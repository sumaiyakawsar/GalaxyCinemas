<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainStaffPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainStaffPage))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet1 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovieName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoviesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.MoviesTableAdapter()
        Me.TableAdapterManager = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(72, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Movie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.Location = New System.Drawing.Point(72, 163)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(123, 38)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "Delete Movie"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.AquaCinemaDataSet1
        '
        'AquaCinemaDataSet1
        '
        Me.AquaCinemaDataSet1.DataSetName = "AquaCinemaDataSet1"
        Me.AquaCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back1
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DeleteButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back1
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(720, 364)
        Me.SplitContainer1.SplitterDistance = 272
        Me.SplitContainer1.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 341)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(272, 23)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(84, 18)
        Me.ToolStripStatusLabel1.Text = "Galaxy Cinemas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 45)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hi, Admin"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(48, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 38)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete All Bookings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._58857db099ec21
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(95, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 66)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieName, Me.DirectorDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MoviesBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.Size = New System.Drawing.Size(444, 361)
        Me.DataGridView1.TabIndex = 11
        '
        'MovieName
        '
        Me.MovieName.DataPropertyName = "MovieName"
        Me.MovieName.HeaderText = "MovieName"
        Me.MovieName.Name = "MovieName"
        '
        'DirectorDataGridViewTextBoxColumn
        '
        Me.DirectorDataGridViewTextBoxColumn.DataPropertyName = "Director"
        Me.DirectorDataGridViewTextBoxColumn.HeaderText = "Director"
        Me.DirectorDataGridViewTextBoxColumn.Name = "DirectorDataGridViewTextBoxColumn"
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        '
        'MoviesBindingSource1
        '
        Me.MoviesBindingSource1.DataMember = "Movies"
        Me.MoviesBindingSource1.DataSource = Me.AquaCinemaDataSet1
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
        'MainStaffPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainStaffPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainStaffPage"
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AquaCinemaDataSet1 As AquaCinemaDataSet1
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As AquaCinemaDataSet1TableAdapters.MoviesTableAdapter
    Friend WithEvents TableAdapterManager As AquaCinemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents MoviesBindingSource1 As BindingSource
    Friend WithEvents MovieName As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
