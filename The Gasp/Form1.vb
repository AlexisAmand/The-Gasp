Public Class Form1

    Dim version = "0.2.0" 'version du jeu

    Dim Damier(5, 5) As Char 'le damier 
    Dim NombreCoups = 0 'nombre de coups 

    ' coordonnées du pion

    Dim xbouton As Integer
    Dim ybouton As Integer

    ' Cette fonctione retourne les pions

    Private Sub retourne(xb, yb)

        For l = (yb - 1) To (yb + 1)
            For c = (xb - 1) To (xb + 1)
                If Damier(c, l) = "X" Then
                    Damier(c, l) = "0"
                Else
                    Damier(c, l) = "X"
                End If
            Next
        Next

        If Damier(xb, yb) = "X" Then
            Damier(xb, yb) = "0"
        Else
            Damier(xb, yb) = "X"
        End If

        NombreCoups = NombreCoups + 1
        Label1.Text = NombreCoups

        afficher()

    End Sub

    ' Cette fonction affiche les pions

    Private Sub afficher()

        ' afficher les pions de la 1ere ligne

        For i = 1 To 4
            If Damier(i, 1) = "X" Then
                Controls("Button" & (i).ToString).BackColor = Color.Sienna
                'Controls("Button" & i.ToString).BackgroundImage = Image.FromFile("E:\Dev\Visual Studio 2017\Projects\Le Gasp\Ressources\noir.png")
                'Controls("Button" & i.ToString).BackgroundImageLayout = ImageLayout.Stretch
            Else
                Controls("Button" & (i).ToString).BackColor = Color.PeachPuff
            End If
        Next

        ' afficher les pions de la 2e ligne

        For i = 1 To 4
            If Damier(i, 2) = "X" Then
                Controls("Button" & (i + 4).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 4).ToString).BackColor = Color.PeachPuff
            End If
        Next

        ' afficher les pions de la 3e ligne

        For i = 1 To 4
            If Damier(i, 3) = "X" Then
                Controls("Button" & (i + 8).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 8).ToString).BackColor = Color.PeachPuff
            End If
        Next

        ' afficher les pions de la 4e ligne

        For i = 1 To 4
            If Damier(i, 4) = "X" Then
                Controls("Button" & (i + 12).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 12).ToString).BackColor = Color.PeachPuff
            End If
        Next

    End Sub

    ' Cette fonction lance une nouvelle partie

    Private Sub nouvelle()

        NombreCoups = 0

        For c = 0 To 5
            For l = 0 To 5
                Damier(c, l) = "X"
            Next
        Next

        Label1.Text = NombreCoups

        afficher()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "The Gasp"
        Label2.Text = "Version " & version

        MaximizeBox = vbFalse
        MinimizeBox = vbFalse

        Button17.Text = "Nouvelle partie"
        Button19.Text = "Régles"
        Button18.Text = "Quitter"
        GroupBox1.Text = "Nombre de coups"

        nouvelle()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        xbouton = 2
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        xbouton = 3
        ybouton = 1

        retourne(xbouton, ybouton)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        xbouton = 4
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        xbouton = 1
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        xbouton = 2
        ybouton = 2

        retourne(xbouton, ybouton)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        xbouton = 3
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        xbouton = 4
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        xbouton = 1
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

        nouvelle()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        xbouton = 2
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        xbouton = 3
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        xbouton = 4
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        xbouton = 1
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        xbouton = 2
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        xbouton = 3
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        xbouton = 4
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        xbouton = 1
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click

        nouvelle()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Me.Close()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        aide.Visible = True

    End Sub
End Class