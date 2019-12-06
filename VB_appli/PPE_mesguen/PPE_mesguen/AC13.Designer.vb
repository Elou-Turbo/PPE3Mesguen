<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AC13L1 = New System.Windows.Forms.Label()
        Me.AC13L2 = New System.Windows.Forms.Label()
        Me.AC13L3 = New System.Windows.Forms.Label()
        Me.AC13L4 = New System.Windows.Forms.Label()
        Me.AC13L6 = New System.Windows.Forms.Label()
        Me.AC13TB = New System.Windows.Forms.TextBox()
        Me.AC13DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.AC13DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.AC13B1 = New System.Windows.Forms.Button()
        Me.AC13B2 = New System.Windows.Forms.Button()
        Me.AC13LB = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AC13L1
        '
        Me.AC13L1.AutoSize = True
        Me.AC13L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC13L1.Location = New System.Drawing.Point(63, 9)
        Me.AC13L1.Name = "AC13L1"
        Me.AC13L1.Size = New System.Drawing.Size(128, 25)
        Me.AC13L1.TabIndex = 0
        Me.AC13L1.Text = "Ajout d'Etape"
        '
        'AC13L2
        '
        Me.AC13L2.AutoSize = True
        Me.AC13L2.Location = New System.Drawing.Point(12, 44)
        Me.AC13L2.Name = "AC13L2"
        Me.AC13L2.Size = New System.Drawing.Size(33, 13)
        Me.AC13L2.TabIndex = 2
        Me.AC13L2.Text = "Lieu :"
        '
        'AC13L3
        '
        Me.AC13L3.AutoSize = True
        Me.AC13L3.Location = New System.Drawing.Point(12, 114)
        Me.AC13L3.Name = "AC13L3"
        Me.AC13L3.Size = New System.Drawing.Size(114, 13)
        Me.AC13L3.TabIndex = 3
        Me.AC13L3.Text = "Rendez-vous entre le :"
        '
        'AC13L4
        '
        Me.AC13L4.AutoSize = True
        Me.AC13L4.Location = New System.Drawing.Point(12, 148)
        Me.AC13L4.Name = "AC13L4"
        Me.AC13L4.Size = New System.Drawing.Size(34, 13)
        Me.AC13L4.TabIndex = 4
        Me.AC13L4.Text = "Et le :"
        '
        'AC13L6
        '
        Me.AC13L6.AutoSize = True
        Me.AC13L6.Location = New System.Drawing.Point(12, 186)
        Me.AC13L6.Name = "AC13L6"
        Me.AC13L6.Size = New System.Drawing.Size(74, 13)
        Me.AC13L6.TabIndex = 5
        Me.AC13L6.Text = "Commentaire :"
        '
        'AC13TB
        '
        Me.AC13TB.Location = New System.Drawing.Point(92, 183)
        Me.AC13TB.Multiline = True
        Me.AC13TB.Name = "AC13TB"
        Me.AC13TB.Size = New System.Drawing.Size(141, 52)
        Me.AC13TB.TabIndex = 6
        '
        'AC13DTP1
        '
        Me.AC13DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AC13DTP1.Location = New System.Drawing.Point(132, 114)
        Me.AC13DTP1.Name = "AC13DTP1"
        Me.AC13DTP1.Size = New System.Drawing.Size(96, 20)
        Me.AC13DTP1.TabIndex = 7
        '
        'AC13DTP2
        '
        Me.AC13DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AC13DTP2.Location = New System.Drawing.Point(132, 148)
        Me.AC13DTP2.Name = "AC13DTP2"
        Me.AC13DTP2.Size = New System.Drawing.Size(96, 20)
        Me.AC13DTP2.TabIndex = 8
        '
        'AC13B1
        '
        Me.AC13B1.Location = New System.Drawing.Point(31, 252)
        Me.AC13B1.Name = "AC13B1"
        Me.AC13B1.Size = New System.Drawing.Size(79, 24)
        Me.AC13B1.TabIndex = 12
        Me.AC13B1.Text = "Valider"
        Me.AC13B1.UseVisualStyleBackColor = True
        '
        'AC13B2
        '
        Me.AC13B2.Location = New System.Drawing.Point(150, 253)
        Me.AC13B2.Name = "AC13B2"
        Me.AC13B2.Size = New System.Drawing.Size(83, 23)
        Me.AC13B2.TabIndex = 13
        Me.AC13B2.Text = "Retour"
        Me.AC13B2.UseVisualStyleBackColor = True
        '
        'AC13LB
        '
        Me.AC13LB.FormattingEnabled = True
        Me.AC13LB.Location = New System.Drawing.Point(68, 44)
        Me.AC13LB.Name = "AC13LB"
        Me.AC13LB.Size = New System.Drawing.Size(165, 56)
        Me.AC13LB.TabIndex = 14
        '
        'AC13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(280, 307)
        Me.Controls.Add(Me.AC13LB)
        Me.Controls.Add(Me.AC13B2)
        Me.Controls.Add(Me.AC13B1)
        Me.Controls.Add(Me.AC13DTP2)
        Me.Controls.Add(Me.AC13DTP1)
        Me.Controls.Add(Me.AC13TB)
        Me.Controls.Add(Me.AC13L6)
        Me.Controls.Add(Me.AC13L4)
        Me.Controls.Add(Me.AC13L3)
        Me.Controls.Add(Me.AC13L2)
        Me.Controls.Add(Me.AC13L1)
        Me.Name = "AC13"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AC13L1 As System.Windows.Forms.Label
    Friend WithEvents AC13L2 As System.Windows.Forms.Label
    Friend WithEvents AC13L3 As System.Windows.Forms.Label
    Friend WithEvents AC13L4 As System.Windows.Forms.Label
    Friend WithEvents AC13L6 As System.Windows.Forms.Label
    Friend WithEvents AC13TB As System.Windows.Forms.TextBox
    Friend WithEvents AC13DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13B1 As System.Windows.Forms.Button
    Friend WithEvents AC13B2 As System.Windows.Forms.Button
    Friend WithEvents AC13LB As System.Windows.Forms.ListBox

End Class
