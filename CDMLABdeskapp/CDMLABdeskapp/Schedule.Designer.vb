<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScheduleDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.clmnComlabNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnPCSlot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnEndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPageNumber = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.MintCream
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(744, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 19
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.MintCream
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(775, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 67)
        Me.Guna2Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPUTER LABORATORY SCHEDULE"
        '
        'ScheduleDataGridView
        '
        Me.ScheduleDataGridView.AllowUserToAddRows = False
        Me.ScheduleDataGridView.AllowUserToDeleteRows = False
        Me.ScheduleDataGridView.AllowUserToOrderColumns = True
        Me.ScheduleDataGridView.AllowUserToResizeColumns = False
        Me.ScheduleDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ScheduleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScheduleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScheduleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ScheduleDataGridView.ColumnHeadersHeight = 35
        Me.ScheduleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmnComlabNo, Me.clmnPCSlot, Me.clmnStartTime, Me.clmnEndTime})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ScheduleDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ScheduleDataGridView.EnableHeadersVisualStyles = False
        Me.ScheduleDataGridView.GridColor = System.Drawing.Color.Black
        Me.ScheduleDataGridView.Location = New System.Drawing.Point(12, 73)
        Me.ScheduleDataGridView.Name = "ScheduleDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScheduleDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ScheduleDataGridView.RowHeadersVisible = False
        Me.ScheduleDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.ScheduleDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ScheduleDataGridView.Size = New System.Drawing.Size(776, 329)
        Me.ScheduleDataGridView.TabIndex = 21
        Me.ScheduleDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.ScheduleDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ScheduleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.ScheduleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ScheduleDataGridView.ThemeStyle.HeaderStyle.Height = 35
        Me.ScheduleDataGridView.ThemeStyle.ReadOnly = False
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.ScheduleDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'clmnComlabNo
        '
        Me.clmnComlabNo.HeaderText = "Comlab no."
        Me.clmnComlabNo.MinimumWidth = 6
        Me.clmnComlabNo.Name = "clmnComlabNo"
        '
        'clmnPCSlot
        '
        Me.clmnPCSlot.HeaderText = "PC slot"
        Me.clmnPCSlot.MinimumWidth = 6
        Me.clmnPCSlot.Name = "clmnPCSlot"
        '
        'clmnStartTime
        '
        Me.clmnStartTime.HeaderText = "Start Time"
        Me.clmnStartTime.MinimumWidth = 6
        Me.clmnStartTime.Name = "clmnStartTime"
        '
        'clmnEndTime
        '
        Me.clmnEndTime.HeaderText = "End Time"
        Me.clmnEndTime.MinimumWidth = 6
        Me.clmnEndTime.Name = "clmnEndTime"
        '
        'btnBack
        '
        Me.btnBack.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnBack.BorderRadius = 5
        Me.btnBack.BorderThickness = 2
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(12, 408)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(78, 30)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "BACK"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(680, 408)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(108, 30)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "Choose ComLab"
        '
        'btnPrevious
        '
        Me.btnPrevious.BorderRadius = 5
        Me.btnPrevious.BorderThickness = 1
        Me.btnPrevious.CheckedState.Parent = Me.btnPrevious
        Me.btnPrevious.CustomImages.Parent = Me.btnPrevious
        Me.btnPrevious.FillColor = System.Drawing.Color.Transparent
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnPrevious.HoverState.Parent = Me.btnPrevious
        Me.btnPrevious.Location = New System.Drawing.Point(330, 408)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.ShadowDecoration.Parent = Me.btnPrevious
        Me.btnPrevious.Size = New System.Drawing.Size(62, 21)
        Me.btnPrevious.TabIndex = 30
        Me.btnPrevious.Text = "Previous"
        '
        'btnNext
        '
        Me.btnNext.BorderRadius = 5
        Me.btnNext.BorderThickness = 1
        Me.btnNext.CheckedState.Parent = Me.btnNext
        Me.btnNext.CustomImages.Parent = Me.btnNext
        Me.btnNext.FillColor = System.Drawing.Color.Transparent
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnNext.HoverState.Parent = Me.btnNext
        Me.btnNext.Location = New System.Drawing.Point(398, 408)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ShadowDecoration.Parent = Me.btnNext
        Me.btnNext.Size = New System.Drawing.Size(62, 21)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next"
        '
        'lblPageNumber
        '
        Me.lblPageNumber.AutoSize = True
        Me.lblPageNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNumber.Location = New System.Drawing.Point(355, 446)
        Me.lblPageNumber.Name = "lblPageNumber"
        Me.lblPageNumber.Size = New System.Drawing.Size(37, 17)
        Me.lblPageNumber.TabIndex = 32
        Me.lblPageNumber.Text = "Page"
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.lblPageNumber)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ScheduleDataGridView)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ScheduleDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clmnComlabNo As DataGridViewTextBoxColumn
    Friend WithEvents clmnPCSlot As DataGridViewTextBoxColumn
    Friend WithEvents clmnStartTime As DataGridViewTextBoxColumn
    Friend WithEvents clmnEndTime As DataGridViewTextBoxColumn
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPageNumber As Label
End Class
