﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewQLLichChieu_Cuong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewQLLichChieu_Cuong))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaSuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaRap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuatChieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayChieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenRap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPhongChieu = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvSuatChieu = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cboRapPhim = New System.Windows.Forms.ComboBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTieuChi = New System.Windows.Forms.ComboBox()
        Me.txtDSPhimSearch = New System.Windows.Forms.TextBox()
        Me.dgvDSPhim = New System.Windows.Forms.DataGridView()
        Me.TenPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinhAnh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNPH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNPH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThongTinPhim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpNgayChieu = New System.Windows.Forms.DateTimePicker()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSuatChieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvDSPhim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(862, 136)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 444)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 165)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 74
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 173)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Tên phim:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Chọn phòng chiếu:"
        '
        'cboPhongChieu
        '
        Me.cboPhongChieu.FormattingEnabled = True
        Me.cboPhongChieu.Location = New System.Drawing.Point(107, 63)
        Me.cboPhongChieu.Name = "cboPhongChieu"
        Me.cboPhongChieu.Size = New System.Drawing.Size(107, 21)
        Me.cboPhongChieu.TabIndex = 1
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(90, 208)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(48, 30)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(164, 208)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(54, 30)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(16, 208)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(48, 30)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        '
        'dgvSuatChieu
        '
        Me.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuatChieu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSuat, Me.MaPhong, Me.MaRap, Me.SuatChieu, Me.NgayChieu, Me.TenPhong, Me.TenRap, Me.TenLoaiPhong})
        Me.dgvSuatChieu.Location = New System.Drawing.Point(10, 32)
        Me.dgvSuatChieu.Name = "dgvSuatChieu"
        Me.dgvSuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuatChieu.Size = New System.Drawing.Size(538, 155)
        Me.dgvSuatChieu.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(16, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(243, 187)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.dgvSuatChieu)
        Me.GroupControl2.Location = New System.Drawing.Point(281, 388)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(558, 192)
        Me.GroupControl2.TabIndex = 11
        Me.GroupControl2.Text = "Danh Sách Suất Chiếu"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 73
        Me.LabelControl5.Text = "Chọn rạp:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1022, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'cboRapPhim
        '
        Me.cboRapPhim.FormattingEnabled = True
        Me.cboRapPhim.Items.AddRange(New Object() {"CGV Hùng Vương"})
        Me.cboRapPhim.Location = New System.Drawing.Point(108, 29)
        Me.cboRapPhim.Name = "cboRapPhim"
        Me.cboRapPhim.Size = New System.Drawing.Size(107, 21)
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
        Me.dtpFrom.Size = New System.Drawing.Size(107, 20)
        Me.dtpFrom.TabIndex = 68
        Me.dtpFrom.Tag = "0"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 137)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Suất chiếu:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cboTieuChi)
        Me.GroupControl1.Controls.Add(Me.txtDSPhimSearch)
        Me.GroupControl1.Controls.Add(Me.dgvDSPhim)
        Me.GroupControl1.Location = New System.Drawing.Point(281, 134)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(558, 248)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "Danh Sách Phim"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl4.TabIndex = 75
        Me.LabelControl4.Text = "Search theo:"
        '
        'cboTieuChi
        '
        Me.cboTieuChi.FormattingEnabled = True
        Me.cboTieuChi.Location = New System.Drawing.Point(133, 43)
        Me.cboTieuChi.Name = "cboTieuChi"
        Me.cboTieuChi.Size = New System.Drawing.Size(107, 21)
        Me.cboTieuChi.TabIndex = 74
        '
        'txtDSPhimSearch
        '
        Me.txtDSPhimSearch.Location = New System.Drawing.Point(319, 43)
        Me.txtDSPhimSearch.Name = "txtDSPhimSearch"
        Me.txtDSPhimSearch.Size = New System.Drawing.Size(132, 20)
        Me.txtDSPhimSearch.TabIndex = 2
        '
        'dgvDSPhim
        '
        Me.dgvDSPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDSPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenPhim, Me.HinhAnh, Me.MaNPH, Me.MaPhim, Me.MaTheLoai, Me.TheLoai, Me.TenNPH, Me.ThongTinPhim})
        Me.dgvDSPhim.Location = New System.Drawing.Point(10, 77)
        Me.dgvDSPhim.Name = "dgvDSPhim"
        Me.dgvDSPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSPhim.Size = New System.Drawing.Size(538, 143)
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
        'dtpNgayChieu
        '
        Me.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayChieu.Location = New System.Drawing.Point(108, 94)
        Me.dtpNgayChieu.Name = "dtpNgayChieu"
        Me.dtpNgayChieu.Size = New System.Drawing.Size(107, 20)
        Me.dtpNgayChieu.TabIndex = 7
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextBox1)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.cboRapPhim)
        Me.GroupControl3.Controls.Add(Me.dtpFrom)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.dtpNgayChieu)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.cboPhongChieu)
        Me.GroupControl3.Controls.Add(Me.btnXoa)
        Me.GroupControl3.Controls.Add(Me.btnCapNhat)
        Me.GroupControl3.Controls.Add(Me.btnThem)
        Me.GroupControl3.Location = New System.Drawing.Point(16, 134)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(243, 248)
        Me.GroupControl3.TabIndex = 12
        Me.GroupControl3.Text = "Nhập liệu"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Ngày chiếu:"
        '
        'NewQLLichChieu_Cuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 592)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Name = "NewQLLichChieu_Cuong"
        Me.Text = "NewQLLichChieu_Cuong"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSuatChieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dgvDSPhim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaSuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaRap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuatChieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayChieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenRap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPhongChieu As System.Windows.Forms.ComboBox
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvSuatChieu As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cboRapPhim As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTieuChi As System.Windows.Forms.ComboBox
    Friend WithEvents txtDSPhimSearch As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
