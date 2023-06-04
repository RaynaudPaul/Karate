<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Note_MS
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Grid_Note = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.Grid_Membre = New System.Windows.Forms.DataGridView()
        Me.Numéro_Licence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prénom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cmd_Modifier = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Cmd_Supprimer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid_Note, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(939, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES NOTES [MODIFIER / SUPPRIMER]"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 83)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Grid_Note)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtNote)
        Me.Panel2.Controls.Add(Me.Grid_Membre)
        Me.Panel2.Location = New System.Drawing.Point(13, 111)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1035, 311)
        Me.Panel2.TabIndex = 16
        '
        'Grid_Note
        '
        Me.Grid_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Note.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Grid_Note.Location = New System.Drawing.Point(317, 120)
        Me.Grid_Note.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid_Note.Name = "Grid_Note"
        Me.Grid_Note.RowHeadersWidth = 51
        Me.Grid_Note.Size = New System.Drawing.Size(424, 120)
        Me.Grid_Note.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumCompetition"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(258, 267)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Note (sur 10)"
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(481, 267)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(260, 22)
        Me.TxtNote.TabIndex = 11
        '
        'Grid_Membre
        '
        Me.Grid_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numéro_Licence, Me.Prénom, Me.Nom})
        Me.Grid_Membre.Location = New System.Drawing.Point(177, 4)
        Me.Grid_Membre.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid_Membre.Name = "Grid_Membre"
        Me.Grid_Membre.RowHeadersWidth = 51
        Me.Grid_Membre.Size = New System.Drawing.Size(704, 108)
        Me.Grid_Membre.TabIndex = 3
        '
        'Numéro_Licence
        '
        Me.Numéro_Licence.HeaderText = "Numéro_Licence"
        Me.Numéro_Licence.MinimumWidth = 6
        Me.Numéro_Licence.Name = "Numéro_Licence"
        Me.Numéro_Licence.Width = 125
        '
        'Prénom
        '
        Me.Prénom.HeaderText = "Prénom"
        Me.Prénom.MinimumWidth = 6
        Me.Prénom.Name = "Prénom"
        Me.Prénom.Width = 125
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.MinimumWidth = 6
        Me.Nom.Name = "Nom"
        Me.Nom.Width = 125
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cmd_Modifier)
        Me.Panel3.Controls.Add(Me.Cmd_Fermer)
        Me.Panel3.Controls.Add(Me.Cmd_Supprimer)
        Me.Panel3.Location = New System.Drawing.Point(13, 430)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1035, 109)
        Me.Panel3.TabIndex = 17
        '
        'Cmd_Modifier
        '
        Me.Cmd_Modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Modifier.Location = New System.Drawing.Point(75, 20)
        Me.Cmd_Modifier.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Modifier.Name = "Cmd_Modifier"
        Me.Cmd_Modifier.Size = New System.Drawing.Size(241, 64)
        Me.Cmd_Modifier.TabIndex = 18
        Me.Cmd_Modifier.Text = "MODIFIER"
        Me.Cmd_Modifier.UseVisualStyleBackColor = True
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Fermer.Location = New System.Drawing.Point(735, 20)
        Me.Cmd_Fermer.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(219, 64)
        Me.Cmd_Fermer.TabIndex = 2
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Cmd_Supprimer
        '
        Me.Cmd_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Supprimer.Location = New System.Drawing.Point(399, 20)
        Me.Cmd_Supprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Supprimer.Name = "Cmd_Supprimer"
        Me.Cmd_Supprimer.Size = New System.Drawing.Size(241, 64)
        Me.Cmd_Supprimer.TabIndex = 1
        Me.Cmd_Supprimer.Text = "SUPPRIMER"
        Me.Cmd_Supprimer.UseVisualStyleBackColor = True
        '
        'Form_Note_MS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Note_MS"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Grid_Note, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents Grid_Membre As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Supprimer As Button
    Friend WithEvents Cmd_Modifier As Button
    Friend WithEvents Numéro_Licence As DataGridViewTextBoxColumn
    Friend WithEvents Prénom As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Grid_Note As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
