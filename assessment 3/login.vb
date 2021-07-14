Imports System.Data.SqlClient

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\user.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\user.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from register where usernme ='" & TextBox1.Text & "' AND passwrd ='" & TextBox2.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                homepage.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Form1.Show()
                TextBox1.Clear()
                TextBox2.Clear()

            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try

        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class