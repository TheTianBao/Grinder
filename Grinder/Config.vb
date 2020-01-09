Imports System.IO

Public Class Config
    Private Sub CMDLoad_Click(sender As Object, e As EventArgs) Handles CMDLoad.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog As New OpenFileDialog()
        Dim i As Integer

        'openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog.Filter = "Grinder config (*.grinder)|*.grinder|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog.OpenFile()
                If (myStream IsNot Nothing) Then
                    Dim sr As New IO.StreamReader(myStream)



                    While (Not sr.EndOfStream)


                        'Attack Config
                        CBAttackBar.Text = sr.ReadLine
                        TBAttackTime.Text = sr.ReadLine
                        'Buff Config
                        TBAttackLoops.Text = sr.ReadLine
                        CBBuff.Text = sr.ReadLine
                        CBBuffBar.Text = sr.ReadLine
                        TBBuffTime.Text = sr.ReadLine
                        'Attack Keys
                        For i = 0 To CLBAttack.Items.Count - 1
                            If sr.ReadLine = "Checked" Then
                                CLBAttack.SetItemChecked(i, True)
                            Else
                                CLBAttack.SetItemChecked(i, False)
                            End If

                        Next
                        'Buff Keys
                        For i = 0 To CLBBuff.Items.Count - 1
                            If sr.ReadLine = "Checked" Then
                                CLBBuff.SetItemChecked(i, True)
                            Else
                                CLBBuff.SetItemChecked(i, False)
                            End If
                        Next
                    End While

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Chr(10) & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub CMDSave_Click(sender As Object, e As EventArgs) Handles CMDSave.Click
        Dim myStream As Stream = Nothing
        Dim sd As New SaveFileDialog 'declare save file dialog
        Dim i As Integer

        'sd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        sd.Filter = "Grinder config (*.grinder)|*.grinder|All files (*.*)|*.*"
        sd.FilterIndex = 1
        sd.RestoreDirectory = True

        If sd.ShowDialog = System.Windows.Forms.DialogResult.OK Then 'check if save file dialog was close after selecting a path
            Try
                myStream = sd.OpenFile()

                Using sw As New IO.StreamWriter(myStream)
                    'Attack Config
                    sw.WriteLine(String.Join(";", CBAttackBar.Text))
                    sw.WriteLine(String.Join(";", TBAttackTime.Text))
                    'Buff
                    sw.WriteLine(String.Join(";", TBAttackLoops.Text))
                    sw.WriteLine(String.Join(";", CBBuff.Text))
                    sw.WriteLine(String.Join(";", CBBuffBar.Text))
                    sw.WriteLine(String.Join(";", TBBuffTime.Text))
                    'Attack Keys
                    For i = 0 To CLBAttack.Items.Count - 1
                        sw.WriteLine(String.Join(";", CLBAttack.GetItemCheckState(i).ToString))
                    Next
                    For i = 0 To CLBBuff.Items.Count - 1
                        sw.WriteLine(String.Join(";", CLBBuff.GetItemCheckState(i).ToString))
                    Next



                End Using
            Catch Ex As Exception
                MessageBox.Show("Cannot write file to disk. Original error: " & Chr(10) & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try

        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Grinder.FRMConfig.Close()
    End Sub

    'Enable/Disable Fields
    Private Sub CBBuff_TextChanged(sender As Object, e As EventArgs) Handles CBBuff.TextChanged
        If CBBuff.Text = "Yes" Then
            'Attack
            CBAttackBar.Enabled = True
            TBAttackTime.Enabled = True
            'Buff
            TBAttackLoops.Enabled = True
            CBBuff.Enabled = True
            CBBuffBar.Enabled = True
            TBBuffTime.Enabled = True
        Else
            'Attack
            CBAttackBar.Enabled = False
            TBAttackTime.Enabled = True
            'Buff
            TBAttackLoops.Enabled = False
            CBBuff.Enabled = True
            CBBuffBar.Enabled = False
            TBBuffTime.Enabled = False
        End If
    End Sub

    Private Sub TBAttackTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBAttackTime.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBAttackLoops_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBAttackLoops.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBBuffTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuffTime.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class