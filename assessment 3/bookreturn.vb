Imports System.Data.SqlClient

Public Class bookreturn
    Dim con As New SqlConnection
    Dim con1 As New SqlConnection
    Dim con2 As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim Y As Integer
    Private Sub bookreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrow1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        con1.Open()
        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\fine.mdf;Integrated Security=True"
        con2.Open()

        If con1.State = ConnectionState.Open And con2.State = ConnectionState.Open Then
            con1.Close()
            con2.Close()
        End If
        con1.Open()
        con2.Open()

        disp_borrower()
        disp_borrow1()
    End Sub

    Public Sub disp_borrower()
        Dim conn As New SqlConnection
        Dim cmd1 As New SqlCommand

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        cmd1 = conn.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "select * from borrower"
        cmd1.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da1 As New SqlDataAdapter(cmd1)
        da1.Fill(dt1)
        DataGridView1.DataSource = dt1
    End Sub

    Public Sub disp_borrow1()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrow1"
        cmd.ExecuteNonQuery()
        Dim Sdt As New DataTable()
        Dim Sda As New SqlDataAdapter(cmd)
        Sda.Fill(Sdt)
        DataGridView2.DataSource = Sdt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim con2 As New SqlConnection
        Dim selected2 As DataGridViewRow

        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        selected2 = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = selected2.Cells(1).Value
        TextBox2.Text = selected2.Cells(2).Value
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(DataGridView2.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from borrow1 where Id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update borrow1 set book_id = '" + TextBox6.Text + "' ,borrower_id = '" + TextBox2.Text + "' ,issue_date = '" + bookissue.DateTimePicker1.Value.ToShortDateString + "' ,due_date = '" + bookissue.DateTimePicker2.Value.ToShortDateString + "' ,return_date = '" + Date1.Value.ToShortDateString + "' , late_return_status = '" + TextBox4.Text + "' where Id=" & i & ""
        cmd.ExecuteNonQuery()
        MsgBox("Successfully returned!", MsgBoxStyle.Information, "Success")

        disp_borrow1()

        If TextBox4.Text = "YES" Then
            cmd = con2.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand(" INSERT INTO fine values(' " & TextBox2.Text & "',' " & TextBox5.Text & "',' " & TextBox3.Text & "',null)", con2)

            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        latereturn.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Date1.ValueChanged
        Dim returndate As Date = Date.Parse(Date1.Value)
        Dim duedate As Date = Date.Parse(bookissue.DateTimePicker2.Value)
        Dim days As Long = DateDiff(DateInterval.Day, duedate, returndate)

        If days > 0 Then
            TextBox4.Text = "YES"
            TextBox3.Text = "PENDING"
            TextBox5.Text = days + 1
            MsgBox("You have late return fines that need to be settled! You can click the LATE RETURN button to directly pay your fines")
        Else
            TextBox4.Text = "NO"
        End If
    End Sub

    Public Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        If (CheckedListBox1.SelectedItem = "VB") Then
            Y = 12
        ElseIf (CheckedListBox1.SelectedItem = "YOLO") Then
            Y = 77
        ElseIf (CheckedListBox1.SelectedItem = "IDC") Then
            CheckedListBox1.Text = 45
        ElseIf (CheckedListBox1.SelectedItem = "KOKO") Then
            Y = 65
        ElseIf (CheckedListBox1.SelectedItem = "HUI") Then
            Y = 90
        ElseIf (CheckedListBox1.SelectedItem = "JK") Then
            Y = 86
        ElseIf (CheckedListBox1.SelectedItem = "MHA") Then
            Y = 1
        ElseIf (CheckedListBox1.SelectedItem = "SUS") Then
            Y = 99
        ElseIf (CheckedListBox1.SelectedItem = "LOVE") Then
            Y = 31
        ElseIf (CheckedListBox1.SelectedItem = "ONE PIECE") Then
            Y = 98
        ElseIf (CheckedListBox1.SelectedItem = "HXH") Then
            Y = 11
        Else

        End If

        TextBox6.Text = Y
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT issue_date, due_date, late_return_status from borrow1 where book_id = '" + TextBox6.Text + "' and borrower_id='" + TextBox2.Text + "'"
        cmd.ExecuteNonQuery()
        Dim Sdt As New DataTable()
        Dim Sda As New SqlDataAdapter(cmd)
        Sda.Fill(Sdt)
        DataGridView2.DataSource = Sdt


        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()

        cmd = con1.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT isbn, year, title, author, publisher from bookd where isbn='" + TextBox6.Text + "'"
        cmd.ExecuteNonQuery()
        Dim Sdt1 As New DataTable()
        Dim Sda1 As New SqlDataAdapter(cmd)
        Sda1.Fill(Sdt1)
        DataGridView3.DataSource = Sdt1


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If
        con2.Open()

        cmd = con2.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT late_return_fines from fine where borrow_id = '" + TextBox2.Text + "'"
        cmd.ExecuteNonQuery()
        Dim Sdt2 As New DataTable()
        Dim Sda2 As New SqlDataAdapter(cmd)
        Sda2.Fill(Sdt2)
        DataGridView4.DataSource = Sdt2
    End Sub


End Class