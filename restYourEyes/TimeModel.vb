Imports System.Timers
Public Class TimeModel
    Dim eyeRestTimer As New Timer()
    Dim viewModelToUse As ViewModel

    Public Sub New(ByRef viewM As ViewModel)
        viewModelToUse = viewM
    End Sub

    ''' <summary>
    ''' Enter 1800000 for 30 minutes or 6000 for a quick 6 second test.
    ''' </summary>
    ''' <param name="timerDuration"></param>
    ''' <remarks></remarks>
    Public Sub startTimer(ByVal timerDuration As Integer)
        If (eyeRestTimer.Enabled = False) Then
            AddHandler eyeRestTimer.Elapsed, AddressOf TimedEvent
            eyeRestTimer.Interval = timerDuration
            eyeRestTimer.Enabled = True
            GC.KeepAlive(eyeRestTimer)
        End If
    End Sub

    Public Sub stopTimer()
        eyeRestTimer.Enabled = False
    End Sub

    Private Sub TimedEvent(ByVal s As Object, ByVal e As ElapsedEventArgs)
        eyeRestTimer.Stop()
        MessageBox.Show("Please rest your eyes and take a break from the computer.", "Rest Your Eyes II - Message", MessageBoxButton.OK)
        viewModelToUse.MessageProperty = "Timer is OFF"
    End Sub
End Class
