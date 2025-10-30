Imports System.IO.Ports
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Public Class SerialComExample
    Private Sub SerialComExample_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connect()
        Timer1.Start()
    End Sub
    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600 'Q@ Board Default
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.PortName = "COM5" 'RS232 Cable
        SerialPort1.Open()
    End Sub

    Sub PWM_Select()
        Dim data(1) As Byte
        Select Case PWMTrackBar.Value
            Case 5
                data(0) = &H5
                CountTextBox.Text = "0.5ms"
            Case 6
                data(0) = &H6
                CountTextBox.Text = "0.6ms"
            Case 7
                data(0) = &H7
                CountTextBox.Text = "0.7ms"
            Case 8
                data(0) = &H8
                CountTextBox.Text = "0.8ms"
            Case 9
                data(0) = &H9
                CountTextBox.Text = "0.9ms"
            Case 10
                data(0) = &HA
                CountTextBox.Text = "1.0ms"
            Case 11
                data(0) = &HB
                CountTextBox.Text = "1.1ms"
            Case 12
                data(0) = &HC
                CountTextBox.Text = "1.2ms"
            Case 13
                data(0) = &HD
                CountTextBox.Text = "1.3ms"
            Case 14
                data(0) = &HE
                CountTextBox.Text = "1.4ms"
            Case 15
                data(0) = &HF
                CountTextBox.Text = "1.5ms"
            Case 16
                data(0) = &H10
                CountTextBox.Text = "1.6ms"
            Case 17
                data(0) = &H11
                CountTextBox.Text = "1.7ms"
            Case 18
                data(0) = &H12
                CountTextBox.Text = "1.8ms"
            Case 19
                data(0) = &H13
                CountTextBox.Text = "1.9ms"
            Case 20
                data(0) = &H14
                CountTextBox.Text = "2.0ms"
            Case 21
                data(0) = &H15
                CountTextBox.Text = "2.1ms"
            Case 22
                data(0) = &H16
                CountTextBox.Text = "2.2ms"
            Case 23
                data(0) = &H17
                CountTextBox.Text = "2.3ms"
            Case 24
                data(0) = &H18
                CountTextBox.Text = "2.4ms"
            Case 25
                data(0) = &H19
                CountTextBox.Text = "2.5ms"
            Case Else
                data(0) = &H0
                CountTextBox.Text = "Erm.." 'Catch Error
        End Select

        If ADCCheckBox.Checked = True Then
            data(1) = &H23 '#
        Else
            data(1) = &H21 '!
        End If

        SerialPort1.Write(data, 0, 2)

    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        BytesToReadTextBox.Text = CStr(numberOfBytes)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        Dim buffer(numberOfBytes - 1) As Byte
        'Dim buffer(3) As Byte
        Dim got As Integer = SerialPort1.Read(buffer, 0, numberOfBytes)
        Dim adresH As Integer
        Dim adresTotal As Integer
        Dim voltage As Double

        BytesToReadTextBox.Text = CStr(numberOfBytes)

        If got > 0 Then
            If buffer(0) = &H24 Then
                If buffer.Length = 4 Then
                    HandShakeHexTextBox.Text = buffer(0).ToString + " & " + buffer(1).ToString + " & " + buffer(2).ToString + " & " + buffer(3).ToString
                    If buffer(1) = &H23 Then
                        If ADCCheckBox.Checked = True Then
                            Select Case buffer(2)
                                Case 0
                                    adresH = 0
                                Case 1
                                    adresH = 256
                                Case 2
                                    adresH = 512
                                Case 3
                                    adresH = 768
                                Case Else
                                    adresH = 1024
                            End Select

                            adresTotal = buffer(3) + adresH
                            RAWADCTextBox.Text = CStr(adresTotal)
                            voltage = adresTotal * 0.004888
                            VoltADCTextBox.Text = CStr(voltage) + "V"
                        End If
                    End If
                    PWM_Select()
                Else
                    HandShakeHexTextBox.Text = "XX ERROR XX"
                End If
            End If
        End If

    End Sub
    Private Sub PWMTrackBar_Scroll(sender As Object, e As EventArgs) Handles PWMTrackBar.Scroll
        Dim data(0) As Byte
        data(0) = &H24 '$

        SerialPort1.ReadExisting()
        SerialPort1.Write(data, 0, 1)
    End Sub

    Private Sub ADCCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ADCCheckBox.CheckedChanged
        Dim data(0) As Byte
        data(0) = &H24 '$

        SerialPort1.ReadExisting()
        SerialPort1.Write(data, 0, 1)
        If ADCCheckBox.Checked = True Then
            AquireDataButton.Enabled = True
        Else
            AquireDataButton.Enabled = False
        End If

    End Sub

    Private Sub AquireDataButton_Click(sender As Object, e As EventArgs) Handles AquireDataButton.Click
        Dim data(0) As Byte
        data(0) = &H24 '$

        SerialPort1.ReadExisting()
        SerialPort1.Write(data, 0, 1)
    End Sub
End Class