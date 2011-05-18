Imports System.ComponentModel
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports LibUsbDotNet.DeviceNotify

Public Class frmBackground

    Private WithEvents MD5Worker As BackgroundWorker
    Private WithEvents sss As New iDeviceNotify

    Public Sub sss1(ByVal DeviceName As String, ByVal Serial As String, ByVal ID As Integer) Handles sss.DeviceArrival
        MsgBox("Device Arrived: " & DeviceName & " Serial: " & Serial & " ID: " & ID.ToString)
    End Sub

    Public Sub sss2(ByVal DeviceName As String, ByVal Serial As String, ByVal ID As Integer) Handles sss.DeviceRemoval
        MsgBox("Device Removed: " & DeviceName & " Serial: " & Serial & " ID: " & ID.ToString)
    End Sub

    Public Sub MD5Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles MD5Worker.DoWork

        Dim SHA1 As New SHA1CryptoServiceProvider
        Dim stream As New FileStream(FirmwareFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        SHA1.ComputeHash(stream)
        stream.Close()
        Dim hash As Byte() = SHA1.Hash
        Dim sb As New StringBuilder()
        For Each b As Byte In hash
            sb.Append(String.Format("{0:X2}", b))
        Next
        FirmWareFileHash = sb.ToString.ToLower

    End Sub

    Public Sub MD5Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles MD5Worker.RunWorkerCompleted

        If FirmWareFileHash = "d2ed58586e8ca2153f2e2ec585bba8afc5173378" Then ' 4.2.1
            MsgBox("Original 4.2.1 Firmware Chosen", vbOKOnly Or vbInformation, "3GSn0w")
            FirmwareIsOriginal421 = True
        Else

        End If

        My.Computer.Clipboard.SetText(FirmWareFileHash)

        Me.PanelFirmware.Enabled = False
        Me.PanelFirmware.Visible = False
        EndBusy()

    End Sub

    Private Sub lblFirmwareDrop_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblFirmwareDrop.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Int32

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list.
            For i = 0 To MyFiles.Length - 1
                If i = 0 Then FirmwareFile = MyFiles(i)
            Next

            runworker()

        End If

    End Sub

    Private Sub lblFirmwareDrop_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblFirmwareDrop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub runworker()
        StartBusy("Checking Firmware file...", "Getting SHA1 Hash")
        MD5Worker = New BackgroundWorker
        MD5Worker.WorkerReportsProgress = True
        MD5Worker.WorkerSupportsCancellation = True
        MD5Worker.RunWorkerAsync()
    End Sub

    Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click

    End Sub

End Class