<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALLTask
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTaskDetails = New System.Windows.Forms.DataGridView()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnStartinTask = New System.Windows.Forms.Button()
        Me.lblLazyDeveloper = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoggedUser = New System.Windows.Forms.Label()
        CType(Me.dgvTaskDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTaskDetails
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvTaskDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTaskDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvTaskDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTaskDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTaskDetails.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTaskDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.dgvTaskDetails.Location = New System.Drawing.Point(40, 79)
        Me.dgvTaskDetails.Name = "dgvTaskDetails"
        Me.dgvTaskDetails.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTaskDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue
        Me.dgvTaskDetails.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTaskDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTaskDetails.Size = New System.Drawing.Size(843, 196)
        Me.dgvTaskDetails.TabIndex = 10
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(259, 99)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(39, 13)
        Me.lblUserId.TabIndex = 11
        Me.lblUserId.Text = "Label2"
        Me.lblUserId.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(394, 99)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(39, 13)
        Me.lblUserName.TabIndex = 12
        Me.lblUserName.Text = "Label2"
        Me.lblUserName.Visible = False
        '
        'btnStartinTask
        '
        Me.btnStartinTask.BackColor = System.Drawing.Color.White
        Me.btnStartinTask.Enabled = False
        Me.btnStartinTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartinTask.ForeColor = System.Drawing.Color.Black
        Me.btnStartinTask.Image = Global.FlinTech.My.Resources.Resources.Play
        Me.btnStartinTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartinTask.Location = New System.Drawing.Point(367, 29)
        Me.btnStartinTask.Name = "btnStartinTask"
        Me.btnStartinTask.Size = New System.Drawing.Size(128, 32)
        Me.btnStartinTask.TabIndex = 13
        Me.btnStartinTask.Text = "START"
        Me.btnStartinTask.UseVisualStyleBackColor = False
        '
        'lblLazyDeveloper
        '
        Me.lblLazyDeveloper.AutoSize = True
        Me.lblLazyDeveloper.BackColor = System.Drawing.Color.Transparent
        Me.lblLazyDeveloper.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLazyDeveloper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblLazyDeveloper.Location = New System.Drawing.Point(37, 294)
        Me.lblLazyDeveloper.Name = "lblLazyDeveloper"
        Me.lblLazyDeveloper.Size = New System.Drawing.Size(328, 16)
        Me.lblLazyDeveloper.TabIndex = 103
        Me.lblLazyDeveloper.Text = "Click Any Task and Press Start Button"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(613, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Logged User  :: "
        '
        'lblLoggedUser
        '
        Me.lblLoggedUser.AutoSize = True
        Me.lblLoggedUser.BackColor = System.Drawing.Color.Transparent
        Me.lblLoggedUser.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblLoggedUser.Location = New System.Drawing.Point(753, 9)
        Me.lblLoggedUser.Name = "lblLoggedUser"
        Me.lblLoggedUser.Size = New System.Drawing.Size(0, 16)
        Me.lblLoggedUser.TabIndex = 105
        '
        'frmALLTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlinTech.My.Resources.Resources.BlueGradient
        Me.ClientSize = New System.Drawing.Size(918, 418)
        Me.Controls.Add(Me.lblLoggedUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLazyDeveloper)
        Me.Controls.Add(Me.btnStartinTask)
        Me.Controls.Add(Me.dgvTaskDetails)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.lblUserName)
        Me.Name = "frmALLTask"
        Me.Text = "ALL Task"
        CType(Me.dgvTaskDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgvTaskDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Private WithEvents btnStartinTask As System.Windows.Forms.Button
    Private WithEvents lblLazyDeveloper As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblLoggedUser As System.Windows.Forms.Label
End Class
