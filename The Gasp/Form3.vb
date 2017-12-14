' Jeu en 4 x 4

Option Strict Off

Public Class Form3


    ' TODO: Changer les cartes 10 et 11 et les remplacer par les figures qui correspondent
    ' TODO: Vérifier qu 'il n'y a pas de cartes en double
    ' TODO: finir l 'icone
    ' TODO: dans form > propriétés > style de la fenêtres > icon : mettre l 'icone

    ' Dim version = "0.2.0" 'version du jeu

    Dim Damier(5, 5) As Char 'le damier 
    Dim NombreCoups = 0 'nombre de coups 

    ' coordonnées du pion

    Dim xbouton As Integer
    Dim ybouton As Integer

    ' ce tableau stocke les versos des cartes

    Dim TableauDesImages(17) As Image

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
        ToolStripStatusLabel1.Text = "Nombre de coups : " & NombreCoups

        afficher(VersoCarte)

    End Sub

    ' Cette fonction affiche les pions

    Public Sub afficher(VersoCarte)

        For i = 1 To 4

            ' afficher les pions de la 1ere ligne

            If Damier(i, 1) = "X" Then

                Controls("PictureBox" & (i).ToString).BackgroundImage = VersoCarte

            Else

                Controls("PictureBox" & (i).ToString).BackgroundImage = TableauDesImages(i)

            End If

            ' afficher les pions de la 2e ligne

            If Damier(i, 2) = "X" Then

                Controls("PictureBox" & (i + 4).ToString).BackgroundImage = VersoCarte

            Else
                Controls("PictureBox" & (i + 4).ToString).BackgroundImage = TableauDesImages(i + 4)
            End If

            ' afficher les pions de la 3e ligne

            If Damier(i, 3) = "X" Then

                Controls("PictureBox" & (i + 8).ToString).BackgroundImage = VersoCarte

            Else
                Controls("PictureBox" & (i + 8).ToString).BackgroundImage = TableauDesImages(i + 8)
            End If

            ' afficher les pions de la 4e ligne

            If Damier(i, 4) = "X" Then

                Controls("PictureBox" & (i + 12).ToString).BackgroundImage = VersoCarte

            Else
                Controls("PictureBox" & (i + 12).ToString).BackgroundImage = TableauDesImages(i + 12)
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

        afficher(VersoCarte)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        xbouton = 1
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        xbouton = 2
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        xbouton = 3
        ybouton = 1

        retourne(xbouton, ybouton)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        xbouton = 4
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "The Gasp"

        ToolStripStatusLabel1.Text = "Nombre de coups : " & NombreCoups

        MaximizeBox = vbFalse
        MinimizeBox = vbFalse

        ' dimensions de la fenêtre

        ' Me.Width = 629
        ' Me.Height = 766

        ' On met le verso des cartes dans le tableau pour pouvoir les récupérer dans la boucle for 

        TableauDesImages(1) = My.Resources.Resource1.carte01
        TableauDesImages(2) = My.Resources.Resource1.carte02
        TableauDesImages(3) = My.Resources.Resource1.carte03
        TableauDesImages(4) = My.Resources.Resource1.carte04
        TableauDesImages(5) = My.Resources.Resource1.carte05
        TableauDesImages(6) = My.Resources.Resource1.carte06
        TableauDesImages(7) = My.Resources.Resource1.carte07
        TableauDesImages(8) = My.Resources.Resource1.carte08
        TableauDesImages(9) = My.Resources.Resource1.carte09
        TableauDesImages(10) = My.Resources.Resource1.carte10
        TableauDesImages(11) = My.Resources.Resource1.carte11
        TableauDesImages(12) = My.Resources.Resource1.carte12
        TableauDesImages(13) = My.Resources.Resource1.carte13
        TableauDesImages(14) = My.Resources.Resource1.carte14
        TableauDesImages(15) = My.Resources.Resource1.carte15
        TableauDesImages(16) = My.Resources.Resource1.carte16

        ' hop ! On lance une nouvelle partie

        nouvelle()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        xbouton = 1
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        xbouton = 2
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        xbouton = 3
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        xbouton = 4
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        xbouton = 1
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        xbouton = 2
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        xbouton = 3
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        xbouton = 4
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        xbouton = 1
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

        xbouton = 2
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

        xbouton = 3
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

        xbouton = 4
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Grille4X4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Grille4X4ToolStripMenuItem.Click

        Me.Visible = vbTrue

    End Sub

    Private Sub RéglesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéglesToolStripMenuItem.Click

        aide.Visible = vbTrue

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click

        AboutBox1.Visible = vbTrue

    End Sub

    Private Sub Grille5X5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Grille5X5ToolStripMenuItem.Click

        Form2.Visible = vbTrue
        Me.Visible = vbFalse

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Form1.Visible = vbTrue

    End Sub
End Class