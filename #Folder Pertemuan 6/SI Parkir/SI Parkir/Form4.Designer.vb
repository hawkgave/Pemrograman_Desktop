<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        MenuStrip1 = New MenuStrip()
        SToolStripMenuItem = New ToolStripMenuItem()
        AturProfileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        btnTutup = New Button()
        btnSimpan = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        txtPasswordProfile = New TextBox()
        lblPasswordProfile = New Label()
        Label1 = New Label()
        Label3 = New Label()
        DataGridView3 = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(640, 28)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SToolStripMenuItem
        ' 
        SToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfileToolStripMenuItem, LogoutToolStripMenuItem})
        SToolStripMenuItem.Name = "SToolStripMenuItem"
        SToolStripMenuItem.Size = New Size(67, 24)
        SToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfileToolStripMenuItem
        ' 
        AturProfileToolStripMenuItem.Name = "AturProfileToolStripMenuItem"
        AturProfileToolStripMenuItem.Size = New Size(167, 26)
        AturProfileToolStripMenuItem.Text = "Atur Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(167, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(165, 26)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(165, 26)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(256, 237)
        btnTutup.Margin = New Padding(2, 2, 2, 2)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(74, 27)
        btnTutup.TabIndex = 32
        btnTutup.Text = "Keluar"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(124, 237)
        btnSimpan.Margin = New Padding(2, 2, 2, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(81, 27)
        btnSimpan.TabIndex = 31
        btnSimpan.Text = "Masuk"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Bis/Truk"})
        ComboBox1.Location = New Point(124, 196)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(119, 28)
        ComboBox1.TabIndex = 30
        ComboBox1.Text = "Option 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 198)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 29
        Label2.Text = "Jenis"
        ' 
        ' txtPasswordProfile
        ' 
        txtPasswordProfile.BorderStyle = BorderStyle.FixedSingle
        txtPasswordProfile.Location = New Point(124, 164)
        txtPasswordProfile.Margin = New Padding(2, 2, 2, 2)
        txtPasswordProfile.Name = "txtPasswordProfile"
        txtPasswordProfile.Size = New Size(206, 27)
        txtPasswordProfile.TabIndex = 28
        txtPasswordProfile.Text = "text"
        ' 
        ' lblPasswordProfile
        ' 
        lblPasswordProfile.AutoSize = True
        lblPasswordProfile.Location = New Point(18, 164)
        lblPasswordProfile.Margin = New Padding(2, 0, 2, 0)
        lblPasswordProfile.Name = "lblPasswordProfile"
        lblPasswordProfile.Size = New Size(85, 20)
        lblPasswordProfile.TabIndex = 27
        lblPasswordProfile.Text = "Nomor Plat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 271)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 33
        Label1.Text = "Biaya Parkir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(359, 169)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 20)
        Label3.TabIndex = 35
        Label3.Text = "Kendaraan sedang parkir:"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(359, 196)
        DataGridView3.Margin = New Padding(2, 2, 2, 2)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 62
        DataGridView3.Size = New Size(271, 240)
        DataGridView3.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 358)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 37
        Label4.Text = "Informasi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 388)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 20)
        Label5.TabIndex = 38
        Label5.Text = "Tanggal: 12-34-5678"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 418)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(245, 20)
        Label6.TabIndex = 39
        Label6.Text = "o Motor, o Mobil, o Taksi, o Bis/Truk"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(195, 388)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 20)
        Label7.TabIndex = 40
        Label7.Text = "Jam: 00:00:00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ScrollBar
        Label8.Font = New Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(124, 280)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(214, 52)
        Label8.TabIndex = 41
        Label8.Text = "Rp   50.000"
        ' 
        ' Label9
        ' 
        Label9.BackColor = SystemColors.ScrollBar
        Label9.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 26)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(618, 124)
        Label9.TabIndex = 42
        Label9.Text = "R 6872 ZH"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 451)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView3)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(txtPasswordProfile)
        Controls.Add(lblPasswordProfile)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form4"
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPasswordProfile As TextBox
    Friend WithEvents lblPasswordProfile As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AturProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
End Class
