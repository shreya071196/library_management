<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.reg_pan = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.desig_combo = New System.Windows.Forms.ComboBox()
        Me.desig_txt = New System.Windows.Forms.Label()
        Me.join_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contact_txt = New System.Windows.Forms.TextBox()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.usertype_combo = New System.Windows.Forms.ComboBox()
        Me.conpass_txt = New System.Windows.Forms.TextBox()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sub_but = New System.Windows.Forms.Button()
        Me.can_but = New System.Windows.Forms.Button()
        Me.reg_pan.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'reg_pan
        '
        Me.reg_pan.BackColor = System.Drawing.Color.DarkCyan
        Me.reg_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.reg_pan.Controls.Add(Me.Panel1)
        Me.reg_pan.Controls.Add(Me.desig_combo)
        Me.reg_pan.Controls.Add(Me.desig_txt)
        Me.reg_pan.Controls.Add(Me.join_date)
        Me.reg_pan.Controls.Add(Me.Label8)
        Me.reg_pan.Controls.Add(Me.email_txt)
        Me.reg_pan.Controls.Add(Me.Label5)
        Me.reg_pan.Controls.Add(Me.Label2)
        Me.reg_pan.Controls.Add(Me.Label1)
        Me.reg_pan.Controls.Add(Me.contact_txt)
        Me.reg_pan.Controls.Add(Me.name_txt)
        Me.reg_pan.Location = New System.Drawing.Point(12, 24)
        Me.reg_pan.Name = "reg_pan"
        Me.reg_pan.Size = New System.Drawing.Size(717, 207)
        Me.reg_pan.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(22, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 102)
        Me.Panel1.TabIndex = 1
        '
        'desig_combo
        '
        Me.desig_combo.AllowDrop = True
        Me.desig_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.desig_combo.FormattingEnabled = True
        Me.desig_combo.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.desig_combo.Location = New System.Drawing.Point(477, 85)
        Me.desig_combo.Name = "desig_combo"
        Me.desig_combo.Size = New System.Drawing.Size(121, 21)
        Me.desig_combo.TabIndex = 18
        '
        'desig_txt
        '
        Me.desig_txt.AutoSize = True
        Me.desig_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desig_txt.Location = New System.Drawing.Point(356, 85)
        Me.desig_txt.Name = "desig_txt"
        Me.desig_txt.Size = New System.Drawing.Size(80, 16)
        Me.desig_txt.TabIndex = 17
        Me.desig_txt.Text = "Designation"
        '
        'join_date
        '
        Me.join_date.Location = New System.Drawing.Point(166, 132)
        Me.join_date.Name = "join_date"
        Me.join_date.Size = New System.Drawing.Size(195, 20)
        Me.join_date.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Date Of Joining"
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(166, 78)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(100, 20)
        Me.email_txt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contact Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'contact_txt
        '
        Me.contact_txt.Location = New System.Drawing.Point(477, 34)
        Me.contact_txt.Name = "contact_txt"
        Me.contact_txt.Size = New System.Drawing.Size(100, 20)
        Me.contact_txt.TabIndex = 1
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(166, 27)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(100, 20)
        Me.name_txt.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.usertype_combo)
        Me.Panel2.Controls.Add(Me.conpass_txt)
        Me.Panel2.Controls.Add(Me.pass_txt)
        Me.Panel2.Controls.Add(Me.username_txt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(12, 294)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 166)
        Me.Panel2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(388, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Confirm Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(418, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "UserType"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(75, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Password"
        '
        'usertype_combo
        '
        Me.usertype_combo.AllowDrop = True
        Me.usertype_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usertype_combo.FormattingEnabled = True
        Me.usertype_combo.Items.AddRange(New Object() {"admin", "employee"})
        Me.usertype_combo.Location = New System.Drawing.Point(510, 27)
        Me.usertype_combo.Name = "usertype_combo"
        Me.usertype_combo.Size = New System.Drawing.Size(121, 21)
        Me.usertype_combo.TabIndex = 4
        '
        'conpass_txt
        '
        Me.conpass_txt.Location = New System.Drawing.Point(510, 77)
        Me.conpass_txt.Name = "conpass_txt"
        Me.conpass_txt.Size = New System.Drawing.Size(121, 20)
        Me.conpass_txt.TabIndex = 3
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(168, 77)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(100, 20)
        Me.pass_txt.TabIndex = 2
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(168, 31)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(100, 20)
        Me.username_txt.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "UserName"
        '
        'sub_but
        '
        Me.sub_but.Location = New System.Drawing.Point(285, 483)
        Me.sub_but.Name = "sub_but"
        Me.sub_but.Size = New System.Drawing.Size(75, 23)
        Me.sub_but.TabIndex = 8
        Me.sub_but.Text = "Submit"
        Me.sub_but.UseVisualStyleBackColor = True
        '
        'can_but
        '
        Me.can_but.Location = New System.Drawing.Point(435, 483)
        Me.can_but.Name = "can_but"
        Me.can_but.Size = New System.Drawing.Size(75, 23)
        Me.can_but.TabIndex = 9
        Me.can_but.Text = "Cancel"
        Me.can_but.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(784, 535)
        Me.Controls.Add(Me.can_but)
        Me.Controls.Add(Me.sub_but)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.reg_pan)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.reg_pan.ResumeLayout(False)
        Me.reg_pan.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reg_pan As System.Windows.Forms.Panel
    Friend WithEvents contact_txt As System.Windows.Forms.TextBox
    Friend WithEvents name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents desig_combo As System.Windows.Forms.ComboBox
    Friend WithEvents desig_txt As System.Windows.Forms.Label
    Friend WithEvents join_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents usertype_combo As System.Windows.Forms.ComboBox
    Friend WithEvents conpass_txt As System.Windows.Forms.TextBox
    Friend WithEvents pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents sub_but As System.Windows.Forms.Button
    Friend WithEvents can_but As System.Windows.Forms.Button
End Class
