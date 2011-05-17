<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackground
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackground))
        Me.TwitterFollow = New System.Windows.Forms.PictureBox()
        Me.PanelFirmware = New System.Windows.Forms.Panel()
        Me.lblFirmwareDrop = New System.Windows.Forms.Label()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TwitterFollow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFirmware.SuspendLayout()
        Me.SuspendLayout()
        '
        'TwitterFollow
        '
        Me.TwitterFollow.Image = CType(resources.GetObject("TwitterFollow.Image"), System.Drawing.Image)
        Me.TwitterFollow.Location = New System.Drawing.Point(627, 509)
        Me.TwitterFollow.Name = "TwitterFollow"
        Me.TwitterFollow.Size = New System.Drawing.Size(147, 69)
        Me.TwitterFollow.TabIndex = 0
        Me.TwitterFollow.TabStop = False
        '
        'PanelFirmware
        '
        Me.PanelFirmware.BackColor = System.Drawing.Color.Transparent
        Me.PanelFirmware.Controls.Add(Me.lblFirmwareDrop)
        Me.PanelFirmware.Controls.Add(Me.ButtonBrowse)
        Me.PanelFirmware.Controls.Add(Me.Label1)
        Me.PanelFirmware.Location = New System.Drawing.Point(31, 30)
        Me.PanelFirmware.Name = "PanelFirmware"
        Me.PanelFirmware.Size = New System.Drawing.Size(468, 450)
        Me.PanelFirmware.TabIndex = 1
        Me.PanelFirmware.Visible = False
        '
        'lblFirmwareDrop
        '
        Me.lblFirmwareDrop.AllowDrop = True
        Me.lblFirmwareDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirmwareDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirmwareDrop.ForeColor = System.Drawing.Color.White
        Me.lblFirmwareDrop.Location = New System.Drawing.Point(132, 164)
        Me.lblFirmwareDrop.Name = "lblFirmwareDrop"
        Me.lblFirmwareDrop.Size = New System.Drawing.Size(205, 131)
        Me.lblFirmwareDrop.TabIndex = 3
        Me.lblFirmwareDrop.Text = "Drop firmware file here..."
        Me.lblFirmwareDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.AutoSize = True
        Me.ButtonBrowse.BackColor = System.Drawing.Color.Black
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowse.ForeColor = System.Drawing.Color.White
        Me.ButtonBrowse.Location = New System.Drawing.Point(196, 319)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 27)
        Me.ButtonBrowse.TabIndex = 2
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please drag your firmware file here or click Browse to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "browse your computer."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 590)
        Me.Controls.Add(Me.PanelFirmware)
        Me.Controls.Add(Me.TwitterFollow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBackground"
        Me.Text = "frmBackground"
        CType(Me.TwitterFollow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFirmware.ResumeLayout(False)
        Me.PanelFirmware.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TwitterFollow As System.Windows.Forms.PictureBox
    Friend WithEvents PanelFirmware As System.Windows.Forms.Panel
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFirmwareDrop As System.Windows.Forms.Label
End Class
