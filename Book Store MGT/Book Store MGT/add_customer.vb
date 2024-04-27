Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class add_customer
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim qry As String
    Dim rdr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim table As New DataTable("table")
    Dim index As Integer
    Dim chk_name, chk_add, chk_city, chk_pin, chk_con As Boolean
    Public Sub loaddata()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("select * from customer_mst", con)
        da = New SqlDataAdapter(cmd)
        Dim fetch_table As New DataTable("table")
        fetch_table.Clear()
        table.Clear()
        da.Fill(fetch_table)
        For i As Integer = 0 To fetch_table.Rows.Count - 1
            table.Rows.Add(fetch_table.Rows(i).Item(0), fetch_table.Rows(i).Item(1), fetch_table.Rows(i).Item(2), fetch_table.Rows(i).Item(3), fetch_table.Rows(i).Item(4), fetch_table.Rows(i).Item(5))
        Next

        con.Close()
    End Sub
    Public Sub find_id()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        txt_id.Enabled = False
        cmd = New SqlCommand("select max(cust_id) from customer_mst", con)
        If IsDBNull(cmd.ExecuteScalar()) Then
            txt_id.Text = 1
        Else
            txt_id.Text = CInt(cmd.ExecuteScalar()) + 1
        End If
        con.Close()
    End Sub
    Public Sub clear_all()
        find_id()
        txt_name.Text = ""
        txt_addr.Text = ""
        txt_city.Text = ""
        txt_pin.Text = ""
        txt_con.Text = ""
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub
    Private Sub add_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table.Columns.Clear()
        table.Columns.Add("ID", Type.GetType("System.Int32"))
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("Address", Type.GetType("System.String"))
        table.Columns.Add("City", Type.GetType("System.String"))
        table.Columns.Add("Pincode", Type.GetType("System.String"))
        table.Columns.Add("Contact", Type.GetType("System.String"))
        customer_gridview.DataSource = table
        loaddata()
        btn_update.Enabled = False
        btn_delete.Enabled = False
        find_id()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        qry = "select distinct(cust_city) from customer_mst"
        cbx_city.Items.Clear()
        cmd = New SqlCommand(qry, con)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cbx_city.Items.Add(rdr.GetString(0))
        End While
        con.Close()

        chk_name = False : chk_add = False : chk_city = False : chk_pin = False : chk_con = False
        btn_add.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub customer_gridview_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customer_gridview.CellClick
        index = e.RowIndex
        Dim selectdata As DataGridViewRow
        selectdata = customer_gridview.Rows(index)
        txt_id.Text = selectdata.Cells(0).Value.ToString()
        txt_name.Text = selectdata.Cells(1).Value.ToString()
        txt_addr.Text = selectdata.Cells(2).Value.ToString()
        txt_city.Text = selectdata.Cells(3).Value.ToString()
        txt_pin.Text = selectdata.Cells(4).Value.ToString()
        txt_con.Text = selectdata.Cells(5).Value.ToString()
        txt_id.Enabled = False
        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim id As Integer = CInt(txt_id.Text)
        Dim name As String = txt_name.Text
        Dim addr As String = txt_addr.Text
        Dim city As String = txt_city.Text
        Dim pin As String = txt_pin.Text
        Dim contact As String = txt_con.Text
        cmd = New SqlCommand("insert into customer_mst values('" & id & "','" & name & "','" & addr & "','" & city & "','" & pin & "','" & contact & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Customer Added Successfully!")
        loaddata()
        con.Close()
        clear_all()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim msg = MsgBox("Do you want to Update record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "")
        If msg = vbYes Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim id As Integer = CInt(txt_id.Text)
            Dim name As String = txt_name.Text
            Dim addr As String = txt_addr.Text
            Dim city As String = txt_city.Text
            Dim pin As String = txt_pin.Text
            Dim contact As String = txt_con.Text
            cmd = New SqlCommand("update customer_mst set cust_name='" & name & "',cust_addr='" & addr & "',cust_city='" & city & "',cust_city_pincode='" & pin & "',cust_contact='" & contact & "' where cust_id='" & id & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Updates Successfully!")
            loaddata()
            clear_all()
        End If

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim msg = MsgBox("Do you want to delete record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "")
        If msg = vbYes Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim id As Integer = CInt(txt_id.Text)
            cmd = New SqlCommand("delete from customer_mst where cust_id=" & id, con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Deleted Successfully!")
            con.Close()
            loaddata()
            clear_all()
        End If
    End Sub

    Private Sub cbx_city_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_city.SelectedIndexChanged
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim city As String = cbx_city.Text
        If cbx_city.SelectedIndex <> -1 Or cbx_city.Text <> "" Then
            cmd = New SqlCommand("select * from customer_mst where cust_city='" & city & "'", con)
            da = New SqlDataAdapter(cmd)
            Dim fetch_table As New DataTable("table")
            fetch_table.Clear()
            table.Clear()
            da.Fill(fetch_table)
            For i As Integer = 0 To fetch_table.Rows.Count - 1
                table.Rows.Add(fetch_table.Rows(i).Item(0), fetch_table.Rows(i).Item(1), fetch_table.Rows(i).Item(2), fetch_table.Rows(i).Item(3), fetch_table.Rows(i).Item(4), fetch_table.Rows(i).Item(5))
            Next
        End If

        con.Close()
    End Sub
    Public Function txtcheck(ByVal str As String) As String
        If str <> "" Then
            If Not Regex.IsMatch(str, "^[A-za-z ]+[A-za-z]${3,30}") Then
                Dim msg = MsgBox("Should only have alphabets-space with length between 5 to 30" + vbNewLine + "Are You Sure With Provided Input?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "")
                If msg = vbNo Then
                    Return False
                    Exit Function
                End If
            Else
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function
    Public Sub checksel()
        If chk_name = True And chk_add = True And chk_city = True And chk_pin = True And chk_con = True Then
            btn_add.Enabled = True
            btn_add.BackColor = Color.White
        End If
    End Sub

    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click

        If sales.IsHandleCreated = True Then
            sales.Close()
        End If
        Me.Close()
    End Sub

    Private Sub txt_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.Leave
        If txtcheck(txt_name.Text) Then
            chk_name = True
        Else
            txt_name.Text = ""
            'txt_name.Focus()
        End If
        checksel()
    End Sub

    Private Sub txt_con_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_con.Leave
        If txt_con.Text <> "" Then
            If Not Regex.IsMatch(txt_con.Text, "^[0-9]{10}$") Then
                MsgBox("Must 10 Digits! ", MsgBoxStyle.Critical, "")
                chk_con = False
                txt_con.Text = ""
                'txt_rate.Focus()
            Else
                chk_con = True
            End If
        End If
        checksel()
    End Sub

    Private Sub txt_addr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_addr.Leave
        If txtcheck(txt_addr.Text) Then
            chk_add = True
        Else
            txt_addr.Text = ""
            'txt_name.Focus()
        End If
        checksel()
    End Sub

    Private Sub txt_city_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_city.Leave
        If txtcheck(txt_city.Text) Then
            chk_city = True
        Else
            txt_city.Text = ""
            'txt_name.Focus()
        End If
        checksel()
    End Sub

    Private Sub txt_pin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pin.Leave
        If txt_pin.Text <> "" Then
            If Not Regex.IsMatch(txt_pin.Text, "^[0-9]{6}$") Then
                MsgBox("Must 6 Digits! ", MsgBoxStyle.Critical, "")
                chk_pin = False
                txt_pin.Text = ""
                'txt_rate.Focus()
            Else
                chk_pin = True
            End If
        End If
        checksel()
    End Sub


    Private Sub txt_pin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pin.TextChanged
        If txt_pin.Text <> "" Then
            If Regex.IsMatch(txt_pin.Text, "^[0-9]{6}$") Then
                chk_pin = True
            Else
                chk_pin = False
            End If
        End If
        checksel()
    End Sub
End Class