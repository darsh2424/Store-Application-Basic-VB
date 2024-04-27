Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Dim psw As String
        psw = txt_psw.Text
        If psw = "admin" Then
            Me.Close()
            dashboard.Show()
        Else
            error_msg.Visible = True
        End If

    End Sub
    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click
        welcome.Close()
    End Sub
    Private Sub close_img_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseHover
        close_img.BackColor = Color.Yellow
    End Sub

    Private Sub close_img_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseLeave
        close_img.BackColor = Color.Lavender
    End Sub
End Class