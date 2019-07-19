<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnClose = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Label()
        Me.pNotConn = New System.Windows.Forms.Panel()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.lblNotConn = New System.Windows.Forms.Label()
        Me.pWelcome = New System.Windows.Forms.Panel()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.ProgressBar()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblWel = New System.Windows.Forms.Label()
        Me.picIpod = New System.Windows.Forms.PictureBox()
        Me.pAbout = New System.Windows.Forms.Panel()
        Me.pProcessing = New System.Windows.Forms.Panel()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.lblCompFPath = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblIpodFPath = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumFiles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDrive = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pNoSpace = New System.Windows.Forms.Panel()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pEmptyIpod = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pNotConn.SuspendLayout()
        Me.pWelcome.SuspendLayout()
        CType(Me.picIpod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pProcessing.SuspendLayout()
        Me.pNoSpace.SuspendLayout()
        Me.pEmptyIpod.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Myriad Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(477, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(22, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        '
        'btnMin
        '
        Me.btnMin.AutoSize = True
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Font = New System.Drawing.Font("Myriad Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.Location = New System.Drawing.Point(451, 9)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 24)
        Me.btnMin.TabIndex = 1
        Me.btnMin.Text = "_"
        '
        'pNotConn
        '
        Me.pNotConn.BackColor = System.Drawing.Color.GhostWhite
        Me.pNotConn.Controls.Add(Me.btnRetry)
        Me.pNotConn.Controls.Add(Me.lblNotConn)
        Me.pNotConn.Location = New System.Drawing.Point(50, 483)
        Me.pNotConn.Name = "pNotConn"
        Me.pNotConn.Size = New System.Drawing.Size(431, 320)
        Me.pNotConn.TabIndex = 2
        '
        'btnRetry
        '
        Me.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.Location = New System.Drawing.Point(178, 188)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(75, 33)
        Me.btnRetry.TabIndex = 1
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.UseVisualStyleBackColor = True
        '
        'lblNotConn
        '
        Me.lblNotConn.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotConn.Location = New System.Drawing.Point(3, 62)
        Me.lblNotConn.Name = "lblNotConn"
        Me.lblNotConn.Size = New System.Drawing.Size(425, 86)
        Me.lblNotConn.TabIndex = 0
        Me.lblNotConn.Text = "Could not find an iPod connected to this computer. Please connect one and press t" &
    "he Retry button below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pWelcome
        '
        Me.pWelcome.BackColor = System.Drawing.Color.GhostWhite
        Me.pWelcome.Controls.Add(Me.lblWait)
        Me.pWelcome.Controls.Add(Me.wait)
        Me.pWelcome.Controls.Add(Me.btnStart)
        Me.pWelcome.Controls.Add(Me.lblWel)
        Me.pWelcome.Controls.Add(Me.picIpod)
        Me.pWelcome.Location = New System.Drawing.Point(50, 53)
        Me.pWelcome.Name = "pWelcome"
        Me.pWelcome.Size = New System.Drawing.Size(431, 320)
        Me.pWelcome.TabIndex = 3
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Myriad Pro Light", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.Location = New System.Drawing.Point(50, 257)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(308, 22)
        Me.lblWait.TabIndex = 4
        Me.lblWait.Text = "...reading songs from the iPod and evaluating free space"
        Me.lblWait.Visible = False
        '
        'wait
        '
        Me.wait.Enabled = False
        Me.wait.Location = New System.Drawing.Point(112, 230)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(166, 10)
        Me.wait.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.wait.TabIndex = 3
        Me.wait.Visible = False
        '
        'btnStart
        '
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(168, 230)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 33)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblWel
        '
        Me.lblWel.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWel.Location = New System.Drawing.Point(37, 79)
        Me.lblWel.Name = "lblWel"
        Me.lblWel.Size = New System.Drawing.Size(336, 137)
        Me.lblWel.TabIndex = 1
        Me.lblWel.Text = "This application will retrieve the music files off of an iPod connected to this c" &
    "omputer and place them in an iPod_music folder on the desktop sorted into folder" &
    "s by album." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'picIpod
        '
        Me.picIpod.Image = Global.GetMyMusicOffOfMyIpodAndOntoMyComputer.My.Resources.Resources.ipod_icon
        Me.picIpod.Location = New System.Drawing.Point(188, 24)
        Me.picIpod.Name = "picIpod"
        Me.picIpod.Size = New System.Drawing.Size(35, 43)
        Me.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIpod.TabIndex = 0
        Me.picIpod.TabStop = False
        '
        'pAbout
        '
        Me.pAbout.BackColor = System.Drawing.Color.GhostWhite
        Me.pAbout.Location = New System.Drawing.Point(578, 53)
        Me.pAbout.Name = "pAbout"
        Me.pAbout.Size = New System.Drawing.Size(431, 320)
        Me.pAbout.TabIndex = 4
        '
        'pProcessing
        '
        Me.pProcessing.BackColor = System.Drawing.Color.GhostWhite
        Me.pProcessing.Controls.Add(Me.progress)
        Me.pProcessing.Controls.Add(Me.lblCompFPath)
        Me.pProcessing.Controls.Add(Me.Label7)
        Me.pProcessing.Controls.Add(Me.lblIpodFPath)
        Me.pProcessing.Controls.Add(Me.Label4)
        Me.pProcessing.Controls.Add(Me.lblNumFiles)
        Me.pProcessing.Controls.Add(Me.Label2)
        Me.pProcessing.Controls.Add(Me.lblDrive)
        Me.pProcessing.Controls.Add(Me.Label1)
        Me.pProcessing.Location = New System.Drawing.Point(578, 483)
        Me.pProcessing.Name = "pProcessing"
        Me.pProcessing.Size = New System.Drawing.Size(431, 320)
        Me.pProcessing.TabIndex = 5
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(26, 251)
        Me.progress.Minimum = 1
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(387, 10)
        Me.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progress.TabIndex = 9
        Me.progress.Value = 1
        '
        'lblCompFPath
        '
        Me.lblCompFPath.Location = New System.Drawing.Point(22, 181)
        Me.lblCompFPath.Name = "lblCompFPath"
        Me.lblCompFPath.Size = New System.Drawing.Size(402, 40)
        Me.lblCompFPath.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "File name being written: "
        '
        'lblIpodFPath
        '
        Me.lblIpodFPath.Location = New System.Drawing.Point(26, 115)
        Me.lblIpodFPath.Name = "lblIpodFPath"
        Me.lblIpodFPath.Size = New System.Drawing.Size(402, 40)
        Me.lblIpodFPath.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "File name on iPod:"
        '
        'lblNumFiles
        '
        Me.lblNumFiles.AutoSize = True
        Me.lblNumFiles.Location = New System.Drawing.Point(142, 62)
        Me.lblNumFiles.Name = "lblNumFiles"
        Me.lblNumFiles.Size = New System.Drawing.Size(33, 19)
        Me.lblNumFiles.TabIndex = 3
        Me.lblNumFiles.Text = "000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of files: "
        '
        'lblDrive
        '
        Me.lblDrive.AutoSize = True
        Me.lblDrive.Location = New System.Drawing.Point(242, 27)
        Me.lblDrive.Name = "lblDrive"
        Me.lblDrive.Size = New System.Drawing.Size(0, 19)
        Me.lblDrive.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Found iPod registered as drive:"
        '
        'pNoSpace
        '
        Me.pNoSpace.BackColor = System.Drawing.Color.GhostWhite
        Me.pNoSpace.Controls.Add(Me.btnTryAgain)
        Me.pNoSpace.Controls.Add(Me.Label6)
        Me.pNoSpace.Location = New System.Drawing.Point(1109, 483)
        Me.pNoSpace.Name = "pNoSpace"
        Me.pNoSpace.Size = New System.Drawing.Size(431, 320)
        Me.pNoSpace.TabIndex = 6
        '
        'btnTryAgain
        '
        Me.btnTryAgain.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnTryAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.btnTryAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTryAgain.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryAgain.Location = New System.Drawing.Point(141, 179)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(114, 33)
        Me.btnTryAgain.TabIndex = 2
        Me.btnTryAgain.Text = "Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(425, 86)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "There is not enough space on the main drive of this computer. Please free up some" &
    " space and click the Try Again button below."
        '
        'pEmptyIpod
        '
        Me.pEmptyIpod.BackColor = System.Drawing.Color.GhostWhite
        Me.pEmptyIpod.Controls.Add(Me.Label5)
        Me.pEmptyIpod.Location = New System.Drawing.Point(1109, 53)
        Me.pEmptyIpod.Name = "pEmptyIpod"
        Me.pEmptyIpod.Size = New System.Drawing.Size(431, 320)
        Me.pEmptyIpod.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(425, 132)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "There are no songs on this iPod. Considering you can't get blood from a stone thi" &
    "s application is worthless in this instance. Connect an iPod containing music an" &
    "d restart this application."
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = Global.GetMyMusicOffOfMyIpodAndOntoMyComputer.My.Resources.Resources.ipod_screen
        Me.ClientSize = New System.Drawing.Size(1574, 871)
        Me.Controls.Add(Me.pEmptyIpod)
        Me.Controls.Add(Me.pNoSpace)
        Me.Controls.Add(Me.pProcessing)
        Me.Controls.Add(Me.pAbout)
        Me.Controls.Add(Me.pWelcome)
        Me.Controls.Add(Me.pNotConn)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GetMyMusicOffOfMyIpodAndOntoMyComputer"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pNotConn.ResumeLayout(False)
        Me.pWelcome.ResumeLayout(False)
        CType(Me.picIpod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pProcessing.ResumeLayout(False)
        Me.pProcessing.PerformLayout()
        Me.pNoSpace.ResumeLayout(False)
        Me.pEmptyIpod.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Label
    Friend WithEvents btnMin As Label
    Friend WithEvents pNotConn As Panel
    Friend WithEvents lblNotConn As Label
    Friend WithEvents btnRetry As Button
    Friend WithEvents pWelcome As Panel
    Friend WithEvents pAbout As Panel
    Friend WithEvents picIpod As PictureBox
    Friend WithEvents lblWel As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents pProcessing As Panel
    Friend WithEvents lblDrive As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumFiles As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIpodFPath As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pNoSpace As Panel
    Friend WithEvents btnTryAgain As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents progress As ProgressBar
    Friend WithEvents lblCompFPath As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents wait As ProgressBar
    Friend WithEvents lblWait As Label
    Friend WithEvents pEmptyIpod As Panel
    Friend WithEvents Label5 As Label
End Class
