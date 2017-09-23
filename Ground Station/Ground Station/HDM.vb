Public Class HDM
    Dim oldString As String
    Dim xc As Integer
    Dim yc As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '  SerialPort1.PortName = portName.Text
        ' SerialPort1.Open()
        ' oldString = "Yo Bros !\n"
        Timer1.Start()
        xc = 0
        'yc = 0
    End Sub

    Private Sub HDM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        xc = xc + 1


    End Sub

    

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim newString As String
        Timer1.Start()

        Dim kk As Integer
        For k As Integer = 1 To 500
            PictureBox1.Width = k

            While Not xc = kk + 1

            End While

        Next
    End Sub
End Class