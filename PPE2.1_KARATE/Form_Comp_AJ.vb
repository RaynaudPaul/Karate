Imports System.Data.OleDb

Public Class Form_Comp_AJ
    Private Sub FormAjoutPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Grid_Club.Rows.Clear()
        Me.Grid_Club.ColumnCount = 2
        Me.Grid_Club.Columns(0).Width = 90
        Me.Grid_Club.Columns(1).Width = 200
        Me.Grid_Club.Columns(0).Name = "NomClub"
        Me.Grid_Club.Columns(1).Name = "NumClub"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Me.Grid_Club.AllowUserToAddRows = False




        Dim requete As String
        requete = "select * from CLUB"
        Dim cmdRech As New OleDbCommand(requete, maConnexion)
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Me.Grid_Club.Rows.Add()
            numLigne = Me.Grid_Club.RowCount - 1
            Me.Grid_Club.Item(0, numLigne).Value = rdrRech.Item("NUM_CLUB")
            Me.Grid_Club.Item(1, numLigne).Value = rdrRech.Item("NOM_CLUB")
        End While



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdAjouter.Click
        Dim requeteInsert As String
        requeteInsert = "insert into COMPETITION values (@NUM_COMPETITION, @NUM_CLUB, @DATE_COMPETITION)"

        Dim requete As String
        requete = "select * from COMPETITION"

        Dim nbNum As Integer
        Dim cmdRech As New OleDbCommand(requete, maConnexion)
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim num_compet As Integer
        While (rdrRech.Read())
            nbNum = nbNum + 1
            num_compet = rdrRech.Item("NUM_COMPETITION")
        End While
        If nbNum < num_compet Then
            While nbNum < num_compet
                nbNum = nbNum + 1
            End While
        End If
        nbNum = nbNum + 1

        Dim nbligne As Integer
        nbligne = Me.Grid_Club.CurrentRow.Index
        Dim numClub As Integer
        numClub = Grid_Club.Item(0, nbligne).Value

        Dim cmdInsert As New OleDbCommand(requeteInsert, maConnexion)
        cmdInsert.Parameters.AddWithValue("@NUM_COMPETITION", nbNum)
        cmdInsert.Parameters.AddWithValue("@NUM_CLUB", numClub)
        cmdInsert.Parameters.AddWithValue("@DATE_COMPETITION", DateTimePicker.Value)
        cmdInsert.ExecuteNonQuery()
        MsgBox("Compétition créée")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CmdFermer.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Club.CellContentClick

    End Sub
End Class