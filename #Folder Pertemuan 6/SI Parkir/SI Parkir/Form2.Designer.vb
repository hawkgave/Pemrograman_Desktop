<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahProfil
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
        btnTutup = New Button()
        txtPasswordProfile = New TextBox()
        lblPasswordProfile = New Label()
        btnSimpan = New Button()
        txtUsernameProfile = New TextBox()
        lblUsernameProfile = New Label()
        TextBox1 = New TextBox()
        lblKetikLagi = New Label()
        SuspendLayout()
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(282, 181)
        btnTutup.Margin = New Padding(2, 2, 2, 2)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(90, 27)
        btnTutup.TabIndex = 11
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' txtPasswordProfile
        ' 
        txtPasswordProfile.BorderStyle = BorderStyle.FixedSingle
        txtPasswordProfile.Location = New Point(187, 92)
        txtPasswordProfile.Margin = New Padding(2, 2, 2, 2)
        txtPasswordProfile.Name = "txtPasswordProfile"
        txtPasswordProfile.Size = New Size(184, 27)
        txtPasswordProfile.TabIndex = 10
        txtPasswordProfile.Text = "input password"
        ' 
        ' lblPasswordProfile
        ' 
        lblPasswordProfile.AutoSize = True
        lblPasswordProfile.Location = New Point(58, 92)
        lblPasswordProfile.Margin = New Padding(2, 0, 2, 0)
        lblPasswordProfile.Name = "lblPasswordProfile"
        lblPasswordProfile.Size = New Size(70, 20)
        lblPasswordProfile.TabIndex = 9
        lblPasswordProfile.Text = "Password"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(187, 181)
        btnSimpan.Margin = New Padding(2, 2, 2, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(90, 27)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtUsernameProfile
        ' 
        txtUsernameProfile.BorderStyle = BorderStyle.FixedSingle
        txtUsernameProfile.Location = New Point(187, 49)
        txtUsernameProfile.Margin = New Padding(2, 2, 2, 2)
        txtUsernameProfile.Name = "txtUsernameProfile"
        txtUsernameProfile.Size = New Size(184, 27)
        txtUsernameProfile.TabIndex = 7
        txtUsernameProfile.Text = "input username"
        ' 
        ' lblUsernameProfile
        ' 
        lblUsernameProfile.AutoSize = True
        lblUsernameProfile.Location = New Point(58, 49)
        lblUsernameProfile.Margin = New Padding(2, 0, 2, 0)
        lblUsernameProfile.Name = "lblUsernameProfile"
        lblUsernameProfile.Size = New Size(75, 20)
        lblUsernameProfile.TabIndex = 6
        lblUsernameProfile.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(187, 133)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 27)
        TextBox1.TabIndex = 13
        TextBox1.Text = "input password lagi"
        ' 
        ' lblKetikLagi
        ' 
        lblKetikLagi.AutoSize = True
        lblKetikLagi.Location = New Point(58, 133)
        lblKetikLagi.Margin = New Padding(2, 0, 2, 0)
        lblKetikLagi.Name = "lblKetikLagi"
        lblKetikLagi.Size = New Size(74, 20)
        lblKetikLagi.TabIndex = 12
        lblKetikLagi.Text = "Ketik Lagi"
        ' 
        ' UbahProfil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(456, 262)
        Controls.Add(TextBox1)
        Controls.Add(lblKetikLagi)
        Controls.Add(btnTutup)
        Controls.Add(txtPasswordProfile)
        Controls.Add(lblPasswordProfile)
        Controls.Add(btnSimpan)
        Controls.Add(txtUsernameProfile)
        Controls.Add(lblUsernameProfile)
        Margin = New Padding(2, 2, 2, 2)
        Name = "UbahProfil"
        Text = "SIParkir - Ubah Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTutup As Button
    Friend WithEvents txtPasswordProfile As TextBox
    Friend WithEvents lblPasswordProfile As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtUsernameProfile As TextBox
    Friend WithEvents lblUsernameProfile As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblKetikLagi As Label
End Class
