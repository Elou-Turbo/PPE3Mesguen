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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ListNomChauf = New System.Windows.Forms.ListBox()
        Me.ListImmat = New System.Windows.Forms.ListBox()
        Me.CommentaireTournee = New System.Windows.Forms.TextBox()
        Me.ButtonValidation = New System.Windows.Forms.Button()
        Me.ButtonAnnulation = New System.Windows.Forms.Button()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.ListLieuEtape = New System.Windows.Forms.DataGridView()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        CType(Me.ListLieuEtape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(139, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORGANISATION DE LA TOURNEE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chauffeur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Véhicule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pris en charge le"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Commentaire"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Etapes"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 123)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(115, 239)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'ListNomChauf
        '
        Me.ListNomChauf.FormattingEnabled = True
        Me.ListNomChauf.Location = New System.Drawing.Point(115, 164)
        Me.ListNomChauf.Name = "ListNomChauf"
        Me.ListNomChauf.Size = New System.Drawing.Size(133, 17)
        Me.ListNomChauf.TabIndex = 9
        '
        'ListImmat
        '
        Me.ListImmat.FormattingEnabled = True
        Me.ListImmat.Location = New System.Drawing.Point(115, 203)
        Me.ListImmat.Name = "ListImmat"
        Me.ListImmat.Size = New System.Drawing.Size(133, 17)
        Me.ListImmat.TabIndex = 10
        '
        'CommentaireTournee
        '
        Me.CommentaireTournee.Location = New System.Drawing.Point(114, 284)
        Me.CommentaireTournee.Multiline = True
        Me.CommentaireTournee.Name = "CommentaireTournee"
        Me.CommentaireTournee.Size = New System.Drawing.Size(143, 71)
        Me.CommentaireTournee.TabIndex = 11
        '
        'ButtonValidation
        '
        Me.ButtonValidation.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonValidation.Location = New System.Drawing.Point(76, 375)
        Me.ButtonValidation.Name = "ButtonValidation"
        Me.ButtonValidation.Size = New System.Drawing.Size(87, 24)
        Me.ButtonValidation.TabIndex = 12
        Me.ButtonValidation.Text = "Valider"
        Me.ButtonValidation.UseVisualStyleBackColor = False
        '
        'ButtonAnnulation
        '
        Me.ButtonAnnulation.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAnnulation.Location = New System.Drawing.Point(183, 375)
        Me.ButtonAnnulation.Name = "ButtonAnnulation"
        Me.ButtonAnnulation.Size = New System.Drawing.Size(87, 26)
        Me.ButtonAnnulation.TabIndex = 13
        Me.ButtonAnnulation.Text = "Annuler"
        Me.ButtonAnnulation.UseVisualStyleBackColor = False
        '
        'ButtonAjout
        '
        Me.ButtonAjout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAjout.Location = New System.Drawing.Point(318, 277)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(87, 26)
        Me.ButtonAjout.TabIndex = 14
        Me.ButtonAjout.Text = "Ajouter"
        Me.ButtonAjout.UseVisualStyleBackColor = False
        '
        'ListLieuEtape
        '
        Me.ListLieuEtape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListLieuEtape.Location = New System.Drawing.Point(318, 105)
        Me.ListLieuEtape.Name = "ListLieuEtape"
        Me.ListLieuEtape.Size = New System.Drawing.Size(309, 131)
        Me.ListLieuEtape.TabIndex = 15
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSupprimer.Location = New System.Drawing.Point(540, 277)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(87, 26)
        Me.ButtonSupprimer.TabIndex = 16
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = False
        '
        'ButtonModifier
        '
        Me.ButtonModifier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonModifier.Location = New System.Drawing.Point(411, 277)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(87, 26)
        Me.ButtonModifier.TabIndex = 17
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = False
        '
        'AC12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(639, 438)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ListLieuEtape)
        Me.Controls.Add(Me.ButtonAjout)
        Me.Controls.Add(Me.ButtonAnnulation)
        Me.Controls.Add(Me.ButtonValidation)
        Me.Controls.Add(Me.CommentaireTournee)
        Me.Controls.Add(Me.ListImmat)
        Me.Controls.Add(Me.ListNomChauf)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AC12"
        Me.Text = "Organisation de la tournée"
        CType(Me.ListLieuEtape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListNomChauf As System.Windows.Forms.ListBox
    Friend WithEvents ListImmat As System.Windows.Forms.ListBox
    Friend WithEvents CommentaireTournee As System.Windows.Forms.TextBox
    Friend WithEvents ButtonValidation As System.Windows.Forms.Button
    Friend WithEvents ButtonAnnulation As System.Windows.Forms.Button
    Friend WithEvents ButtonAjout As System.Windows.Forms.Button
    Friend WithEvents ListLieuEtape As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSupprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonModifier As System.Windows.Forms.Button
End Class
