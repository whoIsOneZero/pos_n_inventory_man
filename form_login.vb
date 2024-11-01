Imports MySql.Data.MySqlClient

Public Class form_login
    Dim fullName As String
    Dim username As String
    Dim password As String
    Dim role As String
    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`='" & txtUsername.Text & "' AND `password`='" & txtPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                found = True
                fullName = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString

            Else
                found = False
                fullName = ""
                username = ""
                password = ""
                role = ""
            End If

            If found = True Then
                If StrComp(txtUsername.Text, username, CompareMethod.Binary) Or StrComp(txtPassword.Text, password, CompareMethod.Binary) Then
                    MsgBox("Warning: wrong username or password!", vbExclamation)
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        form_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        form_mainCashier.Show()
                    End If
                End If
            Else
                MsgBox("Warning: wrong username or password!", vbExclamation)
            End If
            txtPassword.Clear()
            txtUsername.Clear()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
