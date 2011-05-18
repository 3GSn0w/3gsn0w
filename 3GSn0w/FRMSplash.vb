Public Class FRMSplash

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click

        frmBackground.Enabled = True
        Me.Close()
        frmBackground.PanelFirmware.Visible = True

    End Sub

    Private Sub TwitterFollow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwitterFollow.Click
        Diagnostics.Process.Start("http://twitter.com/#!/3GSn0w")
    End Sub

End Class