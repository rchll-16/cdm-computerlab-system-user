<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbSec = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbYrlvl = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.rdbFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdbMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtStudentNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(207, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 80)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CDM COMPUTER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LABORATORY RESERVATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Guna2Panel1.Controls.Add(Me.cmbSec)
        Me.Guna2Panel1.Controls.Add(Me.txtLname)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.cmbYrlvl)
        Me.Guna2Panel1.Controls.Add(Me.btnRegister)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtConfirmPass)
        Me.Guna2Panel1.Controls.Add(Me.txtPass)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.cmbCourse)
        Me.Guna2Panel1.Controls.Add(Me.rdbFemale)
        Me.Guna2Panel1.Controls.Add(Me.rdbMale)
        Me.Guna2Panel1.Controls.Add(Me.txtStudentNo)
        Me.Guna2Panel1.Controls.Add(Me.txtFname)
        Me.Guna2Panel1.Location = New System.Drawing.Point(11, 129)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(763, 398)
        Me.Guna2Panel1.TabIndex = 1
        '
        'cmbSec
        '
        Me.cmbSec.BackColor = System.Drawing.Color.Transparent
        Me.cmbSec.BorderRadius = 3
        Me.cmbSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSec.DropDownHeight = 100
        Me.cmbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSec.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSec.FocusedState.Parent = Me.cmbSec
        Me.cmbSec.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSec.FormattingEnabled = True
        Me.cmbSec.HoverState.Parent = Me.cmbSec
        Me.cmbSec.IntegralHeight = False
        Me.cmbSec.ItemHeight = 30
        Me.cmbSec.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"})
        Me.cmbSec.ItemsAppearance.Parent = Me.cmbSec
        Me.cmbSec.Location = New System.Drawing.Point(595, 262)
        Me.cmbSec.MaxDropDownItems = 5
        Me.cmbSec.Name = "cmbSec"
        Me.cmbSec.ShadowDecoration.Parent = Me.cmbSec
        Me.cmbSec.Size = New System.Drawing.Size(95, 36)
        Me.cmbSec.Sorted = True
        Me.cmbSec.TabIndex = 10
        '
        'txtLname
        '
        Me.txtLname.BorderRadius = 3
        Me.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLname.DefaultText = ""
        Me.txtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.DisabledState.Parent = Me.txtLname
        Me.txtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.FocusedState.Parent = Me.txtLname
        Me.txtLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.HoverState.Parent = Me.txtLname
        Me.txtLname.Location = New System.Drawing.Point(490, 103)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.PlaceholderText = ""
        Me.txtLname.SelectedText = ""
        Me.txtLname.ShadowDecoration.Parent = Me.txtLname
        Me.txtLname.Size = New System.Drawing.Size(200, 30)
        Me.txtLname.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(394, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Last Name:"
        '
        'cmbYrlvl
        '
        Me.cmbYrlvl.BackColor = System.Drawing.Color.Transparent
        Me.cmbYrlvl.BorderRadius = 3
        Me.cmbYrlvl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYrlvl.DropDownHeight = 100
        Me.cmbYrlvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYrlvl.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYrlvl.FocusedState.Parent = Me.cmbYrlvl
        Me.cmbYrlvl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYrlvl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYrlvl.FormattingEnabled = True
        Me.cmbYrlvl.HoverState.Parent = Me.cmbYrlvl
        Me.cmbYrlvl.IntegralHeight = False
        Me.cmbYrlvl.ItemHeight = 30
        Me.cmbYrlvl.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbYrlvl.ItemsAppearance.Parent = Me.cmbYrlvl
        Me.cmbYrlvl.Location = New System.Drawing.Point(490, 263)
        Me.cmbYrlvl.MaxDropDownItems = 5
        Me.cmbYrlvl.Name = "cmbYrlvl"
        Me.cmbYrlvl.ShadowDecoration.Parent = Me.cmbYrlvl
        Me.cmbYrlvl.Size = New System.Drawing.Size(95, 36)
        Me.cmbYrlvl.Sorted = True
        Me.cmbYrlvl.TabIndex = 9
        '
        'btnRegister
        '
        Me.btnRegister.BorderColor = System.Drawing.Color.Transparent
        Me.btnRegister.BorderRadius = 5
        Me.btnRegister.BorderThickness = 2
        Me.btnRegister.CheckedState.Parent = Me.btnRegister
        Me.btnRegister.CustomImages.Parent = Me.btnRegister
        Me.btnRegister.FillColor = System.Drawing.Color.Gold
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.FillColor = System.Drawing.Color.Black
        Me.btnRegister.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.Parent = Me.btnRegister
        Me.btnRegister.Location = New System.Drawing.Point(499, 347)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.ShadowDecoration.Parent = Me.btnRegister
        Me.btnRegister.Size = New System.Drawing.Size(200, 36)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "Register"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 36)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Confirm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(416, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Gender:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(373, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Year / Section:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(415, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Course:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Student No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First Name:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderRadius = 3
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.FocusedState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.HoverState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Location = New System.Drawing.Point(111, 310)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderText = ""
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.ShadowDecoration.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Size = New System.Drawing.Size(200, 30)
        Me.txtConfirmPass.TabIndex = 5
        '
        'txtPass
        '
        Me.txtPass.BorderRadius = 3
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.Parent = Me.txtPass
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.FocusedState.Parent = Me.txtPass
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.HoverState.Parent = Me.txtPass
        Me.txtPass.Location = New System.Drawing.Point(111, 259)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderText = ""
        Me.txtPass.SelectedText = ""
        Me.txtPass.ShadowDecoration.Parent = Me.txtPass
        Me.txtPass.Size = New System.Drawing.Size(200, 30)
        Me.txtPass.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(111, 207)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "abc@gmail.com"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(200, 30)
        Me.txtEmail.TabIndex = 3
        '
        'cmbCourse
        '
        Me.cmbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbCourse.BorderRadius = 3
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCourse.FocusedState.Parent = Me.cmbCourse
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.HoverState.Parent = Me.cmbCourse
        Me.cmbCourse.IntegralHeight = False
        Me.cmbCourse.ItemHeight = 30
        Me.cmbCourse.Items.AddRange(New Object() {"Choose a Course", "BSIT", "BSCPE"})
        Me.cmbCourse.ItemsAppearance.Parent = Me.cmbCourse
        Me.cmbCourse.Location = New System.Drawing.Point(490, 199)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.ShadowDecoration.Parent = Me.cmbCourse
        Me.cmbCourse.Size = New System.Drawing.Size(200, 36)
        Me.cmbCourse.TabIndex = 8
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbFemale.CheckedState.BorderThickness = 0
        Me.rdbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdbFemale.CheckedState.InnerOffset = -4
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.ForeColor = System.Drawing.Color.White
        Me.rdbFemale.Location = New System.Drawing.Point(604, 159)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(67, 17)
        Me.rdbFemale.TabIndex = 7
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "FEMALE"
        Me.rdbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdbFemale.UncheckedState.BorderThickness = 2
        Me.rdbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbMale.CheckedState.BorderThickness = 0
        Me.rdbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdbMale.CheckedState.InnerOffset = -4
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.ForeColor = System.Drawing.Color.White
        Me.rdbMale.Location = New System.Drawing.Point(506, 159)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(54, 17)
        Me.rdbMale.TabIndex = 6
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "MALE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdbMale.UncheckedState.BorderThickness = 2
        Me.rdbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'txtStudentNo
        '
        Me.txtStudentNo.BorderRadius = 3
        Me.txtStudentNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentNo.DefaultText = ""
        Me.txtStudentNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNo.DisabledState.Parent = Me.txtStudentNo
        Me.txtStudentNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNo.FocusedState.Parent = Me.txtStudentNo
        Me.txtStudentNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNo.HoverState.Parent = Me.txtStudentNo
        Me.txtStudentNo.Location = New System.Drawing.Point(111, 156)
        Me.txtStudentNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNo.PlaceholderText = "00-00000"
        Me.txtStudentNo.SelectedText = ""
        Me.txtStudentNo.ShadowDecoration.Parent = Me.txtStudentNo
        Me.txtStudentNo.Size = New System.Drawing.Size(200, 30)
        Me.txtStudentNo.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.BorderRadius = 3
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFname.DefaultText = ""
        Me.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.DisabledState.Parent = Me.txtFname
        Me.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.FocusedState.Parent = Me.txtFname
        Me.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.HoverState.Parent = Me.txtFname
        Me.txtFname.Location = New System.Drawing.Point(111, 104)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PlaceholderText = ""
        Me.txtFname.SelectedText = ""
        Me.txtFname.ShadowDecoration.Parent = Me.txtFname
        Me.txtFname.Size = New System.Drawing.Size(200, 30)
        Me.txtFname.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(727, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 15
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(758, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 14
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(11, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 71)
        Me.Panel1.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(194, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(377, 50)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "REGISTER ACCOUNT"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CDMLABdeskapp.My.Resources.Resources.cdm
        Me.PictureBox2.Location = New System.Drawing.Point(11, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.ics_removebg_preview__2_
        Me.PictureBox1.Location = New System.Drawing.Point(644, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 540)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registration"
        Me.Text = "SIGN UP PAGE"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents rdbFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdbMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbYrlvl As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbSec As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
End Class
