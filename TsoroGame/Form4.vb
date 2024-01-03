Public Class Form4


    

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        Label10.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button1.Visible = False
        Label10.Visible = True
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Form1.Label11.Text = "Player 1"
        Form5.Label2.Text = "Player 1"
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.Label11.Text = "COMPUTER"
        Form5.Label2.Text = "COMPUTER"
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        Form3.Show()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        Form2.Show()
    End Sub


    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.White
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Enabled = False
        Form6.Show()
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.White
    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click
        Label10.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.White
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.White
    End Sub

    Private Sub LineShape9_Click(sender As Object, e As EventArgs) Handles LineShape9.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button1.Visible = False
        Label10.Visible = True
        If RadioButton2.Checked = True Then
            My.Computer.Audio.Stop()
            Form1.RadioButton2.Checked = True
            Form1.RadioButton1.Checked = False
        Else
            'My.Computer.Audio.Play("C:\Users\Kudzi Biza\Music\sleep away.wav")
            Form1.RadioButton2.Checked = False
            Form1.RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play("C:\Users\Kudzi Biza\Music\sleep away.wav")
    End Sub
End Class