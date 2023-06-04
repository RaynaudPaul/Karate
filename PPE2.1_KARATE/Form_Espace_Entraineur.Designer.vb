<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Espace_Entraineur
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_Modif_Suppr = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(305, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ESPACE ENTRAINEUR"
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(354, 34)
        Me.Cmd_Ajouter.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(345, 63)
        Me.Cmd_Ajouter.TabIndex = 1
        Me.Cmd_Ajouter.Text = "AJOUTER"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Fermer.Location = New System.Drawing.Point(354, 246)
        Me.Cmd_Fermer.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(345, 63)
        Me.Cmd_Fermer.TabIndex = 4
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 99)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Modif_Suppr)
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel2.Location = New System.Drawing.Point(13, 148)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1041, 375)
        Me.Panel2.TabIndex = 6
        '
        'Cmd_Modif_Suppr
        '
        Me.Cmd_Modif_Suppr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Modif_Suppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Cmd_Modif_Suppr.Location = New System.Drawing.Point(354, 141)
        Me.Cmd_Modif_Suppr.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmd_Modif_Suppr.Name = "Cmd_Modif_Suppr"
        Me.Cmd_Modif_Suppr.Size = New System.Drawing.Size(345, 63)
        Me.Cmd_Modif_Suppr.TabIndex = 5
        Me.Cmd_Modif_Suppr.Text = "MODIFIER/SUPPR"
        Me.Cmd_Modif_Suppr.UseVisualStyleBackColor = True
        '
        'Form_Espace_Entraineur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Espace_Entraineur"
        Me.Text = "Form_Espace_Entraineur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmd_Ajouter As Button
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cmd_Modif_Suppr As Button
End Class
