<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.store_img = New System.Windows.Forms.PictureBox()
        Me.home_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_add_cust = New System.Windows.Forms.Button()
        Me.btn_add_vendor = New System.Windows.Forms.Button()
        Me.report_btn = New System.Windows.Forms.Button()
        Me.sales_btn = New System.Windows.Forms.Button()
        Me.purchase_btn = New System.Windows.Forms.Button()
        Me.page_load = New System.Windows.Forms.Panel()
        Me.close_img = New System.Windows.Forms.PictureBox()
        CType(Me.store_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'store_img
        '
        Me.store_img.Image = CType(resources.GetObject("store_img.Image"), System.Drawing.Image)
        Me.store_img.Location = New System.Drawing.Point(10, 58)
        Me.store_img.Name = "store_img"
        Me.store_img.Size = New System.Drawing.Size(121, 93)
        Me.store_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.store_img.TabIndex = 4
        Me.store_img.TabStop = False
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Silver
        Me.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.home_btn.FlatAppearance.BorderSize = 0
        Me.home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home_btn.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.Location = New System.Drawing.Point(0, 188)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(148, 48)
        Me.home_btn.TabIndex = 13
        Me.home_btn.Text = "Home"
        Me.home_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_add_cust)
        Me.Panel1.Controls.Add(Me.btn_add_vendor)
        Me.Panel1.Controls.Add(Me.report_btn)
        Me.Panel1.Controls.Add(Me.sales_btn)
        Me.Panel1.Controls.Add(Me.purchase_btn)
        Me.Panel1.Controls.Add(Me.home_btn)
        Me.Panel1.Controls.Add(Me.store_img)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 658)
        Me.Panel1.TabIndex = 0
        '
        'btn_add_cust
        '
        Me.btn_add_cust.BackColor = System.Drawing.Color.Silver
        Me.btn_add_cust.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_add_cust.FlatAppearance.BorderSize = 0
        Me.btn_add_cust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_add_cust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_add_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_cust.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_cust.Location = New System.Drawing.Point(0, 514)
        Me.btn_add_cust.Name = "btn_add_cust"
        Me.btn_add_cust.Size = New System.Drawing.Size(148, 48)
        Me.btn_add_cust.TabIndex = 18
        Me.btn_add_cust.Text = "Customer"
        Me.btn_add_cust.UseVisualStyleBackColor = False
        '
        'btn_add_vendor
        '
        Me.btn_add_vendor.BackColor = System.Drawing.Color.Silver
        Me.btn_add_vendor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_add_vendor.FlatAppearance.BorderSize = 0
        Me.btn_add_vendor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_add_vendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_add_vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_vendor.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_vendor.Location = New System.Drawing.Point(0, 450)
        Me.btn_add_vendor.Name = "btn_add_vendor"
        Me.btn_add_vendor.Size = New System.Drawing.Size(148, 48)
        Me.btn_add_vendor.TabIndex = 17
        Me.btn_add_vendor.Text = "Vendor"
        Me.btn_add_vendor.UseVisualStyleBackColor = False
        '
        'report_btn
        '
        Me.report_btn.BackColor = System.Drawing.Color.Silver
        Me.report_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.report_btn.FlatAppearance.BorderSize = 0
        Me.report_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.report_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.report_btn.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.report_btn.Location = New System.Drawing.Point(0, 382)
        Me.report_btn.Name = "report_btn"
        Me.report_btn.Size = New System.Drawing.Size(148, 48)
        Me.report_btn.TabIndex = 16
        Me.report_btn.Text = "Report"
        Me.report_btn.UseVisualStyleBackColor = False
        '
        'sales_btn
        '
        Me.sales_btn.BackColor = System.Drawing.Color.Silver
        Me.sales_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.sales_btn.FlatAppearance.BorderSize = 0
        Me.sales_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.sales_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sales_btn.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_btn.Location = New System.Drawing.Point(0, 319)
        Me.sales_btn.Name = "sales_btn"
        Me.sales_btn.Size = New System.Drawing.Size(148, 47)
        Me.sales_btn.TabIndex = 15
        Me.sales_btn.Text = "Sales"
        Me.sales_btn.UseVisualStyleBackColor = False
        '
        'purchase_btn
        '
        Me.purchase_btn.BackColor = System.Drawing.Color.Silver
        Me.purchase_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.purchase_btn.FlatAppearance.BorderSize = 0
        Me.purchase_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.purchase_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.purchase_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purchase_btn.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_btn.Location = New System.Drawing.Point(0, 253)
        Me.purchase_btn.Name = "purchase_btn"
        Me.purchase_btn.Size = New System.Drawing.Size(148, 48)
        Me.purchase_btn.TabIndex = 14
        Me.purchase_btn.Text = "Purchase"
        Me.purchase_btn.UseVisualStyleBackColor = False
        '
        'page_load
        '
        Me.page_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.page_load.Location = New System.Drawing.Point(147, 29)
        Me.page_load.Name = "page_load"
        Me.page_load.Size = New System.Drawing.Size(1056, 618)
        Me.page_load.TabIndex = 1
        '
        'close_img
        '
        Me.close_img.BackColor = System.Drawing.Color.AliceBlue
        Me.close_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_img.Image = CType(resources.GetObject("close_img.Image"), System.Drawing.Image)
        Me.close_img.Location = New System.Drawing.Point(1169, 0)
        Me.close_img.Margin = New System.Windows.Forms.Padding(2)
        Me.close_img.Name = "close_img"
        Me.close_img.Size = New System.Drawing.Size(34, 35)
        Me.close_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_img.TabIndex = 2
        Me.close_img.TabStop = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1203, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_img)
        Me.Controls.Add(Me.page_load)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.store_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.close_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents store_img As System.Windows.Forms.PictureBox
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents report_btn As System.Windows.Forms.Button
    Friend WithEvents sales_btn As System.Windows.Forms.Button
    Friend WithEvents purchase_btn As System.Windows.Forms.Button
    Friend WithEvents page_load As System.Windows.Forms.Panel
    Friend WithEvents close_img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_add_vendor As System.Windows.Forms.Button
    Friend WithEvents btn_add_cust As System.Windows.Forms.Button
End Class
