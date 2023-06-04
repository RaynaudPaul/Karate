Public Class FormMenuComp_Note
    Private Sub Form_Comp_Menu_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormEntraineur_Connexion.Show()
        Me.Hide()
    End Sub
End Class