Imports System.Data.OleDb

Public Class Form_Note_AJ
    Private Sub FormAjoutPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Grid_Note.Rows.Clear()
        Me.Grid_Note.ColumnCount = 3
        Me.Grid_Note.Columns(0).Width = 90
        Me.Grid_Note.Columns(1).Width = 200
        Me.Grid_Note.Columns(0).Name = "Num_Licence"
        Me.Grid_Note.Columns(1).Name = "Nom"
        Me.Grid_Note.Columns(2).Name = "Prenom"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Me.Grid_Note.AllowUserToAddRows = False

        Dim requete As String
        requete = "select NUM_LICENCE, NOM_MEMBRE, PRENOM_MEMBRE from MEMBRE"
        Dim cmdRech As New OleDbCommand(requete, maConnexion)
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Me.Grid_Note.Rows.Add()
            numLigne = Me.Grid_Note.RowCount - 1
            Me.Grid_Note.Item(0, numLigne).Value = rdrRech.Item("NUM_LICENCE")
            Me.Grid_Note.Item(1, numLigne).Value = rdrRech.Item("NOM_MEMBRE")
            Me.Grid_Note.Item(2, numLigne).Value = rdrRech.Item("PRENOM_MEMBRE")
        End While

    End Sub
    Public nom_entraineur As String = FormEntraineur_Connexion.nom_entraineur

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Dim Num_Comp As Integer = TxtComp.Text
        Dim nbligne As Integer = Me.Grid_Note.CurrentRow.Index
        Dim numLicence As String = Grid_Note.Item(0, nbligne).Value
        Dim nom_entraineur As String = FormEntraineur_Connexion.nom_entraineur.ToUpper
        Dim note As Double = TxtNote.Text
        If (note > 10 Or note < 0) Then
            MsgBox("La note doit être comprise entre 0 et 10 !")
            TxtComp.Clear()
            TxtNote.Clear()
        Else
            Dim reqNumEntraineur As String = "select NUM_ENTRAINEUR from ENTRAINEUR where NOM_ENTRAINEUR = @nom_entraineur"
            Dim cmdRech As New OleDbCommand(reqNumEntraineur, maConnexion)
            cmdRech.Parameters.AddWithValue("@nom_entraineur", nom_entraineur)
            Dim resultat As Object = cmdRech.ExecuteScalar
            resultat = resultat.ToString

            Dim requeteInsert As String = "insert into NOTE1 values (@NUM_COMPETITION, @NUM_LICENCE, @NUM_ENTRAINEUR, @NOTE)"
            Dim cmdInsert As New OleDbCommand(requeteInsert, maConnexion)
            cmdInsert.Parameters.AddWithValue("@NUM_COMPETITION", Num_Comp)
            cmdInsert.Parameters.AddWithValue("@NUM_LICENCE", numLicence.ToString)
            cmdInsert.Parameters.AddWithValue("@NUM_ENTRAINEUR", resultat)
            cmdInsert.Parameters.AddWithValue("@NOTE", note)

            Try
                cmdInsert.ExecuteNonQuery()
                MsgBox("Note Ajoutée !")
                TxtComp.Clear()
                TxtNote.Clear()
            Catch ex As Exception
                If ex.Message.Contains("doublons") Then
                    MessageBox.Show("Vous avez déjà mis une note pour cette personne !")
                    TxtComp.Clear()
                    TxtNote.Clear()
                Else
                    MessageBox.Show("Cette compétition n'existe pas !")
                    TxtComp.Clear()
                    TxtNote.Clear()
                End If




            End Try

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
        Form_Espace_Entraineur.Show()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Note.CellContentClick

    End Sub
End Class