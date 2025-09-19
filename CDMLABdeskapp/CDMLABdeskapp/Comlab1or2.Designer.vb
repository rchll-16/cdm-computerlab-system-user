<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Comlab1or2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comlab1or2))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnlComlab1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlComlab2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlComlab1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComlab2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(976, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(41, 27)
        Me.Guna2ControlBox2.TabIndex = 20
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1017, 4)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 27)
        Me.Guna2ControlBox1.TabIndex = 19
        '
        'pnlComlab1
        '
        Me.pnlComlab1.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlComlab1.Controls.Add(Me.Label1)
        Me.pnlComlab1.Controls.Add(Me.PictureBox1)
        Me.pnlComlab1.FillColor = System.Drawing.Color.White
        Me.pnlComlab1.ForeColor = System.Drawing.Color.Black
        Me.pnlComlab1.Location = New System.Drawing.Point(135, 124)
        Me.pnlComlab1.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlComlab1.Name = "pnlComlab1"
        Me.pnlComlab1.ShadowColor = System.Drawing.Color.Black
        Me.pnlComlab1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.pnlComlab1.Size = New System.Drawing.Size(349, 254)
        Me.pnlComlab1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMPUTER LABORATORY 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.computer_png
        Me.PictureBox1.Location = New System.Drawing.Point(84, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pnlComlab2
        '
        Me.pnlComlab2.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlComlab2.Controls.Add(Me.Label2)
        Me.pnlComlab2.Controls.Add(Me.PictureBox2)
        Me.pnlComlab2.FillColor = System.Drawing.Color.White
        Me.pnlComlab2.ForeColor = System.Drawing.Color.Black
        Me.pnlComlab2.Location = New System.Drawing.Point(581, 124)
        Me.pnlComlab2.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlComlab2.Name = "pnlComlab2"
        Me.pnlComlab2.ShadowColor = System.Drawing.Color.Black
        Me.pnlComlab2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.pnlComlab2.Size = New System.Drawing.Size(349, 254)
        Me.pnlComlab2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "COMPUTER LABORATORY 2"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.CDMLABdeskapp.My.Resources.Resources.computer_png
        Me.PictureBox2.Location = New System.Drawing.Point(84, 22)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 144)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
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
        Me.btnBack.Location = New System.Drawing.Point(16, 441)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(104, 37)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "BACK"
        '
        'Comlab1or2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 492)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlComlab2)
        Me.Controls.Add(Me.pnlComlab1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Comlab1or2"
        Me.Text = "Form3"
        Me.pnlComlab1.ResumeLayout(False)
        Me.pnlComlab1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComlab2.ResumeLayout(False)
        Me.pnlComlab2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlComlab1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlComlab2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
