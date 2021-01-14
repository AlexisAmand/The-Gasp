' -----------------------
' Choix du dos des cartes
' -----------------------

Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.carte

    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.back_railways

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.bateau_vintage

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.red

    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.russian

    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.old

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.suisse

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.back_atlas

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

        Module1.VersoCarte = The_Gasp.My.Resources.Resource1.dos_disco_o

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Application du nouveau dos des cartes et fermeture de la form des options

        Form3.afficher(VersoCarte)
        Form2.afficher(VersoCarte)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Titre de la Form1

        Me.Text = "Choix du deck"

        ' Textes des boutons radios sous les images

        RadioButton1.Text = "Defaut"
        RadioButton2.Text = "Railways"
        RadioButton3.Text = "Boat"
        RadioButton4.Text = "Red"
        RadioButton5.Text = "Russian"
        RadioButton6.Text = "Meeting"
        RadioButton7.Text = "Suisse"
        RadioButton9.Text = "Vintage"
        RadioButton10.Text = "Disco"

        ' Textes des boutons

        Button1.Text = "Valider"
        Button2.Text = "Annuler"

        ' La fenêtre est centrée quand elle s'ouvre

        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

End Class