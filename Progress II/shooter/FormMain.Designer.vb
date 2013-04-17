<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Shot = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shooter
        '
        Me.Shooter.Image = CType(resources.GetObject("Shooter.Image"), System.Drawing.Image)
        Me.Shooter.Location = New System.Drawing.Point(-12, 556)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(116, 99)
        Me.Shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Shooter.TabIndex = 0
        Me.Shooter.TabStop = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.Color.Red
        Me.Shot.Location = New System.Drawing.Point(41, 498)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(10, 30)
        Me.Shot.TabIndex = 1
        Me.Shot.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 641)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHOOTER"
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Shooter As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents Shot As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
