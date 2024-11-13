Imports MySql.Data.MySqlClient

Public Class form_mainCashier
    Private Sub form_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_searchProductOrBarcode.Focus()
        total()
        btn_f9Pay.Enabled = False
        load_discount()

        txt_billNum.Text = getBillNo()
    End Sub

    Public Sub ADDLIST()
        Dim exist As Boolean = False
        Dim numRow As Integer = 0
        Dim numText As Integer

        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txt_searchProductOrBarcode.Text Then
                    exist = True
                    numRow = itm.Index
                    numText = CInt(itm.Cells(8).Value)
                    Exit For
                End If
            End If
        Next
        If exist = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE `procode`='" & txt_searchProductOrBarcode.Text & "'", conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txt_searchProductOrBarcode.Text = String.Empty Then
                        Return
                    Else
                        ' Create new row
                        Dim procode As String = dr.Item("procode")
                        Dim proname As String = dr.Item("proname")
                        Dim progroup As String = dr.Item("progroup")
                        Dim uom As String = dr.Item("uom")
                        Dim price As Decimal = dr.Item("price")
                        Dim tax As Decimal = dr.Item("tax")
                        Dim totalprice As Decimal = dr.Item("totalprice")

                        Dim totalQtyPrice As Double
                        totalQtyPrice = price * tax / 100 + price

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, uom, price, tax, totalprice, 1, totalQtyPrice)

                        txt_searchProductOrBarcode.Clear()
                        txt_searchProductOrBarcode.Focus()
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView1.Rows(numRow).Cells(8).Value = numText + CInt("1")
            DataGridView1.Rows(numRow).Cells(9).Value = DataGridView1.Rows(numRow).Cells(7).Value * DataGridView1.Rows(numRow).Cells(8).Value

            'txt_searchProductOrBarcode.Clear()
            'txt_searchProductOrBarcode.Focus()
        End If
    End Sub

    Private Sub txt_searchProductOrBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_searchProductOrBarcode.KeyDown
        If txt_searchProductOrBarcode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                ADDLIST()

                txt_searchProductOrBarcode.Clear()
                txt_searchProductOrBarcode.Focus()
            End If
        End If
    End Sub

    Public Sub total()
        lbl_numItems.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Double = 0
        Dim subTotal As Double = 0
        Dim tax As Double = 0

        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(9).Value
            tax = tax + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(6).Value / 100 * DataGridView1.Rows(i).Cells(8).Value
            subTotal = subTotal + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(8).Value
        Next

        Try
            lbl_subTotal.Text = Format(CDec(subTotal), "#,##0.00")
            lbl_totalTax.Text = Format(CDec(tax), "#,##0.00")
            lbl_totalPrice.Text = Format(CDec(subTotal + tax), "#,##0.00")
            lbl_discount.Text = Format(CDec(txt_discountPercent.Text * lbl_totalPrice.Text / 100), "#,##0.00")
            lbl_grandTotal.Text = Format(CDec(lbl_totalPrice.Text - lbl_discount.Text), "#,##0.00")
            lbl_overallGrandTotal.Text = Format(CDec(lbl_grandTotal.Text), "#,##0.00")

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt_amountReceived_TextChanged(sender As Object, e As EventArgs) Handles txt_amountReceived.TextChanged
        Try
            lbl_change.Text = Format(CDec(txt_amountReceived.Text - lbl_grandTotal.Text), "#,##0.00")
        Catch ex As Exception

        End Try
        btn_f9Pay.Enabled = True
    End Sub

    Sub load_discount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbldiscount`", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                txt_discountPercent.Text = dr.Item("discount")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_f3SetDiscount_Click(sender As Object, e As EventArgs) Handles btn_f3SetDiscount.Click
        form_discount.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")
    End Sub

    Sub save_bill()
        If cmb_payMode.Text = String.Empty Then
            MsgBox("Please select a payment mode.", vbInformation)
            Return
        ElseIf txt_amountReceived.Text = String.Empty Then
            MsgBox("Please enter received amount.", vbInformation)
            Return
        ElseIf lbl_grandTotal.Text > txt_amountReceived.Text Then
            MsgBox("Not enough balance.", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO `tblpos`(`billno`, `billdate`, `bmonth`, `bmonthyear`, `procode`, `proname`, `progroup`, `uom`, `price`, `tax`, `totalproductprice`, `qty`, `totalpriceqty`, `subtotal`, `totaltax`, `discount`, `grandtotal`, `paymode`, `receiveamount`, `balance`) VALUES (@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @uom, @price, @tax, @totalproductprice, @qty, @totalpriceqty, @subtotal, totaltax, @discount, @grandtotal, @paymode, @receiveamount, @balance)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@billno", txt_billNum.Text)
                    cmd.Parameters.AddWithValue("@billdate", CDate(dtp_billDate.Text))
                    cmd.Parameters.AddWithValue("@bmonth", Date.Now.ToString("MMMM"))
                    cmd.Parameters.AddWithValue("@bmonthyear", Date.Now.ToString("MMMM-yyyy"))

                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(8).Value)
                    cmd.Parameters.AddWithValue("@totalpriceqty", DataGridView1.Rows(j).Cells(9).Value)

                    cmd.Parameters.AddWithValue("@subtotal", lbl_subTotal.Text)
                    cmd.Parameters.AddWithValue("@totaltax", lbl_totalTax.Text)
                    cmd.Parameters.AddWithValue("@totalprice", lbl_totalPrice.Text)
                    cmd.Parameters.AddWithValue("@discount", lbl_discount.Text)
                    cmd.Parameters.AddWithValue("@grandtotal", lbl_grandTotal.Text)
                    cmd.Parameters.AddWithValue("@paymode", cmb_payMode.Text)
                    cmd.Parameters.AddWithValue("@receiveamount", txt_amountReceived.Text)
                    cmd.Parameters.AddWithValue("@balance", lbl_change.Text)

                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Bill saved succesfully." & vbNewLine & "Bill No: " & txt_billNum.Text, vbInformation)
                    clear()
                Else
                    MsgBox("Bill save failed!" & vbNewLine & "Bill No: " & txt_billNum.Text, vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        conn.Close()
    End Sub

    Sub clear()
        txt_billNum.Text = getBillNo()
        dtp_billDate.Text = Now
        txt_searchProductOrBarcode.Clear()
        DataGridView1.Rows.Clear()
        lbl_subTotal.Text = "0.00"
        lbl_totalTax.Text = "0.00"
        lbl_totalPrice.Text = "0.00"
        lbl_discount.Text = "0.00"
        lbl_grandTotal.Text = "0.00"
        lbl_numItems.Text = "0"
        lbl_overallGrandTotal.Text = "0.00"
        txt_amountReceived.Clear()
        lbl_change.Text = "0.00"
        cmb_payMode.SelectedIndex = -1

    End Sub

    Private Sub btn_f9Pay_Click(sender As Object, e As EventArgs) Handles btn_f9Pay.Click
        save_bill()
        ' clear()
        txt_searchProductOrBarcode.Focus()
    End Sub
End Class