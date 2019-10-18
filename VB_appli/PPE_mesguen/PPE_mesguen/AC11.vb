Public Class AC11
    Dim connexionSQL As New Odbc.OdbcConnection
    Dim myreader As Odbc.OdbcDataReader
    Dim donnee As DataTable
    Dim da As odbc.OdbcDataAdapter
    Dim cb As Odbc.OdbcCommandBuilder
    Dim connstring As String
    Dim myCommand As New Odbc.OdbcCommand
   
    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        connstring = "DSN=ORA02;Uid=u_Mesguen;Pwd=estran;"
        connexionSQL.ConnectionString = connstring

        Try
            connexionSQL.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)

    
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

    Private Sub TableTournee_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
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
        'AC12.show()
    End Sub


    Private Sub Suppr_Click(sender As System.Object, e As System.EventArgs) Handles Suppr.Click
        Dim trnum As Integer
        trnum = TableTournee.CurrentRow.Cells.Item(0).Value

        myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & trnum & ";", connexionSQL)
        myCommand.ExecuteNonQuery()
        myCommand = New Odbc.OdbcCommand("DELETE FROM TOURNEE WHERE TRNNUM = " & trnum & ";", connexionSQL)
        myCommand.ExecuteNonQuery()


    End Sub

End Class
