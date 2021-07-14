Imports System.Data.SqlClient

Public Class latereturn
    Dim con As New SqlConnection
    Dim con1 As New SqlConnection
    Dim con2 As New SqlConnection
    Dim con3 As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub latereturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\fine.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()


        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrow1.mdf;Integrated Security=True"
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()


        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If
        con2.Open()


        con3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        If con3.State = ConnectionState.Open Then
            con3.Close()
        End If
        con3.Open()

        disp_late()
        disp_fine()
        disp_borrower()
    End Sub


    Public Sub disp_late()
        cmd = con1.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrow1 where return_date = null OR late_return_status ='YES' "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Public Sub disp_fine()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from fine"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView3.DataSource = dt
    End Sub

    Public Sub disp_borrower()
        cmd = con2.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrower"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView7.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = con2.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrower where name ='" + TextBox1.Text + "' or ic ='" + TextBox2.Text + "'"
        If (TextBox1.Text = "") And (TextBox2.Text = "") Then
            MessageBox.Show("Please enter the BORROWER'S NAME or BORROWER'S IC")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Search!", MsgBoxStyle.Information, "Success")

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView7.DataSource = dt

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        TextBox5.Text = "COMPLETED"

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update fine set date_of_payment= @date ,payment = '" + TextBox5.Text + "'where Id=" & i & ""
        cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.Date)

        If (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MessageBox.Show("Please enter the BORROW ID, FINES PAYMENT AND PAYMENT DATE")
        Else
            cmd.ExecuteNonQuery()

            TextBox8.Text = Convert.ToInt32(TextBox4.Text) - Convert.ToInt32(TextBox6.Text)

            MsgBox("Successfully Paid!", MsgBoxStyle.Information, "Success")
            disp_fine()

            Dim r As DialogResult = MessageBox.Show("Do you want a receipt?", "Important Question", MessageBoxButtons.YesNo)

            If (r = DialogResult.Yes) Then
                Print.Show()
            Else
                Me.Show()
            End If
        End If



    End Sub


    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(DataGridView3.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from fine where Id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                TextBox3.Text = dr.GetString(1).ToString()
                TextBox6.Text = dr.GetInt32(2).ToString()

            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim selected2 As DataGridViewRow

        selected2 = DataGridView2.Rows(e.RowIndex)
        TextBox7.Text = selected2.Cells(1).Value
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        homepage.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            cmd = con2.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select name, ic, ph_num from borrower where ic ='" + TextBox3.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt1 As New DataTable()
            Dim da1 As New SqlDataAdapter(cmd)
            da1.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch EX As Exception
        End Try

        Try
            cmd = con3.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select isbn,year,title,author,publisher from bookd where isbn ='" & TextBox7.Text & "'"
            cmd.ExecuteNonQuery()

            Dim dt2 As New DataTable()
            Dim da2 As New SqlDataAdapter(cmd)
            da2.Fill(dt2)
            DataGridView4.DataSource = dt2
        Catch EX As Exception
        End Try


        Try
            cmd = con1.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select issue_date, due_date from borrow1 where borrower_id = '" + TextBox3.Text + "' AND book_id ='" + TextBox7.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView5.DataSource = dt
        Catch EX As Exception
        End Try

        Try
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select late_return_fines from fine where borrow_id = '" + TextBox3.Text + "'"
            cmd.ExecuteNonQuery()

            Dim dt3 As New DataTable()
            Dim da3 As New SqlDataAdapter(cmd)
            da3.Fill(dt3)
            DataGridView6.DataSource = dt3
            con.Close()
        Catch EX As Exception
        End Try

    End Sub


End Class