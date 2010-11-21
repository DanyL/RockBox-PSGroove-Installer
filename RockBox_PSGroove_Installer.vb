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

Imports System.Collections.ObjectModel
Imports System.IO
Imports Ionic.Zip
Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Text

Public Class RockBox_PSGroove_Installer
    Dim Descktop As String
    Private Property TextBox1_TextChanged As String
    Private rvn_ZipFile As String = "zipfile"
    Private rvn_ExtractDir As String = "extractdir"
    Private Delegate Sub ZipProgress(ByVal e As ExtractProgressEventArgs)
    Private totalEntriesToProcess As Integer
    Dim WithEvents WC As New WebClient
    Dim aPath As String
    Dim aName As String
    Dim Proc As New System.Diagnostics.Process

    Private Sub RockBox_PSGroove_Installer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        webRequest = webRequest.Create("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/update/version.txt")
        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream())

        If inStream.ReadToEnd() > "2.2" Then
            Updater.Show(Me)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        Descktop = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        PictureBox15.Image = My.Resources.DonateP
        System.Diagnostics.Process.Start("https://sourceforge.net/donate/index.php?group_id=357229")
    End Sub

    Private Sub PictureBox15_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseEnter
        PictureBox15.Image = My.Resources.DonateO
    End Sub

    Private Sub PictureBox15_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseLeave
        PictureBox15.Image = My.Resources.Donate
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.Image = My.Resources.DonateP
        System.Diagnostics.Process.Start("https://sourceforge.net/donate/index.php?group_id=357229")
    End Sub

    Private Sub PictureBox10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseEnter
        PictureBox10.Image = My.Resources.DonateO
    End Sub

    Private Sub PictureBox10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseLeave
        PictureBox10.Image = My.Resources.Donate
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        PictureBox13.Image = My.Resources.Official_SiteP
        System.Diagnostics.Process.Start("http://wordpress.rockbox-psgroove.com/")
    End Sub

    Private Sub PictureBox13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseEnter
        PictureBox13.Image = My.Resources.Official_SiteO
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseLeave
        PictureBox13.Image = My.Resources.Official_Site
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.Image = My.Resources.PSX_SceneP
        System.Diagnostics.Process.Start("http://psx-scene.com/forums/showthread.php?t=67353")
    End Sub

    Private Sub PictureBox11_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Image = My.Resources.PSX_SceneO
    End Sub

    Private Sub PictureBox11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.Image = My.Resources.PSX_Scene
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        System.Diagnostics.Process.Start("http://wordpress.rockbox-psgroove.com/")
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        System.Diagnostics.Process.Start("http://wordpress.rockbox-psgroove.com/")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FolderBrowserDialog2.ShowDialog()
        Descktop = FolderBrowserDialog2.SelectedPath
        TextBox3.Text = FolderBrowserDialog2.SelectedPath
        Dim retval As String
        retval = Dir$(FolderBrowserDialog2.SelectedPath & "/" & "PREVIEW.png")
        If retval = "PREVIEW.png" Then
            PictureBox19.ImageLocation = FolderBrowserDialog2.SelectedPath & "/" & "PREVIEW.png"
        Else
            PictureBox19.Image = My.Resources.PlugInPreview
        End If
        Dim FILE_NAME As String = FolderBrowserDialog2.SelectedPath & "/" & "Details.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            Label22.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            Label22.Text = ""
        End If
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        PictureBox17.Image = My.Resources.Official_SiteP
        System.Diagnostics.Process.Start("http://wordpress.rockbox-psgroove.com/")
    End Sub

    Private Sub PictureBox17_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.MouseEnter
        PictureBox17.Image = My.Resources.Official_SiteO
    End Sub

    Private Sub PictureBox17_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.MouseLeave
        PictureBox17.Image = My.Resources.Official_Site
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        PictureBox18.Image = My.Resources.PSX_SceneP
        System.Diagnostics.Process.Start("http://psx-scene.com/forums/showthread.php?t=67353")
    End Sub

    Private Sub PictureBox18_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseEnter
        PictureBox18.Image = My.Resources.PSX_SceneO
    End Sub

    Private Sub PictureBox18_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseLeave
        PictureBox18.Image = My.Resources.PSX_Scene
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        Me.ResetUi()
        PictureBox37.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox12.Checked = False And CheckBox6.Checked = False And CheckBox9.Checked = False And CheckBox8.Checked = False And CheckBox10.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_video.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_video.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar1.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Video/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label6.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox37_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseEnter
        PictureBox37.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox37_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.MouseLeave
        PictureBox37.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        PictureBox38.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar1.Value = 0
        Label6.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label6.Text = "Uninstallation complete"
            ProgressBar1.Value = 100
        End If
    End Sub

    Private Sub PictureBox38_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.MouseEnter
        PictureBox38.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox38_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.MouseLeave
        PictureBox38.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        Me.ResetUi()
        PictureBox40.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox11.Checked = False And CheckBox18.Checked = False And CheckBox7.Checked = False And CheckBox17.Checked = False And CheckBox16.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_nano.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_nano.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar2.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Nano_1G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label7.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox40_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.MouseEnter
        PictureBox40.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox40_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.MouseLeave
        PictureBox40.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        PictureBox39.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar2.Value = 0
        Label7.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label7.Text = "Uninstallation complete"
            ProgressBar2.Value = 100
        End If

    End Sub

    Private Sub PictureBox39_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.MouseEnter
        PictureBox39.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox39_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.MouseLeave
        PictureBox39.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox42_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.MouseEnter
        PictureBox42.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox42_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.MouseLeave
        PictureBox42.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click
        Me.ResetUi()
        PictureBox42.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox20.Checked = False And CheckBox23.Checked = False And CheckBox19.Checked = False And CheckBox22.Checked = False And CheckBox21.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_4g_photo.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_4g_photo.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar3.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Photo/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label2.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox41_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.MouseEnter
        PictureBox41.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox41_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.MouseLeave
        PictureBox41.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click
        PictureBox41.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar3.Value = 0
        Label2.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label2.Text = "Uninstallation complete"
            ProgressBar3.Value = 100
        End If

    End Sub

    Private Sub PictureBox43_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.MouseEnter
        PictureBox43.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox43_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.MouseLeave
        PictureBox43.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.Click
        PictureBox43.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar4.Value = 0
        Label8.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label8.Text = "Uninstallation complete"
            ProgressBar4.Value = 100
        End If
    End Sub

    Private Sub PictureBox44_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.MouseEnter
        PictureBox44.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox44_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.MouseLeave
        PictureBox44.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.Click
        Me.ResetUi()
        PictureBox44.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox25.Checked = False And CheckBox28.Checked = False And CheckBox24.Checked = False And CheckBox27.Checked = False And CheckBox26.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_4g_grayscale.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_4g_grayscale.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar4.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_4G_Grayscale/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label8.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox45_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.MouseEnter
        PictureBox45.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox45_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.MouseLeave
        PictureBox45.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.Click
        PictureBox45.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar5.Value = 0
        Label9.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label9.Text = "Uninstallation complete"
            ProgressBar5.Value = 100
        End If

    End Sub

    Private Sub PictureBox46_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.MouseEnter
        PictureBox46.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox46_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.MouseLeave
        PictureBox46.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.Click
        Me.ResetUi()
        PictureBox46.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox30.Checked = False And CheckBox33.Checked = False And CheckBox29.Checked = False And CheckBox32.Checked = False And CheckBox31.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_mini_2g.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_mini_2g.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar5.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Mini_2G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label9.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox48_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.MouseEnter
        PictureBox48.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox48_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.MouseLeave
        PictureBox48.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.Click
        Me.ResetUi()
        PictureBox48.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox35.Checked = False And CheckBox38.Checked = False And CheckBox34.Checked = False And CheckBox37.Checked = False And CheckBox36.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_mini_1g.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_mini_1g.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar6.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Mini_1G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label10.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox47_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.MouseEnter
        PictureBox47.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox47_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.MouseLeave
        PictureBox47.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.Click
        PictureBox47.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar6.Value = 0
        Label10.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label10.Text = "Uninstallation complete"
            ProgressBar6.Value = 100
        End If

    End Sub

    Private Sub PictureBox49_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox49.MouseEnter
        PictureBox49.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox49_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox49.MouseLeave
        PictureBox49.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox49.Click
        PictureBox49.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar7.Value = 0
        Label17.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "usp.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label17.Text = "Uninstallation complete"
            ProgressBar7.Value = 100
        End If

    End Sub

    Private Sub PictureBox50_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.MouseEnter
        PictureBox50.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox50_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.MouseLeave
        PictureBox50.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.Click
        Me.ResetUi()
        PictureBox50.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox40.Checked = False And CheckBox43.Checked = False And CheckBox39.Checked = False And CheckBox42.Checked = False And CheckBox41.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_e200v1_e200r.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_e200v1_e200r.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar7.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/E200v1_E200R/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label17.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox51_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox51.MouseEnter
        PictureBox51.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox51_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox51.MouseLeave
        PictureBox51.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox51.Click
        PictureBox51.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar9.Value = 0
        Label56.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "usp.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label56.Text = "Uninstallation complete"
            ProgressBar9.Value = 100
        End If

    End Sub

    Private Sub PictureBox52_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.MouseEnter
        PictureBox52.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox52_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.MouseLeave
        PictureBox52.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.Click
        Me.ResetUi()
        PictureBox52.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox45.Checked = False And CheckBox48.Checked = False And CheckBox44.Checked = False And CheckBox47.Checked = False And CheckBox46.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_c200v1.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_c200v1.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar9.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/C200v1/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label56.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox54_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.MouseEnter
        PictureBox54.Image = My.Resources._1ClickInstallO
    End Sub

    Private Sub PictureBox54_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.MouseLeave
        PictureBox54.Image = My.Resources._1ClickInstall
    End Sub

    Private Sub PictureBox54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.Click
        Me.ResetUi()
        PictureBox54.Image = My.Resources._1_Click_InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox50.Checked = False And CheckBox53.Checked = False And CheckBox49.Checked = False And CheckBox52.Checked = False And CheckBox51.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_e200v1_e200r.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_e200v1_e200r.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar8.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/E200v1_E200R/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label51.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox53_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox53.MouseEnter
        PictureBox53.Image = My.Resources._1ClickUninstallO
    End Sub

    Private Sub PictureBox53_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox53.MouseLeave
        PictureBox53.Image = My.Resources._1ClickUninstall
    End Sub

    Private Sub PictureBox53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox53.Click
        PictureBox53.Image = My.Resources._1ClickUninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar8.Value = 0
        Label51.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        Dim Proc As New System.Diagnostics.Process
        Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "usrp.bat")
        Proc.WaitForExit()

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label51.Text = "Uninstallation complete"
            ProgressBar8.Value = 100
        End If

    End Sub

    Private Sub PictureBox29_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.MouseEnter
        PictureBox29.Image = My.Resources.Instal_uninstalllO
    End Sub

    Private Sub PictureBox29_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.MouseLeave
        PictureBox29.Image = My.Resources.Install_uninstall
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        PictureBox29.Image = My.Resources.Instal_uninstallP
        Shell("cmd.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub PictureBox30_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.MouseEnter
        PictureBox30.Image = My.Resources.Instal_uninstalllO
    End Sub

    Private Sub PictureBox30_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.MouseLeave
        PictureBox30.Image = My.Resources.Install_uninstall
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        PictureBox30.Image = My.Resources.Instal_uninstallP
        Process.Start("Patcher\sansapatcher.exe")
    End Sub

    Private Sub PictureBox31_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.MouseEnter
        PictureBox31.Image = My.Resources.Instal_uninstalllO
    End Sub

    Private Sub PictureBox31_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.MouseLeave
        PictureBox31.Image = My.Resources.Install_uninstall
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        PictureBox31.Image = My.Resources.Instal_uninstallP
        Process.Start("Patcher\e200rpatcher.exe")
    End Sub

    Private Sub PictureBox57_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox57.MouseEnter
        PictureBox57.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox57_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox57.MouseLeave
        PictureBox57.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox57.Click
        Me.ResetUi()
        PictureBox57.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox2.Checked = False And CheckBox5.Checked = False And CheckBox1.Checked = False And CheckBox4.Checked = False And CheckBox3.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_video.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_video.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar10.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Video/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label61.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox60_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.MouseEnter
        PictureBox60.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox60_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.MouseLeave
        PictureBox60.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.Click
        Me.ResetUi()
        PictureBox60.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox14.Checked = False And CheckBox55.Checked = False And CheckBox13.Checked = False And CheckBox54.Checked = False And CheckBox15.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_nano.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_nano.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar11.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Nano_1G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label62.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox63_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox63.MouseEnter
        PictureBox63.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox63_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox63.MouseLeave
        PictureBox63.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox63.Click
        Me.ResetUi()
        PictureBox63.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox57.Checked = False And CheckBox60.Checked = False And CheckBox56.Checked = False And CheckBox59.Checked = False And CheckBox58.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_4g_photo.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_4g_photo.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar12.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Photo/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label63.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox66_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.MouseEnter
        PictureBox66.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox66_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.MouseLeave
        PictureBox66.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.Click
        Me.ResetUi()
        PictureBox66.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox62.Checked = False And CheckBox65.Checked = False And CheckBox61.Checked = False And CheckBox64.Checked = False And CheckBox63.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_4g_grayscale.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_4g_grayscale.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar13.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_4G_Grayscale/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label64.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox69_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox69.MouseEnter
        PictureBox69.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox69_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox69.MouseLeave
        PictureBox69.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox69.Click
        Me.ResetUi()
        PictureBox69.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox67.Checked = False And CheckBox70.Checked = False And CheckBox66.Checked = False And CheckBox69.Checked = False And CheckBox68.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_mini_2g.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_mini_2g.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar14.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Mini_2G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label65.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox72_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox72.MouseEnter
        PictureBox72.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox72_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox72.MouseLeave
        PictureBox72.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox72.Click
        Me.ResetUi()
        PictureBox72.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox72.Checked = False And CheckBox75.Checked = False And CheckBox71.Checked = False And CheckBox74.Checked = False And CheckBox73.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_mini_1g.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_mini_1g.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar15.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/iPod_Mini_1G/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label66.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox75_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox75.MouseEnter
        PictureBox75.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox75_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox75.MouseLeave
        PictureBox75.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox75.Click
        Me.ResetUi()
        PictureBox75.Image = My.Resources.InstallP

        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox77.Checked = False And CheckBox80.Checked = False And CheckBox76.Checked = False And CheckBox79.Checked = False And CheckBox78.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_e200v1_e200r.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_e200v1_e200r.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar16.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/E200v1_E200R/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label67.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox78_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox78.MouseEnter
        PictureBox78.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox78_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox78.MouseLeave
        PictureBox78.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox78.Click
        Me.ResetUi()
        PictureBox78.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox82.Checked = False And CheckBox85.Checked = False And CheckBox81.Checked = False And CheckBox84.Checked = False And CheckBox83.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_e200v1_e200r.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_e200v1_e200r.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar17.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/E200v1_E200R/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label72.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox81_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox81.MouseEnter
        PictureBox81.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox81_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox81.MouseLeave
        PictureBox81.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox81.Click
        Me.ResetUi()
        PictureBox81.Image = My.Resources.InstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If CheckBox87.Checked = False And CheckBox90.Checked = False And CheckBox86.Checked = False And CheckBox89.Checked = False And CheckBox88.Checked = False Then
            MsgBox("Please select Payload")
        Else
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exist, RockBox-PSGroove Installer will delete it and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
            aPath = System.IO.Path.GetDirectoryName(aName)

            If My.Computer.FileSystem.FileExists(aPath & "\" & "PSGroove_c200v1.zip") Then
                Label6.Text = "Installing..."
                Dim ZipToUnpack As String = aPath & "\" & "PSGroove_c200v1.zip"
                Dim TargetDir As String = FolderBrowserDialog1.SelectedPath

                Console.WriteLine(ZipToUnpack, TargetDir)
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    For Each ZipEntry In zip1
                        ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    ProgressBar18.Value = 100
                    Dim Installation As New Installation
                    Installation.ClassSub()
                End Using
            Else
                WC.DownloadFileAsync(New Uri("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/Installer_files/2.1/C200v1/PSGroove.zip"), aPath & "\" & "PSGroove.zip")
                Label77.Text = "Downloading..."
            End If
        End If
        If CheckBox119.Checked = True Then
            MHUFreeStore.Show()
        End If
        Me.ResetUi2()
    End Sub

    Private Sub PictureBox56_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.MouseEnter
        PictureBox56.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox56_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.MouseLeave
        PictureBox56.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.Click
        PictureBox56.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar10.Value = 0
        Label61.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label61.Text = "Uninstallation complete"
            ProgressBar10.Value = 100
        End If
    End Sub
    Private Sub PictureBox59_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox59.MouseEnter
        PictureBox59.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox59_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox59.MouseLeave
        PictureBox59.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox59.Click
        PictureBox59.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar11.Value = 0
        Label62.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label62.Text = "Uninstallation complete"
            ProgressBar11.Value = 100
        End If
    End Sub
    Private Sub PictureBox62_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.MouseEnter
        PictureBox62.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox62_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.MouseLeave
        PictureBox62.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.Click
        PictureBox62.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar12.Value = 0
        Label63.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label63.Text = "Uninstallation complete"
            ProgressBar12.Value = 100
        End If
    End Sub
    Private Sub PictureBox65_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox65.MouseEnter
        PictureBox65.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox65_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox65.MouseLeave
        PictureBox65.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox65.Click
        PictureBox65.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar13.Value = 0
        Label64.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label64.Text = "Uninstallation complete"
            ProgressBar13.Value = 100
        End If
    End Sub
    Private Sub PictureBox68_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.MouseEnter
        PictureBox68.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox68_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.MouseLeave
        PictureBox68.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.Click
        PictureBox68.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar14.Value = 0
        Label65.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label65.Text = "Uninstallation complete"
            ProgressBar14.Value = 100
        End If
    End Sub
    Private Sub PictureBox71_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox71.MouseEnter
        PictureBox71.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox71_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox71.MouseLeave
        PictureBox71.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox71.Click
        PictureBox71.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar15.Value = 0
        Label66.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") = False Then
            Label66.Text = "Uninstallation complete"
            ProgressBar15.Value = 100
        End If
    End Sub
    Private Sub PictureBox74_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox74.MouseEnter
        PictureBox74.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox74_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox74.MouseLeave
        PictureBox74.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox74.Click
        PictureBox74.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar16.Value = 0
        Label67.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label67.Text = "Uninstallation complete"
            ProgressBar16.Value = 100
        End If
    End Sub
    Private Sub PictureBox77_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox77.MouseEnter
        PictureBox77.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox77_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox77.MouseLeave
        PictureBox77.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox77.Click
        PictureBox77.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar17.Value = 0
        Label72.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label72.Text = "Uninstallation complete"
            ProgressBar17.Value = 100
        End If
    End Sub
    Private Sub PictureBox80_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox80.MouseEnter
        PictureBox80.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox80_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox80.MouseLeave
        PictureBox80.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox80.Click
        PictureBox80.Image = My.Resources.UninstallP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        ProgressBar18.Value = 0
        Label77.Text = "Uninstalling.."

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
            My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg") Then
            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "MhuFreeStore.pkg")
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") = False And My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") = False Then
            Label77.Text = "Uninstallation complete"
            ProgressBar18.Value = 100
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.InstallO
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.Install
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = My.Resources.InstallP
        If FolderBrowserDialog2.SelectedPath = "" Then
            MsgBox("You didn't select Plug-In directory.")
            FolderBrowserDialog2.ShowDialog()
        End If

        TextBox3.Text = FolderBrowserDialog2.SelectedPath

        Dim Proc As New System.Diagnostics.Process

        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\PSGroove") Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                MsgBox("Folder already exists. RockBox-PSGroove Installer will delete the old folder, and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                My.Computer.FileSystem.CopyDirectory(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\PSGroove", FolderBrowserDialog1.SelectedPath & "\" & "PSGroove")
            Else
                My.Computer.FileSystem.CopyDirectory(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\PSGroove", FolderBrowserDialog1.SelectedPath & "\" & "PSGroove")
            End If
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\.rockbox") Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                MsgBox("Folder already exists. RockBox-PSGroove Installer will delete the old folder, and create a new one")
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                My.Computer.FileSystem.CopyDirectory(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\.rockbox", FolderBrowserDialog1.SelectedPath & "\" & ".rockbox")
            Else
                My.Computer.FileSystem.CopyDirectory(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\.rockbox", FolderBrowserDialog1.SelectedPath & "\" & ".rockbox")
            End If
        End If
        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\loader.cfg") Then
            If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
                MsgBox("File already exists. RockBox-PSGroove Installer will delete the old file, and create a new one")
                My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
                My.Computer.FileSystem.CopyFile(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\loader.cfg", FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
            Else
                My.Computer.FileSystem.CopyFile(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\loader.cfg", FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
            End If
        End If
        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\cbl.cfg") Then
            If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
                MsgBox("File already exists. RockBox-PSGroove Installer will delete the old file, and create a new one")
                My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
                My.Computer.FileSystem.CopyFile(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\cbl.cfg", FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
            Else
                My.Computer.FileSystem.CopyFile(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\cbl.cfg", FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
            End If
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "ipodpatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "iip.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "sansapatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "isp.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "e200rpatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "isrp.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "CBLv0.3.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "icblp.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "BL.txt") Then
            Dim reader As String
            reader = My.Computer.FileSystem.ReadAllText(FolderBrowserDialog2.SelectedPath & "\" & "BL.txt")
            MsgBox(reader)
            FolderBrowserDialog1.ShowDialog()

            Dim foundfile As String
            For Each foundfile In My.Computer.FileSystem.GetFiles(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\BL", FileIO.SearchOption.SearchTopLevelOnly)
                My.Computer.FileSystem.CopyFile(foundfile, FolderBrowserDialog1.SelectedPath & "\" & My.Computer.FileSystem.GetName(foundfile))
            Next
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "PKG.txt") Then
            Dim foundfile As String
            For Each foundfile In My.Computer.FileSystem.GetFiles(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\PKG", FileIO.SearchOption.SearchTopLevelOnly)
                My.Computer.FileSystem.CopyFile(foundfile, FolderBrowserDialog1.SelectedPath & "\" & My.Computer.FileSystem.GetName(foundfile))
            Next
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.UninstallO
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.Uninstall
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = My.Resources.UninstallP
        If FolderBrowserDialog2.SelectedPath = "" Then
            MsgBox("You didn't select Plug-In directory.")
            FolderBrowserDialog2.ShowDialog()
        End If

        TextBox3.Text = FolderBrowserDialog2.SelectedPath

        Dim Proc As New System.Diagnostics.Process

        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select Device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\PSGroove") Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & "PSGroove", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If
        End If

        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\.rockbox") Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                My.Computer.FileSystem.DeleteDirectory(FolderBrowserDialog1.SelectedPath & "\" & ".rockbox", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If
        End If
        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\loader.cfg") Then
            If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg") Then
                My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg")
            End If
        End If
        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "PlugIn\cbl.cfg") Then
            If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg") Then
                My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg")
            End If
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "ipodpatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "uip.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "sansapatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "usp.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "e200rpatcher.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "usrp.bat")
        End If

        If My.Computer.FileSystem.FileExists(FolderBrowserDialog2.SelectedPath & "\" & "CBLv0.3.txt") Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "ucblp.bat")
        End If

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://download.rockbox.org/bootloader/sandisk-sansa/e200r-patcher/e200-manufac-driver.zip")
    End Sub

    Private Sub CheckBox92_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox92.CheckedChanged
        If CheckBox92.Checked = False Then
            TextBox5.ReadOnly = True
            TextBox5.BackColor = Color.WhiteSmoke
        End If
        If CheckBox92.Checked = True Then
            TextBox5.ReadOnly = False
            TextBox5.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox95_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox95.CheckedChanged
        If CheckBox95.Checked = False Then
            TextBox7.ReadOnly = True
            TextBox7.BackColor = Color.WhiteSmoke
        End If
        If CheckBox95.Checked = True Then
            TextBox7.ReadOnly = False
            TextBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox91_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox91.CheckedChanged
        If CheckBox91.Checked = False Then
            TextBox6.ReadOnly = True
            TextBox6.BackColor = Color.WhiteSmoke
        End If
        If CheckBox91.Checked = True Then
            TextBox6.ReadOnly = False
            TextBox6.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox94_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox94.CheckedChanged
        If CheckBox94.Checked = False Then
            TextBox9.ReadOnly = True
            TextBox9.BackColor = Color.WhiteSmoke
        End If
        If CheckBox94.Checked = True Then
            TextBox9.ReadOnly = False
            TextBox9.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox93_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox93.CheckedChanged
        If CheckBox93.Checked = False Then
            TextBox8.ReadOnly = True
            TextBox8.BackColor = Color.WhiteSmoke
        End If
        If CheckBox93.Checked = True Then
            TextBox8.ReadOnly = False
            TextBox8.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox99_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox99.CheckedChanged
        If CheckBox99.Checked = False Then
            TextBox12.ReadOnly = True
            TextBox12.BackColor = Color.WhiteSmoke
        End If
        If CheckBox99.Checked = True Then
            TextBox12.ReadOnly = False
            TextBox12.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox100_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox100.CheckedChanged
        If CheckBox100.Checked = False Then
            TextBox13.ReadOnly = True
            TextBox13.BackColor = Color.WhiteSmoke
        End If
        If CheckBox100.Checked = True Then
            TextBox13.ReadOnly = False
            TextBox13.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.Create_loader_cfgO
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.Create_loader_cfg
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Image = My.Resources.Create_loader_cfgP
        If FolderBrowserDialog1.SelectedPath = "" Then
            MsgBox("You didn't select device directory.")
            FolderBrowserDialog1.ShowDialog()
        End If

        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", String.Empty, False, Encoding.GetEncoding(28591))
        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", TextBox4.Text, False, Encoding.GetEncoding(28591))

        If CheckBox99.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox12.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox100.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox13.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox92.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox5.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox95.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox7.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox91.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox6.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox94.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox9.Text, True, Encoding.GetEncoding(28591))
        End If

        If CheckBox93.Checked = True Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox8.Text, True, Encoding.GetEncoding(28591))
        End If

        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox11.Text, True, Encoding.GetEncoding(28591))
        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & TextBox10.Text, True, Encoding.GetEncoding(28591))

    End Sub

    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged

        If Label6.Text = "Downloading..." Then
            ProgressBar1.Value = e.ProgressPercentage
        End If

        If Label7.Text = "Downloading..." Then
            ProgressBar2.Value = e.ProgressPercentage
        End If

        If Label2.Text = "Downloading..." Then
            ProgressBar3.Value = e.ProgressPercentage
        End If

        If Label8.Text = "Downloading..." Then
            ProgressBar4.Value = e.ProgressPercentage
        End If

        If Label9.Text = "Downloading..." Then
            ProgressBar5.Value = e.ProgressPercentage
        End If

        If Label10.Text = "Downloading..." Then
            ProgressBar6.Value = e.ProgressPercentage
        End If

        If Label17.Text = "Downloading..." Then
            ProgressBar7.Value = e.ProgressPercentage
        End If

        If Label51.Text = "Downloading..." Then
            ProgressBar8.Value = e.ProgressPercentage
        End If

        If Label56.Text = "Downloading..." Then
            ProgressBar9.Value = e.ProgressPercentage
        End If

        If Label61.Text = "Downloading..." Then
            ProgressBar10.Value = e.ProgressPercentage
        End If

        If Label62.Text = "Downloading..." Then
            ProgressBar11.Value = e.ProgressPercentage
        End If

        If Label63.Text = "Downloading..." Then
            ProgressBar12.Value = e.ProgressPercentage
        End If

        If Label64.Text = "Downloading..." Then
            ProgressBar13.Value = e.ProgressPercentage
        End If

        If Label65.Text = "Downloading..." Then
            ProgressBar14.Value = e.ProgressPercentage
        End If

        If Label66.Text = "Downloading..." Then
            ProgressBar15.Value = e.ProgressPercentage
        End If

        If Label67.Text = "Downloading..." Then
            ProgressBar16.Value = e.ProgressPercentage
        End If

        If Label72.Text = "Downloading..." Then
            ProgressBar17.Value = e.ProgressPercentage
        End If

        If Label77.Text = "Downloading..." Then
            ProgressBar18.Value = e.ProgressPercentage
        End If

    End Sub

    Private Sub wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        Dim ZipToUnpack As String = aPath & "\" & "PSGroove.zip"
        Dim TargetDir As String = FolderBrowserDialog1.SelectedPath
        Dim Proc As New System.Diagnostics.Process

        Console.WriteLine(ZipToUnpack, TargetDir)
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            For Each ZipEntry In zip1
                ZipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using

        Me.AfterExtract()

    End Sub

    Private Sub AfterExtract()

        aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        aPath = System.IO.Path.GetDirectoryName(aName)

        If ProgressBar1.Value = 100 Or ProgressBar10.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_video.zip")
        End If

        If ProgressBar2.Value = 100 Or ProgressBar11.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_nano.zip")
        End If

        If ProgressBar3.Value = 100 Or ProgressBar12.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_4g_photo.zip")
        End If

        If ProgressBar4.Value = 100 Or ProgressBar13.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_4g_grayscale.zip")
        End If

        If ProgressBar5.Value = 100 Or ProgressBar14.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_mini_2g.zip")
        End If

        If ProgressBar6.Value = 100 Or ProgressBar15.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_mini_1g.zip")
        End If

        If ProgressBar7.Value = 100 Or ProgressBar16.Value = 100 Or ProgressBar8.Value = 100 Or ProgressBar17.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_e200v1_e200r.zip")
        End If

        If ProgressBar9.Value = 100 Or ProgressBar18.Value = 100 Then
            My.Computer.FileSystem.RenameFile(aPath & "\" & "PSGroove.zip", "PSGroove_c200v1.zip")
        End If

        Dim Installation As New Installation
        Installation.ClassSub()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        webRequest = webRequest.Create("http://rockbox-psgroove.com/Download/RockBox-PSGroove_Installer/update/version.txt")
        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream())

        If inStream.ReadToEnd() > "2.2" Then
            Updater.Show()
        Else
            MsgBox("There is no available update." & Environment.NewLine & "2.2 is the last version.")
        End If
    End Sub
    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.Instal_uninstalllO
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.Install_uninstall
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = My.Resources.Instal_uninstallP
        Process.Start("Patcher\CBLv0.3.exe")
    End Sub

    Private Sub ResetUi()

        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
        ProgressBar5.Value = 0
        ProgressBar6.Value = 0
        ProgressBar7.Value = 0
        ProgressBar8.Value = 0
        ProgressBar9.Value = 0
        ProgressBar10.Value = 0
        ProgressBar11.Value = 0
        ProgressBar12.Value = 0
        ProgressBar13.Value = 0
        ProgressBar14.Value = 0
        ProgressBar15.Value = 0
        ProgressBar16.Value = 0
        ProgressBar17.Value = 0
        ProgressBar18.Value = 0

        Label6.Text = ""
        Label7.Text = ""
        Label2.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label17.Text = ""
        Label51.Text = ""
        Label56.Text = ""
        Label61.Text = ""
        Label62.Text = ""
        Label63.Text = ""
        Label64.Text = ""
        Label65.Text = ""
        Label66.Text = ""
        Label67.Text = ""
        Label72.Text = ""
        Label77.Text = ""

    End Sub

    Private Sub ResetUi2()

        CheckBox101.Checked = False
        CheckBox102.Checked = False
        CheckBox102.Checked = False
        CheckBox103.Checked = False
        CheckBox104.Checked = False
        CheckBox105.Checked = False
        CheckBox106.Checked = False
        CheckBox107.Checked = False
        CheckBox108.Checked = False
        CheckBox109.Checked = False
        CheckBox110.Checked = False
        CheckBox111.Checked = False
        CheckBox112.Checked = False
        CheckBox112.Checked = False
        CheckBox113.Checked = False
        CheckBox114.Checked = False
        CheckBox115.Checked = False
        CheckBox116.Checked = False
        CheckBox117.Checked = False
        CheckBox118.Checked = False
        CheckBox119.Checked = False

    End Sub

    Private Sub CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox101.CheckedChanged, CheckBox102.CheckedChanged, CheckBox102.CheckedChanged, CheckBox103.CheckedChanged, CheckBox104.CheckedChanged, CheckBox105.CheckedChanged, CheckBox106.CheckedChanged, CheckBox107.CheckedChanged, CheckBox108.CheckedChanged, CheckBox109.CheckedChanged, CheckBox110.CheckedChanged, CheckBox111.CheckedChanged, CheckBox112.CheckedChanged, CheckBox112.CheckedChanged, CheckBox113.CheckedChanged, CheckBox114.CheckedChanged, CheckBox115.CheckedChanged, CheckBox116.CheckedChanged, CheckBox117.CheckedChanged, CheckBox118.CheckedChanged, CheckBox119.CheckedChanged

        If CheckBox101.Checked = True Or CheckBox102.Checked = True Or CheckBox102.Checked = True Or CheckBox103.Checked = True Or CheckBox104.Checked = True Or CheckBox105.Checked = True Or CheckBox106.Checked = True Or CheckBox107.Checked = True Or CheckBox108.Checked = True Or CheckBox109.Checked = True Or CheckBox110.Checked = True Or CheckBox111.Checked = True Or CheckBox112.Checked = True Or CheckBox112.Checked = True Or CheckBox113.Checked = True Or CheckBox114.Checked = True Or CheckBox115.Checked = True Or CheckBox116.Checked = True Or CheckBox117.Checked = True Or CheckBox118.Checked = True Then
            CheckBox119.Checked = True
        End If
    End Sub
End Class

