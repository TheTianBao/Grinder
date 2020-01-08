
Public Class Grinder
    Public iRun As Integer
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
                    'Me.CheckBoxWork.Checked = True
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
End Class
