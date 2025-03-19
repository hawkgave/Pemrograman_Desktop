<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        lblId = New Label()
        lblNoPlat = New Label()
        lblNama = New Label()
        lblBiaya = New Label()
        lblJenis = New Label()
        lblExpired = New Label()
        txtNama = New TextBox()
        txtNoPlat = New TextBox()
        txtBiaya = New TextBox()
        cmbJenis = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        btnCancel = New Button()
        DataGridView1 = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        NoPlat = New DataGridViewTextBoxColumn()
        NamaPemilik = New DataGridViewTextBoxColumn()
        Biaya = New DataGridViewTextBoxColumn()
        Jenis = New DataGridViewTextBoxColumn()
        Expired = New DataGridViewTextBoxColumn()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(468, 24)
        lblId.Name = "lblId"
        lblId.Size = New Size(28, 25)
        lblId.TabIndex = 0
        lblId.Text = "Id"
        lblId.Visible = False
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Location = New Point(29, 24)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(78, 25)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "No. Plat:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(29, 69)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama:"
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(29, 117)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(57, 25)
        lblBiaya.TabIndex = 3
        lblBiaya.Text = "Biaya:"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(489, 120)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(53, 25)
        lblJenis.TabIndex = 4
        lblJenis.Text = "Jenis:"
        ' 
        ' lblExpired
        ' 
        lblExpired.AutoSize = True
        lblExpired.Location = New Point(29, 163)
        lblExpired.Name = "lblExpired"
        lblExpired.Size = New Size(74, 25)
        lblExpired.TabIndex = 5
        lblExpired.Text = "Expired:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(130, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(426, 31)
        txtNama.TabIndex = 6
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(130, 21)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(304, 31)
        txtNoPlat.TabIndex = 7
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(130, 114)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(304, 31)
        txtBiaya.TabIndex = 8
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        cmbJenis.Location = New Point(559, 114)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(182, 33)
        cmbJenis.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(130, 158)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 11
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(821, 158)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Id, NoPlat, NamaPemilik, Biaya, Jenis, Expired})
        DataGridView1.Location = New Point(29, 213)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(965, 225)
        DataGridView1.TabIndex = 16
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.MinimumWidth = 8
        Id.Name = "Id"
        Id.Width = 150
        ' 
        ' NoPlat
        ' 
        NoPlat.HeaderText = "No Plat"
        NoPlat.MinimumWidth = 8
        NoPlat.Name = "NoPlat"
        NoPlat.Width = 150
        ' 
        ' NamaPemilik
        ' 
        NamaPemilik.HeaderText = "Nama Pemilik"
        NamaPemilik.MinimumWidth = 8
        NamaPemilik.Name = "NamaPemilik"
        NamaPemilik.Width = 150
        ' 
        ' Biaya
        ' 
        Biaya.HeaderText = "Biaya"
        Biaya.MinimumWidth = 8
        Biaya.Name = "Biaya"
        Biaya.Width = 150
        ' 
        ' Jenis
        ' 
        Jenis.HeaderText = "Jenis"
        Jenis.MinimumWidth = 8
        Jenis.Name = "Jenis"
        Jenis.Width = 150
        ' 
        ' Expired
        ' 
        Expired.HeaderText = "Expired"
        Expired.MinimumWidth = 8
        Expired.Name = "Expired"
        Expired.Width = 150
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(703, 158)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 17
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(585, 158)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 34)
        btnEdit.TabIndex = 18
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(468, 158)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 19
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 450)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(DateTimePicker1)
        Controls.Add(cmbJenis)
        Controls.Add(txtBiaya)
        Controls.Add(txtNoPlat)
        Controls.Add(txtNama)
        Controls.Add(lblExpired)
        Controls.Add(lblJenis)
        Controls.Add(lblBiaya)
        Controls.Add(lblNama)
        Controls.Add(lblNoPlat)
        Controls.Add(lblId)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Kendaraan Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NoPlat As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemilik As DataGridViewTextBoxColumn
    Friend WithEvents Biaya As DataGridViewTextBoxColumn
    Friend WithEvents Jenis As DataGridViewTextBoxColumn
    Friend WithEvents Expired As DataGridViewTextBoxColumn
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
End Class
