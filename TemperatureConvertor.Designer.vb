<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConvertor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemperatureConvertor))
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.rbtnCtoF = New System.Windows.Forms.RadioButton()
        Me.rbtnFtoC = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(12, 12)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperature.TabIndex = 0
        '
        'rbtnCtoF
        '
        Me.rbtnCtoF.AutoSize = True
        Me.rbtnCtoF.Location = New System.Drawing.Point(12, 57)
        Me.rbtnCtoF.Name = "rbtnCtoF"
        Me.rbtnCtoF.Size = New System.Drawing.Size(123, 17)
        Me.rbtnCtoF.TabIndex = 1
        Me.rbtnCtoF.TabStop = True
        Me.rbtnCtoF.Text = "Celsius to Fahrenheit"
        Me.rbtnCtoF.UseVisualStyleBackColor = True
        '
        'rbtnFtoC
        '
        Me.rbtnFtoC.AutoSize = True
        Me.rbtnFtoC.Location = New System.Drawing.Point(12, 80)
        Me.rbtnFtoC.Name = "rbtnFtoC"
        Me.rbtnFtoC.Size = New System.Drawing.Size(123, 17)
        Me.rbtnFtoC.TabIndex = 2
        Me.rbtnFtoC.TabStop = True
        Me.rbtnFtoC.Text = "Fahrenheit to Celsius"
        Me.rbtnFtoC.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(12, 114)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(196, 57)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(79, 25)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result"
        '
        'TemperatureConvertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 156)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.rbtnFtoC)
        Me.Controls.Add(Me.rbtnCtoF)
        Me.Controls.Add(Me.txtTemperature)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TemperatureConvertor"
        Me.Text = "Temperature Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents rbtnCtoF As RadioButton
    Friend WithEvents rbtnFtoC As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblResult As Label
End Class
