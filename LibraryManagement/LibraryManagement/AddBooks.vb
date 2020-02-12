Imports System.Data.SqlClient

Public Class AddBooks
    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim reader As SqlDataReader

    Public Sub DatabaseConnection()
        Try
            connectionString = "Data Source=DESKTOP-CPRIKBM\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;"
            sqlconnection = New SqlConnection(connectionString)
            sqlconnection.Open()
        Catch ex As Exception
            MsgBox("connection unsuccessful")
        End Try
    End Sub
    Private Sub AddBooks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DatabaseConnection()
        sqlCmd = New SqlCommand("Select dname from deptbudget", sqlconnection)
        reader = sqlCmd.ExecuteReader()
        While reader.Read
            dept_combo.Items.Add(reader("dname").ToString())
        End While
    End Sub
    Private Sub sub_btn_Click(sender As System.Object, e As System.EventArgs) Handles sub_btn.Click
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Insert into bookdetails(bkid,bkname,bkedition,bkauthor,bknoc,bkdept,bkprice,bkadddate) values(@id,@name,@bked,@bkauthor,@bknoc,@bkdept,@bkprice,@bkdate)", sqlconnection)
            With sqlCmd.Parameters
                .Add(New SqlParameter("@id", bkid_txt.Text.ToString()))
                .Add(New SqlParameter("@name", bkname_txt.Text.ToString()))
                .Add(New SqlParameter("@bked", bked_txt.Text.ToString()))
                .Add(New SqlParameter("@bkauthor", bkauth_txt.Text.ToString()))
                .Add(New SqlParameter("@bknoc", CType(bknoc_txt.Text, Integer)))
                .Add(New SqlParameter("@bkdept", dept_combo.SelectedItem()))
                .Add(New SqlParameter("@bkprice", CType(bkprice_txt.Text.ToString(), Integer)))
                .Add(New SqlParameter("@bkdate", add_date.Value.Date))
                sqlCmd.ExecuteNonQuery()
            End With
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("book added")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class