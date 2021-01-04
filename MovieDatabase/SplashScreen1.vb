Public Class SplashScreen1
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

        Else
            ProgressBar1.Value += 1
            Label1.Text = ProgressBar1.Value & " %"
        End If
    End Sub


End Class
