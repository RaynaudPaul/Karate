Imports System.Data.OleDb


Public Class FormEntraineur_Connexion
    Public nom_entraineur As String

    Private Sub FormEntraineur_Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Connexion.Click
        Dim nom As String = TxtNom.Text
        Dim req As String = "Select NOM_ENTRAINEUR from ENTRAINEUR WHERE NOM_ENTRAINEUR = @nom"
        Dim cmdCheck As New OleDbCommand(req, maConnexion)
        cmdCheck.Parameters.AddWithValue("@nom", nom)
        Dim rdrRech As OleDbDataReader = cmdCheck.ExecuteReader()
        Dim test As String = rdrRech.Read()

        If test Then
            TxtNom.Clear()
            nom_entraineur = nom
            Me.Hide()
            Form_Espace_Entraineur.Show()
        Else
            MsgBox("Cet utilisateur n'existe pas !")
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        TxtNom.Clear()
        Me.Close()
        FormMenuComp_Note.Show()
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged

    End Sub
End Class