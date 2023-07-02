<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txttanggal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidscore = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidsiswa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtscore = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.txtkomen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 454)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dgv1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Txttanggal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtidscore)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtidsiswa)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtscore)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnedit)
        Me.Panel2.Controls.Add(Me.txtkomen)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(14, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(767, 419)
        Me.Panel2.TabIndex = 0
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(105, 247)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 62
        Me.dgv1.RowTemplate.Height = 25
        Me.dgv1.Size = New System.Drawing.Size(601, 169)
        Me.dgv1.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(683, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txttanggal
        '
        Me.Txttanggal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txttanggal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Txttanggal.Location = New System.Drawing.Point(232, 159)
        Me.Txttanggal.Name = "Txttanggal"
        Me.Txttanggal.ReadOnly = True
        Me.Txttanggal.Size = New System.Drawing.Size(372, 29)
        Me.Txttanggal.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(86, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Tanggal"
        '
        'txtidscore
        '
        Me.txtidscore.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtidscore.Location = New System.Drawing.Point(232, 60)
        Me.txtidscore.Name = "txtidscore"
        Me.txtidscore.ReadOnly = True
        Me.txtidscore.Size = New System.Drawing.Size(372, 23)
        Me.txtidscore.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(86, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ID Score"
        '
        'txtidsiswa
        '
        Me.txtidsiswa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtidsiswa.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtidsiswa.Location = New System.Drawing.Point(231, 89)
        Me.txtidsiswa.Name = "txtidsiswa"
        Me.txtidsiswa.ReadOnly = True
        Me.txtidsiswa.Size = New System.Drawing.Size(372, 29)
        Me.txtidsiswa.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(88, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "ID Siswa"
        '
        'txtscore
        '
        Me.txtscore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtscore.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtscore.Location = New System.Drawing.Point(232, 124)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.ReadOnly = True
        Me.txtscore.Size = New System.Drawing.Size(372, 29)
        Me.txtscore.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Score"
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(653, 171)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(105, 53)
        Me.btnedit.TabIndex = 46
        Me.btnedit.Text = "Edit / Masukan"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'txtkomen
        '
        Me.txtkomen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtkomen.Location = New System.Drawing.Point(232, 194)
        Me.txtkomen.Name = "txtkomen"
        Me.txtkomen.Size = New System.Drawing.Size(372, 29)
        Me.txtkomen.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(86, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Komentar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(311, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Score Siswa"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Txttanggal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidscore As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidsiswa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtscore As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnedit As Button
    Friend WithEvents txtkomen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv1 As DataGridView
End Class
