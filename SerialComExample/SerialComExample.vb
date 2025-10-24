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
        Dim data(3) As Byte

        For Rank = 5 To 25
            Select Case Rank
                Case 5
                    data(0) = &H24 '$
                    data(1) = &H32 'PR_PW = 50
                    data(2) = &H23 '#
                    data(3) = &HC3 'PR_PS = 195
                    CountTextBox.Text = "0.5ms"
                Case 6
                    data(0) = &H24 '$
                    data(1) = &H3C 'PR_PW = 60
                    data(2) = &H23 '#
                    data(3) = &HC2 'PR_PS = 195
                    CountTextBox.Text = "0.6ms"
                Case 7
                    data(0) = &H24 '$
                    data(1) = &H46 'PR_PW = 70
                    data(2) = &H23 '#
                    data(3) = &HC1 'PR_PS = 193
                    CountTextBox.Text = "0.7ms"
                Case 8
                    data(0) = &H24 '$
                    data(1) = &H50 'PR_PW = 80
                    data(2) = &H23 '#
                    data(3) = &HC0 'PR_PS = 192
                    CountTextBox.Text = "0.8ms"
                Case 9
                    data(0) = &H24 '$
                    data(1) = &H5A 'PR_PW = 90
                    data(2) = &H23 '#
                    data(3) = &HBF 'PR_PS = 191
                    CountTextBox.Text = "0.9ms"
                Case 10
                    data(0) = &H24 '$
                    data(1) = &H64 'PR_PW = 100
                    data(2) = &H23 '#
                    data(3) = &HBE 'PR_PS = 190
                    CountTextBox.Text = "1.0ms"
                Case 11
                    data(0) = &H24 '$
                    data(1) = &H6E 'PR_PW = 110
                    data(2) = &H23 '#
                    data(3) = &HBD 'PR_PS = 189
                    CountTextBox.Text = "1.1ms"
                Case 12
                    data(0) = &H24 '$
                    data(1) = &H78 'PR_PW = 120
                    data(2) = &H23 '#
                    data(3) = &HBC 'PR_PS = 188
                    CountTextBox.Text = "1.2ms"
                Case 13
                    data(0) = &H24 '$
                    data(1) = &H82 'PR_PW = 130
                    data(2) = &H23 '#
                    data(3) = &HBB 'PR_PS = 187
                    CountTextBox.Text = "1.3ms"
                Case 14
                    data(0) = &H24 '$
                    data(1) = &H8C 'PR_PW = 140
                    data(2) = &H23 '#
                    data(3) = &HBA 'PR_PS = 186
                    CountTextBox.Text = "1.4ms"
                Case 15
                    data(0) = &H24 '$
                    data(1) = &H96 'PR_PW = 150
                    data(2) = &H23 '#
                    data(3) = &HB9 'PR_PS = 185
                    CountTextBox.Text = "1.5ms"
                Case 16
                    data(0) = &H24 '$
                    data(1) = &HA0 'PR_PW = 160
                    data(2) = &H23 '#
                    data(3) = &HB8 'PR_PS = 184
                    CountTextBox.Text = "1.6ms"
                Case 17
                    data(0) = &H24 '$
                    data(1) = &HAA 'PR_PW = 170
                    data(2) = &H23 '#
                    data(3) = &HB7 'PR_PS = 183
                    CountTextBox.Text = "1.7ms"
                Case 18
                    data(0) = &H24 '$
                    data(1) = &HB4 'PR_PW = 180
                    data(2) = &H23 '#
                    data(3) = &HB6 'PR_PS = 182
                    CountTextBox.Text = "1.8ms"
                Case 19
                    data(0) = &H24 '$
                    data(1) = &HBE 'PR_PW = 190
                    data(2) = &H23 '#
                    data(3) = &HB5 'PR_PS = 181
                    CountTextBox.Text = "1.9ms"
                Case 20
                    data(0) = &H24 '$
                    data(1) = &HC8 'PR_PW = 200
                    data(2) = &H23 '#
                    data(3) = &HB4 'PR_PS = 180
                    CountTextBox.Text = "2.0ms"
                Case 21
                    data(0) = &H24 '$
                    data(1) = &HD2 'PR_PW = 210
                    data(2) = &H23 '#
                    data(3) = &HB3 'PR_PS = 179
                    CountTextBox.Text = "2.1ms"
                Case 22
                    data(0) = &H24 '$
                    data(1) = &HDC 'PR_PW = 220
                    data(2) = &H23 '#
                    data(3) = &HB2 'PR_PS = 178
                    CountTextBox.Text = "2.2ms"
                Case 23
                    data(0) = &H24 '$
                    data(1) = &HE6 'PR_PW = 230
                    data(2) = &H23 '#
                    data(3) = &HB1 'PR_PS = 177
                    CountTextBox.Text = "2.3ms"
                Case 24
                    data(0) = &H24 '$
                    data(1) = &HF0 'PR_PW = 240
                    data(2) = &H23 '#
                    data(3) = &HB0 'PR_PS = 176
                    CountTextBox.Text = "2.4ms"
                Case 25
                    data(0) = &H24 '$
                    data(1) = &HFA 'PR_PW = 250
                    data(2) = &H23 '#
                    data(3) = &HAF 'PR_PS = 175
                    CountTextBox.Text = "2.5ms"
            End Select
        Next
        SerialPort1.Write(data, 0, 4)
    End Sub

    Private Sub PWMTrackBar_Scroll(sender As Object, e As EventArgs) Handles PWMTrackBar.Scroll
        Connect()
        PWM_Select()
    End Sub
End Class
