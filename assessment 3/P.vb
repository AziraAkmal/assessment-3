Public Class Printer
    Private Shared lines As New Queue(Of String)
    Private Shared myfonts As Font
    Private Shared prn As Printing.PrintDocument

    Shared Sub New()
        myfonts = New Font("courier new", 8, FontStyle.Regular, GraphicsUnit.Point)
        prn = New Printing.PrintDocument
        AddHandler prn.PrintPage, AddressOf printpagehandler
    End Sub

    Public Shared Sub print(ByVal text As String)
        Dim linesarray() = text.Split(New String() _
                                      {Environment.NewLine}, StringSplitOptions.None)

        For Each line As String In linesarray
            lines.Enqueue(line)
        Next
        prn.Print()
    End Sub

    Private Shared Sub printpagehandler(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim sf As New StringFormat
        Dim vpos As Single = e.PageSettings.HardMarginY

        Do While lines.Count > 0
            Dim line As String = lines.Dequeue
            Dim sz As SizeF = e.Graphics.MeasureString(line, myfonts, e.PageSettings.Bounds.Size, sf)

            Dim rct As New RectangleF(e.PageSettings.HardMarginX, vpos, e.PageBounds.Width - e.PageSettings.HardMarginX * 2, e.PageBounds.Height - e.PageSettings.HardMarginY * 2)

            e.Graphics.DrawString(line, myfonts, Brushes.Black, rct)
            vpos += sz.Height
            If vpos > e.PageSettings.Bounds.Height - e.PageSettings.HardMarginY * 2 Then
                e.HasMorePages = True
                Exit Sub
            End If
        Loop
    End Sub
End Class
