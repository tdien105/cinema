<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemGhe
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
        Me.ckbVIP = New System.Windows.Forms.CheckBox()
        Me.txtSoGhe = New System.Windows.Forms.TextBox()
        Me.txtMaHang = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbophong = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ckbVIP
        '
        Me.ckbVIP.AutoSize = True
        Me.ckbVIP.Location = New System.Drawing.Point(324, 68)
        Me.ckbVIP.Name = "ckbVIP"
        Me.ckbVIP.Size = New System.Drawing.Size(43, 17)
        Me.ckbVIP.TabIndex = 15
        Me.ckbVIP.Text = "VIP"
        Me.ckbVIP.UseVisualStyleBackColor = True
        '
        'txtSoGhe
        '
        Me.txtSoGhe.Location = New System.Drawing.Point(116, 94)
        Me.txtSoGhe.Name = "txtSoGhe"
        Me.txtSoGhe.Size = New System.Drawing.Size(191, 20)
        Me.txtSoGhe.TabIndex = 16
        '
        'txtMaHang
        '
        Me.txtMaHang.Location = New System.Drawing.Point(116, 65)
        Me.txtMaHang.Name = "txtMaHang"
        Me.txtMaHang.Size = New System.Drawing.Size(191, 20)
        Me.txtMaHang.TabIndex = 14
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(42, 101)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Số ghế:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 69)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Mã hàng:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Phòng chiếu"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(116, 139)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 21
        Me.btnThem.Text = "Button1"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(219, 139)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Button2"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbophong
        '
        Me.cbophong.FormattingEnabled = True
        Me.cbophong.Location = New System.Drawing.Point(116, 16)
        Me.cbophong.Name = "cbophong"
        Me.cbophong.Size = New System.Drawing.Size(121, 21)
        Me.cbophong.TabIndex = 23
        '
        'frmThemGhe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 174)
        Me.Controls.Add(Me.cbophong)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ckbVIP)
        Me.Controls.Add(Me.txtSoGhe)
        Me.Controls.Add(Me.txtMaHang)
        Me.Name = "frmThemGhe"
        Me.Text = "frmThemGhe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckbVIP As System.Windows.Forms.CheckBox
    Friend WithEvents txtSoGhe As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHang As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cbophong As System.Windows.Forms.ComboBox
End Class
