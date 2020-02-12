<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LibraryManagementDataSet1 = New LibraryManagement.LibraryManagementDataSet1()
        Me.BookdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdetailsTableAdapter = New LibraryManagement.LibraryManagementDataSet1TableAdapters.bookdetailsTableAdapter()
        CType(Me.LibraryManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(303, 71)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(490, 70)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'LibraryManagementDataSet1
        '
        Me.LibraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1"
        Me.LibraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookdetailsBindingSource
        '
        Me.BookdetailsBindingSource.DataMember = "bookdetails"
        Me.BookdetailsBindingSource.DataSource = Me.LibraryManagementDataSet1
        '
        'BookdetailsTableAdapter
        '
        Me.BookdetailsTableAdapter.ClearBeforeFill = True
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 348)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "AddMember"
        Me.Text = "AddMember"
        CType(Me.LibraryManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents LibraryManagementDataSet1 As LibraryManagement.LibraryManagementDataSet1
    Friend WithEvents BookdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookdetailsTableAdapter As LibraryManagement.LibraryManagementDataSet1TableAdapters.bookdetailsTableAdapter
End Class
