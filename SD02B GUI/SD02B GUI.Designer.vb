<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGUI))
        Me.btnAccelerate = New System.Windows.Forms.Button
        Me.plCOMPORT = New System.Windows.Forms.Panel
        Me.btnSendBaud = New System.Windows.Forms.Button
        Me.cbbBaud = New System.Windows.Forms.ComboBox
        Me.lblProcess = New System.Windows.Forms.Label
        Me.lblCONNECT = New System.Windows.Forms.Label
        Me.lblComPort = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.cbbComPort = New System.Windows.Forms.ComboBox
        Me.btnAcquire = New System.Windows.Forms.Button
        Me.btnOn = New System.Windows.Forms.Button
        Me.btnCW = New System.Windows.Forms.Button
        Me.btnGo = New System.Windows.Forms.Button
        Me.txtEncoder = New System.Windows.Forms.TextBox
        Me.btnTrack = New System.Windows.Forms.Button
        Me.nudTrack = New System.Windows.Forms.NumericUpDown
        Me.btnReset = New System.Windows.Forms.Button
        Me.hsbSpeed = New System.Windows.Forms.HScrollBar
        Me.txtSpeed = New System.Windows.Forms.TextBox
        Me.btnStatus = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblInitial = New System.Windows.Forms.Label
        Me.nudAccRate = New System.Windows.Forms.NumericUpDown
        Me.nudFinalS = New System.Windows.Forms.NumericUpDown
        Me.nudInitialS = New System.Windows.Forms.NumericUpDown
        Me.btnMstep = New System.Windows.Forms.Button
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.btnOff = New System.Windows.Forms.Button
        Me.btnBrake = New System.Windows.Forms.Button
        Me.btnCCW = New System.Windows.Forms.Button
        Me.gbCtrlPanel = New System.Windows.Forms.GroupBox
        Me.gbSpeed = New System.Windows.Forms.GroupBox
        Me.gbEncoder = New System.Windows.Forms.GroupBox
        Me.gbTrack = New System.Windows.Forms.GroupBox
        Me.gbAccelerate = New System.Windows.Forms.GroupBox
        Me.gbStatus = New System.Windows.Forms.GroupBox
        Me.gbMicroStep = New System.Windows.Forms.GroupBox
        Me.cbbMicroStep = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.plCOMPORT.SuspendLayout()
        CType(Me.nudTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAccRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFinalS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInitialS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCtrlPanel.SuspendLayout()
        Me.gbSpeed.SuspendLayout()
        Me.gbEncoder.SuspendLayout()
        Me.gbTrack.SuspendLayout()
        Me.gbAccelerate.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        Me.gbMicroStep.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccelerate
        '
        Me.btnAccelerate.Location = New System.Drawing.Point(13, 105)
        Me.btnAccelerate.Name = "btnAccelerate"
        Me.btnAccelerate.Size = New System.Drawing.Size(124, 25)
        Me.btnAccelerate.TabIndex = 0
        Me.btnAccelerate.Text = "Accelerate"
        Me.btnAccelerate.UseVisualStyleBackColor = True
        '
        'plCOMPORT
        '
        Me.plCOMPORT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.plCOMPORT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.plCOMPORT.Controls.Add(Me.btnSendBaud)
        Me.plCOMPORT.Controls.Add(Me.cbbBaud)
        Me.plCOMPORT.Controls.Add(Me.lblProcess)
        Me.plCOMPORT.Controls.Add(Me.lblCONNECT)
        Me.plCOMPORT.Controls.Add(Me.lblComPort)
        Me.plCOMPORT.Controls.Add(Me.btnConnect)
        Me.plCOMPORT.Controls.Add(Me.cbbComPort)
        Me.plCOMPORT.Location = New System.Drawing.Point(12, 12)
        Me.plCOMPORT.Name = "plCOMPORT"
        Me.plCOMPORT.Size = New System.Drawing.Size(150, 170)
        Me.plCOMPORT.TabIndex = 337
        '
        'btnSendBaud
        '
        Me.btnSendBaud.Location = New System.Drawing.Point(12, 135)
        Me.btnSendBaud.Name = "btnSendBaud"
        Me.btnSendBaud.Size = New System.Drawing.Size(121, 22)
        Me.btnSendBaud.TabIndex = 98
        Me.btnSendBaud.Text = "Set New Baudrate"
        Me.btnSendBaud.UseVisualStyleBackColor = True
        '
        'cbbBaud
        '
        Me.cbbBaud.AccessibleName = ""
        Me.cbbBaud.FormattingEnabled = True
        Me.cbbBaud.Location = New System.Drawing.Point(12, 51)
        Me.cbbBaud.Name = "cbbBaud"
        Me.cbbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cbbBaud.TabIndex = 97
        Me.cbbBaud.Tag = ""
        Me.cbbBaud.Text = "9600"
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(17, 521)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(0, 13)
        Me.lblProcess.TabIndex = 96
        '
        'lblCONNECT
        '
        Me.lblCONNECT.AutoSize = True
        Me.lblCONNECT.ForeColor = System.Drawing.Color.Red
        Me.lblCONNECT.Location = New System.Drawing.Point(19, 103)
        Me.lblCONNECT.Name = "lblCONNECT"
        Me.lblCONNECT.Size = New System.Drawing.Size(105, 13)
        Me.lblCONNECT.TabIndex = 84
        Me.lblCONNECT.Text = "    Not connected!    "
        Me.lblCONNECT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(41, 7)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(58, 13)
        Me.lblComPort.TabIndex = 86
        Me.lblComPort.Text = "COM Ports"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 78)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(121, 22)
        Me.btnConnect.TabIndex = 82
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cbbComPort
        '
        Me.cbbComPort.AccessibleName = ""
        Me.cbbComPort.FormattingEnabled = True
        Me.cbbComPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbbComPort.Location = New System.Drawing.Point(12, 25)
        Me.cbbComPort.Name = "cbbComPort"
        Me.cbbComPort.Size = New System.Drawing.Size(121, 21)
        Me.cbbComPort.TabIndex = 81
        Me.cbbComPort.Tag = ""
        Me.cbbComPort.Text = "Port No."
        '
        'btnAcquire
        '
        Me.btnAcquire.Location = New System.Drawing.Point(13, 50)
        Me.btnAcquire.Name = "btnAcquire"
        Me.btnAcquire.Size = New System.Drawing.Size(124, 25)
        Me.btnAcquire.TabIndex = 349
        Me.btnAcquire.Text = "Acquire Encoder"
        Me.btnAcquire.UseVisualStyleBackColor = True
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(14, 28)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(56, 30)
        Me.btnOn.TabIndex = 350
        Me.btnOn.Text = "ON"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnCW
        '
        Me.btnCW.Location = New System.Drawing.Point(14, 110)
        Me.btnCW.Name = "btnCW"
        Me.btnCW.Size = New System.Drawing.Size(56, 30)
        Me.btnCW.TabIndex = 351
        Me.btnCW.Text = "CW"
        Me.btnCW.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(14, 69)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(56, 30)
        Me.btnGo.TabIndex = 352
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtEncoder
        '
        Me.txtEncoder.BackColor = System.Drawing.Color.Black
        Me.txtEncoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncoder.ForeColor = System.Drawing.Color.White
        Me.txtEncoder.Location = New System.Drawing.Point(13, 24)
        Me.txtEncoder.Name = "txtEncoder"
        Me.txtEncoder.Size = New System.Drawing.Size(124, 20)
        Me.txtEncoder.TabIndex = 354
        Me.txtEncoder.Text = "0"
        Me.txtEncoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTrack
        '
        Me.btnTrack.Location = New System.Drawing.Point(77, 50)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(60, 25)
        Me.btnTrack.TabIndex = 356
        Me.btnTrack.Text = "Track"
        Me.btnTrack.UseVisualStyleBackColor = True
        '
        'nudTrack
        '
        Me.nudTrack.Location = New System.Drawing.Point(13, 24)
        Me.nudTrack.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nudTrack.Name = "nudTrack"
        Me.nudTrack.Size = New System.Drawing.Size(124, 20)
        Me.nudTrack.TabIndex = 357
        Me.nudTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudTrack.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 50)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(60, 25)
        Me.btnReset.TabIndex = 358
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'hsbSpeed
        '
        Me.hsbSpeed.Location = New System.Drawing.Point(14, 50)
        Me.hsbSpeed.Maximum = 255
        Me.hsbSpeed.Minimum = 1
        Me.hsbSpeed.Name = "hsbSpeed"
        Me.hsbSpeed.Size = New System.Drawing.Size(121, 19)
        Me.hsbSpeed.TabIndex = 337
        Me.hsbSpeed.Value = 10
        '
        'txtSpeed
        '
        Me.txtSpeed.BackColor = System.Drawing.Color.Black
        Me.txtSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.Color.White
        Me.txtSpeed.Location = New System.Drawing.Point(14, 22)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(121, 20)
        Me.txtSpeed.TabIndex = 354
        Me.txtSpeed.Text = "0"
        Me.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStatus
        '
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.Location = New System.Drawing.Point(13, 48)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(124, 25)
        Me.btnStatus.TabIndex = 364
        Me.btnStatus.Text = "STATUS"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "Accel. Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Final Speed"
        '
        'lblInitial
        '
        Me.lblInitial.AutoSize = True
        Me.lblInitial.Location = New System.Drawing.Point(12, 27)
        Me.lblInitial.Name = "lblInitial"
        Me.lblInitial.Size = New System.Drawing.Size(65, 13)
        Me.lblInitial.TabIndex = 371
        Me.lblInitial.Text = "Initial Speed"
        '
        'nudAccRate
        '
        Me.nudAccRate.Location = New System.Drawing.Point(80, 76)
        Me.nudAccRate.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudAccRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccRate.Name = "nudAccRate"
        Me.nudAccRate.Size = New System.Drawing.Size(56, 20)
        Me.nudAccRate.TabIndex = 369
        Me.nudAccRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAccRate.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudFinalS
        '
        Me.nudFinalS.Location = New System.Drawing.Point(80, 50)
        Me.nudFinalS.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudFinalS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFinalS.Name = "nudFinalS"
        Me.nudFinalS.Size = New System.Drawing.Size(56, 20)
        Me.nudFinalS.TabIndex = 370
        Me.nudFinalS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFinalS.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'nudInitialS
        '
        Me.nudInitialS.Location = New System.Drawing.Point(80, 24)
        Me.nudInitialS.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudInitialS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInitialS.Name = "nudInitialS"
        Me.nudInitialS.Size = New System.Drawing.Size(56, 20)
        Me.nudInitialS.TabIndex = 368
        Me.nudInitialS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudInitialS.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'btnMstep
        '
        Me.btnMstep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMstep.Location = New System.Drawing.Point(13, 51)
        Me.btnMstep.Name = "btnMstep"
        Me.btnMstep.Size = New System.Drawing.Size(121, 25)
        Me.btnMstep.TabIndex = 364
        Me.btnMstep.Text = "Micro-Stepping"
        Me.btnMstep.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Black
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(13, 22)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(124, 20)
        Me.txtStatus.TabIndex = 354
        Me.txtStatus.Text = "0"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(79, 28)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(56, 30)
        Me.btnOff.TabIndex = 350
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnBrake
        '
        Me.btnBrake.Location = New System.Drawing.Point(79, 69)
        Me.btnBrake.Name = "btnBrake"
        Me.btnBrake.Size = New System.Drawing.Size(56, 30)
        Me.btnBrake.TabIndex = 352
        Me.btnBrake.Text = "BRAKE"
        Me.btnBrake.UseVisualStyleBackColor = True
        '
        'btnCCW
        '
        Me.btnCCW.Location = New System.Drawing.Point(79, 110)
        Me.btnCCW.Name = "btnCCW"
        Me.btnCCW.Size = New System.Drawing.Size(56, 30)
        Me.btnCCW.TabIndex = 351
        Me.btnCCW.Text = "CCW"
        Me.btnCCW.UseVisualStyleBackColor = True
        '
        'gbCtrlPanel
        '
        Me.gbCtrlPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.gbCtrlPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbCtrlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbCtrlPanel.Controls.Add(Me.btnBrake)
        Me.gbCtrlPanel.Controls.Add(Me.btnGo)
        Me.gbCtrlPanel.Controls.Add(Me.btnCCW)
        Me.gbCtrlPanel.Controls.Add(Me.btnCW)
        Me.gbCtrlPanel.Controls.Add(Me.btnOff)
        Me.gbCtrlPanel.Controls.Add(Me.btnOn)
        Me.gbCtrlPanel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbCtrlPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCtrlPanel.Location = New System.Drawing.Point(12, 188)
        Me.gbCtrlPanel.Name = "gbCtrlPanel"
        Me.gbCtrlPanel.Size = New System.Drawing.Size(150, 154)
        Me.gbCtrlPanel.TabIndex = 368
        Me.gbCtrlPanel.TabStop = False
        Me.gbCtrlPanel.Text = "Control Panel"
        '
        'gbSpeed
        '
        Me.gbSpeed.Controls.Add(Me.hsbSpeed)
        Me.gbSpeed.Controls.Add(Me.txtSpeed)
        Me.gbSpeed.Location = New System.Drawing.Point(168, 106)
        Me.gbSpeed.Name = "gbSpeed"
        Me.gbSpeed.Size = New System.Drawing.Size(150, 87)
        Me.gbSpeed.TabIndex = 369
        Me.gbSpeed.TabStop = False
        Me.gbSpeed.Text = "Set Speed"
        '
        'gbEncoder
        '
        Me.gbEncoder.Controls.Add(Me.txtEncoder)
        Me.gbEncoder.Controls.Add(Me.btnAcquire)
        Me.gbEncoder.Location = New System.Drawing.Point(324, 106)
        Me.gbEncoder.Name = "gbEncoder"
        Me.gbEncoder.Size = New System.Drawing.Size(150, 88)
        Me.gbEncoder.TabIndex = 370
        Me.gbEncoder.TabStop = False
        Me.gbEncoder.Text = "Request Encoder"
        '
        'gbTrack
        '
        Me.gbTrack.Controls.Add(Me.nudTrack)
        Me.gbTrack.Controls.Add(Me.btnTrack)
        Me.gbTrack.Controls.Add(Me.btnReset)
        Me.gbTrack.Location = New System.Drawing.Point(324, 12)
        Me.gbTrack.Name = "gbTrack"
        Me.gbTrack.Size = New System.Drawing.Size(150, 88)
        Me.gbTrack.TabIndex = 370
        Me.gbTrack.TabStop = False
        Me.gbTrack.Text = "Track Encoder"
        '
        'gbAccelerate
        '
        Me.gbAccelerate.Controls.Add(Me.Label2)
        Me.gbAccelerate.Controls.Add(Me.lblInitial)
        Me.gbAccelerate.Controls.Add(Me.Label1)
        Me.gbAccelerate.Controls.Add(Me.nudInitialS)
        Me.gbAccelerate.Controls.Add(Me.btnAccelerate)
        Me.gbAccelerate.Controls.Add(Me.nudAccRate)
        Me.gbAccelerate.Controls.Add(Me.nudFinalS)
        Me.gbAccelerate.Location = New System.Drawing.Point(168, 199)
        Me.gbAccelerate.Name = "gbAccelerate"
        Me.gbAccelerate.Size = New System.Drawing.Size(150, 143)
        Me.gbAccelerate.TabIndex = 371
        Me.gbAccelerate.TabStop = False
        Me.gbAccelerate.Text = "Set Acceleration"
        '
        'gbStatus
        '
        Me.gbStatus.Controls.Add(Me.btnStatus)
        Me.gbStatus.Controls.Add(Me.txtStatus)
        Me.gbStatus.Location = New System.Drawing.Point(325, 200)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(149, 86)
        Me.gbStatus.TabIndex = 372
        Me.gbStatus.TabStop = False
        Me.gbStatus.Text = "Status"
        '
        'gbMicroStep
        '
        Me.gbMicroStep.Controls.Add(Me.cbbMicroStep)
        Me.gbMicroStep.Controls.Add(Me.btnMstep)
        Me.gbMicroStep.Location = New System.Drawing.Point(168, 12)
        Me.gbMicroStep.Name = "gbMicroStep"
        Me.gbMicroStep.Size = New System.Drawing.Size(150, 88)
        Me.gbMicroStep.TabIndex = 373
        Me.gbMicroStep.TabStop = False
        Me.gbMicroStep.Text = "Micro-Stepping"
        '
        'cbbMicroStep
        '
        Me.cbbMicroStep.AccessibleName = ""
        Me.cbbMicroStep.FormattingEnabled = True
        Me.cbbMicroStep.Location = New System.Drawing.Point(13, 24)
        Me.cbbMicroStep.Name = "cbbMicroStep"
        Me.cbbMicroStep.Size = New System.Drawing.Size(121, 21)
        Me.cbbMicroStep.TabIndex = 365
        Me.cbbMicroStep.Tag = ""
        Me.cbbMicroStep.Text = "1 / 10"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(325, 292)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 50)
        Me.PictureBox1.TabIndex = 374
        Me.PictureBox1.TabStop = False
        '
        'formGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(489, 356)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbMicroStep)
        Me.Controls.Add(Me.gbStatus)
        Me.Controls.Add(Me.gbAccelerate)
        Me.Controls.Add(Me.gbTrack)
        Me.Controls.Add(Me.gbEncoder)
        Me.Controls.Add(Me.gbSpeed)
        Me.Controls.Add(Me.gbCtrlPanel)
        Me.Controls.Add(Me.plCOMPORT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SD02B GUI ver 1.1"
        Me.plCOMPORT.ResumeLayout(False)
        Me.plCOMPORT.PerformLayout()
        CType(Me.nudTrack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAccRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFinalS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInitialS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCtrlPanel.ResumeLayout(False)
        Me.gbSpeed.ResumeLayout(False)
        Me.gbSpeed.PerformLayout()
        Me.gbEncoder.ResumeLayout(False)
        Me.gbEncoder.PerformLayout()
        Me.gbTrack.ResumeLayout(False)
        Me.gbAccelerate.ResumeLayout(False)
        Me.gbAccelerate.PerformLayout()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.gbMicroStep.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccelerate As System.Windows.Forms.Button
    Friend WithEvents plCOMPORT As System.Windows.Forms.Panel
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents lblCONNECT As System.Windows.Forms.Label
    Friend WithEvents lblComPort As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbbComPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnAcquire As System.Windows.Forms.Button
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnCW As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtEncoder As System.Windows.Forms.TextBox
    Friend WithEvents btnTrack As System.Windows.Forms.Button
    Friend WithEvents nudTrack As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cbbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnSendBaud As System.Windows.Forms.Button
    Friend WithEvents nudInitialS As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAccRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFinalS As System.Windows.Forms.NumericUpDown
    Friend WithEvents hsbSpeed As System.Windows.Forms.HScrollBar
    Friend WithEvents btnMstep As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInitial As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnBrake As System.Windows.Forms.Button
    Friend WithEvents btnCCW As System.Windows.Forms.Button
    Friend WithEvents gbCtrlPanel As System.Windows.Forms.GroupBox
    Friend WithEvents gbSpeed As System.Windows.Forms.GroupBox
    Friend WithEvents gbEncoder As System.Windows.Forms.GroupBox
    Friend WithEvents gbTrack As System.Windows.Forms.GroupBox
    Friend WithEvents gbAccelerate As System.Windows.Forms.GroupBox
    Friend WithEvents gbStatus As System.Windows.Forms.GroupBox
    Friend WithEvents gbMicroStep As System.Windows.Forms.GroupBox
    Friend WithEvents cbbMicroStep As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
