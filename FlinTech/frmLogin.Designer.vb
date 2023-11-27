<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblLazyDeveloper = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Blue
        Me.btnLogin.Location = New System.Drawing.Point(100, 72)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(91, 28)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(100, 22)
        Me.txtUserID.MaxLength = 15
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(195, 20)
        Me.txtUserID.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(100, 45)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(195, 21)
        Me.txtPassword.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!)
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(22, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 12)
        Me.label2.TabIndex = 99
        Me.label2.Text = "User Name"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!)
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(22, 51)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 12)
        Me.label4.TabIndex = 100
        Me.label4.Text = "Password"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Blue
        Me.btnClose.Location = New System.Drawing.Point(207, 72)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 28)
        Me.btnClose.TabIndex = 101
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.label4)
        Me.pnlLogin.Controls.Add(Me.btnClose)
        Me.pnlLogin.Controls.Add(Me.label2)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUserID)
        Me.pnlLogin.Location = New System.Drawing.Point(435, 125)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(317, 119)
        Me.pnlLogin.TabIndex = 103
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.Blue
        Me.pnlLeft.BackgroundImage = Global.FlinTech.My.Resources.Resources.BlueGradient
        Me.pnlLeft.Controls.Add(Me.lblLazyDeveloper)
        Me.pnlLeft.Location = New System.Drawing.Point(1, -5)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(414, 367)
        Me.pnlLeft.TabIndex = 104
        '
        'lblLazyDeveloper
        '
        Me.lblLazyDeveloper.AutoSize = True
        Me.lblLazyDeveloper.BackColor = System.Drawing.Color.Transparent
        Me.lblLazyDeveloper.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLazyDeveloper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblLazyDeveloper.Location = New System.Drawing.Point(11, 30)
        Me.lblLazyDeveloper.Name = "lblLazyDeveloper"
        Me.lblLazyDeveloper.Size = New System.Drawing.Size(92, 16)
        Me.lblLazyDeveloper.TabIndex = 102
        Me.lblLazyDeveloper.Text = "FLINTECH"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(775, 361)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlLogin)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents lblLazyDeveloper As System.Windows.Forms.Label
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel

End Class
