<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.date_purchase = New System.Windows.Forms.DateTimePicker()
        Me.book_dtl_panel = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_pdelete = New System.Windows.Forms.Button()
        Me.btn_pupdate = New System.Windows.Forms.Button()
        Me.btn_padd = New System.Windows.Forms.Button()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.cbx_book_cat = New System.Windows.Forms.ComboBox()
        Me.cbx_book_auth = New System.Windows.Forms.ComboBox()
        Me.cbx_book_name = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.purchase_datagrid = New System.Windows.Forms.DataGridView()
        Me.vendor_dtl_panel = New System.Windows.Forms.Panel()
        Me.cbx_vendor_city = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbx_vendor_name = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.p_txtbx_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_save_print = New System.Windows.Forms.Button()
        Me.book_dtl_panel.SuspendLayout()
        CType(Me.purchase_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vendor_dtl_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "XYZ BOOK STORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(547, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PURCHASE BILL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(940, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date:"
        '
        'date_purchase
        '
        Me.date_purchase.CustomFormat = "yyyy-MM-dd"
        Me.date_purchase.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_purchase.Location = New System.Drawing.Point(991, 34)
        Me.date_purchase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_purchase.Name = "date_purchase"
        Me.date_purchase.Size = New System.Drawing.Size(209, 27)
        Me.date_purchase.TabIndex = 1
        '
        'book_dtl_panel
        '
        Me.book_dtl_panel.Controls.Add(Me.btn_clear)
        Me.book_dtl_panel.Controls.Add(Me.btn_pdelete)
        Me.book_dtl_panel.Controls.Add(Me.btn_pupdate)
        Me.book_dtl_panel.Controls.Add(Me.btn_padd)
        Me.book_dtl_panel.Controls.Add(Me.txt_qty)
        Me.book_dtl_panel.Controls.Add(Me.txt_total)
        Me.book_dtl_panel.Controls.Add(Me.txt_rate)
        Me.book_dtl_panel.Controls.Add(Me.cbx_book_cat)
        Me.book_dtl_panel.Controls.Add(Me.cbx_book_auth)
        Me.book_dtl_panel.Controls.Add(Me.cbx_book_name)
        Me.book_dtl_panel.Controls.Add(Me.Label12)
        Me.book_dtl_panel.Controls.Add(Me.Label11)
        Me.book_dtl_panel.Controls.Add(Me.Label10)
        Me.book_dtl_panel.Controls.Add(Me.Label9)
        Me.book_dtl_panel.Controls.Add(Me.Label8)
        Me.book_dtl_panel.Controls.Add(Me.Label7)
        Me.book_dtl_panel.Location = New System.Drawing.Point(12, 181)
        Me.book_dtl_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.book_dtl_panel.Name = "book_dtl_panel"
        Me.book_dtl_panel.Size = New System.Drawing.Size(509, 503)
        Me.book_dtl_panel.TabIndex = 10
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_clear.Enabled = False
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(347, 446)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(119, 34)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_pdelete
        '
        Me.btn_pdelete.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_pdelete.Enabled = False
        Me.btn_pdelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_pdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pdelete.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pdelete.Location = New System.Drawing.Point(347, 370)
        Me.btn_pdelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_pdelete.Name = "btn_pdelete"
        Me.btn_pdelete.Size = New System.Drawing.Size(119, 58)
        Me.btn_pdelete.TabIndex = 23
        Me.btn_pdelete.Text = "DELETE"
        Me.btn_pdelete.UseVisualStyleBackColor = False
        '
        'btn_pupdate
        '
        Me.btn_pupdate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_pupdate.Enabled = False
        Me.btn_pupdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_pupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pupdate.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pupdate.Location = New System.Drawing.Point(201, 370)
        Me.btn_pupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_pupdate.Name = "btn_pupdate"
        Me.btn_pupdate.Size = New System.Drawing.Size(117, 58)
        Me.btn_pupdate.TabIndex = 22
        Me.btn_pupdate.Text = "UPDATE"
        Me.btn_pupdate.UseVisualStyleBackColor = False
        '
        'btn_padd
        '
        Me.btn_padd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_padd.Enabled = False
        Me.btn_padd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_padd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_padd.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_padd.Location = New System.Drawing.Point(39, 370)
        Me.btn_padd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_padd.Name = "btn_padd"
        Me.btn_padd.Size = New System.Drawing.Size(123, 58)
        Me.btn_padd.TabIndex = 21
        Me.btn_padd.Text = "ADD"
        Me.btn_padd.UseVisualStyleBackColor = False
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = False
        Me.txt_qty.Location = New System.Drawing.Point(149, 252)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(152, 22)
        Me.txt_qty.TabIndex = 9
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(149, 309)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(152, 22)
        Me.txt_total.TabIndex = 10
        '
        'txt_rate
        '
        Me.txt_rate.Enabled = False
        Me.txt_rate.Location = New System.Drawing.Point(151, 197)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(152, 22)
        Me.txt_rate.TabIndex = 8
        '
        'cbx_book_cat
        '
        Me.cbx_book_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_book_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_book_cat.FormattingEnabled = True
        Me.cbx_book_cat.Location = New System.Drawing.Point(149, 140)
        Me.cbx_book_cat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_book_cat.Name = "cbx_book_cat"
        Me.cbx_book_cat.Size = New System.Drawing.Size(152, 24)
        Me.cbx_book_cat.TabIndex = 7
        '
        'cbx_book_auth
        '
        Me.cbx_book_auth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_book_auth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_book_auth.FormattingEnabled = True
        Me.cbx_book_auth.Location = New System.Drawing.Point(149, 80)
        Me.cbx_book_auth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_book_auth.Name = "cbx_book_auth"
        Me.cbx_book_auth.Size = New System.Drawing.Size(345, 24)
        Me.cbx_book_auth.TabIndex = 6
        '
        'cbx_book_name
        '
        Me.cbx_book_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_book_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_book_name.FormattingEnabled = True
        Me.cbx_book_name.Location = New System.Drawing.Point(149, 22)
        Me.cbx_book_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_book_name.Name = "cbx_book_name"
        Me.cbx_book_name.Size = New System.Drawing.Size(345, 24)
        Me.cbx_book_name.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(80, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Total :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Rate Per Unit :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Quantity :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Book Category :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Book Author :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Book Name :"
        '
        'purchase_datagrid
        '
        Me.purchase_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.purchase_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purchase_datagrid.GridColor = System.Drawing.Color.DarkGray
        Me.purchase_datagrid.Location = New System.Drawing.Point(535, 181)
        Me.purchase_datagrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchase_datagrid.Name = "purchase_datagrid"
        Me.purchase_datagrid.RowTemplate.Height = 24
        Me.purchase_datagrid.Size = New System.Drawing.Size(779, 503)
        Me.purchase_datagrid.TabIndex = 11
        '
        'vendor_dtl_panel
        '
        Me.vendor_dtl_panel.Controls.Add(Me.cbx_vendor_city)
        Me.vendor_dtl_panel.Controls.Add(Me.Label14)
        Me.vendor_dtl_panel.Controls.Add(Me.cbx_vendor_name)
        Me.vendor_dtl_panel.Controls.Add(Me.Label4)
        Me.vendor_dtl_panel.Controls.Add(Me.p_txtbx_id)
        Me.vendor_dtl_panel.Controls.Add(Me.Label3)
        Me.vendor_dtl_panel.Location = New System.Drawing.Point(12, 69)
        Me.vendor_dtl_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vendor_dtl_panel.Name = "vendor_dtl_panel"
        Me.vendor_dtl_panel.Size = New System.Drawing.Size(1301, 82)
        Me.vendor_dtl_panel.TabIndex = 14
        '
        'cbx_vendor_city
        '
        Me.cbx_vendor_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_vendor_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_vendor_city.FormattingEnabled = True
        Me.cbx_vendor_city.Location = New System.Drawing.Point(1021, 26)
        Me.cbx_vendor_city.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_vendor_city.Name = "cbx_vendor_city"
        Me.cbx_vendor_city.Size = New System.Drawing.Size(184, 24)
        Me.cbx_vendor_city.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(923, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Vendor City:"
        '
        'cbx_vendor_name
        '
        Me.cbx_vendor_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_vendor_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_vendor_name.FormattingEnabled = True
        Me.cbx_vendor_name.Location = New System.Drawing.Point(523, 30)
        Me.cbx_vendor_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_vendor_name.Name = "cbx_vendor_name"
        Me.cbx_vendor_name.Size = New System.Drawing.Size(311, 24)
        Me.cbx_vendor_name.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Vendor Name:"
        '
        'p_txtbx_id
        '
        Me.p_txtbx_id.Enabled = False
        Me.p_txtbx_id.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_txtbx_id.Location = New System.Drawing.Point(239, 30)
        Me.p_txtbx_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.p_txtbx_id.Name = "p_txtbx_id"
        Me.p_txtbx_id.Size = New System.Drawing.Size(79, 25)
        Me.p_txtbx_id.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Purchase Id:"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Gray
        Me.btn_save.Enabled = False
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(932, 700)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(101, 55)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_save_print
        '
        Me.btn_save_print.BackColor = System.Drawing.Color.Gray
        Me.btn_save_print.Enabled = False
        Me.btn_save_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_save_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_print.Location = New System.Drawing.Point(1096, 700)
        Me.btn_save_print.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save_print.Name = "btn_save_print"
        Me.btn_save_print.Size = New System.Drawing.Size(211, 55)
        Me.btn_save_print.TabIndex = 16
        Me.btn_save_print.Text = "SAVE and PRINT"
        Me.btn_save_print.UseVisualStyleBackColor = False
        '
        'purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1347, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_save_print)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.purchase_datagrid)
        Me.Controls.Add(Me.book_dtl_panel)
        Me.Controls.Add(Me.date_purchase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vendor_dtl_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "purchase"
        Me.ShowIcon = False
        Me.book_dtl_panel.ResumeLayout(False)
        Me.book_dtl_panel.PerformLayout()
        CType(Me.purchase_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vendor_dtl_panel.ResumeLayout(False)
        Me.vendor_dtl_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents date_purchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents book_dtl_panel As System.Windows.Forms.Panel
    Friend WithEvents cbx_book_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbx_book_cat As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_book_auth As System.Windows.Forms.ComboBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents purchase_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents vendor_dtl_panel As System.Windows.Forms.Panel
    Friend WithEvents cbx_vendor_city As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbx_vendor_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents p_txtbx_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_save_print As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_pdelete As System.Windows.Forms.Button
    Friend WithEvents btn_pupdate As System.Windows.Forms.Button
    Friend WithEvents btn_padd As System.Windows.Forms.Button
End Class
