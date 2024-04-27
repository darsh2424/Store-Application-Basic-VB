<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_psw = New System.Windows.Forms.TextBox()
        Me.store_img = New System.Windows.Forms.PictureBox()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.close_img = New System.Windows.Forms.PictureBox()
        Me.error_msg = New System.Windows.Forms.Label()
        CType(Me.store_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PASSWORD:"
        '
        'txt_psw
        '
        Me.txt_psw.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_psw.Location = New System.Drawing.Point(208, 237)
        Me.txt_psw.Name = "txt_psw"
        Me.txt_psw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_psw.Size = New System.Drawing.Size(114, 27)
        Me.txt_psw.TabIndex = 1
        Me.txt_psw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'store_img
        '
        Me.store_img.Image = CType(resources.GetObject("store_img.Image"), System.Drawing.Image)
        Me.store_img.Location = New System.Drawing.Point(121, 62)
        Me.store_img.Name = "store_img"
        Me.store_img.Size = New System.Drawing.Size(210, 137)
        Me.store_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.store_img.TabIndex = 3
        Me.store_img.TabStop = False
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.Black
        Me.btn_go.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_go.Location = New System.Drawing.Point(375, 237)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(56, 30)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'close_img
        '
        Me.close_img.Image = CType(resources.GetObject("close_img.Image"), System.Drawing.Image)
        Me.close_img.Location = New System.Drawing.Point(446, 12)
        Me.close_img.Name = "close_img"
        Me.close_img.Size = New System.Drawing.Size(30, 28)
        Me.close_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_img.TabIndex = 6
        Me.close_img.TabStop = False
        '
        'error_msg
        '
        Me.error_msg.AutoSize = True
        Me.error_msg.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_msg.ForeColor = System.Drawing.Color.Red
        Me.error_msg.Location = New System.Drawing.Point(205, 274)
        Me.error_msg.Name = "error_msg"
        Me.error_msg.Size = New System.Drawing.Size(151, 17)
        Me.error_msg.TabIndex = 7
        Me.error_msg.Text = "* Incorrect Password "
        Me.error_msg.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(488, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.error_msg)
        Me.Controls.Add(Me.close_img)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.store_img)
        Me.Controls.Add(Me.txt_psw)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.store_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_psw As System.Windows.Forms.TextBox
    Friend WithEvents store_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents close_img As System.Windows.Forms.PictureBox
    Friend WithEvents error_msg As System.Windows.Forms.Label
End Class
