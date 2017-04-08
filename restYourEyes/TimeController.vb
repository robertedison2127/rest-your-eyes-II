Imports System.Timers
Public Class TimeController
    Dim eyeRestTimer As New Timer()

    Public Delegate Sub pointerToGuiUpdater()

    Public Sub startTimer(ByVal timerDuration As Integer)
        ' how to overload this so we can set 30 minutes or 6 seconds?
        ' 1800000 is 30 minutes.
        ' To do a 6 second test use 6000.
        If (eyeRestTimer.Enabled = False) Then
            AddHandler eyeRestTimer.Elapsed, AddressOf OnTimedEvent
            eyeRestTimer.Interval = timerDuration
            eyeRestTimer.Enabled = True
            GC.KeepAlive(eyeRestTimer)
        End If

    End Sub

    Public Sub stopTimer()
        eyeRestTimer.Enabled = False
    End Sub

    Private Function TimedEvent(ByVal s As Object, ByVal e As ElapsedEventArgs)
        eyeRestTimer.Stop()
        Return ("Please rest your eyes and take a break from the computer.")
    End Function

    Private Sub OnTimedEvent(ByVal s As Object, ByVal e As ElapsedEventArgs)

        ' how to edit a label from another class in the same thread?
        eyeRestTimer.Stop()
        MessageBox.Show("Please rest your eyes and take a break from the computer.", "Message", MessageBoxButton.OK)
        lblTimer.Dispatcher.Invoke(New pointerToGuiUpdater(AddressOf GuiUpdater))
    End Sub

    Private Sub GuiUpdater()
        lblTimer.Content = "Timer is OFF"
    End Sub
End Class
