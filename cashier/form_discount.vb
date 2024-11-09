Imports MySql.Data.MySqlClient

Public Class form_discount
    Private Sub form_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_updateDiscount_Click(sender As Object, e As EventArgs) Handles btn_updateDiscount.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbldiscount` SET `discount`=@discount WHERE `disid`=@disid", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@discount", txt_discountPercent.Text)
            cmd.Parameters.AddWithValue("@disid", "1001")

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Discount updated successfully!", vbInformation)
            Else
                MsgBox("Discount update failed!", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_discountPercent.Clear()
        form_mainCashier.load_discount()
    End Sub
End Class