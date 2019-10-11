Public Class AC12
   
    'Connexion Oracle
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Oracle
        connString = "DSN=CNXORA01;Uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "dd/MM/yy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
    End Sub



    Private Sub Comment_Click(sender As System.Object, e As System.EventArgs) Handles Comment.Click

    End Sub

    Private Sub ListNomChauf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListNomChauf.SelectedIndexChanged

        'Dim query As String = "SELECT chfNom FROM CHAUFFEUR INNER JOIN TOURNEE ON TOURNE.chfId=CHAUFFEUR.chfId"

        'da = New MySqlDataAdapter("SELECT chfNom FROM CHAUFFEUR INNER JOIN TOURNEE ON TOURNE.chfId=CHAUFFEUR.chfId", connexionSql)
        'Dim cb As MySqlCommandBuilder

        'cb = New MySqlCommandBuilder(da)
        'da.Fill(donnee)
        'ListNomChauf.DataSource = donnee

    End Sub

    Private Sub ImmatVehi_Click(sender As System.Object, e As System.EventArgs) Handles ImmatVehi.Click

    End Sub

    Private Sub ListImmatVehi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListImmatVehi.SelectedIndexChanged

    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        ''Probleme: affichage date n'apparait pas comme desire
        'DateTimePicker2.CustomFormat = "d/M/yy"
        'DateTimePicker2.Format = DateTimePickerFormat.Custom
    End Sub

End Class