<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateMovie
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
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim RatingLabel1 As System.Windows.Forms.Label
        Dim PriceLabel1 As System.Windows.Forms.Label
        Dim GenreLabel1 As System.Windows.Forms.Label
        Dim DirectorLabel As System.Windows.Forms.Label
        Dim MovieNameLabel As System.Windows.Forms.Label
        Dim CinemaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateMovie))
        Me.btnadd = New System.Windows.Forms.Button()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet11 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceComboBox = New System.Windows.Forms.ComboBox()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.DirectorTextBox = New System.Windows.Forms.TextBox()
        Me.RatingComboBox = New System.Windows.Forms.ComboBox()
        Me.MovieNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CinemaComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.MoviesTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        RatingLabel1 = New System.Windows.Forms.Label()
        PriceLabel1 = New System.Windows.Forms.Label()
        GenreLabel1 = New System.Windows.Forms.Label()
        DirectorLabel = New System.Windows.Forms.Label()
        MovieNameLabel = New System.Windows.Forms.Label()
        CinemaLabel = New System.Windows.Forms.Label()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.AutoSize = True
        DescriptionLabel1.BackColor = System.Drawing.Color.Transparent
        DescriptionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        DescriptionLabel1.Location = New System.Drawing.Point(14, 234)
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
        RatingLabel1.Location = New System.Drawing.Point(14, 129)
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
        PriceLabel1.Location = New System.Drawing.Point(14, 155)
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
        GenreLabel1.Location = New System.Drawing.Point(14, 181)
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
        DirectorLabel.Location = New System.Drawing.Point(14, 103)
        DirectorLabel.Name = "DirectorLabel"
        DirectorLabel.Size = New System.Drawing.Size(62, 17)
        DirectorLabel.TabIndex = 48
        DirectorLabel.Text = "Director:"
        '
        'MovieNameLabel
        '
        MovieNameLabel.AutoSize = True
        MovieNameLabel.BackColor = System.Drawing.Color.Transparent
        MovieNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovieNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MovieNameLabel.Location = New System.Drawing.Point(14, 77)
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
        CinemaLabel.Location = New System.Drawing.Point(14, 210)
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
        Me.btnadd.Location = New System.Drawing.Point(242, 336)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(99, 43)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Update"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.AquaCinemaDataSet11
        '
        'AquaCinemaDataSet11
        '
        Me.AquaCinemaDataSet11.DataSetName = "AquaCinemaDataSet1"
        Me.AquaCinemaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(113, 236)
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
        Me.PriceComboBox.Location = New System.Drawing.Point(113, 155)
        Me.PriceComboBox.Name = "PriceComboBox"
        Me.PriceComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PriceComboBox.TabIndex = 41
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Genre", True))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"Action", "Animation", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Sci-Fi", "Superhero", "Thriller"})
        Me.GenreComboBox.Location = New System.Drawing.Point(113, 182)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GenreComboBox.TabIndex = 43
        '
        'DirectorTextBox
        '
        Me.DirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Director", True))
        Me.DirectorTextBox.Location = New System.Drawing.Point(113, 102)
        Me.DirectorTextBox.Name = "DirectorTextBox"
        Me.DirectorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DirectorTextBox.TabIndex = 49
        '
        'RatingComboBox
        '
        Me.RatingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Rating", True))
        Me.RatingComboBox.FormattingEnabled = True
        Me.RatingComboBox.Items.AddRange(New Object() {"G", "PG", "PG-13", "R", "NC-17"})
        Me.RatingComboBox.Location = New System.Drawing.Point(113, 128)
        Me.RatingComboBox.Name = "RatingComboBox"
        Me.RatingComboBox.Size = New System.Drawing.Size(200, 21)
        Me.RatingComboBox.TabIndex = 20
        '
        'MovieNameTextBox
        '
        Me.MovieNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "MovieName", True))
        Me.MovieNameTextBox.Location = New System.Drawing.Point(113, 76)
        Me.MovieNameTextBox.Name = "MovieNameTextBox"
        Me.MovieNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MovieNameTextBox.TabIndex = 54
        Me.MovieNameTextBox.WordWrap = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(-1, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 39)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CinemaComboBox
        '
        Me.CinemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Cinema", True))
        Me.CinemaComboBox.FormattingEnabled = True
        Me.CinemaComboBox.Items.AddRange(New Object() {"Midvalley", "Pavilion", "Timesquare", "MyTown"})
        Me.CinemaComboBox.Location = New System.Drawing.Point(113, 209)
        Me.CinemaComboBox.Name = "CinemaComboBox"
        Me.CinemaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CinemaComboBox.TabIndex = 56
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.BindingNavigator1.BindingSource = Me.MoviesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 41)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(374, 25)
        Me.BindingNavigator1.TabIndex = 57
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.AquaCinemaDataSet11
        Me.BindingSource1.Position = 0
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 41)
        Me.Panel1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(108, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Update Details"
        '
        'IDlbl
        '
        Me.IDlbl.BackColor = System.Drawing.Color.Transparent
        Me.IDlbl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "MovieID", True))
        Me.IDlbl.Enabled = False
        Me.IDlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IDlbl.Location = New System.Drawing.Point(30, 331)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(180, 51)
        Me.IDlbl.TabIndex = 59
        Me.IDlbl.Visible = False
        '
        'UpdateMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.ClientSize = New System.Drawing.Size(374, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(CinemaLabel)
        Me.Controls.Add(Me.CinemaComboBox)
        Me.Controls.Add(MovieNameLabel)
        Me.Controls.Add(Me.MovieNameTextBox)
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
        Me.Controls.Add(Me.btnadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateMovie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add A Movie"
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As Button
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceComboBox As ComboBox
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents RatingComboBox As ComboBox
    Friend WithEvents MovieNameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CinemaComboBox As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MoviesTableAdapter As AquaCinemaDataSet1TableAdapters.MoviesTableAdapter
    Friend WithEvents AquaCinemaDataSet11 As AquaCinemaDataSet1
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IDlbl As Label
End Class
