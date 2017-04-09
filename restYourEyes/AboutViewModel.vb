Public Class AboutViewModel

#Region "close command"
    Public Shared CloseCmd As New RoutedCommand

    Public Sub ExecutedCloseCmd(ByVal s As Object, ByVal e As ExecutedRoutedEventArgs)
        Dim mw As Window
        mw = (Application.Current.Windows(1))
        mw.Close()
    End Sub
#End Region

#Region "Only allow controls to run commands"
    Public Sub CanExecuteCmds(ByVal s As Object, ByVal e As CanExecuteRoutedEventArgs)
        Dim target As Control = TryCast(e.Source, Control)
        If target IsNot Nothing Then
            e.CanExecute = True
        Else
            e.CanExecute = False
        End If
    End Sub
#End Region

End Class
