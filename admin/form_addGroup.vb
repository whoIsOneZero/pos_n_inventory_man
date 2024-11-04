Imports MySql.Data.MySqlClient

Public Class form_addGroup
    Private Sub form_addGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' If conn.State = ConnectionState.Closed Then
            '   conn.Open()
            'End If

            conn.Open()

            cmd = New MySqlCommand("INSERT INTO `tblgroup`(`progroup`) VALUES (@progroup)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@progroup", txt_newProGroup.Text)
            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("New Product Group Added", MsgBoxStyle.Information, "Information")
                txt_newProGroup.Text = ""
            Else
                MsgBox("Failed to add new product group", MsgBoxStyle.Critical, "Error")
            End If
            txt_newProGroup.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class