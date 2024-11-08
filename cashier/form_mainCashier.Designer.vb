<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mainCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_invSys2 = New System.Windows.Forms.Label()
        Me.lbl_invSys3 = New System.Windows.Forms.Label()
        Me.lbl_invSys1 = New System.Windows.Forms.Label()
        Me.lbl_POS = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtp_billDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_searchProductOrBarcode = New System.Windows.Forms.TextBox()
        Me.txt_billNum = New System.Windows.Forms.TextBox()
        Me.lbl_billDate = New System.Windows.Forms.Label()
        Me.lbl_productOrBarcode = New System.Windows.Forms.Label()
        Me.lbl_billNum = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_f7Logout = New System.Windows.Forms.Button()
        Me.btn_f6changePassword = New System.Windows.Forms.Button()
        Me.btn_f5Remove = New System.Windows.Forms.Button()
        Me.btn_f4Report = New System.Windows.Forms.Button()
        Me.btn_f3SetDiscount = New System.Windows.Forms.Button()
        Me.btn_f2Cancel = New System.Windows.Forms.Button()
        Me.btn_f1New = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmb_payMode = New System.Windows.Forms.ComboBox()
        Me.txt_amountReceived = New System.Windows.Forms.TextBox()
        Me.txt_discountPercent = New System.Windows.Forms.TextBox()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.lbl_numItems = New System.Windows.Forms.Label()
        Me.btn_f9Pay = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_overallGrandTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_invSys2)
        Me.Panel1.Controls.Add(Me.lbl_invSys3)
        Me.Panel1.Controls.Add(Me.lbl_invSys1)
        Me.Panel1.Controls.Add(Me.lbl_POS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 58)
        Me.Panel1.TabIndex = 0
        '
        'lbl_invSys2
        '
        Me.lbl_invSys2.AutoSize = True
        Me.lbl_invSys2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invSys2.Location = New System.Drawing.Point(671, 8)
        Me.lbl_invSys2.Name = "lbl_invSys2"
        Me.lbl_invSys2.Size = New System.Drawing.Size(116, 17)
        Me.lbl_invSys2.TabIndex = 8
        Me.lbl_invSys2.Text = "Inventory System"
        '
        'lbl_invSys3
        '
        Me.lbl_invSys3.AutoSize = True
        Me.lbl_invSys3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invSys3.Location = New System.Drawing.Point(671, 31)
        Me.lbl_invSys3.Name = "lbl_invSys3"
        Me.lbl_invSys3.Size = New System.Drawing.Size(116, 17)
        Me.lbl_invSys3.TabIndex = 7
        Me.lbl_invSys3.Text = "Inventory System"
        '
        'lbl_invSys1
        '
        Me.lbl_invSys1.AutoSize = True
        Me.lbl_invSys1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invSys1.Location = New System.Drawing.Point(10, 38)
        Me.lbl_invSys1.Name = "lbl_invSys1"
        Me.lbl_invSys1.Size = New System.Drawing.Size(116, 17)
        Me.lbl_invSys1.TabIndex = 6
        Me.lbl_invSys1.Text = "Inventory System"
        '
        'lbl_POS
        '
        Me.lbl_POS.AutoSize = True
        Me.lbl_POS.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_POS.Location = New System.Drawing.Point(29, 8)
        Me.lbl_POS.Name = "lbl_POS"
        Me.lbl_POS.Size = New System.Drawing.Size(64, 30)
        Me.lbl_POS.TabIndex = 0
        Me.lbl_POS.Text = "P O S"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtp_billDate)
        Me.Panel2.Controls.Add(Me.txt_searchProductOrBarcode)
        Me.Panel2.Controls.Add(Me.txt_billNum)
        Me.Panel2.Controls.Add(Me.lbl_billDate)
        Me.Panel2.Controls.Add(Me.lbl_productOrBarcode)
        Me.Panel2.Controls.Add(Me.lbl_billNum)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(998, 99)
        Me.Panel2.TabIndex = 1
        '
        'dtp_billDate
        '
        Me.dtp_billDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_billDate.Location = New System.Drawing.Point(375, 13)
        Me.dtp_billDate.Name = "dtp_billDate"
        Me.dtp_billDate.Size = New System.Drawing.Size(141, 25)
        Me.dtp_billDate.TabIndex = 10
        '
        'txt_searchProductOrBarcode
        '
        Me.txt_searchProductOrBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_searchProductOrBarcode.Location = New System.Drawing.Point(102, 54)
        Me.txt_searchProductOrBarcode.Name = "txt_searchProductOrBarcode"
        Me.txt_searchProductOrBarcode.Size = New System.Drawing.Size(414, 25)
        Me.txt_searchProductOrBarcode.TabIndex = 9
        '
        'txt_billNum
        '
        Me.txt_billNum.Location = New System.Drawing.Point(102, 13)
        Me.txt_billNum.Name = "txt_billNum"
        Me.txt_billNum.Size = New System.Drawing.Size(182, 25)
        Me.txt_billNum.TabIndex = 8
        '
        'lbl_billDate
        '
        Me.lbl_billDate.AutoSize = True
        Me.lbl_billDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billDate.Location = New System.Drawing.Point(309, 16)
        Me.lbl_billDate.Name = "lbl_billDate"
        Me.lbl_billDate.Size = New System.Drawing.Size(60, 17)
        Me.lbl_billDate.TabIndex = 4
        Me.lbl_billDate.Text = "Bill Date:"
        '
        'lbl_productOrBarcode
        '
        Me.lbl_productOrBarcode.AutoSize = True
        Me.lbl_productOrBarcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productOrBarcode.Location = New System.Drawing.Point(19, 49)
        Me.lbl_productOrBarcode.Name = "lbl_productOrBarcode"
        Me.lbl_productOrBarcode.Size = New System.Drawing.Size(65, 34)
        Me.lbl_productOrBarcode.TabIndex = 3
        Me.lbl_productOrBarcode.Text = "Product /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barcode"
        '
        'lbl_billNum
        '
        Me.lbl_billNum.AutoSize = True
        Me.lbl_billNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billNum.Location = New System.Drawing.Point(20, 13)
        Me.lbl_billNum.Name = "lbl_billNum"
        Me.lbl_billNum.Size = New System.Drawing.Size(52, 17)
        Me.lbl_billNum.TabIndex = 2
        Me.lbl_billNum.Text = "Bill NO:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f7Logout, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f6changePassword, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f5Remove, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f4Report, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f3SetDiscount, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f2Cancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_f1New, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 607)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(998, 48)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_f7Logout
        '
        Me.btn_f7Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_f7Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f7Logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f7Logout.FlatAppearance.BorderSize = 0
        Me.btn_f7Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f7Logout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f7Logout.ForeColor = System.Drawing.Color.White
        Me.btn_f7Logout.Location = New System.Drawing.Point(855, 3)
        Me.btn_f7Logout.Name = "btn_f7Logout"
        Me.btn_f7Logout.Size = New System.Drawing.Size(140, 42)
        Me.btn_f7Logout.TabIndex = 17
        Me.btn_f7Logout.Text = "[ F7 - LOGOUT ]"
        Me.btn_f7Logout.UseVisualStyleBackColor = False
        '
        'btn_f6changePassword
        '
        Me.btn_f6changePassword.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f6changePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f6changePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f6changePassword.FlatAppearance.BorderSize = 0
        Me.btn_f6changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f6changePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f6changePassword.ForeColor = System.Drawing.Color.White
        Me.btn_f6changePassword.Location = New System.Drawing.Point(713, 3)
        Me.btn_f6changePassword.Name = "btn_f6changePassword"
        Me.btn_f6changePassword.Size = New System.Drawing.Size(136, 42)
        Me.btn_f6changePassword.TabIndex = 16
        Me.btn_f6changePassword.Text = "[ F6 - CHANGE PASSWORD ]"
        Me.btn_f6changePassword.UseVisualStyleBackColor = False
        '
        'btn_f5Remove
        '
        Me.btn_f5Remove.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f5Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f5Remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f5Remove.FlatAppearance.BorderSize = 0
        Me.btn_f5Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f5Remove.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f5Remove.ForeColor = System.Drawing.Color.White
        Me.btn_f5Remove.Location = New System.Drawing.Point(571, 3)
        Me.btn_f5Remove.Name = "btn_f5Remove"
        Me.btn_f5Remove.Size = New System.Drawing.Size(136, 42)
        Me.btn_f5Remove.TabIndex = 15
        Me.btn_f5Remove.Text = "[ F5 - REMOVE ]"
        Me.btn_f5Remove.UseVisualStyleBackColor = False
        '
        'btn_f4Report
        '
        Me.btn_f4Report.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f4Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f4Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f4Report.FlatAppearance.BorderSize = 0
        Me.btn_f4Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f4Report.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f4Report.ForeColor = System.Drawing.Color.White
        Me.btn_f4Report.Location = New System.Drawing.Point(429, 3)
        Me.btn_f4Report.Name = "btn_f4Report"
        Me.btn_f4Report.Size = New System.Drawing.Size(136, 42)
        Me.btn_f4Report.TabIndex = 14
        Me.btn_f4Report.Text = "[ F4 - REPORT ]"
        Me.btn_f4Report.UseVisualStyleBackColor = False
        '
        'btn_f3SetDiscount
        '
        Me.btn_f3SetDiscount.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f3SetDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f3SetDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f3SetDiscount.FlatAppearance.BorderSize = 0
        Me.btn_f3SetDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f3SetDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f3SetDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_f3SetDiscount.Location = New System.Drawing.Point(287, 3)
        Me.btn_f3SetDiscount.Name = "btn_f3SetDiscount"
        Me.btn_f3SetDiscount.Size = New System.Drawing.Size(136, 42)
        Me.btn_f3SetDiscount.TabIndex = 13
        Me.btn_f3SetDiscount.Text = "[ F3 - SET DISCOUNT ]"
        Me.btn_f3SetDiscount.UseVisualStyleBackColor = False
        '
        'btn_f2Cancel
        '
        Me.btn_f2Cancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f2Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f2Cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f2Cancel.FlatAppearance.BorderSize = 0
        Me.btn_f2Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f2Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f2Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_f2Cancel.Location = New System.Drawing.Point(145, 3)
        Me.btn_f2Cancel.Name = "btn_f2Cancel"
        Me.btn_f2Cancel.Size = New System.Drawing.Size(136, 42)
        Me.btn_f2Cancel.TabIndex = 12
        Me.btn_f2Cancel.Text = "[ F2 - CANCEL ]"
        Me.btn_f2Cancel.UseVisualStyleBackColor = False
        '
        'btn_f1New
        '
        Me.btn_f1New.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f1New.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f1New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_f1New.FlatAppearance.BorderSize = 0
        Me.btn_f1New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f1New.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f1New.ForeColor = System.Drawing.Color.White
        Me.btn_f1New.Location = New System.Drawing.Point(3, 3)
        Me.btn_f1New.Name = "btn_f1New"
        Me.btn_f1New.Size = New System.Drawing.Size(136, 42)
        Me.btn_f1New.TabIndex = 11
        Me.btn_f1New.Text = "[ F1 - NEW ]"
        Me.btn_f1New.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmb_payMode)
        Me.Panel3.Controls.Add(Me.txt_amountReceived)
        Me.Panel3.Controls.Add(Me.txt_discountPercent)
        Me.Panel3.Controls.Add(Me.lbl_change)
        Me.Panel3.Controls.Add(Me.lbl_grandTotal)
        Me.Panel3.Controls.Add(Me.lbl_discount)
        Me.Panel3.Controls.Add(Me.lbl_totalPrice)
        Me.Panel3.Controls.Add(Me.lbl_numItems)
        Me.Panel3.Controls.Add(Me.btn_f9Pay)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lbl_overallGrandTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(713, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 450)
        Me.Panel3.TabIndex = 3
        '
        'cmb_payMode
        '
        Me.cmb_payMode.FormattingEnabled = True
        Me.cmb_payMode.Items.AddRange(New Object() {"CASH", "UPI", "CREDIT CARD", "DEBIT CARD"})
        Me.cmb_payMode.Location = New System.Drawing.Point(141, 271)
        Me.cmb_payMode.Name = "cmb_payMode"
        Me.cmb_payMode.Size = New System.Drawing.Size(111, 25)
        Me.cmb_payMode.TabIndex = 25
        '
        'txt_amountReceived
        '
        Me.txt_amountReceived.Location = New System.Drawing.Point(141, 308)
        Me.txt_amountReceived.Name = "txt_amountReceived"
        Me.txt_amountReceived.Size = New System.Drawing.Size(111, 25)
        Me.txt_amountReceived.TabIndex = 24
        '
        'txt_discountPercent
        '
        Me.txt_discountPercent.Location = New System.Drawing.Point(97, 204)
        Me.txt_discountPercent.Name = "txt_discountPercent"
        Me.txt_discountPercent.Size = New System.Drawing.Size(38, 25)
        Me.txt_discountPercent.TabIndex = 23
        '
        'lbl_change
        '
        Me.lbl_change.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_change.Location = New System.Drawing.Point(147, 338)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(105, 27)
        Me.lbl_change.TabIndex = 22
        Me.lbl_change.Text = "00.00"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.Red
        Me.lbl_grandTotal.Location = New System.Drawing.Point(141, 236)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(111, 27)
        Me.lbl_grandTotal.TabIndex = 21
        Me.lbl_grandTotal.Text = "00.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_discount
        '
        Me.lbl_discount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_discount.Location = New System.Drawing.Point(161, 200)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(91, 27)
        Me.lbl_discount.TabIndex = 20
        Me.lbl_discount.Text = "00.00"
        Me.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_totalPrice.Location = New System.Drawing.Point(141, 140)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(111, 27)
        Me.lbl_totalPrice.TabIndex = 19
        Me.lbl_totalPrice.Text = "00.00"
        Me.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_numItems
        '
        Me.lbl_numItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_numItems.Location = New System.Drawing.Point(141, 98)
        Me.lbl_numItems.Name = "lbl_numItems"
        Me.lbl_numItems.Size = New System.Drawing.Size(111, 27)
        Me.lbl_numItems.TabIndex = 18
        Me.lbl_numItems.Text = "00.00"
        Me.lbl_numItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_f9Pay
        '
        Me.btn_f9Pay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_f9Pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f9Pay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_f9Pay.FlatAppearance.BorderSize = 0
        Me.btn_f9Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f9Pay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f9Pay.ForeColor = System.Drawing.Color.White
        Me.btn_f9Pay.Location = New System.Drawing.Point(0, 408)
        Me.btn_f9Pay.Name = "btn_f9Pay"
        Me.btn_f9Pay.Size = New System.Drawing.Size(285, 42)
        Me.btn_f9Pay.TabIndex = 17
        Me.btn_f9Pay.Text = "[ F9 - PAY ]"
        Me.btn_f9Pay.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Amount Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pay Mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Grand Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Discount %"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Change"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. of Items"
        '
        'lbl_overallGrandTotal
        '
        Me.lbl_overallGrandTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overallGrandTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_overallGrandTotal.Location = New System.Drawing.Point(3, 25)
        Me.lbl_overallGrandTotal.Name = "lbl_overallGrandTotal"
        Me.lbl_overallGrandTotal.Size = New System.Drawing.Size(252, 51)
        Me.lbl_overallGrandTotal.TabIndex = 0
        Me.lbl_overallGrandTotal.Text = "00.00"
        Me.lbl_overallGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(713, 450)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 113
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Product Group"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 109
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Tax %"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 52
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Sub Total"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Qty"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 53
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 61
        '
        'form_mainCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(998, 655)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "form_mainCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS and Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_POS As Label
    Friend WithEvents lbl_billDate As Label
    Friend WithEvents lbl_productOrBarcode As Label
    Friend WithEvents lbl_billNum As Label
    Friend WithEvents lbl_invSys1 As Label
    Friend WithEvents lbl_invSys2 As Label
    Friend WithEvents lbl_invSys3 As Label
    Friend WithEvents txt_searchProductOrBarcode As TextBox
    Friend WithEvents txt_billNum As TextBox
    Friend WithEvents dtp_billDate As DateTimePicker
    Friend WithEvents btn_f1New As Button
    Friend WithEvents btn_f7Logout As Button
    Friend WithEvents btn_f6changePassword As Button
    Friend WithEvents btn_f5Remove As Button
    Friend WithEvents btn_f4Report As Button
    Friend WithEvents btn_f3SetDiscount As Button
    Friend WithEvents btn_f2Cancel As Button
    Friend WithEvents lbl_overallGrandTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_f9Pay As Button
    Friend WithEvents lbl_numItems As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents lbl_grandTotal As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents txt_discountPercent As TextBox
    Friend WithEvents txt_amountReceived As TextBox
    Friend WithEvents cmb_payMode As ComboBox
End Class
