Imports System.Data.SqlClient

Public Class TicketBuyingScreen

    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Dim connect As New SqlConnection(str)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SelectSeatsButton.Click
        BookingSeats.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CustomerMainPage.Show()
        Me.Hide()
    End Sub

    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click
        If Len(CinemaBox.Text) > 0 And Len(MovieComboBox.Text) > 0 Then
            If Len(DateComboBox.Text) > 0 And Len(TimeComboBox.Text) > 0 Then
                If Len(SeatsLabel.Text) > 0 And Len(PaymentMethod.Text) > 0 Then
                    Try
                        If connect.State = ConnectionState.Open Then connect.Close()
                        connect.Open()
                        Dim cmd As New SqlCommand("INSERT INTO tblBookings (Username, Seat,Movie, Date, Time, Cinema)
                                    VALUES(@username, @seat, @movie, @date, @time, @cinema)", connect)
                        Dim da As New SqlDataAdapter("SELECT * FROM tblBookings", connect)
                        Dim dt As New DataTable()

                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = LoginForm1.UsernameTextBox.Text
                        cmd.Parameters.Add("@seat", SqlDbType.VarChar).Value = seatl.Text
                        cmd.Parameters.Add("@movie", SqlDbType.VarChar).Value = MovieComboBox.Text
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateComboBox.Text
                        cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = TimeComboBox.Text
                        cmd.Parameters.Add("@cinema", SqlDbType.VarChar).Value = CinemaBox.Text


                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Booked Successfully", vbInformation, "BOOKED")
                        Else
                            MsgBox("There is some problem", vbInformation, "WARNING")
                        End If

                        dt.Clear()
                        da.Fill(dt)
                        BookingHistory.DataGridView1.DataSource = dt

                        connect.Close()
                    Catch err As Exception
                        MsgBox("Error: " & err.Message, vbExclamation, "ERROR")
                    End Try
                    SummaryTickets.Show()
                    Me.Hide()

                Else
                    MsgBox("Please select a Seat ", vbExclamation, "WARNING")
                End If
            Else
                MsgBox("Please Select Date and Time ", vbExclamation, "WARNING")
            End If
        Else
            MsgBox("Please Select Cinema and Movie to watch ", vbExclamation, "WARNING")

        End If
    End Sub


    Private Sub TicketBuyingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeatsLabel.Text = ""
        seatl.Text = ""
        Me.MoviesTableAdapter.Fill(Me.AquaCinemaDataSet1.Movies)

        If PaymentMethod.Items.Count > 0 Then
            PaymentMethod.SelectedIndex = 0
        End If
        If DateComboBox.Items.Count > 0 Then
            DateComboBox.SelectedIndex = 0
        End If
        If TimeComboBox.Items.Count > 0 Then
            TimeComboBox.SelectedIndex = 0
        End If
        If connect.State = ConnectionState.Open Then connect.Close()

        connect.Open()

        Dim cmd As New SqlCommand("SELECT DISTINCT Cinema from Movies;", connect)

        Dim adap As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        MainStaffPage.loadData()
        adap.Fill(table)
        CinemaBox.DisplayMember = "Cinema"
        CinemaBox.DataSource = table

        connect.Close()

        If connect.State = ConnectionState.Open Then connect.Close()
        connect.Open()
        Dim cmd2 As New SqlCommand("SELECT DISTINCT MovieName from Movies;", connect)
        Dim adap2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable()
        MainStaffPage.loadData()
        adap2.Fill(table2)
        MovieComboBox.DisplayMember = "MovieName"
        MovieComboBox.DataSource = table2

        connect.Close()
    End Sub
End Class
