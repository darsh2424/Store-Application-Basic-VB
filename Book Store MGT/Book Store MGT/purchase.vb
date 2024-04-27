Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class purchase
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim qry As String
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Dim table As New DataTable("table")
    Dim index As Integer
    Dim boolUpdate As Boolean = False
    Dim cellupdate As Boolean = False
    Dim check_ven_name, check_ven_city, check_book_name, check_book_auth, check_book_cat As Boolean
    'Dim WithEvents PD As New PrintDocument()
    Dim PPD As New PrintDialog

    'combobox auto complete function

    Public Sub autocomplete(ByVal panel_dtl As String, ByVal cbxname As ComboBox, ByVal col_name As String, Optional ByVal compare_col As String = "", Optional ByVal ref_val As String = "")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim tablename As String
        If panel_dtl = "vendor_dtl_panel" Then
            tablename = "vendor_mst"
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

        If tablename = "vendor_mst" And col_name = "ven_city" And compare_col = "" And ref_val = "" Then
            qry = "select distinct(" & col_name & ") from " & tablename
            cmd = New SqlCommand(qry, con)
        ElseIf tablename = "vendor_mst" And col_name = "ven_city" And compare_col <> "" And ref_val <> "" Then
            qry = "select distinct(" & col_name & ") from " & tablename & " where " & compare_col & "=" & "'" & ref_val & "'"
            cbxname.Items.Clear()
            cmd = New SqlCommand(qry, con)
        End If
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cbxname.Items.Add(rdr.GetString(0))
        End While
        con.Close()
    End Sub

    'check selections making clear that all controls having some value
    Public Sub checksel()
        If check_ven_name = True And check_ven_city = True Then
            book_dtl_panel.Enabled = True
        End If
        If book_dtl_panel.Enabled = True Then
            If check_book_name = True And check_book_auth = True And check_book_cat = True Then
                Dim cnt As Integer = 0
                Dim repeat_index As Integer = 0
                If cbx_book_name.Text <> "" And cbx_book_auth.Text <> "" And cbx_book_cat.Text <> "" And purchase_datagrid.Rows.Count > 0 And boolUpdate <> True Then
                    For i As Integer = 0 To purchase_datagrid.Rows.Count - 1
                        If cbx_book_name.Text = purchase_datagrid.Rows(i).Cells(1).Value And cbx_book_auth.Text = purchase_datagrid.Rows(i).Cells(2).Value And cbx_book_cat.Text = purchase_datagrid.Rows(i).Cells(3).Value Then
                            cnt = cnt + 1
                            repeat_index = i
                        End If
                    Next
                End If

                If cnt > 0 Then
                    Dim check = MsgBox("Item that you are adding, it is already addded!" + vbNewLine + "Do you want to update?", vbYesNo Or MsgBoxStyle.Exclamation, "")
                    If check = vbYes Then
                        boolUpdate = True
                        btn_padd.Enabled = False
                        btn_padd.BackColor = Color.Gray
                        btn_pupdate.Enabled = True
                        btn_pupdate.BackColor = Color.White

                        Dim selectdata As DataGridViewRow
                        selectdata = purchase_datagrid.Rows(repeat_index)
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
                btn_clear.Enabled = True : btn_clear.BackColor = Color.White
                cbx_book_name.Enabled = False : cbx_book_auth.Enabled = False : cbx_book_cat.Enabled = False
                check_book_name = False : check_book_auth = False : check_book_cat = False
                con.Open()
                cmd = New SqlCommand("select rate_per_unit from book_stock where book_name='" & cbx_book_name.Text & "' and book_author='" & cbx_book_auth.Text & "' and book_cat_name='" & cbx_book_cat.Text & "'", con)
                txt_rate.Text = CStr(cmd.ExecuteScalar())
                con.Close()
                txt_qty.Enabled = True
            ElseIf check_book_name = False Or check_book_auth = False Or check_book_cat = False Then
                txt_rate.Text = ""
            End If
        End If

    End Sub
    Public Sub find_pid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("select max(p_id) from book_purchase", con)
        If IsDBNull(cmd.ExecuteScalar()) Then
            p_txtbx_id.Text = 1
        Else
            p_txtbx_id.Text = CInt(cmd.ExecuteScalar()) + 1
        End If

        con.Close()
    End Sub
    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        date_purchase.Focus()
        book_dtl_panel.Enabled = False
        check_ven_name = False : check_ven_city = False : check_book_name = False : check_book_auth = False : check_book_cat = False
        find_pid()

        table.Columns.Clear()
        table.Columns.Add("Item " + vbNewLine + "Number", Type.GetType("System.Int32"))
        table.Columns.Add("Book Name", Type.GetType("System.String"))
        table.Columns.Add("Book Author", Type.GetType("System.String"))
        table.Columns.Add("Book" + vbNewLine + "Category", Type.GetType("System.String"))
        table.Columns.Add("Rate  " + vbNewLine + "Per" + vbNewLine + "Unit", Type.GetType("System.Double"))
        table.Columns.Add("Qty", Type.GetType("System.Int32"))
        table.Columns.Add("Total", Type.GetType("System.Double"))

        purchase_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        purchase_datagrid.DataSource = table
        purchase_datagrid.AllowUserToResizeColumns = False
        purchase_datagrid.AllowUserToAddRows = False

        autocomplete("vendor_dtl_panel", cbx_vendor_name, "ven_name")
        autocomplete("vendor_dtl_panel", cbx_vendor_city, "ven_city")
        autocomplete("book_dtl_panel", cbx_book_name, "book_name")
        autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
        autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")
    End Sub


    Private Sub cbx_vendor_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_name.Leave
        If cbx_vendor_name.Text <> "" Then
            For i As Integer = 0 To cbx_vendor_name.Items.Count - 1
                If cbx_vendor_name.Text = Convert.ToString(cbx_vendor_name.Items(i)) Then
                    check_ven_name = True
                    Exit For
                End If
            Next
            If check_ven_name = False Then
                cbx_vendor_name.Items.Clear()
                autocomplete("vendor_dtl_panel", cbx_vendor_name, "ven_name")
                Dim add_ven_name = MsgBox("Vendor Name is not exist in Database!" + vbNewLine + "Add Vendor First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add_ven_name = vbOK Then
                    cbx_vendor_name.Focus()
                    If add_vendor.IsHandleCreated = True Then
                        add_vendor.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_vendor.ShowDialog()
                End If
            End If
        End If

    End Sub
    Private Sub cbx_vendor_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_name.SelectedIndexChanged
        If cbx_vendor_name.Text <> "" And cbx_vendor_name.SelectedIndex >= 0 Then
            check_ven_name = True
            autocomplete("vendor_dtl_panel", cbx_vendor_city, "ven_city", "ven_name", CStr(cbx_vendor_name.Text))
            checksel()
        End If
    End Sub
    Private Sub cbx_vendor_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_name.TextChanged
        If cbx_vendor_name.Text = "" Then
            cbx_vendor_name.Items.Clear()
            autocomplete("vendor_dtl_panel", cbx_vendor_name, "ven_name")
            cbx_vendor_city.Items.Clear()
            autocomplete("vendor_dtl_panel", cbx_vendor_city, "ven_city")
            check_ven_name = False
        End If
    End Sub

    Private Sub cbx_vendor_city_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_city.Leave
        If cbx_vendor_city.Text <> "" Then
            For i As Integer = 0 To cbx_vendor_city.Items.Count - 1
                If cbx_vendor_city.Text = Convert.ToString(cbx_vendor_city.Items(i)) Then
                    check_ven_city = True
                    Exit For
                End If
            Next
            If check_ven_city = False Then
                Dim add_ven_city = MsgBox("City Name That You Provided Is Different From Past Data" + vbNewLine + "Add New Vendor Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add_ven_city = vbOK Then
                    cbx_vendor_city.Focus()
                    If add_vendor.IsHandleCreated = True Then
                        add_vendor.Close()
                    End If
                    Me.BackColor = Color.Gray
                    add_vendor.ShowDialog()
                End If

            End If
        End If

    End Sub
    Private Sub cbx_vendor_city_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_city.SelectedIndexChanged
        If cbx_vendor_city.Text <> "" And cbx_vendor_city.SelectedIndex >= 0 Then
            check_ven_city = True
            autocomplete("vendor_dtl_panel", cbx_vendor_name, "ven_name", "ven_city", CStr(cbx_vendor_city.Text))
            checksel()
        End If
    End Sub
    Private Sub cbx_vendor_city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_vendor_city.TextChanged
        If cbx_vendor_city.Text = "" Then
            cbx_vendor_name.Items.Clear()
            autocomplete("vendor_dtl_panel", cbx_vendor_name, "ven_name")
            cbx_vendor_city.Items.Clear()
            autocomplete("vendor_dtl_panel", cbx_vendor_city, "ven_city")
            check_ven_city = False
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
                checksel()
            Else
                Dim add = MsgBox(check_book_name.ToString() & "Book Name That You Provided Is Different From Past Data" + vbNewLine + "Add New Book Details First To Database", vbOKOnly Or MsgBoxStyle.Information, "")
                If add = vbOK Then
                    cbx_book_cat.Focus()
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
        If txt_qty.Text <> "" And Integer.TryParse(txt_qty.Text, qry) Then
            txt_total.Text = CStr(CDbl(txt_rate.Text) * qry)
        Else
            txt_total.Text = ""
            MsgBox("Check Quantity Value!", vbOKOnly Or MsgBoxStyle.Critical, "")
        End If
    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        txt_total.Text = ""
        txt_total.Enabled = True
        btn_padd.Enabled = False
        btn_padd.BackColor = Color.Gray
    End Sub

    Private Sub txt_total_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.Enter
        txt_total.Enabled = False
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        If txt_qty.Text.Length > 0 And boolUpdate = False Then
            btn_padd.Enabled = True
            btn_padd.BackColor = Color.White
        End If
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
    Public Sub clear_all()
        showsave()
        cbx_book_name.Enabled = True : cbx_book_auth.Enabled = True : cbx_book_cat.Enabled = True
        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        check_book_name = False : check_book_auth = False : check_book_cat = False
        txt_qty.Enabled = False
        txt_total.Enabled = False

        btn_padd.Enabled = False
        btn_padd.BackColor = Color.Gray
        boolUpdate = False
        cbx_book_name.Items.Clear()
        cbx_book_auth.Items.Clear()
        cbx_book_cat.Items.Clear()
        autocomplete("book_dtl_panel", cbx_book_name, "book_name")
        autocomplete("book_dtl_panel", cbx_book_auth, "book_author")
        autocomplete("book_dtl_panel", cbx_book_cat, "book_cat_name")
    End Sub
    'Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim item_num As Integer
    '    If CDbl(txt_total.Text) = CDbl(txt_rate.Text) * CInt(txt_qty.Text) Then
    '        If purchase_datagrid.Rows.Count > 0 Then
    '            item_num = purchase_datagrid.Rows((purchase_datagrid.Rows.Count) - 1).Cells(0).Value + 1
    '        Else
    '            item_num = 1
    '        End If

    '        table.Rows.Add(item_num, cbx_book_name.Text, cbx_book_auth.Text, cbx_book_cat.Text, txt_rate.Text, txt_qty.Text, txt_total.Text)
    '        clear_all()
    '    End If

    'End Sub

    Private Sub purchase_datagrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles purchase_datagrid.CellClick
        boolUpdate = True
        index = e.RowIndex
        Dim selectdata As DataGridViewRow
        selectdata = purchase_datagrid.Rows(index)
        cbx_book_name.Text = selectdata.Cells(1).Value.ToString()
        cbx_book_auth.Text = selectdata.Cells(2).Value.ToString()
        cbx_book_cat.Text = selectdata.Cells(3).Value.ToString()
        txt_rate.Text = selectdata.Cells(4).Value.ToString()
        txt_qty.Text = selectdata.Cells(5).Value.ToString()
        txt_total.Text = selectdata.Cells(6).Value.ToString()
        txt_qty.Enabled = True
        btn_pupdate.Enabled = True
        btn_pupdate.BackColor = Color.White
        btn_pdelete.Enabled = True
        btn_pdelete.BackColor = Color.White
        btn_padd.Enabled = False
        btn_padd.BackColor = Color.Gray
    End Sub


    'Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'purchase_datagrid.Rows(index).Cells(1).Value = cbx_book_name.Text
    '    'purchase_datagrid.Rows(index).Cells(2).Value = cbx_book_auth.Text
    '    'purchase_datagrid.Rows(index).Cells(3).Value = cbx_book_cat.Text
    '    'purchase_datagrid.Rows(index).Cells(4).Value = txt_rate.Text
    '    'purchase_datagrid.Rows(index).Cells(5).Value = txt_qty.Text
    '    'purchase_datagrid.Rows(index).Cells(6).Value = txt_total.Text

    '    'showsave()
    '    'cbx_book_name.Text = ""
    '    'cbx_book_auth.Text = ""
    '    'cbx_book_cat.Text = ""
    '    'txt_rate.Text = ""
    '    'txt_qty.Text = ""
    '    'txt_total.Text = ""
    '    'txt_qty.Enabled = False

    '    'btn_pupdate.Enabled = False
    '    'btn_pupdate.BackColor = Color.Gray
    '    'btn_pdelete.Enabled = False
    '    'btn_pdelete.BackColor = Color.Gray
    '    'boolUpdate = False
    'End Sub
    Public Sub arrange()
        Dim curr_value As Integer
        Dim next_val As Integer
        Dim gap As Integer
        'MsgBox(purchase_datagrid.Rows.Count)
        If purchase_datagrid.Rows.Count > 1 Then
            If purchase_datagrid.Rows(0).Cells(0).Value <> 1 Then
                purchase_datagrid.Rows(0).Cells(0).Value = 1
            End If
            For i As Integer = 0 To purchase_datagrid.Rows.Count
                If i + 1 = purchase_datagrid.Rows.Count Then
                    Exit For
                Else
                    curr_value = purchase_datagrid.Rows(i).Cells(0).Value
                    next_val = purchase_datagrid.Rows(i + 1).Cells(0).Value
                    gap = next_val - curr_value
                    If gap > 1 Then
                        next_val = next_val - (gap - 1)
                    End If
                    purchase_datagrid.Rows(i + 1).Cells(0).Value = next_val
                End If
            Next
        ElseIf purchase_datagrid.Rows.Count = 1 Then
            purchase_datagrid.Rows(0).Cells(0).Value = 1
        End If
    End Sub
    'Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'purchase_datagrid.Rows.RemoveAt(index)
    'showsave()
    'arrange()
    'cbx_book_name.Text = ""
    'cbx_book_auth.Text = ""
    'cbx_book_cat.Text = ""
    'txt_rate.Text = ""
    'txt_qty.Text = ""
    'txt_total.Text = ""
    'txt_qty.Enabled = False

    'btn_pupdate.Enabled = False
    'btn_pupdate.BackColor = Color.Gray
    'btn_pdelete.Enabled = False
    'btn_pdelete.BackColor = Color.Gray
    'End Sub
    Public Sub showsave()
        If purchase_datagrid.Rows.Count > 0 Then
            btn_save.Enabled = True
            btn_save.BackColor = Color.White
            btn_save_print.Enabled = True
            btn_save_print.BackColor = Color.White
        ElseIf purchase_datagrid.Rows.Count = 0 Then
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

            Dim ven_name As String = CStr(cbx_vendor_name.Text)
            Dim ven_city As String = CStr(cbx_vendor_city.Text)
            Dim ven_id As Integer

            cmd = New SqlCommand("select ven_id from vendor_mst where ven_name='" & ven_name & "' and ven_city='" & ven_city & "'", con)
            If IsDBNull(cmd.ExecuteScalar()) Then
                MsgBox("Check Vendor Details and Try Again", vbOKOnly Or MsgBoxStyle.Information, "")
            Else

                Dim vpdate As String = date_purchase.Value.ToString("yyyy-MM-dd")
                Dim vpid As Integer = CInt(p_txtbx_id.Text)
                ven_id = CInt(cmd.ExecuteScalar())

                For i As Integer = 0 To purchase_datagrid.Rows.Count - 1
                    Dim vbook_name As String = purchase_datagrid.Rows(i).Cells(1).Value.ToString()
                    Dim vbook_auth As String = purchase_datagrid.Rows(i).Cells(2).Value.ToString()
                    Dim vbook_cat As String = purchase_datagrid.Rows(i).Cells(3).Value.ToString()

                    cmd = New SqlCommand("select book_id from book_stock where book_name='" & vbook_name & "'and book_author='" & vbook_auth & "'and book_cat_name='" & vbook_cat & "'", con)
                    If IsDBNull(cmd.ExecuteScalar()) Then
                        MsgBox("Check Book Details in Gridview", MsgBoxStyle.Information, "")
                        Exit Sub
                    Else
                        Dim vitem_num As Integer = CInt(purchase_datagrid.Rows(i).Cells(0).Value)
                        Dim vbook_id As Integer = CInt(cmd.ExecuteScalar())
                        Dim vbook_qty As Integer = CInt(purchase_datagrid.Rows(i).Cells(5).Value.ToString())
                        Dim vbook_total As Double = CDbl(purchase_datagrid.Rows(i).Cells(6).Value.ToString())
                        Dim add_cmd As SqlCommand = New SqlCommand("insert into book_purchase values('" & vpdate & "','" & vpid & "','" & ven_id & "','" & vitem_num & "','" & vbook_id & "','" & vbook_qty & "','" & vbook_total & "')", con)
                        add_cmd.ExecuteNonQuery()
                        Dim select_cmd As SqlCommand = New SqlCommand("select qty from book_stock where book_id='" & vbook_id & "'", con)
                        Dim old_qty As Integer = select_cmd.ExecuteScalar()
                        Dim new_qty As Integer = old_qty + vbook_qty
                        qry = "update book_stock set qty='" & new_qty & "' where book_id='" & vbook_id & "'"
                        Dim update_cmd As SqlCommand = New SqlCommand(qry, con)
                        'MsgBox(qry)
                        update_cmd.ExecuteNonQuery()


                        Dim book_cnt_sel As SqlCommand = New SqlCommand("select cat_books from book_cat where cat_name='" & vbook_cat & "'", con)
                        Dim old_book_cnt As Integer = book_cnt_sel.ExecuteScalar()
                        Dim new_book_cnt As Integer = old_book_cnt + vbook_qty
                        qry = "update book_cat set cat_books='" & new_book_cnt & "' where cat_name='" & vbook_cat & "'"
                        Dim update_book_cat As SqlCommand = New SqlCommand(qry, con)
                        'MsgBox(qry)
                        update_book_cat.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Purchase Data Saved Successfully!", MsgBoxStyle.Information, "")



            End If

            con.Close()
        End If

    End Sub
    Public Sub clear_grid()
        cbx_vendor_name.Text = ""
        cbx_vendor_city.Text = ""
        Do While (purchase_datagrid.Rows.Count > 0)
            purchase_datagrid.Rows.RemoveAt(0)
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
        graph.DrawString("Purchase Bill", font_reg, Brushes.Black, New XRect(0, 0, pdfPage.Width.Point, 60), XStringFormats.Center)

        Dim pdate As String = "Date : " & date_purchase.Text.ToString()
        graph.DrawString(pdate, font_reg, Brushes.Black, New XRect(490, 45, 0, 0), XStringFormats.Center)

        Dim pid As String = "Purchase ID : " & p_txtbx_id.Text.ToString()
        graph.DrawString(pid, font_reg, Brushes.Black, New XRect(80, 65, 0, 0), XStringFormats.Center)

        Dim pven_name As String = "Vendor Name : " & cbx_vendor_name.Text.ToString()
        graph.DrawString(pven_name, font_reg, Brushes.Black, New XRect(200, 65, 0, 0), XStringFormats.Center)

        Dim pven_city As String = "Vendor City : " & cbx_vendor_city.Text.ToString()
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
        For i As Integer = 0 To purchase_datagrid.Rows.Count - 1
            x = 66
            graph.DrawString(purchase_datagrid.Rows(i).Cells(0).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            x = 150
            graph.DrawString((purchase_datagrid.Rows(i).Cells(1).Value.ToString() & " By " & purchase_datagrid.Rows(i).Cells(2).Value.ToString()), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            x = 305
            graph.DrawString(purchase_datagrid.Rows(i).Cells(5).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            total = total + CDbl(purchase_datagrid.Rows(i).Cells(6).Value)
            x = 350
            graph.DrawString(purchase_datagrid.Rows(i).Cells(6).Value.ToString(), font_reg, Brushes.Black, New XRect(x, y, 0, 0), XStringFormats.Center)

            y = y + 20
        Next

        graph.DrawString(line, font_reg, Brushes.Black, New XRect(248, y, 0, 0), XStringFormats.Center)
        y = y + 20
        graph.DrawString("Final Total : ", font_reg, Brushes.Black, New XRect(300, y, 0, 0), XStringFormats.Center)
        graph.DrawString(total, font_reg, Brushes.Black, New XRect(350, y, 0, 0), XStringFormats.Center)


        Dim pdfFilename As String = "Purchase_Bill_" & p_txtbx_id.Text & ".pdf"
        pdf.Save("D:\tybca11\project\Book Store MGT\Book Store MGT\storebills\purchase\" + pdfFilename)
        Process.Start("D:\tybca11\project\Book Store MGT\Book Store MGT\storebills\purchase\" + pdfFilename)

        clear_grid()
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear_all()
    End Sub

    Private Sub btn_padd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_padd.Click
        Dim item_num As Integer
        If CDbl(txt_total.Text) = CDbl(txt_rate.Text) * CInt(txt_qty.Text) Then
            If purchase_datagrid.Rows.Count > 0 Then
                item_num = purchase_datagrid.Rows((purchase_datagrid.Rows.Count) - 1).Cells(0).Value + 1
            Else
                item_num = 1
            End If

            table.Rows.Add(item_num, cbx_book_name.Text, cbx_book_auth.Text, cbx_book_cat.Text, txt_rate.Text, txt_qty.Text, txt_total.Text)
            clear_all()
        End If

    End Sub

    Private Sub btn_pupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pupdate.Click
        purchase_datagrid.Rows(index).Cells(1).Value = cbx_book_name.Text
        purchase_datagrid.Rows(index).Cells(2).Value = cbx_book_auth.Text
        purchase_datagrid.Rows(index).Cells(3).Value = cbx_book_cat.Text
        purchase_datagrid.Rows(index).Cells(4).Value = txt_rate.Text
        purchase_datagrid.Rows(index).Cells(5).Value = txt_qty.Text
        purchase_datagrid.Rows(index).Cells(6).Value = txt_total.Text

        showsave()
        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        txt_qty.Enabled = False

        btn_pupdate.Enabled = False
        btn_pupdate.BackColor = Color.Gray
        btn_pdelete.Enabled = False
        btn_pdelete.BackColor = Color.Gray
        boolUpdate = False
    End Sub

    Private Sub btn_pdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pdelete.Click
        purchase_datagrid.Rows.RemoveAt(index)
        showsave()
        arrange()
        cbx_book_name.Text = ""
        cbx_book_auth.Text = ""
        cbx_book_cat.Text = ""
        txt_rate.Text = ""
        txt_qty.Text = ""
        txt_total.Text = ""
        txt_qty.Enabled = False

        btn_pupdate.Enabled = False
        btn_pupdate.BackColor = Color.Gray
        btn_pdelete.Enabled = False
        btn_pdelete.BackColor = Color.Gray
    End Sub

    Private Sub purchase_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
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
