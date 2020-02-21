Public Class Form1
    Dim dice As Integer
    Dim Random As Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicturePunch.Hide()
        PictureVersus.Hide()
        PictureKick.Hide()
        Pictureflying.Hide()

    End Sub
    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        PicturePunch.Visible = True
        Timer1.Interval = 1000
        Timer1.Start()
        If player2hp.Value >= 10 Then
            player2hp.Value = player2hp.Value - 10
        End If
        If player2hp.Value <= 0 Then
            win.Text = "PLAYER 1 WIN!"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PicturePunch.Visible = False
        Timer1.Interval = 1000
        Timer1.Stop()
    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        PictureKick.Visible = True
        Timer2.Interval = 1000
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureKick.Visible = False
        Timer2.Interval = 1000
        Timer2.Stop()
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        Pictureflying.Visible = True
        Timer3.Interval = 1000
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Pictureflying.Visible = False
        Timer3.Interval = 1000
        Timer3.Stop()
    End Sub

    Private Sub Buttondice_Click(sender As Object, e As EventArgs) Handles Buttondice.Click
        Timer5.Start()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Random = New Random
        ProgressBar1.Increment(5)

        If ProgressBar1.Value = 100 Then

            Timer5.Stop()

            If dice = 1 Then
                player2hp.Value = player2hp.Value - 5
                MsgBox("-5!!")

            End If
            If dice = 2 Then
                player2hp.Value = player2hp.Value - 10
                MsgBox("-10!!")
            End If
            If dice = 3 Then
                player2hp.Value = player2hp.Value - 15
                MsgBox("-15!!")
            End If
            If dice = 4 Then
                player2hp.Value = player2hp.Value - 20
                MsgBox("-20!!")
            End If
            If dice = 5 Then
                player2hp.Value = player2hp.Value - 25
                MsgBox("-25!!")
            End If
            If dice = 6 Then
                player2hp.Value = player2hp.Value - 30
                MsgBox("-30!!")
            End If
            ProgressBar1.Value = 0
        Else

            dice = Random.Next(1, 6)
            Select Case (dice)
                Case 1 : randompic.Image = My.Resources._1

                Case 2 : randompic.Image = My.Resources._2
                Case 3 : randompic.Image = My.Resources._3
                Case 4 : randompic.Image = My.Resources._4
                Case 5 : randompic.Image = My.Resources._5
                Case 6 : randompic.Image = My.Resources._6
            End Select
        End If
    End Sub
End Class
