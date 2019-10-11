<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC11
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
        Me.components = New System.ComponentModel.Container()
        Me.TableTournee = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataSet1 = New PPE_mesguen.DataSet1()
        Me.TOURNEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOURNEETableAdapter = New PPE_mesguen.DataSet1TableAdapters.TOURNEETableAdapter()
        Me.TRNNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHIMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHFIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNDTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableTournee
        '
        Me.TableTournee.AllowUserToAddRows = False
        Me.TableTournee.AllowUserToDeleteRows = False
        Me.TableTournee.AutoGenerateColumns = False
        Me.TableTournee.BackgroundColor = System.Drawing.Color.White
        Me.TableTournee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableTournee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRNNUMDataGridViewTextBoxColumn, Me.VEHIMMATDataGridViewTextBoxColumn, Me.CHFIDDataGridViewTextBoxColumn, Me.TRNCOMMENTAIREDataGridViewTextBoxColumn, Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn, Me.TRNDTEDataGridViewTextBoxColumn})
        Me.TableTournee.DataSource = Me.TOURNEEBindingSource
        Me.TableTournee.Location = New System.Drawing.Point(67, 92)
        Me.TableTournee.Name = "TableTournee"
        Me.TableTournee.ReadOnly = True
        Me.TableTournee.Size = New System.Drawing.Size(844, 376)
        Me.TableTournee.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTE DES TOURNEES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(429, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RETOUR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(942, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "AJOUTER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(942, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 38)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "SUPPRIMER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOURNEEBindingSource
        '
        Me.TOURNEEBindingSource.DataMember = "TOURNEE"
        Me.TOURNEEBindingSource.DataSource = Me.DataSet1
        '
        'TOURNEETableAdapter
        '
        Me.TOURNEETableAdapter.ClearBeforeFill = True
        '
        'TRNNUMDataGridViewTextBoxColumn
        '
        Me.TRNNUMDataGridViewTextBoxColumn.DataPropertyName = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.HeaderText = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.Name = "TRNNUMDataGridViewTextBoxColumn"
        Me.TRNNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VEHIMMATDataGridViewTextBoxColumn
        '
        Me.VEHIMMATDataGridViewTextBoxColumn.DataPropertyName = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.HeaderText = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.Name = "VEHIMMATDataGridViewTextBoxColumn"
        Me.VEHIMMATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CHFIDDataGridViewTextBoxColumn
        '
        Me.CHFIDDataGridViewTextBoxColumn.DataPropertyName = "CHFID"
        Me.CHFIDDataGridViewTextBoxColumn.HeaderText = "CHFID"
        Me.CHFIDDataGridViewTextBoxColumn.Name = "CHFIDDataGridViewTextBoxColumn"
        Me.CHFIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNCOMMENTAIREDataGridViewTextBoxColumn
        '
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "TRNCOMMENTAIRE"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "TRNCOMMENTAIRE"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.Name = "TRNCOMMENTAIREDataGridViewTextBoxColumn"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNPECCHAUFFEURDataGridViewTextBoxColumn
        '
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.DataPropertyName = "TRNPECCHAUFFEUR"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.HeaderText = "TRNPECCHAUFFEUR"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.Name = "TRNPECCHAUFFEURDataGridViewTextBoxColumn"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNDTEDataGridViewTextBoxColumn
        '
        Me.TRNDTEDataGridViewTextBoxColumn.DataPropertyName = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.HeaderText = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.Name = "TRNDTEDataGridViewTextBoxColumn"
        Me.TRNDTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 541)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableTournee)
        Me.Name = "AC11"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableTournee As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As PPE_mesguen.DataSet1
    Friend WithEvents TOURNEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOURNEETableAdapter As PPE_mesguen.DataSet1TableAdapters.TOURNEETableAdapter
    Friend WithEvents TRNNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHIMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHFIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNCOMMENTAIREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNPECCHAUFFEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNDTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
