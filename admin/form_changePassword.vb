Imports MySql.Data.MySqlClient

Public Class form_changePassword
    Private Sub form_changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtCurrentPassword.Text = String.Empty Then
            MsgBox("Please enter your current password!", vbExclamation)
            Return
        ElseIf txtNewPassword.Text = String.Empty Or txtReNewPassword.Text = String.Empty Then
            MsgBox("Please enter your new password!", vbExclamation)
            Return
        ElseIf StrComp(txtNewPassword.Text, txtReNewPassword.Text, CompareMethod.Binary) Then
            MsgBox("Passwords do not match!", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `tbluser` SET `password`=@password WHERE `password`=@password1", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", txtReNewPassword.Text)
                cmd.Parameters.AddWithValue("@password1", txtCurrentPassword.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password changed successfully!", vbInformation)
                Else
                    MsgBox("Password change failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtReNewPassword.Clear()
        Me.Close()
        form_login.Show()
    End Sub
End Class