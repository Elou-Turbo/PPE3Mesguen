Public Class AC11
    Dim connexionSQL As New Odbc.OdbcConnection
    Dim donnee As DataTable
    Dim da As MySqlDataAdapter
    Dim cb As MySqlCommandBuilder

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        'Dim Chaine As String
        'Chaine = "server=127.0.0.1 ; port=3307 ; userid=root ; password=; database=mlr2; pooling=false"
        'connexionSQL = New MySqlConnection(Chaine)
        'connexionSQL.open()
        'MessageBox.Show("Connexion Reussi")

        'Dim reader As MySqlDataReader
        'Dim cmd As New MySqlCommand("SHOW DATABASES", connexionSQL)
        'reader = cmd.ExecuteReader()
        'cmbBases.Items.Clear()
        'While (reader.Read())
        '    cmbBases.Items.Add(reader.GetString(0))
        'End While
        'reader.Close()
    End Sub

   



    Private Sub cmbBases_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Dim reader2 As MySqlDataReader
        'connexionSQL.ChangeDatabase(cmbBases.SelectedItem.ToString())
        'Dim cmd2 As New MySqlCommand("SHOW TABLES", connexionSQL)
        'reader2 = cmd2.ExecuteReader()
        'cmbTable.Items.Clear()
        'While (reader2.Read())
        '    cmbTable.Items.Add(reader2.GetString(0))
        'End While
        'reader2.Close()

    End Sub

    Private Sub cmbTable_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)


        'MsgBox(cmbTable.SelectedItem.ToString())
        'donnee = New DataTable
        'da = New MySqlDataAdapter("Select * from " + cmbTable.SelectedItem.ToString(), connexionSQL)
        'cb = New MySqlCommandBuilder(da)
        'da.Fill(donnee)
        'TableTournee.DataSource = donnee
    End Sub

    Private Sub TableTournee_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TableTournee.CellContentClick
        'da = New MySqlDataAdapter("Select  from " + cmbTable.SelectedItem.ToString(), connexionSQL)
        'MsgBox(cmbTable.SelectedItem.ToString())
        'donnee = New DataTable
        'da = New MySqlDataAdapter("Select * from ", connexionSQL)
        'cb = New MySqlCommandBuilder(da)
        'da.Fill(donnee)
        'TableTournee.DataSource = donnee
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form_Connexion.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AC12.Show()
        Me.Hide()
    End Sub

    'Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    '    Dim trnum As Integer
    '    trnum = TableTournee.CurrentRow.Cells.Item(0).Value
    '    myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & trnum & ";", connexionSQL)
    '    myCommand.ExecuteNonQuery()
    'End Sub

    Private Sub Modifier_Click(sender As System.Object, e As System.EventArgs) Handles Modifier.Click
        AC12.Show()
        Me.Hide()
    End Sub
End Class
