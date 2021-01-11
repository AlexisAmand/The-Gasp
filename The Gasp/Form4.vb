Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Titre de la Form4

        Me.Text = "Choix du fond"

        ' Textes des boutons radios sous les images

        RadioButton1.Text = "Bois"
        RadioButton2.Text = "Dégradé"
        RadioButton3.Text = "Gazon"
        RadioButton4.Text = "Eau"
        RadioButton5.Text = "Iles"
        RadioButton6.Text = "Rocks"
        RadioButton7.Text = "Galets"
        RadioButton8.Text = "Femme"

        ' Textes des boutons

        Button1.Text = "Fermer"

        ' La fenêtre est centrée quand elle s'ouvre

        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        ' Choix de l'image "wood" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.wood

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        ' Choix de l'image "dégradé" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.fond

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        ' Choix de l'image "herbe" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.herbe

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        ' Choix de l'image "eau" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.eau

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        ' Choix de l'image "nuages" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.nuages

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        ' Choix de l'image "rock" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.rock

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        ' Choix de l'image "galets" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.galets

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

        ' Choix de l'image "woman" comme fond pour la fenêtre de jeu

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.woman

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

End Class