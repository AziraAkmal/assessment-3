Imports System.Data.SqlClient

Public Class borrower
    Dim con As New SqlConnection
    Dim con1 As New SqlConnection
    Dim con2 As New SqlConnection
    Dim con3 As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim id As String
    Dim b As String
    Dim sqlquery As String
    Private Sub borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrower.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        con1.Open()
        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\borrow1.mdf;Integrated Security=True"
        con2.Open()
        con3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\fine.mdf;Integrated Security=True"
        con3.Open()

        If con1.State = ConnectionState.Open And con2.State = ConnectionState.Open And con3.State = ConnectionState.Open Then
            con1.Close()
            con2.Close()
            con3.Close()
        End If
        con1.Open()
        con2.Open()
        con3.Open()

        disp_data()
        TextBox5.Text = DataGridView1.RowCount - 1
        disp_title()
    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrower"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt

    End Sub

    Public Sub disp_title()
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()

        cmd1 = con1.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "select Id, title from bookd"
        cmd1.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da1 As New SqlDataAdapter(cmd1)
        da1.Fill(dt1)
        DataGridView1.DataSource = dt1

    End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrower where name='" + nme.Text + "'"
        If (nme.Text = "") Then
            MessageBox.Show("Please enter the borrower's name!")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Search!", MsgBoxStyle.Information, "Success")

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView2.DataSource = dt

        End If

        nme.Clear()
        ic.Clear()
        ph_num.Clear()
        address.Clear()
    End Sub

    Private Sub addd_Click(sender As Object, e As EventArgs) Handles addd.Click
        Dim dr As SqlDataReader
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrower where name= '" & nme.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Borrower is already in the system", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand(" INSERT INTO borrower values(' " & nme.Text & "','" & ic.Text & "','" & ph_num.Text & "','" & address.Text & "')", con)
            If (nme.Text = "" Or ic.Text = "" Or ph_num.Text = "" Or address.Text = "") Then
                MessageBox.Show("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added!", MsgBoxStyle.Information, "Success")

                nme.Clear()
                ic.Clear()
                ph_num.Clear()
                address.Clear()

            End If
        End If

        disp_data()
        TextBox5.Text = DataGridView1.RowCount - 1
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
            cmd.CommandText = "select * from borrower where Id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                nme.Text = dr.GetString(1).ToString()
                ic.Text = dr.GetString(2).ToString()
                ph_num.Text = dr.GetString(3).ToString()
                address.Text = dr.GetString(4).ToString()

            End While

            Dim cm As New SqlCommand

            cm = con2.CreateCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'")
            cm.ExecuteNonQuery()


            Dim dtt As New DataTable()
            Dim daa As New SqlDataAdapter(cm)
            daa.Fill(dtt)
            DataGridView1.DataSource = dtt
            TextBox5.Text = DataGridView1.RowCount - 1

            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 12 Then
                b = "VB"
                id = "12"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 77 Then
                b = "YOLO"
                id = "77"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 45 Then
                b = "IDC"
                id = "45"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 65 Then
                b = "KOKO"
                id = "65"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 90 Then
                b = "HUI"
                id = "90"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 86 Then
                b = "JK"
                id = "86"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 1 Then
                b = "MHA"
                id = "01"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 99 Then
                b = "SUS"
                id = "99"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 31 Then
                b = "LOVE"
                id = "31"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 98 Then
                b = "ONE PIECE"
                id = "98"
            End If
            If ("select book_id from borrow1 where borrower_id = '" + ic.Text + "'") = 11 Then
                b = "HXH"
                id = "11"
            End If

            Dim t As DataTable = TryCast(DataGridView1.DataSource, DataTable)
            t.Columns.Add("title")
            DataGridView1.Rows(0).Cells(1).Value = b
            DataGridView1.Rows(1).Cells(1).Value = b
            DataGridView1.Rows(2).Cells(1).Value = b

        Catch ex As Exception

        End Try

    End Sub
    Private Sub updte_Click(sender As Object, e As EventArgs) Handles updte.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update borrower set name='" + nme.Text + "',ic='" + ic.Text + "',ph_num='" + ph_num.Text + "',address='" + address.Text + "' where Id=" & i & ""
        cmd.ExecuteNonQuery()
        MsgBox("Update Successfully", MsgBoxStyle.Information, "Success")

        disp_data()
        TextBox5.Text = DataGridView1.RowCount - 1

        nme.Clear()
        ic.Clear()
        ph_num.Clear()
        address.Clear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        MessageBox.Show("You just need to insert the name of the borrower")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from borrower where name='" & nme.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Delete Successfully", MsgBoxStyle.Information, "Success")

        disp_data()
        TextBox5.Text = DataGridView1.RowCount - 1
        nme.Clear()
    End Sub

    Private Sub list_Click(sender As Object, e As EventArgs) Handles list.Click


        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()

        cmd = con1.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from bookd where isbn= '" + TextBox2.Text + "' "
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
        cmd.CommandText = "SELECT issue_date, due_date, late_return_status from borrow1 where borrower_id='" + ic.Text + "'"
        cmd.ExecuteNonQuery()
        Dim Sdt As New DataTable()
        Dim Sda As New SqlDataAdapter(cmd)
        Sda.Fill(Sdt)
        DataGridView4.DataSource = Sdt



        If con3.State = ConnectionState.Open Then
            con3.Close()
        End If
        con3.Open()


        Dim returndate As Date = Date.Parse(bookreturn.Date1.Value)
        Dim duedate As Date = Date.Parse(bookissue.DateTimePicker2.Value)
        Dim days As Long = DateDiff(DateInterval.Day, duedate, returndate)

        If days > 0 Then
            TextBox1.Text = days
        End If

        Dim dtt As DataTable = TryCast(DataGridView4.DataSource, DataTable)
        dtt.Columns.Add("overdue_days")
        DataGridView4.Rows(0).Cells(3).Value = TextBox1.Text


        cmd = con3.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT late_return_fines from fine where borrow_id='" + ic.Text + "'"
        cmd.ExecuteNonQuery()
        Dim Sdt2 As New DataTable()
        Dim Sda2 As New SqlDataAdapter(cmd)
        Sda2.Fill(Sdt2)
        DataGridView5.DataSource = Sdt2


    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disp_data()
    End Sub

    Private Sub DataGridView1_CellCClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selected2 As DataGridViewRow

        selected2 = DataGridView1.Rows(e.RowIndex)
        TextBox2.Text = selected2.Cells(0).Value
    End Sub
End Class