<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHL = New System.Windows.Forms.Label()
        Me.lblFA = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHL = New System.Windows.Forms.TextBox()
        Me.txtFA = New System.Windows.Forms.TextBox()
        Me.txtLO = New System.Windows.Forms.TextBox()
        Me.txtMA = New System.Windows.Forms.TextBox()
        Me.txtS3 = New System.Windows.Forms.TextBox()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.txtS1 = New System.Windows.Forms.TextBox()
        Me.lblMA = New System.Windows.Forms.Label()
        Me.lblLO = New System.Windows.Forms.Label()
        Me.lblS3 = New System.Windows.Forms.Label()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lvlAvg = New System.Windows.Forms.Label()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.txtAPS = New System.Windows.Forms.TextBox()
        Me.lblAPS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name:"
        '
        'lblHL
        '
        Me.lblHL.AutoSize = True
        Me.lblHL.Location = New System.Drawing.Point(31, 66)
        Me.lblHL.Name = "lblHL"
        Me.lblHL.Size = New System.Drawing.Size(34, 20)
        Me.lblHL.TabIndex = 1
        Me.lblHL.Text = "HL:"
        '
        'lblFA
        '
        Me.lblFA.AutoSize = True
        Me.lblFA.Location = New System.Drawing.Point(31, 95)
        Me.lblFA.Name = "lblFA"
        Me.lblFA.Size = New System.Drawing.Size(34, 20)
        Me.lblFA.TabIndex = 2
        Me.lblFA.Text = "FA:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(102, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 26)
        Me.txtName.TabIndex = 3
        '
        'txtHL
        '
        Me.txtHL.Location = New System.Drawing.Point(79, 60)
        Me.txtHL.Name = "txtHL"
        Me.txtHL.Size = New System.Drawing.Size(40, 26)
        Me.txtHL.TabIndex = 4
        '
        'txtFA
        '
        Me.txtFA.Location = New System.Drawing.Point(79, 92)
        Me.txtFA.Name = "txtFA"
        Me.txtFA.Size = New System.Drawing.Size(40, 26)
        Me.txtFA.TabIndex = 5
        '
        'txtLO
        '
        Me.txtLO.Location = New System.Drawing.Point(79, 156)
        Me.txtLO.Name = "txtLO"
        Me.txtLO.Size = New System.Drawing.Size(40, 26)
        Me.txtLO.TabIndex = 7
        '
        'txtMA
        '
        Me.txtMA.Location = New System.Drawing.Point(79, 124)
        Me.txtMA.Name = "txtMA"
        Me.txtMA.Size = New System.Drawing.Size(40, 26)
        Me.txtMA.TabIndex = 6
        '
        'txtS3
        '
        Me.txtS3.Location = New System.Drawing.Point(79, 252)
        Me.txtS3.Name = "txtS3"
        Me.txtS3.Size = New System.Drawing.Size(40, 26)
        Me.txtS3.TabIndex = 10
        '
        'txtS2
        '
        Me.txtS2.Location = New System.Drawing.Point(79, 220)
        Me.txtS2.Name = "txtS2"
        Me.txtS2.Size = New System.Drawing.Size(40, 26)
        Me.txtS2.TabIndex = 9
        '
        'txtS1
        '
        Me.txtS1.Location = New System.Drawing.Point(79, 188)
        Me.txtS1.Name = "txtS1"
        Me.txtS1.Size = New System.Drawing.Size(40, 26)
        Me.txtS1.TabIndex = 8
        '
        'lblMA
        '
        Me.lblMA.AutoSize = True
        Me.lblMA.Location = New System.Drawing.Point(30, 127)
        Me.lblMA.Name = "lblMA"
        Me.lblMA.Size = New System.Drawing.Size(37, 20)
        Me.lblMA.TabIndex = 13
        Me.lblMA.Text = "MA:"
        '
        'lblLO
        '
        Me.lblLO.AutoSize = True
        Me.lblLO.Location = New System.Drawing.Point(30, 159)
        Me.lblLO.Name = "lblLO"
        Me.lblLO.Size = New System.Drawing.Size(34, 20)
        Me.lblLO.TabIndex = 12
        Me.lblLO.Text = "LO:"
        '
        'lblS3
        '
        Me.lblS3.AutoSize = True
        Me.lblS3.Location = New System.Drawing.Point(30, 255)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(33, 20)
        Me.lblS3.TabIndex = 16
        Me.lblS3.Text = "S3:"
        '
        'lblS2
        '
        Me.lblS2.AutoSize = True
        Me.lblS2.Location = New System.Drawing.Point(31, 223)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(33, 20)
        Me.lblS2.TabIndex = 15
        Me.lblS2.Text = "S2:"
        '
        'lblS1
        '
        Me.lblS1.AutoSize = True
        Me.lblS1.Location = New System.Drawing.Point(30, 191)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(33, 20)
        Me.lblS1.TabIndex = 14
        Me.lblS1.Text = "S1:"
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(125, 60)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(115, 218)
        Me.btnCal.TabIndex = 19
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lvlAvg
        '
        Me.lvlAvg.AutoSize = True
        Me.lvlAvg.Location = New System.Drawing.Point(246, 92)
        Me.lvlAvg.Name = "lvlAvg"
        Me.lvlAvg.Size = New System.Drawing.Size(72, 20)
        Me.lvlAvg.TabIndex = 20
        Me.lvlAvg.Text = "Average:"
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(250, 121)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.ReadOnly = True
        Me.txtAvg.Size = New System.Drawing.Size(68, 26)
        Me.txtAvg.TabIndex = 21
        '
        'txtAPS
        '
        Me.txtAPS.Location = New System.Drawing.Point(250, 217)
        Me.txtAPS.Name = "txtAPS"
        Me.txtAPS.ReadOnly = True
        Me.txtAPS.Size = New System.Drawing.Size(68, 26)
        Me.txtAPS.TabIndex = 23
        '
        'lblAPS
        '
        Me.lblAPS.AutoSize = True
        Me.lblAPS.Location = New System.Drawing.Point(261, 188)
        Me.lblAPS.Name = "lblAPS"
        Me.lblAPS.Size = New System.Drawing.Size(45, 20)
        Me.lblAPS.TabIndex = 22
        Me.lblAPS.Text = "APS:"
        '
        'GradeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 304)
        Me.Controls.Add(Me.txtAPS)
        Me.Controls.Add(Me.lblAPS)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.lvlAvg)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblS3)
        Me.Controls.Add(Me.lblS2)
        Me.Controls.Add(Me.lblS1)
        Me.Controls.Add(Me.lblMA)
        Me.Controls.Add(Me.lblLO)
        Me.Controls.Add(Me.txtS3)
        Me.Controls.Add(Me.txtS2)
        Me.Controls.Add(Me.txtS1)
        Me.Controls.Add(Me.txtLO)
        Me.Controls.Add(Me.txtMA)
        Me.Controls.Add(Me.txtFA)
        Me.Controls.Add(Me.txtHL)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblFA)
        Me.Controls.Add(Me.lblHL)
        Me.Controls.Add(Me.lblName)
        Me.Name = "GradeCalculator"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHL As Label
    Friend WithEvents lblFA As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHL As TextBox
    Friend WithEvents txtFA As TextBox
    Friend WithEvents txtLO As TextBox
    Friend WithEvents txtMA As TextBox
    Friend WithEvents txtS3 As TextBox
    Friend WithEvents txtS2 As TextBox
    Friend WithEvents txtS1 As TextBox
    Friend WithEvents lblMA As Label
    Friend WithEvents lblLO As Label
    Friend WithEvents lblS3 As Label
    Friend WithEvents lblS2 As Label
    Friend WithEvents lblS1 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents lvlAvg As Label
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents txtAPS As TextBox
    Friend WithEvents lblAPS As Label
End Class
