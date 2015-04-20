<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLLichChieu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvSuatChieu = New System.Windows.Forms.DataGridView()
        Me.MaSuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaRap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuatChieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayChieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenRap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRapPhim = New System.Windows.Forms.ComboBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpNgayChieu = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPhongChieu = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDSPhimSearch = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvDSPhim = New System.Windows.Forms.DataGridView()
        Me.TenPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinhAnh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNPH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNPH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThongTinPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTieuChi = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvSuatChieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvDSPhim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(674, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 260)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.dgvSuatChieu)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 291)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(668, 333)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Danh Sách Suất Chiếu"
        '
        'dgvSuatChieu
        '
        Me.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuatChieu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSuat, Me.MaPhong, Me.MaRap, Me.SuatChieu, Me.NgayChieu, Me.TenPhong, Me.TenRap, Me.TenLoaiPhong})
        Me.dgvSuatChieu.Location = New System.Drawing.Point(5, 32)
        Me.dgvSuatChieu.Name = "dgvSuatChieu"
        Me.dgvSuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuatChieu.Size = New System.Drawing.Size(658, 269)
        Me.dgvSuatChieu.TabIndex = 1
        '
        'MaSuat
        '
        Me.MaSuat.DataPropertyName = "MaSuat"
        Me.MaSuat.HeaderText = "Mã Suất"
        Me.MaSuat.Name = "MaSuat"
        Me.MaSuat.ReadOnly = True
        Me.MaSuat.Visible = False
        '
        'MaPhong
        '
        Me.MaPhong.DataPropertyName = "MaPhong"
        Me.MaPhong.HeaderText = "Mã phòng"
        Me.MaPhong.Name = "MaPhong"
        Me.MaPhong.ReadOnly = True
        Me.MaPhong.Visible = False
        '
        'MaRap
        '
        Me.MaRap.DataPropertyName = "MaRap"
        Me.MaRap.HeaderText = "Mã Rạp"
        Me.MaRap.Name = "MaRap"
        Me.MaRap.ReadOnly = True
        Me.MaRap.Visible = False
        '
        'SuatChieu
        '
        Me.SuatChieu.DataPropertyName = "SuatChieu"
        Me.SuatChieu.HeaderText = "Suất chiếu"
        Me.SuatChieu.Name = "SuatChieu"
        Me.SuatChieu.ReadOnly = True
        '
        'NgayChieu
        '
        Me.NgayChieu.DataPropertyName = "NgayChieu"
        Me.NgayChieu.HeaderText = "Ngày chiếu"
        Me.NgayChieu.Name = "NgayChieu"
        Me.NgayChieu.ReadOnly = True
        '
        'TenPhong
        '
        Me.TenPhong.DataPropertyName = "TenPhong"
        Me.TenPhong.HeaderText = "Tên phòng"
        Me.TenPhong.Name = "TenPhong"
        Me.TenPhong.ReadOnly = True
        '
        'TenRap
        '
        Me.TenRap.DataPropertyName = "TenRap"
        Me.TenRap.HeaderText = "Tên rạp"
        Me.TenRap.Name = "TenRap"
        Me.TenRap.ReadOnly = True
        '
        'TenLoaiPhong
        '
        Me.TenLoaiPhong.DataPropertyName = "TenLoaiPhong"
        Me.TenLoaiPhong.HeaderText = "Loại phòng"
        Me.TenLoaiPhong.Name = "TenLoaiPhong"
        Me.TenLoaiPhong.ReadOnly = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.cboRapPhim)
        Me.GroupControl3.Controls.Add(Me.dtpFrom)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.dtpNgayChieu)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.cboPhongChieu)
        Me.GroupControl3.Controls.Add(Me.btnXoa)
        Me.GroupControl3.Controls.Add(Me.btnCapNhat)
        Me.GroupControl3.Controls.Add(Me.btnThem)
        Me.GroupControl3.Location = New System.Drawing.Point(674, 291)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(300, 333)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Nhập liệu"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 73
        Me.LabelControl5.Text = "Chọn rạp:"
        '
        'cboRapPhim
        '
        Me.cboRapPhim.FormattingEnabled = True
        Me.cboRapPhim.Location = New System.Drawing.Point(108, 29)
        Me.cboRapPhim.Name = "cboRapPhim"
        Me.cboRapPhim.Size = New System.Drawing.Size(164, 21)
        Me.cboRapPhim.TabIndex = 72
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = " "
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(108, 131)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowUpDown = True
        Me.dtpFrom.Size = New System.Drawing.Size(164, 20)
        Me.dtpFrom.TabIndex = 68
        Me.dtpFrom.Tag = "0"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Ngày chiếu:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 137)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Suất chiếu:"
        '
        'dtpNgayChieu
        '
        Me.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayChieu.Location = New System.Drawing.Point(108, 94)
        Me.dtpNgayChieu.Name = "dtpNgayChieu"
        Me.dtpNgayChieu.Size = New System.Drawing.Size(164, 20)
        Me.dtpNgayChieu.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Chọn phòng:"
        '
        'cboPhongChieu
        '
        Me.cboPhongChieu.FormattingEnabled = True
        Me.cboPhongChieu.Location = New System.Drawing.Point(107, 63)
        Me.cboPhongChieu.Name = "cboPhongChieu"
        Me.cboPhongChieu.Size = New System.Drawing.Size(164, 21)
        Me.cboPhongChieu.TabIndex = 1
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(111, 215)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(201, 215)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(16, 215)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        '
        'txtDSPhimSearch
        '
        Me.txtDSPhimSearch.Location = New System.Drawing.Point(474, 33)
        Me.txtDSPhimSearch.Name = "txtDSPhimSearch"
        Me.txtDSPhimSearch.Size = New System.Drawing.Size(189, 20)
        Me.txtDSPhimSearch.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cboTieuChi)
        Me.GroupControl1.Controls.Add(Me.txtDSPhimSearch)
        Me.GroupControl1.Controls.Add(Me.dgvDSPhim)
        Me.GroupControl1.Location = New System.Drawing.Point(0, -5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(673, 270)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh Sách Phim"
        '
        'dgvDSPhim
        '
        Me.dgvDSPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDSPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenPhim, Me.HinhAnh, Me.MaNPH, Me.MaPhim, Me.MaTheLoai, Me.TheLoai, Me.TenNPH, Me.ThongTinPhim})
        Me.dgvDSPhim.Location = New System.Drawing.Point(5, 59)
        Me.dgvDSPhim.Name = "dgvDSPhim"
        Me.dgvDSPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSPhim.Size = New System.Drawing.Size(658, 206)
        Me.dgvDSPhim.TabIndex = 0
        '
        'TenPhim
        '
        Me.TenPhim.DataPropertyName = "TenPhim"
        Me.TenPhim.HeaderText = "Tên phim"
        Me.TenPhim.Name = "TenPhim"
        Me.TenPhim.ReadOnly = True
        '
        'HinhAnh
        '
        Me.HinhAnh.DataPropertyName = "HinhAnh"
        Me.HinhAnh.HeaderText = "Hình ảnh"
        Me.HinhAnh.Name = "HinhAnh"
        Me.HinhAnh.Visible = False
        '
        'MaNPH
        '
        Me.MaNPH.DataPropertyName = "MaNhaPhatHanh"
        Me.MaNPH.HeaderText = "Mã nhà phát hành"
        Me.MaNPH.Name = "MaNPH"
        Me.MaNPH.Visible = False
        '
        'MaPhim
        '
        Me.MaPhim.DataPropertyName = "MaPhim"
        Me.MaPhim.HeaderText = "Mã phim"
        Me.MaPhim.Name = "MaPhim"
        Me.MaPhim.ReadOnly = True
        Me.MaPhim.Visible = False
        '
        'MaTheLoai
        '
        Me.MaTheLoai.DataPropertyName = "Id"
        Me.MaTheLoai.HeaderText = "Mã thể loại"
        Me.MaTheLoai.Name = "MaTheLoai"
        Me.MaTheLoai.ReadOnly = True
        Me.MaTheLoai.Visible = False
        '
        'TheLoai
        '
        Me.TheLoai.DataPropertyName = "TenTheLoai"
        Me.TheLoai.HeaderText = "Thể loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.ReadOnly = True
        '
        'TenNPH
        '
        Me.TenNPH.DataPropertyName = "TenNPH"
        Me.TenNPH.HeaderText = "Nhà phát hành"
        Me.TenNPH.Name = "TenNPH"
        Me.TenNPH.ReadOnly = True
        '
        'ThongTinPhim
        '
        Me.ThongTinPhim.DataPropertyName = "ThongTinPhim"
        Me.ThongTinPhim.HeaderText = "Thông tin phim"
        Me.ThongTinPhim.Name = "ThongTinPhim"
        Me.ThongTinPhim.ReadOnly = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(196, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl4.TabIndex = 75
        Me.LabelControl4.Text = "Search theo:"
        '
        'cboTieuChi
        '
        Me.cboTieuChi.FormattingEnabled = True
        Me.cboTieuChi.Location = New System.Drawing.Point(288, 33)
        Me.cboTieuChi.Name = "cboTieuChi"
        Me.cboTieuChi.Size = New System.Drawing.Size(164, 21)
        Me.cboTieuChi.TabIndex = 74
        '
        'frmQLLichChieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 625)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmQLLichChieu"
        Me.Text = "frmQLLichChieu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvSuatChieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dgvDSPhim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvSuatChieu As System.Windows.Forms.DataGridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPhongChieu As System.Windows.Forms.ComboBox
    Friend WithEvents txtDSPhimSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvDSPhim As System.Windows.Forms.DataGridView
    Friend WithEvents TenPhim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinhAnh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNPH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaPhim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaTheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNPH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThongTinPhim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpNgayChieu As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRapPhim As System.Windows.Forms.ComboBox
    Friend WithEvents MaSuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaRap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuatChieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayChieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenRap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTieuChi As System.Windows.Forms.ComboBox
End Class
