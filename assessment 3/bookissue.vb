Imports System.Data.SqlClient
Public Class bookissue
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub bookissue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrow1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
        disp_book()
        disp_borrower()
    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrow1"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView3.DataSource = dt
    End Sub

    Public Sub disp_book()
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()

        cmd1 = con1.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "select * from bookd"
        cmd1.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da1 As New SqlDataAdapter(cmd1)
        da1.Fill(dt1)
        DataGridView1.DataSource = dt1
    End Sub

    Public Sub disp_borrower()
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand

        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If
        con2.Open()

        cmd2 = con2.CreateCommand()
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "select * from borrower"
        cmd2.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd2)
        da2.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim con1 As New SqlConnection
        Dim selected As DataGridViewRow

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        selected = DataGridView1.Rows(e.RowIndex)
        book_id.Text = selected.Cells(1).Value
        TextBox2.Text = selected.Cells(3).Value

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim con2 As New SqlConnection
        Dim selected2 As DataGridViewRow

        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        selected2 = DataGridView2.Rows(e.RowIndex)
        TextBox3.Text = selected2.Cells(1).Value
        borrower_id.Text = selected2.Cells(2).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd = New SqlCommand(" INSERT INTO borrow1(book_id, borrower_id, issue_date, due_date, return_date, late_return_status) values(' " & book_id.Text & "','" & borrower_id.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & DateTimePicker2.Value.ToShortDateString & "' ,null ,null)", con)

        cmd.ExecuteNonQuery()
            MsgBox("Successfully issued!", MsgBoxStyle.Information, "Success")

            book_id.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            borrower_id.Clear()


        disp_data()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        borrower.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        homepage.Show()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim setissuedate As String
        setissuedate = DateTimePicker1.Value()

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim setduedate As String
        setduedate = DateTimePicker2.Value()
    End Sub
End Class