<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_cat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_cat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cat_datagridview = New System.Windows.Forms.DataGridView()
        Me.close_img = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_books = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        CType(Me.cat_datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Category"
        '
        'cat_datagridview
        '
        Me.cat_datagridview.AllowUserToAddRows = False
        Me.cat_datagridview.AllowUserToDeleteRows = False
        Me.cat_datagridview.BackgroundColor = System.Drawing.Color.White
        Me.cat_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cat_datagridview.Location = New System.Drawing.Point(12, 42)
        Me.cat_datagridview.Name = "cat_datagridview"
        Me.cat_datagridview.ReadOnly = True
        Me.cat_datagridview.Size = New System.Drawing.Size(502, 205)
        Me.cat_datagridview.TabIndex = 1
        '
        'close_img
        '
        Me.close_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_img.Image = CType(resources.GetObject("close_img.Image"), System.Drawing.Image)
        Me.close_img.Location = New System.Drawing.Point(485, 9)
        Me.close_img.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.close_img.Name = "close_img"
        Me.close_img.Size = New System.Drawing.Size(33, 28)
        Me.close_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_img.TabIndex = 35
        Me.close_img.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(90, 270)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(167, 20)
        Me.txt_name.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Name:"
        '
        'txt_books
        '
        Me.txt_books.Enabled = False
        Me.txt_books.Location = New System.Drawing.Point(365, 270)
        Me.txt_books.Name = "txt_books"
        Me.txt_books.Size = New System.Drawing.Size(70, 20)
        Me.txt_books.TabIndex = 41
        Me.txt_books.Text = "0"
        Me.txt_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "No of Books:"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(340, 415)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 29)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(204, 415)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 29)
        Me.btn_update.TabIndex = 43
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(79, 415)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 29)
        Me.btn_add.TabIndex = 42
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(552, 205)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 302)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Image :"
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Silver
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(90, 298)
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(71, 25)
        Me.btn_browse.TabIndex = 46
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'txt_path
        '
        Me.txt_path.BackColor = System.Drawing.Color.Lavender
        Me.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_path.Enabled = False
        Me.txt_path.Location = New System.Drawing.Point(167, 305)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_path.Multiline = True
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(188, 63)
        Me.txt_path.TabIndex = 47
        Me.txt_path.Visible = False
        '
        'add_cat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(516, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_books)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.close_img)
        Me.Controls.Add(Me.cat_datagridview)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "add_cat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cat_datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cat_datagridview As System.Windows.Forms.DataGridView
    Friend WithEvents close_img As System.Windows.Forms.PictureBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_books As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents txt_path As System.Windows.Forms.TextBox
End Class
