Public Class FormMain
    Dim kanan As Boolean
    Dim kiri As Boolean
    Dim kec_penembak As Integer
    Dim kec_peluru As Integer
    Dim kecSenyum As Integer
    Dim dropSenyum As Integer

    Const JumlahSenyum As Integer = 9 ' menyatakan jumlah sasaran (senyum) dalam satu baris
    Dim senyumKanan(JumlahSenyum) As Boolean
    Dim senyum(JumlahSenyum) As PictureBox
    Dim x As Integer
    Dim Shotdown As Integer

    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick
        MoveShooter()
        FireShot()
        MoveSenyum()
        CheckGameOver()
        CheckHit()
    End Sub

    Private Sub FormMain_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then ' digunakan untuk mengaktifkan key right
            kanan = True ' menyatakan bahwa key kanan aktif
            kiri = False ' menyatakan bahwa key kiri tidak aktif
        End If

        If e.KeyValue = Keys.Left Then ' digunakan untuk mengaktifkan key left
            kiri = True ' menyatakan bahwa key kiri aktif
            kanan = False ' menyatakan bahwa key kanan tidak aktif
        End If

        If e.KeyValue = Keys.Space And Shot.Visible = False Then ' memberikan nilai untuk penggunaan key space
            Shot.Top = Shooter.Top
            Shot.Left = CInt(Shooter.Left + (Shooter.Width / 2) - (Shot.Width / 2))
            Shot.Visible = True
        End If
    End Sub

    Private Sub MoveShooter()
        If kanan = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left += kec_penembak
        End If
        If kiri = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= kec_penembak

        End If
    End Sub

    Private Sub FormMain_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            kanan = False

        End If
        If e.KeyValue = Keys.Left Then
            kiri = False
        End If

    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSettings()
        LoadSenyum()

    End Sub

    Private Sub LoadSettings()
        kec_peluru = 15
        kec_penembak = 3
        Shot.Visible = False
        For Me.x = 1 To JumlahSenyum
            senyumKanan(x) = True
        Next

        kecSenyum = 3
        dropSenyum = 50
    End Sub

    Private Sub FireShot()
        If Shot.Visible = True Then
            Shot.Top -= kec_peluru
        End If

        If Shot.Top + Shot.Height < Me.ClientRectangle.Top Then
            Shot.Visible = False

        End If
    End Sub
    Private Sub MoveSenyum()
        For Me.x = 1 To JumlahSenyum
            If senyumKanan(x) = True Then
                senyum(x).Left += kecSenyum
            Else
                senyum(x).Left -= kecSenyum
            End If

            If senyum(x).Left + senyum(x).Width > Me.ClientRectangle.Width And senyumKanan(x) = True Then

                senyumKanan(x) = False

                senyum(x).Top += dropSenyum
            End If

            If senyum(x).Left < Me.ClientRectangle.Left And senyumKanan(x) = False Then
                senyumKanan(x) = True
                senyum(x).Top += dropSenyum
            End If
        Next

    End Sub

    Private Sub CheckGameOver()
        For Me.x = 1 To JumlahSenyum
            If senyum(x).Top + senyum(x).Height >= Shooter.Top And senyum(x).Visible = True Then
                TimerMain.Enabled = False
                Me.x = JumlahSenyum
                MsgBox("Game Over ")
            End If

        Next
        If Shotdown = JumlahSenyum Then
            TimerMain.Enabled = False
            MsgBox("Tersimpan")
        End If


    End Sub

    Private Sub CheckHit()
        For Me.x = 1 To JumlahSenyum
            If (Shot.Top + Shot.Height >= senyum(x).Top) And (Shot.Top <= senyum(x).Top + senyum(x).Height) And (Shot.Left + Shot.Width >= senyum(x).Left) And (Shot.Left <= senyum(x).Left + senyum(x).Width) And Shot.Visible = True And senyum(x).Visible = True Then

                senyum(x).Visible = False
                Shot.Visible = False
                Shotdown += 1
            End If
        Next
    End Sub
    Private Sub LoadSenyum()
        senyum(1) = PictureBox1
        senyum(2) = PictureBox2
        senyum(3) = PictureBox3
        senyum(4) = PictureBox4
        senyum(5) = PictureBox5
        senyum(6) = PictureBox6
        senyum(7) = PictureBox7
        senyum(8) = PictureBox8
        senyum(9) = PictureBox9

        For Me.x = 1 To JumlahSenyum
            senyum(x).Left = (-50 * x) - (x * 5)

        Next
    End Sub

End Class
