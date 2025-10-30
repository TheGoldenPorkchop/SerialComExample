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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RAWADCTextBox = New System.Windows.Forms.TextBox()
        Me.VoltADCTextBox = New System.Windows.Forms.TextBox()
        Me.ADCCheckBox = New System.Windows.Forms.CheckBox()
        Me.AquireDataButton = New System.Windows.Forms.Button()
        CType(Me.PWMTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
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
        Me.BytesToReadTextBox.ReadOnly = True
        Me.BytesToReadTextBox.Size = New System.Drawing.Size(177, 22)
        Me.BytesToReadTextBox.TabIndex = 2
        '
        'HandShakeAsciiTextBox
        '
        Me.HandShakeAsciiTextBox.Location = New System.Drawing.Point(12, 40)
        Me.HandShakeAsciiTextBox.Name = "HandShakeAsciiTextBox"
        Me.HandShakeAsciiTextBox.ReadOnly = True
        Me.HandShakeAsciiTextBox.Size = New System.Drawing.Size(177, 22)
        Me.HandShakeAsciiTextBox.TabIndex = 3
        '
        'HandShakeHexTextBox
        '
        Me.HandShakeHexTextBox.Location = New System.Drawing.Point(12, 68)
        Me.HandShakeHexTextBox.Name = "HandShakeHexTextBox"
        Me.HandShakeHexTextBox.ReadOnly = True
        Me.HandShakeHexTextBox.Size = New System.Drawing.Size(177, 22)
        Me.HandShakeHexTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0.5ms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2.5ms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pulse Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ADC Data"
        '
        'RAWADCTextBox
        '
        Me.RAWADCTextBox.Location = New System.Drawing.Point(591, 63)
        Me.RAWADCTextBox.Name = "RAWADCTextBox"
        Me.RAWADCTextBox.ReadOnly = True
        Me.RAWADCTextBox.Size = New System.Drawing.Size(197, 22)
        Me.RAWADCTextBox.TabIndex = 10
        '
        'VoltADCTextBox
        '
        Me.VoltADCTextBox.Location = New System.Drawing.Point(592, 96)
        Me.VoltADCTextBox.Name = "VoltADCTextBox"
        Me.VoltADCTextBox.ReadOnly = True
        Me.VoltADCTextBox.Size = New System.Drawing.Size(197, 22)
        Me.VoltADCTextBox.TabIndex = 11
        '
        'ADCCheckBox
        '
        Me.ADCCheckBox.AutoSize = True
        Me.ADCCheckBox.Location = New System.Drawing.Point(385, 70)
        Me.ADCCheckBox.Name = "ADCCheckBox"
        Me.ADCCheckBox.Size = New System.Drawing.Size(57, 20)
        Me.ADCCheckBox.TabIndex = 12
        Me.ADCCheckBox.Text = "ADC"
        Me.ADCCheckBox.UseVisualStyleBackColor = True
        '
        'AquireDataButton
        '
        Me.AquireDataButton.Enabled = False
        Me.AquireDataButton.Location = New System.Drawing.Point(592, 124)
        Me.AquireDataButton.Name = "AquireDataButton"
        Me.AquireDataButton.Size = New System.Drawing.Size(102, 52)
        Me.AquireDataButton.TabIndex = 13
        Me.AquireDataButton.Text = "Acquire Data"
        Me.AquireDataButton.UseVisualStyleBackColor = True
        '
        'SerialComExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AquireDataButton)
        Me.Controls.Add(Me.ADCCheckBox)
        Me.Controls.Add(Me.VoltADCTextBox)
        Me.Controls.Add(Me.RAWADCTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RAWADCTextBox As TextBox
    Friend WithEvents VoltADCTextBox As TextBox
    Friend WithEvents ADCCheckBox As CheckBox
    Friend WithEvents AquireDataButton As Button
End Class
