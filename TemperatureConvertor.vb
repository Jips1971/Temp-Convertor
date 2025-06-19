Public Class TemperatureConvertor

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputTemp As Double

        If Double.TryParse(txtTemperature.Text, inputTemp) Then
            If rbtnCtoF.Checked Then
                Dim result As Double = (inputTemp * 9 / 5) + 32
                lblResult.Text = $"{inputTemp}°C is {result:F2}°F"
            ElseIf rbtnFtoC.Checked Then
                Dim result As Double = (inputTemp - 32) * 5 / 9
                lblResult.Text = $"{inputTemp}°F is {result:F2}°C"
            Else
                MessageBox.Show("Please select a conversion direction.")
            End If
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

End Class