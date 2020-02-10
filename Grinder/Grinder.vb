
Imports System.IO

Public Class Grinder
    Public iRun As Integer
    Public FRMConfig As New Config

    'NewStuff
    Dim Tm As New Timer
    Private Declare Auto Function FindWindow Lib "user32" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Declare Auto Function PostMessage Lib "USER32.DLL" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    Private Const MK_LBUTTON = &H1
    Private Const WM_LBUTTONDOWN = &H201

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles CMDStart.Click

        Dim iRebuffValue As Integer
        Dim iCountdown As Integer
        Dim CheckAttackKeys As Boolean = False
        Dim CheckBuffKeys As Boolean = False

        'Check for AttackTime
        If FRMConfig.TBAttackTime.Text = "" Then
            MsgBox("Please check the configuration. AttackTime is not set correctly. Default set to 500ms.")
            FRMConfig.TBAttackTime.Text = 500
            Exit Sub
        End If

        'Check for AttackKeys need to set at least one
        For i = 0 To FRMConfig.CLBAttack.Items.Count - 1
            If FRMConfig.CLBAttack.GetItemCheckState(i).ToString = "Checked" Then
                CheckAttackKeys = True
            End If
        Next
        If CheckAttackKeys = False Then
            MsgBox("Please check the configuration. You need to select at least 1 Attack Key.")
            Exit Sub
        End If

        'Check for BuffTime if Rebuff is used
        If FRMConfig.CBBuff.Text = "Yes" And FRMConfig.TBAttackLoops.Text = "" Then
            MsgBox("Please check the configuration. Time between buffs is not set correctly.Default set to 5000ms.")
            FRMConfig.CBBuff.Text = 5000
            Exit Sub
        End If

        'Check for AttackKeys need to set at least one
        For i = 0 To FRMConfig.CLBBuff.Items.Count - 1
            If FRMConfig.CLBBuff.GetItemCheckState(i).ToString = "Checked" Then
                CheckBuffKeys = True
            End If
        Next
        If FRMConfig.CBBuff.Text = "Yes" And CheckBuffKeys = False Then
            MsgBox("Please check the configuration. You need to select at least 1 Buff Key while using Rebuff mode.")
            Exit Sub
        End If

        'Set Values of rebuff, if enabled
        If FRMConfig.CBBuff.Text = "Yes" Then
            Try
                iRebuffValue = CInt(FRMConfig.TBAttackLoops.Text)
                iCountdown = CInt(FRMConfig.TBAttackLoops.Text)
            Catch ex As Exception
                MsgBox("The value of your rebuff time is not valid. Please Enter a new value.The Maximum value is 2147483647.")
                Exit Sub
            End Try
        End If

        Me.lblStatus.ForeColor = Color.Green
        Me.lblStatus.Text = "Running"
        'Me.lbAttackBar.Enabled = False
        'Me.lbBuffBar.Enabled = False
        'Me.tbRebuff.Enabled = False
        iRun = 1

        'Grinding Loop
        Do Until iRun = 0
            Call Grind()

            'Burn down the Countdown if Rebuff is used
            If FRMConfig.CBBuff.Text = "Yes" Then
                iCountdown = iCountdown - 1
                'Me.tbRebuff.Text = iCountdown
                If iCountdown = 0 Then
                End If
            End If
            'Start Rebuff
            If FRMConfig.CBBuff.Text = "Yes" And iCountdown = 0 Then
                Call Rebuff()
                iCountdown = iRebuffValue
                'Me.tbRebuff.Text = iRebuffValue
            End If

        Loop

    End Sub
    'Start / Stop with Y/X
    Private Sub Grinder_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Y Then
            cmdStart_Click(sender, e)
        End If
        If e.KeyCode = Keys.X Then
            Call StopGrinder()
        End If
    End Sub
    'Grind untill checkstate is changed
    Private Sub Grind()
        Dim iSleep As Integer


        iSleep = CInt(FRMConfig.TBAttackTime.Text)


        If FRMConfig.CLBAttack.GetItemChecked(1) = True Then
            SendKeys.SendWait("1")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(2) = True Then
            SendKeys.SendWait("2")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(3) = True Then
            SendKeys.SendWait("3")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(4) Then
            SendKeys.SendWait("4")
            Threading.Thread.CurrentThread.Sleep(iSleep)

        End If

        If FRMConfig.CLBAttack.GetItemChecked(5) Then
            SendKeys.SendWait("5")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(6) Then
            SendKeys.SendWait("6")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(7) Then
            SendKeys.SendWait("7")
            Threading.Thread.CurrentThread.Sleep(iSleep)

        End If

        If FRMConfig.CLBAttack.GetItemChecked(8) Then
            SendKeys.SendWait("8")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(9) Then
            SendKeys.SendWait("9")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBAttack.GetItemChecked(0) Then
            SendKeys.SendWait("0")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        Threading.Thread.CurrentThread.Sleep(500)

    End Sub
    'Do the Rebuff
    Private Sub Rebuff()
        Dim iSleep As Integer
        iSleep = CInt(FRMConfig.TBBuffTime.Text)



        SendKeys.Send("{" + FRMConfig.CBBuffBar.Text + "}")

        If FRMConfig.CLBBuff.GetItemChecked(1) = True Then
            SendKeys.SendWait("1")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(2) = True Then
            SendKeys.SendWait("2")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(3) = True Then
            SendKeys.SendWait("3")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(4) Then
            SendKeys.SendWait("4")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(5) Then
            SendKeys.SendWait("5")

            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(6) Then
            SendKeys.SendWait("6")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(7) Then
            SendKeys.SendWait("7")
            Threading.Thread.CurrentThread.Sleep(iSleep)

        End If

        If FRMConfig.CLBBuff.GetItemChecked(8) Then
            SendKeys.SendWait("8")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(9) Then
            SendKeys.SendWait("9")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        If FRMConfig.CLBBuff.GetItemChecked(0) Then
            SendKeys.SendWait("0")
            Threading.Thread.CurrentThread.Sleep(iSleep)
        End If

        SendKeys.Send("{" + FRMConfig.CBAttackBar.Text + "}")

    End Sub



    Private Sub CMDPayPal_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.paypal.com/pools/c/8lu4vqskG6")
    End Sub
    'Stop when focused
    Private Sub Grinder_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call StopGrinder()
    End Sub

    Private Sub CMS_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CMS.ItemClicked


        If e.ClickedItem.Text = "Open Configuration" Then
            FRMConfig.ShowDialog()
        End If

        If e.ClickedItem.Text = "Open GitHub" Then
            Process.Start("https://github.com/TheTianBao/Grinder")
        End If

        If e.ClickedItem.Text = "Donate for Grinder" Then
            Process.Start("https://www.paypal.com/pools/c/8lu4vqskG6")
        End If

    End Sub
    Private Sub StopGrinder()
        Me.lblStatus.ForeColor = Color.Red
        Me.lblStatus.Text = "Not Running"
        iRun = 0
    End Sub

    Private Sub CMDMenu_Click(sender As Object, e As EventArgs) Handles CMDMenu.Click
        FRMConfig.ShowDialog()
    End Sub

    Private Sub CMDHelp_Click(sender As Object, e As EventArgs) Handles CMDHelp.Click
        Me.CMS.Show(Control.MousePosition)
    End Sub

    Private Sub CMDRunClient_Click(sender As Object, e As EventArgs) Handles CMDRunClient.Click
        ' ("C:\Program Files (x86)\Origin Online\Launcher.exe")

        Dim whnd As IntPtr = FindWindow(vbNullString, "untitled - notepad")
        PostMessage(whnd, WM_LBUTTONDOWN, MK_LBUTTON, 30)

    End Sub





End Class
