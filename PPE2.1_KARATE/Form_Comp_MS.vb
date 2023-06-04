Imports System.Data.OleDb

Public Class Form_Comp_MS
    Private Sub Form_Comp_MS_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Grid_Comp.Rows.Clear()
        Me.Grid_Comp.ColumnCount = 4
        Me.Grid_Comp.Columns(0).Width = 90
        Me.Grid_Comp.Columns(1).Width = 200
        Me.Grid_Comp.Columns(0).Name = "NumCompetition"
        Me.Grid_Comp.Columns(1).Name = "DateCompetition"
        Me.Grid_Comp.Columns(2).Name = "NumClub"
        Me.Grid_Comp.Columns(3).Name = "NomClub"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Me.Grid_Comp.AllowUserToAddRows = False





        Dim requete As String
        requete = "select * from COMPETITION"
        Dim cmdRech As New OleDbCommand(requete, maConnexion)
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        Dim requeteNomClub As String
        requeteNomClub = "select CLUB.NUM_CLUB, CLUB.NOM_CLUB, NUM_COMPETITION, DATE_COMPETITION from (CLUB INNER JOIN COMPETITION ON CLUB.NUM_CLUB = COMPETITION.NUM_CLUB)"
        Dim cmdRech2 As New OleDbCommand(requeteNomClub, maConnexion)
        Dim rdrRech2 As OleDbDataReader = cmdRech2.ExecuteReader()

        While (rdrRech2.Read())
            Me.Grid_Comp.Rows.Add()
            numLigne = Me.Grid_Comp.RowCount - 1
            Me.Grid_Comp.Item(0, numLigne).Value = rdrRech2.Item("NUM_COMPETITION")
            Me.Grid_Comp.Item(1, numLigne).Value = rdrRech2.Item("DATE_COMPETITION")
            Me.Grid_Comp.Item(2, numLigne).Value = rdrRech2.Item("NUM_CLUB")
            Me.Grid_Comp.Item(3, numLigne).Value = rdrRech2.Item("NOM_CLUB")
        End While
        Grid_Comp.Sort(Num_Competition, 0)
        'Permet de trier par numéro de compétition.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Supprimer.Click
        Dim nbligne As Integer
        nbligne = Me.Grid_Comp.CurrentRow.Index
        Dim num_comp As Integer
        num_comp = Grid_Comp.Item(0, nbligne).Value
        Dim reqdel As String = "delete from competition where NUM_COMPETITION = @num_comp"
        Dim cmdDelete As New OleDbCommand(reqdel, maConnexion)
        cmdDelete.Parameters.AddWithValue("@num_comp", num_comp)
        Dim rdrRech As OleDbDataReader = cmdDelete.ExecuteReader()
        rdrRech.Read()
        Form_Comp_MS_load(sender, e)
        MsgBox("Compétition suprimée")
        Grid_Comp.Refresh()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier.Click
        Dim nbligne As Integer
        nbligne = Me.Grid_Comp.CurrentRow.Index


        Dim req As String = "UPDATE COMPETITION SET NUM_CLUB = @num_club, DATE_COMPETITION = @date_comp WHERE NUM_COMPETITION = @num_comp"
        Dim cmdModif As New OleDbCommand(req, maConnexion)

        cmdModif.Parameters.AddWithValue("@num_club", Txt_Numclub.Text)
        cmdModif.Parameters.AddWithValue("@date_comp", DateTimePicker.Value)
        cmdModif.Parameters.AddWithValue("@num_comp", Txt_Numcomp.Text)
        Try
            cmdModif.ExecuteNonQuery()
            Form_Comp_MS_load(sender, e)
            MsgBox("Compétition modifiée !")
            Txt_Numclub.Clear()
        Catch ex As Exception
            MessageBox.Show("Ce numéro de club n'existe pas !")
            Txt_Numclub.Clear()
        End Try




    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Comp.CellClick
        Dim nbligne As Integer
        nbligne = Me.Grid_Comp.CurrentRow.Index
        Dim num_comp As Integer = Grid_Comp.Item(0, nbligne).Value
        Dim date_comp As String = Grid_Comp.Item(1, nbligne).Value
        Dim num_club As Integer = Grid_Comp.Item(2, nbligne).Value
        Dim nom_club As String = Grid_Comp.Item(3, nbligne).Value
        Txt_Numcomp.Text = num_comp
        DateTimePicker.Text = date_comp
        Txt_Numclub.Text = num_club
        Txt_Nomclub.Text = nom_club
        Me.Update()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Comp.CellContentClick

    End Sub
End Class