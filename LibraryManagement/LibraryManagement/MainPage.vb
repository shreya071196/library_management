Public Class MainPage


    Private Sub issuebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles issuebook.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New IssueBookForm
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New ReturnBook
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    

    Private Sub AddDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDepartmentToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New AddDepartment
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub departbud_mi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departbud_mi.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New AddDepartmentBudget
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ViewDepartmentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDepartmentDetailsToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New ViewDepartmentDetails
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrderToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New OrderBooks
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AddMembersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddMembersToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New AddMember
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub store_mi_Click(sender As System.Object, e As System.EventArgs) Handles store_mi.Click

    End Sub

    Private Sub AddBooksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddBooksToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Dim f1 As New AddBooks
        f1.MdiParent = Me
        f1.Show()
        f1.WindowState = FormWindowState.Maximized
    End Sub
End Class