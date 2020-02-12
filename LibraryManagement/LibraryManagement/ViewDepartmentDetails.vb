Public Class ViewDepartmentDetails

    Private Sub ViewDepartmentDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryManagementDataSet.deptbudget' table. You can move, or remove it, as needed.
        Me.DeptbudgetTableAdapter.Fill(Me.LibraryManagementDataSet.deptbudget)

    End Sub
End Class