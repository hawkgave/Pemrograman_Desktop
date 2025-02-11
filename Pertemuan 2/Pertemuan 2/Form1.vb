Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDua.Click

    End Sub
    Dim myrandom As Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Randomize()
        myrandom = New Random
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII Besar
        lblSatu.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII Besar
        lblDua.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII Besar
        lblTiga.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        If lblSatu.Text = lblDua.Text And lblDua.Text = lblTiga.Text Then
            lblStatus.Text = "3 WIN!"
        ElseIf lblSatu.Text = lblDua.Text Or lblSatu.Text = lblTiga.Text Or lblDua.Text = lblTiga.Text Then
            lblStatus.Text = "2 WIN!"
        Else
            lblStatus.Text = "TRY AGAIN"
        End If
        Timer4.Enabled = False
    End Sub
End Class