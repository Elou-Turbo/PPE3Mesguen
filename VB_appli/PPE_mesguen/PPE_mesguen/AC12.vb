﻿Public Class AC12

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
        'Me.VEHICULETableAdapter.Fill(Me.DataSet1.VEHICULE)

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
    'Aide vb.net option value combobox: http://net-informations.com/q/faq/combovalue.html
    ' Autre aides: https://www.developpez.net/forums/d201237/dotnet/developpement-windows/windows-forms/csharp-parcourir-items-d-combobox-remplir/
    ' https://riptutorial.com/fr/vb-net/example/7085/create-a-dictionary-filled-with-values
    ' https://www.developpez.net/forums/d1518806/logiciels/microsoft-office/excel/macros-vba-excel/creation-d-dictionnaire-objet/


        'Dim comboSource As New Dictionary(Of Integer, String)()


        'Dim myReader As Odbc.OdbcDataReader = myCommand.ExecuteReader()

        'If myReader.Read() Then
        '    Console.WriteLine(myReader("CHFID").ToString)
        '    Else
        '    Console.WriteLine("PB")
        '    End If
        'comboSource.Add()

        'comboSource.Add("1", "Sunday")
        'comboSource.Add("2", "Monday")
        'comboSource.Add("3", "Tuesday")
        'comboSource.Add("4", "Wednesday")
        'comboSource.Add("5", "Thursday")
        'comboSource.Add("6", "Friday")
        'comboSource.Add("7", "Saturday")
        'ListNomChauf.DataSource = New BindingSource(comboSource, Nothing)
        'ListNomChauf.DisplayMember = "Value"
        'ListNomChauf.ValueMember = "Key"



        'ListNomChauf.DataSource = New BindingSource(comboSource, Nothing)
        'ListNomChauf.DisplayMember = "Value"
        'ListNomChauf.ValueMember = "Key"

        'Dim key As String = DirectCast(ListNomChauf.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As Integer = DirectCast(ListNomChauf.SelectedItem, KeyValuePair(Of String, String)).Value

        'Affichage liste des noms des chauffeurs
        Dim query As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR;"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        ListNomChauf.DataSource = donnee
        ListNomChauf.DisplayMember = "CHFNOM"
        ListNomChauf.ValueMember = "CHFID"


        'Affichage de la liste de l'immatriculation des véhicules
        Dim queryVehi As String = "SELECT VEHIMMAT,VEHNOM FROM VEHICULE"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        ListImmat.DataSource = donnee
        ListImmat.DisplayMember = "VEHIMMAT"
        ListImmat.ValueMember = "VEHNOM"


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