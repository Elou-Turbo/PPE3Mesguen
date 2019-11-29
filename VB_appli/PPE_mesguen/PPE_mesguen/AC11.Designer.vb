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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AC11))
        Me.TableTournee = New System.Windows.Forms.DataGridView()
        Me.NTOURNEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHICULEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARRIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PPE_mesguen.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.DataTable2TableAdapter = New PPE_mesguen.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.degats = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableTournee
        '
        Me.TableTournee.AllowUserToAddRows = False
        Me.TableTournee.AllowUserToDeleteRows = False
        Me.TableTournee.AutoGenerateColumns = False
        Me.TableTournee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableTournee.BackgroundColor = System.Drawing.Color.White
        Me.TableTournee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableTournee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTOURNEEDataGridViewTextBoxColumn, Me.NOMDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.VEHICULEDataGridViewTextBoxColumn, Me.DEPARTDataGridViewTextBoxColumn, Me.ARRIVERDataGridViewTextBoxColumn, Me.degats})
        Me.TableTournee.DataSource = Me.DataTable2BindingSource
        Me.TableTournee.Location = New System.Drawing.Point(171, 81)
        Me.TableTournee.Name = "TableTournee"
        Me.TableTournee.ReadOnly = True
        Me.TableTournee.Size = New System.Drawing.Size(820, 325)
        Me.TableTournee.TabIndex = 0
        '
        'NTOURNEEDataGridViewTextBoxColumn
        '
        Me.NTOURNEEDataGridViewTextBoxColumn.DataPropertyName = "N° TOURNEE"
        Me.NTOURNEEDataGridViewTextBoxColumn.HeaderText = "N° TOURNEE"
        Me.NTOURNEEDataGridViewTextBoxColumn.Name = "NTOURNEEDataGridViewTextBoxColumn"
        Me.NTOURNEEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMDataGridViewTextBoxColumn
        '
        Me.NOMDataGridViewTextBoxColumn.DataPropertyName = "NOM"
        Me.NOMDataGridViewTextBoxColumn.HeaderText = "NOM"
        Me.NOMDataGridViewTextBoxColumn.Name = "NOMDataGridViewTextBoxColumn"
        Me.NOMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DATE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'VEHICULEDataGridViewTextBoxColumn
        '
        Me.VEHICULEDataGridViewTextBoxColumn.DataPropertyName = "VEHICULE"
        Me.VEHICULEDataGridViewTextBoxColumn.HeaderText = "VEHICULE"
        Me.VEHICULEDataGridViewTextBoxColumn.Name = "VEHICULEDataGridViewTextBoxColumn"
        Me.VEHICULEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEPARTDataGridViewTextBoxColumn
        '
        Me.DEPARTDataGridViewTextBoxColumn.DataPropertyName = "DEPART"
        Me.DEPARTDataGridViewTextBoxColumn.HeaderText = "DEPART"
        Me.DEPARTDataGridViewTextBoxColumn.Name = "DEPARTDataGridViewTextBoxColumn"
        Me.DEPARTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARRIVERDataGridViewTextBoxColumn
        '
        Me.ARRIVERDataGridViewTextBoxColumn.DataPropertyName = "ARRIVER"
        Me.ARRIVERDataGridViewTextBoxColumn.HeaderText = "ARRIVER"
        Me.ARRIVERDataGridViewTextBoxColumn.Name = "ARRIVERDataGridViewTextBoxColumn"
        Me.ARRIVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTE DES TOURNEES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(171, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RETOUR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(171, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "AJOUTER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1068, 287)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 38)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "SUPPRIMER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Modifier
        '
        Me.Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modifier.Location = New System.Drawing.Point(1068, 192)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(92, 41)
        Me.Modifier.TabIndex = 5
        Me.Modifier.Text = "MODIFIER"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(828, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 39)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "VOIR LES DEGATS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'degats
        '
        Me.degats.DataPropertyName = "N° TOURNEE"
        Me.degats.HeaderText = "DEGATS"
        Me.degats.Name = "degats"
        Me.degats.ReadOnly = True
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 541)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableTournee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AC11"
        Me.Text = "Liste des tournées"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TableTournee As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As PPE_mesguen.DataSet1

    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2TableAdapter As PPE_mesguen.DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents NTOURNEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHICULEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARRIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents degats As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
