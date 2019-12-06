Public Class AC12
    Dim connstring As String
    Dim myCommand As New Odbc.OdbcCommand
    Dim myConnection As New Odbc.OdbcConnection
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim donnee As DataTable
    Dim donnee1 As DataTable
    Dim uneDate As Date
    Dim uneDate1 As Date
    Dim unText As String
    Dim uneListe As String
    Dim uneListe1 As String

    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connstring = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"
        myConnection.ConnectionString = connstring
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT CHFID, CHFNOM FROM CHAUFFEUR"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        ListChauffeur.DisplayMember = "CHFNOM"
        ListChauffeur.ValueMember = "CHFID"
        ListChauffeur.DataSource = donnee


        Dim commande As String = "SELECT VEHIMMAT FROM VEHICULE"
        donnee1 = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(commande, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee1)


        ListVehicule.DisplayMember = "VEHIMMAT"
        ListVehicule.ValueMember = "VEHIMMAT"
        ListVehicule.DataSource = donnee1

    End Sub


    Private Sub ListChauffeur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListChauffeur.SelectedIndexChanged
        Label6.Text = ListChauffeur.SelectedValue
    End Sub


    Private Sub ListVehicule_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListVehicule.SelectedIndexChanged
        Label7.Text = ListVehicule.SelectedValue
    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC11.Show()
        Me.Close()
    End Sub

    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click

        uneDate = DateTimePicker1.Value()
        uneDate1 = DateTimePicker2.Value()
        unText = BoxCommentaire.Text()
        uneListe = ListChauffeur.SelectedValue()
        uneListe1 = ListVehicule.SelectedValue()


        Dim insert_tournee As String = " INSERT INTO TOURNEE(VEHIMMAT,CHFID,TRNCOMMENTAIRE,TRNDTE) VALUES('" & uneListe1 & "','" & uneListe & "','" & unText & "',to_date('" & uneDate & "' , 'dd/MM/yy'));"
        Dim cmd_insert_tournee = New Odbc.OdbcCommand(insert_tournee, myConnection)
        Try
            cmd_insert_tournee.ExecuteNonQuery()
            AC11.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class