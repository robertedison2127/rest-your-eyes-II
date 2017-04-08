
Class MainWindow

    Dim timeControl As New TimeController()

    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs) Handles btnStart.Click
        lblTimer.Content = "Timer is ON"
        timeControl.startTimer(6000)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As RoutedEventArgs) Handles btnStop.Click
        lblTimer.Content = "Timer is OFF"
        timeControl.stopTimer()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As RoutedEventArgs) Handles btnAbout.Click
        Dim aboutWindow As New About
        aboutWindow.ShowDialog()
    End Sub

    Public Sub updateLabel()
        lblTimer.Content = "Timer is OFF"
    End Sub


    
End Class
