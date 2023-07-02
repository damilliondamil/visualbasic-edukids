<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuguru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblnmgr = New System.Windows.Forms.Label()
        Me.lblidgr = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 368)
        Me.Panel1.TabIndex = 0
        Me.Panel1.UseWaitCursor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.lblnmgr)
        Me.Panel2.Controls.Add(Me.lblidgr)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(70, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 296)
        Me.Panel2.TabIndex = 0
        Me.Panel2.UseWaitCursor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(407, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 33)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Logout"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.UseWaitCursor = True
        '
        'lblnmgr
        '
        Me.lblnmgr.AutoSize = True
        Me.lblnmgr.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblnmgr.Location = New System.Drawing.Point(51, 127)
        Me.lblnmgr.Name = "lblnmgr"
        Me.lblnmgr.Size = New System.Drawing.Size(91, 19)
        Me.lblnmgr.TabIndex = 35
        Me.lblnmgr.Text = "Nama Guru"
        Me.lblnmgr.UseWaitCursor = True
        '
        'lblidgr
        '
        Me.lblidgr.AutoSize = True
        Me.lblidgr.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblidgr.Location = New System.Drawing.Point(51, 81)
        Me.lblidgr.Name = "lblidgr"
        Me.lblidgr.Size = New System.Drawing.Size(65, 19)
        Me.lblidgr.TabIndex = 34
        Me.lblidgr.Text = "Id Guru"
        Me.lblidgr.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(304, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Score Siswa"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(79, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 65)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Data Siswa"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(186, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Guru"
        Me.Label1.UseWaitCursor = True
        '
        'menuguru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "menuguru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuguru"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblidgr As Label
    Friend WithEvents lblnmgr As Label
    Friend WithEvents Button3 As Button
End Class
