Public Class LVC
    Dim oldString As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        SerialPort1.PortName = portName.Text
        SerialPort1.Open()
        oldString = "Yo Bros !\n"
        Timer1.Start()
        Label5.Text = "UP !"
        Label5.ForeColor = Color.Green

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim newString As String
        newString = SerialPort1.ReadLine
        If Not (newString.Equals(oldString)) Then
            If Val(newString.Contains("1")) Then
                Label5.Text = "HOLD !"
                Label5.ForeColor = Color.Red


                indicatoR.FillColor = Color.Red
                Timer1.Stop()
                ' SerialPort1.DiscardInBuffer()
                SerialPort1.Close()

                oldString = "0"
                newString = "0"

            Else
                indicatoR.FillColor = Color.Green
            End If


        End If
    End Sub

End Class