<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SerialComExample
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CountTextBox = New System.Windows.Forms.TextBox()
        Me.PWMTrackBar = New System.Windows.Forms.TrackBar()
        Me.BytesToReadTextBox = New System.Windows.Forms.TextBox()
        Me.HandShakeAsciiTextBox = New System.Windows.Forms.TextBox()
        Me.HandShakeHexTextBox = New System.Windows.Forms.TextBox()
        Me.SendDataButton = New System.Windows.Forms.Button()
        CType(Me.PWMTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CountTextBox
        '
        Me.CountTextBox.Location = New System.Drawing.Point(195, 68)
        Me.CountTextBox.Name = "CountTextBox"
        Me.CountTextBox.ReadOnly = True
        Me.CountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CountTextBox.TabIndex = 0
        '
        'PWMTrackBar
        '
        Me.PWMTrackBar.LargeChange = 1
        Me.PWMTrackBar.Location = New System.Drawing.Point(12, 96)
        Me.PWMTrackBar.Maximum = 25
        Me.PWMTrackBar.Minimum = 5
        Me.PWMTrackBar.Name = "PWMTrackBar"
        Me.PWMTrackBar.Size = New System.Drawing.Size(482, 56)
        Me.PWMTrackBar.TabIndex = 1
        Me.PWMTrackBar.TickFrequency = 20
        Me.PWMTrackBar.Value = 5
        '
        'BytesToReadTextBox
        '
        Me.BytesToReadTextBox.Location = New System.Drawing.Point(12, 12)
        Me.BytesToReadTextBox.Name = "BytesToReadTextBox"
        Me.BytesToReadTextBox.Size = New System.Drawing.Size(177, 22)
        Me.BytesToReadTextBox.TabIndex = 2
        '
        'HandShakeAsciiTextBox
        '
        Me.HandShakeAsciiTextBox.Location = New System.Drawing.Point(12, 40)
        Me.HandShakeAsciiTextBox.Name = "HandShakeAsciiTextBox"
        Me.HandShakeAsciiTextBox.Size = New System.Drawing.Size(177, 22)
        Me.HandShakeAsciiTextBox.TabIndex = 3
        '
        'HandShakeHexTextBox
        '
        Me.HandShakeHexTextBox.Location = New System.Drawing.Point(12, 68)
        Me.HandShakeHexTextBox.Name = "HandShakeHexTextBox"
        Me.HandShakeHexTextBox.Size = New System.Drawing.Size(177, 22)
        Me.HandShakeHexTextBox.TabIndex = 4
        '
        'SendDataButton
        '
        Me.SendDataButton.Location = New System.Drawing.Point(301, 12)
        Me.SendDataButton.Name = "SendDataButton"
        Me.SendDataButton.Size = New System.Drawing.Size(193, 79)
        Me.SendDataButton.TabIndex = 5
        Me.SendDataButton.Text = "Send Data"
        Me.SendDataButton.UseVisualStyleBackColor = True
        '
        'SerialComExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SendDataButton)
        Me.Controls.Add(Me.HandShakeHexTextBox)
        Me.Controls.Add(Me.HandShakeAsciiTextBox)
        Me.Controls.Add(Me.BytesToReadTextBox)
        Me.Controls.Add(Me.PWMTrackBar)
        Me.Controls.Add(Me.CountTextBox)
        Me.Name = "SerialComExample"
        Me.Text = "Form1"
        CType(Me.PWMTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CountTextBox As TextBox
    Friend WithEvents PWMTrackBar As TrackBar
    Friend WithEvents BytesToReadTextBox As TextBox
    Friend WithEvents HandShakeAsciiTextBox As TextBox
    Friend WithEvents HandShakeHexTextBox As TextBox
    Friend WithEvents SendDataButton As Button
End Class
