<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        txtPasswordProfile = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(554, 323)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(69, 27)
        Button2.TabIndex = 31
        Button2.Text = "Tutup"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Januari", "Februari", "Mret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        ComboBox1.Location = New Point(104, 18)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(72, 28)
        ComboBox1.TabIndex = 34
        ComboBox1.Text = "Bulan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 21)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 33
        Label2.Text = "Periode"
        ' 
        ' txtPasswordProfile
        ' 
        txtPasswordProfile.BorderStyle = BorderStyle.FixedSingle
        txtPasswordProfile.Location = New Point(180, 18)
        txtPasswordProfile.Margin = New Padding(2, 2, 2, 2)
        txtPasswordProfile.Name = "txtPasswordProfile"
        txtPasswordProfile.Size = New Size(58, 27)
        txtPasswordProfile.TabIndex = 32
        txtPasswordProfile.Text = "Tahun"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 58)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 35
        Label1.Text = "Laporan: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(254, 17)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 27)
        Button1.TabIndex = 36
        Button1.Text = "Tampilkan!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 360)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(txtPasswordProfile)
        Controls.Add(Button2)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form5"
        Text = "SIParkir - Laporan Pendapatan Parkir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPasswordProfile As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
