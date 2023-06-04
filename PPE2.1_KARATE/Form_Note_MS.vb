Imports System.Data.OleDb

Public Class Form_Note_MS

    Private Sub Form_Comp_MS_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Grid_Membre.Rows.Clear()
        Me.Grid_Membre.ColumnCount = 3
        Me.Grid_Membre.Columns(0).Width = 90
        Me.Grid_Membre.Columns(1).Width = 200
        Me.Grid_Membre.Columns(0).Name = "NumLicence"
        Me.Grid_Membre.Columns(1).Name = "Prénom"
        Me.Grid_Membre.Columns(2).Name = "Nom"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Me.Grid_Membre.AllowUserToAddRows = False



        Dim numLigne As Integer
        Dim requeteMembre As String
        requeteMembre = "select NUM_LICENCE, NOM_MEMBRE, PRENOM_MEMBRE from MEMBRE"
        Dim cmdRech2 As New OleDbCommand(requeteMembre, maConnexion)
        Dim rdrRech2 As OleDbDataReader = cmdRech2.ExecuteReader()
        While (rdrRech2.Read())
            Me.Grid_Membre.Rows.Add()
            numLigne = Me.Grid_Membre.RowCount - 1
            Me.Grid_Membre.Item(0, numLigne).Value = rdrRech2.Item("NUM_LICENCE")
            Me.Grid_Membre.Item(1, numLigne).Value = rdrRech2.Item("NOM_MEMBRE")
            Me.Grid_Membre.Item(2, numLigne).Value = rdrRech2.Item("PRENOM_MEMBRE")
        End While


    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Membre.CellClick

        Me.Grid_Note.Rows.Clear()
        Me.Grid_Note.ColumnCount = 2
        Me.Grid_Note.Columns(0).Width = 90
        Me.Grid_Note.Columns(1).Width = 200
        Me.Grid_Note.Columns(0).Name = "NumCompetition"
        Me.Grid_Note.Columns(1).Name = "Note"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Me.Grid_Note.AllowUserToAddRows = False
        Dim nbligne2 As Integer = Me.Grid_Membre.CurrentRow.Index
        Dim resultat As String = Grid_Membre.Item(1, nbligne2).Value
        Dim requeteMembre As String
        requeteMembre = "select NUM_LICENCE from MEMBRE where NOM_MEMBRE = @resultat"
        Dim cmdRech2 As New OleDbCommand(requeteMembre, maConnexion)
        cmdRech2.Parameters.AddWithValue("@resultat", resultat)
        Dim NumLicence As String = cmdRech2.ExecuteScalar

        Dim nomEntraineur As String = FormEntraineur_Connexion.nom_entraineur
        Dim requeteentraineur As String = "select NUM_ENTRAINEUR from ENTRAINEUR where NOM_ENTRAINEUR = @nomentraineur"
        Dim cmdReqentraineur As New OleDbCommand(requeteentraineur, maConnexion)
        cmdReqentraineur.Parameters.AddWithValue("@nomentraineur", nomEntraineur)
        Dim numEntraineur = cmdReqentraineur.ExecuteScalar
        Dim numLigne As Integer
        Dim requeteNum As String
        requeteNum = "select NUM_COMPETITION,NOTE2 from NOTE1 Where NUM_LICENCE = @numlicence and NUM_ENTRAINEUR = @nomentraineur"
        Dim cmdRech3 As New OleDbCommand(requeteNum, maConnexion)
        cmdRech3.Parameters.AddWithValue("@numlicence", NumLicence)
        cmdRech3.Parameters.AddWithValue("@numentraineur", numEntraineur)
        Dim rdrRech2 As OleDbDataReader = cmdRech3.ExecuteReader()


        While (rdrRech2.Read())
            Me.Grid_Note.Rows.Add()
            numLigne = Me.Grid_Note.RowCount - 1
            Me.Grid_Note.Item(0, numLigne).Value = rdrRech2.Item("NUM_COMPETITION")
            Me.Grid_Note.Item(1, numLigne).Value = rdrRech2.Item("NOTE2")
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
        Form_Espace_Entraineur.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Supprimer.Click
        Dim nbligne As Integer = Me.Grid_Membre.CurrentRow.Index
        Dim numLicence As String = Grid_Membre.Item(0, nbligne).Value
        Dim nbligne1 As Integer = Me.Grid_Note.CurrentRow.Index
        Dim num_comp As Integer = Grid_Note.Item(0, nbligne1).Value
        Dim note As Integer = Grid_Note.Item(1, nbligne1).Value
        Dim reqdel As String = "delete from competition where NUM_COMPETITION = @num_comp and NUM_LICENCE = @num_licence and note = @note"
        Dim cmdDelete As New OleDbCommand(reqdel, maConnexion)
        cmdDelete.Parameters.AddWithValue("@num_comp", num_comp)
        cmdDelete.Parameters.AddWithValue("@num_licence", numLicence)
        cmdDelete.Parameters.AddWithValue("@note", note)
        Dim rdrRech As OleDbDataReader = cmdDelete.ExecuteReader()
        rdrRech.Read()
        TxtNote.Clear()
        Form_Comp_MS_load(sender, e)
        MsgBox("Note suprimée")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier.Click
        Dim nbligne As Integer = Me.Grid_Membre.CurrentRow.Index
        Dim numLicence As String = Grid_Membre.Item(0, nbligne).Value
        Dim nbligne1 As Integer = Me.Grid_Note.CurrentRow.Index
        Dim num_comp As Integer = Grid_Note.Item(0, nbligne1).Value
        Dim note As Double = TxtNote.Text
        If (note > 10 Or note < 0) Then
            MsgBox("La note doit être comprise entre 0 et 10 !")
            TxtNote.Clear()
        Else
            Dim req As String = "UPDATE NOTE1 SET NOTE2 = @note WHERE NUM_COMPETITION = @num_comp and NUM_LICENCE = @num_licence"
            Dim cmdModif As New OleDbCommand(req, maConnexion)

            cmdModif.Parameters.AddWithValue("@note", note)
            cmdModif.Parameters.AddWithValue("@num_comp", num_comp)
            cmdModif.Parameters.AddWithValue("@num_licence", numLicence)

            cmdModif.ExecuteNonQuery()
            TxtNote.Clear()
            Form_Comp_MS_load(sender, e)
            MsgBox("Note modifiée !")
        End If



    End Sub

End Class