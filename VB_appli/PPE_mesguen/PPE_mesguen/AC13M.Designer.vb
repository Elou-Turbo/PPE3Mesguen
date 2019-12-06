<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13M
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AC13LB = New System.Windows.Forms.ListBox()
        Me.AC13MB2 = New System.Windows.Forms.Button()
        Me.AC13MB1 = New System.Windows.Forms.Button()
        Me.AC13DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.AC13DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.AC13TB = New System.Windows.Forms.TextBox()
        Me.AC13L6 = New System.Windows.Forms.Label()
        Me.AC13L4 = New System.Windows.Forms.Label()
        Me.AC13L3 = New System.Windows.Forms.Label()
        Me.AC13L2 = New System.Windows.Forms.Label()
        Me.AC13L1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(107, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(399, 181)
        Me.DataGridView1.TabIndex = 0
        '
        'AC13LB
        '
        Me.AC13LB.FormattingEnabled = True
        Me.AC13LB.Location = New System.Drawing.Point(217, 268)
        Me.AC13LB.Name = "AC13LB"
        Me.AC13LB.Size = New System.Drawing.Size(181, 56)
        Me.AC13LB.TabIndex = 25
        '
        'AC13MB2
        '
        Me.AC13MB2.Location = New System.Drawing.Point(336, 477)
        Me.AC13MB2.Name = "AC13MB2"
        Me.AC13MB2.Size = New System.Drawing.Size(99, 28)
        Me.AC13MB2.TabIndex = 24
        Me.AC13MB2.Text = "Retour"
        Me.AC13MB2.UseVisualStyleBackColor = True
        '
        'AC13MB1
        '
        Me.AC13MB1.Location = New System.Drawing.Point(140, 470)
        Me.AC13MB1.Name = "AC13MB1"
        Me.AC13MB1.Size = New System.Drawing.Size(95, 29)
        Me.AC13MB1.TabIndex = 23
        Me.AC13MB1.Text = "Valider"
        Me.AC13MB1.UseVisualStyleBackColor = True
        '
        'AC13DTP2
        '
        Me.AC13DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AC13DTP2.Location = New System.Drawing.Point(217, 373)
        Me.AC13DTP2.Name = "AC13DTP2"
        Me.AC13DTP2.Size = New System.Drawing.Size(112, 20)
        Me.AC13DTP2.TabIndex = 22
        '
        'AC13DTP1
        '
        Me.AC13DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AC13DTP1.Location = New System.Drawing.Point(217, 338)
        Me.AC13DTP1.Name = "AC13DTP1"
        Me.AC13DTP1.Size = New System.Drawing.Size(112, 20)
        Me.AC13DTP1.TabIndex = 21
        '
        'AC13TB
        '
        Me.AC13TB.Location = New System.Drawing.Point(217, 407)
        Me.AC13TB.Multiline = True
        Me.AC13TB.Name = "AC13TB"
        Me.AC13TB.Size = New System.Drawing.Size(157, 57)
        Me.AC13TB.TabIndex = 20
        '
        'AC13L6
        '
        Me.AC13L6.AutoSize = True
        Me.AC13L6.Location = New System.Drawing.Point(104, 410)
        Me.AC13L6.Name = "AC13L6"
        Me.AC13L6.Size = New System.Drawing.Size(74, 13)
        Me.AC13L6.TabIndex = 19
        Me.AC13L6.Text = "Commentaire :"
        '
        'AC13L4
        '
        Me.AC13L4.AutoSize = True
        Me.AC13L4.Location = New System.Drawing.Point(104, 379)
        Me.AC13L4.Name = "AC13L4"
        Me.AC13L4.Size = New System.Drawing.Size(34, 13)
        Me.AC13L4.TabIndex = 18
        Me.AC13L4.Text = "Et le :"
        '
        'AC13L3
        '
        Me.AC13L3.AutoSize = True
        Me.AC13L3.Location = New System.Drawing.Point(104, 344)
        Me.AC13L3.Name = "AC13L3"
        Me.AC13L3.Size = New System.Drawing.Size(114, 13)
        Me.AC13L3.TabIndex = 17
        Me.AC13L3.Text = "Rendez-vous entre le :"
        '
        'AC13L2
        '
        Me.AC13L2.AutoSize = True
        Me.AC13L2.Location = New System.Drawing.Point(104, 268)
        Me.AC13L2.Name = "AC13L2"
        Me.AC13L2.Size = New System.Drawing.Size(33, 13)
        Me.AC13L2.TabIndex = 16
        Me.AC13L2.Text = "Lieu :"
        '
        'AC13L1
        '
        Me.AC13L1.AutoSize = True
        Me.AC13L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC13L1.Location = New System.Drawing.Point(232, 205)
        Me.AC13L1.Name = "AC13L1"
        Me.AC13L1.Size = New System.Drawing.Size(187, 25)
        Me.AC13L1.TabIndex = 15
        Me.AC13L1.Text = "Modification d'Etape"
        '
        'AC13M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(683, 640)
        Me.Controls.Add(Me.AC13LB)
        Me.Controls.Add(Me.AC13MB2)
        Me.Controls.Add(Me.AC13MB1)
        Me.Controls.Add(Me.AC13DTP2)
        Me.Controls.Add(Me.AC13DTP1)
        Me.Controls.Add(Me.AC13TB)
        Me.Controls.Add(Me.AC13L6)
        Me.Controls.Add(Me.AC13L4)
        Me.Controls.Add(Me.AC13L3)
        Me.Controls.Add(Me.AC13L2)
        Me.Controls.Add(Me.AC13L1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AC13M"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AC13LB As System.Windows.Forms.ListBox
    Friend WithEvents AC13MB2 As System.Windows.Forms.Button
    Friend WithEvents AC13MB1 As System.Windows.Forms.Button
    Friend WithEvents AC13DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AC13TB As System.Windows.Forms.TextBox
    Friend WithEvents AC13L6 As System.Windows.Forms.Label
    Friend WithEvents AC13L4 As System.Windows.Forms.Label
    Friend WithEvents AC13L3 As System.Windows.Forms.Label
    Friend WithEvents AC13L2 As System.Windows.Forms.Label
    Friend WithEvents AC13L1 As System.Windows.Forms.Label
End Class
