<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ImageList1 = New ImageList(components)
        statusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusDimension = New ToolStripStatusLabel()
        toolStripStatusBits = New ToolStripStatusLabel()
        toolStripStatusResolution = New ToolStripStatusLabel()
        toolStripStatusRawFormat = New ToolStripStatusLabel()
        ToolTip1 = New ToolTip(components)
        lvImage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        tvDrive = New TreeView()
        SplitContainer1 = New SplitContainer()
        SplitContainer2 = New SplitContainer()
        SplitContainer3 = New SplitContainer()
        tcProperties = New TabControl()
        TabControl1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabControl2 = New TabPage()
        lvExif = New ListView()
        chProperty = New ColumnHeader()
        chValue = New ColumnHeader()
        statusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        tcProperties.SuspendLayout()
        TabControl1.SuspendLayout()
        TabControl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive")
        ImageList1.Images.SetKeyName(1, "folder")
        ' 
        ' statusStrip1
        ' 
        statusStrip1.ImageScalingSize = New Size(20, 20)
        statusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusDimension, toolStripStatusBits, toolStripStatusResolution, toolStripStatusRawFormat})
        statusStrip1.Location = New Point(0, 584)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Size(948, 30)
        statusStrip1.TabIndex = 0
        statusStrip1.Text = "statusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(50, 24)
        toolStripStatusReady.Text = "Ready"
        ' 
        ' toolStripStatusDimension
        ' 
        toolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        toolStripStatusDimension.Name = "toolStripStatusDimension"
        toolStripStatusDimension.Size = New Size(90, 24)
        toolStripStatusDimension.Text = "Dimensions"
        ' 
        ' toolStripStatusBits
        ' 
        toolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusBits.BorderStyle = Border3DStyle.Etched
        toolStripStatusBits.Name = "toolStripStatusBits"
        toolStripStatusBits.Size = New Size(68, 24)
        toolStripStatusBits.Text = "# of bits"
        ' 
        ' toolStripStatusResolution
        ' 
        toolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        toolStripStatusResolution.Name = "toolStripStatusResolution"
        toolStripStatusResolution.Size = New Size(83, 24)
        toolStripStatusResolution.Text = "Resolution"
        ' 
        ' toolStripStatusRawFormat
        ' 
        toolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        toolStripStatusRawFormat.Name = "toolStripStatusRawFormat"
        toolStripStatusRawFormat.Size = New Size(92, 24)
        toolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        ' 
        ' lvImage
        ' 
        lvImage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        lvImage.GridLines = True
        lvImage.Location = New Point(7, 3)
        lvImage.Name = "lvImage"
        lvImage.Size = New Size(705, 238)
        lvImage.SmallImageList = ImageList1
        lvImage.TabIndex = 0
        ToolTip1.SetToolTip(lvImage, "Image file(s)")
        lvImage.UseCompatibleStateImageBehavior = False
        lvImage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Modified Date"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(464, 326)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto")
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(224, 584)
        tvDrive.TabIndex = 0
        ToolTip1.SetToolTip(tvDrive, "Please select drive/folder that contain" & vbCrLf & "one or more images")
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(948, 584)
        SplitContainer1.SplitterDistance = 224
        SplitContainer1.TabIndex = 0
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(lvImage)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(SplitContainer3)
        SplitContainer2.Size = New Size(720, 584)
        SplitContainer2.SplitterDistance = 244
        SplitContainer2.TabIndex = 0
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(tcProperties)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(PictureBox1)
        SplitContainer3.Size = New Size(720, 336)
        SplitContainer3.SplitterDistance = 238
        SplitContainer3.TabIndex = 0
        ' 
        ' tcProperties
        ' 
        tcProperties.Controls.Add(TabControl1)
        tcProperties.Controls.Add(TabControl2)
        tcProperties.Dock = DockStyle.Fill
        tcProperties.Location = New Point(0, 0)
        tcProperties.Name = "tcProperties"
        tcProperties.SelectedIndex = 0
        tcProperties.Size = New Size(238, 336)
        tcProperties.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(PropertyGrid1)
        TabControl1.Location = New Point(4, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Padding(3)
        TabControl1.Size = New Size(230, 303)
        TabControl1.TabIndex = 0
        TabControl1.Text = "Image Properties"
        TabControl1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(224, 297)
        PropertyGrid1.TabIndex = 0
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(lvExif)
        TabControl2.Location = New Point(4, 29)
        TabControl2.Name = "TabControl2"
        TabControl2.Padding = New Padding(3)
        TabControl2.Size = New Size(230, 303)
        TabControl2.TabIndex = 1
        TabControl2.Text = "EXIF Metadata"
        TabControl2.UseVisualStyleBackColor = True
        ' 
        ' lvExif
        ' 
        lvExif.Columns.AddRange(New ColumnHeader() {chProperty, chValue})
        lvExif.GridLines = True
        lvExif.Location = New Point(0, 0)
        lvExif.Name = "lvExif"
        lvExif.Size = New Size(201, 297)
        lvExif.TabIndex = 1
        lvExif.UseCompatibleStateImageBehavior = False
        lvExif.View = View.Details
        ' 
        ' chProperty
        ' 
        chProperty.Text = "Property"
        ' 
        ' chValue
        ' 
        chValue.Text = "Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 614)
        Controls.Add(SplitContainer1)
        Controls.Add(statusStrip1)
        Name = "Form1"
        Text = "Form1"
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        tcProperties.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents toolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents toolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents toolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents lvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents tcProperties As TabControl
    Friend WithEvents TabControl1 As TabPage
    Friend WithEvents TabControl2 As TabPage
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tvDrive As TreeView

End Class
