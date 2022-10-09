Public Class AGClass
    Public pop As New List(Of Integer) 'Lista de População - 
    Public nbits As Integer = CInt(AG.txtNbits.Text) 'Número de Bit´s (Genes)
    Public limSup As Integer = CInt(AG.txtLimiteSup.Text) 'Limte Superior
    Public limInf As Integer = CInt(AG.txtLimiteInf.Text) 'Limite Inferior
    Public popSz As Integer = 50 'Tamanho Limite da População - Fixo
    Public pc As Double = AG.nCruz.Value 'Probabilidade de Cruzamento - Fixa 0.6
    Public pm As Double = AG.nMut.Value 'Probabilidade de Mutação - Fixa 0.01 
    Private totalFitness As Double = 0 'Total de Aptidão
    Public rand As System.Random = New System.Random() 'Função Randômica
    Public fitness As New List(Of Double) 'Aptidão - Lista de Double
    Public iProb As New List(Of Double) 'Probabilidade - Lista de Double Usado na Roleta
    Public acumProb As New List(Of Double) 'Probabilidade Acumulada - Lista de Double Usado na Roleta
    Public geration As Integer = 1 'Start de Geração -1 Porque? Contador do Looping

    Sub AgClass()
        '=Propriedades do Indivíduo (Gene)
        'Método que inicializa o AG
        rand = New Random()
        pop = New List(Of Integer)
        Dim fitness = New List(Of Double)
        iProb = New List(Of Double)
        acumProb = New List(Of Double)
    End Sub

    'Converte Binário para Decimal
    Private Function bin2dec(value As String) As Integer
        Return Convert.ToInt32(value, 2)
    End Function

    'Converte Decimal para Binário (porque e como converter?)
    'Usa para achar o ponto de fazer o cruzamento [0101100|10]
    Private Function dec2bin(value As Integer) As String
        Dim s As String = Convert.ToString(value, 2)
        While s.Length < nbits
            ' ajusta número de casas
            s = Convert.ToString("0"c) & s
        End While
        Return s
    End Function

    'Método que Inicializa População
    Public Sub randPop()

        pop.Clear()  'Limpa a população
        Dim cromo As Integer = 0 'Seta o cromossomo para 0
        Dim max As Integer = CInt(Math.Pow(2, nbits)) - 1 '??Criando a faixa de elementos (exemplo escada)
        For i As Integer = 0 To popSz - 1
            Do
                cromo = rand.[Next](max)
            Loop While pop.IndexOf(cromo) <> -1  'Exemplo do Maicon - SE tiver forma de gerar número aleató
            'rio sem repetir substituir por esta
            'Otimiza eliminando os números repetidos - Melhor explicação
            pop.Add(cromo) 'Adiciona o cromossomo a população
        Next

    End Sub
    'Função de Aptidão - Passada no Exemplo Citado
    'Função de maximização do x - depois multiplicavamos para o 01
    'No AG sempre vai achar a max, para ser min multiplicar por -1
    Public Overridable Function Fnfitness(x As Double) As Double
        ' virtual é pq a função pode ser alterada nas classes herdadas no futuro
        'Return CDbl(Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))))
        'Alterar a função de ftnes
        Return CDbl(f(x) + 3)
        'Os pontos tem que ficar entre 0 e 1 (Exercicio4)
        ' -1 removido maximização -> g(x) = -f(x)
    End Function

    Public Overridable Function f(x As Double) As Double
        ' virtual é pq a função pode ser alterada nas classes herdadas no futuro
        'Return CDbl(Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))))
        'Alterar a função de ftnes
        Return CDbl(x * Math.Sin(10 * Math.PI * x))
        'Os pontos tem que ficar entre 0 e 1 (Exercicio4)
        ' -1 removido maximização -> g(x) = -f(x)
    End Function

    'Função de decodificação do indvíduo
    'Porque decodificar o indivíduo? Indivíuo é = cromossomo
    'Para achar os intervalos possiveis no caso de 1024 entre -512 a 512 (-1) 
    'Neste caso ele ignora a parte negativa (-512) porém ele passa como 0.5 (Fator de PArticionamento
    'Limita a região e setoriza elas atráves de 1024 partes (contando o 0)
    'Porem na hora do calculo ignoramos o 0 (sendo assim 1024-1)
    Public Function decodeInd(ind As Integer) As Double 'O quechega no ind é apopulação (índice int)
        Return CDbl(ind / (Math.Pow(2, nbits) - 1) * (limSup - limInf)) + limInf 'Atribuimos limite inferior, no outro era 0
        'Não muda dentro desse tipo de codificação
        'Passa de um setor para o valor
    End Function


    'Cálculo da Aptidão
    'Usa a função de aptidão.. mas como? e Porque? Ela represnta que cada indivíduo
    'é selecionado por ela
    'È para provar porque um individuo é melhor que o outro 
    'É o cálculo da qualidade 
    'Muitas vezes tem restrições e a função deixa de ser matemática e pode
    'ser um algorítmo (Baseado nas restrições)
    Private Sub CalcFitness()
        Dim x As Double = 0
        Dim fts As Double = 0 'Resultado da FUnção de Aptidão
        totalFitness = 0
        fitness.Clear()
        For Each ind As Integer In pop
            x = decodeInd(ind)
            fts = Fnfitness(x)
            fitness.Add(fts)
            totalFitness += fts
        Next
    End Sub

