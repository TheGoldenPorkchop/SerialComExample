Imports System.IO.Ports
Imports System.Security.Cryptography


Public Class SerialComExample

    Private Sub SerialComExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        CountTextBox.Text = "1"
    End Sub

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

    Private Sub SerialComExample_Click(sender As Object, e As EventArgs) Handles Me.Click
        Connect()
        Write()
    End Sub

    Sub Write()
        Dim data(0) As Byte 'put bytes into an array
        data(0) = &B11110000 'actual data as a byte
        SerialPort1.Write(data, 0, 1) 'a
    End Sub

    Sub WriteLow()
        Dim data(1) As Byte 'put bytes into an array
        data(0) = &H20 'actual data as a byte
        data(1) = &HFF 'actual data as a byte

        SerialPort1.Write(data, 0, 2) 'a

    End Sub
    Sub WriteHigh()
        Dim data(1) As Byte 'put bytes into an array
        data(0) = &B100000 'actual data as a byte
        data(1) = &B10000000 'actual data as a byte

        SerialPort1.Write(data, 0, 2) 'a
    End Sub

    Sub Read()
        Dim data(SerialPort1.BytesToRead) As Byte

        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)

        For i = 0 To UBound(data)
            Console.WriteLine($"Byte {i}: {Chr(data(i))}")
        Next

        Console.WriteLine($"Is this Q@ Board: {IsQuietBoard(data)}")
        Console.WriteLine(UBound(data))

    End Sub

    Function IsQuietBoard(data() As Byte) As Boolean

        If UBound(data) = 64 And Chr(data(60)) = "@" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Console.WriteLine(SerialPort1.BytesToRead)
        Catch ex As Exception
            Console.WriteLine("Woag")
        End Try
        Read()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Connect()
        ShiftLEDs()
    End Sub

    Sub ShiftLEDs()
        Dim preCount As Integer
        Dim postCount As Integer
        Dim data(1) As Byte 'put bytes into an array

        preCount = CInt(CountTextBox.Text)
        postCount = Counter(preCount)

        data(0) = &H20 'Writes to the Digital Output
        'data(0) = &H60 'Writes to the USART TX Buffer

        If postCount = 1 Then
                data(1) = &H1 'actual data as a byte
            ElseIf postCount = 2 Then
                data(1) = &H2 'actual data as a byte
            ElseIf postCount = 3 Then
                data(1) = &H4 'actual data as a byte
            ElseIf postCount = 4 Then
                data(1) = &H8 'actual data as a byte
            ElseIf postCount = 5 Then
                data(1) = &H10 'actual data as a byte
            ElseIf postCount = 6 Then
                data(1) = &H20 'actual data as a byte
            ElseIf postCount = 7 Then
                data(1) = &H40 'actual data as a byte
            ElseIf postCount = 8 Then
                data(1) = &H80 'actual data as a byte
        End If

        SerialPort1.Write(data, 0, 2) '
        CountTextBox.Text = CStr(postCount)
    End Sub

    Function Counter(currentCount As Integer) As Integer
        If currentCount > 7 Then
            currentCount = 1
        Else
            currentCount = currentCount + 1
        End If
        Return currentCount
    End Function
End Class
