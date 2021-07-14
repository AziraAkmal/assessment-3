Public Class homepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Thank you for using our system --by AzMK")
        Application.Exit()
    End Sub

    Private Sub DETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETAILSToolStripMenuItem.Click
        bookdetails.Show()
    End Sub

    Private Sub DETAILSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DETAILSToolStripMenuItem1.Click
        borrower.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem.Click
        bookissue.Show()
    End Sub

    Private Sub RETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETURNToolStripMenuItem.Click
        bookreturn.Show()
    End Sub

    Private Sub DETAILSToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DETAILSToolStripMenuItem2.Click
        userinfo.Show()
    End Sub

    Private Sub LATERETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LATERETURNToolStripMenuItem.Click
        latereturn.Show()
    End Sub


    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label4.Text = login.TextBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")

    End Sub


End Class