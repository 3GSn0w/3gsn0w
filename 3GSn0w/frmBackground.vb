Public Class frmBackground

    Private Sub TwitterFollow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwitterFollow.Click
        Diagnostics.Process.Start("http://twitter.com/#!/3GSn0w")
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

        End If

    End Sub

    Private Sub lblFirmwareDrop_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblFirmwareDrop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

End Class