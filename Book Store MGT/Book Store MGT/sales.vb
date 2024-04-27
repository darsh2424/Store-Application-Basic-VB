Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class sales
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim qry As String
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Dim table As New DataTable("table")
    Dim index As Integer

    Dim db_quan As Integer = 0
    Dim boolUpdate As Boolean = False
    Dim cellupdate As Boolean = False
    Dim check_cust_name, check_cust_city, check_book_name, check_book_auth, check_book_cat As Boolean
    
    'combobox auto complete function

    Public Sub autocomplete(ByVal panel_dtl As String, ByVal cbxname As ComboBox, ByVal col_name As String, Optional ByVal compare_col As String = "", Optional ByVal ref_val As String = "")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim tablename As String
        If panel_dtl = "customer_dtl_panel" Then
            tablename = "customer_mst"
        Else
            tablename = "book_stock"
        End If

        If compare_col = "" And ref_val = "" Then
            qry = "select " & col_name & " from " & tablename
            cmd = New SqlCommand(qry, con)
        Else
            qry = "select " & col_name & " from " & tablename & " where " & compare_col & "=" & "'" & ref_val & "'"
            cbxname.Items.Clear()
            cmd = New SqlCommand(qry, con)
        End If
        'MsgBox(qry)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cbxname.Items.Add(rdr.GetString(0))
        End While
        con.Close()
    End Sub

    'check selections making clear that all controls having some value
    Public Sub checksel()
        If check_cust_name = True And check_cust_city = True Then
            book_dtl_panel.Enabled = True
            btn_clear.Enabled = True
            btn_clear.BackColor = Color.White
        End If
        If book_dtl_panel.Enabled = True Then
            If check_book_name = True And check_book_auth = True And check_book_cat = True Then
                Dim cnt As Integer = 0
                Dim repeat_index As Integer = 0
                If cbx_book_name.Text <> "" And cbx_book_auth.Text <> "" And cbx_book_cat.Text <> "" And sales_datagrid.Rows.Count > 0 And boolUpdate <> True Then
                    For i As Integer = 0 To sales_datagrid.Rows.Count - 1
                        If cbx_book_name.Text = sales_datagrid.Rows(i).Cells(1).Value And cbx_book_auth.Text = sales_datagrid.Rows(i).Cells(2).Value And cbx_book_cat.Text = sales_datagrid.Rows(i).Cells(3).Value Then
                            cnt = cnt + 1
                            repeat_index = i
                        End If
                    Next
                End If

                If cnt > 0 Then
                    Dim check = MsgBox("Item that you are adding, it is already addded!" + vbNewLine + "Do you want to update?", vbYesNo Or MsgBoxStyle.Exclamation, "")
                    If check = vbYes Then
                        boolUpdate = True
                        btn_add.Enabled = False
                        btn_add.BackColor = Color.Gray
                        btn_update.Enabled = True
                        btn_update.BackColor = Color.White

                        Dim selectdata As DataGridViewRow
                        selectdata = sales_datagrid.Rows(repeat_index)
                        cbx_book_name.Text = selectdata.Cells(1).Value.ToString()
                        cbx_book_auth.Text = selectdata.Cells(2).Value.ToString()
                        cbx_book_cat.Text = selectdata.Cells(3).Value.ToString()
                        txt_rate.Text = selectdata.Cells(4).Value.ToString()
                        txt_qty.Text = selectdata.Cells(5).Value.ToString()
                        txt_total.Text = selectdata.Cells(6).Value.ToString()
                    ElseIf check = vbNo Then
                        MsgBox("Please add unique item or update old values from gridview by clicking on that item cell", MsgBoxStyle.Critical, "")
                        cbx_book_name.Text = ""
                        cbx_book_auth.Text = ""
                        cbx_book_cat.Text = ""
                        check_book_name = False : check_book_auth = False : check_book_cat = False
                        Exit Sub
                    End If
                End If
                cbx_book_name.Enabled = False : cbx_book_auth.Enabled = False : cbx_book_cat.Enabled = False
                'check_book_name = False : check_book_auth = False : check_book_cat = False
                txt_db_qty.Text = ""

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim temp_qry As String = "select qty from book_stock where book_name=" + "'" & cbx_book_name.Text & "'" + " And book_author=" + "'" & cbx_book_auth.Text & "' and book_cat_name=" + "'" & cbx_book_cat.Text & "'"

                cmd = New SqlCommand(temp_qry, con)
                Dim n As Integer = 0
                n = cmd.ExecuteScalar()
                db_quan = n

                txt_db_qty.Text = db_quan.ToString()
                cmd = New SqlCommand("select rate_per_unit from book_stock where book_name='" & cbx_book_name.Text & "' and book_author='" & cbx_book_auth.Text & "' and book_cat_name='" & cbx_book_cat.Text & "'", con)
                txt_rate.Text = CStr(cmd.ExecuteScalar())
                con.Close()

                txt_rate.BorderStyle = BorderStyle.None
                txt_rate.BackColor = Color.Lavender
                txt_rate.Enabled = True
                txt_rate.ReadOnly = True
                txt_qty.Enabled = True
            ElseIf check_book_name = False Or check_book_auth = False Or check_book_cat = False Then
                txt_qty.Text = ""
                txt_total.Text = ""
                txt_db_qty.Text = ""
                txt_rate.Text = ""
                'MsgBox(txt_db_qty.Text & " " & txt_rate.Text & check_book_name.ToString() & check_book_auth.ToString() & check_book_cat.ToString())
            End If

        End If

    End Sub
    Public Sub find_pid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("select max(s_id) from book_sales", con)
        If IsDBNull(cmd.ExecuteScalar()) Then
            p_txtbx_id.Text = 1
        Else
            p_txtbx_id.Text = CInt(cmd.ExecuteScalar()) + 1
        End If

        con.Close()
    End Sub
    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        date_sales.Focus()
        book_dtl_panel.Enabled = False
        check_cust_name = False : check_cust_city = False : check_book_name = False : check_book_auth = False : check_book_cat = False
        find_pid()
        txt_db_qty.Text = ""

        table.Columns.Clear()
        table.Columns.Add("Item " + vbNewLine + "Number", Type.GetType("System.Int32"))
        table.Columns.Add("Book Name", Type.GetType("System.String"))
        table.Columns.Add("Book Author", Type.GetType("System.String"))
        table.Columns.Add("Book" + vbNewLine + "Category", Type.GetType("System.String"))
        table.Columns.Add("Rate  " + vbNewLine + "Per" + vbNewLine + "Unit", Type.GetType("System.Double"))
        table.Columns.Add("Qty", Type.GetType("System.Int32"))
        table.Columns.Add("Total", Type.GetType("System.Double"))

        sales_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sales_datagrid.DataSource = table
        sales_datagrid.AllowUserToResizeColumns = False
        sales_datagrid.AllowUserToAddRows = False

        autocomplete("customer_dtl_panel", cbx_cust_name, "cust_name")
        autocomplete("customer_dtl_panel", cbx_cust_city, "cust_city")
        autocomplete("book_dtl_panel", cbx_book_name, "book_name")
        autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
        autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")
    End Sub


    Private Sub cbx_cust_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_name.Leave
        If cbx_cust_name.Text <> "" Then
            For i As Integer = 0 To cbx_cust_name.Items.Count - 1
                If cbx_cust_name.Text = Convert.ToString(cbx_cust_name.Items(i)) Then
                    check_cust_name = True
                    Exit For
                End If
            Next
            If check_cust_name = False Then
                Dim add_cust_name = MsgBox("Customer Name is not exist in Database!" + vbNewLine + "Add Customer First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add_cust_name = vbOK Then
                    cbx_cust_name.Focus()
                    If add_customer.IsHandleCreated = True Then
                        add_customer.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_customer.ShowDialog()
                End If
            End If
        End If

    End Sub
    Private Sub cbx_cust_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_name.SelectedIndexChanged
        If cbx_cust_name.Text <> "" And cbx_cust_name.SelectedIndex >= 0 Then
            check_cust_name = True
            autocomplete("customer_dtl_panel", cbx_cust_city, "cust_city", "cust_name", CStr(cbx_cust_name.Text))
            checksel()
        End If
    End Sub
    Private Sub cbx_cust_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_name.TextChanged
        If cbx_cust_name.Text = "" Then
            cbx_cust_name.Items.Clear()
            autocomplete("customer_dtl_panel", cbx_cust_name, "cust_name")
            cbx_cust_city.Items.Clear()
            autocomplete("customer_dtl_panel", cbx_cust_city, "cust_city")
            check_cust_name = False
        End If
    End Sub

    Private Sub cbx_cust_city_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_city.Leave
        If cbx_cust_city.Text <> "" Then
            For i As Integer = 0 To cbx_cust_city.Items.Count - 1
                If cbx_cust_city.Text = Convert.ToString(cbx_cust_city.Items(i)) Then
                    check_cust_city = True
                    Exit For
                End If
            Next
            If check_cust_city = False Then
                Dim add_cust_city = MsgBox("City Name That You Provided Is Different From Past Data" + vbNewLine + "Add New Customer Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add_cust_city = vbOK Then
                    cbx_cust_city.Focus()
                    If add_customer.IsHandleCreated = True Then
                        add_customer.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_customer.ShowDialog()
                End If

            End If
        End If
    End Sub
    Private Sub cbx_cust_city_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_city.SelectedIndexChanged
        If cbx_cust_city.Text <> "" And cbx_cust_city.SelectedIndex >= 0 Then
            check_cust_city = True
            autocomplete("customer_dtl_panel", cbx_cust_name, "cust_name", "cust_city", CStr(cbx_cust_city.Text))
            checksel()
        End If
    End Sub
    Private Sub cbx_cust_city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cust_city.TextChanged
        If cbx_cust_city.Text = "" Then
            cbx_cust_name.Items.Clear()
            autocomplete("customer_dtl_panel", cbx_cust_name, "cust_name")
            cbx_cust_city.Items.Clear()
            autocomplete("customer_dtl_panel", cbx_cust_city, "cust_city")
            check_cust_city = False
        End If
    End Sub

    Private Sub cbx_book_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_name.Leave


        If cbx_book_name.Text <> "" Then
            For i As Integer = 0 To cbx_book_name.Items.Count - 1
                If cbx_book_name.Text = Convert.ToString(cbx_book_name.Items(i)) Then
                    check_book_name = True
                    Exit For
                End If
            Next
            If check_book_name = True Then
                cbx_book_auth.Items.Clear()
                cbx_book_cat.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_name", CStr(cbx_book_name.Text))
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_name", CStr(cbx_book_name.Text))
                checksel()
            Else
                Dim add = MsgBox("Book Name That You Provided Is Different From Past Data" + vbNewLine + "Add New Book Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add = vbOK Then
                    cbx_book_name.Focus()
                   
                    If add_book.IsHandleCreated = True Then
                        add_book.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_book.ShowDialog()
                End If
            End If
        End If

    End Sub
    Private Sub cbx_book_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_name.SelectedIndexChanged
        If cbx_book_name.Text <> "" And cbx_book_name.SelectedIndex >= 0 Then
            check_book_name = True
            If cbx_book_auth.SelectedIndex = -1 Then
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_name", CStr(cbx_book_name.Text))
            End If
            If cbx_book_cat.SelectedIndex = -1 Then
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_name", CStr(cbx_book_name.Text))
            End If
            'If cellupdate <> True Then
            '    checksel()
            'End If
            checksel()
        End If
    End Sub

    Private Sub cbx_book_auth_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_auth.Leave
        If cbx_book_auth.Text <> "" Then
            For i As Integer = 0 To cbx_book_auth.Items.Count - 1
                If cbx_book_auth.Text = Convert.ToString(cbx_book_auth.Items(i)) Then
                    check_book_auth = True
                    Exit For
                End If
            Next
            If check_book_auth = True Then
                cbx_book_name.Items.Clear()
                cbx_book_cat.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_author", CStr(cbx_book_auth.Text))
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_author", CStr(cbx_book_auth.Text))
                checksel()
            Else
                Dim add = MsgBox("Book Author That You Provided Is Different From Past Data" + vbNewLine + "Add New Book Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add = vbOK Then
                    cbx_book_auth.Focus()
                    If add_book.IsHandleCreated = True Then
                        add_book.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_book.ShowDialog()
                End If
            End If
        End If

    End Sub
    Private Sub cbx_book_auth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_auth.SelectedIndexChanged
        If cbx_book_auth.Text <> "" And cbx_book_auth.SelectedIndex >= 0 Then
            check_book_auth = True
            If cbx_book_name.SelectedIndex = -1 And cbx_book_name.Text = "" Then
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_author", CStr(cbx_book_auth.Text))
            End If
            If cbx_book_cat.SelectedIndex = -1 And cbx_book_cat.Text = "" Then
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_author", CStr(cbx_book_auth.Text))
            End If
            'If cellupdate <> True Then
            '    checksel()
            'End If
            checksel()
        End If
    End Sub

    Private Sub cbx_book_cat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_cat.Leave
        If cbx_book_cat.Text <> "" Then
            For i As Integer = 0 To cbx_book_cat.Items.Count - 1
                If cbx_book_cat.Text = Convert.ToString(cbx_book_cat.Items(i)) Then
                    check_book_cat = True
                    Exit For
                End If
            Next
            If check_book_cat = True Then
                cbx_book_auth.Items.Clear()
                cbx_book_name.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_cat_name", CStr(cbx_book_cat.Text))
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_cat_name", CStr(cbx_book_cat.Text))
                'MsgBox(check_book_name.ToString() & check_book_auth.ToString() & check_book_cat.ToString())
                checksel()
            Else
                Dim add = MsgBox(check_book_name.ToString() & "Book Name That You Provided Is Different From Past Data" + vbNewLine + "Add New Book Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add = vbOK Then
                    cbx_book_name.Focus()
                    If add_book.IsHandleCreated = True Then
                        add_book.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_book.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub cbx_book_cat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_cat.SelectedIndexChanged
        If cbx_book_cat.Text <> "" And cbx_book_cat.SelectedIndex >= 0 Then
            check_book_cat = True
            If cbx_book_name.SelectedIndex = -1 And cbx_book_name.Text = "" Then
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_cat_name", CStr(cbx_book_cat.Text))
            End If
            If cbx_book_cat.SelectedIndex = -1 And cbx_book_cat.Text = "" Then
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_cat_name", CStr(cbx_book_cat.Text))
            End If
            'If cellupdate <> True Then
            '    checksel()
            'End If
            checksel()
        End If
    End Sub
    Private Sub txt_qty_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.Leave
        Dim qry As Integer
        If txt_qty.Text <> "" Then

            If Integer.TryParse(txt_qty.Text, qry) Then
                db_quan = CInt(txt_db_qty.Text)
                If CInt(txt_qty.Text) > db_quan Then
                    MsgBox("Available Stock: " & db_quan & " Check Values", MsgBoxStyle.Critical, "")
                Else
                    txt_total.Text = CStr(CDbl(txt_rate.Text) * qry)
                End If
            Else
                MsgBox("Check Quantity Value!", vbOKOnly Or MsgBoxStyle.Critical, "")
            End If


        Else
            txt_total.Text = ""
            'MsgBox("Check Quantity Value!", vbOKOnly Or MsgBoxStyle.Critical, "")
        End If
    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        txt_total.Text = ""
        txt_total.Enabled = True
        btn_add.Enabled = False
        btn_add.BackColor = Color.Gray
    End Sub

    Private Sub txt_total_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.Enter
        txt_total.Enabled = False
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        If txt_qty.Text.Length > 0 And boolUpdate = False Then
            btn_add.Enabled = True
            btn_add.BackColor = Color.White
        End If
    End Sub
    Public Sub clear_all()
        showsave()

        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_db_qty.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        check_book_name = False : check_book_auth = False : check_book_cat = False
        txt_qty.Enabled = False
        txt_total.Enabled = False

        btn_add.Enabled = False
        btn_add.BackColor = Color.Gray
        boolUpdate = False
        cbx_book_name.Items.Clear()
        cbx_book_auth.Items.Clear()
        cbx_book_cat.Items.Clear()
        autocomplete("book_dtl_panel", cbx_book_name, "book_name")
        autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
        autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")

        cbx_book_name.Enabled = True : cbx_book_auth.Enabled = True : cbx_book_cat.Enabled = True
        cbx_book_name.Focus()
    End Sub

    'Private Sub cbx_book_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_name.TextChanged, cbx_book_cat.TextChanged, cbx_book_auth.TextChanged
    '    If cbx_book_name.Text.Length = 0 Or cbx_book_auth.Text.Length = 0 Or cbx_book_cat.Text.Length = 0 Then
    '        cbx_book_name.Items.Clear()
    '        cbx_book_auth.Items.Clear()
    '        cbx_book_cat.Items.Clear()
    '        autocomplete("book_dtl_panel", cbx_book_name, "book_name")
    '        autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
    '        autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")
    '    End If
    'End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim item_num As Integer
        If CDbl(txt_total.Text) = CDbl(txt_rate.Text) * CInt(txt_qty.Text) Then
            If sales_datagrid.Rows.Count > 0 Then
                item_num = sales_datagrid.Rows((sales_datagrid.Rows.Count) - 1).Cells(0).Value + 1
            Else
                item_num = 1
            End If

            table.Rows.Add(item_num, cbx_book_name.Text, cbx_book_auth.Text, cbx_book_cat.Text, txt_rate.Text, txt_qty.Text, txt_total.Text)
            clear_all()
        End If

    End Sub

    Private Sub sales_datagrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles sales_datagrid.CellClick
        boolUpdate = True
        index = e.RowIndex
        Dim selectdata As DataGridViewRow
        selectdata = sales_datagrid.Rows(index)
        cbx_book_name.Text = selectdata.Cells(1).Value.ToString()
        cbx_book_auth.Text = selectdata.Cells(2).Value.ToString()
        cbx_book_cat.Text = selectdata.Cells(3).Value.ToString()
        txt_rate.Text = selectdata.Cells(4).Value.ToString()
        txt_qty.Text = selectdata.Cells(5).Value.ToString()
        txt_total.Text = selectdata.Cells(6).Value.ToString()
        txt_qty.Enabled = True
        btn_update.Enabled = True
        btn_update.BackColor = Color.White
        btn_delete.Enabled = True
        btn_delete.BackColor = Color.White
        btn_add.Enabled = False
        btn_add.BackColor = Color.Gray
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        sales_datagrid.Rows(index).Cells(1).Value = cbx_book_name.Text
        sales_datagrid.Rows(index).Cells(2).Value = cbx_book_auth.Text
        sales_datagrid.Rows(index).Cells(3).Value = cbx_book_cat.Text
        sales_datagrid.Rows(index).Cells(4).Value = txt_rate.Text
        sales_datagrid.Rows(index).Cells(5).Value = txt_qty.Text
        sales_datagrid.Rows(index).Cells(6).Value = txt_total.Text

        showsave()
        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        txt_qty.Enabled = False

        btn_update.Enabled = False
        btn_update.BackColor = Color.Gray
        btn_delete.Enabled = False
        btn_delete.BackColor = Color.Gray
        boolUpdate = False
    End Sub
    Public Sub arrange()
        Dim curr_value As Integer
        Dim next_val As Integer
        Dim gap As Integer
        'MsgBox(purchase_datagrid.Rows.Count)
        If sales_datagrid.Rows.Count > 1 Then
            If sales_datagrid.Rows(0).Cells(0).Value <> 1 Then
                sales_datagrid.Rows(0).Cells(0).Value = 1
            End If
            For i As Integer = 0 To sales_datagrid.Rows.Count
                If i + 1 = sales_datagrid.Rows.Count Then
                    Exit For
                Else
                    curr_value = sales_datagrid.Rows(i).Cells(0).Value
                    next_val = sales_datagrid.Rows(i + 1).Cells(0).Value
                    gap = next_val - curr_value
                    If gap > 1 Then
                        next_val = next_val - (gap - 1)
                    End If
                    sales_datagrid.Rows(i + 1).Cells(0).Value = next_val
                End If
            Next
        ElseIf sales_datagrid.Rows.Count = 1 Then
            sales_datagrid.Rows(0).Cells(0).Value = 1
        End If
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        sales_datagrid.Rows.RemoveAt(index)
        showsave()
        arrange()
        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_db_qty.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        txt_qty.Enabled = False

        btn_update.Enabled = False
        btn_update.BackColor = Color.Gray
        btn_delete.Enabled = False
        btn_delete.BackColor = Color.Gray
    End Sub
    Public Sub showsave()
        If sales_datagrid.Rows.Count > 0 Then
            btn_save.Enabled = True
            btn_save.BackColor = Color.White
            btn_save_print.Enabled = True
            btn_save_print.BackColor = Color.White
        ElseIf sales_datagrid.Rows.Count = 0 Then
            btn_save.Enabled = False
            btn_save.BackColor = Color.Gray
            btn_save_print.Enabled = False
            btn_save_print.BackColor = Color.Gray
        End If
    End Sub
    Public Sub save_bill()
        Dim check = MsgBox("Are you sure you want to save current bill?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "")
        If check = vbYes Then
            con.Open()

            Dim cust_name As String = CStr(cbx_cust_name.Text)
            Dim cust_city As String = CStr(cbx_cust_city.Text)
            Dim cust_id As Integer

            cmd = New SqlCommand("select cust_id from customer_mst where cust_name='" & cust_name & "' and cust_city='" & cust_city & "'", con)
            If IsDBNull(cmd.ExecuteScalar()) Then
                MsgBox("Check Vendor Details and Try Again", vbOKOnly Or MsgBoxStyle.Information, "")
            Else

                Dim vsdate As String = date_sales.Value.ToString("yyyy-MM-dd")
                Dim vsid As Integer = CInt(p_txtbx_id.Text)
                cust_id = CInt(cmd.ExecuteScalar())

                For i As Integer = 0 To sales_datagrid.Rows.Count - 1
                    Dim vbook_name As String = sales_datagrid.Rows(i).Cells(1).Value.ToString()
                    Dim vbook_auth As String = sales_datagrid.Rows(i).Cells(2).Value.ToString()
                    Dim vbook_cat As String = sales_datagrid.Rows(i).Cells(3).Value.ToString()

                    cmd = New SqlCommand("select book_id from book_stock where book_name='" & vbook_name & "'and book_author='" & vbook_auth & "'and book_cat_name='" & vbook_cat & "'", con)
                    If IsDBNull(cmd.ExecuteScalar()) Then
                        MsgBox("Check Book Details in Gridview", MsgBoxStyle.Information, "")
                        Exit Sub
                    Else
                        Dim vitem_num As Integer = CInt(sales_datagrid.Rows(i).Cells(0).Value)
                        Dim vbook_id As Integer = CInt(cmd.ExecuteScalar())
                        Dim vbook_qty As Integer = CInt(sales_datagrid.Rows(i).Cells(5).Value.ToString())
                        Dim vbook_total As Double = CDbl(sales_datagrid.Rows(i).Cells(6).Value.ToString())
                        Dim add_cmd As SqlCommand = New SqlCommand("insert into book_sales values('" & vsdate & "','" & vsid & "','" & cust_id & "','" & vitem_num & "','" & vbook_id & "','" & vbook_qty & "','" & vbook_total & "')", con)
                        add_cmd.ExecuteNonQuery()
                        Dim select_cmd As SqlCommand = New SqlCommand("select qty from book_stock where book_id='" & vbook_id & "'", con)
                        Dim old_qty As Integer = select_cmd.ExecuteScalar()
                        Dim new_qty As Integer = old_qty - vbook_qty
                        qry = "update book_stock set qty='" & new_qty & "' where book_id='" & vbook_id & "'"
                        Dim update_cmd As SqlCommand = New SqlCommand(qry, con)
                        'MsgBox(qry)
                        update_cmd.ExecuteNonQuery()

                        Dim book_cnt_sel As SqlCommand = New SqlCommand("select cat_books from book_cat where cat_name='" & vbook_cat & "'", con)
                        Dim old_book_cnt As Integer = book_cnt_sel.ExecuteScalar()
                        Dim new_book_cnt As Integer = old_book_cnt - vbook_qty
                        qry = "update book_cat set cat_books='" & new_book_cnt & "' where cat_name='" & vbook_cat & "'"
                        Dim update_book_cat As SqlCommand = New SqlCommand(qry, con)
                        'MsgBox(qry)
                        update_book_cat.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Sales Data Saved Successfully!", MsgBoxStyle.Information, "")



            End If

            con.Close()
        End If

    End Sub
    Public Sub clear_grid()
        cbx_cust_name.Text = ""
        cbx_cust_city.Text = ""
        Do While (sales_datagrid.Rows.Count > 0)
            sales_datagrid.Rows.RemoveAt(0)
        Loop
        find_pid()
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        save_bill()
        clear_grid()
    End Sub

    Private Sub btn_save_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_print.Click
        save_bill()
        Dim pdf As PdfDocument = New PdfDocument
        pdf.Info.Title = "Purchase Bill"
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)

        Dim font_reg As XFont = New XFont("Calibari", 8, XFontStyle.Regular)
        Dim font_title As XFont = New XFont("Calibari", 12, XFontStyle.Bold Or XFontStyle.Underline)

        graph.DrawString("XYZ BOOK STORE", font_title, Brushes.Black, New XRect(0, 0, pdfPage.Width.Point, 35), XStringFormats.Center)
        graph.DrawString("Sales Bill", font_reg, Brushes.Black, New XRect(0, 0, pdfPage.Width.Point, 60), XStringFormats.Center)

        Dim pdate As String = "Date : " & date_sales.Text.ToString()
        graph.DrawString(pdate, font_reg, Brushes.Black, New XRect(490, 45, 0, 0), XStringFormats.Center)

        Dim pid As String = "Purchase ID : " & p_txtbx_id.Text.ToString()
        graph.DrawString(pid, font_reg, Brushes.Black, New XRect(80, 65, 0, 0), XStringFormats.Center)

        Dim pven_name As String = "Vendor Name : " & cbx_cust_name.Text.ToString()
        graph.DrawString(pven_name, font_reg, Brushes.Black, New XRect(200, 65, 0, 0), XStringFormats.Center)

        Dim pven_city As String = "Vendor City : " & cbx_cust_city.Text.ToString()
        graph.DrawString(pven_city, font_reg, Brushes.Black, New XRect(380, 65, 0, 0), XStringFormats.Center)

        Dim line As String = "------------------------------------------------------------------------------------------------------------------------------------------------"
        graph.DrawString(line, font_reg, Brushes.Black, New XRect(248, 85, 0, 0), XStringFormats.Center)

        Dim title As String = "         Sr. No.       Book Name & Author                                                             Quantity        Total          "
        graph.DrawString(title, font_reg, Brushes.Black, New XRect(200, 95, 0, 0), XStringFormats.Center)
        graph.DrawString(line, font_reg, Brushes.Black, New XRect(248, 105, 0, 0), XStringFormats.Center)

        'Dim p_itnum, p_name_auth, p_quan, p_total As String
        Dim x, y As Integer
        Dim total As Double = 0
        y = 115
        For i As Integer = 0 To sales_datagrid.Rows.Count - 1
            x = 66
            graph.DrawString(sales_datagrid.Rows(i).Cells(0).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            x = 150
            graph.DrawString((sales_datagrid.Rows(i).Cells(1).Value.ToString() & " By " & sales_datagrid.Rows(i).Cells(2).Value.ToString()), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            x = 305
            graph.DrawString(sales_datagrid.Rows(i).Cells(5).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            total = total + CDbl(sales_datagrid.Rows(i).Cells(6).Value)
            x = 350
            graph.DrawString(sales_datagrid.Rows(i).Cells(6).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            y = y + 20
        Next

        graph.DrawString(line, font_reg, Brushes.Black, New XRect(248, y, 0, 0), XStringFormats.Center)
        y = y + 20
        graph.DrawString("Final Total : ", font_reg, Brushes.Black, New XRect(300, y, 0, 0), XStringFormats.Center)
        graph.DrawString(total, font_reg, Brushes.Black, New XRect(350, y, 0, 0), XStringFormats.Center)


        Dim pdfFilename As String = "Sales_Bill_" & p_txtbx_id.Text & ".pdf"

        pdf.Save("D:\tybca11\project\Book Store MGT\Book Store MGT\storebills\sales\" + pdfFilename)
        Process.Start("D:\tybca11\project\Book Store MGT\Book Store MGT\storebills\sales\" + pdfFilename)
        clear_grid()
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear_all()
    End Sub

    Private Sub cbx_book_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_book_name.TextChanged, cbx_book_cat.TextChanged, cbx_book_auth.TextChanged
        ''If (cbx_book_name.Text = "" Or cbx_book_auth.Text = "" Or cbx_book_cat.Text = "") And (cbx_book_name.te) Then
        ''    cbx_book_name.Items.Clear()
        ''    cbx_book_auth.Items.Clear()
        ''    cbx_book_cat.Items.Clear()
        ''    autocomplete("book_dtl_panel", cbx_book_name, "book_name")
        ''    autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
        ''    autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")
        'End If
        check_book_name = False & check_book_auth = False & check_book_cat = False
        If cbx_book_name.Text = "" Then
            cbx_book_name.Items.Clear()
            autocomplete("book_dtl_panel", cbx_book_name, "book_name")

            If cbx_book_auth.Text <> "" Then
                cbx_book_name.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_author", CStr(cbx_book_auth.Text))

            End If

            If cbx_book_cat.Text <> "" Then
                cbx_book_name.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_name, "book_name", "book_cat_name", CStr(cbx_book_cat.Text))

            End If
        End If

        If cbx_book_auth.Text = "" Then
            cbx_book_auth.Items.Clear()
            autocomplete("book_dtl_panel", cbx_book_auth, "book_author")

            If cbx_book_name.Text <> "" Then
                cbx_book_auth.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_name", CStr(cbx_book_name.Text))

            End If

            If cbx_book_cat.Text <> "" Then
                cbx_book_name.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_auth, "book_author", "book_cat_name", CStr(cbx_book_cat.Text))

            End If
        End If

        If cbx_book_cat.Text = "" Then
            cbx_book_cat.Items.Clear()
            autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")

            If cbx_book_auth.Text <> "" Then
                cbx_book_cat.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_author", CStr(cbx_book_auth.Text))

            End If

            If cbx_book_name.Text <> "" Then
                cbx_book_cat.Items.Clear()
                autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name", "book_name", CStr(cbx_book_name.Text))

            End If
        End If
    End Sub
End Class
