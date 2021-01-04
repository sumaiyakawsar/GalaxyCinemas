Imports System.Data.SqlClient
Public Class MainStaffPage
    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Dim connect As New SqlConnection(str)
    Dim da As New SqlDataAdapter("SELECT * FROM Movies", connect)
    Dim dt As New DataTable()

    Private Sub MoviesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AquaCinemaDataSet1)

    End Sub

    Private Sub MainStaffPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddMovie.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim DeleteData As String
        Dim row As Integer
        Dim MovieNam As String

        row = DataGridView1.CurrentRow.Index
        MovieNam = DataGridView1(0, row).Value

        Dim message As String
        message = MsgBox("Are you sure you want to delete this data? ", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub

        End If
        DeleteData = "DELETE from Movies where MovieName = '" & MovieNam & "'"
        ExecuteQuery(DeleteData)
        loadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm1.Close()
        Dim mainForm As New LoginForm1
        mainForm.Show()
        Me.Hide()
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
            MessageBox.Show("Error: " & err.Message)
        End Try
    End Sub

    Public Sub loadData()
        If connect.State = ConnectionState.Open Then connect.Close()
        connect.Open()
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        connect.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim DeleteallBooking As String = "DELETE from tblBookings"
        ExecuteQuery(DeleteallBooking)
        Dim message As String
        message = MsgBox("Are you sure you want to delete all the bookings? ", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub

        End If

    End Sub
End Class