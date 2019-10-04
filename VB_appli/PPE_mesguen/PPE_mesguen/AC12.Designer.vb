<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC12
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DteTournee = New System.Windows.Forms.Label()
        Me.NomChauf = New System.Windows.Forms.Label()
        Me.ImmatVéhi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DteTournee
        '
        Me.DteTournee.AutoSize = True
        Me.DteTournee.Location = New System.Drawing.Point(26, 39)
        Me.DteTournee.Name = "DteTournee"
        Me.DteTournee.Size = New System.Drawing.Size(30, 13)
        Me.DteTournee.TabIndex = 1
        Me.DteTournee.Text = "Date"
        '
        'NomChauf
        '
        Me.NomChauf.AutoSize = True
        Me.NomChauf.Location = New System.Drawing.Point(26, 71)
        Me.NomChauf.Name = "NomChauf"
        Me.NomChauf.Size = New System.Drawing.Size(53, 13)
        Me.NomChauf.TabIndex = 2
        Me.NomChauf.Text = "Chauffeur"
        '
        'ImmatVéhi
        '
        Me.ImmatVéhi.AutoSize = True
        Me.ImmatVéhi.Location = New System.Drawing.Point(29, 104)
        Me.ImmatVéhi.Name = "ImmatVéhi"
        Me.ImmatVéhi.Size = New System.Drawing.Size(48, 13)
        Me.ImmatVéhi.TabIndex = 3
        Me.ImmatVéhi.Text = "Véhicule"
        '
        'AC12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 352)
        Me.Controls.Add(Me.ImmatVéhi)
        Me.Controls.Add(Me.NomChauf)
        Me.Controls.Add(Me.DteTournee)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "AC12"
        Me.Text = "AC12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DteTournee As System.Windows.Forms.Label
    Friend WithEvents NomChauf As System.Windows.Forms.Label
    Friend WithEvents ImmatVéhi As System.Windows.Forms.Label
End Class
