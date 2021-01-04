Imports System.Data.SqlClient

Public Class BookingSeats
    Dim SelectedSeat As New System.Drawing.Bitmap(My.Resources.Selected)
    Dim EmptySeat As New System.Drawing.Bitmap(My.Resources.Unselected)
    Dim ReservedSeat As New System.Drawing.Bitmap(My.Resources.Reserved)

    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Dim ImageTag As Integer

    Public Sub MyButton_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click,
    Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click,
    Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click,
    Button40.Click, Button41.Click, Button42.Click
        Try
            Dim myButton = DirectCast(sender, Button)
            If myButton.BackgroundImage IsNot ReservedSeat Then
                If (ImageTag = 0) Then
                    myButton.BackgroundImage = SelectedSeat
                    ImageTag = 1

                ElseIf (ImageTag = 1) Then
                    myButton.BackgroundImage = EmptySeat
                    ImageTag = 0

                End If
            End If
        Catch er As Exception
            MsgBox("Error: " & er.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Public Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim c As Control
        Dim BSelected As Boolean
        Dim str As String
        Dim aSeat As Integer


        Try
            For Each c In Me.Controls
                If TypeOf (c) Is Button Then
                    If CType(c, Button).BackgroundImage Is SelectedSeat Then
                        BSelected = True
                        str = c.AccessibleName
                        aSeat = c.AccessibleDescription

                        TicketBuyingScreen.SeatsLabel.Text = str
                        TicketBuyingScreen.seatl.Text = aSeat
                        Exit For
                    End If
                End If
                AddHandler c.Click, AddressOf MyButton_Click

            Next
            If BSelected = False Then
                MsgBox("Please select at least one seat to book", vbCritical, "Warning")
                Exit Sub
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try

    End Sub

    Public Sub BookingSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQL As String = "Select Seat FROM tblBookings"
        Try
            Using Connect As New SqlConnection(str)
                If Connect.State = ConnectionState.Open Then Connect.Close()
                Connect.Open()
                Using cmd As SqlCommand = New SqlCommand(SQL, Connect)

                    Dim dsBookings As New DataSet
                    Dim daBookings As New SqlDataAdapter(cmd)
                    daBookings.Fill(dsBookings, "Bookings")
                    Connect.Close()

                    Dim t1 As DataTable = dsBookings.Tables("Bookings")
                    Dim row As DataRow

                    For Each row In t1.Rows
                        CType(Controls("Button" & row(0)), Button).BackgroundImage = ReservedSeat
                    Next
                End Using
            End Using
        Catch err As Exception
            MsgBox("Error: " & err.Message, vbCritical, "ERROR")
        End Try

    End Sub
End Class