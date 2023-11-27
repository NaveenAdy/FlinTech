Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmProcessTask
    Dim sw As New Stopwatch
    Dim startTime As New Date
    Dim stopWatch As New Diagnostics.Stopwatch
    Dim elapsed As New TimeSpan
    Dim elapsedonPausing As New TimeSpan
    Dim pauseFlag As New Boolean
    Dim elapsedPeriodonPausing As New TimeSpan
    Dim stopWatchForPausing As New Diagnostics.Stopwatch
    Dim isAlreadySave As New Boolean
    Private Sub frmProcessTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTaskName.Text = "Task In Progress :  " + GlobalVariables.selectedTaskName
        sw.Start()
        startTime = DateTime.Now()
        Timer1.Start()
        Me.stopWatch.Start()
        isAlreadySave = False
    End Sub
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        elapsedonPausing = Me.stopWatch.Elapsed
        Me.stopWatch.Stop()
        btnStart.Enabled = True
        pauseFlag = True
        Me.stopWatchForPausing.Reset()
        Me.stopWatchForPausing.Start()
        btnPause.Enabled = False
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (pauseFlag) Then
            stopWatchForPausing.Stop()
            elapsedPeriodonPausing += stopWatchForPausing.Elapsed.Duration()
            pauseFlag = False
            lblPausedPeriod.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsedPeriodonPausing.TotalHours), elapsedPeriodonPausing.Minutes, elapsedPeriodonPausing.Seconds)
        End If
        Me.stopWatch.Elapsed.Add(elapsedonPausing)
        Me.stopWatch.Start()
        btnStart.Enabled = False
        btnPause.Enabled = True
        lblPausedPeriod.Visible = True
        lblPausedText.Visible = True
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        sw.Stop()
        Dim remaining As TimeSpan = (Now.Subtract(startTime))
        Dim days As String = remaining.Days & " days"
        Dim hours As String = remaining.Hours & " hours"
        Dim minutes As String = remaining.Minutes & " minutes"
        'Dim remainingafterPausing As TimeSpan = remaining.Subtract(elapsedPeriodonPausing)
        lblElapsedTime.Text = sw.Elapsed.Duration().ToString()
        Timer1.Stop()
        Me.stopWatch.Stop()
        SaveWorkLogDetails()
        ntyFy1.Dispose()
        lblPausedPeriod.Visible = False
        lblPausedText.Visible = False
        Dim formALLTask As New frmALLTask
        Me.Hide()
        formALLTask.Show()
    End Sub
    Public Sub SaveWorkLogDetails()
        Dim daysWorked As Integer
        Dim hoursWorked As Integer
        Dim minutesWorked As Integer
        elapsed = Me.stopWatch.Elapsed
        lblTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds)
        daysWorked = elapsed.Days
        hoursWorked = Math.Floor(elapsed.TotalHours)
        minutesWorked = elapsed.Minutes
        Dim cmd As SqlCommand = New SqlCommand
        Using con As New SqlConnection(GlobalVariables.con)
            Try
                Dim da As New SqlDataAdapter
                Dim ds As New DataSet
                With cmd
                    .Connection = con
                    .Connection.Open()
                    .CommandText = "SaveWorkLogDetails"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@TaskID", GlobalVariables.selectedTaskId)
                    .Parameters.AddWithValue("@UserId", GlobalVariables.userId)
                    .Parameters.AddWithValue("@Days", daysWorked)
                    .Parameters.AddWithValue("@Hours", hoursWorked)
                    .Parameters.AddWithValue("@Minutes", minutesWorked)
                End With
                cmd.ExecuteNonQuery()
                isAlreadySave = True
                MessageBox.Show("Work Log of Task :" + GlobalVariables.selectedTaskName + ", Saved Successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cmd.Dispose()
            End Try
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerTick()
    End Sub
    Public Sub TimerTick()
        elapsed = Me.stopWatch.Elapsed
        lblTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds)
    End Sub

    Private Sub frmProcessTask_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                ntyFy1.Visible = True
                'ntyFy1.Text = lblTimer.Text
                Me.Hide()
                ntyFy1.BalloonTipText = lblTimer.Text
                ntyFy1.ShowBalloonTip(1, lblTimer.Text, "Running", ToolTipIcon.Info)
            Else
                ntyFy1.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmProcessTask(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Do You Want to Close the Form..?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If isAlreadySave = False Then
                SaveWorkLogDetails()
            End If
            Me.Dispose()
            Me.Close()
            ntyFy1.Visible = False
            ntyFy1.Dispose()
        End If
        If result = DialogResult.No Then
            Return
        End If
    End Sub
    Private Sub ntyFy1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ntyFy1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        ntyFy1.Visible = False
    End Sub
    Private Sub ntyFy1_MouseMove(sender As Object, e As MouseEventArgs) Handles ntyFy1.MouseMove
        'ntyFy1.ShowBalloonTip(0.5, lblTimer.Text, "Still Running", ToolTipIcon.Error)
        'ntyFy1.BalloonTipText = lblTimer.Text
        ntyFy1.Text = lblTimer.Text
    End Sub
End Class