   M S B A M L   `   `   `  ����  restYourEyesA0clr-namespace:restYourEyes;assembly=restYourEyesrestYourEyes  5          restYourEyes.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Ccustom0clr-namespace:restYourEyes;assembly=restYourEyes     5        � Title$  Rest Your Eyes II��5      $	��454��6   $	��517��6,    � 
ResizeMode$ CanMinimize=�68    � WindowStartupLocation$ CenterScreen=�6Q   .��5      � .+�5   
   �� -   5         ��Name$ btnStart��5      $��custom:ViewModel.StartCmd��6#   $ ��Start Timer for 30 minutes��6G   $
��Left=�6l   $��	44,38,0,0q�6�   $	��Top=�6�   $	��420��6�   $��63��6�   $��20(�6�   �� 5	   
   -   5         ��Name$ lblTimer��5	      $
��Left=�6F   $��
44,138,0,0q�6a   $	��Top=�6u    J� RenderTransformOrigin$ -0.783,-0.081&�6�   $	��420��6�   $��63��6�   $��20(�6�   $��Center=�6�   ��6"   �� *MessageProperty+6�   �� 5
   
   -   5        $ btnStop��5
      $��custom:ViewModel.StopCmd��6"   $��
Stop Timer��6E   $
��Left=�6Z   $��
44,246,0,0q�6u   $	��Top=�6�   $	��420��6�   $��63��6�   $��20(�6�   �� 5   
   -   5        $ btnClose��5      $%��custom:ViewModel.ExitProgramCmd��6#   $��Close��6M   $
��Left=�6]   $��389,354,0,0q�6x   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ btnAbout��5      $��custom:ViewModel.AboutCmd��6#   $��About��6G   $
��Left=�6W   $��
44,354,0,0q�6r   $	��Top=�6�   $��75��6�   5      5      