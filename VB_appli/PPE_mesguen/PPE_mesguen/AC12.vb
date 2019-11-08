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
        
        connString = "Dsn=CNXORA_Mesguen;uid=u_mesguen;Pwd=estran;"

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

    Public Sub ListNomChauf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListNomChauf.SelectedIndexChanged

        'myReader.Close()


        ''TEST3
        'Dim result As String = "SELECT chaufid FROM CHAUFFEUR"
        'Dim cmd As New OdbcCommand(result, myConnection)
        'Dim da As OdbcDataAdapter = New OdbcDataAdapter(cmd)
        'Dim dt As New DataTable("CHAUFFEUR")
        'da.Fill(dt)
        'If dt.Rows.Count > 0 Then
        '    ListNomChauf.DataSource = dt
        '    ListNomChauf.ValueMember = "chfid"
        '    ListNomChauf.DisplayMember = "chfnom"
        'End If

        'ListNomChauf = ListNomChauf.SelectedValue

        ''TEST2
        'ListNomChauf.ValueMember = "chfid"
        'ListNomChauf.DisplayMember = "chfnom"
        'ListNomChauf.DataSource = "CHAUFFEUR"

        ''TEST0
        'Dim table_name As String = ListNomChauf.SelectedItem.ToString()
        'Dim query As String = "SELECT chfNom FROM CHAUFFEUR INNER JOIN TOURNEE ON CHAUFFEUR.chfId = TOURNEE.chaufId;"
        'donnee = New DataTable
        'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        'myAdapter.Fill(donnee)

        'SocGrid.DataSource = donnee

        'TEST1
        'Dim query As String = "SELECT chfNom FROM CHAUFFEUR;"
        'myCommand.Connection = myConnection
        'myCommand.CommandText = query
        'myReader = myCommand.ExecuteReader

        'While (myReader.Read())
        '    ListNomChauf.Items.Add(myReader.GetString(1))
        'End While

        'Dim query As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR"
        'donnee = New DataTable
        'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        'myAdapter.Fill(donnee)

        'ListNomChauf.ValueMember = "CHFID"
        'ListNomChauf.DisplayMember = "CHFNOM"
        'ListNomChauf.DataSource = "CHAUFFEUR"

    End Sub

    Private Sub ListImmatVehi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListImmatVehi.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        'Format JJ/MM/AAAA
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "d/M/YY "

    End Sub

    Private Sub ButtonValidation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonValidation.Click

    End Sub

    Private Sub ButtonAnnulation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnnulation.Click
        'Retour à l'écran précédent AC11
        AC11.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonAjout_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAjout.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim query As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)


        ListBox1.DisplayMember = "CHFNOM"
        ListBox1.ValueMember = "CHFID"
        ListBox1.DataSource = donnee

    End Sub
End Class