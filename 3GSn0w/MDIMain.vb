Imports System.Windows.Forms

Public Class MDIMain

    Private Sub ButtonTwitterDollow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Open website with default browser :D
        Diagnostics.Process.Start("http://www.twitter.com/3GSn0w")

    End Sub

    Private Sub MDIMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        frmBackground.MdiParent = Me
        frmBackground.Show()

        ShowMDIClientCenter(FRMSplash, True)

    End Sub

    Public Sub ShowMDIClientCenter(ByVal Form As System.Windows.Forms.Form, ByVal HoldUser As Boolean)
        Dim MDIChildForm As System.Windows.Forms.Form = Form
        MDIChildForm.MdiParent = Me
        MDIChildForm.Show()
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width)
        Dim BorderHeight As Integer = (Me.Height - Me.ClientSize.Height)
        Dim ChildLeft As Integer = (Me.Width - BorderWidth - MDIChildForm.Width) / 2
        Dim ChildTop As Integer = (Me.Height - BorderHeight - MDIChildForm.Height) / 2
        MDIChildForm.Left = ChildLeft
        MDIChildForm.Top = ChildTop

        If HoldUser Then frmBackground.Enabled = False

    End Sub

End Class
