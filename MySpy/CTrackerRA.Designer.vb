<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTrackerRA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTrackerRA))
        Me.LNameTxt = New System.Windows.Forms.TextBox()
        Me.FNameTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.BlockT = New System.Windows.Forms.Timer(Me.components)
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.ResBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.AboBtn = New System.Windows.Forms.Button()
        Me.PNTxt5 = New System.Windows.Forms.TextBox()
        Me.PNTxt4 = New System.Windows.Forms.TextBox()
        Me.PNTxt3 = New System.Windows.Forms.TextBox()
        Me.PNTxt2 = New System.Windows.Forms.TextBox()
        Me.PNTxt1 = New System.Windows.Forms.TextBox()
        Me.IdTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LNameTxt
        '
        Me.LNameTxt.BackColor = System.Drawing.Color.White
        Me.LNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTxt.ForeColor = System.Drawing.Color.Black
        Me.LNameTxt.Location = New System.Drawing.Point(241, 35)
        Me.LNameTxt.Name = "LNameTxt"
        Me.LNameTxt.Size = New System.Drawing.Size(200, 31)
        Me.LNameTxt.TabIndex = 1
        Me.LNameTxt.Text = "last name"
        '
        'FNameTxt
        '
        Me.FNameTxt.BackColor = System.Drawing.Color.White
        Me.FNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTxt.ForeColor = System.Drawing.Color.Black
        Me.FNameTxt.Location = New System.Drawing.Point(35, 35)
        Me.FNameTxt.Name = "FNameTxt"
        Me.FNameTxt.Size = New System.Drawing.Size(200, 31)
        Me.FNameTxt.TabIndex = 0
        Me.FNameTxt.Text = "first name"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BackColor = System.Drawing.Color.White
        Me.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.PasswordTxt.Location = New System.Drawing.Point(241, 74)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(200, 31)
        Me.PasswordTxt.TabIndex = 3
        Me.PasswordTxt.Text = "gmail password"
        '
        'EmailTxt
        '
        Me.EmailTxt.BackColor = System.Drawing.Color.White
        Me.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.ForeColor = System.Drawing.Color.Black
        Me.EmailTxt.Location = New System.Drawing.Point(35, 74)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(200, 31)
        Me.EmailTxt.TabIndex = 2
        Me.EmailTxt.Text = "gmail address"
        '
        'BlockT
        '
        Me.BlockT.Interval = 1
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegisterBtn.BackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RegisterBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterBtn.ForeColor = System.Drawing.Color.White
        Me.RegisterBtn.Location = New System.Drawing.Point(680, 35)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(100, 50)
        Me.RegisterBtn.TabIndex = 10
        Me.RegisterBtn.Text = "register"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'ResBtn
        '
        Me.ResBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResBtn.BackColor = System.Drawing.Color.Transparent
        Me.ResBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ResBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ResBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ResBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResBtn.ForeColor = System.Drawing.Color.White
        Me.ResBtn.Location = New System.Drawing.Point(680, 91)
        Me.ResBtn.Name = "ResBtn"
        Me.ResBtn.Size = New System.Drawing.Size(100, 50)
        Me.ResBtn.TabIndex = 11
        Me.ResBtn.Text = "restart"
        Me.ResBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ExitBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(680, 500)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(100, 50)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "close"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'AboBtn
        '
        Me.AboBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AboBtn.BackColor = System.Drawing.Color.Transparent
        Me.AboBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AboBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.AboBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.AboBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AboBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboBtn.ForeColor = System.Drawing.Color.White
        Me.AboBtn.Location = New System.Drawing.Point(680, 444)
        Me.AboBtn.Name = "AboBtn"
        Me.AboBtn.Size = New System.Drawing.Size(100, 50)
        Me.AboBtn.TabIndex = 13
        Me.AboBtn.Text = "about"
        Me.AboBtn.UseVisualStyleBackColor = False
        '
        'PNTxt5
        '
        Me.PNTxt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNTxt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNTxt5.Location = New System.Drawing.Point(447, 162)
        Me.PNTxt5.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.PNTxt5.MaxLength = 6
        Me.PNTxt5.Name = "PNTxt5"
        Me.PNTxt5.Size = New System.Drawing.Size(97, 31)
        Me.PNTxt5.TabIndex = 9
        Me.PNTxt5.Text = "KEY 5"
        '
        'PNTxt4
        '
        Me.PNTxt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNTxt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNTxt4.Location = New System.Drawing.Point(344, 162)
        Me.PNTxt4.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.PNTxt4.MaxLength = 6
        Me.PNTxt4.Name = "PNTxt4"
        Me.PNTxt4.Size = New System.Drawing.Size(97, 31)
        Me.PNTxt4.TabIndex = 8
        Me.PNTxt4.Text = "KEY 4"
        '
        'PNTxt3
        '
        Me.PNTxt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNTxt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNTxt3.Location = New System.Drawing.Point(241, 162)
        Me.PNTxt3.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.PNTxt3.MaxLength = 6
        Me.PNTxt3.Name = "PNTxt3"
        Me.PNTxt3.Size = New System.Drawing.Size(97, 31)
        Me.PNTxt3.TabIndex = 7
        Me.PNTxt3.Text = "KEY 3"
        '
        'PNTxt2
        '
        Me.PNTxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNTxt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNTxt2.Location = New System.Drawing.Point(138, 162)
        Me.PNTxt2.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.PNTxt2.MaxLength = 6
        Me.PNTxt2.Name = "PNTxt2"
        Me.PNTxt2.Size = New System.Drawing.Size(97, 31)
        Me.PNTxt2.TabIndex = 6
        Me.PNTxt2.Text = "KEY 2"
        '
        'PNTxt1
        '
        Me.PNTxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNTxt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNTxt1.Location = New System.Drawing.Point(35, 162)
        Me.PNTxt1.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.PNTxt1.MaxLength = 6
        Me.PNTxt1.Name = "PNTxt1"
        Me.PNTxt1.Size = New System.Drawing.Size(97, 31)
        Me.PNTxt1.TabIndex = 5
        Me.PNTxt1.Text = "KEY 1"
        '
        'IdTxt
        '
        Me.IdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTxt.Location = New System.Drawing.Point(35, 123)
        Me.IdTxt.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.IdTxt.MaxLength = 8
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(200, 31)
        Me.IdTxt.TabIndex = 4
        Me.IdTxt.Text = "PRODUCT ID"
        '
        'CTrackerRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.PNTxt5)
        Me.Controls.Add(Me.PNTxt4)
        Me.Controls.Add(Me.PNTxt3)
        Me.Controls.Add(Me.PNTxt2)
        Me.Controls.Add(Me.PNTxt1)
        Me.Controls.Add(Me.IdTxt)
        Me.Controls.Add(Me.AboBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ResBtn)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.LNameTxt)
        Me.Controls.Add(Me.FNameTxt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.EmailTxt)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CTrackerRA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTracker Basic"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents FNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents BlockT As System.Windows.Forms.Timer
    Friend WithEvents RegisterBtn As System.Windows.Forms.Button
    Friend WithEvents ResBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents AboBtn As System.Windows.Forms.Button
    Friend WithEvents PNTxt5 As System.Windows.Forms.TextBox
    Friend WithEvents PNTxt4 As System.Windows.Forms.TextBox
    Friend WithEvents PNTxt3 As System.Windows.Forms.TextBox
    Friend WithEvents PNTxt2 As System.Windows.Forms.TextBox
    Friend WithEvents PNTxt1 As System.Windows.Forms.TextBox
    Friend WithEvents IdTxt As System.Windows.Forms.TextBox
End Class
