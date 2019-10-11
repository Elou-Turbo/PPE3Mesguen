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
        Me.DteTournee = New System.Windows.Forms.Label()
        Me.NomChauf = New System.Windows.Forms.Label()
        Me.ImmatVehi = New System.Windows.Forms.Label()
        Me.PriseCharge = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DteTournee
        '
        Me.DteTournee.AutoSize = True
        Me.DteTournee.Location = New System.Drawing.Point(11, 13)
        Me.DteTournee.Name = "DteTournee"
        Me.DteTournee.Size = New System.Drawing.Size(30, 13)
        Me.DteTournee.TabIndex = 0
        Me.DteTournee.Text = "Date"
        '
        'NomChauf
        '
        Me.NomChauf.AutoSize = True
        Me.NomChauf.Location = New System.Drawing.Point(12, 44)
        Me.NomChauf.Name = "NomChauf"
        Me.NomChauf.Size = New System.Drawing.Size(53, 13)
        Me.NomChauf.TabIndex = 1
        Me.NomChauf.Text = "Chauffeur"
        '
        'ImmatVehi
        '
        Me.ImmatVehi.AutoSize = True
        Me.ImmatVehi.Location = New System.Drawing.Point(15, 76)
        Me.ImmatVehi.Name = "ImmatVehi"
        Me.ImmatVehi.Size = New System.Drawing.Size(48, 13)
        Me.ImmatVehi.TabIndex = 2
        Me.ImmatVehi.Text = "Véhicule"
        '
        'PriseCharge
        '
        Me.PriseCharge.AutoSize = True
        Me.PriseCharge.Location = New System.Drawing.Point(16, 102)
        Me.PriseCharge.Name = "PriseCharge"
        Me.PriseCharge.Size = New System.Drawing.Size(86, 13)
        Me.PriseCharge.TabIndex = 3
        Me.PriseCharge.Text = "Pris en charge le"
        '
        'Comment
        '
        Me.Comment.AutoSize = True
        Me.Comment.Location = New System.Drawing.Point(19, 128)
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(68, 13)
        Me.Comment.TabIndex = 4
        Me.Comment.Text = "Commentaire"
        '
        'AC12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.PriseCharge)
        Me.Controls.Add(Me.ImmatVehi)
        Me.Controls.Add(Me.NomChauf)
        Me.Controls.Add(Me.DteTournee)
        Me.Name = "AC12"
        Me.Text = "AC12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DteTournee As System.Windows.Forms.Label
    Friend WithEvents NomChauf As System.Windows.Forms.Label
    Friend WithEvents ImmatVehi As System.Windows.Forms.Label
    Friend WithEvents PriseCharge As System.Windows.Forms.Label
    Friend WithEvents Comment As System.Windows.Forms.Label
End Class
