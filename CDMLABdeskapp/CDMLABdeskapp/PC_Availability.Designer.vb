<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PC_Availability
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PC_Availability))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComlab1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtComlab2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChooseSubj = New Guna.UI2.WinForms.Guna2Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.DateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(684, 2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 17
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.MintCream
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(715, 2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Computer Laboratory 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(430, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Computer Laboratory 2"
        '
        'txtComlab1
        '
        Me.txtComlab1.BorderColor = System.Drawing.Color.Black
        Me.txtComlab1.BorderRadius = 5
        Me.txtComlab1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComlab1.DefaultText = "30"
        Me.txtComlab1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtComlab1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtComlab1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComlab1.DisabledState.Parent = Me.txtComlab1
        Me.txtComlab1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComlab1.FillColor = System.Drawing.Color.Gold
        Me.txtComlab1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComlab1.FocusedState.Parent = Me.txtComlab1
        Me.txtComlab1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComlab1.ForeColor = System.Drawing.Color.Black
        Me.txtComlab1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComlab1.HoverState.Parent = Me.txtComlab1
        Me.txtComlab1.Location = New System.Drawing.Point(74, 215)
        Me.txtComlab1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtComlab1.Name = "txtComlab1"
        Me.txtComlab1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComlab1.PlaceholderText = ""
        Me.txtComlab1.ReadOnly = True
        Me.txtComlab1.SelectedText = ""
        Me.txtComlab1.SelectionStart = 2
        Me.txtComlab1.ShadowDecoration.Parent = Me.txtComlab1
        Me.txtComlab1.Size = New System.Drawing.Size(64, 46)
        Me.txtComlab1.TabIndex = 23
        Me.txtComlab1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComlab2
        '
        Me.txtComlab2.BorderColor = System.Drawing.Color.Black
        Me.txtComlab2.BorderRadius = 5
        Me.txtComlab2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComlab2.DefaultText = "30"
        Me.txtComlab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtComlab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtComlab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComlab2.DisabledState.Parent = Me.txtComlab2
        Me.txtComlab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComlab2.FillColor = System.Drawing.Color.Gold
        Me.txtComlab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComlab2.FocusedState.Parent = Me.txtComlab2
        Me.txtComlab2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComlab2.ForeColor = System.Drawing.Color.Black
        Me.txtComlab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComlab2.HoverState.Parent = Me.txtComlab2
        Me.txtComlab2.Location = New System.Drawing.Point(430, 215)
        Me.txtComlab2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtComlab2.Name = "txtComlab2"
        Me.txtComlab2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComlab2.PlaceholderText = ""
        Me.txtComlab2.ReadOnly = True
        Me.txtComlab2.SelectedText = ""
        Me.txtComlab2.SelectionStart = 2
        Me.txtComlab2.ShadowDecoration.Parent = Me.txtComlab2
        Me.txtComlab2.Size = New System.Drawing.Size(64, 46)
        Me.txtComlab2.TabIndex = 24
        Me.txtComlab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(144, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 50)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Schedule Reserved " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ 120 Time Schedule "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(500, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 50)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Schedule Reserved " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ 120 Time Schedule "
        '
        'btnChooseSubj
        '
        Me.btnChooseSubj.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseSubj.BorderRadius = 5
        Me.btnChooseSubj.BorderThickness = 1
        Me.btnChooseSubj.CheckedState.Parent = Me.btnChooseSubj
        Me.btnChooseSubj.CustomImages.Parent = Me.btnChooseSubj
        Me.btnChooseSubj.FillColor = System.Drawing.Color.Gold
        Me.btnChooseSubj.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSubj.ForeColor = System.Drawing.Color.Black
        Me.btnChooseSubj.HoverState.Parent = Me.btnChooseSubj
        Me.btnChooseSubj.Location = New System.Drawing.Point(609, 339)
        Me.btnChooseSubj.Name = "btnChooseSubj"
        Me.btnChooseSubj.ShadowDecoration.Parent = Me.btnChooseSubj
        Me.btnChooseSubj.Size = New System.Drawing.Size(106, 41)
        Me.btnChooseSubj.TabIndex = 28
        Me.btnChooseSubj.Text = "Reserve Now"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
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
        Me.btnBack.Location = New System.Drawing.Point(12, 344)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(78, 36)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "BACK"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.ics
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(71, 64)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 31
        Me.Guna2PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePicker1.CalendarSize = New System.Drawing.Size(290, 320)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 145)
        Me.DateTimePicker1.MinDate = New Date(2024, 5, 24, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        '
        '
        '
        Me.DateTimePicker1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 164, 20)
        Me.DateTimePicker1.RootElement.StretchVertically = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 39)
        Me.DateTimePicker1.TabIndex = 38
        Me.DateTimePicker1.TabStop = False
        Me.DateTimePicker1.Text = "Friday, 24 May 2024"
        Me.DateTimePicker1.ThemeName = "Fluent"
        Me.DateTimePicker1.Value = New Date(2024, 5, 24, 21, 4, 20, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePicker2.CalendarSize = New System.Drawing.Size(290, 320)
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.ForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker2.Location = New System.Drawing.Point(454, 145)
        Me.DateTimePicker2.MinDate = New Date(2024, 5, 24, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        '
        '
        '
        Me.DateTimePicker2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 164, 20)
        Me.DateTimePicker2.RootElement.StretchVertically = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 39)
        Me.DateTimePicker2.TabIndex = 38
        Me.DateTimePicker2.TabStop = False
        Me.DateTimePicker2.Text = "Friday, 24 May 2024"
        Me.DateTimePicker2.ThemeName = "Fluent"
        Me.DateTimePicker2.Value = New Date(2024, 5, 24, 21, 4, 20, 0)
        '
        'PC_Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(745, 398)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChooseSubj)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtComlab2)
        Me.Controls.Add(Me.txtComlab1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.ForeColor = System.Drawing.Color.MintCream
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PC_Availability"
        Me.Text = "PC_Availability"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtComlab2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtComlab1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChooseSubj As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents DateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
End Class
