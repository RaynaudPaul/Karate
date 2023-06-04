Public Class Form_Espace_Entraineur
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Form_Note_AJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Modif_Suppr.Click
        Form_Note_MS.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
        FormMenuComp_Note.Show()
    End Sub

    Private Sub Form_Espace_Entraineur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class