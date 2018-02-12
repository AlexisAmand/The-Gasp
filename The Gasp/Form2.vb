' ----------------------
' Grille de jeu en 5 x 5
' ----------------------

Option Strict Off

Public Class Form2

    Dim Damier(6, 6) As Char 'le damier 
    Dim NombreCoups = 0 'nombre de coups 

    ' coordonnées du pion

    Dim xbouton As Integer
    Dim ybouton As Integer

    ' ce tableau stocke les versos des cartes

    Dim TableauDesImages(27) As Image

    ' fonction qui retourne les pions

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

        For i = 1 To 5

            ' afficher les pions de la 1ere ligne

            If Damier(i, 1) = "X" Then
                Controls("PictureBox" & (i).ToString).BackgroundImage = VersoCarte
            Else
                Controls("PictureBox" & (i).ToString).BackgroundImage = TableauDesImages(i)
            End If

            ' afficher les pions de la 2e ligne

            If Damier(i, 2) = "X" Then
                Controls("PictureBox" & (i + 5).ToString).BackgroundImage = VersoCarte
            Else
                Controls("PictureBox" & (i + 5).ToString).BackgroundImage = TableauDesImages(i + 5)
            End If

            ' afficher les pions de la 3e ligne

            If Damier(i, 3) = "X" Then
                Controls("PictureBox" & (i + 10).ToString).BackgroundImage = VersoCarte
            Else
                Controls("PictureBox" & (i + 10).ToString).BackgroundImage = TableauDesImages(i + 10)
            End If

            ' afficher les pions de la 4e ligne

            If Damier(i, 4) = "X" Then
                Controls("PictureBox" & (i + 15).ToString).BackgroundImage = VersoCarte
            Else
                Controls("PictureBox" & (i + 15).ToString).BackgroundImage = TableauDesImages(i + 15)
            End If

            ' afficher les pions de la 5e ligne

            If Damier(i, 5) = "X" Then
                Controls("PictureBox" & (i + 20).ToString).BackgroundImage = VersoCarte
            Else
                Controls("PictureBox" & (i + 20).ToString).BackgroundImage = TableauDesImages(i + 20)
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

        'Label1.Text = NombreCoups

        afficher(VersoCarte)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "The Gasp"

        ToolStripStatusLabel1.Text = "Nombre de coups : " & NombreCoups

        MaximizeBox = vbFalse
        MinimizeBox = vbFalse

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

        ' TODO : vérifier la taille des cartes 17 à 22

        TableauDesImages(17) = My.Resources.Resource1.carte17
        TableauDesImages(18) = My.Resources.Resource1.carte18
        TableauDesImages(19) = My.Resources.Resource1.carte19
        TableauDesImages(20) = My.Resources.Resource1.carte20
        TableauDesImages(21) = My.Resources.Resource1.carte21
        TableauDesImages(22) = My.Resources.Resource1.carte22

        ' TODO: changer les cartes 23 à 25

        TableauDesImages(23) = My.Resources.Resource1.carte23
        TableauDesImages(24) = My.Resources.Resource1.carte24
        TableauDesImages(25) = My.Resources.Resource1.carte25

        ' TableauDesImages(26) = My.Resources.Resource1.carte10

        ' hop ! On lance une nouvelle partie

        nouvelle()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        xbouton = 2
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        xbouton = 3
        ybouton = 1

        retourne(xbouton, ybouton)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        xbouton = 4
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        xbouton = 5
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

        xbouton = 1
        ybouton = 2

        retourne(xbouton, ybouton)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        xbouton = 2
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        xbouton = 3
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        xbouton = 4
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

        nouvelle()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        xbouton = 5
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

        xbouton = 1
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

        xbouton = 2
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

        xbouton = 3
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

        xbouton = 4
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

        xbouton = 5
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

        xbouton = 1
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        xbouton = 1
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs)

        xbouton = 2
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

        xbouton = 3
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)

        xbouton = 4
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)

        xbouton = 5
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)

        nouvelle()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

        xbouton = 1
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)

        xbouton = 2
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)

        xbouton = 3
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)

        xbouton = 4
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)

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

        Form3.Visible = vbTrue
        Me.Visible = vbFalse

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form1.Visible = vbTrue

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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        xbouton = 5
        ybouton = 1

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        xbouton = 1
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        xbouton = 2
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        xbouton = 3
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        xbouton = 4
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        xbouton = 5
        ybouton = 2

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        xbouton = 1
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        xbouton = 2
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        xbouton = 3
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

        xbouton = 4
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

        xbouton = 5
        ybouton = 3

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

        xbouton = 1
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

        xbouton = 2
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

        xbouton = 3
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click

        xbouton = 4
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

        xbouton = 5
        ybouton = 4

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

        xbouton = 1
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click

        xbouton = 2
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click

        xbouton = 3
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click

        xbouton = 4
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click

        xbouton = 5
        ybouton = 5

        retourne(xbouton, ybouton)

    End Sub
End Class