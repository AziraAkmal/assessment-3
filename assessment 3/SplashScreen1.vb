Public NotInheritable Class SplashScreen1


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ApplicationTitle.Text = "WELCOME TO READ OBRITE LIBRARY MANAGEMENT SYSTEM"


        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = System.String.Format(Copyright.Text, My.Application.Info.Copyright, My.Application.Info.Copyright)
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        Form1.Show()

    End Sub


End Class
