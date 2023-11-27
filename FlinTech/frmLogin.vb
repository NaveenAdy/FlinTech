Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .FormBorderStyle = FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            .StartPosition = FormStartPosition.WindowsDefaultLocation
        End With

        With pnlLogin
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub
    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    Public Sub Login()
        If (txtUserID.Text.Trim() = "") Then
            MessageBox.Show("User ID Not Provided")
            txtUserID.Focus()
            Return
        End If
        If (txtPassword.Text.Trim() = "") Then
            MessageBox.Show("Password Not Provided")
            txtPassword.Focus()
            Return
        End If
        Dim dt As New DataTable()
        Using cn As New SqlConnection(GlobalVariables.con)
            Using da As New SqlDataAdapter("Select ID,UserName,Password from User_MST Where UserName='" + txtUserID.Text.Trim() + "' ", GlobalVariables.con)
                Try
                    da.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        If String.Compare(txtPassword.Text.Trim(), dt.Rows(0)(2)) = 0 Then
                            'MessageBox.Show("Success")
                            GlobalVariables.userId = dt.Rows(0)(0).ToString()
                            GlobalVariables.userName = dt.Rows(0)(1).ToString()
                            Dim formForAllTask As New frmALLTask
                            Me.Hide()
                            formForAllTask.Show()
                        Else
                            txtPassword.Text = ""
                            txtPassword.Focus()
                            MessageBox.Show("Incorrect Password")
                        End If
                    Else
                        txtUserID.Text = ""
                        txtUserID.Focus()
                        MessageBox.Show("Not a Valid User Name")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally

                End Try
            End Using
        End Using
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            Login()
        End If
    End Sub
End Class
