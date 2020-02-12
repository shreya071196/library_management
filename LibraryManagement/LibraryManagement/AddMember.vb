Public Class AddMember

    Private Sub AddMember_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryManagementDataSet1.bookdetails' table. You can move, or remove it, as needed.
        Me.BookdetailsTableAdapter.Fill(Me.LibraryManagementDataSet1.bookdetails)

    End Sub
End Class