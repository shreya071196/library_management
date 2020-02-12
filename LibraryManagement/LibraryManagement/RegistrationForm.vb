Imports System.Data.SqlClient

Public Class RegistrationForm
    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd1 As SqlCommand
    Dim reader As SqlDataReader
    Dim sql As String
    Dim flag1 As Integer = 0
    Dim flag2 As Integer = 0
    Dim flag3 As Integer = 0
    Dim userid As String


    Private Sub sub_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_but.Click
        DatabaseConnection()
        NullCheck()
        PassCheck()
        UserNameValidation()
        PersonalDetailsCheck()
        InsertData()

    End Sub

    Public Sub NullCheck()
        If name_txt.Text = "" Or contact_txt.Text = "" Or email_txt.Text = "" Or username_txt.Text = "" Or pass_txt.Text = "" Or conpass_txt.Text = "" Then
            MessageBox.Show("Please enter all details")
            flag1 = 0
        Else
            flag1 = 1
        End If
    End Sub

    Public Sub PassCheck()
        If pass_txt.Text <> conpass_txt.Text Then
            flag2 = 0
            MessageBox.Show("passwords do not match")
        Else
            flag2 = 1
        End If
    End Sub

    Public Sub UserNameValidation()
        Try
            sqlCmd1 = New SqlCommand(" Select username from login where userid='" & username_txt.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd1.ExecuteReader()
            If reader.Read Then
                userid = reader("username").ToString()
                If username_txt.ToString() = userid Then
                    MessageBox.Show("username already exists", "login error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    username_txt.Text = ""
                    username_txt.Focus()
                    flag3 = 0
                End If
            Else
                flag3 = 1
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub PersonalDetailsCheck()
        If contact_txt.Text <> 10 Then
            MsgBox("please enter valid mobile number")
        End If
        If Today.Date < join_date.Value.Date Then
            MsgBox("Invalid join date")
        End If

    End Sub

    Public Sub InsertData()
        If flag1 = 1 Then
            Try
                sqlCmd1 = New SqlCommand("Insert into empdetails values(@name,@contact,@emailid,@desig,@joindate,@username,@password)", sqlconnection)
                With sqlCmd1.Parameters
                    .Add(New SqlParameter("@name", name_txt.Text.ToString()))
                    .Add(New SqlParameter("@contact", CType(contact_txt.Text, Int64)))
                    .Add(New SqlParameter("@emailid", email_txt.Text.ToString()))
                    .Add(New SqlParameter("@desig", desig_combo.Text.ToString()))
                    .Add(New SqlParameter("@joindate", join_date.Value.Date))
                    .Add(New SqlParameter("@username", username_txt.Text.ToString()))
                    .Add(New SqlParameter("@password", pass_txt.Text.ToString()))

                End With
                sqlCmd1.ExecuteNonQuery()

                sqlCmd1 = New SqlCommand("Insert into login values(@username,@password,@usertype)", sqlconnection)
                With sqlCmd1.Parameters
                    .Add(New SqlParameter("@username", username_txt.Text.ToString()))
                    .Add(New SqlParameter("@password", pass_txt.Text.ToString()))
                    .Add(New SqlParameter("@usertype", usertype_combo.Text.ToString()))
                End With
                sqlCmd1.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Public Sub DatabaseConnection()
        Try
            connectionString = "Data Source=DESKTOP-CPRIKBM\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;"
            sqlconnection = New SqlConnection(connectionString)
            sqlconnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        desig_combo.SelectedItem = "Cashier"
        usertype_combo.SelectedItem = "admin"
    End Sub
End Class