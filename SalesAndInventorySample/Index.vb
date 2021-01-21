Public Class Index



    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime.Spring = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        dateandtime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

End Class