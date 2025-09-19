<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateTimePick
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateTimePick))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTime = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnProceed = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(569, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 19
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(600, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.computerbg
        Me.PictureBox1.Location = New System.Drawing.Point(64, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(379, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Pick a Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(379, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Pick a Time (Max: 1hour):"
        '
        'cmbTime
        '
        Me.cmbTime.BackColor = System.Drawing.Color.Transparent
        Me.cmbTime.BorderColor = System.Drawing.Color.Black
        Me.cmbTime.BorderRadius = 5
        Me.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.FillColor = System.Drawing.Color.ForestGreen
        Me.cmbTime.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTime.FocusedState.Parent = Me.cmbTime
        Me.cmbTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTime.ForeColor = System.Drawing.Color.White
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.HoverState.Parent = Me.cmbTime
        Me.cmbTime.ItemHeight = 30
        Me.cmbTime.Items.AddRange(New Object() {"Choose Time", "1:00 PM - 2:00 PM", "2:00 PM - 3:00 PM", "3:00 PM - 4:00 PM", "4:00 PM - 5:00 PM"})
        Me.cmbTime.ItemsAppearance.Parent = Me.cmbTime
        Me.cmbTime.Location = New System.Drawing.Point(383, 217)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.ShadowDecoration.Parent = Me.cmbTime
        Me.cmbTime.Size = New System.Drawing.Size(200, 36)
        Me.cmbTime.TabIndex = 32
        '
        'btnProceed
        '
        Me.btnProceed.BorderRadius = 5
        Me.btnProceed.BorderThickness = 1
        Me.btnProceed.CheckedState.Parent = Me.btnProceed
        Me.btnProceed.CustomImages.Parent = Me.btnProceed
        Me.btnProceed.FillColor = System.Drawing.Color.ForestGreen
        Me.btnProceed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.HoverState.FillColor = System.Drawing.Color.Gold
        Me.btnProceed.HoverState.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnProceed.HoverState.Parent = Me.btnProceed
        Me.btnProceed.Location = New System.Drawing.Point(522, 361)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.ShadowDecoration.Parent = Me.btnProceed
        Me.btnProceed.Size = New System.Drawing.Size(88, 33)
        Me.btnProceed.TabIndex = 33
        Me.btnProceed.Text = "Proceed"
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
        Me.btnBack.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.ForestGreen
        Me.btnBack.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(12, 364)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(78, 30)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "BACK"
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadDateTimePicker1.CalendarSize = New System.Drawing.Size(290, 320)
        Me.RadDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDateTimePicker1.ForeColor = System.Drawing.Color.ForestGreen
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(383, 106)
        Me.RadDateTimePicker1.MinDate = New Date(2024, 5, 24, 0, 0, 0, 0)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        '
        '
        '
        Me.RadDateTimePicker1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 164, 20)
        Me.RadDateTimePicker1.RootElement.StretchVertically = True
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(200, 39)
        Me.RadDateTimePicker1.TabIndex = 36
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Text = "Friday, 24 May 2024"
        Me.RadDateTimePicker1.ThemeName = "Fluent"
        Me.RadDateTimePicker1.Value = New Date(2024, 5, 24, 21, 4, 20, 0)
        '
        'DateTimePick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 406)
        Me.Controls.Add(Me.RadDateTimePicker1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.cmbTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DateTimePick"
        Me.Text = "DateTimePick"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTime As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProceed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
End Class
