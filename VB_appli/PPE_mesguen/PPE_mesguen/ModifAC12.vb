Public Class ModifAC12
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

    'variable globale
    Public etpid As Integer
    Public mytrnnum As Integer


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mytrnnum = AC11.testtrnnum



    End Sub




    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        connString = "DSN=TestOracle;Uid=u_mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString

        'CONNEXION
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'remplir le tableau d'informations
        Dim query2 As String = "select trnnum, tournee.vehimmat, tournee.trncommentaire, tournee.trnpecchauffeur, chauffeur.chfnom from tournee inner join chauffeur ON tournee.chfid = chauffeur.chfid where trnnum = '" & mytrnnum & "';"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView1.DataSource = donnee


        'remplir le tablo des etapes
        affichetablo()

        'chargement de la liste des chauffeurs a partir de la table chauffeur

        Dim query As String
        query = "SELECT CHFID, CHFNOM FROM CHAUFFEUR"
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


        Dim update_tournee As String = "update tournee set VEHIMMAT='" & uneListe1 & "' , CHFID='" & uneListe & "' , TRNCOMMENTAIRE= '" & unText & "', TRNDTE= TO_DATE('" & uneDate & "', 'dd/MM/yy') where trnnum = '" & mytrnnum & "';"
        Dim cmd_update_tournee = New Odbc.OdbcCommand(update_tournee, myConnection)
        Try
            cmd_update_tournee.ExecuteNonQuery()
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


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    'bouton modifier
    Public Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click


        'recup case etpid
        etpid = DataGridView2.CurrentRow.Cells.Item(0).Value

        AC13.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click


        'recup case etpid
        etpid = DataGridView2.CurrentRow.Cells.Item(0).Value
        AC13Modifier.Show()
        Me.Close()



    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        'recup case etpid
        etpid = DataGridView2.CurrentRow.Cells.Item(0).Value

        Try

            myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & mytrnnum & " AND etpid = '" & etpid & "';", myConnection)
            myCommand.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("erreur")

        End Try

        affichetablo()

    End Sub

    'fonction afficher tableau
    Public Sub affichetablo()

        Dim query3 As String = "SELECT ETPID, LIEUNOM FROM commune, lieu, etape WHERE commune.VILID = lieu.VILID AND etape.LIEUID = lieu.LIEUID AND TRNNUM = '" & mytrnnum & "' ;"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query3, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView2.DataSource = donnee



    End Sub
End Class
'