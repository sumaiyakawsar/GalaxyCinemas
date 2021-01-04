<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMainPage))
        Me.AboutUsBtn = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WelcomeLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutUsBtn
        '
        Me.AboutUsBtn.BackColor = System.Drawing.Color.Transparent
        Me.AboutUsBtn.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Border2
        Me.AboutUsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutUsBtn.FlatAppearance.BorderSize = 0
        Me.AboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutUsBtn.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutUsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutUsBtn.Location = New System.Drawing.Point(374, 82)
        Me.AboutUsBtn.Name = "AboutUsBtn"
        Me.AboutUsBtn.Size = New System.Drawing.Size(59, 58)
        Me.AboutUsBtn.TabIndex = 0
        Me.AboutUsBtn.Text = "?"
        Me.AboutUsBtn.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.Transparent
        Me.LogOutButton.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources._58857db099ec2
        Me.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogOutButton.Location = New System.Drawing.Point(12, 342)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(58, 58)
        Me.LogOutButton.TabIndex = 3
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Waltograph UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 53)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Welcome to our Galaxy"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Algerian", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button3.Location = New System.Drawing.Point(37, 138)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(248, 61)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Buy Tickets"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Algerian", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button4.Location = New System.Drawing.Point(37, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(318, 61)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Booking History"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.AboutUsBtn)
        Me.Panel1.Controls.Add(Me.WelcomeLbl)
        Me.Panel1.Controls.Add(Me.LogOutButton)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 412)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(726, 76)
        Me.Panel2.TabIndex = 10
        '
        'WelcomeLbl
        '
        Me.WelcomeLbl.AutoSize = True
        Me.WelcomeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WelcomeLbl.Location = New System.Drawing.Point(31, 89)
        Me.WelcomeLbl.Name = "WelcomeLbl"
        Me.WelcomeLbl.Size = New System.Drawing.Size(0, 31)
        Me.WelcomeLbl.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(439, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 319)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CustomerMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerMainPAge"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutUsBtn As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeLbl As Label
    Friend WithEvents Panel2 As Panel
End Class
