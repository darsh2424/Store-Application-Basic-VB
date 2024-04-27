<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.disp_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.book_panel = New System.Windows.Forms.Panel()
        Me.lbl_books = New System.Windows.Forms.Label()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panel_close_img = New System.Windows.Forms.PictureBox()
        Me.btn_add_book = New System.Windows.Forms.Button()
        Me.btn_add_cat = New System.Windows.Forms.Button()
        Me.book_panel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_close_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'disp_panel
        '
        Me.disp_panel.Location = New System.Drawing.Point(26, 69)
        Me.disp_panel.Name = "disp_panel"
        Me.disp_panel.Size = New System.Drawing.Size(905, 537)
        Me.disp_panel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "XYZ BOOK STORE"
        '
        'book_panel
        '
        Me.book_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.book_panel.Controls.Add(Me.btn_add_book)
        Me.book_panel.Controls.Add(Me.lbl_books)
        Me.book_panel.Controls.Add(Me.lbl_cat)
        Me.book_panel.Controls.Add(Me.Label3)
        Me.book_panel.Controls.Add(Me.Label2)
        Me.book_panel.Controls.Add(Me.DataGridView1)
        Me.book_panel.Controls.Add(Me.panel_close_img)
        Me.book_panel.Enabled = False
        Me.book_panel.Location = New System.Drawing.Point(408, 9)
        Me.book_panel.Name = "book_panel"
        Me.book_panel.Size = New System.Drawing.Size(560, 605)
        Me.book_panel.TabIndex = 7
        Me.book_panel.Visible = False
        '
        'lbl_books
        '
        Me.lbl_books.AutoSize = True
        Me.lbl_books.Location = New System.Drawing.Point(140, 62)
        Me.lbl_books.Name = "lbl_books"
        Me.lbl_books.Size = New System.Drawing.Size(39, 13)
        Me.lbl_books.TabIndex = 8
        Me.lbl_books.Text = "Label4"
        '
        'lbl_cat
        '
        Me.lbl_cat.AutoSize = True
        Me.lbl_cat.Location = New System.Drawing.Point(140, 21)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cat.TabIndex = 7
        Me.lbl_cat.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Books : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Book Category : "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(556, 496)
        Me.DataGridView1.TabIndex = 4
        '
        'panel_close_img
        '
        Me.panel_close_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel_close_img.Image = CType(resources.GetObject("panel_close_img.Image"), System.Drawing.Image)
        Me.panel_close_img.Location = New System.Drawing.Point(524, 2)
        Me.panel_close_img.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_close_img.Name = "panel_close_img"
        Me.panel_close_img.Size = New System.Drawing.Size(34, 35)
        Me.panel_close_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.panel_close_img.TabIndex = 3
        Me.panel_close_img.TabStop = False
        '
        'btn_add_book
        '
        Me.btn_add_book.BackColor = System.Drawing.Color.Silver
        Me.btn_add_book.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_add_book.FlatAppearance.BorderSize = 0
        Me.btn_add_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_add_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_add_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_book.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_book.Location = New System.Drawing.Point(372, 25)
        Me.btn_add_book.Name = "btn_add_book"
        Me.btn_add_book.Size = New System.Drawing.Size(124, 36)
        Me.btn_add_book.TabIndex = 19
        Me.btn_add_book.Text = "Add Books"
        Me.btn_add_book.UseVisualStyleBackColor = False
        '
        'btn_add_cat
        '
        Me.btn_add_cat.BackColor = System.Drawing.Color.Silver
        Me.btn_add_cat.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_add_cat.FlatAppearance.BorderSize = 0
        Me.btn_add_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_add_cat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_add_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_cat.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_cat.Location = New System.Drawing.Point(781, 27)
        Me.btn_add_cat.Name = "btn_add_cat"
        Me.btn_add_cat.Size = New System.Drawing.Size(150, 36)
        Me.btn_add_cat.TabIndex = 20
        Me.btn_add_cat.Text = "Add Category"
        Me.btn_add_cat.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(970, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add_cat)
        Me.Controls.Add(Me.book_panel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.disp_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.ShowIcon = False
        Me.book_panel.ResumeLayout(False)
        Me.book_panel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_close_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents disp_panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents book_panel As System.Windows.Forms.Panel
    Friend WithEvents lbl_books As System.Windows.Forms.Label
    Friend WithEvents lbl_cat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents panel_close_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_add_book As System.Windows.Forms.Button
    Friend WithEvents btn_add_cat As System.Windows.Forms.Button
End Class
