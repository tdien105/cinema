<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheLoai_Nhat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheLoai_Nhat))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvDS = New System.Windows.Forms.DataGridView()
        Me.MaTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenTheLoai = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCapNhat)
        Me.PanelControl1.Controls.Add(Me.dgvDS)
        Me.PanelControl1.Controls.Add(Me.btnXoa)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnThem)
        Me.PanelControl1.Controls.Add(Me.txtTenTheLoai)
        Me.PanelControl1.Location = New System.Drawing.Point(113, 204)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(714, 263)
        Me.PanelControl1.TabIndex = 2
        '
        'dgvDS
        '
        Me.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTheLoai, Me.TenTheLoai})
        Me.dgvDS.Location = New System.Drawing.Point(34, 96)
        Me.dgvDS.Name = "dgvDS"
        Me.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDS.Size = New System.Drawing.Size(646, 162)
        Me.dgvDS.TabIndex = 0
        '
        'MaTheLoai
        '
        Me.MaTheLoai.DataPropertyName = "ID"
        Me.MaTheLoai.HeaderText = "Thể loại"
        Me.MaTheLoai.Name = "MaTheLoai"
        Me.MaTheLoai.ReadOnly = True
        '
        'TenTheLoai
        '
        Me.TenTheLoai.DataPropertyName = "TenTheLoai"
        Me.TenTheLoai.HeaderText = "Tên thể loại"
        Me.TenTheLoai.Name = "TenTheLoai"
        Me.TenTheLoai.ReadOnly = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(493, 57)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(140, 23)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập Nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(306, 57)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(131, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xoá"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(107, 57)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(123, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(195, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Tên thể loại:"
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(279, 19)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(232, 20)
        Me.txtTenTheLoai.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(690, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(315, 184)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(309, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(370, 184)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 184)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmTheLoai_Nhat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 504)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmTheLoai_Nhat"
        Me.Text = "frmTheLoai_Nhat"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvDS As System.Windows.Forms.DataGridView
    Friend WithEvents MaTheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenTheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenTheLoai As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
