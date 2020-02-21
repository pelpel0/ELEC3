<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.player2hp = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.win = New System.Windows.Forms.Label()
        Me.Buttondice = New System.Windows.Forms.Button()
        Me.randompic = New System.Windows.Forms.PictureBox()
        Me.Pictureflying = New System.Windows.Forms.PictureBox()
        Me.PictureKick = New System.Windows.Forms.PictureBox()
        Me.PicturePunch = New System.Windows.Forms.PictureBox()
        Me.Picturestart = New System.Windows.Forms.PictureBox()
        Me.PictureVersus = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pictureflying, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureKick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePunch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturestart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureVersus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonA
        '
        Me.ButtonA.Location = New System.Drawing.Point(139, 407)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonA.TabIndex = 2
        Me.ButtonA.Text = "Punch"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ButtonB
        '
        Me.ButtonB.Location = New System.Drawing.Point(139, 436)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(75, 23)
        Me.ButtonB.TabIndex = 6
        Me.ButtonB.Text = "Kick"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'ButtonC
        '
        Me.ButtonC.Location = New System.Drawing.Point(220, 407)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(75, 23)
        Me.ButtonC.TabIndex = 8
        Me.ButtonC.Text = "High Kick"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'player2hp
        '
        Me.player2hp.Location = New System.Drawing.Point(512, 22)
        Me.player2hp.Name = "player2hp"
        Me.player2hp.Size = New System.Drawing.Size(142, 23)
        Me.player2hp.TabIndex = 11
        Me.player2hp.Value = 100
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(117, 22)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(142, 23)
        Me.ProgressBar2.TabIndex = 12
        Me.ProgressBar2.Value = 100
        '
        'win
        '
        Me.win.AutoSize = True
        Me.win.Location = New System.Drawing.Point(284, 25)
        Me.win.MinimumSize = New System.Drawing.Size(200, 20)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(200, 20)
        Me.win.TabIndex = 13
        Me.win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Buttondice
        '
        Me.Buttondice.Location = New System.Drawing.Point(328, 522)
        Me.Buttondice.Name = "Buttondice"
        Me.Buttondice.Size = New System.Drawing.Size(156, 32)
        Me.Buttondice.TabIndex = 14
        Me.Buttondice.Text = "ROLL DICE"
        Me.Buttondice.UseVisualStyleBackColor = True
        '
        'randompic
        '
        Me.randompic.Image = Global.ELEC3._1.My.Resources.Resources._6
        Me.randompic.Location = New System.Drawing.Point(328, 420)
        Me.randompic.Name = "randompic"
        Me.randompic.Size = New System.Drawing.Size(156, 96)
        Me.randompic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.randompic.TabIndex = 15
        Me.randompic.TabStop = False
        '
        'Pictureflying
        '
        Me.Pictureflying.Image = Global.ELEC3._1.My.Resources.Resources.Fyingkick
        Me.Pictureflying.Location = New System.Drawing.Point(117, 67)
        Me.Pictureflying.Name = "Pictureflying"
        Me.Pictureflying.Size = New System.Drawing.Size(537, 334)
        Me.Pictureflying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pictureflying.TabIndex = 7
        Me.Pictureflying.TabStop = False
        '
        'PictureKick
        '
        Me.PictureKick.Image = Global.ELEC3._1.My.Resources.Resources.kick
        Me.PictureKick.Location = New System.Drawing.Point(117, 67)
        Me.PictureKick.Name = "PictureKick"
        Me.PictureKick.Size = New System.Drawing.Size(537, 334)
        Me.PictureKick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureKick.TabIndex = 5
        Me.PictureKick.TabStop = False
        '
        'PicturePunch
        '
        Me.PicturePunch.Image = Global.ELEC3._1.My.Resources.Resources.Punch
        Me.PicturePunch.Location = New System.Drawing.Point(117, 67)
        Me.PicturePunch.Name = "PicturePunch"
        Me.PicturePunch.Size = New System.Drawing.Size(537, 334)
        Me.PicturePunch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePunch.TabIndex = 4
        Me.PicturePunch.TabStop = False
        '
        'Picturestart
        '
        Me.Picturestart.Image = Global.ELEC3._1.My.Resources.Resources.start
        Me.Picturestart.Location = New System.Drawing.Point(139, 67)
        Me.Picturestart.Name = "Picturestart"
        Me.Picturestart.Size = New System.Drawing.Size(515, 334)
        Me.Picturestart.TabIndex = 3
        Me.Picturestart.TabStop = False
        '
        'PictureVersus
        '
        Me.PictureVersus.Image = Global.ELEC3._1.My.Resources.Resources.fight
        Me.PictureVersus.Location = New System.Drawing.Point(139, 67)
        Me.PictureVersus.Name = "PictureVersus"
        Me.PictureVersus.Size = New System.Drawing.Size(515, 334)
        Me.PictureVersus.TabIndex = 0
        Me.PictureVersus.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(328, 560)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(156, 10)
        Me.ProgressBar1.TabIndex = 16
        '
        'Timer5
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 582)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.randompic)
        Me.Controls.Add(Me.Buttondice)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.player2hp)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.Pictureflying)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.PictureKick)
        Me.Controls.Add(Me.PicturePunch)
        Me.Controls.Add(Me.Picturestart)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.PictureVersus)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pictureflying, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureKick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePunch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturestart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureVersus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureVersus As PictureBox
    Friend WithEvents ButtonA As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Picturestart As PictureBox
    Friend WithEvents PicturePunch As PictureBox
    Friend WithEvents PictureKick As PictureBox
    Friend WithEvents ButtonB As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Pictureflying As PictureBox
    Friend WithEvents ButtonC As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents player2hp As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents win As Label
    Friend WithEvents Buttondice As Button
    Friend WithEvents randompic As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer5 As Timer
End Class
