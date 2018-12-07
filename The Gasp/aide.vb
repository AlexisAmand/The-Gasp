' -----------
' Aide du jeu
' -----------

Public Class aide

    Private Sub aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Il y a quelques mois, j'ai découvert un petit listing en Basic paru dans le n°38 de Jeux et Stratégie d'avril/mai 1985. Il s'agit d'un petit jeu de réflexion qui est un petit mélange de Reverso et d'Othello. Vous disposez d'un plateau de jeu avec 16 pions bicolores formant un carré 4 x 4. Le but est de retourner tous les pions en respectant une seule régle : Quand vous désignez un pion, ses 8 voisins changent de couleurs mais lui garde la sienne.

        ' Quelques pages plus tard, la revue adaptait le jeu de plateau en Basic. Rien de bien génial, aujourd'hui nous appelerions ça un jeu en "mode console".

        ' Dans ma version, celle que je vous propose ici, les pions sont remplacés par des cartes, mais le principe est toujours le même : Quand vous désignez une carte, ses 8 voisines sont retournées sauf elle. Saurez-vous toutes les retourner ?

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class