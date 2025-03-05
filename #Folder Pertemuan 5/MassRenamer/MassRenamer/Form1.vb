Imports System.IO

Public Class Form1
    Dim arrFile As List(Of String) = New List(Of String) 'untuk menampung semua file original sebelum direname
    Dim arrFile2 As List(Of String) = New List(Of String) 'untuk menampung semua file hasil setelah direname
    Dim arrExt As List(Of String) = New List(Of String) 'untuk menampung semua extension file original sebelum direname
    Dim arrExt2 As List(Of String) = New List(Of String) 'untuk menampung semua extension file setelah direname
    Dim arrUndo As List(Of String) = New List(Of String) 'untuk menampung data file dan ext sebelumnya
    Dim mode As String

    Sub MuatUlang()
        lvOri.Items.Clear()
        lvOri.View = View.Details
        lvOri.BeginUpdate()
        lvPreview.Items.Clear()
        lvPreview.View = View.Details
        lvPreview.BeginUpdate()

        Dim hasil As String() = Directory.GetFiles(txtPath.Text, txtExt.Text, SearchOption.TopDirectoryOnly)
        arrFile.Clear()
        arrFile2.Clear()
        arrExt.Clear()
        arrExt2.Clear()
        arrFile.AddRange(hasil)
        arrFile2.AddRange(hasil)

        For i As Integer = 0 To hasil.Length - 1
            Dim iconForFile As Icon = SystemIcons.WinLogo
            Dim fileName As String = Path.GetFileNameWithoutExtension(hasil(i))
            Dim ext As String = Path.GetExtension(hasil(i))

            If Not (ImageList1.Images.ContainsKey(ext)) Then
                iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(hasil(i))
                ImageList1.Images.Add(ext, iconForFile)
            End If

            arrExt.Add(ext)
            arrExt2.Add(ext)

            Dim f As FileInfo = New FileInfo(hasil(i))
            Dim att As String = f.Attributes.ToString
            Dim size As String = f.Length.ToString
            Dim dibuat As String = f.CreationTime.ToString
            Dim akses As String = f.LastAccessTime.ToString
            Dim modi As String = f.LastWriteTime.ToString

            Dim item1 As ListViewItem = New ListViewItem(New String() {fileName, ext, size, att, dibuat, akses, modi})
            item1.ImageKey = ext
            Dim item2 As ListViewItem = New ListViewItem(New String() {fileName, ext, size, att, dibuat, akses, modi})
            item2.ImageKey = ext

            lvOri.Items.Add(item1)
            lvPreview.Items.Add(item2)
        Next

        lvOri.EndUpdate()
        lvPreview.EndUpdate()
        lvOri.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        lvPreview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub btnPath_Click(sender As System.Object, e As System.EventArgs) Handles btnPath.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
            MuatUlang()
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbCaseF.SelectedIndex = 2
        cbCaseE.SelectedIndex = 2
    End Sub

    Private Sub rbReplaceWithF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbReplaceWithF.CheckedChanged, rbReplaceWithF.Click
        If rbReplaceWithF.Checked Then
            mode = "R"
            txtReplaceWithF.ReadOnly = False
        Else
            mode = "X"
            txtReplaceWithF.ReadOnly = True
        End If
    End Sub

    Private Sub rbReplaceThisF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbReplaceThisF.CheckedChanged, rbReplaceThisF.Click
        If rbReplaceThisF.Checked Then
            mode = "R2"
            txtReplaceThisF.ReadOnly = False
            txtWithThisF.ReadOnly = False
        Else
            mode = "X"
            txtReplaceThisF.ReadOnly = True
            txtWithThisF.ReadOnly = True
        End If
    End Sub

    Function ListViewContainsDuplicates(ByVal listView As ListView, ByVal subItemIndex As Integer) As Boolean
        Dim DistinctCount As Integer = (From Item In listView.Items
                                        Select CType(Item, ListViewItem).SubItems(subItemIndex).Text Distinct).Count
        Return DistinctCount <> listView.Items.Count
    End Function

    Private Sub btnPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        If mode = "R2" Then 'replace this F
            Dim s1 As String = txtReplaceThisF.Text
            Dim s2 As String = txtWithThisF.Text

            If s1.Length = 0 Then
                s1 = " "
            End If

            If s2.Length = 0 Then
                s2 = " "
            End If

            For i As Integer = 0 To arrFile2.Count - 1
                arrFile2(i) = Path.GetFileNameWithoutExtension(arrFile2(i)).Replace(s1, s2)
                lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
            Next

        ElseIf mode = "R" Then 'replace with F
            For i As Integer = 0 To arrFile2.Count - 1
                arrFile2(i) = arrFile2(i).Replace(arrFile2(i), txtReplaceWithF.Text)
                lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
            Next

        ElseIf mode = "IB" Then 'insert before F
            For i As Integer = 0 To arrFile2.Count - 1
                arrFile2(i) = Path.GetFileNameWithoutExtension(arrFile2(i)).Insert(0, txtInsertBeforeF.Text)
                lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
            Next

        ElseIf mode = "IA" Then 'insert after F
            For i As Integer = 0 To arrFile2.Count - 1
                Dim x As String = Path.GetFileNameWithoutExtension(arrFile2(i))
                arrFile2(i) = x.Insert(x.Length, txtInsertAfterF.Text)
                lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
            Next

        ElseIf mode = "LC" Then 'Left crop n char F
            If (txtLeftCropNCharF.Text <> "" Or Val(txtLeftCropNCharF.Text) > 0) Then
                For i As Integer = 0 To arrFile2.Count - 1
                    Dim x As String = Path.GetFileNameWithoutExtension(arrFile2(i))
                    arrFile2(i) = x.Substring(txtLeftCropNCharF.Text)
                    lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
                Next
            Else
                For i As Integer = 0 To arrFile.Count - 1
                    Dim x As String = Path.GetFileNameWithoutExtension(arrFile(i))
                    lvPreview.Items.Item(i).Text = Trim(x)
                Next
            End If

        ElseIf mode = "RC" Then 'right crop n char F
            If (txtRightCropNCharE.Text <> "" Or Val(txtRightCropNCharE.Text) > 0) Then
                For i As Integer = 0 To arrFile2.Count - 1
                    Dim x As String = Path.GetFileNameWithoutExtension(arrFile2(i))
                    arrFile2(i) = x.Substring(0, x.Length - Val(txtRightCropNCharE.Text))
                    lvPreview.Items.Item(i).Text = Trim(arrFile2(i))
                Next
            Else
                For i As Integer = 0 To arrFile.Count - 1
                    Dim x As String = Path.GetFileNameWithoutExtension(arrFile(i))
                    lvPreview.Items.Item(i).Text = Trim(x)
                Next
            End If

        ElseIf mode = "RE" Then 'replace with E
            For i As Integer = 0 To arrFile2.Count - 1
                arrExt2(i) = arrExt2(i).Replace(arrExt2(i).Substring(1), txtReplaceWithE.Text)
                lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
            Next

        ElseIf mode = "R2E" Then 'replace this E
            Dim s1 As String = txtReplaceThisE.Text
            Dim s2 As String = txtWithThisE.Text

            If s1.Length = 0 Then
                s1 = " "
            End If

            If s2.Length = 0 Then
                s2 = " "
            End If

            For i As Integer = 0 To arrExt2.Count - 1
                arrExt2(i) = arrExt2(i).Replace(s1, s2)
                lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
            Next

        ElseIf mode = "IBE" Then 'insert before E
            For i As Integer = 0 To arrExt2.Count - 1
                arrExt2(i) = arrExt2(i).Insert(1, txtInsertBeforeE.Text)
                lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
            Next

        ElseIf mode = "IAE" Then 'insert after E
            For i As Integer = 0 To arrExt2.Count - 1
                arrExt2(i) = arrExt2(i).Insert(arrExt2(i).Length, txtInsertAfterE.Text)
                lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
            Next

        ElseIf mode = "LCE" Then 'left crop n char E
            If (txtLeftCropNCharE.Text <> "" Or Val(txtLeftCropNCharE.Text) > 0) Then
                Dim z As Integer = Val(txtLeftCropNCharE.Text)
                If (z = 1) Then
                    z = z + 1
                End If
                z = z + 1

                For i As Integer = 0 To arrExt2.Count - 1
                    arrExt2(i) = arrExt2(i).Substring(z)
                    lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
                Next
            Else
                For i As Integer = 0 To arrExt.Count - 1
                    lvPreview.Items(i).SubItems(1).Text = Trim(arrExt(i))
                Next
            End If

        ElseIf mode = "RCE" Then 'right crop n char E
            If (txtRightCropNCharE.Text <> "" Or Val(txtRightCropNCharE.Text) > 0) Then
                For i As Integer = 0 To arrExt2.Count - 1
                    arrExt2(i) = arrExt2(i).Substring(0, arrExt2(i).Length - Val(txtRightCropNCharE.Text))
                    lvPreview.Items(i).SubItems(1).Text = Trim(arrExt2(i))
                Next
            Else
                For i As Integer = 0 To arrExt.Count - 1
                    lvPreview.Items(i).SubItems(1).Text = Trim(arrExt(i))
                Next
            End If
        End If

        'untuk autonumber
        Dim naik As Integer = nudIncrementBy.Value
        Dim mulai As Integer = nudStartWithNumber.Value

        If ListViewContainsDuplicates(lvPreview, 0) Then
            For i As Integer = 0 To lvPreview.Items.Count - 1
                If rbAfterFileName.Checked Then
                    lvPreview.Items(i).SubItems(0).Text = Trim(lvPreview.Items(i).SubItems(0).Text) & Trim("-" & Str(mulai))
                ElseIf rbBeforeFileName.Checked Then
                    lvPreview.Items(i).SubItems(0).Text = Trim(Str(mulai) & "-") & Trim(lvPreview.Items(i).SubItems(0).Text)
                End If
                mulai = mulai + naik
            Next
        End If

        'untuk huruf - case
        If cbCaseF.SelectedIndex = 0 Or cbCaseE.SelectedIndex = 0 Then
            For i As Integer = 0 To lvPreview.Items.Count - 1
                lvPreview.Items(i).SubItems(0).Text = lvPreview.Items(i).SubItems(0).Text.ToLower
            Next
        ElseIf cbCaseF.SelectedIndex = 1 Or cbCaseE.SelectedIndex = 1 Then
            For i As Integer = 0 To lvPreview.Items.Count - 1
                lvPreview.Items(i).SubItems(0).Text = lvPreview.Items(i).SubItems(0).Text.ToUpper
            Next
        End If
    End Sub

    Private Sub rbInsertBeforeF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInsertBeforeF.CheckedChanged, rbInsertBeforeF.Click
        If rbInsertBeforeF.Checked Then
            mode = "IB"
            txtInsertBeforeF.ReadOnly = False
        Else
            mode = "X"
            txtInsertBeforeF.ReadOnly = True
        End If
    End Sub

    Private Sub rbInsertAfterF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInsertAFterF.CheckedChanged, rbInsertAFterF.Click
        If rbInsertAfterF.Checked Then
            mode = "IA"
            txtInsertAfterF.ReadOnly = False
        Else
            mode = "X"
            txtInsertAfterF.ReadOnly = True
        End If
    End Sub

    Private Sub rbLeftCropNCharF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbLeftCropNCharF.CheckedChanged, rbLeftCropNCharF.Click
        If rbLeftCropNCharF.Checked Then
            mode = "LC"
            txtLeftCropNCharF.ReadOnly = False
        Else
            mode = "X"
            txtLeftCropNCharF.ReadOnly = True
        End If
    End Sub

    Private Sub rbRightCropNCharF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbRightCropNCharF.CheckedChanged, rbRightCropNCharF.Click
        If rbRightCropNCharF.Checked Then
            mode = "RC"
            txtRightCropNCharF.ReadOnly = False
        Else
            mode = "X"
            txtRightCropNCharF.ReadOnly = True
        End If
    End Sub

    Private Sub rbReplaceWithE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbReplaceWithE.CheckedChanged, rbReplaceWithE.Click
        If rbReplaceWithE.Checked Then
            mode = "RE"
            txtReplaceWithE.ReadOnly = False   ' Note: This might be a bug - should be txtReplaceWithE
        Else
            mode = "X"
            txtReplaceWithE.ReadOnly = True    ' Note: This might be a bug - should be txtReplaceWithE
        End If
    End Sub

    Private Sub rbReplaceThisE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbReplaceThisE.CheckedChanged, rbReplaceThisE.Click
        If rbReplaceThisE.Checked Then
            mode = "R2E"
            txtReplaceThisE.ReadOnly = False
            txtWithThisE.ReadOnly = False
        Else
            mode = "X"
            txtReplaceThisE.ReadOnly = True
            txtWithThisE.ReadOnly = True
        End If
    End Sub

    Private Sub rbInsertBeforeE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInsertBeforeE.CheckedChanged, rbInsertBeforeE.Click
        If rbInsertBeforeE.Checked Then
            mode = "IBE"
            txtInsertBeforeE.ReadOnly = False
        Else
            mode = "X"
            txtInsertBeforeE.ReadOnly = True
        End If
    End Sub

    Private Sub rbInsertAfterE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInsertAfterE.CheckedChanged, rbInsertAfterE.Click
        If rbInsertAfterE.Checked Then
            mode = "IAE"
            txtInsertAfterE.ReadOnly = False
        Else
            mode = "X"
            txtInsertAfterE.ReadOnly = True
        End If
    End Sub

    Private Sub rbLeftCropNCharE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbLeftCropNCharE.CheckedChanged
        If rbLeftCropNCharE.Checked Then
            mode = "LCE"
            txtLeftCropNCharE.ReadOnly = False
        Else
            mode = "X"
            txtLeftCropNCharE.ReadOnly = True
        End If
    End Sub

    Private Sub rbRightCropNCharE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbRightCropNCharE.CheckedChanged, rbRightCropNCharE.Click
        If rbRightCropNCharE.Checked Then
            mode = "RCE"
            txtRightCropNCharE.ReadOnly = False
        Else
            mode = "X"
            txtRightCropNCharE.ReadOnly = True
        End If
    End Sub

    Private Sub btnRename_Click(sender As System.Object, e As System.EventArgs) Handles btnRename.Click
        arrUndo.Clear()
        For i As Integer = 0 To lvOri.Items.Count - 1
            arrUndo.Add(lvOri.Items(i).SubItems(0).Text & lvOri.Items(i).SubItems(1).Text)
            My.Computer.FileSystem.RenameFile(txtPath.Text & "\" & lvOri.Items(i).SubItems(0).Text & lvOri.Items(i).SubItems(1).Text,
                                             lvPreview.Items(i).SubItems(0).Text & lvPreview.Items(i).SubItems(1).Text)
        Next
        btnUndo.Enabled = True
        MuatUlang()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        For i As Integer = 0 To lvOri.Items.Count - 1
            My.Computer.FileSystem.RenameFile(txtPath.Text & "\" & lvOri.Items(i).SubItems(0).Text & lvOri.Items(i).SubItems(1).Text, arrUndo(i))
            arrUndo.Item(i) = lvOri.Items(i).SubItems(0).Text & lvOri.Items(i).SubItems(1).Text
        Next
        MuatUlang()
    End Sub


End Class