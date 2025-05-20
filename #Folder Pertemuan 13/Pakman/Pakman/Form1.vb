Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    'map (peta papan permainan)
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 9 'musuh itu di petak x berapa
    Dim enmy = 7 ' petak y
    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    Dim pacmanDirection As String = "Down" ' Awalnya Pakman menghadap ke bawah
    Dim lives As Integer = 3 ' Jumlah nyawa Pakman
    Dim heart As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\heart2.png") ' Gambar hati untuk nyawa Pakman

    'deklarasi sprite citra yang digunakan
    Dim wall As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\bata.png")
    Dim way As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\rumput.png")
    Dim pacUp As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\pakman4.png")
    Dim pacDown As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\pakman2.png")
    Dim pacLeft As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\pakman3.png")
    Dim pacRight As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\pakman.png")
    Dim enm As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\hantu3.png")
    Dim goal As Image = Image.FromFile("C:\kuliah kuliah\SEMESTER 6\Prog. Desktop\#Folder Pertemuan 13\omah.jpg")

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        ' Gambarkan background (jalan dan tembok)
        For y = 0 To 8 ' 0 to 8 yaitu tinggi map - 1
            For x = 0 To 10 ' 0 to 10 yaitu lebar map - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        ' Gambarkan Pakman sesuai arah
        Select Case pacmanDirection
            Case "Up"
                g.DrawImage(pacUp, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "Down"
                g.DrawImage(pacDown, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "Left"
                g.DrawImage(pacLeft, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "Right"
                g.DrawImage(pacRight, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        ' Gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        ' Gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        ' Gambarkan nyawa Pakman
        For i = 0 To lives - 1
            g.DrawImage(heart, (i * 40) + 10, 10, 30, 30) ' Menampilkan nyawa di kiri atas
        Next

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Me.KeyPreview = True
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    pacmanDirection = "Up" ' Ubah arah Pakman ke atas
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    pacmanDirection = "Down" ' Ubah arah Pakman ke bawah
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    pacmanDirection = "Right" ' Ubah arah Pakman ke kanan
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    pacmanDirection = "Left" ' Ubah arah Pakman ke kiri
                End If
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk musuh
        Dim jarakx, jaraky As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enmx) And (pacy = enmy) Then
            lives -= 1 'kurangi nyawa Pakman
            If lives <= 0 Then
                Timer1.Enabled = False
                MsgBox("Game Over! Pakman dies!")
            Else
                MsgBox("Pakman caught! Remaining lives: " & lives)
            End If
        End If

        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class
