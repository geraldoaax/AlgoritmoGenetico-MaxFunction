<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtEvolve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFitness = New System.Windows.Forms.TextBox()
        Me.agChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNbits = New System.Windows.Forms.TextBox()
        Me.mpcl = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLimiteSup = New System.Windows.Forms.TextBox()
        Me.txtLimiteInf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nCruz = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nMut = New System.Windows.Forms.NumericUpDown()
        CType(Me.agChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mpcl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCruz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(749, 9)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(131, 40)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular AG"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtEvolve
        '
        Me.txtEvolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvolve.Location = New System.Drawing.Point(134, 16)
        Me.txtEvolve.Name = "txtEvolve"
        Me.txtEvolve.Size = New System.Drawing.Size(49, 30)
        Me.txtEvolve.TabIndex = 1
        Me.txtEvolve.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gerações ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X = "
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(271, 16)
        Me.txtX.Name = "txtX"
        Me.txtX.ReadOnly = True
        Me.txtX.Size = New System.Drawing.Size(61, 30)
        Me.txtX.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "f(x) = "
        '
        'txtfx
        '
        Me.txtfx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfx.Location = New System.Drawing.Point(410, 16)
        Me.txtfx.Name = "txtfx"
        Me.txtfx.ReadOnly = True
        Me.txtfx.Size = New System.Drawing.Size(106, 30)
        Me.txtfx.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fitness ="
        '
        'txtFitness
        '
        Me.txtFitness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitness.Location = New System.Drawing.Point(602, 16)
        Me.txtFitness.Name = "txtFitness"
        Me.txtFitness.ReadOnly = True
        Me.txtFitness.Size = New System.Drawing.Size(127, 30)
        Me.txtFitness.TabIndex = 7
        '
        'agChart
        '
        Me.agChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.agChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.agChart.Legends.Add(Legend1)
        Me.agChart.Location = New System.Drawing.Point(3, 81)
        Me.agChart.Name = "agChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.agChart.Series.Add(Series1)
        Me.agChart.Size = New System.Drawing.Size(889, 359)
        Me.agChart.TabIndex = 9
        Me.agChart.Text = "AG"
        Title1.Name = "Title1"
        Title1.Text = "Solução Ótima"
        Me.agChart.Titles.Add(Title1)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bit´s (Genes) ="
        '
        'txtNbits
        '
        Me.txtNbits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbits.Location = New System.Drawing.Point(134, 48)
        Me.txtNbits.Name = "txtNbits"
        Me.txtNbits.Size = New System.Drawing.Size(49, 30)
        Me.txtNbits.TabIndex = 11
        Me.txtNbits.Text = "10"
        '
        'mpcl
        '
        Me.mpcl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.mpcl.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.mpcl.Legends.Add(Legend2)
        Me.mpcl.Location = New System.Drawing.Point(3, 446)
        Me.mpcl.Name = "mpcl"
        Me.mpcl.Size = New System.Drawing.Size(889, 373)
        Me.mpcl.TabIndex = 13
        Title2.Name = "AG"
        Title2.Text = "Gráfico de Performance"
        Me.mpcl.Titles.Add(Title2)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(189, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "LimSup ="
        '
        'txtLimiteSup
        '
        Me.txtLimiteSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteSup.Location = New System.Drawing.Point(271, 48)
        Me.txtLimiteSup.Name = "txtLimiteSup"
        Me.txtLimiteSup.Size = New System.Drawing.Size(61, 30)
        Me.txtLimiteSup.TabIndex = 16
        Me.txtLimiteSup.Text = "2"
        '
        'txtLimiteInf
        '
        Me.txtLimiteInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteInf.Location = New System.Drawing.Point(410, 48)
        Me.txtLimiteInf.Name = "txtLimiteInf"
        Me.txtLimiteInf.Size = New System.Drawing.Size(59, 30)
        Me.txtLimiteInf.TabIndex = 18
        Me.txtLimiteInf.Text = "-1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(338, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "LimInf ="
        '
        'nCruz
        '
        Me.nCruz.DecimalPlaces = 2
        Me.nCruz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCruz.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nCruz.Location = New System.Drawing.Point(540, 49)
        Me.nCruz.Name = "nCruz"
        Me.nCruz.Size = New System.Drawing.Size(63, 30)
        Me.nCruz.TabIndex = 19
        Me.nCruz.Value = New Decimal(New Integer() {6, 0, 0, 65536})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cruz. ="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(609, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Mut. ="
        '
        'nMut
        '
        Me.nMut.DecimalPlaces = 2
        Me.nMut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMut.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nMut.Location = New System.Drawing.Point(663, 48)
        Me.nMut.Name = "nMut"
        Me.nMut.Size = New System.Drawing.Size(63, 30)
        Me.nMut.TabIndex = 22
        Me.nMut.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'AG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 831)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nMut)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nCruz)
        Me.Controls.Add(Me.txtLimiteInf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLimiteSup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mpcl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNbits)
        Me.Controls.Add(Me.agChart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFitness)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEvolve)
        Me.Controls.Add(Me.btnCalcular)
        Me.MaximizeBox = False
        Me.Name = "AG"
        Me.Text = "AG"
        CType(Me.agChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mpcl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCruz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtEvolve As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFitness As TextBox
    Friend WithEvents agChart As DataVisualization.Charting.Chart
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNbits As TextBox
    Friend WithEvents mpcl As DataVisualization.Charting.Chart
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLimiteSup As TextBox
    Friend WithEvents txtLimiteInf As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nCruz As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nMut As NumericUpDown
End Class
