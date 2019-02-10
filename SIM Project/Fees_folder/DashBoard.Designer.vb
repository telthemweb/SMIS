<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRecept = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBoxAmt = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblChange = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.Label()
        Me.GroupBoxInfo = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfeeperTerm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.avatar = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCashName = New System.Windows.Forms.Label()
        Me.lblAmntPaid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxAmt.SuspendLayout()
        Me.GroupBoxInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 58)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administrative"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(187, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 2)
        Me.Panel3.TabIndex = 102
        '
        'txtRecept
        '
        Me.txtRecept.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtRecept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecept.Enabled = False
        Me.txtRecept.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecept.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtRecept.Location = New System.Drawing.Point(229, 35)
        Me.txtRecept.Name = "txtRecept"
        Me.txtRecept.Size = New System.Drawing.Size(174, 25)
        Me.txtRecept.TabIndex = 99
        Me.txtRecept.Text = "Receipt Number"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(47, 436)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 45)
        Me.Button4.TabIndex = 111
        Me.Button4.Text = "Make Payment"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(749, 392)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 184)
        Me.Panel8.TabIndex = 112
        '
        'GroupBoxAmt
        '
        Me.GroupBoxAmt.Controls.Add(Me.TextBox1)
        Me.GroupBoxAmt.Controls.Add(Me.TextBox2)
        Me.GroupBoxAmt.Controls.Add(Me.TextBox3)
        Me.GroupBoxAmt.Controls.Add(Me.TextBox4)
        Me.GroupBoxAmt.Controls.Add(Me.Panel9)
        Me.GroupBoxAmt.Controls.Add(Me.lblChange)
        Me.GroupBoxAmt.Controls.Add(Me.Panel7)
        Me.GroupBoxAmt.Controls.Add(Me.txtBalance)
        Me.GroupBoxAmt.Controls.Add(Me.Panel6)
        Me.GroupBoxAmt.Controls.Add(Me.txtAmt)
        Me.GroupBoxAmt.Controls.Add(Me.txtRecept)
        Me.GroupBoxAmt.Controls.Add(Me.Panel3)
        Me.GroupBoxAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxAmt.Location = New System.Drawing.Point(311, 381)
        Me.GroupBoxAmt.Name = "GroupBoxAmt"
        Me.GroupBoxAmt.Size = New System.Drawing.Size(418, 215)
        Me.GroupBoxAmt.TabIndex = 115
        Me.GroupBoxAmt.TabStop = False
        Me.GroupBoxAmt.Text = "Amount To be paid"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(33, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 25)
        Me.TextBox1.TabIndex = 111
        Me.TextBox1.Text = "change"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.Location = New System.Drawing.Point(31, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 25)
        Me.TextBox2.TabIndex = 110
        Me.TextBox2.Text = "Balance"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox3.Location = New System.Drawing.Point(32, 82)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(165, 25)
        Me.TextBox3.TabIndex = 109
        Me.TextBox3.Text = "Fees Paid"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox4.Location = New System.Drawing.Point(32, 37)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 25)
        Me.TextBox4.TabIndex = 108
        Me.TextBox4.Text = "Receipt Number"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Enabled = False
        Me.Panel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(186, 202)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(217, 2)
        Me.Panel9.TabIndex = 107
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblChange.Enabled = False
        Me.lblChange.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblChange.Location = New System.Drawing.Point(230, 168)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(165, 25)
        Me.lblChange.TabIndex = 106
        Me.lblChange.Text = "change"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Enabled = False
        Me.Panel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(184, 157)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(217, 2)
        Me.Panel7.TabIndex = 105
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBalance.Enabled = False
        Me.txtBalance.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtBalance.Location = New System.Drawing.Point(228, 123)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(165, 25)
        Me.txtBalance.TabIndex = 104
        Me.txtBalance.Text = "Balance"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(185, 114)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(217, 2)
        Me.Panel6.TabIndex = 103
        '
        'txtAmt
        '
        Me.txtAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtAmt.Location = New System.Drawing.Point(229, 80)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(165, 25)
        Me.txtAmt.TabIndex = 102
        Me.txtAmt.Text = "Fees Paid"
        '
        'cboStatus
        '
        Me.cboStatus.AutoSize = True
        Me.cboStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.Color.White
        Me.cboStatus.Location = New System.Drawing.Point(241, 569)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(61, 18)
        Me.cboStatus.TabIndex = 1
        Me.cboStatus.Text = "Status"
        '
        'GroupBoxInfo
        '
        Me.GroupBoxInfo.Controls.Add(Me.Label8)
        Me.GroupBoxInfo.Controls.Add(Me.txtfeeperTerm)
        Me.GroupBoxInfo.Controls.Add(Me.Label6)
        Me.GroupBoxInfo.Controls.Add(Me.avatar)
        Me.GroupBoxInfo.Controls.Add(Me.Panel10)
        Me.GroupBoxInfo.Controls.Add(Me.txtSearch)
        Me.GroupBoxInfo.Controls.Add(Me.cboTerm)
        Me.GroupBoxInfo.Controls.Add(Me.cboClass)
        Me.GroupBoxInfo.Controls.Add(Me.Panel4)
        Me.GroupBoxInfo.Controls.Add(Me.Panel2)
        Me.GroupBoxInfo.Controls.Add(Me.Panel5)
        Me.GroupBoxInfo.Controls.Add(Me.txtSurname)
        Me.GroupBoxInfo.Controls.Add(Me.txtName)
        Me.GroupBoxInfo.Controls.Add(Me.txtReg)
        Me.GroupBoxInfo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxInfo.Location = New System.Drawing.Point(8, 64)
        Me.GroupBoxInfo.Name = "GroupBoxInfo"
        Me.GroupBoxInfo.Size = New System.Drawing.Size(294, 361)
        Me.GroupBoxInfo.TabIndex = 116
        Me.GroupBoxInfo.TabStop = False
        Me.GroupBoxInfo.Text = "Student Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(170, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 24)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "$"
        Me.Label8.Visible = False
        '
        'txtfeeperTerm
        '
        Me.txtfeeperTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtfeeperTerm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfeeperTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeeperTerm.ForeColor = System.Drawing.Color.Red
        Me.txtfeeperTerm.Location = New System.Drawing.Point(150, 79)
        Me.txtfeeperTerm.Name = "txtfeeperTerm"
        Me.txtfeeperTerm.Size = New System.Drawing.Size(131, 24)
        Me.txtfeeperTerm.TabIndex = 126
        Me.txtfeeperTerm.Text = "120"
        Me.txtfeeperTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtfeeperTerm.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(19, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Fees/Term"
        Me.Label6.Visible = False
        '
        'avatar
        '
        Me.avatar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.avatar.BackgroundImage = Global.SIM_Project.My.Resources.Resources._1__6_
        Me.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.avatar.FlatAppearance.BorderSize = 0
        Me.avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.avatar.Location = New System.Drawing.Point(234, 30)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(45, 25)
        Me.avatar.TabIndex = 125
        Me.avatar.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(12, 61)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(257, 2)
        Me.Panel10.TabIndex = 124
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtSearch.Location = New System.Drawing.Point(13, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 26)
        Me.txtSearch.TabIndex = 123
        Me.txtSearch.Text = "Search here...."
        '
        'cboTerm
        '
        Me.cboTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboTerm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Items.AddRange(New Object() {"First Term", "Second Term", "Third Term"})
        Me.cboTerm.Location = New System.Drawing.Point(9, 296)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(274, 33)
        Me.cboTerm.TabIndex = 122
        Me.cboTerm.Text = "Choose Term"
        '
        'cboClass
        '
        Me.cboClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClass.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A", "4 B", "4 C", "5 COMMERCIALS", "5 ARTS", "5 SCIENCES", "6 ARTS", "6 COMMERCIALS", "6 SCIENCES"})
        Me.cboClass.Location = New System.Drawing.Point(7, 255)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(274, 33)
        Me.cboClass.TabIndex = 121
        Me.cboClass.Text = "Choose class"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(6, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 2)
        Me.Panel4.TabIndex = 119
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(5, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 2)
        Me.Panel2.TabIndex = 116
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(6, 206)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 2)
        Me.Panel5.TabIndex = 120
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSurname.Enabled = False
        Me.txtSurname.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtSurname.Location = New System.Drawing.Point(7, 213)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(275, 25)
        Me.txtSurname.TabIndex = 118
        Me.txtSurname.Text = "Surname"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtName.Location = New System.Drawing.Point(5, 173)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(279, 25)
        Me.txtName.TabIndex = 117
        Me.txtName.Text = "Name"
        '
        'txtReg
        '
        Me.txtReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReg.Enabled = False
        Me.txtReg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtReg.Location = New System.Drawing.Point(6, 128)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(275, 25)
        Me.txtReg.TabIndex = 115
        Me.txtReg.Text = "Student ID"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(47, 487)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 45)
        Me.Button5.TabIndex = 117
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(757, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 45)
        Me.Button2.TabIndex = 98
        Me.Button2.Text = "        Examination Fees"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(757, 531)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(272, 45)
        Me.Button3.TabIndex = 97
        Me.Button3.Text = "        Others"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(757, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 45)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "        View Payment List"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUpdat
        '
        Me.btnUpdat.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdat.FlatAppearance.BorderSize = 0
        Me.btnUpdat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnUpdat.Image = CType(resources.GetObject("btnUpdat.Image"), System.Drawing.Image)
        Me.btnUpdat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdat.Location = New System.Drawing.Point(757, 429)
        Me.btnUpdat.Name = "btnUpdat"
        Me.btnUpdat.Size = New System.Drawing.Size(272, 45)
        Me.btnUpdat.TabIndex = 95
        Me.btnUpdat.Text = "        View Arrears"
        Me.btnUpdat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIM_Project.My.Resources.Resources.dashboard1
        Me.PictureBox1.Location = New System.Drawing.Point(311, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(726, 309)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtCashName
        '
        Me.txtCashName.AutoSize = True
        Me.txtCashName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashName.ForeColor = System.Drawing.Color.White
        Me.txtCashName.Location = New System.Drawing.Point(28, 569)
        Me.txtCashName.Name = "txtCashName"
        Me.txtCashName.Size = New System.Drawing.Size(44, 18)
        Me.txtCashName.TabIndex = 118
        Me.txtCashName.Text = "Role"
        '
        'lblAmntPaid
        '
        Me.lblAmntPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblAmntPaid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblAmntPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmntPaid.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAmntPaid.Location = New System.Drawing.Point(80, 541)
        Me.lblAmntPaid.Name = "lblAmntPaid"
        Me.lblAmntPaid.Size = New System.Drawing.Size(136, 24)
        Me.lblAmntPaid.TabIndex = 119
        Me.lblAmntPaid.Text = "0"
        Me.lblAmntPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lblAmntPaid.Visible = False
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 608)
        Me.Controls.Add(Me.lblAmntPaid)
        Me.Controls.Add(Me.txtCashName)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.GroupBoxInfo)
        Me.Controls.Add(Me.GroupBoxAmt)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxAmt.ResumeLayout(False)
        Me.GroupBoxAmt.PerformLayout()
        Me.GroupBoxInfo.ResumeLayout(False)
        Me.GroupBoxInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtRecept As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBoxAmt As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblChange As TextBox
    Friend WithEvents cboStatus As Label
    Friend WithEvents GroupBoxInfo As GroupBox
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtReg As TextBox
    Friend WithEvents Button5 As Button
    Private WithEvents avatar As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtCashName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfeeperTerm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAmntPaid As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
