Imports MySql.Data.MySqlClient
Imports ZXing
Imports System.Drawing

Public Class form_manageProducts

    Private Sub form_manageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_ProductGroup()
        load_Product()
    End Sub

    Private Sub btn_addProdGroup_Click(sender As Object, e As EventArgs) Handles btn_addProdGroup.Click
        form_addGroup.ShowDialog()
    End Sub

    Sub load_ProductGroup()
        cmb_proGroup.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblgroup`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cmb_proGroup.Items.Add(dr.Item("progroup").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub load_Product()
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

    Sub clear()
        txt_proCode.Clear()
        txt_proName.Clear()
        txt_price.Clear()
        txt_location.Clear()
        txt_searchProCode.Clear()
        cmb_proGroup.SelectedIndex = -1
        cmb_tax.SelectedIndex = -1
        cmb_UOM.SelectedIndex = -1
        picBox_barcode.Image = Nothing
    End Sub

    Private Sub txt_proCode_TextChanged(sender As Object, e As EventArgs) Handles txt_proCode.TextChanged
        ' Generate barcode
        Dim barcode As New BarcodeWriter
        barcode.Format = BarcodeFormat.CODE_128
        barcode.Options.Width = 200
        ' barcode.Options.Height = 100
        barcode.Options.PureBarcode = True

        Try
            picBox_barcode.Image = barcode.Write(txt_proCode.Text)
        Catch ex As Exception
            picBox_barcode.Image = Nothing
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()

            ' convert image to binary format
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream()
            picBox_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `barcode`) VALUES (@procode, @proname, @progroup, @uom, @location, @price, @tax, @totalprice, @barcode)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_proCode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_proName.Text)
            cmd.Parameters.AddWithValue("@progroup", cmb_proGroup.Text)
            cmd.Parameters.AddWithValue("@uom", cmb_UOM.Text)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cmb_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalPrice.Text))
            cmd.Parameters.AddWithValue("@barcode", arrImage)
            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("New Product added!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Failed to add new product.", MsgBoxStyle.Critical, "Error")
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub

    Private Sub cmb_tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tax.SelectedIndexChanged
        Try
            txt_totalPrice.Text = CDec(txt_price.Text * cmb_tax.Text / 100) + txt_price.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class