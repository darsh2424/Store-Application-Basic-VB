Imports System.Data.SqlClient
Public Class home

    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\tybca11\project\Book Store MGT\Book Store MGT\book_store_db.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim drd As SqlDataReader
    Public Sub cat_code()
        con.Open()
        cmd = New SqlCommand("select * from book_cat", con)
        drd = cmd.ExecuteReader()
        'Dim panel_main As New Panel
        'panel_main.Size = New Size(920, 500)
        'panel_main.BorderStyle = BorderStyle.FixedSingle
        'panel_main.Location = New Point(20, 90)

        Dim x As Integer = 20
        While drd.Read()

            Dim panel As New Panel
            panel.Name = "panel_" & drd.GetString(0)
            panel.Size = New Size(250, 250)
            panel.BorderStyle = BorderStyle.FixedSingle

            Dim pic As New PictureBox
            pic.Image = Image.FromFile(drd.GetString(2))
            pic.Width = 120
            pic.Height = 120
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Location = New Point(50, 10)

            Dim lbl_name As New Label
            lbl_name.Text = "Category Name:  " & drd.GetString(0)
            lbl_name.Font = New Font("Arial", 10.5)
            lbl_name.Location = New Point(10, 150)
            lbl_name.Size = New Size(500, 20)

            Dim lbl_book As New Label
            lbl_book.Text = "Category Books:  " & drd.GetValue(1)
            lbl_book.Font = New Font("Arial", 10.5)
            lbl_book.Location = New Point(10, 170)
            lbl_book.Size = New Size(500, 20)

            Dim btn As New Button
            btn.Name = "btn_" & drd.GetString(0)
            btn.Text = "Show Books"
            btn.Font = New Font("Arial", 10.5)
            btn.Location = New Point(10, 200)
            btn.Size = New Size(200, 30)

            panel.Location = New Point(x, 60)
            panel.Controls.Add(pic)
            panel.Controls.Add(lbl_name)
            panel.Controls.Add(lbl_book)
            panel.Controls.Add(btn)


            disp_panel.Controls.Add(panel)
            panel.Cursor = Cursors.Hand

            AddHandler btn.Click, Sub(btn_object As System.Object, btn_e As System.EventArgs)
                                      disp_panel.Enabled = False
                                      disp_panel.BackColor = Color.Gray
                                      dashboard.close_img.Visible = False
                                      btn_add_cat.Visible = False
                                      book_panel.Visible = True
                                      book_panel.Enabled = True

                                      lbl_cat.Text = btn.Name.Substring(4).ToString()
                                      If con.State = ConnectionState.Closed Then
                                          con.Open()

                                      End If
                                      cmd = New SqlCommand("select * from book_cat where cat_name='" & lbl_cat.Text & "'", con)
                                      drd = cmd.ExecuteReader()

                                      While drd.Read()
                                          lbl_books.Text = drd.GetValue(1).ToString()
                                      End While
                                      drd.Close()
                                      cmd = New SqlCommand("select * from book_stock where book_cat_name='" & lbl_cat.Text & "'", con)
                                      Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                                      Dim table As New DataTable("table")
                                      table.Clear()
                                      da.Fill(table)
                                      DataGridView1.DataSource = table
                                      DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                                  End Sub


            x += 300
        End While
        con.Close()

        'Me.Controls.Add(panel_main)
    End Sub



    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cat_code()
    End Sub


    Private Sub panel_close_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel_close_img.Click
        disp_panel.Enabled = True
        disp_panel.BackColor = Color.Lavender
        dashboard.close_img.Visible = True
        btn_add_cat.Visible = True
        book_panel.Visible = False
    End Sub

    Private Sub panel_close_img_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel_close_img.MouseHover
        panel_close_img.BackColor = Color.Yellow
    End Sub

    Private Sub panel_close_img_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel_close_img.MouseLeave
        panel_close_img.BackColor = Color.Lavender
    End Sub

    Private Sub btn_add_book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_book.Click
        add_book.Show()
    End Sub

    Private Sub btn_add_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_cat.Click
        add_cat.Show()
    End Sub
End Class