<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        btnSave = New Button()
        btnClose = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        txtRetype = New TextBox()
        lblRetype = New Label()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(166, 202)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(115, 34)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(316, 202)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(115, 34)
        btnClose.TabIndex = 12
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(166, 87)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(265, 31)
        txtPassword.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(166, 36)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(265, 31)
        txtUsername.TabIndex = 10
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(37, 90)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(91, 25)
        lblPassword.TabIndex = 9
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(37, 39)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(95, 25)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username:"
        ' 
        ' txtRetype
        ' 
        txtRetype.Location = New Point(166, 139)
        txtRetype.Name = "txtRetype"
        txtRetype.Size = New Size(265, 31)
        txtRetype.TabIndex = 15
        ' 
        ' lblRetype
        ' 
        lblRetype.AutoSize = True
        lblRetype.Location = New Point(37, 142)
        lblRetype.Name = "lblRetype"
        lblRetype.Size = New Size(109, 25)
        lblRetype.TabIndex = 14
        lblRetype.Text = "Retype Pass:"
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 265)
        Controls.Add(txtRetype)
        Controls.Add(lblRetype)
        Controls.Add(btnSave)
        Controls.Add(btnClose)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents lblRetype As Label
End Class
