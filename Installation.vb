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

Imports System.Text

Public Class Installation
    Dim Proc As New System.Diagnostics.Process
    Dim aPath As String
    Dim aName As String

    Sub ClassSub()
        If RockBox_PSGroove_Installer.ProgressBar1.Value = 100 Then

            RockBox_PSGroove_Installer.Label6.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox12.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox6.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox9.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox8.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox10.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar2.Value = 100 Then

            RockBox_PSGroove_Installer.Label7.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox11.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox18.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox7.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox17.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox16.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar3.Value = 100 Then

            RockBox_PSGroove_Installer.Label2.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox20.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox23.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox19.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox22.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox21.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar4.Value = 100 Then

            RockBox_PSGroove_Installer.Label8.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox25.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox28.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox24.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox27.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox26.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar5.Value = 100 Then

            RockBox_PSGroove_Installer.Label9.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox30.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox33.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox29.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox32.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox31.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar6.Value = 100 Then

            RockBox_PSGroove_Installer.Label10.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox35.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox38.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox34.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox37.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox36.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar7.Value = 100 Then

            RockBox_PSGroove_Installer.Label17.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox40.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox43.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox39.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox42.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox41.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If

                If RockBox_PSGroove_Installer.RadioButton1.Checked Then
                    Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "isp.bat")
                    Proc.WaitForExit()
                    Sansa_default.Show()
                End If

                If RockBox_PSGroove_Installer.RadioButton2.Checked Then
                    Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "icblp.bat")
                    Proc.WaitForExit()
                    cbl_cfg.Show()
                End If

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar8.Value = 100 Then

            RockBox_PSGroove_Installer.Label51.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox50.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox53.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox49.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox52.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox51.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If

                Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "isrp.bat")
                Proc.WaitForExit()

                Sansa_default.Show()
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar9.Value = 100 Then

            RockBox_PSGroove_Installer.Label56.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox45.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox48.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox44.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox47.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox46.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If

                If RockBox_PSGroove_Installer.RadioButton4.Checked Then
                    Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "isp.bat")
                    Proc.WaitForExit()
                    Sansa_default.Show()
                End If

                If RockBox_PSGroove_Installer.RadioButton3.Checked Then
                    Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "icblp.bat")
                    Proc.WaitForExit()
                    cbl_cfg.Show()
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar10.Value = 100 Then

            RockBox_PSGroove_Installer.Label61.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox2.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox5.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox1.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox4.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox3.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label61.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar11.Value = 100 Then

            RockBox_PSGroove_Installer.Label62.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox14.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox55.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox13.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox54.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox15.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label62.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar12.Value = 100 Then

            RockBox_PSGroove_Installer.Label63.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox57.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox60.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox56.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox59.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox58.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label63.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar13.Value = 100 Then

            RockBox_PSGroove_Installer.Label64.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox62.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox65.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox61.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox64.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox63.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label64.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar14.Value = 100 Then

            RockBox_PSGroove_Installer.Label65.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox67.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox70.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox66.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox69.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox68.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label65.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar15.Value = 100 Then

            RockBox_PSGroove_Installer.Label66.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove") Then
                If RockBox_PSGroove_Installer.CheckBox72.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox75.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox71.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox74.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod")
                End If

                If RockBox_PSGroove_Installer.CheckBox73.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod")
                End If

                RockBox_PSGroove_Installer.Label66.Text = "Installation Complete"
                Installation_complete.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar16.Value = 100 Then

            RockBox_PSGroove_Installer.Label67.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox77.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox80.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox76.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox79.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox78.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If
                If RockBox_PSGroove_Installer.RadioButton6.Checked Then
                    Sansa_default.Show()
                End If

                If RockBox_PSGroove_Installer.RadioButton5.Checked Then
                    cbl_cfg.Show()
                End If
            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar17.Value = 100 Then

            RockBox_PSGroove_Installer.Label72.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox82.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox85.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox81.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox84.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox83.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If

                Sansa_default.Show()

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar18.Value = 100 Then

            RockBox_PSGroove_Installer.Label77.Text = "Installing..."

            If My.Computer.FileSystem.DirectoryExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox") Then
                If RockBox_PSGroove_Installer.CheckBox87.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox90.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox86.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox89.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4")
                End If

                If RockBox_PSGroove_Installer.CheckBox88.Checked = False Then
                    My.Computer.FileSystem.DeleteFile(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4")
                End If

                If RockBox_PSGroove_Installer.RadioButton8.Checked Then
                    Sansa_default.Show()
                End If

                If RockBox_PSGroove_Installer.RadioButton7.Checked Then
                    cbl_cfg.Show()
                End If

            End If
        End If

        If RockBox_PSGroove_Installer.ProgressBar2.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar3.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar4.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar5.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar6.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar11.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar12.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar13.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar14.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar15.Value = 100 Then

            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", String.Empty, True, Encoding.GetEncoding(28591))
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", "Apple OS @ ramimg", False, Encoding.GetEncoding(28591))

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\rockbox.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Rockbox @ (hd0,1)/.rockbox/rockbox.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "linux.bin") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "iPodLinux @ (hd0,1)/linux.bin", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "HWM @ (hd0,1)/PSGroove/HWM.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Hermes v4B @ (hd0,1)/PSGroove/H4B.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PL3 - 3.41 @ (hd0,1)/PSGroove/PL3_3_41.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PL3 - 3.15 @ (hd0,1)/PSGroove/PL3_3_15.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PL3 - 3.01 @ (hd0,1)/PSGroove/PL3_3_01.ipod", True, Encoding.GetEncoding(28591))
            End If

            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Disk Mode @ diskmode", True, Encoding.GetEncoding(28591))
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Sleep @ standby", True, Encoding.GetEncoding(28591))

        End If

        If RockBox_PSGroove_Installer.ProgressBar1.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar10.Value = 100 Then

            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", String.Empty, True, Encoding.GetEncoding(28591))
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", "Apple OS @ ramimg", False, Encoding.GetEncoding(28591))

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\rockbox.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Rockbox @ (hd0,1)/.rockbox/rockbox.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "linux.bin") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "iPodLinux @ (hd0,1)/linux.bin", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\HWM.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PSGroove HWM @ (hd0,1)/PSGroove/HWM.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\H4B.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PSGroove Hermes v4B @ (hd0,1)/PSGroove/H4B.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_41.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PSGroove PL3 - 3.41 @ (hd0,1)/PSGroove/PL3_3_41.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_15.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PSGroove PL3 - 3.15 @ (hd0,1)/PSGroove/PL3_3_15.ipod", True, Encoding.GetEncoding(28591))
            End If

            If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "PSGroove\PL3_3_01.ipod") Then
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "PSGroove PL3 - 3.01 @ (hd0,1)/PSGroove/PL3_3_01.ipod", True, Encoding.GetEncoding(28591))
            End If

            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Disk Mode @ diskmode", True, Encoding.GetEncoding(28591))
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "loader.cfg", Environment.NewLine & "Sleep @ standby", True, Encoding.GetEncoding(28591))

        End If

        If RockBox_PSGroove_Installer.ProgressBar1.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar2.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar3.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar4.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar5.Value = 100 Or RockBox_PSGroove_Installer.ProgressBar6.Value = 100 Then
            Proc = System.Diagnostics.Process.Start("Patcher" & "\" & "iip.bat")
            Proc.WaitForExit()

            If RockBox_PSGroove_Installer.ProgressBar1.Value = 100 Then
                RockBox_PSGroove_Installer.Label6.Text = "Installation Complete"
            End If

            If RockBox_PSGroove_Installer.ProgressBar2.Value = 100 Then
                RockBox_PSGroove_Installer.Label7.Text = "Installation Complete"
            End If

            If RockBox_PSGroove_Installer.ProgressBar3.Value = 100 Then
                RockBox_PSGroove_Installer.Label2.Text = "Installation Complete"
            End If

            If RockBox_PSGroove_Installer.ProgressBar4.Value = 100 Then
                RockBox_PSGroove_Installer.Label8.Text = "Installation Complete"
            End If

            If RockBox_PSGroove_Installer.ProgressBar5.Value = 100 Then
                RockBox_PSGroove_Installer.Label9.Text = "Installation Complete"
            End If

            If RockBox_PSGroove_Installer.ProgressBar6.Value = 100 Then
                RockBox_PSGroove_Installer.Label10.Text = "Installation Complete"
            End If

            Installation_complete.Show()
        End If
    End Sub

End Class
