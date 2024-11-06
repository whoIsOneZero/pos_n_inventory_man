<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mainAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_invSystem = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_manageUsers = New System.Windows.Forms.Button()
        Me.btn_manageStock = New System.Windows.Forms.Button()
        Me.btn_manageProducts = New System.Windows.Forms.Button()
        Me.lbl_POS = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_invSystem)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.lbl_POS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 88)
        Me.Panel1.TabIndex = 0
        '
        'lbl_invSystem
        '
        Me.lbl_invSystem.AutoSize = True
        Me.lbl_invSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invSystem.Location = New System.Drawing.Point(17, 52)
        Me.lbl_invSystem.Name = "lbl_invSystem"
        Me.lbl_invSystem.Size = New System.Drawing.Size(116, 17)
        Me.lbl_invSystem.TabIndex = 2
        Me.lbl_invSystem.Text = "Inventory System"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageUsers, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageStock, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageProducts, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(353, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(565, 82)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(455, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(107, 76)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_report
        '
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.Location = New System.Drawing.Point(342, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(107, 76)
        Me.btn_report.TabIndex = 4
        Me.btn_report.Text = "Report"
        Me.btn_report.UseVisualStyleBackColor = True
        '
        'btn_manageUsers
        '
        Me.btn_manageUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageUsers.FlatAppearance.BorderSize = 0
        Me.btn_manageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageUsers.Location = New System.Drawing.Point(229, 3)
        Me.btn_manageUsers.Name = "btn_manageUsers"
        Me.btn_manageUsers.Size = New System.Drawing.Size(107, 76)
        Me.btn_manageUsers.TabIndex = 3
        Me.btn_manageUsers.Text = "Manage Users"
        Me.btn_manageUsers.UseVisualStyleBackColor = True
        '
        'btn_manageStock
        '
        Me.btn_manageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageStock.FlatAppearance.BorderSize = 0
        Me.btn_manageStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageStock.Location = New System.Drawing.Point(116, 3)
        Me.btn_manageStock.Name = "btn_manageStock"
        Me.btn_manageStock.Size = New System.Drawing.Size(107, 76)
        Me.btn_manageStock.TabIndex = 2
        Me.btn_manageStock.Text = "Manage Stock"
        Me.btn_manageStock.UseVisualStyleBackColor = True
        '
        'btn_manageProducts
        '
        Me.btn_manageProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageProducts.FlatAppearance.BorderSize = 0
        Me.btn_manageProducts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageProducts.Location = New System.Drawing.Point(3, 3)
        Me.btn_manageProducts.Name = "btn_manageProducts"
        Me.btn_manageProducts.Size = New System.Drawing.Size(107, 76)
        Me.btn_manageProducts.TabIndex = 1
        Me.btn_manageProducts.Text = "Manage Products"
        Me.btn_manageProducts.UseVisualStyleBackColor = True
        '
        'lbl_POS
        '
        Me.lbl_POS.AutoSize = True
        Me.lbl_POS.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_POS.Location = New System.Drawing.Point(34, 9)
        Me.lbl_POS.Name = "lbl_POS"
        Me.lbl_POS.Size = New System.Drawing.Size(74, 32)
        Me.lbl_POS.TabIndex = 1
        Me.lbl_POS.Text = "P O S"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 420)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 39)
        Me.Panel2.TabIndex = 1
        '
        'form_mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_mainAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS and Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_manageProducts As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_manageUsers As Button
    Friend WithEvents btn_manageStock As Button
    Friend WithEvents lbl_POS As Label
    Friend WithEvents lbl_invSystem As Label
    Friend WithEvents Panel2 As Panel
End Class
