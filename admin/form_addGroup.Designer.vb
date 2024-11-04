<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addGroup
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
        Me.txt_newProGroup = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_newGroup = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_newProGroup
        '
        Me.txt_newProGroup.Location = New System.Drawing.Point(23, 44)
        Me.txt_newProGroup.Name = "txt_newProGroup"
        Me.txt_newProGroup.Size = New System.Drawing.Size(328, 25)
        Me.txt_newProGroup.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(23, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(328, 26)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_newGroup
        '
        Me.lbl_newGroup.AutoSize = True
        Me.lbl_newGroup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newGroup.Location = New System.Drawing.Point(20, 24)
        Me.lbl_newGroup.Name = "lbl_newGroup"
        Me.lbl_newGroup.Size = New System.Drawing.Size(113, 17)
        Me.lbl_newGroup.TabIndex = 23
        Me.lbl_newGroup.Text = "Enter New Group"
        '
        'form_addGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(369, 133)
        Me.Controls.Add(Me.lbl_newGroup)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_newProGroup)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "form_addGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Group"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_newProGroup As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_newGroup As Label
End Class
