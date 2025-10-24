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
        Dim data(2) As Byte
        'data(0) = &H24 ' $
        'data(0) = &H22 ' "

        Select Case PWMTrackBar.Value
            Case 5
                data(0) = &H24 ' $
                data(1) = &HC3 'PR_PW = 50 32
                data(2) = &H32 'PR_PS = 195 C3
                CountTextBox.Text = "0.5ms"
            Case 6
                data(0) = &H24 ' $
                data(1) = &H3C 'PR_PW = 60
                data(2) = &HC2 'PR_PS = 195
                CountTextBox.Text = "0.6ms"
            Case 7
                data(0) = &H24 ' $
                data(1) = &H46 'PR_PW = 70
                data(2) = &HC1 'PR_PS = 193
                CountTextBox.Text = "0.7ms"
            Case 8
                data(0) = &H24 ' $
                data(1) = &HC8 'PR_PW = 80 50
                data(2) = &HB4 'PR_PS = 192 C0
                CountTextBox.Text = "0.8ms"
            Case 9
                data(0) = &H24 ' $
                data(1) = &H5A 'PR_PW = 90
                data(2) = &HBF 'PR_PS = 191
                CountTextBox.Text = "0.9ms"
            Case 10
                data(0) = &H24 ' $
                data(1) = &H64 'PR_PW = 120
                data(2) = &HBE 'PR_PS = 188
                CountTextBox.Text = "1.0ms"
            Case 11
                data(0) = &H24 ' $
                data(1) = &H6E 'PR_PW = 110 6E
                data(2) = &HBD 'PR_PS = 189 BD
                CountTextBox.Text = "1.1ms"
            Case 12
                data(0) = &H24 ' $
                data(1) = &H78 'PR_PW = 120
                data(2) = &HBC 'PR_PS = 188
                CountTextBox.Text = "1.2ms"
            Case 13
                data(0) = &H24 ' $
                data(1) = &H82 'PR_PW = 130
                data(2) = &HBB 'PR_PS = 187
                CountTextBox.Text = "1.3ms"
            Case 14
                data(0) = &H24 ' $
                data(1) = &H8C 'PR_PW = 140
                data(2) = &HBA 'PR_PS = 186
                CountTextBox.Text = "1.4ms"
            Case 15
                data(0) = &H24 ' $
                data(1) = &H96 'PR_PW = 150
                data(2) = &HB9 'PR_PS = 185
                CountTextBox.Text = "1.5ms"
            Case 16
                data(0) = &H24 ' $
                data(1) = &HA0 'PR_PW = 160
                data(2) = &HB8 'PR_PS = 184
                CountTextBox.Text = "1.6ms"
            Case 17
                data(0) = &H24 ' $
                data(1) = &HAA 'PR_PW = 170
                data(2) = &HB7 'PR_PS = 183
                CountTextBox.Text = "1.7ms"
            Case 18
                data(0) = &H24 ' $
                data(1) = &HB4 'PR_PW = 180 B4
                data(2) = &HB6 'PR_PS = 182 B6
                CountTextBox.Text = "1.8ms"
            Case 19
                data(0) = &H24 ' $
                data(1) = &HBE 'PR_PW = 190
                data(2) = &HB5 'PR_PS = 181
                CountTextBox.Text = "1.9ms"
            Case 20
                data(0) = &H24 ' $
                data(1) = &HC8 'PR_PW = 200
                data(2) = &HB4 'PR_PS = 180
                CountTextBox.Text = "2.0ms"
            Case 21
                data(0) = &H24 ' $
                data(1) = &HD2 'PR_PW = 210
                data(2) = &HB3 'PR_PS = 179
                CountTextBox.Text = "2.1ms"
            Case 22
                data(0) = &H24 ' $
                data(1) = &HDC 'PR_PW = 220
                data(2) = &HB2 'PR_PS = 178
                CountTextBox.Text = "2.2ms"
            Case 23
                data(0) = &H24 ' $
                data(1) = &HE6 'PR_PW = 230
                data(2) = &HB1 'PR_PS = 177
                CountTextBox.Text = "2.3ms"
            Case 24
                data(0) = &H24 ' $
                data(1) = &HF0 'PR_PW = 240
                data(2) = &HB0 'PR_PS = 176
                CountTextBox.Text = "2.4ms"
            Case 25
                data(0) = &H24 ' $
                data(1) = &HFA 'PR_PW = 250
                data(2) = &HAF 'PR_PS = 175
                CountTextBox.Text = "2.5ms"
            Case Else
                data(0) = &H24 ' $
                data(1) = &HFA 'PR_PW = 250
                data(2) = &HAF 'PR_PS = 175
                CountTextBox.Text = "2.5ms"
        End Select
        SerialPort1.Write(data, 0, 3)
    End Sub

    'Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    'CheckForIllegalCrossThreadCalls = False
    'Dim numberOfBytes = SerialPort1.BytesToRead
    'Dim' buffer(numberOfBytes - 1) As Byte
    'Dim got As Integer = SerialPort1.Read(buffer, 0, numberOfBytes)

    ' BytesToReadTextBox.Text = CStr(numberOfBytes)
    'If got > 0 Then
    '     AppendRX(buffer, got)
    ' End If

    'End Sub

    'Private Sub AppendRX(data() As Byte, count As Integer)
    'Dim hexLine As New System.Text.StringBuilder()
    'Dim asciiLine As New System.Text.StringBuilder()

    'F'or i = 0 To count - 1
    'Dim b = data(i)
    '       asciiLine.Append(If(b >= 32 AndAlso b <= 126, ChrW(b), "."c))
    '        hexLine.Append(b.ToString("X2")).Append(" ")
    ' Next
    '
    '   HandShakeAsciiTextBox.Text = asciiLine.ToString()
    '   HandShakeHexTextBox.Text = hexLine.ToString()
    '
    ' If HandShakeHexTextBox.Text = "25 " Then
    'PWM_Select()
    'Timer1.Start()
    ' Else
    '        HandShakeAsciiTextBox.Text = asciiLine.ToString()
    '       HandShakeHexTextBox.Text = hexLine.ToString()
    'End If

    'End Sub

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
