
Imports System.IO

Public Class Grinder
    Public iRun As Integer
    Public FRMConfig As New Config
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        Dim iRebuffValue As Integer
        Dim iCountdown As Integer

        If CheckBox0.Checked = False And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False Then
            MsgBox("You need to select at least one Key")
            Exit Sub
        End If

        'Set Values of rebuff, if enabled
        If cbRebuff.Checked = True Then
            Try
                iRebuffValue = tbRebuff.Text
                iCountdown = tbRebuff.Text
            Catch ex As Exception
                MsgBox("The value of your rebuff time is not valid. Please Enter a new value.The Maximum value is 2147483647.")
                Exit Sub
            End Try
        End If

        'Start
        Try
            AppActivate("Origin")
        Catch ex As Exception

        End Try

        Me.lblStatus.ForeColor = Color.Green
        Me.lblStatus.Text = "Running"
        Me.lbAttackBar.Enabled = False
        Me.lbBuffBar.Enabled = False
        Me.tbRebuff.Enabled = False
        iRun = 1

        'Grinding Loop
        Do Until iRun = 0
            Call Grind()

            'Burn down the Countdown if Rebuff is used
            If cbRebuff.Checked = True Then
                iCountdown = iCountdown - 1
                Me.tbRebuff.Text = iCountdown
                If iCountdown = 0 Then
                End If
            End If
            'Start Rebuff
            If cbRebuff.Checked = True And iCountdown = 0 Then
                Call Rebuff()
                iCountdown = iRebuffValue
                Me.tbRebuff.Text = iRebuffValue
            End If

        Loop

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        iRun = 0
        Me.Close()
    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        Me.lblStatus.ForeColor = Color.Red
        Me.lblStatus.Text = "Not Running"
        Me.lbAttackBar.Enabled = True
        Me.lbBuffBar.Enabled = True
        Me.tbRebuff.Enabled = True
        iRun = 0
    End Sub
    'Start / Stop with Y/X
    Private Sub Grinder_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Y Then
            cmdStart_Click(sender, e)
        End If
        If e.KeyCode = Keys.X Then
            cmdStop_Click(sender, e)
        End If
    End Sub
    'Grind untill checkstate is changed
    Private Sub Grind()
        Dim iCountdown As Integer
        iCountdown = 1000
        'Do Stuff Here
        If CheckBox1.Checked = True Then
            SendKeys.SendWait("1")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox2.Checked = True Then
            SendKeys.SendWait("2")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox3.Checked = True Then
            SendKeys.SendWait("3")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox4.Checked = True Then
            SendKeys.SendWait("4")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox5.Checked = True Then
            SendKeys.SendWait("5")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox6.Checked = True Then
            SendKeys.SendWait("6")
            Threading.Thread.CurrentThread.Sleep(50)
            Countdown = iCountdown - 50
        End If

        If CheckBox7.Checked = True Then
            SendKeys.SendWait("7")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50

        End If

        If CheckBox8.Checked = True Then
            SendKeys.SendWait("8")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox9.Checked = True Then
            SendKeys.SendWait("9")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If

        If CheckBox0.Checked = True Then
            SendKeys.SendWait("0")
            Threading.Thread.CurrentThread.Sleep(50)
            iCountdown = iCountdown - 50
        End If
        Threading.Thread.CurrentThread.Sleep(iCountdown)

    End Sub
    'Do the Rebuff
    Private Sub Rebuff()
        Threading.Thread.CurrentThread.Sleep(5000)
        SendKeys.Send("{" + lbBuffBar.Text + "}")

        If CheckBoxBuff1.Checked = True Then
            SendKeys.SendWait("1")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff2.Checked = True Then
            SendKeys.SendWait("2")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff3.Checked = True Then
            SendKeys.SendWait("3")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff4.Checked = True Then
            SendKeys.SendWait("4")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff5.Checked = True Then
            SendKeys.SendWait("5")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff6.Checked = True Then
            SendKeys.SendWait("6")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff7.Checked = True Then
            SendKeys.SendWait("7")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff8.Checked = True Then
            SendKeys.SendWait("8")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff9.Checked = True Then
            SendKeys.SendWait("9")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        If CheckBoxBuff0.Checked = True Then
            SendKeys.SendWait("0")
            Threading.Thread.CurrentThread.Sleep(5000)
        End If

        SendKeys.Send("{" + lbAttackBar.Text + "}")

    End Sub
    'Change the Enabled status if Rebuff is Enabled
    Private Sub cbRebuff_CheckedChanged(sender As Object, e As EventArgs) Handles cbRebuff.CheckedChanged
        If cbRebuff.Checked = True Then
            Me.lbBuffBar.Enabled = True
            Me.lbAttackBar.Enabled = True
            Me.tbRebuff.Enabled = True
            Me.CheckBoxBuff0.Enabled = True
            Me.CheckBoxBuff1.Enabled = True
            Me.CheckBoxBuff2.Enabled = True
            Me.CheckBoxBuff3.Enabled = True
            Me.CheckBoxBuff4.Enabled = True
            Me.CheckBoxBuff5.Enabled = True
            Me.CheckBoxBuff6.Enabled = True
            Me.CheckBoxBuff7.Enabled = True
            Me.CheckBoxBuff8.Enabled = True
            Me.CheckBoxBuff9.Enabled = True


        Else
            Me.lbBuffBar.Enabled = False
            Me.lbAttackBar.Enabled = False
            Me.tbRebuff.Enabled = False
            Me.CheckBoxBuff0.Enabled = False
            Me.CheckBoxBuff1.Enabled = False
            Me.CheckBoxBuff2.Enabled = False
            Me.CheckBoxBuff3.Enabled = False
            Me.CheckBoxBuff4.Enabled = False
            Me.CheckBoxBuff5.Enabled = False
            Me.CheckBoxBuff6.Enabled = False
            Me.CheckBoxBuff7.Enabled = False
            Me.CheckBoxBuff8.Enabled = False
            Me.CheckBoxBuff9.Enabled = False
        End If
    End Sub

    Private Sub CMDLoad_Click(sender As Object, e As EventArgs) Handles CMDLoad.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog As New OpenFileDialog()

        'openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog.Filter = "Grinder config (*.grinder)|*.grinder|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        OpenFileDialog.RestoreDirectory = True

        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog.OpenFile()
                If (myStream IsNot Nothing) Then
                    Dim sr As New IO.StreamReader(myStream)



                    While (Not sr.EndOfStream)


                        'Basic Config
                        cbRebuff.Checked = Convert.ToBoolean(sr.ReadLine)
                        lbBuffBar.Text = sr.ReadLine
                        lbAttackBar.Text = sr.ReadLine
                        tbRebuff.Text = sr.ReadLine
                        'Keys
                        Me.CheckBox0.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox1.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox2.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox3.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox4.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox5.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox6.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox7.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox8.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBox9.Checked = Convert.ToBoolean(sr.ReadLine)
                        'Buff
                        Me.CheckBoxBuff0.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff1.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff2.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff3.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff4.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff5.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff6.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff7.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff8.Checked = Convert.ToBoolean(sr.ReadLine)
                        Me.CheckBoxBuff9.Checked = Convert.ToBoolean(sr.ReadLine)

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

        'sd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        sd.Filter = "Grinder config (*.grinder)|*.grinder|All files (*.*)|*.*"
        sd.FilterIndex = 1
        sd.RestoreDirectory = True

        If sd.ShowDialog = System.Windows.Forms.DialogResult.OK Then 'check if save file dialog was close after selecting a path
            Try
                myStream = sd.OpenFile()

                Using sw As New IO.StreamWriter(myStream)
                    'Basic Config
                    sw.WriteLine(String.Join(";", cbRebuff.Checked))
                    sw.WriteLine(String.Join(";", lbBuffBar.Text))
                    sw.WriteLine(String.Join(";", lbAttackBar.Text))
                    sw.WriteLine(String.Join(";", tbRebuff.Text))
                    'Keys
                    sw.WriteLine(String.Join(";", Me.CheckBox0.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox1.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox2.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox3.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox4.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox5.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox6.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox7.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox8.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBox9.Checked))
                    'Buff
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff0.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff1.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff2.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff3.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff4.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff5.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff6.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff7.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff8.Checked))
                    sw.WriteLine(String.Join(";", Me.CheckBoxBuff9.Checked))
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

    Private Sub CMDPayPal_Click(sender As Object, e As EventArgs) Handles CMDPayPal.Click
        Process.Start("https://www.paypal.com/pools/c/8lu4vqskG6")
    End Sub
    'Stop when focused
    Private Sub Grinder_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cmdStop_Click(sender, e)
    End Sub

    Private Sub CMS_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CMS.ItemClicked

        If e.ClickedItem.Text = "About Grinder" Then
            Dim oForm As New About
            oForm.Show()
        End If

        If e.ClickedItem.Text = "Open Configuration" Then

            FRMConfig.ShowDialog()
        End If

        If e.ClickedItem.Text = "GitHub" Then
            Process.Start("https://github.com/TheTianBao/Grinder")
        End If

        If e.ClickedItem.Text = "Donate" Then
            Process.Start("https://www.paypal.com/pools/c/8lu4vqskG6")
        End If

    End Sub
End Class
