<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookVe
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
        Me.cbosuatchieu = New System.Windows.Forms.ComboBox()
        Me.cbochonphong = New System.Windows.Forms.ComboBox()
        Me.cbophim = New System.Windows.Forms.ComboBox()
        Me.cborap = New System.Windows.Forms.ComboBox()
        Me.btnhienthi = New DevExpress.XtraEditors.SimpleButton()
        Me.dchonngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnbook = New DevExpress.XtraEditors.SimpleButton()
        Me.pnMain = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dchonngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dchonngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelControl1.Controls.Add(Me.cbosuatchieu)
        Me.PanelControl1.Controls.Add(Me.cbochonphong)
        Me.PanelControl1.Controls.Add(Me.cbophim)
        Me.PanelControl1.Controls.Add(Me.cborap)
        Me.PanelControl1.Controls.Add(Me.btnhienthi)
        Me.PanelControl1.Controls.Add(Me.dchonngay)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
<<<<<<< HEAD
        Me.PanelControl1.Controls.Add(Me.txtsove)
        Me.PanelControl1.Location = New System.Drawing.Point(23, 30)
=======
        Me.PanelControl1.Location = New System.Drawing.Point(1, 2)
>>>>>>> 42dd87338b8314a5589385c726e9da54e8400cf6
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(178, 362)
        Me.PanelControl1.TabIndex = 0
        '
        'cbosuatchieu
        '
        Me.cbosuatchieu.FormattingEnabled = True
        Me.cbosuatchieu.Location = New System.Drawing.Point(15, 236)
        Me.cbosuatchieu.Name = "cbosuatchieu"
        Me.cbosuatchieu.Size = New System.Drawing.Size(146, 21)
        Me.cbosuatchieu.TabIndex = 18
        '
        'cbochonphong
        '
        Me.cbochonphong.FormattingEnabled = True
        Me.cbochonphong.Location = New System.Drawing.Point(15, 185)
        Me.cbochonphong.Name = "cbochonphong"
        Me.cbochonphong.Size = New System.Drawing.Size(146, 21)
        Me.cbochonphong.TabIndex = 17
        '
        'cbophim
        '
        Me.cbophim.FormattingEnabled = True
        Me.cbophim.Location = New System.Drawing.Point(15, 134)
        Me.cbophim.Name = "cbophim"
        Me.cbophim.Size = New System.Drawing.Size(146, 21)
        Me.cbophim.TabIndex = 16
        '
        'cborap
        '
        Me.cborap.FormattingEnabled = True
        Me.cborap.Location = New System.Drawing.Point(15, 33)
        Me.cborap.Name = "cborap"
        Me.cborap.Size = New System.Drawing.Size(146, 21)
        Me.cborap.TabIndex = 15
        '
        'btnhienthi
        '
        Me.btnhienthi.Location = New System.Drawing.Point(41, 330)
        Me.btnhienthi.Name = "btnhienthi"
        Me.btnhienthi.Size = New System.Drawing.Size(75, 23)
        Me.btnhienthi.TabIndex = 14
        Me.btnhienthi.Text = "Submit"
        '
        'dchonngay
        '
        Me.dchonngay.EditValue = Nothing
        Me.dchonngay.Location = New System.Drawing.Point(15, 91)
        Me.dchonngay.Name = "dchonngay"
        Me.dchonngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dchonngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dchonngay.Size = New System.Drawing.Size(146, 20)
        Me.dchonngay.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Chọn phim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Suất chiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Chọn loại phòng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chọn ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chọn rạp"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(311, 369)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 19
        Me.btnclear.Text = "Clear"
        '
        'btnbook
        '
        Me.btnbook.Location = New System.Drawing.Point(230, 369)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(75, 23)
        Me.btnbook.TabIndex = 19
        Me.btnbook.Text = "Đặt vé"
        '
        'pnMain
        '
        Me.pnMain.Location = New System.Drawing.Point(230, 35)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(578, 318)
        Me.pnMain.TabIndex = 20
        '
        'frmBookVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 430)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.btnbook)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmBookVe"
        Me.Text = "frmBookVe"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dchonngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dchonngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dchonngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnhienthi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cborap As System.Windows.Forms.ComboBox
    Friend WithEvents cbosuatchieu As System.Windows.Forms.ComboBox
    Friend WithEvents cbochonphong As System.Windows.Forms.ComboBox
    Friend WithEvents cbophim As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnbook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnMain As System.Windows.Forms.FlowLayoutPanel
End Class
