Imports System.Data.SqlClient
Public Class bookdetails
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub bookdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\bookd.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from bookd"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim dr As SqlDataReader
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from bookd where isbn= '" & isbn.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Book is already in the system", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand(" INSERT INTO bookd values(' " & isbn.Text & "','" & year.Text & "','" & title.Text & "','" & author.Text & "','" & publisher.Text & "','" & category.Text & "')", con)
            If (isbn.Text = "" Or year.Text = "" Or title.Text = "" Or author.Text = "" Or publisher.Text = "" Or category.Text = "") Then
                MessageBox.Show("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added!", MsgBoxStyle.Information, "Success")

                isbn.Clear()
                year.Clear()
                title.Clear()
                author.Clear()
                publisher.Clear()
                category.Clear()

            End If
        End If

        disp_data()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles search.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from bookd where isbn='" + isbn.Text + "' and title='" + title.Text + "' or author='" + author.Text + "'"
        If (isbn.Text = "" And (title.Text = "" Or author.Text = "")) Then
            MessageBox.Show("Please enter the ISBN and either the TITLE or AUTHOR of the book")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Search!", MsgBoxStyle.Information, "Success")

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        End If

        isbn.Clear()
        year.Clear()
        title.Clear()
        author.Clear()
        publisher.Clear()
        category.Clear()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from bookd where Id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                isbn.Text = dr.GetString(1).ToString()
                year.Text = dr.GetString(2).ToString()
                title.Text = dr.GetString(3).ToString()
                author.Text = dr.GetString(4).ToString()
                publisher.Text = dr.GetString(5).ToString()
                category.Text = dr.GetString(6).ToString()
            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles updte.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update bookd set isbn='" + isbn.Text + "',year='" + year.Text + "',title='" + title.Text + "',author='" + author.Text + "',publisher='" + publisher.Text + "',category='" + category.Text + "' where Id=" & i & ""
        cmd.ExecuteNonQuery()
        MsgBox("Update Successfully", MsgBoxStyle.Information, "Success")
        disp_data()

        isbn.Clear()
        year.Clear()
        title.Clear()
        author.Clear()
        publisher.Clear()
        category.Clear()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from bookd where isbn='" & isbn.Text & "'"
        If (isbn.Text = "") Then
            MessageBox.Show("Please enter the ISBN of the book")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Delete Successfully", MsgBoxStyle.Information, "Success")
            disp_data()

        End If
        isbn.Clear()
    End Sub


    Private Sub List_Click(sender As Object, e As EventArgs) Handles list.Click
        disp_data()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        homepage.Show()
    End Sub


End Class