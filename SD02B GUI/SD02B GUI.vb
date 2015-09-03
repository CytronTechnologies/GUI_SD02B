'===========================================================================================
'
'   SD02B GUI ver 1.1
'   -----------------
'
'   DOCUMENT    :   SAMPLE SOURCE CODE TO CONTROL A SD02B THROUGH UART USING COMPUTER
'
'   DESCRIPTION :   - This GUI is developed as a kick-starter for the user in controlling 
'                     SD02B Enhanced 2Amp Stepper Motor Driver using computer.
'                   - The commands used in the main program are parts of the full UART 
'					  Protocol for SD02B. 
'                   - Always refer to SD02B user's manual for more accurate info.
'                   - This software is not fully tested. Thus, there is no guarantee 
'					  on the full functional of this software in all conditions.
'				    - User may modify this software to use in own applications.
'                   - Since a lot of information can be found in internet and from Microsoft 
'                     support, we don't provide full comments in this software.  
'
'
'	Cytron Technologies - ROBOT. HEAD to TOE
'
'   Please visit our website at www.cytron.com.my
'
'===========================================================================================

Option Strict On
Imports System
Imports System.Text
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows.Forms

Public Class formGUI

    '==== VARIABLES ========================================================================

    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim data(2) As Byte                                     'declare array
    Dim mode As Integer

    '==== PROGRAM STARTS ===================================================================

    Private Sub formGUI_Load( _
       ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles MyBase.Load

        For i As Integer = 0 To _
            My.Computer.Ports.SerialPortNames.Count - 1
            cbbComPort.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
        btnConnect.Text = "CONNECT"
        btnReset.Enabled = False
        btnOn.Enabled = False
        btnCW.Enabled = False
        btnGo.Enabled = False
        btnOff.Enabled = False
        btnCCW.Enabled = False
        btnBrake.Enabled = False
        btnAccelerate.Enabled = False
        btnAcquire.Enabled = False
        hsbSpeed.Enabled = False
        btnTrack.Enabled = False
        btnStatus.Enabled = False
        btnSendBaud.Enabled = False
        btnMstep.Enabled = False
        txtSpeed.Text = CStr(hsbSpeed.Value)

    End Sub


    '==== REFRESH COM PORT =================================================================

    Private Sub cbbComPort_DropDown( _
        ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cbbComPort.DropDown

        cbbComPort.Items.Clear()
        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            cbbComPort.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next

    End Sub


    Private Sub cbbBaud_DropDown( _
        ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cbbBaud.DropDown

        cbbBaud.Items.Clear()
        cbbBaud.Items.Add(9600)
        cbbBaud.Items.Add(19200)
        cbbBaud.Items.Add(38400)
        cbbBaud.Items.Add(57600)

    End Sub

    Private Sub cbbMicroStep_DropDown( _
        ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cbbMicroStep.DropDown

        cbbMicroStep.Items.Clear()
        cbbMicroStep.Items.Add("None (1 / 1)")
        cbbMicroStep.Items.Add("1 / 2")
        cbbMicroStep.Items.Add("1 / 5")
        cbbMicroStep.Items.Add("1 / 10")

    End Sub


    '==== CONNECT BUTTON ===================================================================

    Private Sub btnConnect_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnConnect.Click

        If SerialPort.IsOpen Then
            Try
                SerialPort.Write("F")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            SerialPort.Close()

            lblCONNECT.Text = "Port closed at " + vbCrLf + CStr(DateTime.Now)
            btnConnect.Text = "CONNECT"
            btnReset.Enabled = False
            btnOn.Enabled = False
            btnCW.Enabled = False
            btnGo.Enabled = False
            btnOff.Enabled = False
            btnCCW.Enabled = False
            btnBrake.Enabled = False
            btnAccelerate.Enabled = False
            btnAcquire.Enabled = False
            btnTrack.Enabled = False
            hsbSpeed.Enabled = False
            btnStatus.Enabled = False
            btnSendBaud.Enabled = False
            btnMstep.Enabled = False
        Else
            Try
                With SerialPort
                    .PortName = cbbComPort.Text
                    .BaudRate = CInt(cbbBaud.Text)
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = IO.Ports.StopBits.One
                End With
                SerialPort.Open()
                lblCONNECT.Text = cbbComPort.Text & " is connected!"
                btnConnect.Text = "DISCONNECT"
                btnReset.Enabled = True
                btnOn.Enabled = True
                btnCW.Enabled = True
                btnGo.Enabled = True
                btnAccelerate.Enabled = True
                btnAcquire.Enabled = True
                hsbSpeed.Enabled = True
                btnTrack.Enabled = True
                btnStatus.Enabled = True
                btnSendBaud.Enabled = True
                btnMstep.Enabled = True
                mode = 0
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If
    End Sub


    '==== CONTROL BUTTONS ==================================================================

    Private Sub btnOnOff_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnOn.Click, btnOff.Click

        If (btnOn.Enabled = True) Then
            btnOn.Enabled = False
            btnOff.Enabled = True
            SerialPort.Write("O")
        ElseIf (btnOff.Enabled = True) Then
            btnOff.Enabled = False
            btnOn.Enabled = True
            SerialPort.Write("F")
        End If
    End Sub

    Private Sub btnCwCcw_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnCW.Click, btnCCW.Click

        If (btnCW.Enabled = True) Then
            btnCW.Enabled = False
            btnCCW.Enabled = True
            SerialPort.Write(">")
        ElseIf (btnCCW.Enabled = True) Then
            btnCCW.Enabled = False
            btnCW.Enabled = True
            SerialPort.Write("<")
        End If
    End Sub

    Private Sub btnGoBrake_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnGo.Click, btnBrake.Click

        If (btnGo.Enabled = True) Then
            btnGo.Enabled = False
            btnBrake.Enabled = True
            SerialPort.Write("G")
        ElseIf (btnBrake.Enabled = True) Then
            btnBrake.Enabled = False
            btnGo.Enabled = True
            SerialPort.Write("B")
        End If
    End Sub

    Private Sub btnAcquire_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAcquire.Click

        SerialPort.Write("E")

        Dim recH As Integer = ((SerialPort.ReadByte() << 8) And &HFF00) 'High byte
        Dim recL As Integer = (SerialPort.ReadByte() And &HFF)          'Low byte
        txtEncoder.Text = CStr(recH Xor recL)                           'Combined to a 16 bits value

    End Sub

    Private Sub btnReset_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnReset.Click

        SerialPort.Write("R")

    End Sub

    Private Sub btnTrack_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnTrack.Click

        data(0) = CByte((CLng(nudTrack.Value) >> 8) And &HFF)   'High byte
        data(1) = CByte(CLng(nudTrack.Value) And &HFF)          'Low byte

        SerialPort.Write("T")
        SerialPort.Write(data, 0, 2)

    End Sub

    Private Sub hsbSPEED_scroll( _
            ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles hsbSpeed.Scroll

        txtSpeed.Text = CStr(hsbSpeed.Value)
        data(0) = CByte(hsbSpeed.Value)

        SerialPort.Write("S")
        SerialPort.Write(data, 0, 1)

    End Sub

    Private Sub btnAccelerate_Click( _
            ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles btnAccelerate.Click

        data(0) = CByte(nudInitialS.Value)
        data(1) = CByte(nudFinalS.Value)
        data(2) = CByte(nudAccRate.Value)

        SerialPort.Write("A")
        SerialPort.Write(data, 0, 3)

    End Sub

    Private Sub btnStatus_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStatus.Click, btnMstep.Click

        SerialPort.Write("C")

        Dim rec As Integer = SerialPort.ReadByte()

        txtStatus.Clear()
        txtStatus.Text = CStr(rec)

    End Sub

    Private Sub btnSendBaud_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSendBaud.Click

        data(0) = CByte(CInt(cbbBaud.Text) / 9600)
        SerialPort.Write("U")
        SerialPort.Write(data, 0, 1)

        SerialPort.Close()
        Try                         'Also change GUI baudrate to the newly defined baudrate
            With SerialPort
                .PortName = cbbComPort.Text
                .BaudRate = CInt(cbbBaud.Text)
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With
            SerialPort.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnMstep_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnMstep.Click

        If cbbMicroStep.Text = "None (1 / 1)" Then
            data(0) = CByte(1)
        ElseIf cbbMicroStep.Text = "1 / 2" Then
            data(0) = CByte(2)
        ElseIf cbbMicroStep.Text = "1 / 5" Then
            data(0) = CByte(5)
        ElseIf cbbMicroStep.Text = "1 / 10" Then
            data(0) = CByte(10)
        End If

        SerialPort.Write("M")
        SerialPort.Write(data, 0, 1)

    End Sub
    
    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        System.Diagnostics.Process.Start("http://www.cytron.com.my/viewProduct.php?pid=Hh0lHSMiEB4WLykMDQcbM9ZhFTt00HXpaerQwtupNE8=")

    End Sub

End Class



