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
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.VEHICULE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.VEHICULETableAdapter.Fill(Me.DataSet1.VEHICULE)

        'Connexion à la base MESGUEN
        connString = "Dsn=CNXORA_Mesguen;uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        'Test de connexion à la base
        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'Affichage de la liste des noms des chauffeurs
        'Aide: http://net-informations.com/q/faq/combovalue.html
        Dim comboSource As New Dictionary(Of Integer, String)()

        ListNomChauf.DataSource = New BindingSource(comboSource, Nothing)
        ListNomChauf.DisplayMember = "Value"
        ListNomChauf.ValueMember = "Key"

        Dim key As String = DirectCast(ListNomChauf.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As Integer = DirectCast(ListNomChauf.SelectedItem, KeyValuePair(Of String, String)).Value


        'Dim query As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR;"
        'donnee = New DataTable
        'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

        'ListNomChauf.DataSource = donnee
        'ListNomChauf.DisplayMember = "CHFNOM"
        'ListNomChauf.ValueMember = "CHFID"


        'Affichage de la liste des chauffeurs
        'Dim query As String = "SELECT VEHIMMAT FROM VEHICULE"
        'donnee = New DataTable
        'myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        'myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

        'ListImmatVehi.DataSource = donnee
        'ListImmatVehi.DisplayMember = "VEHIMMAT"
        'ListImmatVehi.ValueMember = "VEHIMMAT"
       

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Format JJ/MM/AAAA
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/YYYY"

    End Sub

    Private Sub ListNomChauf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListNomChauf.SelectedIndexChanged

    End Sub

    Private Sub ListImmat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListImmat.SelectedIndexChanged

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

    'CONCERNNANT ETAPE
    'etpid = Convert.ToString(TableTournee.CurrentRow.Cells.Item(0).Value)

End Class