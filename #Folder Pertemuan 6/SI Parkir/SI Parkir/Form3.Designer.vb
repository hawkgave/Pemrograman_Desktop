<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Langganan
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
        TextBox1 = New TextBox()
        lblKetikLagi = New Label()
        txtPasswordProfile = New TextBox()
        lblPasswordProfile = New Label()
        txtUsernameProfile = New TextBox()
        lblUsernameProfile = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        btnTutup = New Button()
        btnSimpan = New Button()
        Button1 = New Button()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(142, 103)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 27)
        TextBox1.TabIndex = 19
        TextBox1.Text = "text"
        ' 
        ' lblKetikLagi
        ' 
        lblKetikLagi.AutoSize = True
        lblKetikLagi.Location = New Point(12, 103)
        lblKetikLagi.Margin = New Padding(2, 0, 2, 0)
        lblKetikLagi.Name = "lblKetikLagi"
        lblKetikLagi.Size = New Size(114, 20)
        lblKetikLagi.TabIndex = 18
        lblKetikLagi.Text = "Tarif Langganan"
        ' 
        ' txtPasswordProfile
        ' 
        txtPasswordProfile.BorderStyle = BorderStyle.FixedSingle
        txtPasswordProfile.Location = New Point(142, 74)
        txtPasswordProfile.Margin = New Padding(2, 2, 2, 2)
        txtPasswordProfile.Name = "txtPasswordProfile"
        txtPasswordProfile.Size = New Size(244, 27)
        txtPasswordProfile.TabIndex = 17
        txtPasswordProfile.Text = "text"
        ' 
        ' lblPasswordProfile
        ' 
        lblPasswordProfile.AutoSize = True
        lblPasswordProfile.Location = New Point(12, 74)
        lblPasswordProfile.Margin = New Padding(2, 0, 2, 0)
        lblPasswordProfile.Name = "lblPasswordProfile"
        lblPasswordProfile.Size = New Size(85, 20)
        lblPasswordProfile.TabIndex = 16
        lblPasswordProfile.Text = "Nomor Plat"
        ' 
        ' txtUsernameProfile
        ' 
        txtUsernameProfile.BorderStyle = BorderStyle.FixedSingle
        txtUsernameProfile.Location = New Point(142, 32)
        txtUsernameProfile.Margin = New Padding(2, 2, 2, 2)
        txtUsernameProfile.Name = "txtUsernameProfile"
        txtUsernameProfile.Size = New Size(300, 27)
        txtUsernameProfile.TabIndex = 15
        txtUsernameProfile.Text = "text"
        ' 
        ' lblUsernameProfile
        ' 
        lblUsernameProfile.AutoSize = True
        lblUsernameProfile.Location = New Point(12, 32)
        lblUsernameProfile.Margin = New Padding(2, 0, 2, 0)
        lblUsernameProfile.Name = "lblUsernameProfile"
        lblUsernameProfile.Size = New Size(122, 20)
        lblUsernameProfile.TabIndex = 14
        lblUsernameProfile.Text = "Nama Pelanggan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(446, 34)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 20
        Label1.Text = "ID Pelanggan:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(398, 78)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 21
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 136)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 22
        Label3.Text = "Berlaku Hingga"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(142, 136)
        DateTimePicker1.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(244, 27)
        DateTimePicker1.TabIndex = 23
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Bis/Truk"})
        ComboBox1.Location = New Point(483, 76)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(119, 28)
        ComboBox1.TabIndex = 24
        ComboBox1.Text = "Option 1"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(484, 136)
        btnTutup.Margin = New Padding(2, 2, 2, 2)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(74, 27)
        btnTutup.TabIndex = 26
        btnTutup.Text = "Edit"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(398, 136)
        btnSimpan.Margin = New Padding(2, 2, 2, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(81, 27)
        btnSimpan.TabIndex = 25
        btnSimpan.Text = "Tambah"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(562, 136)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(68, 27)
        Button1.TabIndex = 27
        Button1.Text = "Hapus"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 181)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 20)
        Label4.TabIndex = 28
        Label4.Text = "Kendaraan terdaftar langganan: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 203)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(617, 140)
        DataGridView1.TabIndex = 29
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(562, 348)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(69, 27)
        Button2.TabIndex = 30
        Button2.Text = "Tutup"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Langganan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 385)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(lblKetikLagi)
        Controls.Add(txtPasswordProfile)
        Controls.Add(lblPasswordProfile)
        Controls.Add(txtUsernameProfile)
        Controls.Add(lblUsernameProfile)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Langganan"
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblKetikLagi As Label
    Friend WithEvents txtPasswordProfile As TextBox
    Friend WithEvents lblPasswordProfile As Label
    Friend WithEvents txtUsernameProfile As TextBox
    Friend WithEvents lblUsernameProfile As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
End Class
