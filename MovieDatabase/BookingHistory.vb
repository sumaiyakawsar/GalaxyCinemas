Imports System.Data.SqlClient
Public Class BookingHistory
    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Dim connect As New SqlConnection(str)
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Connect.State = ConnectionState.Open Then Connect.Close()
            Connect.Open()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM tblBookings where Username = '" & UserNLbl.Text & "'", connect)
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerMainPage.Show()
        Me.Hide()
    End Sub
End Class