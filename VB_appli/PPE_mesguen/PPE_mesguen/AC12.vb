Public Class AC12

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim ds As DataSet


    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        connString = "Dsn=BD_Oracle;uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Format JJ/MM/AAAA
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/YYYY"

    End Sub

    Private Sub ListNomChauf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListNomChauf.SelectedIndexChanged

        'Dim table_name As String = ListNomChauf.SelectedItem.ToString()
        'Dim query As String = "SELECT chfNom FROM CHAUFFEUR INNER JOIN TOURNEE ON CHAUFFEUR.chfId = TOURNEE.chaufId;"
        'donnee = New DataTable
        'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        'myAdapter.Fill(donnee)

        'SocGrid.DataSource = donnee

        Dim query As String = "chfNom FROM CHAUFFEUR INNER JOIN TOURNEE ON CHAUFFEUR.chfId = TOURNEE.chaufId;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While (myReader.Read())
            ListNomChauf.Items.Add(myReader.GetString(0))
        End While

    End Sub

    Private Sub ListImmatVehi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListImmatVehi.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub ButtonValidation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonValidation.Click

    End Sub

    Private Sub ButtonAnnulation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnnulation.Click
        'Retour à l'écran précédent AC11
        AC11.Show()
        Me.Hide()

    End Sub
End Class