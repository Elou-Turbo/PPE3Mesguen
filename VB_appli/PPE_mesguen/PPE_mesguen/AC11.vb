Public Class AC11
    Dim connexionSQL As MySqlConnection
    Dim donnee As DataTable
    Dim da As MySqlDataAdapter
    Dim cb As MySqlCommandBuilder

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Chaine As String
        Chaine = "server=127.0.0.1 ; port=3307 ; userid=root ; password=; database=mlr2; pooling=false"
        connexionSQL = New MySqlConnection(Chaine)
        connexionSQL.open()
        MessageBox.Show("Connexion Reussi")

        Dim reader As MySqlDataReader
        Dim cmd As New MySqlCommand("SHOW DATABASES", connexionSQL)
        reader = cmd.ExecuteReader()
        cmbBases.Items.Clear()
        While (reader.Read())
            cmbBases.Items.Add(reader.GetString(0))
        End While
        reader.Close()
    End Sub

   



    Private Sub cmbBases_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBases.SelectedIndexChanged
        Dim reader2 As MySqlDataReader
        connexionSQL.ChangeDatabase(cmbBases.SelectedItem.ToString())
        Dim cmd2 As New MySqlCommand("SHOW TABLES", connexionSQL)
        reader2 = cmd2.ExecuteReader()
        cmbTable.Items.Clear()
        While (reader2.Read())
            cmbTable.Items.Add(reader2.GetString(0))
        End While
        reader2.Close()

    End Sub

    Private Sub cmbTable_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTable.SelectedIndexChanged


        MsgBox(cmbTable.SelectedItem.ToString())
        donnee = New DataTable
        da = New MySqlDataAdapter("Select * from " + cmbTable.SelectedItem.ToString(), connexionSQL)
        cb = New MySqlCommandBuilder(da)
        da.Fill(donnee)
        TableTournee.DataSource = donnee
    End Sub

    Private Sub TableTournee_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TableTournee.CellContentClick

        MsgBox(cmbTable.SelectedItem.ToString())
        donnee = New DataTable
        da = New MySqlDataAdapter("Select * from ", connexionSQL)
        cb = New MySqlCommandBuilder(da)
        da.Fill(donnee)
        TableTournee.DataSource = donnee
    End Sub
End Class
