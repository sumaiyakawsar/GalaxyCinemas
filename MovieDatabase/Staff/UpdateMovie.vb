Imports System.Data.SqlClient

Public Class UpdateMovie

    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CC215 Visual Basic.net\Projects\MovieDatabase\MovieDatabase\AquaCinema.mdf"
    Dim conn As New SqlConnection(str)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim Stttt As String = "UPDATE Movies set MovieName = '" & MovieNameTextBox.Text & "', Director = '" & DirectorTextBox.Text & "', Rating = '" & RatingComboBox.Text & "', Price = " & PriceComboBox.Text & ", Genre =  '" & GenreComboBox.Text & "', Description = '" & DescriptionTextBox.Text & "', Cinema = '" & CinemaComboBox.Text & "' WHERE MovieID = " & IDlbl.Text & ""

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New SqlCommand(Stttt, conn)
            Try
                cmd.ExecuteScalar().ToString()

                If cmd.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Updated the database Sucessfully.")
                Else
                    MessageBox.Show("There is some problem")
                End If
            Catch err As Exception
                MessageBox.Show("Error: " & err.Message)
            End Try

            Dim da As New SqlDataAdapter("SELECT * FROM Movies", conn)
            Dim dt As New DataTable()
            dt.Clear()
            da.Fill(dt)
            MainStaffPage.DataGridView1.DataSource = dt

            conn.Close()

        Catch err As Exception
            MessageBox.Show("Error: " & err.Message)
        End Try
        Me.Close()
    End Sub

    Public Sub UpdateMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AquaCinemaDataSet1.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.AquaCinemaDataSet11.Movies)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MainStaffPage.Show()
        Me.Hide()
    End Sub
End Class