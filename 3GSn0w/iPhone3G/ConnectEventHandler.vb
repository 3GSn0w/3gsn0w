Imports System.Collections.Generic
Imports System.Text

Namespace iPhone3G

    ''' <summary>
    ''' Represents the method that will handle the <see>Connected</see> and <see>Disconnected</see> event.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="args">A <see>ConnectEventArgs</see> that contains the data.</param>
    Public Delegate Sub ConnectEventHandler(ByVal sender As Object, ByVal args As ConnectEventArgs)

End Namespace
