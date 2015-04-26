<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLPhim))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsotien = New DevExpress.XtraEditors.SpinEdit()
        Me.txtthoiluong = New DevExpress.XtraEditors.SpinEdit()
        Me.btnthemNPH = New DevExpress.XtraEditors.SimpleButton()
        Me.txtdaodien = New System.Windows.Forms.TextBox()
        Me.datengaynhap = New DevExpress.XtraEditors.DateEdit()
        Me.cboNPH = New System.Windows.Forms.ComboBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnthemTL = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTheLoai = New System.Windows.Forms.ComboBox()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdotuoi = New System.Windows.Forms.TextBox()
        Me.txtTenPhim = New System.Windows.Forms.TextBox()
        Me.btntrailer = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvDS = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.btnposter = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttomtat = New System.Windows.Forms.TextBox()
        Me.group = New System.Windows.Forms.GroupBox()
        Me.video = New AxWMPLib.AxWindowsMediaPlayer()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtsotien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtthoiluong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datengaynhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datengaynhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.group.SuspendLayout()
        CType(Me.video, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsotien)
        Me.GroupBox1.Controls.Add(Me.txtthoiluong)
        Me.GroupBox1.Controls.Add(Me.btnthemNPH)
        Me.GroupBox1.Controls.Add(Me.txtdaodien)
        Me.GroupBox1.Controls.Add(Me.datengaynhap)
        Me.GroupBox1.Controls.Add(Me.cboNPH)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.btnthemTL)
        Me.GroupBox1.Controls.Add(Me.btnLamMoi)
        Me.GroupBox1.Controls.Add(Me.cboTheLoai)
        Me.GroupBox1.Controls.Add(Me.btnCapNhat)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtdotuoi)
        Me.GroupBox1.Controls.Add(Me.txtTenPhim)
        Me.GroupBox1.Location = New System.Drawing.Point(253, 430)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 282)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP PHIM"
        '
        'txtsotien
        '
        Me.txtsotien.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsotien.Location = New System.Drawing.Point(101, 206)
        Me.txtsotien.Name = "txtsotien"
        Me.txtsotien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtsotien.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtsotien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtsotien.Size = New System.Drawing.Size(232, 20)
        Me.txtsotien.TabIndex = 22
        '
        'txtthoiluong
        '
        Me.txtthoiluong.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtthoiluong.Location = New System.Drawing.Point(101, 154)
        Me.txtthoiluong.Name = "txtthoiluong"
        Me.txtthoiluong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtthoiluong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtthoiluong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtthoiluong.Size = New System.Drawing.Size(232, 20)
        Me.txtthoiluong.TabIndex = 21
        '
        'btnthemNPH
        '
        Me.btnthemNPH.Image = CType(resources.GetObject("btnthemNPH.Image"), System.Drawing.Image)
        Me.btnthemNPH.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnthemNPH.Location = New System.Drawing.Point(302, 98)
        Me.btnthemNPH.Name = "btnthemNPH"
        Me.btnthemNPH.Size = New System.Drawing.Size(33, 23)
        Me.btnthemNPH.TabIndex = 25
        '
        'txtdaodien
        '
        Me.txtdaodien.Location = New System.Drawing.Point(101, 128)
        Me.txtdaodien.Name = "txtdaodien"
        Me.txtdaodien.Size = New System.Drawing.Size(232, 20)
        Me.txtdaodien.TabIndex = 20
        '
        'datengaynhap
        '
        Me.datengaynhap.EditValue = Nothing
        Me.datengaynhap.Location = New System.Drawing.Point(101, 44)
        Me.datengaynhap.Name = "datengaynhap"
        Me.datengaynhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.datengaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.datengaynhap.Size = New System.Drawing.Size(232, 20)
        Me.datengaynhap.TabIndex = 19
        '
        'cboNPH
        '
        Me.cboNPH.FormattingEnabled = True
        Me.cboNPH.Location = New System.Drawing.Point(101, 100)
        Me.cboNPH.Name = "cboNPH"
        Me.cboNPH.Size = New System.Drawing.Size(154, 21)
        Me.cboNPH.TabIndex = 24
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Nhà PH"
        '
        'btnthemTL
        '
        Me.btnthemTL.Image = CType(resources.GetObject("btnthemTL.Image"), System.Drawing.Image)
        Me.btnthemTL.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnthemTL.Location = New System.Drawing.Point(301, 68)
        Me.btnthemTL.Name = "btnthemTL"
        Me.btnthemTL.Size = New System.Drawing.Size(33, 23)
        Me.btnthemTL.TabIndex = 16
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Location = New System.Drawing.Point(261, 243)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 14
        Me.btnLamMoi.Text = "Làm mới"
        '
        'cboTheLoai
        '
        Me.cboTheLoai.FormattingEnabled = True
        Me.cboTheLoai.Location = New System.Drawing.Point(101, 70)
        Me.cboTheLoai.Name = "cboTheLoai"
        Me.cboTheLoai.Size = New System.Drawing.Size(154, 21)
        Me.cboTheLoai.TabIndex = 12
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(177, 243)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(93, 243)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xóa"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(9, 243)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Thể loại:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 128)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Đạo diễn:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Ngày nhập:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 209)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "Số tiền:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 183)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Độ tuổi qui định:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 157)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Thời lượng:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tên phim:"
        '
        'txtdotuoi
        '
        Me.txtdotuoi.Location = New System.Drawing.Point(101, 179)
        Me.txtdotuoi.Name = "txtdotuoi"
        Me.txtdotuoi.Size = New System.Drawing.Size(232, 20)
        Me.txtdotuoi.TabIndex = 0
        '
        'txtTenPhim
        '
        Me.txtTenPhim.Location = New System.Drawing.Point(101, 18)
        Me.txtTenPhim.Name = "txtTenPhim"
        Me.txtTenPhim.Size = New System.Drawing.Size(232, 20)
        Me.txtTenPhim.TabIndex = 0
        '
        'btntrailer
        '
        Me.btntrailer.Location = New System.Drawing.Point(937, 401)
        Me.btntrailer.Name = "btntrailer"
        Me.btntrailer.Size = New System.Drawing.Size(75, 23)
        Me.btntrailer.TabIndex = 15
        Me.btntrailer.Text = "..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1000, 123)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'dgvDS
        '
        Me.dgvDS.AllowUserToAddRows = False
        Me.dgvDS.AllowUserToDeleteRows = False
        Me.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDS.Location = New System.Drawing.Point(12, 21)
        Me.dgvDS.Name = "dgvDS"
        Me.dgvDS.ReadOnly = True
        Me.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDS.Size = New System.Drawing.Size(731, 190)
        Me.dgvDS.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDS)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 225)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CÁC PHIM ĐÃ NHẬP"
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnsearch.Location = New System.Drawing.Point(439, 396)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(30, 20)
        Me.btnsearch.TabIndex = 12
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(253, 396)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(181, 20)
        Me.txtTimKiem.TabIndex = 3
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(14, 152)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(220, 228)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 16
        Me.pic.TabStop = False
        '
        'btnposter
        '
        Me.btnposter.Location = New System.Drawing.Point(58, 395)
        Me.btnposter.Name = "btnposter"
        Me.btnposter.Size = New System.Drawing.Size(75, 23)
        Me.btnposter.TabIndex = 15
        Me.btnposter.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Poster:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttomtat)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 430)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 247)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tóm tắt:"
        '
        'txttomtat
        '
        Me.txttomtat.Location = New System.Drawing.Point(7, 16)
        Me.txttomtat.Multiline = True
        Me.txttomtat.Name = "txttomtat"
        Me.txttomtat.Size = New System.Drawing.Size(205, 225)
        Me.txttomtat.TabIndex = 0
        '
        'group
        '
        Me.group.Controls.Add(Me.video)
        Me.group.Location = New System.Drawing.Point(649, 430)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(363, 282)
        Me.group.TabIndex = 20
        Me.group.TabStop = False
        Me.group.Text = "Trailer"
        '
        'video
        '
        Me.video.Dock = System.Windows.Forms.DockStyle.Fill
        Me.video.Enabled = True
        Me.video.Location = New System.Drawing.Point(3, 16)
        Me.video.Name = "video"
        Me.video.OcxState = CType(resources.GetObject("video.OcxState"), System.Windows.Forms.AxHost.State)
        Me.video.Size = New System.Drawing.Size(357, 263)
        Me.video.TabIndex = 0
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'frmQLPhim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 732)
        Me.Controls.Add(Me.btntrailer)
        Me.Controls.Add(Me.group)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.btnposter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmQLPhim"
        Me.Text = "frmQLPhim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtsotien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtthoiluong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datengaynhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datengaynhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.group.ResumeLayout(False)
        CType(Me.video, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthemTL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btntrailer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLamMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTheLoai As System.Windows.Forms.ComboBox
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenPhim As System.Windows.Forms.TextBox
    Friend WithEvents dgvDS As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents datengaynhap As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents btnposter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents group As System.Windows.Forms.GroupBox
    Friend WithEvents video As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtdaodien As System.Windows.Forms.TextBox
    Friend WithEvents txtsotien As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtthoiluong As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtdotuoi As System.Windows.Forms.TextBox
    Friend WithEvents btnthemNPH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboNPH As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txttomtat As System.Windows.Forms.TextBox
End Class
