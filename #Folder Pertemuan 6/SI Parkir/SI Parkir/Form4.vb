Public Class Form4
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AturProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfileToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of UbahProfil)().Any() Then
            Application.OpenForms("UbahProfil").BringToFront()
        Else
            Dim formProfil As New UbahProfil()
            formProfil.Show()
        End If
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim formLangganan As New Langganan()
        formLangganan.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim formLaporan As New Form5()
        formLaporan.Show()
    End Sub
End Class