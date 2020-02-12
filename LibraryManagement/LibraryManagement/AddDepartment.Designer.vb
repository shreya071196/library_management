<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartment
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
        Me.dstream_cb = New System.Windows.Forms.ComboBox()
        Me.dhodname_txt = New System.Windows.Forms.TextBox()
        Me.dname_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dstream_cb
        '
        Me.dstream_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dstream_cb.FormattingEnabled = True
        Me.dstream_cb.Items.AddRange(New Object() {"Arts", "Science", "Commerce"})
        Me.dstream_cb.Location = New System.Drawing.Point(222, 108)
        Me.dstream_cb.Name = "dstream_cb"
        Me.dstream_cb.Size = New System.Drawing.Size(103, 21)
        Me.dstream_cb.TabIndex = 16
        '
        'dhodname_txt
        '
        Me.dhodname_txt.Location = New System.Drawing.Point(223, 171)
        Me.dhodname_txt.Name = "dhodname_txt"
        Me.dhodname_txt.Size = New System.Drawing.Size(100, 20)
        Me.dhodname_txt.TabIndex = 15
        '
        'dname_txt
        '
        Me.dname_txt.Location = New System.Drawing.Point(223, 139)
        Me.dname_txt.Name = "dname_txt"
        Me.dname_txt.Size = New System.Drawing.Size(100, 20)
        Me.dname_txt.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Department HOD Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Department Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Stream :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dstream_cb)
        Me.Controls.Add(Me.dhodname_txt)
        Me.Controls.Add(Me.dname_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddDepartment"
        Me.Text = "AddDepartment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dstream_cb As System.Windows.Forms.ComboBox
    Friend WithEvents dhodname_txt As System.Windows.Forms.TextBox
    Friend WithEvents dname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
