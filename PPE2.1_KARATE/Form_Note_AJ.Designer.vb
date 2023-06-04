<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Note_AJ
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
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Grid_Note = New System.Windows.Forms.DataGridView()
        Me.Num_Licence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.TxtComp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.Grid_Note, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(221, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(662, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES NOTES [AJOUTER]"
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(242, 29)
        Me.Cmd_Ajouter.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(192, 58)
        Me.Cmd_Ajouter.TabIndex = 1
        Me.Cmd_Ajouter.Text = "AJOUTER"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Fermer.Location = New System.Drawing.Point(694, 29)
        Me.Cmd_Fermer.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(185, 58)
        Me.Cmd_Fermer.TabIndex = 2
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Grid_Note
        '
        Me.Grid_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Note.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num_Licence, Me.Nom, Me.Prenom})
        Me.Grid_Note.Location = New System.Drawing.Point(206, 4)
        Me.Grid_Note.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid_Note.Name = "Grid_Note"
        Me.Grid_Note.RowHeadersWidth = 51
        Me.Grid_Note.Size = New System.Drawing.Size(692, 149)
        Me.Grid_Note.TabIndex = 3
        '
        'Num_Licence
        '
        Me.Num_Licence.HeaderText = "Num_Licence"
        Me.Num_Licence.MinimumWidth = 6
        Me.Num_Licence.Name = "Num_Licence"
        Me.Num_Licence.Width = 125
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.MinimumWidth = 6
        Me.Nom.Name = "Nom"
        Me.Nom.Width = 125
        '
        'Prenom
        '
        Me.Prenom.HeaderText = "Prenom"
        Me.Prenom.MinimumWidth = 6
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 87)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtNote)
        Me.Panel2.Controls.Add(Me.TxtComp)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Grid_Note)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(13, 111)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 300)
        Me.Panel2.TabIndex = 5
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(435, 222)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(260, 26)
        Me.TxtNote.TabIndex = 9
        '
        'TxtComp
        '
        Me.TxtComp.Location = New System.Drawing.Point(435, 161)
        Me.TxtComp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(260, 26)
        Me.TxtComp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(203, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Note (sur 10)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(202, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numéro_Competition"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cmd_Fermer)
        Me.Panel3.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel3.Location = New System.Drawing.Point(13, 427)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1071, 104)
        Me.Panel3.TabIndex = 6
        '
        'Form_Note_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1097, 560)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Note_AJ"
        Me.Text = "Form_Note_AJ"
        CType(Me.Grid_Note, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmd_Ajouter As Button
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Grid_Note As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents TxtComp As TextBox
    Friend WithEvents Num_Licence As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
End Class
