<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartmentBudget
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dhodname_txt = New System.Windows.Forms.TextBox()
        Me.dbudget_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dstream_cb = New System.Windows.Forms.ComboBox()
        Me.dname_cb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stream :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department HOD Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department Budget"
        '
        'dhodname_txt
        '
        Me.dhodname_txt.Location = New System.Drawing.Point(222, 157)
        Me.dhodname_txt.Name = "dhodname_txt"
        Me.dhodname_txt.ReadOnly = True
        Me.dhodname_txt.Size = New System.Drawing.Size(100, 20)
        Me.dhodname_txt.TabIndex = 7
        '
        'dbudget_txt
        '
        Me.dbudget_txt.Location = New System.Drawing.Point(222, 191)
        Me.dbudget_txt.Name = "dbudget_txt"
        Me.dbudget_txt.Size = New System.Drawing.Size(100, 20)
        Me.dbudget_txt.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dstream_cb
        '
        Me.dstream_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dstream_cb.FormattingEnabled = True
        Me.dstream_cb.Items.AddRange(New Object() {"Arts", "Science", "Commerce"})
        Me.dstream_cb.Location = New System.Drawing.Point(222, 94)
        Me.dstream_cb.Name = "dstream_cb"
        Me.dstream_cb.Size = New System.Drawing.Size(103, 21)
        Me.dstream_cb.TabIndex = 10
        '
        'dname_cb
        '
        Me.dname_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dname_cb.FormattingEnabled = True
        Me.dname_cb.Location = New System.Drawing.Point(222, 124)
        Me.dname_cb.Name = "dname_cb"
        Me.dname_cb.Size = New System.Drawing.Size(103, 21)
        Me.dname_cb.TabIndex = 11
        '
        'AddDepartmentBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 381)
        Me.Controls.Add(Me.dname_cb)
        Me.Controls.Add(Me.dstream_cb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dbudget_txt)
        Me.Controls.Add(Me.dhodname_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddDepartmentBudget"
        Me.Text = "AddDepartmentBudget"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dhodname_txt As System.Windows.Forms.TextBox
    Friend WithEvents dbudget_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dstream_cb As System.Windows.Forms.ComboBox
    Friend WithEvents dname_cb As System.Windows.Forms.ComboBox
End Class
