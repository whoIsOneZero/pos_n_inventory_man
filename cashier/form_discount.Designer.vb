<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_discount
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
        Me.btn_updateDiscount = New System.Windows.Forms.Button()
        Me.txt_discountPercent = New System.Windows.Forms.TextBox()
        Me.lbl_enterDiscount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_updateDiscount
        '
        Me.btn_updateDiscount.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_updateDiscount.FlatAppearance.BorderSize = 0
        Me.btn_updateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_updateDiscount.Location = New System.Drawing.Point(34, 94)
        Me.btn_updateDiscount.Name = "btn_updateDiscount"
        Me.btn_updateDiscount.Size = New System.Drawing.Size(323, 29)
        Me.btn_updateDiscount.TabIndex = 0
        Me.btn_updateDiscount.Text = "UPDATE DISCOUNT"
        Me.btn_updateDiscount.UseVisualStyleBackColor = False
        '
        'txt_discountPercent
        '
        Me.txt_discountPercent.Location = New System.Drawing.Point(34, 59)
        Me.txt_discountPercent.Name = "txt_discountPercent"
        Me.txt_discountPercent.Size = New System.Drawing.Size(323, 20)
        Me.txt_discountPercent.TabIndex = 1
        '
        'lbl_enterDiscount
        '
        Me.lbl_enterDiscount.AutoSize = True
        Me.lbl_enterDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enterDiscount.Location = New System.Drawing.Point(31, 33)
        Me.lbl_enterDiscount.Name = "lbl_enterDiscount"
        Me.lbl_enterDiscount.Size = New System.Drawing.Size(112, 17)
        Me.lbl_enterDiscount.TabIndex = 2
        Me.lbl_enterDiscount.Text = "Enter Discount %"
        '
        'form_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 147)
        Me.Controls.Add(Me.lbl_enterDiscount)
        Me.Controls.Add(Me.txt_discountPercent)
        Me.Controls.Add(Me.btn_updateDiscount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_updateDiscount As Button
    Friend WithEvents txt_discountPercent As TextBox
    Friend WithEvents lbl_enterDiscount As Label
End Class
