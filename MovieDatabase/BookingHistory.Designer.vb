<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBookingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet1 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TblBookingsTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.tblBookingsTableAdapter()
        Me.UserNLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.MovieDataGridViewTextBoxColumn, Me.SeatDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBookingsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(12, 46)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.Size = New System.Drawing.Size(547, 313)
        Me.DataGridView1.TabIndex = 11
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieDataGridViewTextBoxColumn
        '
        Me.MovieDataGridViewTextBoxColumn.DataPropertyName = "Movie"
        Me.MovieDataGridViewTextBoxColumn.HeaderText = "Movie"
        Me.MovieDataGridViewTextBoxColumn.Name = "MovieDataGridViewTextBoxColumn"
        Me.MovieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeatDataGridViewTextBoxColumn
        '
        Me.SeatDataGridViewTextBoxColumn.DataPropertyName = "Seat"
        Me.SeatDataGridViewTextBoxColumn.HeaderText = "Seat"
        Me.SeatDataGridViewTextBoxColumn.Name = "SeatDataGridViewTextBoxColumn"
        Me.SeatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblBookingsBindingSource
        '
        Me.TblBookingsBindingSource.DataMember = "tblBookings"
        Me.TblBookingsBindingSource.DataSource = Me.AquaCinemaDataSet1
        '
        'AquaCinemaDataSet1
        '
        Me.AquaCinemaDataSet1.DataSetName = "AquaCinemaDataSet1"
        Me.AquaCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(0, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TblBookingsTableAdapter
        '
        Me.TblBookingsTableAdapter.ClearBeforeFill = True
        '
        'UserNLbl
        '
        Me.UserNLbl.AutoSize = True
        Me.UserNLbl.BackColor = System.Drawing.Color.Transparent
        Me.UserNLbl.Enabled = False
        Me.UserNLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UserNLbl.Location = New System.Drawing.Point(538, 7)
        Me.UserNLbl.Name = "UserNLbl"
        Me.UserNLbl.Size = New System.Drawing.Size(0, 13)
        Me.UserNLbl.TabIndex = 13
        Me.UserNLbl.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._5ebc3462a22fb660ec67166f9a7b9420___Copy___Copy1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UserNLbl)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 40)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(93, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Movies you travelled through in this galaxy"
        '
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.ClientSize = New System.Drawing.Size(570, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookingHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookingHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents AquaCinemaDataSet1 As AquaCinemaDataSet1
    Friend WithEvents TblBookingsBindingSource As BindingSource
    Friend WithEvents TblBookingsTableAdapter As AquaCinemaDataSet1TableAdapters.tblBookingsTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
