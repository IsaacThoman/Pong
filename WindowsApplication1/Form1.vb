
Public Class Form1


    Dim LeftScore As Integer
    Dim RightScore As Integer

    Dim LeftDown As Boolean
    Dim RightDown As Boolean
    Dim UpDown As Boolean
    Dim DownDown As Boolean
    Dim keyWDown As Boolean
    Dim keySDown As Boolean


    Public leftTouching As Boolean
    Public rightTouching As Boolean



    Function movePlayer()
        If (UpDown = True) Then
            rightPaddle.Location = New Point(rightPaddle.Location.X, rightPaddle.Location.Y - 5)

        End If
        If (DownDown = True) Then
            rightPaddle.Location = New Point(rightPaddle.Location.X, rightPaddle.Location.Y + 5)

        End If


        If (keyWDown = True) Then
            leftPaddle.Location = New Point(leftPaddle.Location.X, leftPaddle.Location.Y - 5)

        End If
        If (keySDown = True) Then
            leftPaddle.Location = New Point(leftPaddle.Location.X, leftPaddle.Location.Y + 5)

        End If

    End Function


    Function LeftColisionTest()
        leftTouching = False
        If (ball.Location.X + ball.Width > leftPaddle.Location.X And ball.Location.X < leftPaddle.Location.X + leftPaddle.Width) Then
            'Width matches
            If (ball.Location.Y + ball.Height > leftPaddle.Location.Y And ball.Location.Y < leftPaddle.Location.Y + leftPaddle.Height) Then
                'height matches
                leftTouching = True

            End If
        End If

    End Function



    Function RightColisionTest()
        rightTouching = False
        If (ball.Location.X + ball.Width > rightPaddle.Location.X And ball.Location.X < rightPaddle.Location.X + rightPaddle.Width) Then
            'Width matches
            If (ball.Location.Y + ball.Height > rightPaddle.Location.Y And ball.Location.Y < rightPaddle.Location.Y + rightPaddle.Height) Then
                'height matches
                rightTouching = True

            End If
        End If

    End Function

    Public velocityX As Integer
    Public velocityY As Integer
    Public leftVelocityY As Integer
    Public leftVelocityX As Integer



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LeftColisionTest()
        RightColisionTest()


        If (rightTouching = True) Then
            velocityY = Int((4 - 2 + 1) * Rnd() + 2)
            velocityX = -10
        End If

        If (leftTouching = True) Then
            'velocityY = Int((6 - 2 + 1) * Rnd() + 2)
            If (ball.Location.Y < Me.Height / 2) Then
                velocityY = 5
            End If
            If (ball.Location.Y > Me.Height / 2) Then
                velocityY = -5
            End If
            velocityX = 10
        End If '  ------------------------ This was the old bot

        ' '       If (ball.Location.Y < leftPaddle.Location.Y) Then
        '        leftVelocityY = -3
        '
        '        End If
        '        If (ball.Location.Y > leftPaddle.Location.Y) Then
        '        leftVelocityY = 3

        '        End If





        '                ---------------------------------------------------------------put scoring here
        If (ball.Location.X > Me.Width - ball.Width) Then
            velocityX = -5
            LeftScore = LeftScore + 1
            ScoreLabel.Text = (LeftScore & " - " & RightScore)
            ball.Location = New Point(472, 260)

        End If
        If (ball.Location.X < 0) Then
            velocityX = 5
            RightScore = RightScore + 1
            ball.Location = New Point(472, 260)
            ScoreLabel.Text = (LeftScore & " - " & RightScore)
        End If

        If (ball.Location.Y > Me.Height - (ball.Height * 2)) Then

            velocityY = -5
        End If

        If (ball.Location.Y < 0) Then

            velocityY = 5
        End If

        movePlayer()

        leftPaddle.Location = New Point(leftPaddle.Location.X + leftVelocityX, leftPaddle.Location.Y + leftVelocityY)


        ball.Location = New Point(ball.Location.X + velocityX, ball.Location.Y + velocityY)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles ball.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        velocityX = 10
        debugLabel.Visible = False '   ---------------------------------------------hides the key value thing

    End Sub



    'Next 65 lines or so detect key presses
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Or e.Shift Or e.Alt Then

        End If


        '     LeftDown = False
        '     RightDown = False
        '     UpDown = False
        '     DownDown = False

        If e.KeyValue = 37 Then
            LeftDown = True
            RightDown = False
            UpDown = False
            DownDown = False
        End If
        If e.KeyValue = 38 Then
            LeftDown = False
            RightDown = False
            UpDown = True
            DownDown = False
        End If
        If e.KeyValue = 39 Then
            LeftDown = False
            RightDown = True
            UpDown = False
            DownDown = False
        End If
        If e.KeyValue = 40 Then
            LeftDown = False
            RightDown = False
            UpDown = False
            DownDown = True
        End If

        If e.KeyValue = 87 Then
            keyWDown = True
            keySDown = False
        End If

        If e.KeyValue = 83 Then
            keyWDown = False
            keySDown = True
        End If

        '    debugLabel.Text = e.KeyValue
    End Sub

    Private Sub Form1_KeyuP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.Control Or e.Shift Or e.Alt Then

        End If




        If e.KeyValue = 37 Then
            LeftDown = False
        End If
        If e.KeyValue = 38 Then

            UpDown = False

        End If
        If e.KeyValue = 39 Then

            RightDown = False

        End If
        If e.KeyValue = 40 Then
            DownDown = False
        End If

        If e.KeyValue = 87 Then
            keyWDown = False

        End If

        If e.KeyValue = 83 Then

            keySDown = False
        End If

    End Sub

    Private Sub scaleTimer_Tick(sender As Object, e As EventArgs) Handles scaleTimer.Tick
        rightPaddle.Location = New Point((Me.Width - 50 - rightPaddle.Width), rightPaddle.Location.Y)
    End Sub
End Class
