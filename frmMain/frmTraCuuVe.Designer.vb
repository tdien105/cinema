<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuVe
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvdanhsach = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbophim = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnfillter = New System.Windows.Forms.Button()
        Me.cbosuatchieu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dchonngay = New DevExpress.XtraEditors.DateEdit()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dchonngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dchonngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvdanhsach)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vé đã bán"
        '
        'dgvdanhsach
        '
        Me.dgvdanhsach.AllowUserToAddRows = False
        Me.dgvdanhsach.AllowUserToDeleteRows = False
        Me.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsach.Location = New System.Drawing.Point(7, 20)
        Me.dgvdanhsach.Name = "dgvdanhsach"
        Me.dgvdanhsach.ReadOnly = True
        Me.dgvdanhsach.Size = New System.Drawing.Size(643, 166)
        Me.dgvdanhsach.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbophim)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnreset)
        Me.GroupBox2.Controls.Add(Me.btnfillter)
        Me.GroupBox2.Controls.Add(Me.cbosuatchieu)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dchonngay)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 105)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fillter"
        '
        'txtmave
        '
        Me.txtmave.Location = New System.Drawing.Point(474, 147)
        Me.txtmave.Name = "txtmave"
        Me.txtmave.Size = New System.Drawing.Size(121, 20)
        Me.txtmave.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mã vé"
        '
        'cbophim
        '
        Me.cbophim.FormattingEnabled = True
        Me.cbophim.Location = New System.Drawing.Point(354, 21)
        Me.cbophim.Name = "cbophim"
        Me.cbophim.Size = New System.Drawing.Size(121, 21)
        Me.cbophim.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tên phim"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(527, 19)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "Reset fillter"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnfillter
        '
        Me.btnfillter.Location = New System.Drawing.Point(527, 68)
        Me.btnfillter.Name = "btnfillter"
        Me.btnfillter.Size = New System.Drawing.Size(75, 23)
        Me.btnfillter.TabIndex = 5
        Me.btnfillter.Text = "Fillter"
        Me.btnfillter.UseVisualStyleBackColor = True
        '
        'cbosuatchieu
        '
        Me.cbosuatchieu.FormattingEnabled = True
        Me.cbosuatchieu.Location = New System.Drawing.Point(95, 70)
        Me.cbosuatchieu.Name = "cbosuatchieu"
        Me.cbosuatchieu.Size = New System.Drawing.Size(121, 21)
        Me.cbosuatchieu.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Suất chiếu"
        '
        'dchonngay
        '
        Me.dchonngay.EditValue = Nothing
        Me.dchonngay.Location = New System.Drawing.Point(95, 31)
        Me.dchonngay.Name = "dchonngay"
        Me.dchonngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dchonngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dchonngay.Size = New System.Drawing.Size(100, 20)
        Me.dchonngay.TabIndex = 0
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(601, 145)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(67, 23)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'frmTraCuuVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 379)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtmave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTraCuuVe"
        Me.Text = "frmTraCuuVe"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dchonngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dchonngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdanhsach As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosuatchieu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dchonngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnfillter As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbophim As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmave As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
End Class
