
Imports System.Data.SqlClient

Public Class CustomerMainPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AboutUsBtn.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TicketBuyingScreen.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        LoginForm1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        LoginForm1.Close()
        TicketBuyingScreen.Close()
        SummaryTickets.Close()
        BookingHistory.Close()
        BookingSeats.Close()
        Dim mainForm As New LoginForm1
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BookingHistory.ShowDialog()

    End Sub
End Class