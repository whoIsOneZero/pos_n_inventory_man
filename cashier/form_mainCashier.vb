Imports MySql.Data.MySqlClient

Public Class form_mainCashier
    Private Sub form_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        txt_searchProductOrBarcode.Focus()
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
    End Sub
End Class