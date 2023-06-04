Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_GoTo_Ajout.Click
        Form_Comp_AJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_GoTo_Modif.Click
        Form_Comp_MS.Show()
        Me.Hide()
    End Sub


    Private Sub Cmd_fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
        FormMenuComp_Note.Show()
    End Sub
End Class