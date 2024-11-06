Imports MySql.Data.MySqlClient
Public Class form_manageStock
    Private Sub form_manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_stock()
    End Sub

    Sub load_stock()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock`, `barcode` FROM `tblproduct`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class