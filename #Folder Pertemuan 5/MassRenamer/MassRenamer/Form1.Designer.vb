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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lblPath = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chSize = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chSize2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        TpFilename = New TabPage()
        txtRightCropNCharF = New TextBox()
        cbCaseF = New ComboBox()
        txtWithThisF = New TextBox()
        txtInsertAfterF = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertAFterF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        TpExtension = New TabPage()
        txtRightCropNCharE = New TextBox()
        cbCaseE = New ComboBox()
        txtWithThisE = New TextBox()
        txtInsertAfterE = New TextBox()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        lblWithThisE = New Label()
        lblCaseE = New Label()
        rbRightCropNCharE = New RadioButton()
        rbLeftCropNCharE = New RadioButton()
        rbInsertAfterE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        TpAutoNumber = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        TpFilename.SuspendLayout()
        TpExtension.SuspendLayout()
        TpAutoNumber.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(17, 12)
        lblPath.Margin = New Padding(2, 0, 2, 0)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(37, 15)
        lblPath.TabIndex = 0
        lblPath.Text = "Path :"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(58, 12)
        txtPath.Margin = New Padding(2)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(243, 23)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(315, 10)
        btnPath.Margin = New Padding(2)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(32, 20)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(360, 14)
        lblExt.Margin = New Padding(2, 0, 2, 0)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(44, 15)
        lblExt.TabIndex = 3
        lblExt.Text = "File Ext"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(421, 12)
        txtExt.Margin = New Padding(2)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(43, 23)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(17, 40)
        lblOri.Margin = New Padding(2, 0, 2, 0)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(70, 15)
        lblOri.TabIndex = 5
        lblOri.Text = "Original File"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(360, 43)
        lblPreview.Margin = New Padding(2, 0, 2, 0)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(69, 15)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chSize, chAttribute, chCreated, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.HoverSelection = True
        lvOri.Location = New Point(17, 73)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(299, 351)
        lvOri.TabIndex = 7
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chSize
        ' 
        chSize.DisplayIndex = 6
        chSize.Text = "Size"
        ' 
        ' chAttribute
        ' 
        chAttribute.DisplayIndex = 2
        chAttribute.Text = "Attributes"
        ' 
        ' chCreated
        ' 
        chCreated.DisplayIndex = 3
        chCreated.Text = "Date Created"
        ' 
        ' chAccessed
        ' 
        chAccessed.DisplayIndex = 4
        chAccessed.Text = "Date Accessed"
        ' 
        ' chModified
        ' 
        chModified.DisplayIndex = 5
        chModified.Text = "Date Modified"
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chSize2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(361, 73)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(290, 351)
        lvPreview.TabIndex = 8
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        ' 
        ' chSize2
        ' 
        chSize2.DisplayIndex = 6
        chSize2.Text = "Size"
        ' 
        ' chAttribute2
        ' 
        chAttribute2.DisplayIndex = 2
        chAttribute2.Text = "Attributes"
        ' 
        ' chCreated2
        ' 
        chCreated2.DisplayIndex = 3
        chCreated2.Text = "Date Created"
        ' 
        ' chAccessed2
        ' 
        chAccessed2.DisplayIndex = 4
        chAccessed2.Text = "Date Accessed"
        ' 
        ' chModified2
        ' 
        chModified2.DisplayIndex = 5
        chModified2.Text = "Date Modified"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpFilename)
        TabControl1.Controls.Add(TpExtension)
        TabControl1.Controls.Add(TpAutoNumber)
        TabControl1.Location = New Point(17, 433)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(499, 173)
        TabControl1.TabIndex = 9
        ' 
        ' TpFilename
        ' 
        TpFilename.Controls.Add(txtRightCropNCharF)
        TpFilename.Controls.Add(cbCaseF)
        TpFilename.Controls.Add(txtWithThisF)
        TpFilename.Controls.Add(txtInsertAfterF)
        TpFilename.Controls.Add(txtLeftCropNCharF)
        TpFilename.Controls.Add(txtInsertBeforeF)
        TpFilename.Controls.Add(txtReplaceThisF)
        TpFilename.Controls.Add(txtReplaceWithF)
        TpFilename.Controls.Add(lblWithThisF)
        TpFilename.Controls.Add(lblCaseF)
        TpFilename.Controls.Add(rbRightCropNCharF)
        TpFilename.Controls.Add(rbLeftCropNCharF)
        TpFilename.Controls.Add(rbInsertAFterF)
        TpFilename.Controls.Add(rbInsertBeforeF)
        TpFilename.Controls.Add(rbReplaceThisF)
        TpFilename.Controls.Add(rbReplaceWithF)
        TpFilename.Location = New Point(4, 24)
        TpFilename.Name = "TpFilename"
        TpFilename.Padding = New Padding(3)
        TpFilename.Size = New Size(491, 145)
        TpFilename.TabIndex = 0
        TpFilename.Text = "Filename"
        TpFilename.UseVisualStyleBackColor = True
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(406, 83)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(79, 23)
        txtRightCropNCharF.TabIndex = 16
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(326, 10)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(159, 23)
        cbCaseF.TabIndex = 15
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(342, 33)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(143, 23)
        txtWithThisF.TabIndex = 14
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(371, 58)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(114, 23)
        txtInsertAfterF.TabIndex = 13
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(129, 83)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(147, 23)
        txtLeftCropNCharF.TabIndex = 11
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(113, 58)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(163, 23)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(113, 33)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(163, 23)
        txtReplaceThisF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(113, 8)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(163, 23)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(282, 36)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(54, 15)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "With this"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(282, 13)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(38, 15)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case :"
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(282, 84)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(118, 19)
        rbRightCropNCharF.TabIndex = 5
        rbRightCropNCharF.Text = "Right Crop n char"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(13, 84)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(110, 19)
        rbLeftCropNCharF.TabIndex = 4
        rbLeftCropNCharF.Text = "Left Crop n char"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAFterF
        ' 
        rbInsertAFterF.AutoSize = True
        rbInsertAFterF.Location = New Point(282, 59)
        rbInsertAFterF.Name = "rbInsertAFterF"
        rbInsertAFterF.Size = New Size(83, 19)
        rbInsertAFterF.TabIndex = 3
        rbInsertAFterF.Text = "Insert After"
        rbInsertAFterF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(13, 59)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(91, 19)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.Text = "Insert Before"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(13, 34)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(90, 19)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.Text = "Replace This"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(13, 9)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(94, 19)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.Text = "Replace With"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' TpExtension
        ' 
        TpExtension.Controls.Add(txtRightCropNCharE)
        TpExtension.Controls.Add(cbCaseE)
        TpExtension.Controls.Add(txtWithThisE)
        TpExtension.Controls.Add(txtInsertAfterE)
        TpExtension.Controls.Add(txtLeftCropNCharE)
        TpExtension.Controls.Add(txtInsertBeforeE)
        TpExtension.Controls.Add(txtReplaceThisE)
        TpExtension.Controls.Add(txtReplaceWithE)
        TpExtension.Controls.Add(lblWithThisE)
        TpExtension.Controls.Add(lblCaseE)
        TpExtension.Controls.Add(rbRightCropNCharE)
        TpExtension.Controls.Add(rbLeftCropNCharE)
        TpExtension.Controls.Add(rbInsertAfterE)
        TpExtension.Controls.Add(rbInsertBeforeE)
        TpExtension.Controls.Add(rbReplaceThisE)
        TpExtension.Controls.Add(rbReplaceWithE)
        TpExtension.Location = New Point(4, 24)
        TpExtension.Name = "TpExtension"
        TpExtension.Size = New Size(491, 145)
        TpExtension.TabIndex = 2
        TpExtension.Text = "Extension"
        TpExtension.UseVisualStyleBackColor = True
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(405, 87)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(79, 23)
        txtRightCropNCharE.TabIndex = 12
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowecase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(325, 14)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(159, 23)
        cbCaseE.TabIndex = 30
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(341, 37)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(143, 23)
        txtWithThisE.TabIndex = 29
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(370, 62)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(114, 23)
        txtInsertAfterE.TabIndex = 28
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(128, 87)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(147, 23)
        txtLeftCropNCharE.TabIndex = 27
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(112, 62)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(163, 23)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(112, 37)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(163, 23)
        txtReplaceThisE.TabIndex = 25
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(112, 12)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(163, 23)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(281, 40)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(54, 15)
        lblWithThisE.TabIndex = 6
        lblWithThisE.Text = "With this"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(281, 17)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(38, 15)
        lblCaseE.TabIndex = 7
        lblCaseE.Text = "Case :"
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(281, 88)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(118, 19)
        rbRightCropNCharE.TabIndex = 5
        rbRightCropNCharE.Text = "Right Crop n char"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(12, 88)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(110, 19)
        rbLeftCropNCharE.TabIndex = 3
        rbLeftCropNCharE.Text = "Left Crop n char"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(281, 63)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(83, 19)
        rbInsertAfterE.TabIndex = 4
        rbInsertAfterE.Text = "Insert After"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(12, 63)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(91, 19)
        rbInsertBeforeE.TabIndex = 2
        rbInsertBeforeE.Text = "Insert Before"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(12, 38)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(90, 19)
        rbReplaceThisE.TabIndex = 1
        rbReplaceThisE.Text = "Replace This"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(12, 13)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(94, 19)
        rbReplaceWithE.TabIndex = 0
        rbReplaceWithE.Text = "Replace With"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' TpAutoNumber
        ' 
        TpAutoNumber.Controls.Add(gbWith)
        TpAutoNumber.Controls.Add(gbPlace)
        TpAutoNumber.Location = New Point(4, 24)
        TpAutoNumber.Name = "TpAutoNumber"
        TpAutoNumber.Size = New Size(491, 145)
        TpAutoNumber.TabIndex = 3
        TpAutoNumber.Text = "Autonumber"
        TpAutoNumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(210, 5)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(200, 137)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With :"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(131, 65)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(63, 23)
        nudIncrementBy.TabIndex = 3
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(131, 27)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(63, 23)
        nudStartWithNumber.TabIndex = 2
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(15, 67)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(83, 15)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by :"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(15, 29)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(112, 15)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start With Number :"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(4, 5)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(200, 137)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place :"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(16, 65)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(108, 19)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Checked = True
        rbAfterFileName.Location = New Point(16, 29)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(100, 19)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(552, 433)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(552, 462)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(75, 23)
        btnRename.TabIndex = 11
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(552, 491)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(75, 23)
        btnUndo.TabIndex = 12
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(662, 636)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        TpFilename.ResumeLayout(False)
        TpFilename.PerformLayout()
        TpExtension.ResumeLayout(False)
        TpExtension.PerformLayout()
        TpAutoNumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAFterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents chSize As ColumnHeader
    Friend WithEvents chSize2 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList

End Class
