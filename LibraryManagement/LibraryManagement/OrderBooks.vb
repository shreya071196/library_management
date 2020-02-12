Imports System.Data.SqlClient

Public Class OrderBooks
    Dim connectionString As String
    Dim sqlconnection As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim reader As SqlDataReader

    Dim noc As Integer = 0
    Dim price As Integer = 0
    Dim finalprice As Integer = 0
    Dim rembud As Integer = 0
    Dim budget As Integer = 0

    Public Sub DatabaseConnection()
        Try
            connectionString = "Data Source=DESKTOP-CPRIKBM\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;"
            sqlconnection = New SqlConnection(connectionString)
            sqlconnection.Open()
        Catch ex As Exception
            MsgBox("connection unsuccessful")
        End Try
    End Sub
    Private Sub OrderBooks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        obbud_txt.ReadOnly = True
        obhod_txt.ReadOnly = True
        obrebud_txt.ReadOnly = True
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Select dstream from deptBudget", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            While reader.Read
                obstream_cb.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertOrder()
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Insert into deptorder(deptname,bud,rembud,bkname,bkedition,bkauthor,bknoc,bkprice) values(@deptname,@bud,@rembud,@bkname,@bkedition,@bkauthor,@bknoc,@bkprice)", sqlconnection)
            With sqlCmd.Parameters
                .Add(New SqlParameter("@deptname", obdeptname_cb.SelectedItem()))
                .Add(New SqlParameter("@bud", CType(obbud_txt.Text, Integer)))
                .Add(New SqlParameter("@rembud", CType(obrebud_txt.Text, Integer)))
                .Add(New SqlParameter("@bkname", bkname_txt.Text.ToString()))
                .Add(New SqlParameter("@bkedition", bked_txt.Text.ToString()))
                .Add(New SqlParameter("@bkauthor", bkauth_txt.Text.ToString()))
                .Add(New SqlParameter("@bknoc", CType(bknoc_txt.Text, Integer)))
                .Add(New SqlParameter("@bkprice", CType(bkprice_txt.Text, Integer)))
            End With
            sqlCmd.ExecuteNonQuery()
            MsgBox("ordered")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Public Sub PriceOfBooksRow1()
        noc = bknoc_txt.Text
        price = bkprice_txt.Text
        finalprice = noc * price
        bkfp_txt.Text = finalprice
        budget = obbud_txt.Text
        rembud = budget - finalprice
        obrebud_txt.Text = rembud
    End Sub

    Public Sub PriceOfBooksRow2()
        If (bkname2_txt.Text = "") Then
            noc = 0
            price = 0
        Else
            noc = bknoc2_txt.Text
            price = bkprice2_txt.Text
            finalprice = noc * price
            bkfp2_txt.Text = finalprice
            budget = obbud_txt.Text
            rembud = budget - finalprice
            obrebud_txt.Text = rembud
        End If
    End Sub
    Public Sub PriceOfBooksRow3()
        If (bkname3_txt.Text = "") Then
            noc = 0
            price = 0
        Else
            noc = bknoc3_txt.Text
            price = bkprice3_txt.Text
            finalprice = noc * price
            bkfp3_txt.Text = finalprice
            budget = obbud_txt.Text
            rembud = budget - finalprice
            obrebud_txt.Text = rembud
        End If
    End Sub
    Public Sub PriceOfBooksRow4()
        If (bkname4_txt.Text = "") Then
            noc = 0
            price = 0
        Else
            noc = bknoc4_txt.Text
            price = bkprice4_txt.Text
            finalprice = noc * price
            bkfp4_txt.Text = finalprice
            budget = obbud_txt.Text
            rembud = budget - finalprice
            obrebud_txt.Text = rembud
        End If
    End Sub




    Private Sub obstream_cb_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles obstream_cb.SelectedIndexChanged
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Select dname from deptbudget where dstream='" & obstream_cb.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            While reader.Read
                obdeptname_cb.Items.Add(reader("dname").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   

    Private Sub obdeptname_cb_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles obdeptname_cb.SelectedIndexChanged
        Try
            DatabaseConnection()
            sqlCmd = New SqlCommand("Select dhodname,dbudget from deptbudget where dname='" & obdeptname_cb.Text.ToString() & "'", sqlconnection)
            reader = sqlCmd.ExecuteReader()
            If reader.Read Then
                obhod_txt.Text = reader("dhodname").ToString()
                obbud_txt.Text = reader("dbudget").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub order_btn_Click(sender As System.Object, e As System.EventArgs) Handles order_btn.Click
        PriceOfBooksRow1()
        PriceOfBooksRow2()
        PriceOfBooksRow3()
        PriceOfBooksRow4()
        InsertOrder()
    End Sub
   
    Private Sub more_btn_Click(sender As System.Object, e As System.EventArgs) Handles more_btn.Click
      
        bkname_txt.Clear()
        bkname2_txt.Clear()
        bkname3_txt.Clear()
        bkname4_txt.Clear()

        bkauth_txt.Clear()
        bkauth2_txt.Clear()
        bkauth3_txt.Clear()
        bkauth4_txt.Clear()

        bked_txt.Clear()
        bked2_txt.Clear()
        bked3_txt.Clear()
        bked4_txt.Clear()

        bknoc_txt.Clear()
        bknoc2_txt.Clear()
        bknoc3_txt.Clear()
        bknoc4_txt.Clear()

        bkprice_txt.Clear()
        bkprice2_txt.Clear()
        bkprice3_txt.Clear()
        bkprice4_txt.Clear()

        bkfp_txt.Clear()
        bkfp2_txt.Clear()
        bkfp3_txt.Clear()
        bkfp4_txt.Clear()
    End Sub
End Class