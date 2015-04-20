<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheLoai
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvDS = New System.Windows.Forms.DataGridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenTheLoai = New System.Windows.Forms.TextBox()
        Me.MaTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dgvDS)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(349, 288)
        Me.PanelControl1.TabIndex = 0
        '
        'dgvDS
        '
        Me.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTheLoai, Me.TenTheLoai})
        Me.dgvDS.Location = New System.Drawing.Point(5, 5)
        Me.dgvDS.Name = "dgvDS"
        Me.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDS.Size = New System.Drawing.Size(338, 278)
        Me.dgvDS.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnCapNhat)
        Me.GroupControl1.Controls.Add(Me.btnXoa)
        Me.GroupControl1.Controls.Add(Me.btnThem)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTenTheLoai)
        Me.GroupControl1.Location = New System.Drawing.Point(349, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(243, 288)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Nhập dữ liệu"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(6, 179)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(232, 23)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập Nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(5, 133)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(232, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xoá"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(6, 86)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(232, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Tên thể loại:"
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(6, 51)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(232, 20)
        Me.txtTenTheLoai.TabIndex = 1
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
        'frmTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 288)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmTheLoai"
        Me.Text = "frmTheLoai"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgvDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvDS As System.Windows.Forms.DataGridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenTheLoai As System.Windows.Forms.TextBox
    Friend WithEvents MaTheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenTheLoai As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
