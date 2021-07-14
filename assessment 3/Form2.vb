Imports System.Data.SqlClient

Public Class registration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim a As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim number As Integer = 1
        Dim alp As Integer = 1
        If (passwrd.TextLength < 8 Or passwrd.TextLength > 12) Or num.Matches(passwrd.Text).Count < number Or a.Matches(passwrd.Text).Count < alp Then
            MsgBox("Password must have 8-12 characters including alphabets and numbers")
            passwrd.Clear()
        Else

            Try
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\assessment 3\assessment 3\user.mdf;Integrated Security=True"
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from register where usernme= '" & usernme.Text & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Username is already registered", MsgBoxStyle.Critical)
                    con.Close()
                Else
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand(" INSERT INTO register values(' " & n.Text & "','" & staffid.Text & "','" & phnum.Text & "','" & usernme.Text & "','" & passwrd.Text & "')", con)
                    If (n.Text = "" And staffid.Text = "" And phnum.Text = "" And usernme.Text = "" And passwrd.Text = "") Then
                        MessageBox.Show("Please enter the details")
                    Else
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfully registered!", MsgBoxStyle.Information, "Success")
                        Hide()
                        login.Show()
                        n.Clear()
                        staffid.Clear()
                        phnum.Clear()
                        usernme.Clear()
                        passwrd.Clear()
                    End If
                    con.Close()
                End If
                con.Close()

            Catch ex As Exception
                MsgBox("Error! the data insert is invalid")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub checkpassword(passwrd As String, Optional ByVal number As Integer = 1, Optional ByVal alp As Integer = 1)
        Dim n As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim a As New System.Text.RegularExpressions.Regex("[A-Z],[a-zReturn False]")

        If Not passwrd.Length > 7 And passwrd.Length < 13 And n.Matches(passwrd).Count < number And a.Matches(passwrd).Count < alp Then
            MsgBox("Password must have 8-12 characters including alphabets and numbers")
        Else

        End If

    End Sub

    Function validatep(ByVal passwrd As String, Optional ByVal minlength As Integer = 8, Optional ByVal maxlength As Integer = 12, Optional ByVal number As Integer = 1, Optional ByVal alp As Integer = 1) As Boolean
        Dim n As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim a As New System.Text.RegularExpressions.Regex("[A-Z],[a-zReturn False]")
        If Len(passwrd) < minlength Or Len(passwrd) > maxlength Then Return False
        If n.Matches(passwrd).Count < number Then Return False
        If a.Matches(passwrd).Count < alp Then Return False

        Return True
    End Function


End Class