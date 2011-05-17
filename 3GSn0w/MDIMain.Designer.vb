<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3GSn0w = New System.Windows.Forms.Label()
        Me.ButtonTwitterDollow = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ButtonTwitterDollow)
        Me.Panel1.Controls.Add(Me.Label3GSn0w)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 604)
        Me.Panel1.TabIndex = 11
        '
        'Label3GSn0w
        '
        Me.Label3GSn0w.AutoSize = True
        Me.Label3GSn0w.BackColor = System.Drawing.Color.Transparent
        Me.Label3GSn0w.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3GSn0w.ForeColor = System.Drawing.Color.White
        Me.Label3GSn0w.Location = New System.Drawing.Point(27, 544)
        Me.Label3GSn0w.Name = "Label3GSn0w"
        Me.Label3GSn0w.Size = New System.Drawing.Size(146, 37)
        Me.Label3GSn0w.TabIndex = 0
        Me.Label3GSn0w.Text = "3GSn0w"
        '
        'ButtonTwitterDollow
        '
        Me.ButtonTwitterDollow.AutoSize = True
        Me.ButtonTwitterDollow.Image = CType(resources.GetObject("ButtonTwitterDollow.Image"), System.Drawing.Image)
        Me.ButtonTwitterDollow.Location = New System.Drawing.Point(688, 504)
        Me.ButtonTwitterDollow.Name = "ButtonTwitterDollow"
        Me.ButtonTwitterDollow.Size = New System.Drawing.Size(158, 77)
        Me.ButtonTwitterDollow.TabIndex = 2
        Me.ButtonTwitterDollow.UseVisualStyleBackColor = True
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(874, 604)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3GSn0w - iPhone3G Custom Firmware Tool - Follow 3GSn0w on Twitter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3GSn0w As System.Windows.Forms.Label
    Friend WithEvents ButtonTwitterDollow As System.Windows.Forms.Button

End Class
