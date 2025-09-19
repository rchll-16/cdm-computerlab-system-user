<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseSubjPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseSubjPopup))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.cmbMajorSubj = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChooseMajorSubj = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(379, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(348, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 19
        '
        'cmbMajorSubj
        '
        Me.cmbMajorSubj.BackColor = System.Drawing.Color.Transparent
        Me.cmbMajorSubj.BorderColor = System.Drawing.Color.Black
        Me.cmbMajorSubj.BorderRadius = 2
        Me.cmbMajorSubj.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMajorSubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMajorSubj.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMajorSubj.FocusedState.Parent = Me.cmbMajorSubj
        Me.cmbMajorSubj.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMajorSubj.ForeColor = System.Drawing.Color.Black
        Me.cmbMajorSubj.FormattingEnabled = True
        Me.cmbMajorSubj.HoverState.Parent = Me.cmbMajorSubj
        Me.cmbMajorSubj.ItemHeight = 30
        Me.cmbMajorSubj.Items.AddRange(New Object() {"Choose a Subject"})
        Me.cmbMajorSubj.ItemsAppearance.Parent = Me.cmbMajorSubj
        Me.cmbMajorSubj.Location = New System.Drawing.Point(110, 153)
        Me.cmbMajorSubj.Name = "cmbMajorSubj"
        Me.cmbMajorSubj.ShadowDecoration.Parent = Me.cmbMajorSubj
        Me.cmbMajorSubj.Size = New System.Drawing.Size(200, 36)
        Me.cmbMajorSubj.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(126, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Choose a Major Subject"
        '
        'btnChooseMajorSubj
        '
        Me.btnChooseMajorSubj.BorderRadius = 5
        Me.btnChooseMajorSubj.BorderThickness = 1
        Me.btnChooseMajorSubj.CheckedState.Parent = Me.btnChooseMajorSubj
        Me.btnChooseMajorSubj.CustomImages.Parent = Me.btnChooseMajorSubj
        Me.btnChooseMajorSubj.FillColor = System.Drawing.Color.Gold
        Me.btnChooseMajorSubj.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseMajorSubj.ForeColor = System.Drawing.Color.Black
        Me.btnChooseMajorSubj.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChooseMajorSubj.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.btnChooseMajorSubj.HoverState.Parent = Me.btnChooseMajorSubj
        Me.btnChooseMajorSubj.Location = New System.Drawing.Point(140, 273)
        Me.btnChooseMajorSubj.Name = "btnChooseMajorSubj"
        Me.btnChooseMajorSubj.ShadowDecoration.Parent = Me.btnChooseMajorSubj
        Me.btnChooseMajorSubj.Size = New System.Drawing.Size(137, 38)
        Me.btnChooseMajorSubj.TabIndex = 29
        Me.btnChooseMajorSubj.Text = "Select Subject"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.CDMLABdeskapp.My.Resources.Resources.ics
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(28, 35)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(71, 64)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 30
        Me.Guna2PictureBox1.TabStop = False
        '
        'ChooseSubjPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(410, 350)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnChooseMajorSubj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMajorSubj)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChooseSubjPopup"
        Me.Text = "ChooseSubjPopup"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents cmbMajorSubj As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChooseMajorSubj As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
