<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PosterLabel As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim RatingLabel1 As System.Windows.Forms.Label
        Dim PriceLabel1 As System.Windows.Forms.Label
        Dim GenreLabel1 As System.Windows.Forms.Label
        Dim DirectorLabel As System.Windows.Forms.Label
        Dim ReleaseDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim MovieNameLabel As System.Windows.Forms.Label
        Dim CinemaLabel As System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PosterPictureBox = New System.Windows.Forms.PictureBox()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet1 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceComboBox = New System.Windows.Forms.ComboBox()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.DirectorTextBox = New System.Windows.Forms.TextBox()
        Me.RatingComboBox = New System.Windows.Forms.ComboBox()
        Me.ReleaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.MoviesTableAdapter()
        Me.TableAdapterManager = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager()
        Me.MovieNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CinemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        PosterLabel = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        RatingLabel1 = New System.Windows.Forms.Label()
        PriceLabel1 = New System.Windows.Forms.Label()
        GenreLabel1 = New System.Windows.Forms.Label()
        DirectorLabel = New System.Windows.Forms.Label()
        ReleaseDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        MovieNameLabel = New System.Windows.Forms.Label()
        CinemaLabel = New System.Windows.Forms.Label()
        CType(Me.PosterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PosterLabel
        '
        PosterLabel.AutoSize = True
        PosterLabel.BackColor = System.Drawing.Color.Transparent
        PosterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PosterLabel.ForeColor = System.Drawing.Color.White
        PosterLabel.Location = New System.Drawing.Point(349, 63)
        PosterLabel.Name = "PosterLabel"
        PosterLabel.Size = New System.Drawing.Size(57, 16)
        PosterLabel.TabIndex = 29
        PosterLabel.Text = "Poster:"
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.AutoSize = True
        DescriptionLabel1.BackColor = System.Drawing.Color.Transparent
        DescriptionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        DescriptionLabel1.Location = New System.Drawing.Point(25, 271)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(71, 17)
        DescriptionLabel1.TabIndex = 36
        DescriptionLabel1.Text = "Summary:"
        '
        'RatingLabel1
        '
        RatingLabel1.AutoSize = True
        RatingLabel1.BackColor = System.Drawing.Color.Transparent
        RatingLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RatingLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        RatingLabel1.Location = New System.Drawing.Point(25, 115)
        RatingLabel1.Name = "RatingLabel1"
        RatingLabel1.Size = New System.Drawing.Size(53, 17)
        RatingLabel1.TabIndex = 38
        RatingLabel1.Text = "Rating:"
        '
        'PriceLabel1
        '
        PriceLabel1.AutoSize = True
        PriceLabel1.BackColor = System.Drawing.Color.Transparent
        PriceLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        PriceLabel1.Location = New System.Drawing.Point(25, 141)
        PriceLabel1.Name = "PriceLabel1"
        PriceLabel1.Size = New System.Drawing.Size(44, 17)
        PriceLabel1.TabIndex = 40
        PriceLabel1.Text = "Price:"
        '
        'GenreLabel1
        '
        GenreLabel1.AutoSize = True
        GenreLabel1.BackColor = System.Drawing.Color.Transparent
        GenreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenreLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        GenreLabel1.Location = New System.Drawing.Point(25, 167)
        GenreLabel1.Name = "GenreLabel1"
        GenreLabel1.Size = New System.Drawing.Size(52, 17)
        GenreLabel1.TabIndex = 42
        GenreLabel1.Text = "Genre:"
        '
        'DirectorLabel
        '
        DirectorLabel.AutoSize = True
        DirectorLabel.BackColor = System.Drawing.Color.Transparent
        DirectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DirectorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DirectorLabel.Location = New System.Drawing.Point(25, 89)
        DirectorLabel.Name = "DirectorLabel"
        DirectorLabel.Size = New System.Drawing.Size(62, 17)
        DirectorLabel.TabIndex = 48
        DirectorLabel.Text = "Director:"
        '
        'ReleaseDateLabel
        '
        ReleaseDateLabel.AutoSize = True
        ReleaseDateLabel.BackColor = System.Drawing.Color.Transparent
        ReleaseDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReleaseDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ReleaseDateLabel.Location = New System.Drawing.Point(25, 219)
        ReleaseDateLabel.Name = "ReleaseDateLabel"
        ReleaseDateLabel.Size = New System.Drawing.Size(98, 17)
        ReleaseDateLabel.TabIndex = 51
        ReleaseDateLabel.Text = "Release Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.BackColor = System.Drawing.Color.Transparent
        EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EndDateLabel.Location = New System.Drawing.Point(25, 245)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(71, 17)
        EndDateLabel.TabIndex = 52
        EndDateLabel.Text = "End Date:"
        '
        'MovieNameLabel
        '
        MovieNameLabel.AutoSize = True
        MovieNameLabel.BackColor = System.Drawing.Color.Transparent
        MovieNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MovieNameLabel.Location = New System.Drawing.Point(25, 63)
        MovieNameLabel.Name = "MovieNameLabel"
        MovieNameLabel.Size = New System.Drawing.Size(90, 17)
        MovieNameLabel.TabIndex = 53
        MovieNameLabel.Text = "Movie Name:"
        '
        'CinemaLabel
        '
        CinemaLabel.AutoSize = True
        CinemaLabel.BackColor = System.Drawing.Color.Transparent
        CinemaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CinemaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CinemaLabel.Location = New System.Drawing.Point(25, 196)
        CinemaLabel.Name = "CinemaLabel"
        CinemaLabel.Size = New System.Drawing.Size(59, 17)
        CinemaLabel.TabIndex = 55
        CinemaLabel.Text = "Cinema:"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnadd.Location = New System.Drawing.Point(420, 368)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(99, 43)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PosterPictureBox
        '
        Me.PosterPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PosterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PosterPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MoviesBindingSource, "Poster", True))
        Me.PosterPictureBox.Location = New System.Drawing.Point(352, 78)
        Me.PosterPictureBox.Name = "PosterPictureBox"
        Me.PosterPictureBox.Size = New System.Drawing.Size(167, 203)
        Me.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PosterPictureBox.TabIndex = 30
        Me.PosterPictureBox.TabStop = False
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.AquaCinemaDataSet1
        '
        'AquaCinemaDataSet1
        '
        Me.AquaCinemaDataSet1.DataSetName = "AquaCinemaDataSet"
        Me.AquaCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(124, 273)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 78)
        Me.DescriptionTextBox.TabIndex = 37
        '
        'PriceComboBox
        '
        Me.PriceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Price", True))
        Me.PriceComboBox.FormattingEnabled = True
        Me.PriceComboBox.Items.AddRange(New Object() {"10", "18", "20", "25"})
        Me.PriceComboBox.Location = New System.Drawing.Point(124, 141)
        Me.PriceComboBox.Name = "PriceComboBox"
        Me.PriceComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PriceComboBox.TabIndex = 41
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Genre", True))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"Action", "Animation", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Sci-Fi", "Superhero", "Thriller"})
        Me.GenreComboBox.Location = New System.Drawing.Point(124, 168)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GenreComboBox.TabIndex = 43
        '
        'DirectorTextBox
        '
        Me.DirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Director", True))
        Me.DirectorTextBox.Location = New System.Drawing.Point(124, 88)
        Me.DirectorTextBox.Name = "DirectorTextBox"
        Me.DirectorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DirectorTextBox.TabIndex = 49
        '
        'RatingComboBox
        '
        Me.RatingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Rating", True))
        Me.RatingComboBox.FormattingEnabled = True
        Me.RatingComboBox.Items.AddRange(New Object() {"G", "PG", "PG-13", "R", "NC-17"})
        Me.RatingComboBox.Location = New System.Drawing.Point(124, 114)
        Me.RatingComboBox.Name = "RatingComboBox"
        Me.RatingComboBox.Size = New System.Drawing.Size(200, 21)
        Me.RatingComboBox.TabIndex = 20
        '
        'ReleaseDateDateTimePicker
        '
        Me.ReleaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "ReleaseDate", True))
        Me.ReleaseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReleaseDateDateTimePicker.Location = New System.Drawing.Point(124, 221)
        Me.ReleaseDateDateTimePicker.Name = "ReleaseDateDateTimePicker"
        Me.ReleaseDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReleaseDateDateTimePicker.TabIndex = 52
        '
        'EndDateDateTimePicker
        '
        Me.EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "EndDate", True))
        Me.EndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDateDateTimePicker.Location = New System.Drawing.Point(124, 247)
        Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
        Me.EndDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EndDateDateTimePicker.TabIndex = 53
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.AquaCinemaDataSet1
        Me.BindingSource1.Position = 0
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MoviesTableAdapter = Me.MoviesTableAdapter
        Me.TableAdapterManager.tblBookingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSeatsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserLoginTableAdapter = Nothing
        '
        'MovieNameTextBox
        '
        Me.MovieNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "MovieName", True))
        Me.MovieNameTextBox.Location = New System.Drawing.Point(124, 62)
        Me.MovieNameTextBox.Name = "MovieNameTextBox"
        Me.MovieNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MovieNameTextBox.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 43)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CinemaComboBox
        '
        Me.CinemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Cinema", True))
        Me.CinemaComboBox.FormattingEnabled = True
        Me.CinemaComboBox.Items.AddRange(New Object() {"Midvalley", "Pavilion", "Timesquare", "MyTown"})
        Me.CinemaComboBox.Location = New System.Drawing.Point(124, 195)
        Me.CinemaComboBox.Name = "CinemaComboBox"
        Me.CinemaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CinemaComboBox.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._5ebc3462a22fb660ec67166f9a7b9420___Copy___Copy1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 41)
        Me.Panel1.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(222, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Movie"
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.ClientSize = New System.Drawing.Size(560, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(CinemaLabel)
        Me.Controls.Add(Me.CinemaComboBox)
        Me.Controls.Add(MovieNameLabel)
        Me.Controls.Add(Me.MovieNameTextBox)
        Me.Controls.Add(EndDateLabel)
        Me.Controls.Add(Me.EndDateDateTimePicker)
        Me.Controls.Add(ReleaseDateLabel)
        Me.Controls.Add(Me.ReleaseDateDateTimePicker)
        Me.Controls.Add(DescriptionLabel1)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(RatingLabel1)
        Me.Controls.Add(PriceLabel1)
        Me.Controls.Add(Me.PriceComboBox)
        Me.Controls.Add(GenreLabel1)
        Me.Controls.Add(Me.GenreComboBox)
        Me.Controls.Add(DirectorLabel)
        Me.Controls.Add(Me.DirectorTextBox)
        Me.Controls.Add(Me.RatingComboBox)
        Me.Controls.Add(PosterLabel)
        Me.Controls.Add(Me.PosterPictureBox)
        Me.Controls.Add(Me.btnadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMovie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add A Movie"
        CType(Me.PosterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents AquaCinemaDataSet1 As AquaCinemaDataSet1
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As AquaCinemaDataSet1TableAdapters.MoviesTableAdapter
    Friend WithEvents TableAdapterManager As AquaCinemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PosterPictureBox As PictureBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceComboBox As ComboBox
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents RatingComboBox As ComboBox
    Friend WithEvents ReleaseDateDateTimePicker As DateTimePicker
    Friend WithEvents EndDateDateTimePicker As DateTimePicker
    Friend WithEvents MovieNameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CinemaComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
