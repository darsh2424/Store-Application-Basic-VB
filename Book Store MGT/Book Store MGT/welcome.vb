Public Class welcome
    Dim count As Integer = 0
    Public Sub fadeout()
        For n = 90 To 10 Step -10
            Me.Opacity = n / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
            If n = 10 Then
                Me.Hide()
            End If
        Next

    End Sub
    Private Sub timer_load_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_load.Tick
        timer_load.Interval = 100
        count = count + 10
        ProgressBar1.Increment(count)
        lbl_load.Text = Str(count) + "%"
        If count = 100 Then
            fadeout()
            login.Show()

        End If
    End Sub

    Private Sub welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer_load.Start()
        lbl_load.Text = 0
        lbl_load.Location = New Point(484, 315)
        lbl_load.Visible = True
    End Sub
End Class
