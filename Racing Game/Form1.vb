Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top > Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''setting speed START''''''''''''''''''''''''''''''''''''''''''''''
        If score < 20 Then
            speed = 1
        End If
        If score > 20 And score < 40 Then
            speed = 2
        End If
        If score > 40 And score < 60 Then
            speed = 3
        End If
        If score > 60 And score < 80 Then
            speed = 4
        End If
        If score > 80 And score < 100 Then
            speed = 5
        End If
        If score > 100 Then
            speed = 6
        End If
        Speed_text.Text = "speed " & speed
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''setting speed END''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''if car hits other car call gameover START''''''''''''''''''''''''''''''''''''''''''''''
        If (Car.Bounds.IntersectsWith(Enemy1.Bounds)) Then
            gameover()
        End If
        If (Car.Bounds.IntersectsWith(Enemy2.Bounds)) Then
            gameover()
        End If
        If (Car.Bounds.IntersectsWith(Enemy3.Bounds)) Then
            gameover()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''if car hits other car call gameover END''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''gameover function resets the game'''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    Private Sub gameover()
        Button1.Visible = True
        End_Text.Visible = True
        Timer1.Stop()
        LeftM.Stop()
        RightM.Stop()
        enemy1M.Stop()
        enemy2M.Stop()
        enemy3M.Stop()
        golimover.Stop()
    End Sub
    ''' <summary>
    ''' to move car left
    ''' </summary>
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftM.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 3
        End If
    End Sub
    ''' <summary>
    ''' to move car right
    ''' </summary>
    Private Sub RightM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightM.Tick
        If (Car.Location.X < 190) Then
            Car.Left += 3
        End If
    End Sub
    ''' <summary>
    ''' to stop car moving
    ''' </summary>
    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        RightM.Stop()
        LeftM.Stop()
    End Sub
    ''' <summary>
    ''' propertires of enemy cars START
    ''' </summary>
    Private Sub enemy1M_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy1M.Tick
        Enemy1.Top += speed + 1
        If Enemy1.Top >= Me.Height Then
            score += 1
            score_text.Text = "Score " & score
            Enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy1.Height)
            Enemy1.Left = CInt(Math.Ceiling(Rnd() * 70)) + 0
        End If
        If (goli.Bounds.IntersectsWith(Enemy1.Bounds)) Then
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited START'''''''''''''''''''''''''''''''''''
            golimover.Stop()
            goli.Location = Car.Location
            goli.Top = 307
            golilr.Start()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited END'''''''''''''''''''''''''''''''''''
            Enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy1.Height)
            Enemy1.Left = CInt(Math.Ceiling(Rnd() * 70)) + 0
        End If
    End Sub

    Private Sub enemy2M_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy2M.Tick
        Enemy2.Top += speed + 1
        If Enemy2.Top >= Me.Height Then
            score += 1
            score_text.Text = "Score " & score
            Enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy2.Height)
            Enemy2.Left = CInt(Math.Ceiling(Rnd() * 40)) + 100
        End If
        If (goli.Bounds.IntersectsWith(Enemy2.Bounds)) Then
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited START'''''''''''''''''''''''''''''''''''
            golimover.Stop()
            goli.Location = Car.Location
            goli.Top = 307
            golilr.Start()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited END'''''''''''''''''''''''''''''''''''
            Enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy2.Height)
            Enemy2.Left = CInt(Math.Ceiling(Rnd() * 40)) + 100
        End If
    End Sub

    Private Sub enemy3M_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy3M.Tick
        Enemy3.Top += speed + 1
        If Enemy3.Top >= Me.Height Then
            score += 1
            score_text.Text = "Score " & score
            Enemy3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy3.Height)
            Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        End If
        If (goli.Bounds.IntersectsWith(Enemy3.Bounds)) Then
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited START'''''''''''''''''''''''''''''''''''
            golimover.Stop()
            goli.Location = Car.Location
            goli.Top = 307
            golilr.Start()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''this is edited END'''''''''''''''''''''''''''''''''''
            Enemy3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemy3.Height)
            Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        End If
    End Sub
    ''' <summary>
    ''' propertires of enemy cars END
    ''' when we click restart button refresh the page
    ''' </summary>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
    ''' <summary>
    ''' at runtime when we hold a key START
    ''' </summary>
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            golimover.Start()
            golilr.Stop()
        End If
        If e.KeyCode = Keys.Right Then
            RightM.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftM.Start()
        End If
    End Sub
    ''' <summary>
    ''' at runtime when we hold a key END
    ''' to move our goli forward START
    ''' </summary>
    Private Sub golimover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golimover.Tick
        goli.Top -= 2
        If goli.Location.Y < 1 Then
            golimover.Stop()
            goli.Location = Car.Location
            goli.Top = 307
            golilr.Start()
        End If
    End Sub
    ''' <summary>
    ''' to move our goli forward END
    ''' to keep our goli with the car START 
    ''' </summary>
    Private Sub golilr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golilr.Tick
        If Car.Location.X > 0 And Car.Location.X < 190 Then
            goli.Left = Car.Location.X + 7
        End If
    End Sub
    '''''''''''''''''to keep our goli with car END'''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''TO THE CODE WRITER ''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''PLEASE WRITE COMMENTS AT EACH POINT. NOT FOR YOU BUT FOR ME :-)''''''''''''''''''''''''''''''''''''''
End Class                   