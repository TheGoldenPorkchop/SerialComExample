Imports System.IO.Ports
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar


Public Class SerialComExample
    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600 'Q@ Board Default
        'SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.Parity = Parity.None
        'SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.PortName = "COM5" 'RS232 Cable
        'SerialPort1.PortName = "COM3" 'Qy@ Board
        SerialPort1.Open()
    End Sub

    Sub PWM_Select()
        Dim data(0) As Byte
        'data(0) = &H24 ' $
        'data(0) = &H22 ' "

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
                data(0) = &H21
                CountTextBox.Text = "Erm.."
        End Select
        SerialPort1.Write(data, 0, 1)
    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        Dim buffer(numberOfBytes - 1) As Byte
        Dim got As Integer = SerialPort1.Read(buffer, 0, numberOfBytes)

        BytesToReadTextBox.Text = CStr(numberOfBytes)
        If got > 0 Then
            'AppendRX(buffer, got)
        End If

    End Sub

    Private Sub AppendRX(data() As Byte, count As Integer)
        Dim hexLine As New System.Text.StringBuilder()
        Dim asciiLine As New System.Text.StringBuilder()

        For i = 0 To count - 1
            Dim b = data(i)
            asciiLine.Append(If(b >= 32 AndAlso b <= 126, ChrW(b), "."c))
            hexLine.Append(b.ToString("X2")).Append(" ")
        Next

        HandShakeAsciiTextBox.Text = asciiLine.ToString()
        HandShakeHexTextBox.Text = hexLine.ToString()

        If HandShakeHexTextBox.Text = "24 " Then
            'PWM_Select()
            'Timer1.Start()
        Else
            'HandShakeAsciiTextBox.Text = asciiLine.ToString()
            'HandShakeHexTextBox.Text = hexLine.ToString()
        End If

    End Sub

    Private Sub SerialComExample_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connect()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        If numberOfBytes = 0 Then
            HandShakeAsciiTextBox.Text = ""
            HandShakeHexTextBox.Text = ""
        End If
        Timer1.Stop()
    End Sub

    Private Sub SendDataButton_Click(sender As Object, e As EventArgs) Handles SendDataButton.Click
        'Timer1.Start()
        PWM_Select()

        'Dim data(0) As Byte
        'Data(0) = &H24 '$
        'SerialPort1.Write(data, 0, 1)
    End Sub
End Class
