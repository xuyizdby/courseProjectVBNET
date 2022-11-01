Public Class Form3


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Today.Date
        Label4.Text = Format(Now, "HH:mm")
        Timer1.Enabled = True
        Timer1.Interval = 5000
        Dim S As Date
        S = Now
        If Hour(S) > 4 And Hour(S) < 11 Then
            Label5.Text = "早上好"
        ElseIf Hour(S) > 10 And Hour(S) < 13 Then
            Label5.Text = "午安！"
        ElseIf Hour(S) > 12 And Hour(S) < 19 Then
            Label5.Text = "下午好！"
        ElseIf Hour(S) > 18 And Hour(S) < 24 Then
            Label5.Text = "晚上好！"
        ElseIf Hour(S) >= 0 And Hour(S) < 5 Then
            Label5.Text = "晚安！"
        End If
    End Sub
End Class