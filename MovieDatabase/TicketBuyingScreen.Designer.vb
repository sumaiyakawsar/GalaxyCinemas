<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketBuyingScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AquaCinemaDataSet1 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.CinemaBox = New System.Windows.Forms.ComboBox()
        Me.MovieComboBox = New System.Windows.Forms.ComboBox()
        Me.MoviesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectSeatsButton = New System.Windows.Forms.Button()
        Me.SeatsLabel = New System.Windows.Forms.Label()
        Me.PaymentMethod = New System.Windows.Forms.ComboBox()
        Me.TblBookingsTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.tblBookingsTableAdapter()
        Me.TableAdapterManager = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager()
        Me.DateComboBox = New System.Windows.Forms.ComboBox()
        Me.MoviesTableAdapter = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.MoviesTableAdapter()
        Me.seatl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(87, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Movie :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(87, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Cinema :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(87, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Select a Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(87, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select a Payment Method :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(87, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Select a Time :"
        '
        'OKbtn
        '
        Me.OKbtn.BackColor = System.Drawing.Color.Transparent
        Me.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OKbtn.Location = New System.Drawing.Point(348, 236)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(75, 27)
        Me.OKbtn.TabIndex = 5
        Me.OKbtn.Text = "Book"
        Me.OKbtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(3, -5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AquaCinemaDataSet1
        '
        Me.AquaCinemaDataSet1.DataSetName = "AquaCinemaDataSet"
        Me.AquaCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CinemaBox
        '
        Me.CinemaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CinemaBox.FormattingEnabled = True
        Me.CinemaBox.Location = New System.Drawing.Point(273, 40)
        Me.CinemaBox.Name = "CinemaBox"
        Me.CinemaBox.Size = New System.Drawing.Size(121, 21)
        Me.CinemaBox.TabIndex = 9
        '
        'MovieComboBox
        '
        Me.MovieComboBox.FormattingEnabled = True
        Me.MovieComboBox.Location = New System.Drawing.Point(273, 98)
        Me.MovieComboBox.Name = "MovieComboBox"
        Me.MovieComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MovieComboBox.TabIndex = 11
        '
        'MoviesBindingSource1
        '
        Me.MoviesBindingSource1.DataMember = "Movies"
        Me.MoviesBindingSource1.DataSource = Me.AquaCinemaDataSet1BindingSource
        '
        'AquaCinemaDataSet1BindingSource
        '
        Me.AquaCinemaDataSet1BindingSource.DataSource = Me.AquaCinemaDataSet1
        Me.AquaCinemaDataSet1BindingSource.Position = 0
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.AquaCinemaDataSet1BindingSource
        '
        'TimeComboBox
        '
        Me.TimeComboBox.DisplayMember = "Time"
        Me.TimeComboBox.FormattingEnabled = True
        Me.TimeComboBox.Items.AddRange(New Object() {"12:00 PM", "3:00 PM", "7:00 PM", "12:00 AM"})
        Me.TimeComboBox.Location = New System.Drawing.Point(273, 127)
        Me.TimeComboBox.Name = "TimeComboBox"
        Me.TimeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TimeComboBox.TabIndex = 12
        Me.TimeComboBox.ValueMember = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(87, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Select Seats:"
        '
        'SelectSeatsButton
        '
        Me.SelectSeatsButton.BackColor = System.Drawing.Color.Transparent
        Me.SelectSeatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SelectSeatsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSeatsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SelectSeatsButton.Location = New System.Drawing.Point(37, 236)
        Me.SelectSeatsButton.Name = "SelectSeatsButton"
        Me.SelectSeatsButton.Size = New System.Drawing.Size(121, 27)
        Me.SelectSeatsButton.TabIndex = 15
        Me.SelectSeatsButton.Text = "Select Seats"
        Me.SelectSeatsButton.UseVisualStyleBackColor = False
        '
        'SeatsLabel
        '
        Me.SeatsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SeatsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SeatsLabel.Location = New System.Drawing.Point(273, 156)
        Me.SeatsLabel.Name = "SeatsLabel"
        Me.SeatsLabel.Size = New System.Drawing.Size(121, 21)
        Me.SeatsLabel.TabIndex = 16
        '
        'PaymentMethod
        '
        Me.PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentMethod.FormattingEnabled = True
        Me.PaymentMethod.Items.AddRange(New Object() {"Credit Card", "Online Payment", "Google Pay"})
        Me.PaymentMethod.Location = New System.Drawing.Point(273, 185)
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.PaymentMethod.TabIndex = 17
        '
        'TblBookingsTableAdapter
        '
        Me.TblBookingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MoviesTableAdapter = Nothing
        Me.TableAdapterManager.tblBookingsTableAdapter = Me.TblBookingsTableAdapter
        Me.TableAdapterManager.tblSeatsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserLoginTableAdapter = Nothing
        '
        'DateComboBox
        '
        Me.DateComboBox.FormattingEnabled = True
        Me.DateComboBox.Items.AddRange(New Object() {"Mon, 1-APR-2019", "Tue, 02-APR-2019", "Wed, 03-APR-2019", "Thur, 04-APR-2019", "Fri, 05-APR-2019", "Sat, 06-APR-2019", "Sun, 07-APR-2019"})
        Me.DateComboBox.Location = New System.Drawing.Point(273, 69)
        Me.DateComboBox.Name = "DateComboBox"
        Me.DateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DateComboBox.TabIndex = 18
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'seatl
        '
        Me.seatl.AutoSize = True
        Me.seatl.BackColor = System.Drawing.Color.Transparent
        Me.seatl.Enabled = False
        Me.seatl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.seatl.Location = New System.Drawing.Point(414, 156)
        Me.seatl.Name = "seatl"
        Me.seatl.Size = New System.Drawing.Size(0, 13)
        Me.seatl.TabIndex = 19
        Me.seatl.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._5ebc3462a22fb660ec67166f9a7b9420___Copy___Copy
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 30)
        Me.Panel1.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(179, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Buy Tickets"
        '
        'TicketBuyingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back1
        Me.ClientSize = New System.Drawing.Size(458, 281)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.seatl)
        Me.Controls.Add(Me.DateComboBox)
        Me.Controls.Add(Me.PaymentMethod)
        Me.Controls.Add(Me.SeatsLabel)
        Me.Controls.Add(Me.SelectSeatsButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TimeComboBox)
        Me.Controls.Add(Me.MovieComboBox)
        Me.Controls.Add(Me.CinemaBox)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TicketBuyingScreen"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy Tickets"
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OKbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AquaCinemaDataSet1 As AquaCinemaDataSet1
    Friend WithEvents CinemaBox As ComboBox
    Friend WithEvents MovieComboBox As ComboBox
    Friend WithEvents TimeComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SelectSeatsButton As Button
    Friend WithEvents SeatsLabel As Label
    Friend WithEvents PaymentMethod As ComboBox
    Friend WithEvents TblBookingsTableAdapter As AquaCinemaDataSet1TableAdapters.tblBookingsTableAdapter
    Friend WithEvents TableAdapterManager As AquaCinemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DateComboBox As ComboBox
    Friend WithEvents AquaCinemaDataSet1BindingSource As BindingSource
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As AquaCinemaDataSet1TableAdapters.MoviesTableAdapter
    Friend WithEvents seatl As Label
    Friend WithEvents MoviesBindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
End Class
