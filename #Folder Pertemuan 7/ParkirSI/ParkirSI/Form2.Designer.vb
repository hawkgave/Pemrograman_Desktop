<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        SToolStripMenuItem = New ToolStripMenuItem()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        KendaraanLanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanPendapatanToolStripMenuItem = New ToolStripMenuItem()
        BToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        pnlPlat = New Panel()
        lblPlat = New Label()
        pnlHarga = New Panel()
        lblHarga = New Label()
        pnlInput = New Panel()
        lblInfoJenis = New Label()
        lblTekan = New Label()
        lblInputPlat = New Label()
        lblJenis = New Label()
        txtNoPlat = New TextBox()
        pnlGrid = New Panel()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        lblInfoUser = New Label()
        lblTgl = New Label()
        lblJmlKendaraan = New Label()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        pnlPlat.SuspendLayout()
        pnlHarga.SuspendLayout()
        pnlInput.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SToolStripMenuItem, AdminToolStripMenuItem, BToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1161, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SToolStripMenuItem
        ' 
        SToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfileToolStripMenuItem, LogoutToolStripMenuItem})
        SToolStripMenuItem.Name = "SToolStripMenuItem"
        SToolStripMenuItem.Size = New Size(81, 29)
        SToolStripMenuItem.Text = "Sistem"
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        ProfileToolStripMenuItem.Size = New Size(270, 34)
        ProfileToolStripMenuItem.Text = "Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(270, 34)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KendaraanLanggananToolStripMenuItem, LaporanPendapatanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(81, 29)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' KendaraanLanggananToolStripMenuItem
        ' 
        KendaraanLanggananToolStripMenuItem.Name = "KendaraanLanggananToolStripMenuItem"
        KendaraanLanggananToolStripMenuItem.Size = New Size(289, 34)
        KendaraanLanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        ' 
        ' LaporanPendapatanToolStripMenuItem
        ' 
        LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        LaporanPendapatanToolStripMenuItem.Size = New Size(289, 34)
        LaporanPendapatanToolStripMenuItem.Text = "Laporan Pendapatan"
        ' 
        ' BToolStripMenuItem
        ' 
        BToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem, TentangToolStripMenuItem})
        BToolStripMenuItem.Name = "BToolStripMenuItem"
        BToolStripMenuItem.Size = New Size(92, 29)
        BToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(270, 34)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(270, 34)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(241, 69)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(240, 32)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.Controls.Add(lblPlat)
        pnlPlat.Dock = DockStyle.Top
        pnlPlat.Location = New Point(0, 33)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.Size = New Size(1161, 150)
        pnlPlat.TabIndex = 2
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlat.Location = New Point(172, -26)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(783, 191)
        lblPlat.TabIndex = 0
        lblPlat.Text = "R 6872 ZH"
        ' 
        ' pnlHarga
        ' 
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.Controls.Add(lblHarga)
        pnlHarga.Location = New Point(12, 192)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.Size = New Size(475, 98)
        pnlHarga.TabIndex = 0
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(3, 16)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(93, 60)
        lblHarga.TabIndex = 0
        lblHarga.Text = "Rp."
        ' 
        ' pnlInput
        ' 
        pnlInput.BorderStyle = BorderStyle.Fixed3D
        pnlInput.Controls.Add(lblInfoJenis)
        pnlInput.Controls.Add(lblTekan)
        pnlInput.Controls.Add(lblInputPlat)
        pnlInput.Controls.Add(lblJenis)
        pnlInput.Controls.Add(txtNoPlat)
        pnlInput.Location = New Point(12, 296)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(475, 150)
        pnlInput.TabIndex = 3
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(355, 22)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(63, 25)
        lblInfoJenis.TabIndex = 4
        lblInfoJenis.Text = "Label1"
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTekan.Location = New Point(-2, 91)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(273, 25)
        lblTekan.TabIndex = 3
        lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.Location = New Point(4, 22)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(92, 25)
        lblInputPlat.TabIndex = 2
        lblInputPlat.Text = "Input Plat:"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJenis.Location = New Point(-2, 66)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(481, 25)
        lblJenis.TabIndex = 1
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNoPlat.Location = New Point(105, 14)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(244, 39)
        txtNoPlat.TabIndex = 0
        ' 
        ' pnlGrid
        ' 
        pnlGrid.AutoScroll = True
        pnlGrid.Controls.Add(DataGridView1)
        pnlGrid.Location = New Point(493, 192)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(656, 410)
        pnlGrid.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, ColJenis})
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(656, 410)
        DataGridView1.TabIndex = 0
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.MinimumWidth = 8
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.Width = 150
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.MinimumWidth = 8
        ColMasuk.Name = "ColMasuk"
        ColMasuk.Width = 150
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.MinimumWidth = 8
        ColKeluar.Name = "ColKeluar"
        ColKeluar.Width = 150
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 8
        ColHarga.Name = "ColHarga"
        ColHarga.Width = 150
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 8
        ColJenis.Name = "ColJenis"
        ColJenis.Width = 150
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoUser.Location = New Point(16, 467)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(105, 25)
        lblInfoUser.TabIndex = 5
        lblInfoUser.Text = "Informasi -"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(18, 492)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(82, 25)
        lblTgl.TabIndex = 6
        lblTgl.Text = "Tanggal: "
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Location = New Point(18, 517)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(376, 25)
        lblJmlKendaraan.TabIndex = 7
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk" & vbCrLf
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1161, 614)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblTgl)
        Controls.Add(lblInfoUser)
        Controls.Add(pnlGrid)
        Controls.Add(pnlInput)
        Controls.Add(pnlHarga)
        Controls.Add(pnlPlat)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        pnlPlat.ResumeLayout(False)
        pnlPlat.PerformLayout()
        pnlHarga.ResumeLayout(False)
        pnlHarga.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        pnlGrid.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KendaraanLanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
End Class
