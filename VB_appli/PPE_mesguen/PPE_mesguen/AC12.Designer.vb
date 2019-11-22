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
        Me.DateTournee = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelChauf = New System.Windows.Forms.Label()
        Me.LabelVehicule = New System.Windows.Forms.Label()
        Me.PrisEnCharge = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonValidation = New System.Windows.Forms.Button()
        Me.ButtonAnnulation = New System.Windows.Forms.Button()
        Me.IdEtape = New System.Windows.Forms.Label()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.CommentaireTournee = New System.Windows.Forms.TextBox()
        Me.ListNomChauf = New System.Windows.Forms.ComboBox()
        Me.ListImmat = New System.Windows.Forms.ComboBox()
        Me.DataSet1 = New PPE_mesguen.DataSet1()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTournee
        '
        Me.DateTournee.AutoSize = True
        Me.DateTournee.Location = New System.Drawing.Point(12, 129)
        Me.DateTournee.Name = "DateTournee"
        Me.DateTournee.Size = New System.Drawing.Size(30, 13)
        Me.DateTournee.TabIndex = 0
        Me.DateTournee.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 123)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'LabelChauf
        '
        Me.LabelChauf.AutoSize = True
        Me.LabelChauf.Location = New System.Drawing.Point(12, 168)
        Me.LabelChauf.Name = "LabelChauf"
        Me.LabelChauf.Size = New System.Drawing.Size(53, 13)
        Me.LabelChauf.TabIndex = 2
        Me.LabelChauf.Text = "Chauffeur"
        '
        'LabelVehicule
        '
        Me.LabelVehicule.AutoSize = True
        Me.LabelVehicule.Location = New System.Drawing.Point(12, 209)
        Me.LabelVehicule.Name = "LabelVehicule"
        Me.LabelVehicule.Size = New System.Drawing.Size(48, 13)
        Me.LabelVehicule.TabIndex = 4
        Me.LabelVehicule.Text = "Véhicule"
        '
        'PrisEnCharge
        '
        Me.PrisEnCharge.AutoSize = True
        Me.PrisEnCharge.Location = New System.Drawing.Point(12, 249)
        Me.PrisEnCharge.Name = "PrisEnCharge"
        Me.PrisEnCharge.Size = New System.Drawing.Size(86, 13)
        Me.PrisEnCharge.TabIndex = 6
        Me.PrisEnCharge.Text = "Pris en charge le"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker2.Location = New System.Drawing.Point(115, 242)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Commentaire"
        '
        'ButtonValidation
        '
        Me.ButtonValidation.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonValidation.Location = New System.Drawing.Point(76, 375)
        Me.ButtonValidation.Name = "ButtonValidation"
        Me.ButtonValidation.Size = New System.Drawing.Size(87, 24)
        Me.ButtonValidation.TabIndex = 9
        Me.ButtonValidation.Text = "Valider"
        Me.ButtonValidation.UseVisualStyleBackColor = False
        '
        'ButtonAnnulation
        '
        Me.ButtonAnnulation.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAnnulation.Location = New System.Drawing.Point(187, 373)
        Me.ButtonAnnulation.Name = "ButtonAnnulation"
        Me.ButtonAnnulation.Size = New System.Drawing.Size(87, 26)
        Me.ButtonAnnulation.TabIndex = 10
        Me.ButtonAnnulation.Text = "Annuler"
        Me.ButtonAnnulation.UseVisualStyleBackColor = False
        '
        'IdEtape
        '
        Me.IdEtape.AutoSize = True
        Me.IdEtape.Location = New System.Drawing.Point(315, 66)
        Me.IdEtape.Name = "IdEtape"
        Me.IdEtape.Size = New System.Drawing.Size(40, 13)
        Me.IdEtape.TabIndex = 11
        Me.IdEtape.Text = "Etapes"
        '
        'ButtonAjout
        '
        Me.ButtonAjout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAjout.Location = New System.Drawing.Point(483, 277)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(87, 26)
        Me.ButtonAjout.TabIndex = 12
        Me.ButtonAjout.Text = "Ajouter"
        Me.ButtonAjout.UseVisualStyleBackColor = False
        '
        'CommentaireTournee
        '
        Me.CommentaireTournee.Location = New System.Drawing.Point(114, 284)
        Me.CommentaireTournee.Multiline = True
        Me.CommentaireTournee.Name = "CommentaireTournee"
        Me.CommentaireTournee.Size = New System.Drawing.Size(143, 71)
        Me.CommentaireTournee.TabIndex = 14
        '
        'ListNomChauf
        '
        Me.ListNomChauf.FormattingEnabled = True
        Me.ListNomChauf.Location = New System.Drawing.Point(114, 160)
        Me.ListNomChauf.Name = "ListNomChauf"
        Me.ListNomChauf.Size = New System.Drawing.Size(93, 21)
        Me.ListNomChauf.TabIndex = 15
        '
        'ListImmat
        '
        Me.ListImmat.FormattingEnabled = True
        Me.ListImmat.Location = New System.Drawing.Point(115, 201)
        Me.ListImmat.Name = "ListImmat"
        Me.ListImmat.Size = New System.Drawing.Size(93, 21)
        Me.ListImmat.TabIndex = 16
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(318, 123)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(94, 17)
        Me.ListBox1.TabIndex = 17
        '
        'AC12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 438)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListImmat)
        Me.Controls.Add(Me.ListNomChauf)
        Me.Controls.Add(Me.CommentaireTournee)
        Me.Controls.Add(Me.ButtonAjout)
        Me.Controls.Add(Me.IdEtape)
        Me.Controls.Add(Me.ButtonAnnulation)
        Me.Controls.Add(Me.ButtonValidation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.PrisEnCharge)
        Me.Controls.Add(Me.LabelVehicule)
        Me.Controls.Add(Me.LabelChauf)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTournee)
        Me.Name = "AC12"
        Me.Text = "AC12"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTournee As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelChauf As System.Windows.Forms.Label
    Friend WithEvents LabelVehicule As System.Windows.Forms.Label
    Friend WithEvents PrisEnCharge As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonValidation As System.Windows.Forms.Button
    Friend WithEvents ButtonAnnulation As System.Windows.Forms.Button
    Friend WithEvents IdEtape As System.Windows.Forms.Label
    Friend WithEvents ButtonAjout As System.Windows.Forms.Button
    Friend WithEvents CommentaireTournee As System.Windows.Forms.TextBox
    Friend WithEvents ListNomChauf As System.Windows.Forms.ComboBox
    Friend WithEvents ListImmat As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As PPE_mesguen.DataSet1
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
