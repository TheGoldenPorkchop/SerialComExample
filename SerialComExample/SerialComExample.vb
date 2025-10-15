Imports System.IO.Ports
Imports System.Security.Cryptography


Public Class SerialComExample

    Sub Connect()
        SerialPort1.BaudRate = 115200 'Q@ Board Default
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.PortName = "COM3"

        SerialPort1.Open()
        SerialPort1.Close()
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

    Sub Read()
        Dim data(SerialPort1.ReadBufferSize) As Byte
        SerialPort1.Read(data, 0, SerialPort1.ReadBufferSize)

        For i = 0 To UBound(data)
            'Console.WriteLine(Chr(data(i)))
            Console.WriteLine(Chr(data(i)))
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

    Function CheckIfQuietBoard() As Boolean
        Dim bytes(0) As Byte
        bytes(0) = &B11110000
        SerialPort1.Write(bytes, 0, 1)
        Return True
    End Function




    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim bytes As Integer
        Try
            ' Me.Text = CStr(SerialPort1.BytesToRead)
            bytes = SerialPort1.BytesToRead
            Console.WriteLine(SerialPort1.BytesToRead)
        Catch ex As Exception
            Console.WriteLine("Woag")
        End Try
    End Sub
End Class
