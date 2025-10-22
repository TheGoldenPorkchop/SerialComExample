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
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'CountTextBox
        '
        Me.CountTextBox.Location = New System.Drawing.Point(500, 151)
        Me.CountTextBox.Name = "CountTextBox"
        Me.CountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CountTextBox.TabIndex = 0
        '
        'SerialComExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CountTextBox)
        Me.Name = "SerialComExample"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CountTextBox As TextBox
End Class
