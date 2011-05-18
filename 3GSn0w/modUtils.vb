Module modUtils

    Private pIsBusyFormShown As Boolean = False

    Public Sub StartBusy(ByVal MainStatus As String, Optional ByVal SubStatus As String = "Please wait...")
        If Not pIsBusyFormShown Then
            frmBackground.Enabled = False
            FormBusy.MdiParent = MDIMain
            MDIMain.ShowMDIClientCenter(FormBusy, True)
            FormBusy.StatusMain.Text = MainStatus
            FormBusy.StatusSub.Text = SubStatus
            pIsBusyFormShown = True
        Else
            Throw New Exception("Busy windows is already shown")
        End If

    End Sub

    Public Sub UpdateBusyMainStatus(ByVal Status As String)
        If pIsBusyFormShown Then
            FormBusy.StatusMain.Text = Status
        End If
    End Sub

    Public Sub UpdateBusySubStatus(ByVal Status As String)
        If pIsBusyFormShown Then
            FormBusy.StatusSub.Text = Status
        End If
    End Sub

    Public Sub EndBusy()
        If pIsBusyFormShown Then
            FormBusy.Close()
            frmBackground.Enabled = True
            pIsBusyFormShown = False
        End If
    End Sub

End Module
