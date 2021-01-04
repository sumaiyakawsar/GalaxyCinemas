<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SummaryTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryTickets))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RateLBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.halllbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblGST = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.LblSeat = New System.Windows.Forms.Label()
        Me.Moviename = New System.Windows.Forms.Label()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.CinemaLabel = New System.Windows.Forms.Label()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BookingFeelbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(574, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.PrintToFile = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Ticket"
        Me.PrintDocument1.OriginAtMargins = True
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.BackColor = System.Drawing.Color.Transparent
        Me.Namelbl.Font = New System.Drawing.Font("Goudy Old Style", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.ForeColor = System.Drawing.Color.White
        Me.Namelbl.Location = New System.Drawing.Point(28, 213)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(65, 27)
        Me.Namelbl.TabIndex = 2
        Me.Namelbl.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(229, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Movie"
        '
        'DateLbl
        '
        Me.DateLbl.BackColor = System.Drawing.Color.Transparent
        Me.DateLbl.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.Color.White
        Me.DateLbl.Location = New System.Drawing.Point(28, 113)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(187, 20)
        Me.DateLbl.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(229, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Seat Number"
        '
        'RateLBL
        '
        Me.RateLBL.BackColor = System.Drawing.Color.Transparent
        Me.RateLBL.Font = New System.Drawing.Font("Consolas", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RateLBL.ForeColor = System.Drawing.Color.White
        Me.RateLBL.Location = New System.Drawing.Point(534, 224)
        Me.RateLBL.Name = "RateLBL"
        Me.RateLBL.Size = New System.Drawing.Size(141, 48)
        Me.RateLBL.TabIndex = 8
        Me.RateLBL.Text = "rating"
        Me.RateLBL.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(229, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Price"
        '
        'halllbl
        '
        Me.halllbl.BackColor = System.Drawing.Color.Transparent
        Me.halllbl.Font = New System.Drawing.Font("Consolas", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.halllbl.ForeColor = System.Drawing.Color.White
        Me.halllbl.Location = New System.Drawing.Point(576, 66)
        Me.halllbl.Name = "halllbl"
        Me.halllbl.Size = New System.Drawing.Size(99, 58)
        Me.halllbl.TabIndex = 12
        Me.halllbl.Text = "hall"
        Me.halllbl.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(229, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 22)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "GST (6%) "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(229, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Total"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.White
        Me.LblTotal.Location = New System.Drawing.Point(381, 196)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTotal.Size = New System.Drawing.Size(0, 22)
        Me.LblTotal.TabIndex = 21
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGST
        '
        Me.LblGST.AutoSize = True
        Me.LblGST.BackColor = System.Drawing.Color.Transparent
        Me.LblGST.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGST.ForeColor = System.Drawing.Color.White
        Me.LblGST.Location = New System.Drawing.Point(381, 134)
        Me.LblGST.Name = "LblGST"
        Me.LblGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblGST.Size = New System.Drawing.Size(0, 22)
        Me.LblGST.TabIndex = 20
        Me.LblGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(381, 103)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblprice.Size = New System.Drawing.Size(0, 22)
        Me.lblprice.TabIndex = 18
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSeat
        '
        Me.LblSeat.BackColor = System.Drawing.Color.Transparent
        Me.LblSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeat.ForeColor = System.Drawing.Color.White
        Me.LblSeat.Location = New System.Drawing.Point(229, 248)
        Me.LblSeat.Name = "LblSeat"
        Me.LblSeat.Size = New System.Drawing.Size(102, 50)
        Me.LblSeat.TabIndex = 17
        '
        'Moviename
        '
        Me.Moviename.AutoSize = True
        Me.Moviename.BackColor = System.Drawing.Color.Transparent
        Me.Moviename.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moviename.ForeColor = System.Drawing.Color.White
        Me.Moviename.Location = New System.Drawing.Point(381, 72)
        Me.Moviename.Name = "Moviename"
        Me.Moviename.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Moviename.Size = New System.Drawing.Size(0, 22)
        Me.Moviename.TabIndex = 16
        Me.Moviename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.BackColor = System.Drawing.Color.Transparent
        Me.lblBookingID.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingID.ForeColor = System.Drawing.Color.White
        Me.lblBookingID.Location = New System.Drawing.Point(28, 72)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(150, 22)
        Me.lblBookingID.TabIndex = 22
        Me.lblBookingID.Text = "Booking number"
        '
        'CinemaLabel
        '
        Me.CinemaLabel.AutoSize = True
        Me.CinemaLabel.BackColor = System.Drawing.Color.Transparent
        Me.CinemaLabel.Font = New System.Drawing.Font("Goudy Old Style", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CinemaLabel.ForeColor = System.Drawing.Color.White
        Me.CinemaLabel.Location = New System.Drawing.Point(28, 248)
        Me.CinemaLabel.Name = "CinemaLabel"
        Me.CinemaLabel.Size = New System.Drawing.Size(117, 23)
        Me.CinemaLabel.TabIndex = 23
        Me.CinemaLabel.Text = "CinemaName"
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonPrint.Location = New System.Drawing.Point(469, 333)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(99, 33)
        Me.ButtonPrint.TabIndex = 24
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Goudy Old Style", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(661, 59)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Enjoy Your Movie at our Galaxy"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GalaxyCinemas.My.Resources.Resources.frame
        Me.PictureBox1.Location = New System.Drawing.Point(31, 280)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TimeLbl
        '
        Me.TimeLbl.BackColor = System.Drawing.Color.Transparent
        Me.TimeLbl.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.ForeColor = System.Drawing.Color.White
        Me.TimeLbl.Location = New System.Drawing.Point(28, 133)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(141, 20)
        Me.TimeLbl.TabIndex = 26
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BookingFeelbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TimeLbl)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.ButtonPrint)
        Me.Panel1.Controls.Add(Me.CinemaLabel)
        Me.Panel1.Controls.Add(Me.lblBookingID)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.LblGST)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.LblSeat)
        Me.Panel1.Controls.Add(Me.Moviename)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RateLBL)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateLbl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Namelbl)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.halllbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 385)
        Me.Panel1.TabIndex = 27
        '
        'BookingFeelbl
        '
        Me.BookingFeelbl.AutoSize = True
        Me.BookingFeelbl.BackColor = System.Drawing.Color.Transparent
        Me.BookingFeelbl.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingFeelbl.ForeColor = System.Drawing.Color.White
        Me.BookingFeelbl.Location = New System.Drawing.Point(381, 165)
        Me.BookingFeelbl.Name = "BookingFeelbl"
        Me.BookingFeelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BookingFeelbl.Size = New System.Drawing.Size(0, 22)
        Me.BookingFeelbl.TabIndex = 28
        Me.BookingFeelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(229, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Booking Fee"
        '
        'SummaryTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GalaxyCinemas.My.Resources.Resources.Back2
        Me.ClientSize = New System.Drawing.Size(703, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SummaryTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SummaryTickets"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Namelbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RateLBL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents halllbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblGST As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents LblSeat As Label
    Friend WithEvents Moviename As Label
    Friend WithEvents lblBookingID As Label
    Friend WithEvents CinemaLabel As Label
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TimeLbl As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookingFeelbl As Label
    Friend WithEvents Label4 As Label
End Class
