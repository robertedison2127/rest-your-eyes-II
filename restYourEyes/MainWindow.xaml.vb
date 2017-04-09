Class MainWindow

    ' The ViewModel deals with the GUI logic.
    Dim mainViewModel As New ViewModel()

    ' Setup objects to reference commands in the ViewModel
    Dim startCmdBinding As New CommandBinding(ViewModel.StartCmd, AddressOf mainViewModel.ExecutedStartCmd, _
                                                   AddressOf mainViewModel.CanExecuteCmds)

    Dim stopCmdBinding As New CommandBinding(ViewModel.StopCmd, AddressOf mainViewModel.ExecutedStopCmd, _
                                             AddressOf mainViewModel.CanExecuteCmds)

    Dim aboutCmdBinding As New CommandBinding(ViewModel.AboutCmd, AddressOf mainViewModel.ExecutedAboutCmd, _
                                            AddressOf mainViewModel.CanExecuteCmds)

    Dim exitProgramCmdBinding As New CommandBinding(ViewModel.ExitProgramCmd, AddressOf mainViewModel.ExecutedExitProgramCmd, _
                                                    AddressOf mainViewModel.CanExecuteCmds)

    Sub New()
        InitializeComponent()

        ' Remember for all this to work we must have a namespace reference in the XAML file.
        ' The XAML code is xmlns:custom="clr-namespace:restYourEyes;assembly=restYourEyes"

        ' We need to connect the ViewModel to the GUI for XAML data bindings to work.
        ' The XAML code is  <Label x:Name="lblTimer" Content="{Binding MessageProperty}"
        Me.DataContext = mainViewModel

        ' We need to connect commands to the GUI for XAML to call.
        ' The XAML code is <Button x:Name="btnStart" Command="custom:ViewModel.StartCmd"
        ' If this code is missing, the button will be greyed out.

        Me.CommandBindings.Add(startCmdBinding)
        Me.CommandBindings.Add(stopCmdBinding)
        Me.CommandBindings.Add(aboutCmdBinding)
        Me.CommandBindings.Add(exitProgramCmdBinding)

    End Sub
End Class