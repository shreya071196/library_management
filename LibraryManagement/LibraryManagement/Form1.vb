Imports System.Data.SqlClient
Public Class Form1
    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim reader As SqlDataReader
    Dim sql As String
    Dim user_var, pass_var As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub



    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        Try
            DatabaseConnection()
            If sqlconnection.State = ConnectionState.Closed Then
                sqlconnection.Open()
            End If
            sqlCmd = New SqlCommand("Select username,pass from login where username='" & login_txt.Text.ToString() & "' and pass='" & pass_txt.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            If reader.Read Then
                user_var = reader("username").ToString()
                pass_var = reader("pass").ToString()
            End If

            ValidCheck()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
            sqlconnection.Close()


        End Try
    End Sub

    Private Sub ValidCheck()
        If login_txt.Text = "" And pass_txt.Text = "" Then
            MessageBox.Show("Please Enter ID and Password", "Login Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If login_txt.Text = user_var And pass_txt.Text = pass_var Then
                MessageBox.Show("Welcome Administrator", "Login Sucessfull ", MessageBoxButtons.OK)
                Dim mp As New MainPage
                mp.Show()
                Me.Hide()
            Else
                MessageBox.Show("invalid username or password", "login error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub reg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_btn.Click
        Dim regpg As New RegistrationForm
        regpg.Show()
        Me.Hide()
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
