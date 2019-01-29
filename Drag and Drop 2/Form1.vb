Public Class Form1
    Dim counter As Byte
    Dim loss As Byte
    Private Sub lbl6_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl6.MouseMove
        Static x As Integer
        Static y As Integer
        Static move As Boolean = True

        If e.Button = False Then
            x = e.X
            y = e.Y

            If lbl6.Bounds.IntersectsWith(lbl2x3.Bounds) Then
                move = False
                lbl2x3.ForeColor = Color.Green
                lbl6.Location = New Point(180, 196)
                lbl6.ForeColor = Color.Black
                counter += 1
                win()
            End If
        Else
            If move = True Then
                lbl6.Left += (e.X - x)
                lbl6.Top += (e.Y - y)
            End If
        End If
        If lbl6.Bounds.IntersectsWith(lbl2x1.Bounds) Or lbl6.Bounds.IntersectsWith(lbl2x2.Bounds) Or lbl6.Bounds.IntersectsWith(lbl2x4.Bounds) Or lbl6.Bounds.IntersectsWith(lbl2x5.Bounds) Then
            lbl6.ForeColor = Color.Red
            lbl6.Location = New Point(165, 41)
            limit()
        End If
        If counter <= 5 Then
            move = True
        End If
        lblCounter.Text = counter
        lblLoss.Text = loss
    End Sub

    Private Sub lbl10_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl10.MouseMove
        Static x As Integer
        Static y As Integer
        Static move As Boolean = True

        If e.Button = False Then
            x = e.X
            y = e.Y

            If lbl10.Bounds.IntersectsWith(lbl2x5.Bounds) Then
                move = False
                lbl2x5.ForeColor = Color.Green
                lbl10.Location = New Point(200, 196)
                lbl10.ForeColor = Color.Black
                counter += 1
                '   limit()
                win()
            End If
        Else
            If move = True Then
                lbl10.Left += (e.X - x)
                lbl10.Top += (e.Y - y)
            End If
        End If
        If lbl10.Bounds.IntersectsWith(lbl2x1.Bounds) Or lbl10.Bounds.IntersectsWith(lbl2x2.Bounds) Or lbl10.Bounds.IntersectsWith(lbl2x3.Bounds) Or lbl10.Bounds.IntersectsWith(lbl2x4.Bounds) Then
            lbl10.ForeColor = Color.Red
            lbl10.Location = New Point(165, 69)
            limit()
        End If
        If counter <= 5 Then
            move = True
        End If
        lblCounter.Text = counter
        lblLoss.Text = loss
    End Sub

    Private Sub lbl8_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl8.MouseMove
        Static x As Integer
        Static y As Integer
        Static move As Boolean = True

        If e.Button = False Then
            x = e.X
            y = e.Y

            If lbl8.Bounds.IntersectsWith(lbl2x4.Bounds) Then
                move = False
                lbl2x4.ForeColor = Color.Green
                lbl8.Location = New Point(190, 196)
                lbl8.ForeColor = Color.Black
                counter += 1
                '    limit()
                win()
            End If
        Else
            If move = True Then
                lbl8.Left += (e.X - x)
                lbl8.Top += (e.Y - y)
            End If
        End If
        If lbl8.Bounds.IntersectsWith(lbl2x1.Bounds) Or lbl8.Bounds.IntersectsWith(lbl2x2.Bounds) Or lbl8.Bounds.IntersectsWith(lbl2x3.Bounds) Or lbl8.Bounds.IntersectsWith(lbl2x5.Bounds) Then
            lbl8.ForeColor = Color.Red
            lbl8.Location = New Point(165, 97)
            limit()
        End If
        If counter <= 5 Then
            move = True
        End If
        lblCounter.Text = counter
        lblLoss.Text = loss
    End Sub

    Private Sub lbl2_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl2.MouseMove
        Static x As Integer
        Static y As Integer
        Static move As Boolean = True

        If e.Button = False Then
            x = e.X
            y = e.Y

            If lbl2.Bounds.IntersectsWith(lbl2x1.Bounds) Then
                move = False
                lbl2x1.ForeColor = Color.Green
                lbl2.Location = New Point(160, 196)
                lbl2.ForeColor = Color.Black
                counter += 1
                win()
            End If

        Else
            If lbl2.Bounds.IntersectsWith(lbl2x2.Bounds) Or lbl2.Bounds.IntersectsWith(lbl2x3.Bounds) Or lbl2.Bounds.IntersectsWith(lbl2x4.Bounds) Or lbl2.Bounds.IntersectsWith(lbl2x5.Bounds) Then
                lbl2.ForeColor = Color.Red
                lbl2.Location = New Point(165, 127)
                limit()
            End If
            ElseIf
                  If move = True Then
                lbl2.Left += (e.X - x)
                lbl2.Top += (e.Y - y)
            End If
        End If


        If counter <= 5 Then
            move = True
        End If
        lblCounter.Text = counter
        lblLoss.Text = loss
    End Sub

    Private Sub lbl4_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl4.MouseMove
        Static x As Integer
        Static y As Integer
        Static move As Boolean = True

        If e.Button = False Then
            x = e.X
            y = e.Y

            If lbl4.Bounds.IntersectsWith(lbl2x2.Bounds) Then
                move = False
                lbl2x2.ForeColor = Color.Green
                lbl4.Location = New Point(170, 196)
                lbl4.ForeColor = Color.Black
                counter += 1
                win()
            Else
                If lbl4.Bounds.IntersectsWith(lbl2x1.Bounds) Or lbl4.Bounds.IntersectsWith(lbl2x3.Bounds) Or lbl4.Bounds.IntersectsWith(lbl2x4.Bounds) Or lbl4.Bounds.IntersectsWith(lbl2x5.Bounds) Then
                    lbl4.ForeColor = Color.Red
                    lbl4.Location = New Point(165, 153)
                    limit()
                End If
            End If

        ElseIf move = True Then
            lbl4.Left += (e.X - x)
            lbl4.Top += (e.Y - y)

        End If
        If counter <= 5 Then
            move = True
        End If

        lblCounter.Text = counter
        lblLoss.Text = loss
    End Sub
    Private Sub reset()
        Static move As Boolean = True
        lbl2.ForeColor = Color.Black
        lbl4.ForeColor = Color.Black
        lbl6.ForeColor = Color.Black
        lbl8.ForeColor = Color.Black
        lbl10.ForeColor = Color.Black

        lbl2x1.ForeColor = Color.Black
        lbl2x2.ForeColor = Color.Black
        lbl2x3.ForeColor = Color.Black
        lbl2x4.ForeColor = Color.Black
        lbl2x5.ForeColor = Color.Black

        lbl2.Location = New Point(165, 127)
        lbl4.Location = New Point(165, 153)
        lbl6.Location = New Point(165, 41)
        lbl8.Location = New Point(165, 97)
        lbl10.Location = New Point(165, 69)

        counter = 0
        loss = 0
    End Sub
    Private Sub limit()
        loss += 1
        If loss = 3 Then
            MsgBox("You got 3 incorrect, try again.")
            reset()
            Exit Sub
        End If
    End Sub
    Private Sub win()
        If counter = 5 Then
            MsgBox("You Win!")
            reset()
        End If
    End Sub
End Class