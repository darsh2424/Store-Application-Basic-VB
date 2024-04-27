Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class add_cat
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim table As New DataTable("table")
    Dim index As Integer
    Dim chk_name, chk_book, chk_img As Boolean
    Public Sub loaddata()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("select * from book_cat", con)
        da = New SqlDataAdapter(cmd)
        Dim fetch_table As New DataTable("table")
        fetch_table.Clear()
        table.Clear()
        da.Fill(fetch_table)


        For i As Integer = 0 To fetch_table.Rows.Count - 1
            table.Rows.Add(fetch_table.Rows(i).Item(0), fetch_table.Rows(i).Item(1))
            cat_datagridview.Rows(i).Cells("Image").Value = Image.FromFile(fetch_table.Rows(i).Item(2))
            '"D:\tybca11\project\Book Store MGT\Book Store MGT\img\home.png"
        Next

        con.Close()
    End Sub

    Public Sub clear_all()
        txt_name.Text = ""
        txt_books.Text = 0

        btn_browse.Location = New Point(100, 300)
        txt_path.Text = ""
        txt_path.Visible = False
        btn_add.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub
    Private Sub add_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table.Columns.Clear()
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("No. of" + vbNewLine + " Books", Type.GetType("System.String"))
        cat_datagridview.DataSource = table
        '  Create Datagridview image column

        Dim dgvImageColumn As New DataGridViewImageColumn
        ' set header text to the column
        dgvImageColumn.Name = "Image"
        dgvImageColumn.HeaderText = "Image"
        dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        cat_datagridview.Columns.Add(dgvImageColumn)

        loaddata()
        chk_name = False : chk_book = False
        btn_add.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False

    End Sub

    Private Sub cat_datagridview_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cat_datagridview.CellClick
        index = e.RowIndex
        Dim selectdata As DataGridViewRow
        selectdata = cat_datagridview.Rows(index)
        txt_name.Text = selectdata.Cells(0).Value.ToString()
        txt_books.Text = selectdata.Cells(1).Value.ToString()

        txt_path.Visible = True
        txt_path.Location = New Point(100, 303)
        txt_path.Font = New Font("Arial", 10)
        btn_browse.Location = New Point(300, 300)
        btn_browse.Text = "CHANGE"
        con.Open()
        cmd = New SqlCommand("select cat_cover_image from book_cat where cat_name='" & txt_name.Text & "'", con)
        txt_path.Text = cmd.ExecuteScalar()
        con.Close()


        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim name As String = txt_name.Text
        Dim books As String = CInt(txt_books.Text)
        cmd = New SqlCommand("insert into book_cat values('" & name & "','" & books & "','" & txt_path.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Category Added Successfully!")
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
            Dim name As String = txt_name.Text
            Dim books As String = txt_books.Text
            cmd = New SqlCommand("update book_cat set cat_books='" & books & "',  cat_cover_image='" & txt_path.Text & "' where cat_name='" & name & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Updated Successfully!")
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
            Dim name As String = txt_name.Text
            cmd = New SqlCommand("delete from book_cat where cat_name='" & name & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Deleted Successfully!")
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
        If chk_name = True Then
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
    Private Sub close_img_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseHover
        close_img.BackColor = Color.Yellow
    End Sub

    Private Sub close_img_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseLeave
        close_img.BackColor = Color.Lavender
    End Sub

    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click

        If home.IsHandleCreated = True Then
            'dashboard.Close()
            home.Close()
            dashboard.switchpanel(home)
        End If
        Me.Close()
    End Sub


    Private Sub btn_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            txt_path.Text = opf.FileName()
            txt_path.Visible = True
            txt_path.Font = New Font("Arial", 8)
        End If
    End Sub
End Class