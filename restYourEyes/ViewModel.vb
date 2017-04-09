Imports System.ComponentModel

Public Class ViewModel
    Implements INotifyPropertyChanged

#Region "fields"
    Private myTextValue As String
    Private timeModel As New TimeModel(Me)
#End Region

#Region "Constructor"
    Public Sub New()
        Me.MessageProperty = "Timer is OFF"
    End Sub
#End Region

#Region "properties"
    Public Property MessageProperty() As String
        Get
            Return Me.myTextValue
        End Get
        Set(value As String)
            Me.myTextValue = value
            NotifyPropertyChanged("MessageProperty")
        End Set
    End Property
#End Region

#Region "Tell the GUI that something has changed"
    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "Start commands"
    Public Shared StartCmd As New RoutedCommand

    Public Sub ExecutedStartCmd(ByVal s As Object, ByVal e As ExecutedRoutedEventArgs)
        Me.MessageProperty = "Timer is ON"
        timeModel.startTimer(1800000)
    End Sub
#End Region

#Region "Stop commands"
    Public Shared StopCmd As New RoutedCommand

    Public Sub ExecutedStopCmd(ByVal s As Object, ByVal e As ExecutedRoutedEventArgs)
        Me.MessageProperty = "Timer is OFF"
        timeModel.stopTimer()
    End Sub
#End Region

#Region "About command"
    Public Shared AboutCmd As New RoutedCommand

    Public Sub ExecutedAboutCmd(ByVal s As Object, ByVal e As ExecutedRoutedEventArgs)
        Dim aboutWindow As New About()
        aboutWindow.ShowDialog()
    End Sub
#End Region

#Region "Exit command"
    Public Shared ExitProgramCmd As New RoutedCommand

    Public Sub ExecutedExitProgramCmd(ByVal s As Object, ByVal e As ExecutedRoutedEventArgs)
        Application.Current.Shutdown()
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
