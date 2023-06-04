<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.title = New System.Windows.Forms.Label()
        Me.Cmd_GoTo_Ajout = New System.Windows.Forms.Button()
        Me.Cmd_GoTo_Modif = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(12, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(775, 91)
        Me.title.TabIndex = 0
        Me.title.Text = "Espace Competition"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_GoTo_Ajout
        '
        Me.Cmd_GoTo_Ajout.AllowDrop = True
        Me.Cmd_GoTo_Ajout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmd_GoTo_Ajout.BackColor = System.Drawing.Color.Silver
        Me.Cmd_GoTo_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_GoTo_Ajout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_GoTo_Ajout.FlatAppearance.BorderSize = 2
        Me.Cmd_GoTo_Ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_GoTo_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_GoTo_Ajout.Location = New System.Drawing.Point(219, 14)
        Me.Cmd_GoTo_Ajout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_GoTo_Ajout.Name = "Cmd_GoTo_Ajout"
        Me.Cmd_GoTo_Ajout.Size = New System.Drawing.Size(341, 50)
        Me.Cmd_GoTo_Ajout.TabIndex = 1
        Me.Cmd_GoTo_Ajout.Text = "Ajout de Competition"
        Me.Cmd_GoTo_Ajout.UseVisualStyleBackColor = False
        '
        'Cmd_GoTo_Modif
        '
        Me.Cmd_GoTo_Modif.AllowDrop = True
        Me.Cmd_GoTo_Modif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmd_GoTo_Modif.BackColor = System.Drawing.Color.Silver
        Me.Cmd_GoTo_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_GoTo_Modif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_GoTo_Modif.FlatAppearance.BorderSize = 2
        Me.Cmd_GoTo_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_GoTo_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_GoTo_Modif.Location = New System.Drawing.Point(162, 88)
        Me.Cmd_GoTo_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_GoTo_Modif.Name = "Cmd_GoTo_Modif"
        Me.Cmd_GoTo_Modif.Size = New System.Drawing.Size(456, 142)
        Me.Cmd_GoTo_Modif.TabIndex = 2
        Me.Cmd_GoTo_Modif.Text = "Modification et suppression de Competition"
        Me.Cmd_GoTo_Modif.UseVisualStyleBackColor = False
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.AllowDrop = True
        Me.Cmd_Fermer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmd_Fermer.BackColor = System.Drawing.Color.Silver
        Me.Cmd_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Fermer.FlatAppearance.BorderSize = 2
        Me.Cmd_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(268, 252)
        Me.Cmd_Fermer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(237, 50)
        Me.Cmd_Fermer.TabIndex = 4
        Me.Cmd_Fermer.Text = "Fermer"
        Me.Cmd_Fermer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Cmd_Fermer)
        Me.Panel1.Controls.Add(Me.Cmd_GoTo_Modif)
        Me.Panel1.Controls.Add(Me.Cmd_GoTo_Ajout)
        Me.Panel1.Location = New System.Drawing.Point(12, 121)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 316)
        Me.Panel1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.title)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents Cmd_GoTo_Ajout As Button
    Friend WithEvents Cmd_GoTo_Modif As Button
    Friend WithEvents Cmd_Fermer As Button
    Public WithEvents Panel1 As Panel
End Class
