Imports System.Data.SqlClient

Public Class LoginForm1
    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Public Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignIN.Click
        If Len(UsernameTextBox.Text) <= 0 Then
            MsgBox("Please enter Username!", vbExclamation, "ERROR")
        ElseIf Len(PasswordTextBox.Text) <= 0 Then
            MsgBox("Please enter Password!", vbExclamation, "ERROR")
        End If
        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "12345" Then

                MainStaffPage.Show()
                Me.Hide()

            Else
                Dim SQL As String = "Select * FROM UserLogin WHERE username = '" &
                           UsernameTextBox.Text & "' AND [password] = '" & PasswordTextBox.Text & "' "

                Try
                    Using Connect As New SqlConnection(str)
                        If Connect.State = ConnectionState.Open Then Connect.Close()
                        Connect.Open()
                        Using cmd As SqlCommand = New SqlCommand(SQL, Connect)
                            Dim sdr As SqlDataReader = cmd.ExecuteReader()
                            If (sdr.Read() = True) Then
                                MsgBox("Successful Login", vbInformation, "Congratulations")
                                Dim mainForm As New CustomerMainPage
                                mainForm.Show()
                                CustomerMainPage.WelcomeLbl.Text = "Hi, " & UsernameTextBox.Text
                                BookingHistory.UserNLbl.Text = UsernameTextBox.Text
                                SummaryTickets.Namelbl.Text = UsernameTextBox.Text
                                Me.Hide()
                            Else
                            MsgBox("You dont exist in our Galaxy :(" & vbNewLine & " So Please Register yourself", vbExclamation, "ERROR")
                        End If
                            Connect.Close()
                        End Using
                    End Using
                Catch err As Exception
                    MsgBox("Error: " & err.Message, vbCritical, "ERROR")
                End Try
            End If

    End Sub

    Public Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim RegisterQuery As String = "INSERT INTO UserLogin (Username,Password) VALUES('" & UsernameTextBox.Text & "'," & PasswordTextBox.Text & ")"
        ExecuteQuery(RegisterQuery)
        MsgBox("Registered Sucessfully.", vbInformation, "REGISTER")
    End Sub


    Public Sub ExecuteQuery(query As String)
        Try
            Dim connect As New SqlConnection(str)
            If connect.State = ConnectionState.Open Then connect.Close()
            connect.Open()
            Dim cmd As New SqlCommand(query, connect)
            cmd.ExecuteNonQuery()
            connect.Close()
        Catch err As Exception
            MsgBox("Error: " & err.Message, vbCritical, "ERROR")
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "UPDATE UserLogin set Password= '" & PasswordTextBox.Text & "' where Username = '" & UsernameTextBox.Text & "';"


        Try
            Using Connect As New SqlConnection(str)
                If Connect.State = ConnectionState.Open Then Connect.Close()
                Connect.Open()
                Using cmd As SqlCommand = New SqlCommand(query, Connect)
                    Try
                        If cmd.ExecuteNonQuery() = 1 Then
                            Dim message As String
                            message = MsgBox("Are you sure you want to change your password? ", vbYesNo + vbInformation, "Warning")
                            If message = vbNo Then
                                Exit Sub
                            End If
                            MsgBox("Your Password is changed Successfully", vbInformation, "Congrats")
                        Else
                            MsgBox("Please enter Username!", vbExclamation, "ERROR")
                        End If
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
                    End Try
                End Using
            End Using
        Catch err As Exception
            MsgBox("Error: " & err.Message, vbCritical, "ERROR")
        End Try

    End Sub
End Class
