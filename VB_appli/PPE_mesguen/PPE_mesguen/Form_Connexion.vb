Public Class Form_Connexion

    Private Sub Utilisateur_TextChanged(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub MotDePasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (TextBox_pass.Text = "phicorp29") And (TextBox_Login.Text = "phicorp29") Then
            AC11.Show()
            Me.Hide()
        Else
            MessageBox.Show("Identifiant ou Mot de passe incorrect")
        End If

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form_Connexion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

