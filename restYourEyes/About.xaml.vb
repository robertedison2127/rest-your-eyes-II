Public Class About
    Dim abViewModel As New AboutViewModel()
    Dim closeCmdBinding As New CommandBinding(AboutViewModel.CloseCmd, AddressOf abViewModel.ExecutedCloseCmd, _
                                              AddressOf abViewModel.CanExecuteCmds)

    Sub New()
        InitializeComponent()
        Me.DataContext = abViewModel
        Me.CommandBindings.Add(closeCmdBinding)
    End Sub
End Class
