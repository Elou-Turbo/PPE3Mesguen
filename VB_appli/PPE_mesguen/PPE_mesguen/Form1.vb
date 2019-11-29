Imports System.IO
Public Class Form1

    Dim LesImages As List(Of String)
    Dim index As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LesImages = New List(Of String)
        Panel1.Controls.Add(PictureBox1)
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click

        Using open As New OpenFileDialog()
            open.Filter = "Les images|*.jpeg;*.png;*.jpg;*.bmp;*.ico"
            If open.ShowDialog() = DialogResult.OK Then

                If PictureBox1.Image IsNot Nothing Then
                    PictureBox1.Image.Dispose()
                End If
                PictureBox1.Image = Image.FromFile(open.FileName)
                PictureBoxManager()

                Dim dossier As String = open.FileName.Substring(0, open.FileName.LastIndexOf("\"))
                Dim r = From i In Directory.GetFiles(dossier)
                        Where i.ToLower().EndsWith("jpeg") Or i.ToLower().EndsWith("jpg") Or i.ToLower().EndsWith("png") _
                        Or i.ToLower().EndsWith("bmp") Or i.ToLower().EndsWith("ico")
                        Select i

                LesImages.Clear()
                For x As Integer = 0 To r.Count() - 1
                    LesImages.Add(r(x))
                    If r(x) = open.FileName Then
                        index = x
                    End If
                Next
            End If
        End Using

    End Sub


    Private Sub PictureBoxManager()

        If PictureBox1.Image.Width > Panel1.Width And PictureBox1.Image.Height > Panel1.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Dock = DockStyle.Fill
        ElseIf PictureBox1.Image.Width > Panel1.Width Or PictureBox1.Image.Height > Panel1.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Dock = DockStyle.Fill
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.Dock = DockStyle.Fill
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'suivant
        If LesImages.Count > 1 Then
            If index + 1 > LesImages.Count - 1 Then
                index = 0
            Else
                index = index + 1
            End If
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Image.FromFile(LesImages(index))
            PictureBoxManager()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LesImages.Count > 1 Then
            If index - 1 < 0 Then
                index = LesImages.Count - 1
            Else
                index = index - 1
            End If
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Image.FromFile(LesImages(index))
            PictureBoxManager()
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If PictureBox1.Dock = DockStyle.Fill Then
            PictureBox1.Dock = DockStyle.None
            PictureBox1.Size = New Size(PictureBox1.Image.Width * 2, PictureBox1.Image.Height * 2)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            If PictureBox1.Width < Panel1.Width Then
                PictureBox1.Location = New Point((Panel1.Width / 2) - PictureBox1.Width, PictureBox1.Location.Y)
            End If
        Else
            PictureBoxManager()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If PictureBox1.Image IsNot Nothing Then
            PictureBoxManager()
            PictureBox1.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
