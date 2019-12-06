Public Class AC11
    Dim myreader As Odbc.OdbcDataReader
    Dim donnee As DataTable
    Dim da As Odbc.OdbcDataAdapter
    Dim cb As Odbc.OdbcCommandBuilder
    Dim connstring As String
    Dim myCommand As New Odbc.OdbcCommand

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)


    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        Form_Connexion.Show()
        Me.Close()
    End Sub


    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        'AC12.Show()
        Me.Close()
    End Sub


    Private Sub Suppr_Click(sender As System.Object, e As System.EventArgs) Handles Suppr.Click
        Dim ans As String
        Dim data As String

        data = Convert.ToString(TableTournee.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Confirmé la suppression de la tournée N° " & data, vbYesNo)
        If ans = vbYes Then
            myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & data & ";", connexionSQL)
            myCommand.ExecuteNonQuery()
            myCommand = New Odbc.OdbcCommand("DELETE FROM TOURNEE WHERE TRNNUM = " & data & ";", connexionSQL)
            myCommand.ExecuteNonQuery()
            MessageBox.Show(data)
            Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        End If

    End Sub



    Private Sub Modifier_Click(sender As System.Object, e As System.EventArgs)
        Dim ans As String
        trnnum = Convert.ToString(TableTournee.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Confirmer la modification de la tournée N° " & trnnum, vbYesNo)
        If ans = vbYes Then

        End If
    End Sub
End Class
