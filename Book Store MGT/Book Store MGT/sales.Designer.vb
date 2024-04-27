<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.customer_dtl_panel = New System.Windows.Forms.Panel()
        Me.cbx_cust_city = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_cust_name = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.p_txtbx_id = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cbx_book_name = New System.Windows.Forms.ComboBox()
        Me.cbx_book_auth = New System.Windows.Forms.ComboBox()
        Me.cbx_book_cat = New System.Windows.Forms.ComboBox()
        Me.sales_datagrid = New System.Windows.Forms.DataGridView()
        Me.book_dtl_panel = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_db_qty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_sales = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save_print = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customer_dtl_panel.SuspendLayout()
        CType(Me.sales_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.book_dtl_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_update.Enabled = False
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(204, 441)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(117, 60)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 0
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(351, 441)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 58)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = False
        Me.txt_qty.Location = New System.Drawing.Point(149, 302)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(152, 22)
        Me.txt_qty.TabIndex = 9
        '
        'customer_dtl_panel
        '
        Me.customer_dtl_panel.Controls.Add(Me.cbx_cust_city)
        Me.customer_dtl_panel.Controls.Add(Me.Label5)
        Me.customer_dtl_panel.Controls.Add(Me.cbx_cust_name)
        Me.customer_dtl_panel.Controls.Add(Me.Label13)
        Me.customer_dtl_panel.Controls.Add(Me.p_txtbx_id)
        Me.customer_dtl_panel.Controls.Add(Me.Label15)
        Me.customer_dtl_panel.Location = New System.Drawing.Point(12, 69)
        Me.customer_dtl_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.customer_dtl_panel.Name = "customer_dtl_panel"
        Me.customer_dtl_panel.Size = New System.Drawing.Size(1301, 82)
        Me.customer_dtl_panel.TabIndex = 23
        '
        'cbx_cust_city
        '
        Me.cbx_cust_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_cust_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_cust_city.FormattingEnabled = True
        Me.cbx_cust_city.Location = New System.Drawing.Point(1027, 30)
        Me.cbx_cust_city.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_cust_city.Name = "cbx_cust_city"
        Me.cbx_cust_city.Size = New System.Drawing.Size(184, 24)
        Me.cbx_cust_city.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(908, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Customer City:"
        '
        'cbx_cust_name
        '
        Me.cbx_cust_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_cust_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_cust_name.FormattingEnabled = True
        Me.cbx_cust_name.Location = New System.Drawing.Point(515, 31)
        Me.cbx_cust_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_cust_name.Name = "cbx_cust_name"
        Me.cbx_cust_name.Size = New System.Drawing.Size(311, 24)
        Me.cbx_cust_name.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(384, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Customer Name:"
        '
        'p_txtbx_id
        '
        Me.p_txtbx_id.Enabled = False
        Me.p_txtbx_id.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_txtbx_id.Location = New System.Drawing.Point(224, 30)
        Me.p_txtbx_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.p_txtbx_id.Name = "p_txtbx_id"
        Me.p_txtbx_id.Size = New System.Drawing.Size(79, 25)
        Me.p_txtbx_id.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(147, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 18)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Sales Id:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_add.Enabled = False
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(48, 441)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(123, 60)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(149, 359)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(152, 22)
        Me.txt_total.TabIndex = 10
        '
        'txt_rate
        '
        Me.txt_rate.Enabled = False
        Me.txt_rate.Location = New System.Drawing.Point(151, 198)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(152, 22)
        Me.txt_rate.TabIndex = 18
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Gray
        Me.btn_save.Enabled = False
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(911, 702)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(101, 55)
        Me.btn_save.TabIndex = 24
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
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
        'sales_datagrid
        '
        Me.sales_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.sales_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sales_datagrid.GridColor = System.Drawing.Color.DarkGray
        Me.sales_datagrid.Location = New System.Drawing.Point(543, 175)
        Me.sales_datagrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sales_datagrid.Name = "sales_datagrid"
        Me.sales_datagrid.RowTemplate.Height = 24
        Me.sales_datagrid.Size = New System.Drawing.Size(771, 491)
        Me.sales_datagrid.TabIndex = 22
        '
        'book_dtl_panel
        '
        Me.book_dtl_panel.Controls.Add(Me.btn_clear)
        Me.book_dtl_panel.Controls.Add(Me.txt_db_qty)
        Me.book_dtl_panel.Controls.Add(Me.Label4)
        Me.book_dtl_panel.Controls.Add(Me.txt_qty)
        Me.book_dtl_panel.Controls.Add(Me.btn_delete)
        Me.book_dtl_panel.Controls.Add(Me.btn_update)
        Me.book_dtl_panel.Controls.Add(Me.btn_add)
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
        Me.book_dtl_panel.Location = New System.Drawing.Point(20, 175)
        Me.book_dtl_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.book_dtl_panel.Name = "book_dtl_panel"
        Me.book_dtl_panel.Size = New System.Drawing.Size(509, 582)
        Me.book_dtl_panel.TabIndex = 21
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_clear.Enabled = False
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(351, 516)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(119, 34)
        Me.btn_clear.TabIndex = 20
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'txt_db_qty
        '
        Me.txt_db_qty.BackColor = System.Drawing.Color.Lavender
        Me.txt_db_qty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_db_qty.Location = New System.Drawing.Point(151, 249)
        Me.txt_db_qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_db_qty.Name = "txt_db_qty"
        Me.txt_db_qty.ReadOnly = True
        Me.txt_db_qty.Size = New System.Drawing.Size(100, 15)
        Me.txt_db_qty.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 34)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Current Quantity :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             (in stock)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(80, 363)
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
        Me.Label10.Location = New System.Drawing.Point(56, 304)
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
        'date_sales
        '
        Me.date_sales.CustomFormat = "yyyy-MM-dd"
        Me.date_sales.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_sales.Location = New System.Drawing.Point(991, 34)
        Me.date_sales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_sales.Name = "date_sales"
        Me.date_sales.Size = New System.Drawing.Size(209, 27)
        Me.date_sales.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(940, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(555, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "SALES BILL"
        '
        'btn_save_print
        '
        Me.btn_save_print.BackColor = System.Drawing.Color.Gray
        Me.btn_save_print.Enabled = False
        Me.btn_save_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_save_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_print.Location = New System.Drawing.Point(1075, 702)
        Me.btn_save_print.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save_print.Name = "btn_save_print"
        Me.btn_save_print.Size = New System.Drawing.Size(211, 55)
        Me.btn_save_print.TabIndex = 25
        Me.btn_save_print.Text = "SAVE and PRINT"
        Me.btn_save_print.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(515, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "XYZ BOOK STORE"
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1347, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customer_dtl_panel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.sales_datagrid)
        Me.Controls.Add(Me.book_dtl_panel)
        Me.Controls.Add(Me.date_sales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_save_print)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "sales"
        Me.ShowIcon = False
        Me.customer_dtl_panel.ResumeLayout(False)
        Me.customer_dtl_panel.PerformLayout()
        CType(Me.sales_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.book_dtl_panel.ResumeLayout(False)
        Me.book_dtl_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents cbx_vendor_city As System.Windows.Forms.ComboBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    'Friend WithEvents cbx_vendor_name As System.Windows.Forms.ComboBox
    Friend WithEvents customer_dtl_panel As System.Windows.Forms.Panel
    'Friend WithEvents Label4 As System.Windows.Forms.Label
    'Friend WithEvents p_txtbx_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents cbx_book_name As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_book_auth As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_book_cat As System.Windows.Forms.ComboBox
    Friend WithEvents sales_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents book_dtl_panel As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_sales As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save_print As System.Windows.Forms.Button
    'Friend WithEvents vendor_dtl_panel As System.Windows.Forms.Panel
    Friend WithEvents cbx_cust_city As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbx_cust_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents p_txtbx_id As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_db_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
