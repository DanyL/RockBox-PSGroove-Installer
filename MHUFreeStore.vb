'RockBox-PSGroove Installer.
'Official site: http://rockbox-psgroove.com/

'Copyright (C) 2010 DanyL

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see http://www.gnu.org/licenses/.

Imports System.Net

Public Class MHUFreeStore

    Dim WithEvents WC As New WebClient
    Dim aPath As String
    Dim aName As String

    Private Sub MHUFreeStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        aPath = System.IO.Path.GetDirectoryName(aName)

        If My.Computer.FileSystem.FileExists(aPath & "\" & "MhuFreeStore.pkg") Then
            Label2.Text = "Installing..."
            My.Computer.FileSystem.CopyFile(aPath & "\" & "MhuFreeStore.pkg", RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg", True)
            ProgressBar1.Value = 100
            Label2.Text = "Installation Complete"
            Me.Close()
        Else
            WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.2/MhuFreeStore.pkg"), aPath & "\" & "MhuFreeStore.pkg")
            Label2.Text = "Downloading..."
        End If

    End Sub

    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged

        If Label2.Text = "Downloading..." Then
            ProgressBar1.Value = e.ProgressPercentage
        End If
    End Sub

    Private Sub wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted

        aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        aPath = System.IO.Path.GetDirectoryName(aName)

        Label2.Text = "Installing..."
        My.Computer.FileSystem.CopyFile(aPath & "\" & "MhuFreeStore.pkg", RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg", True)
        Label2.Text = "Installation Complete"
        Me.Close()

    End Sub
End Class