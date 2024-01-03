Public Class Form5



    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        RadioButton1.Checked = True
    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        RadioButton2.Checked = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Enabled = True
        Panel2.Enabled = True
        Me.Hide()
        Form4.Show()
        n1.BorderColor = Color.Red
        n2.BorderColor = Color.Red
        n3.BorderColor = Color.Red
        n4.BorderColor = Color.Red
        n5.BorderColor = Color.Red
        n6.BorderColor = Color.Red
        n7.BorderColor = Color.Red
        n8.BorderColor = Color.Red
        n9.BorderColor = Color.Red
        n1.BorderColor = Color.Red
    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        RadioButton3.Checked = True
    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        RadioButton4.Checked = True
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        RadioButton5.Checked = True
    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        RadioButton6.Checked = True
    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        RadioButton7.Checked = True
    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        RadioButton8.Checked = True
    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        RadioButton9.Checked = True
    End Sub

    Private Sub n10_Click(sender As Object, e As EventArgs) Handles n10.Click
        RadioButton10.Checked = True
    End Sub

    Private Sub m1_Click(sender As Object, e As EventArgs) Handles m1.Click
        RadioButton11.Checked = True
    End Sub

    Private Sub m9_Click(sender As Object, e As EventArgs) Handles m9.Click
        RadioButton19.Checked = True
    End Sub

    Private Sub m8_Click(sender As Object, e As EventArgs) Handles m8.Click
        RadioButton18.Checked = True
    End Sub

    Private Sub m7_Click(sender As Object, e As EventArgs) Handles m7.Click
        RadioButton17.Checked = True
    End Sub

    Private Sub m6_Click(sender As Object, e As EventArgs) Handles m6.Click
        RadioButton16.Checked = True
    End Sub

    Private Sub m5_Click(sender As Object, e As EventArgs) Handles m5.Click
        RadioButton15.Checked = True
    End Sub

    Private Sub m4_Click(sender As Object, e As EventArgs) Handles m4.Click
        RadioButton14.Checked = True
    End Sub

    Private Sub m3_Click(sender As Object, e As EventArgs) Handles m3.Click
        RadioButton13.Checked = True
    End Sub

    Private Sub m2_Click(sender As Object, e As EventArgs) Handles m2.Click
        RadioButton12.Checked = True
    End Sub

    Private Sub m10_Click(sender As Object, e As EventArgs) Handles m10.Click
        RadioButton20.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Form1.n1.BorderColor = Color.OrangeRed
            Form1.n1.BorderWidth = 10
            Form1.n1.Enabled = False
        ElseIf RadioButton2.Checked = True Then
            Form1.n2.BorderColor = Color.OrangeRed
            Form1.n2.BorderWidth = 10
            Form1.n2.Enabled = False
        ElseIf RadioButton3.Checked = True Then
            Form1.n3.BorderColor = Color.OrangeRed
            Form1.n3.BorderWidth = 10
            Form1.n3.Enabled = False
        ElseIf RadioButton4.Checked = True Then
            Form1.n4.BorderColor = Color.OrangeRed
            Form1.n4.BorderWidth = 10
            Form1.n4.Enabled = False
        ElseIf RadioButton5.Checked = True Then
            Form1.n5.BorderColor = Color.OrangeRed
            Form1.n5.BorderWidth = 10
            Form1.n5.Enabled = False
        ElseIf RadioButton6.Checked = True Then
            Form1.n6.BorderColor = Color.OrangeRed
            Form1.n6.BorderWidth = 10
            Form1.n6.Enabled = False
        ElseIf RadioButton7.Checked = True Then
            Form1.n7.BorderColor = Color.OrangeRed
            Form1.n7.BorderWidth = 10
            Form1.n7.Enabled = False
        ElseIf RadioButton8.Checked = True Then
            Form1.n8.BorderColor = Color.OrangeRed
            Form1.n8.BorderWidth = 10
            Form1.n8.Enabled = False
        ElseIf RadioButton9.Checked = True Then
            Form1.n9.BorderColor = Color.OrangeRed
            Form1.n9.BorderWidth = 10
            Form1.n9.Enabled = False
        ElseIf RadioButton10.Checked = True Then
            Form1.n10.BorderColor = Color.OrangeRed
            Form1.n10.BorderWidth = 10
            Form1.n10.Enabled = False
        Else
            MsgBox("Default Bank has been selected for you...")
            RadioButton9.Checked = True
            Form1.n9.BorderColor = Color.OrangeRed
            Form1.n9.BorderWidth = 10
            Form1.n9.Enabled = False
        End If

        If RadioButton11.Checked = True Then
            Form1.m1.BorderColor = Color.Chocolate
            Form1.m1.BorderWidth = 10
            Form1.m1.Enabled = False
        ElseIf RadioButton12.Checked = True Then
            Form1.m2.BorderColor = Color.Chocolate
            Form1.m2.BorderWidth = 10
            Form1.m2.Enabled = False
        ElseIf RadioButton13.Checked = True Then
            Form1.m3.BorderColor = Color.Chocolate
            Form1.m3.BorderWidth = 10
            Form1.m3.Enabled = False
        ElseIf RadioButton14.Checked = True Then
            Form1.m4.BorderColor = Color.Chocolate
            Form1.m4.BorderWidth = 10
            Form1.m4.Enabled = False
        ElseIf RadioButton15.Checked = True Then
            Form1.m5.BorderColor = Color.Chocolate
            Form1.m5.BorderWidth = 10
            Form1.m5.Enabled = False
        ElseIf RadioButton16.Checked = True Then
            Form1.m6.BorderColor = Color.Chocolate
            Form1.m6.BorderWidth = 10
            Form1.m6.Enabled = False
        ElseIf RadioButton17.Checked = True Then
            Form1.m7.BorderColor = Color.Chocolate
            Form1.m7.BorderWidth = 10
            Form1.m7.Enabled = False
        ElseIf RadioButton18.Checked = True Then
            Form1.m8.BorderColor = Color.Chocolate
            Form1.m8.BorderWidth = 10
            Form1.m8.Enabled = False
        ElseIf RadioButton19.Checked = True Then
            Form1.m9.BorderColor = Color.Chocolate
            Form1.m9.BorderWidth = 10
            Form1.m9.Enabled = False
        ElseIf RadioButton20.Checked = True Then
            Form1.m10.BorderColor = Color.Chocolate
            Form1.m10.BorderWidth = 10
            Form1.m10.Enabled = False
        Else
            MsgBox("Default Bank has been selected for you...")
            RadioButton17.Checked = True
            Form1.m7.BorderColor = Color.Chocolate
            Form1.m7.BorderWidth = 10
            Form1.m7.Enabled = False
        End If
        If Label2.Text = "COMPUTER" Then
            Form1.Chooser("n10")
        End If
        Me.Hide()
        Form1.Show()
    End Sub
End Class