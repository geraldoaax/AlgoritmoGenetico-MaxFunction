
## Introdução

Os algoritmos genéticos são muito importantes nos mais variados campos de pesquisa e aplicados em logística, finanças, mineração, etc. A convergência da população para um indivíduo de alta aptidão e a degradação da população quando os critérios de seleção são baixos são problemas comuns desses algoritmos.
Este trabalho consiste em aplicar e avaliar um algoritmo genético básico para a maximização da função f, no intervalo [ -1; 2] e definida por: f(x) = x.sen(10 Π x) usando o método de seleção com torneio e aplicando o elitismo para o cruzamento dos indivíduos.

Seleção por Torneio

O Método de Torneio seleciona aleatoriamente um grupo de N indivíduos da população original e copia o indivíduo com melhor aptidão no grupo de reprodução. Todos os indivíduos são devolvidos à população original. O processo se repete até encher o grupo de reprodução. 

Elitismo

O Elitismo mantém pelo menos uma cópia sem alterações da melhor solução da geração anterior é passada para a nova população, de forma que a melhor solução possa sobreviver às sucessivas gerações.
Basicamente os algoritmos genéticos seguem o seguinte algoritmo generalista:

![alt text](https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction/blob/main/img/estrutura_ag.png)

Figura 1 – Estrutura geral de algoritmos genéticos – Fonte: Catarina, 2005.

Com o desenvolvimento do algoritmo viu-se necessário em equalizar os resultados apresentados para não desprezar os valores negativos acrescentando +3 na f(x) sendo: (f(x) + 3) para gerar o fitness. Com isso houve um deslocamento da função de x gerando o seguinte gráfico:
 
![alt text](https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction/blob/main/img/resultado.png?raw=true)

Figura 2 – Gráfico de Resultados da AG.

![alt text](https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction/blob/main/img/interface.png?raw=true)
 
A figura 3 - Representa a interface completa do problema desenvolvido.

## Conclusão

O Algoritmo Genético conseguiu resolver o problema rapidamente e com uma precisão semelhante a um método exato.

A Computação Evolutiva é deve ser utilizada como mais uma ferramenta para resolução de problemas computacionais, sobretudo quando temos um vasto campo de busca.
Com alterações em probabilidade de cruzamento e mutação o algoritmo se torna menos “viciado” e é interessante os resultados apresentados. Outros valores como número de genes e quantidade da geração tem impacto consideráveis nos resultados apresentados.

![alt text](https://github.com/geraldoaax/https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction/blob/main/img/alteracoes_valores.png?raw=true)
 
Figura 04 – Exemplo de Alterações em Valores de Cruzamento, Mutação, Gerações e Genes.

## Referências Bibliográficas

CATARINA, A.S. Algoritmos evolutivos aplicados ao processo de análise de dados geográficos. São José dos Campos: [s,n], 2005.
BARCELLOS, J. C. H.  Algoritmos genéticos adaptativos: um estudo comparativo. Dissertação de mestrado. Universidade Estadual de São Paulo, Escola Politécnica. São Paulo: 2000


