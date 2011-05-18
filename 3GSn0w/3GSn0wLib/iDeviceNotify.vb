Imports LibUsbDotNet
Imports LibUsbDotNet.Info
Imports LibUsbDotNet.Main
Imports LibUsbDotNet.DeviceNotify
Imports System.Collections.ObjectModel
Imports System.Runtime.InteropServices
Imports System.IO

Public Class iDeviceNotify

    Public Class Constants
        Public Const APPLE_VENDOR_ID = &H5AC
        Public Const PROD_IPHONE = &H1290
        Public Const PROD_IPHONE3G = &H1292
        Public Const PROD_IPHONE3GS = &H1294
        Public Const PROD_IPHONE4_GSM = &H1297
        Public Const PROD_IPHONE4_CDMA = &H129C
        Public Const PROD_IPODTOUCH = &H1291
        Public Const PROD_IPODTOUCH2G = &H1293
        Public Const PROD_IPODTOUCH3G = &H1299
        Public Const PROD_IPODTOUCH4G = &H129E
        Public Const PROD_IPAD = &H129A
        Public Const PROD_IPAD2_WIFI = &H129F
        Public Const PROD_IPAD2_GSM = &H12A2
        Public Const PROD_IPAD2_CDMA = &H12A3
        Public Const PROD_RECOVERY_MODE = &H1281
        Public Const PROD_DFU_MODE = &H1227
    End Class

    Public Shared UsbDeviceNotifier As IDeviceNotifier = DeviceNotifier.OpenDeviceNotifier()
    Public Event DeviceArrival(ByVal DeviceName As String, ByVal Serial As String, ByVal ID As Integer)
    Public Event DeviceRemoval(ByVal DeviceName As String, ByVal Serial As String, ByVal ID As Integer)

    Private piDeviceIDs As New Hashtable
    Private pIsStarted As Boolean = False
    Private pDeviceCount As Integer = 1

    Public Sub New()
        GetExistingiDevices()
        Start()
    End Sub

    Private Sub RegisterDevice(ByVal Serial As String)
        Try
            piDeviceIDs.Add(Serial, pDeviceCount)
            pDeviceCount = +1
        Catch ex As Exception

        End Try

    End Sub

    Private Function GetDeviceID(ByVal Serial As String) As Integer
        Try
            Return piDeviceIDs(Serial)
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub GetExistingiDevices()
        Dim MyUsbDevice As UsbDevice = Nothing
        Dim allDevices As UsbRegDeviceList = UsbDevice.AllLibUsbDevices
        For Each usbRegistry As UsbRegistry In allDevices
            If usbRegistry.Open(MyUsbDevice) Then
                If MyUsbDevice.UsbRegistryInfo.Vid = Constants.APPLE_VENDOR_ID Then
                    Select Case MyUsbDevice.UsbRegistryInfo.Pid
                        Case Constants.PROD_IPHONE
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPHONE3G
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPHONE3GS
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPHONE4_GSM
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPHONE4_CDMA
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPODTOUCH
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPODTOUCH2G
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPODTOUCH3G
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPODTOUCH4G
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPAD
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPAD2_WIFI
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPAD2_GSM
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_IPAD2_CDMA
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_RECOVERY_MODE
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                        Case Constants.PROD_DFU_MODE
                            RegisterDevice(MyUsbDevice.Info.SerialString)
                    End Select
                End If
            End If
        Next
    End Sub

    Public Sub Start()
        If Not pIsStarted Then
            AddHandler UsbDeviceNotifier.OnDeviceNotify, AddressOf OnDeviceNotifyEvent
            UsbDeviceNotifier.Enabled = True
            pIsStarted = True
        End If
    End Sub

    Public Sub [Stop]()
        If pIsStarted Then
            UsbDeviceNotifier.Enabled = False
            RemoveHandler UsbDeviceNotifier.OnDeviceNotify, AddressOf OnDeviceNotifyEvent
            pIsStarted = False
        End If
    End Sub

    Private Sub OnDeviceNotifyEvent(ByVal sender As Object, ByVal e As DeviceNotifyEventArgs)

        If e.EventType = EventType.DeviceArrival Then

            If e.Device.IdVendor = Constants.APPLE_VENDOR_ID Then
                Select Case e.Device.IdProduct
                    Case Constants.PROD_IPHONE
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPhone", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPHONE3G
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPhone3G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPHONE3GS
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPhone3GS", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPHONE4_GSM
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPhone4 GSM", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPHONE4_CDMA
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPhone4 CDMA", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPODTOUCH
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPod Touch", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPODTOUCH2G
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPod Touch 2G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPODTOUCH3G
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPod Touch 3G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPODTOUCH4G
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPod Touch 4G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPAD
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPad", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPAD2_WIFI
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPad2 WiFi", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPAD2_GSM
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPad2 GSM", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_IPAD2_CDMA
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("iPad2 CDMA", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_RECOVERY_MODE
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("Recovery Mode", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Constants.PROD_DFU_MODE
                        RegisterDevice(e.Device.SerialNumber)
                        RaiseEvent DeviceArrival("DFU Mode", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                    Case Else
                        RaiseEvent DeviceArrival("Unknown &H" & Hex(e.Device.IdProduct), "", -1)
                End Select

            End If

        ElseIf e.EventType = EventType.DeviceRemoveComplete Then

            Select Case e.Device.IdProduct
                Case Constants.PROD_IPHONE
                    RaiseEvent DeviceRemoval("iPhone", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPHONE3G
                    RaiseEvent DeviceRemoval("iPhone3G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPHONE3GS
                    RaiseEvent DeviceRemoval("iPhone3GS", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPHONE4_GSM
                    RaiseEvent DeviceRemoval("iPhone4 GSM", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPHONE4_CDMA
                    RaiseEvent DeviceRemoval("iPhone4 CDMA", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPODTOUCH
                    RaiseEvent DeviceRemoval("iPod Touch", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPODTOUCH2G
                    RaiseEvent DeviceRemoval("iPod Touch 2G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPODTOUCH3G
                    RaiseEvent DeviceRemoval("iPod Touch 3G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPODTOUCH4G
                    RaiseEvent DeviceRemoval("iPod Touch 4G", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPAD
                    RaiseEvent DeviceRemoval("iPad", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPAD2_WIFI
                    RaiseEvent DeviceRemoval("iPad2 WiFi", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPAD2_GSM
                    RaiseEvent DeviceRemoval("iPad2 GSM", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_IPAD2_CDMA
                    RaiseEvent DeviceRemoval("iPad2 CDMA", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_RECOVERY_MODE
                    RaiseEvent DeviceRemoval("Recovery Mode", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Constants.PROD_DFU_MODE
                    RaiseEvent DeviceRemoval("DFU Mode", e.Device.SerialNumber, GetDeviceID(e.Device.SerialNumber))
                Case Else
                    RaiseEvent DeviceRemoval("Unknown &H" & Hex(e.Device.IdProduct), "", -1)
            End Select

        End If

    End Sub

End Class
