Public Class Form2

    Dim version = "0.2.0" 'version du jeu

    Dim Damier(6, 6) As Char 'le damier 
    Dim NombreCoups = 0 'nombre de coups 

    ' coordonnées du pion

    Dim xbouton As Integer
    Dim ybouton As Integer

    ' résolution de l'écran

    Dim ResWidth As Short = Screen.PrimaryScreen.Bounds.Width
    Dim ResHeight As Short = Screen.PrimaryScreen.Bounds.Height

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

        For i = 1 To 5

            ' afficher les pions de la 1ere ligne

            If Damier(i, 1) = "X" Then
                Controls("Button" & (i).ToString).BackColor = Color.Sienna
                'Controls("Button" & i.ToString).BackgroundImage = Image.FromFile("E:\Dev\Visual Studio 2017\Projects\Le Gasp\Ressources\noir.png")
                'Controls("Button" & i.ToString).BackgroundImageLayout = ImageLayout.Stretch
            Else
                Controls("Button" & (i).ToString).BackColor = Color.PeachPuff
            End If

            ' afficher les pions de la 2e ligne

            If Damier(i, 2) = "X" Then
                Controls("Button" & (i + 5).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 5).ToString).BackColor = Color.PeachPuff
            End If

            ' afficher les pions de la 3e ligne

            If Damier(i, 3) = "X" Then
                Controls("Button" & (i + 10).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 10).ToString).BackColor = Color.PeachPuff
            End If

            ' afficher les pions de la 4e ligne

            If Damier(i, 4) = "X" Then
                Controls("Button" & (i + 15).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 15).ToString).BackColor = Color.PeachPuff
            End If

            ' afficher les pions de la 5e ligne

            If Damier(i, 5) = "X" Then
                Controls("Button" & (i + 20).ToString).BackColor = Color.Sienna
            Else
                Controls("Button" & (i + 20).ToString).BackColor = Color.PeachPuff
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "The Gasp"

        GroupBox1.Text = "Nombre de coups"

        MaximizeBox = vbFalse
        MinimizeBox = vbFalse

        ' dimensions de la fenêtre

        Me.Width = 613
        Me.Height = 709

        ' on enléve les textes des boutons

        For i = 1 To 25
            Controls("Button" & (i).ToString).Text = ""
        Next

        ' hop ! On lance une nouvelle partie

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

        xbouton = 5
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        xbouton = 1
        ybouton = 2

        retourne(xbouton, ybouton)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        xbouton = 2
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        xbouton = 3
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        xbouton = 4
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

        nouvelle()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        xbouton = 5
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        xbouton = 1
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        xbouton = 2
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        xbouton = 3
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        xbouton = 4
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        xbouton = 5
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        xbouton = 1
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        xbouton = 1
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click

        xbouton = 2
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        xbouton = 3
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        xbouton = 4
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        xbouton = 5
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)

        nouvelle()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

        xbouton = 1
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        xbouton = 2
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        xbouton = 3
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        xbouton = 4
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        xbouton = 5
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click

        AboutBox1.Visible = vbTrue

    End Sub

    Private Sub RéglesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéglesToolStripMenuItem.Click

        aide.Visible = vbTrue

    End Sub

    Private Sub NouvellePartieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvellePartieToolStripMenuItem.Click

        nouvelle()

    End Sub

    Private Sub Grille4X4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Grille4X4ToolStripMenuItem.Click

        Form1.Visible = vbTrue
        Me.Visible = vbFalse

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click

        Me.Close()

    End Sub
End Class