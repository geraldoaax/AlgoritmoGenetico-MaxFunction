Imports System.Windows.Forms.DataVisualization.Charting
Public Class AG

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ag As New AGClass()
        ag.randPop()

        agChart.Series.Clear()
        mpcl.Series.Clear()

        Dim s1 As New Series
        s1.Points.Clear()
        s1.Name = "Função de Aptidão"
        s1.ChartType = SeriesChartType.Line
        agChart.Series.Add(s1)

        Dim s2 As New Series
        s2.Points.Clear()
        s2.Name = "População"
        s2.ChartType = SeriesChartType.Point
        agChart.Series.Add(s2)

        Dim s3 As New Series
        s3.Points.Clear()
        s3.Name = "Média por Ciclo"
        s3.ChartType = SeriesChartType.Point
        mpcl.Series.Add(s3)

        Dim s4 As New Series
        s4.Points.Clear()
        s4.Name = "Média por Melhor Indivíduo"
        s4.ChartType = SeriesChartType.Point
        mpcl.Series.Add(s4)

        'Trocar a plotagem de -1 a 2 (ex 1)
        For i As Integer = -100 To 200 'Aumentar a área de abrangência
            s1.Points.AddXY(i / 100, ag.f(i / 100))
        Next


        For d As Integer = 0 To txtEvolve.Text
            'dgvPopulacao.Rows.Clear()
            s2.Points.Clear()
            System.Threading.Thread.Sleep(100)

            ag.evolve(1)

            txtX.Text = CStr(ag.decodeInd(ag.bestInd()))
            txtfx.Text = CStr(ag.f(ag.decodeInd(ag.bestInd())))
            txtFitness.Text = CStr(ag.bestFitness())

            'X - For de -512 a 512
            'Y - Formula (-)Fnfitness 

            'agChart.Titles.Add("AG")

            'X - Point Função de decodificação do indvíduo
            Dim media As Double = 0
            Dim x As Double = 0

            For i As Integer = 0 To ag.popSz - 1
                x = ag.decodeInd(ag.pop(i))
                media = media + ag.f(i)
                s2.Points.AddXY(x, ag.f(x))
                'dgvPopulacao.Rows.Add(x, ag.f(x))
            Next
            media = media / ag.geration
            s3.Points.AddXY(ag.geration, media)
            s4.Points.AddXY(media, ag.bestInd)
            Application.DoEvents()
        Next
        'Y - Formula (-)Fnfitness 'Configurar como pontos
        'MessageBox.Show(String.Format("X = {0} f(x) = {1} fitness = {2} ", AG.bestInd(), AG.Fnfitness(AG.bestInd()), AG.bestFitness()))



    End Sub

End Class
