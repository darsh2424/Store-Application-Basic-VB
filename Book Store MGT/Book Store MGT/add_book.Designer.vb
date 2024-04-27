<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_book))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_aut = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_quan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vendor_gridview = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_img = New System.Windows.Forms.PictureBox()
        Me.txt_cat = New System.Windows.Forms.ComboBox()
        CType(Me.vendor_gridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(569, 565)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 29)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(320, 565)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 29)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(95, 565)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 29)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'txt_aut
        '
        Me.txt_aut.Location = New System.Drawing.Point(452, 439)
        Me.txt_aut.Name = "txt_aut"
        Me.txt_aut.Size = New System.Drawing.Size(168, 20)
        Me.txt_aut.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Author :"
        '
        'txt_quan
        '
        Me.txt_quan.Enabled = False
        Me.txt_quan.Location = New System.Drawing.Point(149, 511)
        Me.txt_quan.Name = "txt_quan"
        Me.txt_quan.Size = New System.Drawing.Size(168, 20)
        Me.txt_quan.TabIndex = 5
        Me.txt_quan.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 512)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Quantity :"
        '
        'txt_rate
        '
        Me.txt_rate.Location = New System.Drawing.Point(452, 514)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(168, 20)
        Me.txt_rate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(346, 514)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Rate Per Unit :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 477)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Category :"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(147, 437)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(168, 20)
        Me.txt_name.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Name :"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(147, 405)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(67, 20)
        Me.txt_id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Id :"
        '
        'vendor_gridview
        '
        Me.vendor_gridview.AllowUserToAddRows = False
        Me.vendor_gridview.AllowUserToDeleteRows = False
        Me.vendor_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vendor_gridview.BackgroundColor = System.Drawing.Color.White
        Me.vendor_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vendor_gridview.Location = New System.Drawing.Point(30, 39)
        Me.vendor_gridview.Name = "vendor_gridview"
        Me.vendor_gridview.Size = New System.Drawing.Size(624, 345)
        Me.vendor_gridview.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Add New Book"
        '
        'close_img
        '
        Me.close_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_img.Image = CType(resources.GetObject("close_img.Image"), System.Drawing.Image)
        Me.close_img.Location = New System.Drawing.Point(602, 6)
        Me.close_img.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.close_img.Name = "close_img"
        Me.close_img.Size = New System.Drawing.Size(33, 28)
        Me.close_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_img.TabIndex = 34
        Me.close_img.TabStop = False
        '
        'txt_cat
        '
        Me.txt_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_cat.FormattingEnabled = True
        Me.txt_cat.Location = New System.Drawing.Point(147, 472)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.Size = New System.Drawing.Size(121, 21)
        Me.txt_cat.TabIndex = 4
        '
        'add_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(685, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_cat)
        Me.Controls.Add(Me.close_img)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_aut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_quan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_rate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vendor_gridview)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.vendor_gridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_aut As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_quan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vendor_gridview As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents close_img As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cat As System.Windows.Forms.ComboBox
End Class
