<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDepartmentDetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DstreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DhodnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DbudgetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptbudgetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryManagementDataSet = New LibraryManagement.LibraryManagementDataSet()
        Me.DeptbudgetTableAdapter = New LibraryManagement.LibraryManagementDataSetTableAdapters.deptbudgetTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptbudgetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DidDataGridViewTextBoxColumn, Me.DstreamDataGridViewTextBoxColumn, Me.DnameDataGridViewTextBoxColumn, Me.DhodnameDataGridViewTextBoxColumn, Me.DbudgetDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DeptbudgetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(497, 231)
        Me.DataGridView1.TabIndex = 0
        '
        'DidDataGridViewTextBoxColumn
        '
        Me.DidDataGridViewTextBoxColumn.DataPropertyName = "did"
        Me.DidDataGridViewTextBoxColumn.HeaderText = "Department ID"
        Me.DidDataGridViewTextBoxColumn.Name = "DidDataGridViewTextBoxColumn"
        Me.DidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DidDataGridViewTextBoxColumn.Visible = False
        '
        'DstreamDataGridViewTextBoxColumn
        '
        Me.DstreamDataGridViewTextBoxColumn.DataPropertyName = "dstream"
        Me.DstreamDataGridViewTextBoxColumn.HeaderText = "Department Stream"
        Me.DstreamDataGridViewTextBoxColumn.Name = "DstreamDataGridViewTextBoxColumn"
        Me.DstreamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DnameDataGridViewTextBoxColumn
        '
        Me.DnameDataGridViewTextBoxColumn.DataPropertyName = "dname"
        Me.DnameDataGridViewTextBoxColumn.HeaderText = "Department Name"
        Me.DnameDataGridViewTextBoxColumn.Name = "DnameDataGridViewTextBoxColumn"
        Me.DnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DhodnameDataGridViewTextBoxColumn
        '
        Me.DhodnameDataGridViewTextBoxColumn.DataPropertyName = "dhodname"
        Me.DhodnameDataGridViewTextBoxColumn.HeaderText = "Head Of Department"
        Me.DhodnameDataGridViewTextBoxColumn.Name = "DhodnameDataGridViewTextBoxColumn"
        Me.DhodnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DbudgetDataGridViewTextBoxColumn
        '
        Me.DbudgetDataGridViewTextBoxColumn.DataPropertyName = "dbudget"
        Me.DbudgetDataGridViewTextBoxColumn.HeaderText = "Department Budget"
        Me.DbudgetDataGridViewTextBoxColumn.Name = "DbudgetDataGridViewTextBoxColumn"
        Me.DbudgetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptbudgetBindingSource
        '
        Me.DeptbudgetBindingSource.DataMember = "deptbudget"
        Me.DeptbudgetBindingSource.DataSource = Me.LibraryManagementDataSet
        '
        'LibraryManagementDataSet
        '
        Me.LibraryManagementDataSet.DataSetName = "LibraryManagementDataSet"
        Me.LibraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeptbudgetTableAdapter
        '
        Me.DeptbudgetTableAdapter.ClearBeforeFill = True
        '
        'ViewDepartmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewDepartmentDetails"
        Me.Text = "ViewDepartmentDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptbudgetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LibraryManagementDataSet As LibraryManagement.LibraryManagementDataSet
    Friend WithEvents DeptbudgetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeptbudgetTableAdapter As LibraryManagement.LibraryManagementDataSetTableAdapters.deptbudgetTableAdapter
    Friend WithEvents DidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DstreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DhodnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DbudgetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
