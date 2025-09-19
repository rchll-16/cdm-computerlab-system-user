<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.chbShow = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.linkReg = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(143, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.chbShow)
        Me.Panel1.Controls.Add(Me.linkReg)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(421, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 506)
        Me.Panel1.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.BorderColor = System.Drawing.Color.Black
        Me.txtPass.BorderRadius = 5
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.Parent = Me.txtPass
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.Green
        Me.txtPass.FocusedState.Parent = Me.txtPass
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtPass.HoverState.Parent = Me.txtPass
        Me.txtPass.HoverState.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(67, 295)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPass.PlaceholderText = ""
        Me.txtPass.SelectedText = ""
        Me.txtPass.ShadowDecoration.Parent = Me.txtPass
        Me.txtPass.Size = New System.Drawing.Size(233, 38)
        Me.txtPass.TabIndex = 14
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(306, 8)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 13
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(337, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 12
        '
        'chbShow
        '
        Me.chbShow.AutoSize = True
        Me.chbShow.BackColor = System.Drawing.Color.Transparent
        Me.chbShow.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chbShow.CheckedState.BorderRadius = 2
        Me.chbShow.CheckedState.BorderThickness = 0
        Me.chbShow.CheckedState.FillColor = System.Drawing.Color.White
        Me.chbShow.CheckMarkColor = System.Drawing.Color.Black
        Me.chbShow.ForeColor = System.Drawing.Color.Black
        Me.chbShow.Location = New System.Drawing.Point(67, 338)
        Me.chbShow.Name = "chbShow"
        Me.chbShow.Size = New System.Drawing.Size(102, 17)
        Me.chbShow.TabIndex = 11
        Me.chbShow.Text = "Show Password"
        Me.chbShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbShow.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chbShow.UncheckedState.BorderRadius = 2
        Me.chbShow.UncheckedState.BorderThickness = 1
        Me.chbShow.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chbShow.UseVisualStyleBackColor = False
        '
        'linkReg
        '
        Me.linkReg.AutoSize = True
        Me.linkReg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkReg.Location = New System.Drawing.Point(127, 434)
        Me.linkReg.Name = "linkReg"
        Me.linkReg.Size = New System.Drawing.Size(125, 13)
        Me.linkReg.TabIndex = 10
        Me.linkReg.TabStop = True
        Me.linkReg.Text = "Don't Have an Account?"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(170, 541)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 20
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.ForestGreen
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.Yellow
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(91, 386)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(185, 45)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOGIN"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColor = System.Drawing.Color.Black
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Green
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.HoverState.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(67, 205)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtEmail.PlaceholderText = "abc@gmail.com"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(233, 38)
        Me.txtEmail.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EMAIL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 47)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STUDENT LOGIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(342, 126)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CDM COMPUTER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LABORATORY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESERVATION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.TargetControl = Me.Panel1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.ics
        Me.PictureBox1.Location = New System.Drawing.Point(213, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CDMLABdeskapp.My.Resources.Resources.cdm
        Me.PictureBox2.Location = New System.Drawing.Point(43, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 122)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(787, 506)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "LOGIN PAGE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents linkReg As LinkLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chbShow As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
End Class