#Region "Torneio - Função de Seleção"
    'Torneio - Dentro da Seleção
    'Calculo da Probabilidade Individual e Acumulada
    Private Sub CalcProb()
        Dim acum As Double = 0
        Dim p As Double = 0
        iProb.Clear()
        acumProb.Clear()
        For i As Integer = 0 To popSz - 1
            p = CDbl(fitness(i) / totalFitness)
            iProb.Add(p)
            acum += p
            acumProb.Add(acum)
        Next
    End Sub

    'Função de Torneio
    Private Function SelInd() As Integer 'Torneio
        Dim ntor As Integer = 4 'Variável de Número de Elementos no Torneio
        ' Não usa (é para acumular vetor)Dim Vetor(ntor) As Integer 'Criar um vetor que sortei N elementos randomicamente
        Dim inx As Integer = 0 'ìndice criado para sortear o próximo indivíduo
        Dim best As Integer = rand.Next(popSz) 'varíavel do melhor
        For i As Integer = 1 To ntor - 1
            inx = rand.Next(popSz)
            If fitness(best) < fitness(inx) Then
                best = inx
            End If
        Next
        Return best
    End Function
    'select


    'For i  as integer = 0 to ntor -1 -ok
    'index = rand.popsz
    'IF (Ftn < fitness(index)
    'elm = index
    'Ftn = fitness(index)
    'end if
    'next


    ' Função de Seleção  ' Sai função da Roleta
    Private Function SelIndRoleta() As Integer 'Roleta - Não Utilizada
        Dim roleta As Double = rand.NextDouble()
        For i As Integer = 0 To acumProb.Count - 1
            If roleta < acumProb(i) Then
                Return i
            End If
        Next
        Return -1
    End Function
#End Region

#Region "Cruzamento"
    'Função de Cruzamento
    Private Sub Crossover()
        Dim nPop As New List(Of Integer)()
#Region "Elitismo"
        'Elitismo
        'Ordenar(Fitness) OrdeyBy
        'fitness.OrderByDescending(Function(fitness) fitness.ToString).ToList
        'fitness = (From m In fitness Order By m.ToString).ToList() *Walter Linq
        'Função de ordenar (método da bolha)
        Dim tmp As Double
        Dim tmp2 As Integer
        For i As Integer = 0 To popSz - 2
            For j As Integer = i + 1 To popSz - 1
                If fitness(j) > fitness(i) Then 'Ordenar em order crescente >
                    'troca de valores
                    tmp = fitness(i)
                    fitness(i) = fitness(j)
                    fitness(j) = tmp
                    tmp2 = pop(i)
                    pop(i) = pop(j)
                    pop(j) = tmp2
                End If
            Next
        Next

        'Variável de Elite (Dinâmica Número qualter (usou 4 de exemplo)
        'Outro Exemplo elite = 0,06.popsz
        Dim elite As Integer = 1

        'For i as integer = 0 to elite -1 (Só varrer a elite)
        'Vr se vai aceitar elite = 0
        'newpop.add(pop(i))
        'next
        For i As Integer = 0 To elite - 1
            nPop.Add(pop(i))
        Next
