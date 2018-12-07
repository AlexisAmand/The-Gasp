' -----------
' Aide du jeu
' -----------

Public Class aide

    Private Sub aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' dimensions de la fenêtre

        Me.Width = 613
        Me.Height = 709




        RichTextBox1.Text = "Il s'agit de retourner <em>toutes</em> les cartes sachant que quand une carte est choisie, toutes ses voisines, sauf elle-même seront retournées.\r\n Il s'agit de retourner toutes les cartes sachant que quand une carte est choisie, toutes ses voisines, sauf elle-même seront retournées."

    End Sub

End Class