<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_manageProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_productList = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_searchProduct = New System.Windows.Forms.Label()
        Me.txt_searchProduct = New System.Windows.Forms.TextBox()
        Me.tab_manageProducts = New System.Windows.Forms.TabPage()
        Me.btn_addProdGroup = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_searchProCode = New System.Windows.Forms.Button()
        Me.lbl_barcode = New System.Windows.Forms.Label()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.lbl_tax = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.lbl_UOM = New System.Windows.Forms.Label()
        Me.lbl_proGroup = New System.Windows.Forms.Label()
        Me.lbl_proName = New System.Windows.Forms.Label()
        Me.lbl_proCode = New System.Windows.Forms.Label()
        Me.lbl_searchProCode = New System.Windows.Forms.Label()
        Me.txt_searchProCode = New System.Windows.Forms.TextBox()
        Me.picBox_barcode = New System.Windows.Forms.PictureBox()
        Me.txt_totalPrice = New System.Windows.Forms.TextBox()
        Me.cmb_tax = New System.Windows.Forms.ComboBox()
        Me.cmb_UOM = New System.Windows.Forms.ComboBox()
        Me.cmb_proGroup = New System.Windows.Forms.ComboBox()
        Me.txt_proName = New System.Windows.Forms.TextBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_proCode = New System.Windows.Forms.TextBox()
        Me.lbl_manageProducts = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_productList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tab_manageProducts.SuspendLayout()
        CType(Me.picBox_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lbl_manageProducts)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 67)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_productList)
        Me.TabControl1.Controls.Add(Me.tab_manageProducts)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 67)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(8, 15)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(877, 447)
        Me.TabControl1.TabIndex = 1
        '
        'tab_productList
        '
        Me.tab_productList.Controls.Add(Me.DataGridView1)
        Me.tab_productList.Controls.Add(Me.Panel2)
        Me.tab_productList.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_productList.Location = New System.Drawing.Point(4, 50)
        Me.tab_productList.Name = "tab_productList"
        Me.tab_productList.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_productList.Size = New System.Drawing.Size(869, 393)
        Me.tab_productList.TabIndex = 0
        Me.tab_productList.Text = "PRODUCT LIST"
        Me.tab_productList.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column10, Me.Column11, Me.Column12, Me.Column8, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(863, 334)
        Me.DataGridView1.TabIndex = 3
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
        Me.Column2.HeaderText = "PRO CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 89
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "PRODUCT NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "GROUP"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 77
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "UOM"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 64
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "LOCATION"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 96
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "PRICE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 68
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "TAX %"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 56
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "TOTAL PRICE"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 99
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "STOCK"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "BARCODE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_searchProduct)
        Me.Panel2.Controls.Add(Me.txt_searchProduct)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 53)
        Me.Panel2.TabIndex = 2
        '
        'lbl_searchProduct
        '
        Me.lbl_searchProduct.AutoSize = True
        Me.lbl_searchProduct.Location = New System.Drawing.Point(59, 19)
        Me.lbl_searchProduct.Name = "lbl_searchProduct"
        Me.lbl_searchProduct.Size = New System.Drawing.Size(48, 17)
        Me.lbl_searchProduct.TabIndex = 12
        Me.lbl_searchProduct.Text = "Search"
        '
        'txt_searchProduct
        '
        Me.txt_searchProduct.Location = New System.Drawing.Point(113, 16)
        Me.txt_searchProduct.Name = "txt_searchProduct"
        Me.txt_searchProduct.Size = New System.Drawing.Size(472, 25)
        Me.txt_searchProduct.TabIndex = 11
        '
        'tab_manageProducts
        '
        Me.tab_manageProducts.Controls.Add(Me.btn_addProdGroup)
        Me.tab_manageProducts.Controls.Add(Me.btn_clear)
        Me.tab_manageProducts.Controls.Add(Me.btn_delete)
        Me.tab_manageProducts.Controls.Add(Me.btn_update)
        Me.tab_manageProducts.Controls.Add(Me.btn_save)
        Me.tab_manageProducts.Controls.Add(Me.btn_searchProCode)
        Me.tab_manageProducts.Controls.Add(Me.lbl_barcode)
        Me.tab_manageProducts.Controls.Add(Me.lbl_totalPrice)
        Me.tab_manageProducts.Controls.Add(Me.lbl_tax)
        Me.tab_manageProducts.Controls.Add(Me.lbl_price)
        Me.tab_manageProducts.Controls.Add(Me.lbl_location)
        Me.tab_manageProducts.Controls.Add(Me.lbl_UOM)
        Me.tab_manageProducts.Controls.Add(Me.lbl_proGroup)
        Me.tab_manageProducts.Controls.Add(Me.lbl_proName)
        Me.tab_manageProducts.Controls.Add(Me.lbl_proCode)
        Me.tab_manageProducts.Controls.Add(Me.lbl_searchProCode)
        Me.tab_manageProducts.Controls.Add(Me.txt_searchProCode)
        Me.tab_manageProducts.Controls.Add(Me.picBox_barcode)
        Me.tab_manageProducts.Controls.Add(Me.txt_totalPrice)
        Me.tab_manageProducts.Controls.Add(Me.cmb_tax)
        Me.tab_manageProducts.Controls.Add(Me.cmb_UOM)
        Me.tab_manageProducts.Controls.Add(Me.cmb_proGroup)
        Me.tab_manageProducts.Controls.Add(Me.txt_proName)
        Me.tab_manageProducts.Controls.Add(Me.txt_location)
        Me.tab_manageProducts.Controls.Add(Me.txt_price)
        Me.tab_manageProducts.Controls.Add(Me.txt_proCode)
        Me.tab_manageProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_manageProducts.Location = New System.Drawing.Point(4, 50)
        Me.tab_manageProducts.Name = "tab_manageProducts"
        Me.tab_manageProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_manageProducts.Size = New System.Drawing.Size(869, 393)
        Me.tab_manageProducts.TabIndex = 1
        Me.tab_manageProducts.Text = "MANAGE PRODUCTS"
        Me.tab_manageProducts.UseVisualStyleBackColor = True
        '
        'btn_addProdGroup
        '
        Me.btn_addProdGroup.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_addProdGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addProdGroup.ForeColor = System.Drawing.Color.White
        Me.btn_addProdGroup.Location = New System.Drawing.Point(401, 184)
        Me.btn_addProdGroup.Name = "btn_addProdGroup"
        Me.btn_addProdGroup.Size = New System.Drawing.Size(31, 26)
        Me.btn_addProdGroup.TabIndex = 25
        Me.btn_addProdGroup.Text = "+"
        Me.btn_addProdGroup.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Purple
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(612, 344)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(125, 26)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Maroon
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(453, 344)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(125, 26)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(306, 344)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 26)
        Me.btn_update.TabIndex = 22
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(161, 344)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(125, 26)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_searchProCode
        '
        Me.btn_searchProCode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_searchProCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_searchProCode.ForeColor = System.Drawing.Color.White
        Me.btn_searchProCode.Location = New System.Drawing.Point(657, 38)
        Me.btn_searchProCode.Name = "btn_searchProCode"
        Me.btn_searchProCode.Size = New System.Drawing.Size(81, 26)
        Me.btn_searchProCode.TabIndex = 20
        Me.btn_searchProCode.Text = "SEARCH"
        Me.btn_searchProCode.UseVisualStyleBackColor = False
        '
        'lbl_barcode
        '
        Me.lbl_barcode.AutoSize = True
        Me.lbl_barcode.Location = New System.Drawing.Point(465, 214)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(57, 17)
        Me.lbl_barcode.TabIndex = 19
        Me.lbl_barcode.Text = "Barcode"
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.AutoSize = True
        Me.lbl_totalPrice.Location = New System.Drawing.Point(470, 166)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(70, 17)
        Me.lbl_totalPrice.TabIndex = 18
        Me.lbl_totalPrice.Text = "Total Price"
        '
        'lbl_tax
        '
        Me.lbl_tax.AutoSize = True
        Me.lbl_tax.Location = New System.Drawing.Point(465, 115)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(46, 17)
        Me.lbl_tax.TabIndex = 17
        Me.lbl_tax.Text = "TAX %"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(465, 67)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(37, 17)
        Me.lbl_price.TabIndex = 16
        Me.lbl_price.Text = "Price"
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Location = New System.Drawing.Point(159, 267)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(59, 17)
        Me.lbl_location.TabIndex = 15
        Me.lbl_location.Text = "Location"
        '
        'lbl_UOM
        '
        Me.lbl_UOM.AutoSize = True
        Me.lbl_UOM.Location = New System.Drawing.Point(159, 214)
        Me.lbl_UOM.Name = "lbl_UOM"
        Me.lbl_UOM.Size = New System.Drawing.Size(39, 17)
        Me.lbl_UOM.TabIndex = 14
        Me.lbl_UOM.Text = "UOM"
        '
        'lbl_proGroup
        '
        Me.lbl_proGroup.AutoSize = True
        Me.lbl_proGroup.Location = New System.Drawing.Point(159, 162)
        Me.lbl_proGroup.Name = "lbl_proGroup"
        Me.lbl_proGroup.Size = New System.Drawing.Size(98, 17)
        Me.lbl_proGroup.TabIndex = 13
        Me.lbl_proGroup.Text = "Product Group"
        '
        'lbl_proName
        '
        Me.lbl_proName.AutoSize = True
        Me.lbl_proName.Location = New System.Drawing.Point(159, 114)
        Me.lbl_proName.Name = "lbl_proName"
        Me.lbl_proName.Size = New System.Drawing.Size(96, 17)
        Me.lbl_proName.TabIndex = 12
        Me.lbl_proName.Text = "Product Name"
        '
        'lbl_proCode
        '
        Me.lbl_proCode.AutoSize = True
        Me.lbl_proCode.Location = New System.Drawing.Point(159, 67)
        Me.lbl_proCode.Name = "lbl_proCode"
        Me.lbl_proCode.Size = New System.Drawing.Size(91, 17)
        Me.lbl_proCode.TabIndex = 11
        Me.lbl_proCode.Text = "Product Code"
        '
        'lbl_searchProCode
        '
        Me.lbl_searchProCode.AutoSize = True
        Me.lbl_searchProCode.Location = New System.Drawing.Point(159, 18)
        Me.lbl_searchProCode.Name = "lbl_searchProCode"
        Me.lbl_searchProCode.Size = New System.Drawing.Size(135, 17)
        Me.lbl_searchProCode.TabIndex = 10
        Me.lbl_searchProCode.Text = "Search Product Code"
        '
        'txt_searchProCode
        '
        Me.txt_searchProCode.Location = New System.Drawing.Point(162, 38)
        Me.txt_searchProCode.Name = "txt_searchProCode"
        Me.txt_searchProCode.Size = New System.Drawing.Size(472, 25)
        Me.txt_searchProCode.TabIndex = 9
        '
        'picBox_barcode
        '
        Me.picBox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBox_barcode.Location = New System.Drawing.Point(468, 235)
        Me.picBox_barcode.Name = "picBox_barcode"
        Me.picBox_barcode.Size = New System.Drawing.Size(270, 77)
        Me.picBox_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox_barcode.TabIndex = 8
        Me.picBox_barcode.TabStop = False
        '
        'txt_totalPrice
        '
        Me.txt_totalPrice.Location = New System.Drawing.Point(468, 186)
        Me.txt_totalPrice.Name = "txt_totalPrice"
        Me.txt_totalPrice.Size = New System.Drawing.Size(270, 25)
        Me.txt_totalPrice.TabIndex = 7
        '
        'cmb_tax
        '
        Me.cmb_tax.FormattingEnabled = True
        Me.cmb_tax.Items.AddRange(New Object() {"5", "9", "18", "24", "28"})
        Me.cmb_tax.Location = New System.Drawing.Point(468, 134)
        Me.cmb_tax.Name = "cmb_tax"
        Me.cmb_tax.Size = New System.Drawing.Size(270, 25)
        Me.cmb_tax.TabIndex = 6
        '
        'cmb_UOM
        '
        Me.cmb_UOM.FormattingEnabled = True
        Me.cmb_UOM.Items.AddRange(New Object() {"NOS", "LTR", "PKT", "BAG", "PAIR"})
        Me.cmb_UOM.Location = New System.Drawing.Point(162, 235)
        Me.cmb_UOM.Name = "cmb_UOM"
        Me.cmb_UOM.Size = New System.Drawing.Size(270, 25)
        Me.cmb_UOM.TabIndex = 5
        '
        'cmb_proGroup
        '
        Me.cmb_proGroup.FormattingEnabled = True
        Me.cmb_proGroup.Location = New System.Drawing.Point(162, 186)
        Me.cmb_proGroup.Name = "cmb_proGroup"
        Me.cmb_proGroup.Size = New System.Drawing.Size(233, 25)
        Me.cmb_proGroup.TabIndex = 4
        '
        'txt_proName
        '
        Me.txt_proName.Location = New System.Drawing.Point(162, 134)
        Me.txt_proName.Name = "txt_proName"
        Me.txt_proName.Size = New System.Drawing.Size(270, 25)
        Me.txt_proName.TabIndex = 3
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(162, 287)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(270, 25)
        Me.txt_location.TabIndex = 2
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(468, 87)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(270, 25)
        Me.txt_price.TabIndex = 1
        '
        'txt_proCode
        '
        Me.txt_proCode.Location = New System.Drawing.Point(162, 87)
        Me.txt_proCode.Name = "txt_proCode"
        Me.txt_proCode.Size = New System.Drawing.Size(270, 25)
        Me.txt_proCode.TabIndex = 0
        '
        'lbl_manageProducts
        '
        Me.lbl_manageProducts.AutoSize = True
        Me.lbl_manageProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manageProducts.ForeColor = System.Drawing.Color.White
        Me.lbl_manageProducts.Location = New System.Drawing.Point(26, 20)
        Me.lbl_manageProducts.Name = "lbl_manageProducts"
        Me.lbl_manageProducts.Size = New System.Drawing.Size(181, 30)
        Me.lbl_manageProducts.TabIndex = 0
        Me.lbl_manageProducts.Text = "Manage Products"
        '
        'form_manageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(877, 514)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "form_manageProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Products"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_productList.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tab_manageProducts.ResumeLayout(False)
        Me.tab_manageProducts.PerformLayout()
        CType(Me.picBox_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_productList As TabPage
    Friend WithEvents tab_manageProducts As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_proName As TextBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_proCode As TextBox
    Friend WithEvents cmb_UOM As ComboBox
    Friend WithEvents cmb_proGroup As ComboBox
    Friend WithEvents txt_totalPrice As TextBox
    Friend WithEvents cmb_tax As ComboBox
    Friend WithEvents txt_searchProCode As TextBox
    Friend WithEvents picBox_barcode As PictureBox
    Friend WithEvents lbl_barcode As Label
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents lbl_tax As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_location As Label
    Friend WithEvents lbl_UOM As Label
    Friend WithEvents lbl_proGroup As Label
    Friend WithEvents lbl_proName As Label
    Friend WithEvents lbl_proCode As Label
    Friend WithEvents lbl_searchProCode As Label
    Friend WithEvents btn_searchProCode As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_addProdGroup As Button
    Friend WithEvents lbl_searchProduct As Label
    Friend WithEvents txt_searchProduct As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents lbl_manageProducts As Label
End Class
