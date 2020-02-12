Imports System.Data.SqlClient
Public Class AddDepartmentBudget
    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim reader As SqlDataReader


    Private Sub SubmitBudget(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("UPDATE deptbudget SET dbudget=@dbudget where dname='" & dname_cb.Text & "'", sqlconnection)
            With sqlCmd.Parameters
                .Add(New SqlParameter("@dbudget", dbudget_txt.Text.ToString()))
            End With
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Department Budget inserted")
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



    Private Sub dstream_cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dstream_cb.SelectedIndexChanged
        Try
            dname_cb.Items.Clear()
            DatabaseConnection()
            sqlCmd = New SqlCommand("Select dname from deptbudget where dname='" & dstream_cb.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            While reader.Read
                dname_cb.Items.Add(reader("dname").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dname_cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dname_cb.SelectedIndexChanged
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Select dhodname from deptbudget where dname='" & dname_cb.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            If reader.Read Then
                dhodname_txt.Text = reader("dhodname").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class