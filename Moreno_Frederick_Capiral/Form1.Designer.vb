<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btncomp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblsum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnum2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnum1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 40
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Controls.Add(Me.btnclear)
        Me.Guna2Panel1.Controls.Add(Me.btncomp)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lbltp)
        Me.Guna2Panel1.Controls.Add(Me.lblsum)
        Me.Guna2Panel1.Controls.Add(Me.txtnum2)
        Me.Guna2Panel1.Controls.Add(Me.txtnum1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(94, 86)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(497, 615)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.BorderRadius = 9
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnclear.Location = New System.Drawing.Point(298, 505)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(117, 46)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        '
        'btncomp
        '
        Me.btncomp.BackColor = System.Drawing.Color.Transparent
        Me.btncomp.BorderRadius = 9
        Me.btncomp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncomp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncomp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncomp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncomp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncomp.FillColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btncomp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btncomp.Location = New System.Drawing.Point(82, 505)
        Me.btncomp.Name = "btncomp"
        Me.btncomp.Size = New System.Drawing.Size(117, 46)
        Me.btncomp.TabIndex = 9
        Me.btncomp.Text = "Compute"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(197, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Activity 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(160, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "30% of Sum:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(157, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(157, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Second Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(157, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Number:"
        '
        'lbltp
        '
        Me.lbltp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lbltp.BorderRadius = 6
        Me.lbltp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbltp.DefaultText = ""
        Me.lbltp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lbltp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lbltp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbltp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbltp.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lbltp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbltp.ForeColor = System.Drawing.Color.Transparent
        Me.lbltp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltp.Location = New System.Drawing.Point(160, 415)
        Me.lbltp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lbltp.Name = "lbltp"
        Me.lbltp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbltp.PlaceholderText = ""
        Me.lbltp.SelectedText = ""
        Me.lbltp.Size = New System.Drawing.Size(185, 34)
        Me.lbltp.TabIndex = 3
        '
        'lblsum
        '
        Me.lblsum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lblsum.BorderRadius = 6
        Me.lblsum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblsum.DefaultText = ""
        Me.lblsum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblsum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblsum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblsum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblsum.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblsum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblsum.ForeColor = System.Drawing.Color.Transparent
        Me.lblsum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsum.Location = New System.Drawing.Point(160, 331)
        Me.lblsum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblsum.Name = "lblsum"
        Me.lblsum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblsum.PlaceholderText = ""
        Me.lblsum.SelectedText = ""
        Me.lblsum.Size = New System.Drawing.Size(185, 34)
        Me.lblsum.TabIndex = 2
        '
        'txtnum2
        '
        Me.txtnum2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtnum2.BorderRadius = 6
        Me.txtnum2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnum2.DefaultText = ""
        Me.txtnum2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnum2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnum2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnum2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnum2.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtnum2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnum2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnum2.ForeColor = System.Drawing.Color.Transparent
        Me.txtnum2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnum2.Location = New System.Drawing.Point(160, 250)
        Me.txtnum2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnum2.PlaceholderText = ""
        Me.txtnum2.SelectedText = ""
        Me.txtnum2.Size = New System.Drawing.Size(185, 34)
        Me.txtnum2.TabIndex = 1
        '
        'txtnum1
        '
        Me.txtnum1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtnum1.BorderRadius = 6
        Me.txtnum1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnum1.DefaultText = ""
        Me.txtnum1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnum1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnum1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnum1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnum1.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtnum1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnum1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnum1.ForeColor = System.Drawing.Color.Transparent
        Me.txtnum1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnum1.Location = New System.Drawing.Point(160, 165)
        Me.txtnum1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnum1.PlaceholderText = ""
        Me.txtnum1.SelectedText = ""
        Me.txtnum1.Size = New System.Drawing.Size(185, 34)
        Me.txtnum1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 786)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblsum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnum2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnum1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btncomp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
End Class
