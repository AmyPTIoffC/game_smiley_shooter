Public Class FormMain
    Dim kanan As Boolean
    Dim kiri As Boolean
    Dim kec_segitiga As Integer
    Dim kec_senjata As Integer
    Dim kec_senyum As Integer
    Dim drop_senyum As Integer
    Dim senyum_kanan As Boolean

    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick
        MoveShooter()
        FireShot()
        MoveSenyum()
        CheckGameOver()
        'CheckHit()


    End Sub

    Private Sub FormMain_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            kanan = True
            kiri = False
        End If
        If e.KeyValue = Keys.Left Then
            kiri = True
            kanan = False
        End If

        If e.KeyValue = Keys.Space And Shot.Visible = False Then
            Shot.Top = Shooter.Top
            Shot.Left = CInt(Shooter.Left + (Shooter.Width / 2) - (Shot.Width / 2))
            Shot.Visible = True

        End If
    End Sub
    Private Sub MoveShooter()
        If kanan = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then

            Shooter.Left += kec_segitiga

        End If
        If kiri = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= kec_segitiga

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
    End Sub

    Private Sub LoadSettings()
        kec_senjata = 6
        kec_segitiga = 3
        Shot.Visible = False
        senyum_kanan = True
        kec_senyum = 5
        drop_senyum = 50


    End Sub

    Private Sub FireShot()
        If Shot.Visible = True Then
            Shot.Top -= kec_senjata
        End If
        If Shot.Top + Shot.Height < Me.ClientRectangle.Top Then
            Shot.Visible = False

        End If
    End Sub
    Private Sub MoveSenyum()
        If senyum_kanan = True Then
            PictureBox1.Left += kec_senyum
        Else
            PictureBox1.Left -= kec_senyum
        End If
        If PictureBox1.Left + PictureBox1.Width > Me.ClientRectangle.Width Then
            senyum_kanan = False
            PictureBox1.Top += drop_senyum
        End If
        If PictureBox1.Left < Me.ClientRectangle.Left Then
            senyum_kanan = True
            PictureBox1.Top += drop_senyum
        End If
    End Sub
    Private Sub CheckGameOver()
        If PictureBox1.Top + PictureBox1.Height >= Shooter.Top And PictureBox1.Visible Then
            TimerMain.Enabled = False
            MsgBox("Game Over")
        End If
    End Sub

End Class
