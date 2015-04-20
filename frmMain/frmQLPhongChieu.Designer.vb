<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhongChieu
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnThemGhe = New DevExpress.XtraEditors.SimpleButton()
        Me.cboloadrap = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBaoHu = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvDSPhongChieu = New System.Windows.Forms.DataGridView()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaRap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoGhe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoGheVip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cboLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.cboRap = New System.Windows.Forms.ComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvDSPhongChieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnThemGhe)
        Me.GroupControl1.Controls.Add(Me.cboloadrap)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btnBaoHu)
        Me.GroupControl1.Controls.Add(Me.dgvDSPhongChieu)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(743, 304)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh sách phòng chiếu"
        '
        'btnThemGhe
        '
        Me.btnThemGhe.Location = New System.Drawing.Point(575, 25)
        Me.btnThemGhe.Name = "btnThemGhe"
        Me.btnThemGhe.Size = New System.Drawing.Size(75, 23)
        Me.btnThemGhe.TabIndex = 11
        Me.btnThemGhe.Text = "Thêm ghế"
        '
        'cboloadrap
        '
        Me.cboloadrap.FormattingEnabled = True
        Me.cboloadrap.Location = New System.Drawing.Point(191, 23)
        Me.cboloadrap.Name = "cboloadrap"
        Me.cboloadrap.Size = New System.Drawing.Size(121, 21)
        Me.cboloadrap.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(103, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Chọn rạp:"
        '
        'btnBaoHu
        '
        Me.btnBaoHu.Location = New System.Drawing.Point(656, 24)
        Me.btnBaoHu.Name = "btnBaoHu"
        Me.btnBaoHu.Size = New System.Drawing.Size(75, 23)
        Me.btnBaoHu.TabIndex = 7
        Me.btnBaoHu.Text = "Báo Hư"
        '
        'dgvDSPhongChieu
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        Me.dgvDSPhongChieu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDSPhongChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDSPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhongChieu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhong, Me.TenPhong, Me.MaLoaiPhong, Me.MaRap, Me.TenLoaiPhong, Me.SoGhe, Me.SoGheVip, Me.MaHang, Me.TinhTrang})
        Me.dgvDSPhongChieu.Location = New System.Drawing.Point(11, 53)
        Me.dgvDSPhongChieu.Name = "dgvDSPhongChieu"
        Me.dgvDSPhongChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSPhongChieu.Size = New System.Drawing.Size(720, 246)
        Me.dgvDSPhongChieu.TabIndex = 0
        '
        'MaPhong
        '
        Me.MaPhong.DataPropertyName = "MaPhong"
        Me.MaPhong.HeaderText = "Mã phòng"
        Me.MaPhong.Name = "MaPhong"
        Me.MaPhong.ReadOnly = True
        '
        'TenPhong
        '
        Me.TenPhong.DataPropertyName = "TenPhong"
        Me.TenPhong.HeaderText = "Tên phòng"
        Me.TenPhong.Name = "TenPhong"
        Me.TenPhong.ReadOnly = True
        '
        'MaLoaiPhong
        '
        Me.MaLoaiPhong.DataPropertyName = "MaLoaiPhong"
        Me.MaLoaiPhong.HeaderText = "Mã loại phòng"
        Me.MaLoaiPhong.Name = "MaLoaiPhong"
        Me.MaLoaiPhong.ReadOnly = True
        Me.MaLoaiPhong.Visible = False
        '
        'MaRap
        '
        Me.MaRap.DataPropertyName = "MaRap"
        Me.MaRap.HeaderText = "Mã rạp"
        Me.MaRap.Name = "MaRap"
        Me.MaRap.ReadOnly = True
        Me.MaRap.Visible = False
        '
        'TenLoaiPhong
        '
        Me.TenLoaiPhong.DataPropertyName = "TenLoaiPhong"
        Me.TenLoaiPhong.HeaderText = "Loại phòng"
        Me.TenLoaiPhong.Name = "TenLoaiPhong"
        Me.TenLoaiPhong.ReadOnly = True
        '
        'SoGhe
        '
        Me.SoGhe.DataPropertyName = "SOGHE"
        Me.SoGhe.HeaderText = "Số ghế"
        Me.SoGhe.Name = "SoGhe"
        Me.SoGhe.ReadOnly = True
        '
        'SoGheVip
        '
        Me.SoGheVip.DataPropertyName = "SOGHEVIP"
        Me.SoGheVip.HeaderText = "Số ghế VIP"
        Me.SoGheVip.Name = "SoGheVip"
        Me.SoGheVip.ReadOnly = True
        '
        'MaHang
        '
        Me.MaHang.DataPropertyName = "MaHang"
        Me.MaHang.HeaderText = "Mã hàng"
        Me.MaHang.Name = "MaHang"
        Me.MaHang.ReadOnly = True
        Me.MaHang.Visible = False
        '
        'TinhTrang
        '
        Me.TinhTrang.DataPropertyName = "TinhTrang"
        Me.TinhTrang.HeaderText = "Tình trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.ReadOnly = True
        Me.TinhTrang.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cboLoaiPhong)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.btnCapNhat)
        Me.GroupControl2.Controls.Add(Me.btnXoa)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.btnThem)
        Me.GroupControl2.Controls.Add(Me.txtTenPhong)
        Me.GroupControl2.Controls.Add(Me.cboRap)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 322)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(743, 272)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Nhập liệu"
        '
        'cboLoaiPhong
        '
        Me.cboLoaiPhong.FormattingEnabled = True
        Me.cboLoaiPhong.Location = New System.Drawing.Point(98, 56)
        Me.cboLoaiPhong.Name = "cboLoaiPhong"
        Me.cboLoaiPhong.Size = New System.Drawing.Size(191, 21)
        Me.cboLoaiPhong.TabIndex = 12
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Loại phòng:"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(236, 236)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(53, 23)
        Me.btnCapNhat.TabIndex = 8
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(166, 236)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(53, 23)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xoá"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Tên phòng:"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(98, 236)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(53, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Location = New System.Drawing.Point(98, 89)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(191, 20)
        Me.txtTenPhong.TabIndex = 2
        '
        'cboRap
        '
        Me.cboRap.FormattingEnabled = True
        Me.cboRap.Location = New System.Drawing.Point(98, 24)
        Me.cboRap.Name = "cboRap"
        Me.cboRap.Size = New System.Drawing.Size(191, 21)
        Me.cboRap.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Chọn rạp:"
        '
        'frmQLPhongChieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 593)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmQLPhongChieu"
        Me.Text = "frmQLPhongChieu"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dgvDSPhongChieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvDSPhongChieu As System.Windows.Forms.DataGridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents cboRap As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBaoHu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboloadrap As System.Windows.Forms.ComboBox
    Friend WithEvents cboLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaRap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoGhe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoGheVip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnThemGhe As DevExpress.XtraEditors.SimpleButton
End Class
