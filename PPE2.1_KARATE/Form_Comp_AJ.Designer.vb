<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Comp_AJ
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
        Me.Grid_Club = New System.Windows.Forms.DataGridView()
        Me.Nom_Club = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Club = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CmdAjouter = New System.Windows.Forms.Button()
        Me.CmdFermer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.Grid_Club, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES COMPETITIONS [AJOUTER]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid_Club
        '
        Me.Grid_Club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Club.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom_Club, Me.Num_Club})
        Me.Grid_Club.Location = New System.Drawing.Point(146, 45)
        Me.Grid_Club.Name = "Grid_Club"
        Me.Grid_Club.RowHeadersWidth = 51
        Me.Grid_Club.RowTemplate.Height = 24
        Me.Grid_Club.Size = New System.Drawing.Size(403, 110)
        Me.Grid_Club.TabIndex = 1
        '
        'Nom_Club
        '
        Me.Nom_Club.HeaderText = "Nom_Club"
        Me.Nom_Club.MinimumWidth = 6
        Me.Nom_Club.Name = "Nom_Club"
        Me.Nom_Club.Width = 125
        '
        'Num_Club
        '
        Me.Num_Club.HeaderText = "Num_Club"
        Me.Num_Club.MinimumWidth = 6
        Me.Num_Club.Name = "Num_Club"
        Me.Num_Club.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Club : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date de Compétition : "
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "14/01/2021"
        Me.DateTimePicker.Location = New System.Drawing.Point(350, 206)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(224, 22)
        Me.DateTimePicker.TabIndex = 4
        Me.DateTimePicker.Value = New Date(2021, 1, 14, 0, 0, 0, 0)
        '
        'CmdAjouter
        '
        Me.CmdAjouter.BackColor = System.Drawing.Color.Silver
        Me.CmdAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdAjouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAjouter.Location = New System.Drawing.Point(210, 16)
        Me.CmdAjouter.Name = "CmdAjouter"
        Me.CmdAjouter.Size = New System.Drawing.Size(125, 42)
        Me.CmdAjouter.TabIndex = 5
        Me.CmdAjouter.Text = "Ajouter"
        Me.CmdAjouter.UseVisualStyleBackColor = False
        '
        'CmdFermer
        '
        Me.CmdFermer.BackColor = System.Drawing.Color.Silver
        Me.CmdFermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdFermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFermer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdFermer.Location = New System.Drawing.Point(450, 16)
        Me.CmdFermer.Name = "CmdFermer"
        Me.CmdFermer.Size = New System.Drawing.Size(125, 42)
        Me.CmdFermer.TabIndex = 6
        Me.CmdFermer.Text = "Fermer"
        Me.CmdFermer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Grid_Club)
        Me.Panel1.Location = New System.Drawing.Point(12, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 242)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CmdFermer)
        Me.Panel2.Controls.Add(Me.CmdAjouter)
        Me.Panel2.Location = New System.Drawing.Point(12, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 66)
        Me.Panel2.TabIndex = 8
        '
        'Form_Comp_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Comp_AJ"
        Me.Text = "Form_Comp_AJ"
        CType(Me.Grid_Club, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Grid_Club As DataGridView
    Friend WithEvents Nom_Club As DataGridViewTextBoxColumn
    Friend WithEvents Num_Club As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents CmdAjouter As Button
    Friend WithEvents CmdFermer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
