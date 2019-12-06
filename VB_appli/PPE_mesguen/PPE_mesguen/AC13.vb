Public Class AC13

    Dim connexionSQL As New Odbc.OdbcConnection
    Dim myreader As Odbc.OdbcDataReader
    Dim donnee As DataTable
    Dim da As Odbc.OdbcDataAdapter
    Dim cb As Odbc.OdbcCommandBuilder
    Dim connstring As String
    Dim myCommand As New Odbc.OdbcCommand




#Region "Connexion à la Base de données / affiche lieu "
    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        connstring = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"
        connexionSQL.ConnectionString = connstring
        Try
            connexionSQL.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'Recuperation des données du lieu

        Dim query As String = "SELECT LIEUNOM, LIEUID FROM LIEU"
        donnee = New DataTable
        da = New Odbc.OdbcDataAdapter(query, connexionSQL)
        cb = New Odbc.OdbcCommandBuilder(da)
        da.Fill(donnee)


        AC13LB.DisplayMember = "LIEUNOM"
        AC13LB.ValueMember = "LIEUID"
        AC13LB.DataSource = donnee

    End Sub
#End Region

    '#Region "Affichage des données des tables"
    '    Private Sub cmbBases2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBases2.SelectedIndexChanged

    '        donnee = New DataTable
    '        da = New MySqlDataAdapter("SELECT * FROM " & cmbBases2.SelectedItem.ToString(), connexionSql)
    '        cb = New MySqlCommandBuilder(da)
    '        da.Fill(donnee)
    '        DGVdonnees.DataSource = donnee
    '    End Sub
    '#End Region


#Region "Validation des Modifications"
    Private Sub AC13B1_Click(sender As System.Object, e As System.EventArgs) Handles AC13B1.Click
        Dim lieu As String
        Dim dateRDV1 As Date
        Dim dateRDV2 As Date
        Dim commentaire As String

        lieu = AC13LB.Text
        commentaire = AC13TB.Text
        dateRDV1 = AC13DTP1.Value
        dateRDV2 = AC13DTP2.Value


        Dim insert_etape As String = "Insert into etape(TRNNUM, ETPID, LIEUID, ETPHREDEBUT, ETPHREFIN, ETPCOMMENTAIRE) VALUES ( 1, 8 , '" & lieu & "','" & dateRDV1 & "','" & dateRDV2 & "','" & commentaire & "'); "
        Dim cmd_insert_etape As New Odbc.OdbcCommand(insert_etape, connexionSQL)
        Try
            cmd_insert_etape.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try







        'Dim update_etape As String = "Update etape set LIEUNOM = '" & lieu & "' ETPHREDEBUT = '" & dateRDV1 & "' ETPHREFIN = '" & dateRDV2 & "' ETPCOMMENTAIRE = '" & commentaire & "' WHERE TRNNUM = '" & trnnum & "' and ETPID = '" & etpid & "' ;"
        'Dim cmd_update_etape As New Odbc.OdbcCommand(update_etape, connexionSQL)

        'Try
        '    cmd_insert_etape.ExecuteNonQuery()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


        'Dim Requete As String = "Insert into etape(TRNNUM, ETPID, LIEUNOM,ETPHREDEBUT, ETPHREFIN, ETPCOMMENTAIRE) VALUES ( '" & trnnum & "', '" & etpid & "' , '" & lieu & "','" & dateRDV1 & "','" & dateRDV2 & "','" & commentaire & "'); "
        'Dim Commande As New Odbc.OdbcCommand(Requete, connexionSQL)

        'Dim changes As DataTable = donnee.GetChanges
        'da.Update(changes)
        'donnee.AcceptChanges()




    End Sub
#End Region

#Region "Retour"
    Private Sub AC13B2_Click(sender As System.Object, e As System.EventArgs) Handles AC13B2.Click
        Me.Close()
    End Sub
#End Region



End Class
