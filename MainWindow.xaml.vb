Imports System.Drawing.Text
Imports System.Security.Principal
Imports Microsoft.Win32
Imports Xpress.Core.Project
Public Class MainWindow

    Public Shared PageType As String = "StartupPage"

    Private Sub CommandBinding_CanExecute(sender As Object, e As CanExecuteRoutedEventArgs)
        e.CanExecute = True
    End Sub

    Private Sub CommandBinding_Executed_Close(sender As Object, e As ExecutedRoutedEventArgs)
        SystemCommands.CloseWindow(Me)
    End Sub

    Private Sub CommandBinding_Executed_Maximize(sender As Object, e As ExecutedRoutedEventArgs)
        SystemCommands.MaximizeWindow(Me)
    End Sub

    Private Sub CommandBinding_Executed_Minimize(sender As Object, e As ExecutedRoutedEventArgs)
        SystemCommands.MinimizeWindow(Me)
    End Sub

    Private Sub CommandBinding_Executed_Restore(sender As Object, e As ExecutedRoutedEventArgs)
        SystemCommands.RestoreWindow(Me)
    End Sub

    Private Sub MainWindow_StateChanged(sender As Object, e As EventArgs) Handles Me.StateChanged
        Dim w As Double = 1108
        Dim h As Double = 587
        If Me.WindowState = WindowState.Maximized Then
            MainWindowBorder.BorderThickness = New Thickness(7)
            RestoreButton.Visibility = Visibility.Visible
            MaximizeButton.Visibility = Visibility.Collapsed
        Else
            MainWindowBorder.BorderThickness = New Thickness(1)
            RestoreButton.Visibility = Visibility.Collapsed
            MaximizeButton.Visibility = Visibility.Visible
        End If
    End Sub
    Private Sub Window_Deactivated(sender As Object, e As EventArgs)
        WindowName.Foreground = Brushes.DimGray
        MainWindowBorder.BorderBrush = Brushes.DimGray
    End Sub

    Private Sub Window_Activated(sender As Object, e As EventArgs)

        Dim borderDefault As New SolidColorBrush(Color.FromArgb(255, 65, 105, 225))
        WindowName.Foreground = Brushes.White
        MainWindowBorder.BorderBrush = borderDefault
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        Dim fc As New InstalledFontCollection()


        NavPage.Navigate(New StartupPage)
        Me.WindowState = WindowState.Maximized



        For Each fontFamilly In fc.Families
            If IO.File.Exists("C:\Windows\Fonts\segmdl2.ttf") Then

            Else
                If isElevated = True Then
                    IO.File.WriteAllBytes("C:\Windows\Fonts\segmdl2.ttf", My.Resources.segmdl2)
                    System.Windows.Forms.Application.Restart()
                    Return
                End If

                If vbOK = MessageBox.Show("Font missing in your operating system" & vbCrLf & vbCrLf & "Missing font: Segoe MDL2 Assets" & vbCrLf & "OS Version: " & Environment.OSVersion.ToString & vbCrLf & vbCrLf & "Press 'OK' to launch as administrator the program and install the font", "Xpress Studio Error", MessageBoxButton.OKCancel, MessageBoxImage.Error) Then

                    Dim process As System.Diagnostics.Process = Nothing
                    Dim processStartInfo As System.Diagnostics.ProcessStartInfo
                    processStartInfo = New System.Diagnostics.ProcessStartInfo()
                    processStartInfo.FileName = System.Windows.Forms.Application.ExecutablePath
                    processStartInfo.Verb = "runas"

                    processStartInfo.Arguments = ""
                    processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    processStartInfo.UseShellExecute = True
                    process = System.Diagnostics.Process.Start(processStartInfo)

                End If

            End If
        Next


    End Sub

    Private Sub StackPanel_MouseEnter(sender As Object, e As MouseEventArgs)
        TabPage0.Background = New SolidColorBrush(Color.FromArgb(255, 30, 30, 30))
    End Sub

    Private Sub TabPage0_MouseLeave(sender As Object, e As MouseEventArgs) Handles TabPage0.MouseLeave
        TabPage0.Background = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Public Sub CreateTabPage(Optional ToolTip As String = Nothing)



        Dim _lastTab As Integer = 0
        Dim _lastTabName As String = "TabPage" + _lastTab.ToString
        Dim _tab As Integer = 0
        Dim _tabname As String = "TabPage" + _tab.ToString
        Dim _lastTabTop As Integer = 0
        Dim _tabTop As Integer = 35
        Dim _fto As String = ToolTip

        Dim NewTabPage As New StackPanel

        For Each ctrl As StackPanel In HorizontalTabs.Children
            If ctrl.Name = _lastTabName Then
                _tab += 1
                _lastTab += 1
                _lastTab -= 1
                _lastTabTop = ctrl.Margin.Top
            End If
        Next

        With NewTabPage
            .Name = _tabname
            .ToolTip = _fto
            .Height = 30
            .Width = 30
            .Margin = New Thickness(4, _lastTabTop + _tabTop, 0, 0)
            .Background = Brushes.Black
            .VerticalAlignment = VerticalAlignment.Top
            .HorizontalAlignment = HorizontalAlignment.Left
            AddHandler NewTabPage.MouseLeftButtonDown, AddressOf Nav_Click
        End With

        If _tab = 16 Then
            MsgBox("You have been reached the max limit of tabs opened")
            Return
        End If

        HorizontalTabs.Children.Add(NewTabPage)


    End Sub

    Private Sub TabPage0_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles TabPage0.MouseLeftButtonDown
        NavPage.Navigate(New StartupPage)
        CreateTabPage()
    End Sub

    Private Sub HorizontalTabs_MouseEnter(sender As Object, e As MouseEventArgs) Handles HorizontalTabs.MouseEnter
        HorizontalTabs.Width = 200
        HorizontalTabs.Background = New SolidColorBrush(Color.FromArgb(255, 24, 24, 24))
    End Sub

    Private Sub HorizontalTabs_MouseLeave(sender As Object, e As MouseEventArgs) Handles HorizontalTabs.MouseLeave
        HorizontalTabs.Width = 40
        HorizontalTabs.Background = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Settings_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Settings.MouseLeftButtonDown
        If settingsPanel.Visibility = Visibility.Visible Then
            settingsPanel.Visibility = Visibility.Hidden
        Else
            settingsPanel.Visibility = Visibility.Visible
        End If
    End Sub

    Private Sub Settings_MouseEnter(sender As Object, e As MouseEventArgs) Handles Settings.MouseEnter
        Settings.Background = New SolidColorBrush(Color.FromArgb(255, 30, 30, 30))
    End Sub

    Private Sub Settings_MouseLeave(sender As Object, e As MouseEventArgs) Handles Settings.MouseLeave
        Settings.Background = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim newMe As New MainWindow
        newMe.Show()
        settingsPanel.Visibility = Visibility.Hidden
    End Sub

    Private Sub Nav_Click(sender As Object, e As EventArgs)
        NavPage.Navigate(New Editor)

    End Sub

    Private Sub NewProj_Click(sender As Object, e As RoutedEventArgs) Handles NewProj.Click
        Dim openProj As New OpenProject
        settingsPanel.Visibility = Visibility.Hidden
        openProj.ShowDialog()

    End Sub





End Class
