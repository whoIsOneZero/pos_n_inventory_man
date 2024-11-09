Imports MySql.Data.MySqlClient

Public Class form_mainCashier
    Private Sub form_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_searchProductOrBarcode.Focus()
        total()
        load_discount()
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
        lbl_change.Text = Format(CDec(txt_amountReceived.Text - lbl_grandTotal.Text), "#,##0.00")
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
End Class