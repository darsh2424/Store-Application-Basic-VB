Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class add_book
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim table As New DataTable("table")
    Dim index As Integer
    Dim chk_name, chk_auth, chk_cat, chk_rate As Boolean
    Public Sub loaddata()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("select * from book_stock", con)
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
        cmd = New SqlCommand("select max(book_id) from book_stock", con)
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
        txt_aut.Text = ""
        txt_cat.Text = ""
        txt_quan.Text = ""
        txt_rate.Text = ""
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub
    Private Sub add_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table.Columns.Clear()
        table.Columns.Add("Book ID", Type.GetType("System.Int32"))
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("Author", Type.GetType("System.String"))
        table.Columns.Add("Category", Type.GetType("System.String"))
        table.Columns.Add("QTY", Type.GetType("System.String"))
        table.Columns.Add("Rate Per Unit", Type.GetType("System.String"))
        vendor_gridview.DataSource = table
        loaddata()
        find_id()
        chk_name = False : chk_auth = False : chk_cat = False : chk_rate = False
        btn_add.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False

        If con.State = ConnectionState.Closed Then
            con.Open()
            cmd = New SqlCommand("select distinct(cat_name) from book_cat", con)
            Dim drd As SqlDataReader = cmd.ExecuteReader()
            While drd.Read()
                txt_cat.Items.Add(drd.GetString(0))
            End While

            con.Close()
        End If
    End Sub

    Private Sub vendor_gridview_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles vendor_gridview.CellClick
        index = e.RowIndex
        Dim selectdata As DataGridViewRow
        selectdata = vendor_gridview.Rows(index)
        txt_id.Text = selectdata.Cells(0).Value.ToString()
        txt_name.Text = selectdata.Cells(1).Value.ToString()
        txt_aut.Text = selectdata.Cells(2).Value.ToString()
        txt_cat.Text = selectdata.Cells(3).Value.ToString()
        txt_quan.Text = CInt(selectdata.Cells(4).Value.ToString())
        txt_rate.Text = CDbl(selectdata.Cells(5).Value.ToString())
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
        Dim auth As String = txt_aut.Text
        Dim cat As String = txt_cat.Text
        Dim qty As Integer = CInt(txt_quan.Text)
        Dim rate As Double = CDbl(txt_rate.Text)
        cmd = New SqlCommand("insert into book_stock values('" & id & "','" & name & "','" & auth & "','" & cat & "','" & qty & "','" & rate & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Book Added Successfully!")
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
            Dim auth As String = txt_aut.Text
            Dim cat As String = txt_cat.Text
            Dim qty As Integer = CInt(txt_quan.Text)
            Dim rate As Double = CDbl(txt_rate.Text)
            cmd = New SqlCommand("update book_stock set book_name='" & name & "',book_author='" & auth & "',book_cat_name='" & cat & "',qty='" & qty & "',rate_per_unit='" & rate & "' where book_id='" & id & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Updated Successfully!")
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
            cmd = New SqlCommand("delete from book_stock where book_id=" & id, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted Successfully!")
            con.Close()
            loaddata()
            clear_all()
        End If
    End Sub

    Public Function txtcheck(ByVal str As String) As String
        If str <> "" Then
            If Not Regex.IsMatch(str, "^[A-za-z ]+[A-za-z]${3,30}") Then
                Dim msg = MsgBox("Should only have alphabets-space with length between 3 to 30" + vbNewLine + "Are You Sure With Provided Input?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "")
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
        If chk_name = True And chk_auth = True And chk_cat = True And chk_rate = True Then
            btn_add.Enabled = True
            btn_add.BackColor = Color.White
        End If
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

    Private Sub txt_aut_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_aut.Leave
        If txtcheck(txt_aut.Text) Then
            chk_auth = True
        Else
            txt_aut.Text = ""
            '    txt_aut.Focus()
        End If
        checksel()
    End Sub

    Private Sub txt_cat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cat.Leave
        chk_cat = False
        If txtcheck(txt_cat.Text) Then
            For i As Integer = 0 To txt_cat.Items.Count - 1
                If txt_cat.Text = txt_cat.Items(i).ToString Then
                    chk_cat = True
                End If
            Next
        Else
            txt_cat.Text = ""
            Exit Sub
            '    txt_cat.Focus()
        End If

        If chk_cat = False Then
            Dim ans = MsgBox("Category You Provided is Not Exist!" + vbNewLine + "Do You Want to Add New Category?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "")
            If ans = vbYes Then
                add_cat.ShowDialog()
            ElseIf ans = vbNo Then
                MsgBox("Select Category that already exist !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "")
                txt_cat.Text = ""
            End If
        End If
        checksel()
    End Sub

    Private Sub txt_rate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_rate.Leave, txt_rate.TextChanged
        If txt_rate.Text <> "" Then
            If Not Regex.IsMatch(txt_rate.Text, "^[0-9]{1,5}$") Then
                MsgBox("Must Only Digits! ", MsgBoxStyle.Critical, "")
                chk_rate = False
                txt_rate.Text = ""
                'txt_rate.Focus()
            Else
                chk_rate = True
            End If
        End If
        checksel()
    End Sub

    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click


        If home.IsHandleCreated = True Then
            'dashboard.Close()
            home.Close()
            dashboard.switchpanel(home)
        End If
        Me.Close()
    End Sub
    Private Sub close_img_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseHover
        close_img.BackColor = Color.Yellow
    End Sub

    Private Sub close_img_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseLeave
        close_img.BackColor = Color.Lavender
    End Sub
End Class