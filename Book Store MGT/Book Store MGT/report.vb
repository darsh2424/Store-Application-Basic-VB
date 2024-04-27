Imports System.Data.SqlClient
Public Class report
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand

    Dim tbl1 As String = ""
    Dim tbl2 As String = ""

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panel_sel.Enabled = False
    End Sub
    Public Sub default_data()
        If cbx_tbl.SelectedIndex >= 0 Then
            panel_sel.Enabled = True
            cbx_ch.Enabled = True

            cbx_ch.Text = ""
            cbx_col.Text = ""
            cbx_val.Text = ""
            If cbx_tbl.SelectedIndex = 0 Then
                cbx_ch.Items.Clear()
                cbx_col.Items.Clear()
                cbx_val.Items.Clear()

                cbx_col.Enabled = False
                cbx_val.Enabled = False
                report_purchase()
                cbx_ch.Items.Add("Vendor Name and City Wise")

            ElseIf cbx_tbl.SelectedIndex = 1 Then
                cbx_ch.Items.Clear()
                cbx_col.Items.Clear()
                cbx_val.Items.Clear()

                cbx_col.Enabled = False
                cbx_val.Enabled = False
                report_sales()
                cbx_ch.Items.Add("Customer Name and City Wise")


            End If
            cbx_ch.Items.Add("Book Name and Author Wise")
            cbx_ch.Items.Add("Book Category Wise")
        Else
            panel_sel.Enabled = False
            cbx_ch.Enabled = False
        End If

    End Sub

    Public Sub report_purchase(Optional ByVal ch As Integer = -1, Optional ByVal date_from As String = "", Optional ByVal date_to As String = "")
        con.Open()
        Dim qry As String = ""
        'If ch = -1 Then
        '    If date_from = "" And date_to = "" Then
        '        qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id"

        '    Else
        '        qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and pur.p_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and pur.p_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "'"
        '    End If
        'Else

        'End If

        If ch = 0 Then
            If date_from = "" And date_to = "" Then
                qry = "select ven.ven_id,ven.ven_name,ven.ven_city,ven.ven_contact,count(*) as Total_Purchase from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name group by ven.ven_id,ven.ven_name,ven.ven_city,ven.ven_contact order by count(*)"
            Else
                qry = "select ven.ven_id,ven.ven_name,ven.ven_city,ven.ven_contact,count(*) as Total_Purchase from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name and pur.p_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and pur.p_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by ven.ven_id,ven.ven_name,ven.ven_city,ven.ven_contact order by count(*)"
            End If
        ElseIf ch = 1 Then
            If date_from = "" And date_to = "" Then
                qry = "select book.book_id,book.book_name,book.book_author,count(*) as Total_Purchase from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_id,book.book_name,book.book_author order by count(*)"
            Else
                qry = "select book.book_id,book.book_name,book.book_author,count(*) as Total_Purchase from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name and pur.p_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and pur.p_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by book.book_id,book.book_name,book.book_author order by count(*)"
            End If

        ElseIf ch = 2 Then
            If date_from = "" And date_to = "" Then
                qry = "select book.book_cat_name,cat.cat_books as Total_Available,count(*) as Total_Purcahse from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_cat_name,cat.cat_books order by count(*)"
            Else
                qry = "select book.book_cat_name,cat.cat_books as Total_Available,count(*) as Total_Purcahse from book_purchase as pur, vendor_mst as ven,book_stock as book,book_cat as cat where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and book.book_cat_name = cat.cat_name and pur.p_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and pur.p_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by book.book_cat_name,cat.cat_books order by count(*)"

            End If
        ElseIf ch = -1 Then
            If date_from = "" And date_to = "" Then
                qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,ven.ven_contact,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id"

            Else
                qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,ven.ven_contact,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and pur.p_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and pur.p_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "'"
            End If
        End If

        If qry <> "" Then
            cmd = New SqlCommand(qry, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable("table")
            table.Clear()
            da.Fill(table)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = table

        End If
        con.Close()
    End Sub
    Public Sub report_sales(Optional ByVal ch As Integer = -1, Optional ByVal date_from As String = "", Optional ByVal date_to As String = "")
        con.Open()
        Dim qry As String = ""

        If ch = 0 Then
            If date_from = "" And date_to = "" Then
                qry = "select cust.cust_id,cust.cust_name,cust.cust_city,cust.cust_contact,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by cust.cust_id,cust.cust_name,cust.cust_city,cust.cust_contact order by count(*)"
            Else
                qry = "select cust.cust_id,cust.cust_name,cust.cust_city,cust.cust_contact,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name and sale.s_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and sale.s_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by cust.cust_id,cust.cust_name,cust.cust_city,cust.cust_contact order by count(*)"
            End If
        ElseIf ch = 1 Then
            If date_from = "" And date_to = "" Then
                qry = "select book.book_id,book.book_name,book.book_author,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_id,book.book_name,book.book_author order by count(*)"
            Else
                qry = "select book.book_id,book.book_name,book.book_author,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name and sale.s_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and sale.s_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by book.book_id,book.book_name,book.book_author order by count(*)"
            End If

        ElseIf ch = 2 Then
            If date_from = "" And date_to = "" Then
                qry = "select book.book_cat_name,cat.cat_books as Total_Available,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_cat_name,cat.cat_books order by count(*)"
            Else
                qry = "select book.book_cat_name,cat.cat_books as Total_Available,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name and sale.s_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and sale.s_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "' group by book.book_cat_name,cat.cat_books order by count(*)"
            End If
        ElseIf ch = -1 Then
            If date_from = "" And date_to = "" Then
                qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,cust.cust_contact,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id"

            Else
                qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,cust.cust_contact,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and sale.s_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and sale.s_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "'"
            End If
        End If

        If qry <> "" Then
            cmd = New SqlCommand(qry, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable("table")
            table.Clear()
            da.Fill(table)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = table

        End If
        con.Close()
























        'con.Open()
        'Dim qry As String = ""
        'If ch = -1 Then
        '    If date_from = "" And date_to = "" Then
        '        qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id"

        '    Else
        '        qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and sale.s_date>='" & CDate(date_from).ToString("yyyy-MM-dd") & "'" & " and sale.s_date<='" & CDate(date_to).ToString("yyyy-MM-dd") & "'"
        '        'MsgBox(qry)
        '    End If

        'Else

        '    If ch = 0 Then
        '        qry = "select cust.cust_id,cust.cust_name,cust.cust_city,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by cust.cust_id,cust.cust_name,cust.cust_city order by count(*)"
        '    ElseIf ch = 1 Then
        '        qry = "select book.book_id,book.book_name,book.book_author,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_id,book.book_name,book.book_author order by count(*)"
        '    ElseIf ch = 2 Then
        '        qry = "select book.book_cat_name,cat.cat_books as Total_Available,count(*) as Total_Sales from book_sales as sale, customer_mst as cust,book_stock as book,book_cat as cat where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and book.book_cat_name = cat.cat_name group by book.book_cat_name,cat.cat_books order by count(*)"
        '    End If

        'End If
        'If qry <> "" Then
        '    cmd = New SqlCommand(qry, con)
        '    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        '    Dim table As DataTable = New DataTable("table")
        '    table.Clear()
        '    da.Fill(table)
        '    DataGridView1.DataSource = Nothing
        '    DataGridView1.DataSource = table
        'End If
        'con.Close()

    End Sub

    Private Sub cbx_tbl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_tbl.SelectedIndexChanged
        default_data()
    End Sub

    Private Sub cbx_col_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ch.SelectedIndexChanged

        If cbx_ch.SelectedIndex >= 0 Then
            'cbx_val.Enabled = True
            If cbx_tbl.SelectedIndex = 0 Then
                report_purchase(cbx_ch.SelectedIndex)
            ElseIf cbx_tbl.SelectedIndex = 1 Then
                report_sales(cbx_ch.SelectedIndex)
            End If

            cbx_col.Enabled = True
            cbx_col.Text = ""
            cbx_col.Items.Clear()
            If cbx_ch.SelectedIndex < 2 Then
                cbx_col.Items.Add(DataGridView1.Columns(1).Name)
                cbx_col.Items.Add(DataGridView1.Columns(2).Name)
            ElseIf cbx_ch.SelectedIndex = 2 Then
                cbx_col.Items.Add(DataGridView1.Columns(0).Name)
            End If

            'If cbx_ch.SelectedIndex = 0 Then
            '    cbx_val.Items.Clear()
            '    cbx_val.Enabled = True
            '    For i As Integer = 0 To DataGridView1.RowCount - 1
            '        cbx_val.Items.Add(DataGridView1.Rows(i).Cells(1).Value.ToString & "-" & DataGridView1.Rows(i).Cells(2).Value.ToString)
            '    Next
            'ElseIf cbx_ch.SelectedIndex = 1 Then
            '    cbx_val.Items.Clear()
            '    cbx_val.Enabled = True
            '    For i As Integer = 0 To DataGridView1.RowCount - 1
            '        cbx_val.Items.Add(DataGridView1.Rows(i).Cells(1).Value.ToString & "-" & DataGridView1.Rows(i).Cells(2).Value.ToString)
            '    Next
            'ElseIf cbx_ch.SelectedIndex = 2 Then
            '    cbx_val.Items.Clear()
            '    cbx_val.Enabled = True
            '    For i As Integer = 0 To DataGridView1.RowCount - 1
            '        cbx_val.Items.Add(DataGridView1.Rows(i).Cells(0).Value.ToString)
            '    Next
            'End If
        Else
            cbx_col.Items.Clear()
            cbx_col.Enabled = False
        End If

    End Sub

    Private Sub cbx_col_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ch.TextChanged
        If cbx_ch.Text = "" Then
            If cbx_tbl.SelectedIndex = 0 Then
                report_purchase()
            ElseIf cbx_tbl.SelectedIndex = 1 Then
                report_sales()
            End If
            cbx_col.Text = ""
            cbx_col.Items.Clear()
            cbx_col.Enabled = False
            cbx_val.Text = ""
            cbx_val.Items.Clear()
            cbx_val.Enabled = False
        End If
    End Sub

    Private Sub cbx_col_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_col.SelectedIndexChanged
        cbx_val.Text = ""
        cbx_val.Items.Clear()
        cbx_val.Enabled = False
        If cbx_col.SelectedIndex >= 0 Then
            cbx_val.Enabled = True
            For i As Integer = 0 To DataGridView1.RowCount - 1
                cbx_val.Items.Add(DataGridView1.Rows(i).Cells(cbx_col.Text).Value)
            Next
        End If
    End Sub

    Private Sub cbx_val_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_val.SelectedIndexChanged
        If cbx_val.SelectedIndex >= 0 Then
            Dim qry As String = ""
            If cbx_tbl.SelectedIndex = 0 Then
                qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "'"

            ElseIf cbx_tbl.SelectedIndex = 1 Then
                qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "'"

            End If

            cmd = New SqlCommand(qry, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable("table")
            table.Clear()
            da.Fill(table)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = table
        End If
    End Sub
    Public Sub report_sel()
        If CheckBox1.Checked Then
            panel_sel.Enabled = False
            panel_show.Enabled = True
            cbx_tbl.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            If cbx_ch.Text = "" Then

                If cbx_val.Text = "" Then
                    If cbx_tbl.SelectedIndex = 0 Then
                        report_purchase(, DateTimePicker1.Text, DateTimePicker2.Text)
                    ElseIf cbx_tbl.SelectedIndex = 1 Then
                        report_sales(, DateTimePicker1.Text, DateTimePicker2.Text)

                    End If
                End If

            Else
                If cbx_val.Text = "" Then
                    If cbx_tbl.SelectedIndex = 0 Then
                        report_purchase(cbx_ch.SelectedIndex, DateTimePicker1.Text, DateTimePicker2.Text)
                    ElseIf cbx_tbl.SelectedIndex = 1 Then
                        report_sales(cbx_ch.SelectedIndex, DateTimePicker1.Text, DateTimePicker2.Text)
                    End If

                    cbx_col.Enabled = True
                    cbx_col.Text = ""
                    cbx_col.Items.Clear()
                    If cbx_ch.SelectedIndex < 2 Then
                        cbx_col.Items.Add(DataGridView1.Columns(1).Name)
                        cbx_col.Items.Add(DataGridView1.Columns(2).Name)
                    ElseIf cbx_ch.SelectedIndex = 2 Then
                        cbx_col.Items.Add(DataGridView1.Columns(0).Name)
                    End If
                Else
                    If cbx_val.SelectedIndex >= 0 Then
                        Dim qry As String = ""
                        If cbx_tbl.SelectedIndex = 0 Then
                            qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "' and pur.p_date>='" & CDate(DateTimePicker1.Text).ToString("yyyy-MM-dd") & "' and pur.p_date<='" & CDate(DateTimePicker2.Text).ToString("yyyy-MM-dd") & "'"

                        ElseIf cbx_tbl.SelectedIndex = 1 Then
                            qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "' and sale.s_date>='" & CDate(DateTimePicker1.Text).ToString("yyyy-MM-dd") & "' and sale.s_date<='" & CDate(DateTimePicker2.Text).ToString("yyyy-MM-dd") & "'"


                        End If

                        cmd = New SqlCommand(qry, con)
                        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                        Dim table As DataTable = New DataTable("table")
                        table.Clear()
                        da.Fill(table)
                        DataGridView1.DataSource = Nothing
                        DataGridView1.DataSource = table
                    End If
                End If


            End If
        Else
            panel_sel.Enabled = True
            cbx_tbl.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker1.Value = "01-10-2023"
            If cbx_ch.Text = "" Then

                If cbx_val.Text = "" Then
                    If cbx_tbl.SelectedIndex = 0 Then
                        report_purchase()
                    ElseIf cbx_tbl.SelectedIndex = 1 Then
                        report_sales()

                    End If
                End If

            Else
                If cbx_val.Text = "" Then
                    If cbx_tbl.SelectedIndex = 0 Then
                        report_purchase(cbx_ch.SelectedIndex)
                    ElseIf cbx_tbl.SelectedIndex = 1 Then
                        report_sales(cbx_ch.SelectedIndex)
                    End If

                    cbx_col.Enabled = True
                    cbx_col.Text = ""
                    cbx_col.Items.Clear()
                    If cbx_ch.SelectedIndex < 2 Then
                        cbx_col.Items.Add(DataGridView1.Columns(1).Name)
                        cbx_col.Items.Add(DataGridView1.Columns(2).Name)
                    ElseIf cbx_ch.SelectedIndex = 2 Then
                        cbx_col.Items.Add(DataGridView1.Columns(0).Name)
                    End If
                Else
                    If cbx_val.SelectedIndex >= 0 Then
                        Dim qry As String = ""
                        If cbx_tbl.SelectedIndex = 0 Then
                            qry = "select pur.p_date,pur.p_id,pur.p_item_num,ven.ven_name,ven.ven_city,book.book_name,book.book_author,book.book_cat_name,pur.p_qty,pur.p_total from book_purchase as pur, vendor_mst as ven,book_stock as book where pur.p_ven_id=ven.ven_id and pur.p_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "'"

                        ElseIf cbx_tbl.SelectedIndex = 1 Then
                            qry = "select sale.s_date,sale.s_id,sale.s_item_num,cust.cust_name,cust.cust_city,book.book_name,book.book_author,book.book_cat_name,sale.s_qty,sale.s_total from book_sales as sale, customer_mst as cust,book_stock as book where sale.s_cust_id=cust.cust_id and sale.s_book_id=book.book_id and " & cbx_col.Text & "='" & cbx_val.Text & "'"


                        End If

                        cmd = New SqlCommand(qry, con)
                        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                        Dim table As DataTable = New DataTable("table")
                        table.Clear()
                        da.Fill(table)
                        DataGridView1.DataSource = Nothing
                        DataGridView1.DataSource = table
                    End If
                End If


            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        report_sel()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        report_sel()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        report_sel()
    End Sub
End Class