<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_changePassword
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
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtReNewPassword = New System.Windows.Forms.TextBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblReNewPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(36, 37)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(358, 25)
        Me.txtCurrentPassword.TabIndex = 0
        Me.txtCurrentPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(36, 96)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(358, 25)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtReNewPassword
        '
        Me.txtReNewPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReNewPassword.Location = New System.Drawing.Point(36, 153)
        Me.txtReNewPassword.Name = "txtReNewPassword"
        Me.txtReNewPassword.Size = New System.Drawing.Size(358, 25)
        Me.txtReNewPassword.TabIndex = 2
        Me.txtReNewPassword.UseSystemPasswordChar = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(36, 204)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(358, 35)
        Me.btnChangePassword.TabIndex = 3
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassword.Location = New System.Drawing.Point(33, 17)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(150, 17)
        Me.lblCurrentPassword.TabIndex = 4
        Me.lblCurrentPassword.Text = "Enter current password"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.Location = New System.Drawing.Point(33, 76)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(131, 17)
        Me.lblNewPassword.TabIndex = 5
        Me.lblNewPassword.Text = "Enter new password"
        '
        'lblReNewPassword
        '
        Me.lblReNewPassword.AutoSize = True
        Me.lblReNewPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReNewPassword.Location = New System.Drawing.Point(33, 133)
        Me.lblReNewPassword.Name = "lblReNewPassword"
        Me.lblReNewPassword.Size = New System.Drawing.Size(151, 17)
        Me.lblReNewPassword.TabIndex = 6
        Me.lblReNewPassword.Text = "Re-enter new password"
        '
        'form_changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 281)
        Me.Controls.Add(Me.lblReNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblCurrentPassword)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.txtReNewPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "form_changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtReNewPassword As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblReNewPassword As Label
End Class
