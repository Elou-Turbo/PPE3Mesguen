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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AC11))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.Suppr = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.TableTournee = New System.Windows.Forms.DataGridView()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NTOURNEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHICULEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARRIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PPE_mesguen.DataSet1()
        Me.DataTable2TableAdapter = New PPE_mesguen.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.DataSet11 = New PPE_mesguen.DataSet1()
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTE DES TOURNEES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Retour
        '
        Me.Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour.Location = New System.Drawing.Point(291, 490)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(163, 39)
        Me.Retour.TabIndex = 2
        Me.Retour.Text = "RETOUR"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'Ajouter
        '
        Me.Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ajouter.Location = New System.Drawing.Point(685, 490)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(163, 39)
        Me.Ajouter.TabIndex = 3
        Me.Ajouter.Text = "AJOUTER"
        Me.Ajouter.UseVisualStyleBackColor = True
        '
        'Suppr
        '
        Me.Suppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suppr.Location = New System.Drawing.Point(1068, 287)
        Me.Suppr.Name = "Suppr"
        Me.Suppr.Size = New System.Drawing.Size(92, 38)
        Me.Suppr.TabIndex = 4
        Me.Suppr.Text = "SUPPRIMER"
        Me.Suppr.UseVisualStyleBackColor = True
        '
        'Modifier
        '
        Me.Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modifier.Location = New System.Drawing.Point(1068, 156)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(92, 41)
        Me.Modifier.TabIndex = 5
        Me.Modifier.Text = "MODIFIER"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'TableTournee
        '
        Me.TableTournee.AllowUserToAddRows = False
        Me.TableTournee.AllowUserToDeleteRows = False
        Me.TableTournee.AutoGenerateColumns = False
        Me.TableTournee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableTournee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableTournee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableTournee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTOURNEEDataGridViewTextBoxColumn, Me.NOMDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.VEHICULEDataGridViewTextBoxColumn, Me.DEPARTDataGridViewTextBoxColumn, Me.ARRIVERDataGridViewTextBoxColumn})
        Me.TableTournee.DataSource = Me.DataTable2BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableTournee.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableTournee.Location = New System.Drawing.Point(197, 87)
        Me.TableTournee.Name = "TableTournee"
        Me.TableTournee.ReadOnly = True
        Me.TableTournee.Size = New System.Drawing.Size(803, 337)
        Me.TableTournee.TabIndex = 6
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1BindingSource
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
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1221, 541)
        Me.Controls.Add(Me.TableTournee)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Suppr)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AC11"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.TableTournee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents Suppr As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As PPE_mesguen.DataSet1

    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable2TableAdapter As PPE_mesguen.DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents DataSet11 As PPE_mesguen.DataSet1
    Friend WithEvents TableTournee As System.Windows.Forms.DataGridView
    Friend WithEvents NTOURNEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHICULEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARRIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource

End Class
