Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class SummaryTickets
    Dim booking As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf")
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap
    Public Sub SummaryTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AquaCinemaDataSet1.UserLogin' table. You can move, or remove it, as needed.

        If booking.State = ConnectionState.Open Then booking.Close()
        booking.Open()
        Dim id1 As String = "SELECT Hall from tblSeats where RColumn ='" & TicketBuyingScreen.SeatsLabel.Text & "'"
        Dim cmd2 As New SqlCommand(id1, booking)
        Dim reader As SqlDataReader = cmd2.ExecuteReader()

        Try
            'Namelbl.Text = LoginForm1.UsernameTextBox.Text
            DateLbl.Text = TicketBuyingScreen.DateComboBox.Text
            TimeLbl.Text = TicketBuyingScreen.TimeComboBox.Text
            CinemaLabel.Text = TicketBuyingScreen.CinemaBox.Text
            Moviename.Text = TicketBuyingScreen.MovieComboBox.Text
            LblSeat.Text = TicketBuyingScreen.SeatsLabel.Text
            If reader.HasRows Then
                reader.Read()
                halllbl.Text = reader.Item("Hall")
                reader.Close()
            End If
        Catch err As Exception
            MsgBox("Error: " & err.Message, vbExclamation, "ERROR")
        End Try
        booking.Close()
        If booking.State = ConnectionState.Open Then booking.Close()

        booking.Open()
        Dim id As String = "SELECT Price,Rating from Movies where MovieName ='" & TicketBuyingScreen.MovieComboBox.Text & "'"
        Dim cmd As New SqlCommand(id, booking)
        Dim reader1 As SqlDataReader = cmd.ExecuteReader()
        Try
            If reader1.HasRows Then
                reader1.Read()
                RateLBL.Text = reader1.Item("Rating")
                lblprice.Text = "RM " & reader1.Item("Price")

                Dim Price As Decimal = reader1.Item("Price")

                Dim GST As Decimal = (Price * 0.06)
                LblGST.Text = "RM " & GST.ToString()

                Dim BookingFee As Decimal = 0.5
                BookingFeelbl.Text = "RM " & BookingFee

                Dim Total As Decimal = GST + Price + BookingFee
                LblTotal.Text = "RM " & Total.ToString()
                reader1.Close()
            End If
        Catch err As Exception
            MessageBox.Show("Error: " & err.Message, "ERROR!")
        End Try
        booking.Close()

        If booking.State = ConnectionState.Open Then booking.Close()

        booking.Open()
        Dim id3 As String = "SELECT BookingID from tblBookings where  UserName ='" & LoginForm1.UsernameTextBox.Text & "' AND Seat = (Select SeatID FROM tblSeats WHERE RColumn ='" & TicketBuyingScreen.SeatsLabel.Text & "')"
        Dim cmd3 As New SqlCommand(id3, booking)
        Dim reader3 As SqlDataReader = cmd3.ExecuteReader()
        Try
            If reader3.HasRows Then
                reader3.Read()
                lblBookingID.Text = "Booking ID : " & reader3.Item("BookingID")
                reader3.Close()
            End If
        Catch err As Exception
            MessageBox.Show("Error: " & err.Message)
        End Try
        booking.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Try
            mPrintBitMap = New Bitmap(Me.Width, Me.Height)
            Dim IRect As System.Drawing.Rectangle
            IRect.Width = Me.Width
            IRect.Height = Me.Height
            Me.DrawToBitmap(mPrintBitMap, IRect)
            mPrintDocument = New PrintDocument
            PrintPreviewDialog1.Show()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TicketBuyingScreen.Close()
        BookingSeats.Close()
        Me.Hide()
        CustomerMainPage.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim IWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width)
        Dim IHeight As Integer = e.MarginBounds.Y
        e.Graphics.DrawImage(mPrintBitMap, IWidth, IHeight)
        e.HasMorePages = False
    End Sub
End Class

