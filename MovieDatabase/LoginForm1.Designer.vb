<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm1
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
    Friend WithEvents SignIN As System.Windows.Forms.Button
    Friend WithEvents BtnRegister As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Me.SignIN = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AquaCinemaDataSet1 = New GalaxyCinemas.AquaCinemaDataSet1()
        Me.UserLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        UsernameLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.BackColor = System.Drawing.Color.Transparent
        UsernameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        UsernameLabel1.Location = New System.Drawing.Point(342, 98)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(96, 20)
        UsernameLabel1.TabIndex = 6
        UsernameLabel1.Text = "&Username:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.BackColor = System.Drawing.Color.Transparent
        PasswordLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        PasswordLabel1.Location = New System.Drawing.Point(342, 155)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(91, 20)
        PasswordLabel1.TabIndex = 7
        PasswordLabel1.Text = "&Password:"
        '
        'SignIN
        '
        Me.SignIN.BackColor = System.Drawing.Color.Transparent
        Me.SignIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SignIN.Location = New System.Drawing.Point(447, 216)
        Me.SignIN.Name = "SignIN"
        Me.SignIN.Size = New System.Drawing.Size(78, 38)
        Me.SignIN.TabIndex = 3
        Me.SignIN.Text = "Sign &In"
        Me.SignIN.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnRegister.Location = New System.Drawing.Point(346, 216)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(87, 38)
        Me.BtnRegister.TabIndex = 4
        Me.BtnRegister.Text = "&Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'AquaCinemaDataSet1
        '
        Me.AquaCinemaDataSet1.DataSetName = "AquaCinemaDataSet1"
        Me.AquaCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserLoginBindingSource
        '
        Me.UserLoginBindingSource.DataMember = "UserLogin"
        Me.UserLoginBindingSource.DataSource = Me.AquaCinemaDataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.MoviesTableAdapter = Nothing
        Me.TableAdapterManager.tblBookingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSeatsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GalaxyCinemas.AquaCinemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserLoginTableAdapter = Nothing
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLoginBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(342, 121)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(178, 26)
        Me.UsernameTextBox.TabIndex = 7
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLoginBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(342, 178)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(176, 26)
        Me.PasswordTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GalaxyCinemas.My.Resources.Resources.Movies
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._58857db099ec2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(500, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(346, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Forgot my password"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.SignIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnRegister
        Me.ClientSize = New System.Drawing.Size(543, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(PasswordLabel1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.SignIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquaCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents AquaCinemaDataSet1 As AquaCinemaDataSet1
    Friend WithEvents UserLoginBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As AquaCinemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
