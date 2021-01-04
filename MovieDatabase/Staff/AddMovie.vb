Imports System.Data.SqlClient
Imports System.IO

Public Class AddMovie
    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GalaxyCinemas\MovieDatabase\AquaCinema.mdf"
    Dim connect As New SqlConnection(str)
    Private Sub PosterPictureBox_Click(sender As Object, e As EventArgs) Handles PosterPictureBox.Click
        Dim pic As New OpenFileDialog

        pic.Filter = "Choose Image(*.JPG;*.PNG;*.GIF,*.JFIF)|*.jpg;*.png;*.gif"
        If pic.ShowDialog = DialogResult.OK Then
            PosterPictureBox.Image = Image.FromFile(pic.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If connect.State = ConnectionState.Open Then connect.Close()
            connect.Open()
            Dim cmd As New SqlCommand("INSERT INTO Movies (MovieName,Director,Rating,Price,Genre,ReleaseDate,EndDate,Description,Cinema,Poster) 
                                    VALUES(@moviename, @directorname, @rating, @price, @genre, @releasedate, @enddate, @description,@cinema,@poster)", connect)
            Dim da As New SqlDataAdapter("SELECT * FROM Movies", connect)
            Dim dt As New DataTable()
            Dim ms As New MemoryStream
            PosterPictureBox.Image.Save(ms, PosterPictureBox.Image.RawFormat)
            cmd.Parameters.Add("@moviename", SqlDbType.VarChar).Value = MovieNameTextBox.Text
            cmd.Parameters.Add("@directorname", SqlDbType.VarChar).Value = DirectorTextBox.Text
            cmd.Parameters.Add("@rating", SqlDbType.VarChar).Value = RatingComboBox.Text
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceComboBox.Text
            cmd.Parameters.Add("@genre", SqlDbType.VarChar).Value = GenreComboBox.Text
            cmd.Parameters.Add("@releasedate", SqlDbType.Date).Value = ReleaseDateDateTimePicker.Text
            cmd.Parameters.Add("@enddate", SqlDbType.Date).Value = EndDateDateTimePicker.Text
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = DescriptionTextBox.Text
            cmd.Parameters.Add("@cinema", SqlDbType.VarChar).Value = CinemaComboBox.Text
            cmd.Parameters.Add("@poster", SqlDbType.Image).Value = ms.ToArray

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Added To the database Sucessfully.")
            Else
                MessageBox.Show("There is some problem")
            End If
            dt.Clear()
            da.Fill(dt)
            MainStaffPage.DataGridView1.DataSource = dt

            connect.Close()

            Refresh()
        Catch err As Exception
            MessageBox.Show("Error: " & err.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MainStaffPage.Show()
        Me.Hide()
    End Sub

    Private Sub AddMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class