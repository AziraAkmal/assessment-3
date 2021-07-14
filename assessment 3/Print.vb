
Public Class Print
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strprint As String
        strprint = "READ OBRITE LIBRARY" & vbCrLf
        strprint = strprint & "------------------------------" & vbCrLf
        strprint = strprint & "NO       : ROL1234567890" & vbCrLf
        strprint = strprint & "  " & vbCrLf
        strprint = strprint & "BOOK ID    FINES     PAID" & vbCrLf
        strprint = strprint & "---------------------------" & vbCrLf
        strprint = strprint & "'" + latereturn.TextBox7.Text + "'         '" + latereturn.TextBox6.Text + "'        '" + latereturn.TextBox4.Text + "'   " & vbCrLf
        strprint = strprint & "---------------------------" & vbCrLf
        strprint = strprint & "CHANGE                  '" + latereturn.TextBox8.Text + "' " & vbCrLf
        strprint = strprint & "  " & vbCrLf
        strprint = strprint & "  " & vbCrLf
        strprint = strprint & "  " & vbCrLf
        strprint = strprint & "          THANK YOU          " & vbCrLf
        strprint = strprint & "   HOPE TO SEE YOU AGAIN!   " & vbCrLf
        Printer.print(strprint)
    End Sub


End Class