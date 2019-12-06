Public Class AC12Modification

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim ds As DataSet


    Dim uneDate As Date
    Dim uneDatePriseCharge As Date
    Dim unCommentaire As String
    Dim uneListNomChauf As String
    Dim uneListImmat As String

    Private Sub AC12Modification_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Connexion à la base MESGUEN
        connString = "Dsn=BD_Oracle;uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        'Test de connexion à la base
        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'Affichage du chauffeur sélectionné (possibilité de modifier)
        Dim query As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR WHERE;"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        ListNomChauf.DataSource = donnee
        ListNomChauf.DisplayMember = "CHFNOM"
        ListNomChauf.ValueMember = "CHFID"


        'Affichage de la liste de l'immatriculation des vehicules
        Dim queryVehi As String = "SELECT VEHIMMAT FROM VEHICULE WHERE;"
        Dim donneeVehi As DataTable = New DataTable
        Dim myAdapterVehi As Odbc.OdbcDataAdapter = New Odbc.OdbcDataAdapter(queryVehi, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapterVehi)
        myAdapterVehi.Fill(donneeVehi)

        ListImmat.DataSource = donneeVehi
        ListImmat.DisplayMember = "VEHIMMAT"
        ListImmat.ValueMember = "VEHIMMAT"

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Format JJ/MM/AAAA
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/y"
    End Sub

    Private Sub ListNomChauf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListNomChauf.SelectedIndexChanged

    End Sub

    Private Sub ListImmat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListImmat.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        'Format JJ/MM/AAAA
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "d/M/y"
    End Sub

    Private Sub CommentaireTournee_TextChanged(sender As System.Object, e As System.EventArgs) Handles CommentaireTournee.TextChanged

    End Sub

    Private Sub ButtonValidation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonValidation.Click
        uneDate = DateTimePicker1.Value()
        uneDatePriseCharge = DateTimePicker2.Value()
        unCommentaire = CommentaireTournee.Text()
        uneListNomChauf = ListNomChauf.SelectedValue()
        uneListImmat = ListImmat.SelectedValue()

        
        Dim modif_tournee As String = " update tournee set CHFID='" & uneListNomChauf & "', VEHIMMAT='" & uneListImmat & "', TRNCOMMENTAIRE= '" & unCommentaire & "', TRNDTE= TO_DATE('" & uneDate & "','d/M/y') WHERE TRNNUM= '" & unNumeroTournee & "';"
        Dim modification_tournee = New Odbc.OdbcCommand(modif_tournee, myConnection)
        Try
            modification_tournee.ExecuteNonQuery()
            AC11.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonAnnulation_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnnulation.Click
        'Retour à l'écran précédent AC11
        'AC11.Show()
        'Me.Hide()
        Me.Close()
    End Sub

    Private Sub ListLieuEtape_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListLieuEtape.CellContentClick

    End Sub

    Private Sub ButtonAjout_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAjout.Click
        'Retour à l'écran précédent AC11
        'AC13.Show()
        Me.Hide()
    End Sub

End Class