<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.leftPaddle = New System.Windows.Forms.PictureBox()
        Me.rightPaddle = New System.Windows.Forms.PictureBox()
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.debugLabel = New System.Windows.Forms.Label()
        Me.scaleTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.leftPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftPaddle
        '
        Me.leftPaddle.BackColor = System.Drawing.Color.White
        Me.leftPaddle.Location = New System.Drawing.Point(40, 140)
        Me.leftPaddle.Name = "leftPaddle"
        Me.leftPaddle.Size = New System.Drawing.Size(40, 150)
        Me.leftPaddle.TabIndex = 0
        Me.leftPaddle.TabStop = False
        '
        'rightPaddle
        '
        Me.rightPaddle.BackColor = System.Drawing.Color.White
        Me.rightPaddle.Location = New System.Drawing.Point(900, 250)
        Me.rightPaddle.Name = "rightPaddle"
        Me.rightPaddle.Size = New System.Drawing.Size(40, 150)
        Me.rightPaddle.TabIndex = 1
        Me.rightPaddle.TabStop = False
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.White
        Me.ball.Location = New System.Drawing.Point(472, 260)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(40, 40)
        Me.ball.TabIndex = 2
        Me.ball.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.Color.White
        Me.ScoreLabel.Location = New System.Drawing.Point(453, 20)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(78, 33)
        Me.ScoreLabel.TabIndex = 3
        Me.ScoreLabel.Text = "0 - 0"
        '
        'debugLabel
        '
        Me.debugLabel.AutoSize = True
        Me.debugLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debugLabel.ForeColor = System.Drawing.Color.White
        Me.debugLabel.Location = New System.Drawing.Point(12, 519)
        Me.debugLabel.Name = "debugLabel"
        Me.debugLabel.Size = New System.Drawing.Size(176, 33)
        Me.debugLabel.TabIndex = 4
        Me.debugLabel.Text = "debugLabel"
        Me.debugLabel.UseWaitCursor = True
        '
        'scaleTimer
        '
        Me.scaleTimer.Enabled = True
        Me.scaleTimer.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.debugLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.rightPaddle)
        Me.Controls.Add(Me.leftPaddle)
        Me.Name = "Form1"
        Me.Text = "Pong!"
        CType(Me.leftPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leftPaddle As PictureBox
    Friend WithEvents rightPaddle As PictureBox
    Friend WithEvents ball As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents debugLabel As Label
    Friend WithEvents scaleTimer As Timer
End Class
