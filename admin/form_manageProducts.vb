Imports MySql.Data.MySqlClient
Imports ZXing
Imports System.Drawing

Public Class form_manageProducts

    Private Sub form_manageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_ProductGroup()
        load_Product()
    End Sub

    Private Sub btn_addProdGroup_Click(sender As Object, e As EventArgs) Handles btn_addProdGroup.Click
        form_addGroup.ShowDialog()
    End Sub

    Sub load_productGroup()
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

    Sub load_product()
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
        txt_location.Clear()
        txt_price.Clear()
        txt_proCode.Clear()
        txt_proName.Clear()
        txt_totalPrice.Clear()
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

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            ' Check if PictureBox contains an image
            If picBox_barcode.Image Is Nothing Then
                MsgBox("Please add a barcode image before saving.", MsgBoxStyle.Exclamation, "Image Missing")
                Exit Sub
            End If

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
        ' Calculate Total Price
        If String.IsNullOrWhiteSpace(txt_price.Text) Then
            txt_totalPrice.Clear()
            Return
        End If

        Try
            txt_totalPrice.Text = CDec(txt_price.Text * cmb_tax.Text / 100) + txt_price.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_searchProduct_TextChanged(sender As Object, e As EventArgs) Handles txt_searchProduct.TextChanged
        ' Search Product
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE procode like '%" & txt_searchProduct.Text & "%' or proname like '%" & txt_searchProduct.Text & "%' or progroup like '%" & txt_searchProduct.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"), dr.Item("barcode"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_searchProCode_Click(sender As Object, e As EventArgs) Handles btn_searchProCode.Click
        txt_proCode.ReadOnly = True

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock`, `barcode` FROM `tblproduct` WHERE procode like '%" & txt_searchProCode.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_proCode.Text = dr.Item("procode")
                txt_proName.Text = dr.Item("proname")
                cmb_proGroup.Text = dr.Item("progroup")
                cmb_UOM.Text = dr.Item("uom")
                txt_location.Text = dr.Item("location")
                txt_price.Text = dr.Item("price")
                cmb_tax.Text = dr.Item("tax")
                txt_totalPrice.Text = dr.Item("totalprice")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        txt_searchProCode.Clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname,`progroup`=@progroup,`uom`=@uom,`location`=@location,`price`=@price,`tax`=@tax,`totalprice`=@totalprice WHERE `procode`=@procode", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@proname", txt_proName.Text)
            cmd.Parameters.AddWithValue("@progroup", cmb_proGroup.Text)
            cmd.Parameters.AddWithValue("@uom", cmb_UOM.Text)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cmb_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalPrice.Text))
            cmd.Parameters.AddWithValue("@procode", txt_proCode.Text)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Product update success!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Produt update failed!.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txt_searchProCode.Clear()
        load_product()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure you want to delete this product?", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblproduct` WHERE `procode`=@procode", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", txt_proCode.Text)

                i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Product deleted successfully!", MsgBoxStyle.Information, "Information")
                Else
                    MsgBox("Produt deletion failed!.", MsgBoxStyle.Critical, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txt_searchProCode.Clear()
            load_product()
        Else

        End If
    End Sub
End Class