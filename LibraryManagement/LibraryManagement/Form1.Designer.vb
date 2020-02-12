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
        Me.login_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.login_pan = New System.Windows.Forms.Panel()
        Me.reg_btn = New System.Windows.Forms.Button()
        Me.login_pan.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_txt
        '
        Me.login_txt.Location = New System.Drawing.Point(246, 41)
        Me.login_txt.Name = "login_txt"
        Me.login_txt.Size = New System.Drawing.Size(100, 20)
        Me.login_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Californian FB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(246, 106)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(100, 20)
        Me.pass_txt.TabIndex = 3
        '
        'login_btn
        '
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.SteelBlue
        Me.login_btn.Location = New System.Drawing.Point(198, 157)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(129, 34)
        Me.login_btn.TabIndex = 4
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'login_pan
        '
        Me.login_pan.BackColor = System.Drawing.Color.Teal
        Me.login_pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_pan.Controls.Add(Me.reg_btn)
        Me.login_pan.Controls.Add(Me.Label1)
        Me.login_pan.Controls.Add(Me.login_btn)
        Me.login_pan.Controls.Add(Me.login_txt)
        Me.login_pan.Controls.Add(Me.Label2)
        Me.login_pan.Controls.Add(Me.pass_txt)
        Me.login_pan.ForeColor = System.Drawing.Color.Wheat
        Me.login_pan.Location = New System.Drawing.Point(84, 39)
        Me.login_pan.Name = "login_pan"
        Me.login_pan.Size = New System.Drawing.Size(540, 289)
        Me.login_pan.TabIndex = 5
        '
        'reg_btn
        '
        Me.reg_btn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.reg_btn.Location = New System.Drawing.Point(198, 214)
        Me.reg_btn.Name = "reg_btn"
        Me.reg_btn.Size = New System.Drawing.Size(129, 23)
        Me.reg_btn.TabIndex = 5
        Me.reg_btn.Text = "Register"
        Me.reg_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(711, 393)
        Me.Controls.Add(Me.login_pan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.login_pan.ResumeLayout(False)
        Me.login_pan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents login_pan As System.Windows.Forms.Panel
    Friend WithEvents reg_btn As System.Windows.Forms.Button

End Class
