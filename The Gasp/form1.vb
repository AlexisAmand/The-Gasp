' --------------
' Options du jeu
' --------------

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

        ' TODO: selection du verso n°6 dans les options

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        ' TODO: selection du verso n°7 dans les options

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

        ' TODO: selection du verso n°8 dans les options

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

        ' TODO: selection du verso n°9 dans les options

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

        ' TODO: selection du verso n°10 dans les options

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged

        ' TODO: selection du verso n°11 dans les options

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged

        ' TODO: selection du verso n°12 dans les options

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Application du nouveau dos des cartes et fermeture de la form des options

        Form3.afficher(VersoCarte)
        Form2.afficher(VersoCarte)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Application du nouveau dos des cartes 

        Form3.afficher(VersoCarte)
        Form2.afficher(VersoCarte)

    End Sub
End Class