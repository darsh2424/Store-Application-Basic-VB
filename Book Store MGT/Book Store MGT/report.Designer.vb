<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_tbl = New System.Windows.Forms.ComboBox()
        Me.panel_sel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_col = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_val = New System.Windows.Forms.ComboBox()
        Me.cbx_ch = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.panel_show = New System.Windows.Forms.Panel()
        Me.panel_sel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_show.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Report :"
        '
        'cbx_tbl
        '
        Me.cbx_tbl.FormattingEnabled = True
        Me.cbx_tbl.Items.AddRange(New Object() {"Purchase", "Sales"})
        Me.cbx_tbl.Location = New System.Drawing.Point(495, 10)
        Me.cbx_tbl.Name = "cbx_tbl"
        Me.cbx_tbl.Size = New System.Drawing.Size(121, 21)
        Me.cbx_tbl.TabIndex = 1
        '
        'panel_sel
        '
        Me.panel_sel.Controls.Add(Me.Label4)
        Me.panel_sel.Controls.Add(Me.cbx_col)
        Me.panel_sel.Controls.Add(Me.Label3)
        Me.panel_sel.Controls.Add(Me.Label2)
        Me.panel_sel.Controls.Add(Me.cbx_val)
        Me.panel_sel.Controls.Add(Me.cbx_ch)
        Me.panel_sel.Location = New System.Drawing.Point(12, 51)
        Me.panel_sel.Name = "panel_sel"
        Me.panel_sel.Size = New System.Drawing.Size(945, 68)
        Me.panel_sel.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select Field:"
        '
        'cbx_col
        '
        Me.cbx_col.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_col.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_col.Enabled = False
        Me.cbx_col.FormattingEnabled = True
        Me.cbx_col.Location = New System.Drawing.Point(458, 23)
        Me.cbx_col.Name = "cbx_col"
        Me.cbx_col.Size = New System.Drawing.Size(166, 21)
        Me.cbx_col.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(659, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Your Choice:"
        '
        'cbx_val
        '
        Me.cbx_val.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_val.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_val.Enabled = False
        Me.cbx_val.FormattingEnabled = True
        Me.cbx_val.Location = New System.Drawing.Point(754, 24)
        Me.cbx_val.Name = "cbx_val"
        Me.cbx_val.Size = New System.Drawing.Size(166, 21)
        Me.cbx_val.TabIndex = 2
        '
        'cbx_ch
        '
        Me.cbx_ch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_ch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_ch.Enabled = False
        Me.cbx_ch.FormattingEnabled = True
        Me.cbx_ch.Location = New System.Drawing.Point(152, 23)
        Me.cbx_ch.Name = "cbx_ch"
        Me.cbx_ch.Size = New System.Drawing.Size(166, 21)
        Me.cbx_ch.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(20, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(900, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "From :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(318, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2023, 10, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(487, 12)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(113, 20)
        Me.DateTimePicker2.TabIndex = 10
        Me.DateTimePicker2.Value = New Date(2023, 10, 20, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(609, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'panel_show
        '
        Me.panel_show.Controls.Add(Me.DataGridView1)
        Me.panel_show.Controls.Add(Me.CheckBox1)
        Me.panel_show.Controls.Add(Me.DateTimePicker2)
        Me.panel_show.Controls.Add(Me.Label5)
        Me.panel_show.Controls.Add(Me.Label6)
        Me.panel_show.Controls.Add(Me.DateTimePicker1)
        Me.panel_show.Location = New System.Drawing.Point(12, 126)
        Me.panel_show.Name = "panel_show"
        Me.panel_show.Size = New System.Drawing.Size(945, 503)
        Me.panel_show.TabIndex = 12
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(970, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_show)
        Me.Controls.Add(Me.panel_sel)
        Me.Controls.Add(Me.cbx_tbl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "report"
        Me.ShowIcon = False
        Me.panel_sel.ResumeLayout(False)
        Me.panel_sel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_show.ResumeLayout(False)
        Me.panel_show.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_tbl As System.Windows.Forms.ComboBox
    Friend WithEvents panel_sel As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbx_val As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_ch As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbx_col As System.Windows.Forms.ComboBox
    Friend WithEvents panel_show As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
