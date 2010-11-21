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

Public Class cbl_cfg

    Private Sub cbl_cfg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath = "" Then
            RockBox_PSGroove_Installer.FolderBrowserDialog1.ShowDialog()
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\rockbox.mi4") Then
            ComboBox1.Items.Add("RockBox")
            ComboBox2.Items.Add("RockBox")
            ComboBox3.Items.Add("RockBox")
            ComboBox4.Items.Add("RockBox")
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\HWM.mi4") Then
            ComboBox1.Items.Add("HWM")
            ComboBox2.Items.Add("HWM")
            ComboBox3.Items.Add("HWM")
            ComboBox4.Items.Add("HWM")
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\H4B.mi4") Then
            ComboBox1.Items.Add("H4B")
            ComboBox2.Items.Add("H4B")
            ComboBox3.Items.Add("H4B")
            ComboBox4.Items.Add("H4B")
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_41.mi4") Then
            ComboBox1.Items.Add("PL3_3_41")
            ComboBox2.Items.Add("PL3_3_41")
            ComboBox3.Items.Add("PL3_3_41")
            ComboBox4.Items.Add("PL3_3_41")
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_15.mi4") Then
            ComboBox1.Items.Add("PL3_3_15")
            ComboBox2.Items.Add("PL3_3_15")
            ComboBox3.Items.Add("PL3_3_15")
            ComboBox4.Items.Add("PL3_3_15")
        End If

        If My.Computer.FileSystem.FileExists(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & ".rockbox\PL3_3_01.mi4") Then
            ComboBox1.Items.Add("PL3_3_01")
            ComboBox2.Items.Add("PL3_3_01")
            ComboBox3.Items.Add("PL3_3_01")
            ComboBox4.Items.Add("PL3_3_01")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" And ComboBox2.Text = "" And ComboBox3.Text = "" And ComboBox4.Text = "" Then
            MsgBox("Select at least one button to launch RockBox-PSGroove with")
        Else
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", String.Empty, True, Encoding.GetEncoding(28591))
            My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", "cbl_fw_dir=/.rockbox/", False, Encoding.GetEncoding(28591))

            If ComboBox1.Text = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", Environment.NewLine & "btn_select=" + ComboBox1.Text + ".mi4", True, Encoding.GetEncoding(28591))
            End If

            If ComboBox2.Text = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", Environment.NewLine & "btn_up=" + ComboBox2.Text + ".mi4", True, Encoding.GetEncoding(28591))
            End If

            If ComboBox3.Text = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", Environment.NewLine & "btn_down=" + ComboBox3.Text + ".mi4", True, Encoding.GetEncoding(28591))
            End If

            If ComboBox4.Text = "" Then
            Else
                My.Computer.FileSystem.WriteAllText(RockBox_PSGroove_Installer.FolderBrowserDialog1.SelectedPath & "\" & "cbl.cfg", Environment.NewLine & "btn_right=" + ComboBox4.Text + ".mi4", True, Encoding.GetEncoding(28591))
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If RockBox_PSGroove_Installer.ProgressBar7.Value = 100 Then
            RockBox_PSGroove_Installer.Label17.Text = "Installation Complete"
            Installation_complete.Show()
        End If

        If RockBox_PSGroove_Installer.ProgressBar8.Value = 100 Then
            RockBox_PSGroove_Installer.Label51.Text = "Installation Complete"
            Installation_complete.Show()
        End If

        If RockBox_PSGroove_Installer.ProgressBar9.Value = 100 Then
            RockBox_PSGroove_Installer.Label56.Text = "Installation Complete"
            Installation_complete.Show()
        End If

        If RockBox_PSGroove_Installer.ProgressBar16.Value = 100 Then
            RockBox_PSGroove_Installer.Label67.Text = "Installation Complete"
            Installation_complete.Show()
        End If

        If RockBox_PSGroove_Installer.ProgressBar17.Value = 100 Then
            RockBox_PSGroove_Installer.Label72.Text = "Installation Complete"
            Installation_complete.Show()
        End If

        If RockBox_PSGroove_Installer.ProgressBar18.Value = 100 Then
            RockBox_PSGroove_Installer.Label77.Text = "Installation Complete"
            Installation_complete.Show()
        End If

    End Sub
End Class