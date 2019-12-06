Public Class AC13M
    Dim connexionSQL As New Odbc.OdbcConnection
    Dim myreader As Odbc.OdbcDataReader
    Dim donnee As DataTable
    Dim da As Odbc.OdbcDataAdapter
    Dim cb As Odbc.OdbcCommandBuilder
    Dim connstring As String
    Dim myCommand As New Odbc.OdbcCommand




#Region "Connexion à la Base de données / affiche lieu "
    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs)


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


        'affiche tableau etape

        Dim query_etape As String = "select TRNNUM,LIEUNOM,ETPHREMIN,ETPHREMAX,ETPCOMMENTAIRE from etape inner join lieu on etape.lieuid = lieu.lieuid where etpid = '" & etpid & "' AND trnnum = '" & trnnum & "';"
        donnee = New DataTable
        da = New Odbc.OdbcDataAdapter(query_etape, connexionSQL)
        cb = New Odbc.OdbcCommandBuilder(da)
        da.Fill(donnee)
        DataGridView1.DataSource = donnee

        AC13TB.Text = DataGridView1.Rows(0).Cells.Item(4).Value
    End Sub
#End Region


    Private Sub AC13MB1_Click(sender As System.Object, e As System.EventArgs)
        Dim v_lieu As String
        Dim v_dteRDV As String
        Dim v_dteRDV2 As String
        Dim v_commentaire As String

        v_lieu = Me.AC13LB.SelectedValue
        v_dteRDV = Me.AC13DTP1.Value
        v_dteRDV2 = Me.AC13DTP2.Value()
        v_commentaire = Me.AC13TB.Text

        Dim updateEtape As String = "update Etape set LIEUID= '" & v_lieu & "', ETPHREMIN= TO_DATE('" & v_dteRDV & "','DD/MM/YYYY HH24:MI:SS'), ETPHREMAX =TO_DATE('" & v_dteRDV2 & "','DD/MM/YYYY HH24:MI:SS'), ETPCOMMENTAIRE ='" & v_commentaire & "'  where etpid = '" & etpid & "' AND trnnum = '" & trnnum & "' ;"
        Dim cmdEtape As New Odbc.OdbcCommand(updateEtape, connexionSQL)
        Try
            cmdEtape.ExecuteNonQuery()
            MessageBox.Show("Etape modiée")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AC13MB2_Click(sender As System.Object, e As System.EventArgs) Handles AC13MB2.Click
        ''AC11.Show()
        Me.Close()
    End Sub
End Class