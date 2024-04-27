Public Class dashboard
    Public Sub switchpanel(ByVal panel As Form)
        page_load.Size = New Size(1056, 618)
        page_load.Location = New Point(147, 29)
        page_load.Controls.Clear()
        panel.TopLevel = False
        page_load.Controls.Add(panel)
        panel.Show()
        
    End Sub
    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        If home.IsHandleCreated = True Then
            home.Close()
        End If
        switchpanel(home)
    End Sub

    Private Sub purchase_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchase_btn.Click
        'MsgBox(purchase.IsHandleCreated.ToString)
        If purchase.IsHandleCreated = True Then
            purchase.Close()
        End If
        switchpanel(purchase)
    End Sub

    Private Sub sales_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_btn.Click
        If sales.IsHandleCreated = True Then
            sales.Close()
        End If
        switchpanel(sales)
    End Sub

    Private Sub report_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles report_btn.Click
        If report.IsHandleCreated = True Then
            report.Close()
        End If
        switchpanel(report)
    End Sub

    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click
        Me.Close()
        welcome.Close()
    End Sub
    Private Sub close_img_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseHover
        close_img.BackColor = Color.Yellow
    End Sub

    Private Sub close_img_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.MouseLeave
        close_img.BackColor = Color.AliceBlue
    End Sub

    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        switchpanel(home)
    End Sub

    Private Sub btn_add_vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_vendor.Click
        'switchpanel(add_vendor)
        If add_vendor.IsHandleCreated = True Then
            add_vendor.Close()
        End If
        page_load.Controls.Clear()
        page_load.Size = New Size(670, 700)
        page_load.Location = New Point(300, 0)
        add_vendor.TopLevel = False
        page_load.Controls.Add(add_vendor)
        add_vendor.Show()
    End Sub

    Private Sub btn_add_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_cust.Click
        'switchpanel(add_customer)
        If add_customer.IsHandleCreated = True Then
            add_customer.Close()
        End If
        page_load.Controls.Clear()
        page_load.Size = New Size(670, 700)
        page_load.Location = New Point(300, 0)
        add_customer.TopLevel = False
        page_load.Controls.Add(add_customer)
        add_customer.Show()
    End Sub
End Class