#End Region
        CalcProb()

        Dim pai1Idx As Integer = -1
        Dim pai2Idx As Integer = -1
        Dim pntCross As Integer = 0
        Dim fil1 As Integer, fil2 As Integer
        Dim sPai1 As String, sPai2 As String, sFil1 As String, sFil2 As String

        While nPop.Count < popSz
            pai1Idx = -1
            pai2Idx = -1
            While pai1Idx = pai2Idx
                ' envita repetição
                pai1Idx = SelInd()
                pai2Idx = SelInd()
            End While

            If rand.NextDouble() <= pc Then
                ' probabilidade de cruzamento
                pntCross = rand.[Next](1, nbits - 1) 'Localiza a área de corte do cromossomo
                ' cruzar apenas nas intercessões
                sPai1 = dec2bin(pop(pai1Idx))
                sPai2 = dec2bin(pop(pai2Idx))
                sFil1 = sPai1.Substring(0, pntCross) + sPai2.Substring(pntCross, sPai2.Length - pntCross)
                sFil2 = sPai2.Substring(0, pntCross) + sPai1.Substring(pntCross, sPai1.Length - pntCross)

                'Volta de Binário para Decimal
                fil1 = bin2dec(sFil1)
                fil2 = bin2dec(sFil2)
            Else
                fil1 = pop(pai1Idx)
                fil2 = pop(pai2Idx)
            End If

            nPop.Add(fil1)
            nPop.Add(fil2)

        End While
        pop = nPop
    End Sub
#End Region

#Region "Mutação"
    'Função de Mutação
    Private Sub Mutate()
        For i As Integer = 0 To popSz - 1
            For j As Integer = 0 To nbits - 1
                If rand.NextDouble() < pm Then
                    ' prob de mutação
                    ' invert o bit j com XOr (Estudar tabela)
                    pop(i) = pop(i) Xor (1 << j)
                End If
            Next
        Next
    End Sub
#End Region

#Region "Melhor Indivíduo"
    'Verificação do Melhor indivíduo
    'Resultado do Melhor individuo
    Private Function BestIndIdx() As Integer
        Dim bestIdx As Integer = 0
        For i As Integer = 1 To popSz - 1
            If fitness(bestIdx) < fitness(i) Then
                bestIdx = i
            End If
        Next

        Return bestIdx
    End Function


    Public Function bestInd() As Double
        Return CDbl(pop(BestIndIdx()))
    End Function
    'Sai a solução do problema.
    'Melhor função da aptidão.
#End Region

    'Função de Melhor aptidão aplicada para o melhor indivíduo?
    'Ver qual a aptidão do melhor indivíduo
    'identifica as melhoras propriedades do cronossomo que foi selecionado.
    Public Function bestFitness() As Double
        Return CDbl(fitness(BestIndIdx()))
    End Function

#Region "Evolução"
    'evolução por uma geração
    Private Sub evolve()
        If geration = 1 Then 'Otimiza para não ficar mais lento
            CalcFitness() 'Função de apatidão Incial para não calcular o ftnes
        End If
        Crossover() 'Cruzamento - Cria nova população
        Mutate() 'Mutação a nova população
        geration += 1 'Incrementa uma geração
        CalcFitness() 'aplica novamente a função de aptidão na nova população
    End Sub

    'Calcula para várias gerações
    Public Sub evolve(gerations As Integer)
        For i As Integer = 0 To gerations - 1 'Como funciona?
            evolve()
        Next
    End Sub
#End Region
End Class
