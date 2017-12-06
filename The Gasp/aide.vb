Public Class aide

    ' résolution de l'écran

    Dim ResWidth As Short = Screen.PrimaryScreen.Bounds.Width
    Dim ResHeight As Short = Screen.PrimaryScreen.Bounds.Height

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' dimensions de la fenêtre

        Me.Width = 613
        Me.Height = 709

    End Sub
End Class