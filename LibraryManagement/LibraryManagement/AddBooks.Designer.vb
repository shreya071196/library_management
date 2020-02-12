<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBooks
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
        Me.bkid_txt = New System.Windows.Forms.TextBox()
        Me.bkname_txt = New System.Windows.Forms.TextBox()
        Me.bked_txt = New System.Windows.Forms.TextBox()
        Me.bkauth_txt = New System.Windows.Forms.TextBox()
        Me.bknoc_txt = New System.Windows.Forms.TextBox()
        Me.bkprice_txt = New System.Windows.Forms.TextBox()
        Me.sub_btn = New System.Windows.Forms.Button()
        Me.can_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.add_date = New System.Windows.Forms.DateTimePicker()
        Me.dept_combo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'bkid_txt
        '
        Me.bkid_txt.Location = New System.Drawing.Point(63, 41)
        Me.bkid_txt.Name = "bkid_txt"
        Me.bkid_txt.Size = New System.Drawing.Size(100, 20)
        Me.bkid_txt.TabIndex = 0
        '
        'bkname_txt
        '
        Me.bkname_txt.Location = New System.Drawing.Point(232, 41)
        Me.bkname_txt.Name = "bkname_txt"
        Me.bkname_txt.Size = New System.Drawing.Size(100, 20)
        Me.bkname_txt.TabIndex = 1
        '
        'bked_txt
        '
        Me.bked_txt.Location = New System.Drawing.Point(407, 40)
        Me.bked_txt.Name = "bked_txt"
        Me.bked_txt.Size = New System.Drawing.Size(100, 20)
        Me.bked_txt.TabIndex = 2
        '
        'bkauth_txt
        '
        Me.bkauth_txt.Location = New System.Drawing.Point(567, 41)
        Me.bkauth_txt.Name = "bkauth_txt"
        Me.bkauth_txt.Size = New System.Drawing.Size(100, 20)
        Me.bkauth_txt.TabIndex = 3
        '
        'bknoc_txt
        '
        Me.bknoc_txt.Location = New System.Drawing.Point(63, 128)
        Me.bknoc_txt.Name = "bknoc_txt"
        Me.bknoc_txt.Size = New System.Drawing.Size(100, 20)
        Me.bknoc_txt.TabIndex = 4
        '
        'bkprice_txt
        '
        Me.bkprice_txt.Location = New System.Drawing.Point(407, 127)
        Me.bkprice_txt.Name = "bkprice_txt"
        Me.bkprice_txt.Size = New System.Drawing.Size(100, 20)
        Me.bkprice_txt.TabIndex = 6
        '
        'sub_btn
        '
        Me.sub_btn.Location = New System.Drawing.Point(250, 242)
        Me.sub_btn.Name = "sub_btn"
        Me.sub_btn.Size = New System.Drawing.Size(75, 23)
        Me.sub_btn.TabIndex = 8
        Me.sub_btn.Text = "submit"
        Me.sub_btn.UseVisualStyleBackColor = True
        '
        'can_btn
        '
        Me.can_btn.Location = New System.Drawing.Point(407, 242)
        Me.can_btn.Name = "can_btn"
        Me.can_btn.Size = New System.Drawing.Size(75, 23)
        Me.can_btn.TabIndex = 9
        Me.can_btn.Text = "Cancel"
        Me.can_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Book Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "edition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "author"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "No. Of copies"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "department"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(348, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 30)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Book Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(522, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date"
        '
        'add_date
        '
        Me.add_date.Location = New System.Drawing.Point(567, 127)
        Me.add_date.Name = "add_date"
        Me.add_date.Size = New System.Drawing.Size(191, 20)
        Me.add_date.TabIndex = 18
        '
        'dept_combo
        '
        Me.dept_combo.FormattingEnabled = True
        Me.dept_combo.Location = New System.Drawing.Point(232, 126)
        Me.dept_combo.Name = "dept_combo"
        Me.dept_combo.Size = New System.Drawing.Size(100, 21)
        Me.dept_combo.TabIndex = 19
        '
        'AddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 360)
        Me.Controls.Add(Me.dept_combo)
        Me.Controls.Add(Me.add_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.can_btn)
        Me.Controls.Add(Me.sub_btn)
        Me.Controls.Add(Me.bkprice_txt)
        Me.Controls.Add(Me.bknoc_txt)
        Me.Controls.Add(Me.bkauth_txt)
        Me.Controls.Add(Me.bked_txt)
        Me.Controls.Add(Me.bkname_txt)
        Me.Controls.Add(Me.bkid_txt)
        Me.Name = "AddBooks"
        Me.Text = "AddBooks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bkid_txt As System.Windows.Forms.TextBox
    Friend WithEvents bkname_txt As System.Windows.Forms.TextBox
    Friend WithEvents bked_txt As System.Windows.Forms.TextBox
    Friend WithEvents bkauth_txt As System.Windows.Forms.TextBox
    Friend WithEvents bknoc_txt As System.Windows.Forms.TextBox
    Friend WithEvents bkprice_txt As System.Windows.Forms.TextBox
    Friend WithEvents sub_btn As System.Windows.Forms.Button
    Friend WithEvents can_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents add_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dept_combo As System.Windows.Forms.ComboBox
End Class
