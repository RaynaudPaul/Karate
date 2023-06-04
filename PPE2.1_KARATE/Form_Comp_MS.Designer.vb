<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Comp_MS
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grid_Comp = New System.Windows.Forms.DataGridView()
        Me.Num_Competition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Competition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Club = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Club = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Numcomp = New System.Windows.Forms.TextBox()
        Me.Txt_Numclub = New System.Windows.Forms.TextBox()
        Me.Txt_Nomclub = New System.Windows.Forms.TextBox()
        Me.Cmd_Modifier = New System.Windows.Forms.Button()
        Me.Cmd_Supprimer = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.Grid_Comp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 84)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPETITION [MODIF/SUPPR]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid_Comp
        '
        Me.Grid_Comp.AllowUserToOrderColumns = True
        Me.Grid_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Comp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num_Competition, Me.Date_Competition, Me.Num_Club, Me.Nom_Club})
        Me.Grid_Comp.Location = New System.Drawing.Point(9, 3)
        Me.Grid_Comp.Name = "Grid_Comp"
        Me.Grid_Comp.RowHeadersWidth = 51
        Me.Grid_Comp.RowTemplate.Height = 24
        Me.Grid_Comp.Size = New System.Drawing.Size(738, 171)
        Me.Grid_Comp.TabIndex = 1
        '
        'Num_Competition
        '
        Me.Num_Competition.HeaderText = "Num_Competition"
        Me.Num_Competition.MinimumWidth = 6
        Me.Num_Competition.Name = "Num_Competition"
        Me.Num_Competition.ReadOnly = True
        Me.Num_Competition.Width = 125
        '
        'Date_Competition
        '
        Me.Date_Competition.HeaderText = "Date_Competition"
        Me.Date_Competition.MinimumWidth = 6
        Me.Date_Competition.Name = "Date_Competition"
        Me.Date_Competition.ReadOnly = True
        Me.Date_Competition.Width = 125
        '
        'Num_Club
        '
        Me.Num_Club.HeaderText = "Num_Club"
        Me.Num_Club.MinimumWidth = 6
        Me.Num_Club.Name = "Num_Club"
        Me.Num_Club.ReadOnly = True
        Me.Num_Club.Width = 125
        '
        'Nom_Club
        '
        Me.Nom_Club.HeaderText = "Nom_Club"
        Me.Nom_Club.MinimumWidth = 6
        Me.Nom_Club.Name = "Nom_Club"
        Me.Nom_Club.ReadOnly = True
        Me.Nom_Club.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Num_Competition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nom_Competition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Num_Club"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nom_Club"
        '
        'Txt_Numcomp
        '
        Me.Txt_Numcomp.Enabled = False
        Me.Txt_Numcomp.Location = New System.Drawing.Point(198, 180)
        Me.Txt_Numcomp.Name = "Txt_Numcomp"
        Me.Txt_Numcomp.ReadOnly = True
        Me.Txt_Numcomp.Size = New System.Drawing.Size(309, 22)
        Me.Txt_Numcomp.TabIndex = 6
        '
        'Txt_Numclub
        '
        Me.Txt_Numclub.Location = New System.Drawing.Point(198, 246)
        Me.Txt_Numclub.Name = "Txt_Numclub"
        Me.Txt_Numclub.Size = New System.Drawing.Size(309, 22)
        Me.Txt_Numclub.TabIndex = 8
        '
        'Txt_Nomclub
        '
        Me.Txt_Nomclub.Enabled = False
        Me.Txt_Nomclub.Location = New System.Drawing.Point(198, 280)
        Me.Txt_Nomclub.Name = "Txt_Nomclub"
        Me.Txt_Nomclub.ReadOnly = True
        Me.Txt_Nomclub.Size = New System.Drawing.Size(309, 22)
        Me.Txt_Nomclub.TabIndex = 9
        '
        'Cmd_Modifier
        '
        Me.Cmd_Modifier.BackColor = System.Drawing.Color.Silver
        Me.Cmd_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Modifier.Location = New System.Drawing.Point(604, 191)
        Me.Cmd_Modifier.Name = "Cmd_Modifier"
        Me.Cmd_Modifier.Size = New System.Drawing.Size(126, 32)
        Me.Cmd_Modifier.TabIndex = 10
        Me.Cmd_Modifier.Text = "Modifier"
        Me.Cmd_Modifier.UseVisualStyleBackColor = False
        '
        'Cmd_Supprimer
        '
        Me.Cmd_Supprimer.BackColor = System.Drawing.Color.Silver
        Me.Cmd_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Supprimer.Location = New System.Drawing.Point(604, 229)
        Me.Cmd_Supprimer.Name = "Cmd_Supprimer"
        Me.Cmd_Supprimer.Size = New System.Drawing.Size(126, 35)
        Me.Cmd_Supprimer.TabIndex = 11
        Me.Cmd_Supprimer.Text = "Supprimer"
        Me.Cmd_Supprimer.UseVisualStyleBackColor = False
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.BackColor = System.Drawing.Color.Silver
        Me.Cmd_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(604, 270)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(126, 32)
        Me.Cmd_Fermer.TabIndex = 12
        Me.Cmd_Fermer.Text = "Fermer"
        Me.Cmd_Fermer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker)
        Me.Panel1.Controls.Add(Me.Cmd_Fermer)
        Me.Panel1.Controls.Add(Me.Cmd_Supprimer)
        Me.Panel1.Controls.Add(Me.Cmd_Modifier)
        Me.Panel1.Controls.Add(Me.Txt_Nomclub)
        Me.Panel1.Controls.Add(Me.Txt_Numclub)
        Me.Panel1.Controls.Add(Me.Txt_Numcomp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Grid_Comp)
        Me.Panel1.Location = New System.Drawing.Point(12, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 318)
        Me.Panel1.TabIndex = 13
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "21/01/2021"
        Me.DateTimePicker.Location = New System.Drawing.Point(198, 214)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(309, 22)
        Me.DateTimePicker.TabIndex = 13
        Me.DateTimePicker.Value = New Date(2021, 1, 21, 0, 0, 0, 0)
        '
        'Form_Comp_MS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Comp_MS"
        Me.Text = "Form_Comp_MS"
        CType(Me.Grid_Comp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Grid_Comp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Numcomp As TextBox
    Friend WithEvents Txt_Numclub As TextBox
    Friend WithEvents Txt_Nomclub As TextBox
    Friend WithEvents Cmd_Modifier As Button
    Friend WithEvents Cmd_Supprimer As Button
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Num_Competition As DataGridViewTextBoxColumn
    Friend WithEvents Date_Competition As DataGridViewTextBoxColumn
    Friend WithEvents Num_Club As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Club As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker As DateTimePicker
End Class
