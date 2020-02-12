Imports System.Data.SqlClient
Public Class AddDepartment

    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim reader As SqlDataReader
    Dim flag1 As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NullCheck()
        If flag1 = 1 Then
            InsertDepartmentDetails()
        End If
    End Sub


    Public Sub NullCheck()
        If dname_txt.Text = "" Or dhodname_txt.Text = "" Or dstream_cb.Text = "" Then
            MessageBox.Show("One or more fields are empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flag1 = 0
        Else
            flag1 = 1
        End If
    End Sub
    Public Sub InsertDepartmentDetails()
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Insert into deptbudget(did,dstream,dname,dhodname) values(@did,@dstream,@dname,@dhodname)", sqlconnection)
            With sqlCmd.Parameters
                Dim id As Integer = 1
                .Add(New SqlParameter("@did", CType(id, Integer)))
                .Add(New SqlParameter("@dstream", dstream_cb.Text))
                .Add(New SqlParameter("@dname", dname_txt.Text.ToString()))
                .Add(New SqlParameter("@dhodname", dhodname_txt.Text.ToString()))
            End With
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Department Details inserted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlCmd.Dispose()
            sqlconnection.Close()
        End Try
    End Sub

    Public Sub DatabaseConnection()
        Try
            connectionString = "Data Source=DESKTOP-CPRIKBM\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;"
            sqlconnection = New SqlConnection(connectionString)
            sqlconnection.Open()
        Catch ex As Exception
            MsgBox("Connection unsuccesful")
        End Try
    End Sub
End Class