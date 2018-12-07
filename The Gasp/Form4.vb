' TODO : vérifier si tous les boutons des formulaires d'options ont bien tous les mêmes dimensions

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.wood

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.fond

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Form3.BackgroundImage = The_Gasp.My.Resources.Resource1.herbe

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class