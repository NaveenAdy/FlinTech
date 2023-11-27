<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessTask
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessTask))
        Me.ntyFy1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblPausedPeriod = New System.Windows.Forms.Label()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.lblPausedText = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ntyFy1
        '
        Me.ntyFy1.Icon = CType(resources.GetObject("ntyFy1.Icon"), System.Drawing.Icon)
        Me.ntyFy1.Text = "NotifyIcon1"
        Me.ntyFy1.Visible = True
        '
        'btnStop
        '
        Me.btnStop.Image = Global.FlinTech.My.Resources.Resources.stopsmall
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(403, 184)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(120, 23)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Image = Global.FlinTech.My.Resources.Resources.Pause
        Me.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPause.Location = New System.Drawing.Point(128, 184)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(127, 23)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "PAUSE"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Image = Global.FlinTech.My.Resources.Resources.Continue_Small
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(261, 184)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(136, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "CONTINUE"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(151, 251)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(39, 13)
        Me.lblElapsedTime.TabIndex = 3
        Me.lblElapsedTime.Text = "Label1"
        Me.lblElapsedTime.Visible = False
        '
        'Timer1
        '
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTimer.Font = New System.Drawing.Font("Copperplate Gothic Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTimer.Location = New System.Drawing.Point(266, 136)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(121, 30)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Text = "Label1"
        '
        'lblPausedPeriod
        '
        Me.lblPausedPeriod.AutoSize = True
        Me.lblPausedPeriod.Location = New System.Drawing.Point(585, 261)
        Me.lblPausedPeriod.Name = "lblPausedPeriod"
        Me.lblPausedPeriod.Size = New System.Drawing.Size(39, 13)
        Me.lblPausedPeriod.TabIndex = 5
        Me.lblPausedPeriod.Text = "Label1"
        Me.lblPausedPeriod.Visible = False
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblTaskName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.ForeColor = System.Drawing.Color.White
        Me.lblTaskName.Location = New System.Drawing.Point(151, 34)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(57, 20)
        Me.lblTaskName.TabIndex = 6
        Me.lblTaskName.Text = "Label1"
        '
        'lblPausedText
        '
        Me.lblPausedText.AutoSize = True
        Me.lblPausedText.Location = New System.Drawing.Point(477, 261)
        Me.lblPausedText.Name = "lblPausedText"
        Me.lblPausedText.Size = New System.Drawing.Size(102, 13)
        Me.lblPausedText.TabIndex = 7
        Me.lblPausedText.Text = "Total Paused Time :"
        Me.lblPausedText.Visible = False
        '
        'frmProcessTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlinTech.My.Resources.Resources.BlueGradient
        Me.ClientSize = New System.Drawing.Size(660, 332)
        Me.Controls.Add(Me.lblPausedText)
        Me.Controls.Add(Me.lblTaskName)
        Me.Controls.Add(Me.lblPausedPeriod)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStop)
        Me.Name = "frmProcessTask"
        Me.Text = "Process Task"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblElapsedTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Public WithEvents ntyFy1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents lblPausedPeriod As System.Windows.Forms.Label
    Friend WithEvents lblTaskName As System.Windows.Forms.Label
    Friend WithEvents lblPausedText As System.Windows.Forms.Label
End Class
