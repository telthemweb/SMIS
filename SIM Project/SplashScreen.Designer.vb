<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCurrentYear = New System.Windows.Forms.Label()
        Me.ProgressLoader = New System.Windows.Forms.ProgressBar()
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblWait = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(215, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Powered by Mercy Gwara"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Location = New System.Drawing.Point(197, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 4)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SIM_Project.My.Resources.Resources.checkbox_touch
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(314, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 104)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(274, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Copyright all Reserved"
        '
        'lblCurrentYear
        '
        Me.lblCurrentYear.AutoSize = True
        Me.lblCurrentYear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.lblCurrentYear.Location = New System.Drawing.Point(338, 353)
        Me.lblCurrentYear.Name = "lblCurrentYear"
        Me.lblCurrentYear.Size = New System.Drawing.Size(85, 22)
        Me.lblCurrentYear.TabIndex = 4
        Me.lblCurrentYear.Text = "(c) 2034"
        '
        'ProgressLoader
        '
        Me.ProgressLoader.Location = New System.Drawing.Point(-3, 429)
        Me.ProgressLoader.Name = "ProgressLoader"
        Me.ProgressLoader.Size = New System.Drawing.Size(806, 23)
        Me.ProgressLoader.TabIndex = 5
        Me.ProgressLoader.Visible = False
        '
        'splashTimer
        '
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblWait.Location = New System.Drawing.Point(326, 169)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(125, 23)
        Me.lblWait.TabIndex = 6
        Me.lblWait.Text = "Please wait.."
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 507)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.ProgressLoader)
        Me.Controls.Add(Me.lblCurrentYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCurrentYear As Label
    Friend WithEvents ProgressLoader As ProgressBar
    Friend WithEvents splashTimer As Timer
    Friend WithEvents lblWait As Label
End Class
