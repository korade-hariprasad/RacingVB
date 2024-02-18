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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.LeftM = New System.Windows.Forms.Timer(Me.components)
        Me.RightM = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.enemy1M = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2M = New System.Windows.Forms.Timer(Me.components)
        Me.enemy3M = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.score_text = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Speed_text = New System.Windows.Forms.Label()
        Me.goli = New System.Windows.Forms.PictureBox()
        Me.golimover = New System.Windows.Forms.Timer(Me.components)
        Me.golilr = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(60, -28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(140, -28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Location = New System.Drawing.Point(60, 90)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Location = New System.Drawing.Point(140, 90)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox5.Location = New System.Drawing.Point(60, 188)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox6.Location = New System.Drawing.Point(140, 188)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox7.Location = New System.Drawing.Point(60, 291)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox8.Location = New System.Drawing.Point(140, 291)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(12, 68)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(98, 291)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(25, 44)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 2
        Me.Car.TabStop = False
        '
        'LeftM
        '
        Me.LeftM.Interval = 10
        '
        'RightM
        '
        Me.RightM.Interval = 10
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), System.Drawing.Image)
        Me.Enemy1.Location = New System.Drawing.Point(29, 12)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(25, 44)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy1.TabIndex = 3
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), System.Drawing.Image)
        Me.Enemy2.Location = New System.Drawing.Point(98, 9)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(25, 44)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy2.TabIndex = 4
        Me.Enemy2.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), System.Drawing.Image)
        Me.Enemy3.Location = New System.Drawing.Point(166, 9)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(25, 44)
        Me.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy3.TabIndex = 5
        Me.Enemy3.TabStop = False
        '
        'enemy1M
        '
        Me.enemy1M.Enabled = True
        Me.enemy1M.Interval = 10
        '
        'enemy2M
        '
        Me.enemy2M.Enabled = True
        Me.enemy2M.Interval = 10
        '
        'enemy3M
        '
        Me.enemy3M.Enabled = True
        Me.enemy3M.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.Color.White
        Me.End_Text.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(33, 76)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(160, 31)
        Me.End_Text.TabIndex = 6
        Me.End_Text.Text = "Game Over"
        Me.End_Text.Visible = False
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_text.Location = New System.Drawing.Point(9, 9)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(49, 15)
        Me.score_text.TabIndex = 7
        Me.score_text.Text = "Score  0"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(60, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Replay"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Speed_text
        '
        Me.Speed_text.AutoSize = True
        Me.Speed_text.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed_text.Location = New System.Drawing.Point(163, 9)
        Me.Speed_text.Name = "Speed_text"
        Me.Speed_text.Size = New System.Drawing.Size(40, 15)
        Me.Speed_text.TabIndex = 7
        Me.Speed_text.Text = "Speed"
        '
        'goli
        '
        Me.goli.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.goli.Location = New System.Drawing.Point(106, 307)
        Me.goli.Name = "goli"
        Me.goli.Size = New System.Drawing.Size(10, 10)
        Me.goli.TabIndex = 9
        Me.goli.TabStop = False
        '
        'golimover
        '
        Me.golimover.Interval = 10
        '
        'golilr
        '
        Me.golilr.Enabled = True
        Me.golilr.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.goli)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Speed_text)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Car As System.Windows.Forms.PictureBox
    Friend WithEvents LeftM As System.Windows.Forms.Timer
    Friend WithEvents Enemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents enemy1M As System.Windows.Forms.Timer
    Friend WithEvents enemy2M As System.Windows.Forms.Timer
    Friend WithEvents enemy3M As System.Windows.Forms.Timer
    Friend WithEvents End_Text As System.Windows.Forms.Label
    Friend WithEvents score_text As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Speed_text As System.Windows.Forms.Label
    Friend WithEvents RightM As System.Windows.Forms.Timer
    Friend WithEvents goli As System.Windows.Forms.PictureBox
    Friend WithEvents golimover As System.Windows.Forms.Timer
    Friend WithEvents golilr As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
End Class
