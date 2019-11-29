Public Class AC12
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim donnee1 As DataTable



    Dim uneDate As Date
    Dim uneDate1 As Date
    Dim unText As String
    Dim uneListe As String
    Dim uneListe1 As String







    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'FERME DE SERVEUR
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Uid=MESGUEN3;Pwd=Estran;"
        'SERVEUR DE TEST
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.100)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORAPROF)));Uid=SCOTT;Pwd=tiger;"
        'connString = "DSN=Test10;Uid=mesguen;Pwd=passwd;"
        'connString = "DSN=TestOracle;Uid=mesguen;Pwd=passwd;"

        'myConnection.ConnectionString = connString
        'Try
        'myConnection.Open()
        'MessageBox.Show("Connexion Oracle Réussie")
        'Catch ex As Odbc.OdbcException
        'MessageBox.Show(ex.Message)
        'End Try

        connString = "DSN=TestOracle;Uid=u_mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString

        'CONNEXION
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try





        'chargement de la liste des chauffeurs a partir de la table chauffeur
        Dim query As String = "SELECT CHFID, CHFNOM FROM CHAUFFEUR"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)


        ListBox1.DisplayMember = "CHFNOM"
        ListBox1.ValueMember = "CHFID"
        ListBox1.DataSource = donnee

        'On récuperera la valeur avec ListBox1.SelectedValue


        'chargement de la liste des vehicule a partir de la table vehicule
        Dim commande As String = "SELECT VEHIMMAT FROM VEHICULE"
        donnee1 = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(commande, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee1)


        ListBox2.DisplayMember = "VEHIMMAT"
        ListBox2.ValueMember = "VEHIMMAT"
        ListBox2.DataSource = donnee1



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'MsgBox(CType(ListBox1.SelectedItem, DataTable).CHFID)
        'MsgBox(ListBox1.SelectedValue)

        'DataTable).CHFID)

        Label6.Text = ListBox1.SelectedValue

    End Sub



    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        'MsgBox(ListBox2.SelectedValue)

        Label7.Text = ListBox2.SelectedValue
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        uneDate = DateTimePicker1.Value()
        uneDate1 = DateTimePicker2.Value()
        unText = TextBox1.Text()
        uneListe = ListBox1.SelectedValue()
        uneListe1 = ListBox2.SelectedValue()


        Dim insert_tournee As String = " INSERT INTO TOURNEE(REMORQUE,VEHIMMAT,CHFID,TRNCOMMENTAIRE,TRNDTE) VALUES(0,'" & uneListe1 & "','" & uneListe & "','" & unText & "',TO_DATE('" & uneDate & "', 'dd/MM/yy'));"
        Dim cmd_insert_tournee = New Odbc.OdbcCommand(insert_tournee, myConnection)
        Try
            cmd_insert_tournee.ExecuteNonQuery()
            AC11.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AC11.Show()
        Me.Close()
    End Sub
End Class
'