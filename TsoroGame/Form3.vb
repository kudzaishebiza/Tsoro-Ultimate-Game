Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Form1.BackColor = Color.Gray
            Form1.Label1.ForeColor = Color.White
            Form1.GroupBox3.BackColor = Color.DimGray
            Form1.Panel1.BackColor = Color.DimGray
            Form1.GroupBox1.BackColor = Color.DimGray
            Form1.GroupBox2.BackColor = Color.DimGray
        ElseIf RadioButton2.Checked = True Then
            Form1.BackColor = Color.WhiteSmoke
            Form1.GroupBox3.BackColor = Color.Silver
            Form1.GroupBox1.BackColor = Color.Silver
            Form1.GroupBox2.BackColor = Color.Silver
            Form1.Label1.ForeColor = Color.Black
            Form1.Panel1.BackColor = Color.Silver
        ElseIf RadioButton5.Checked = True Then
            Form1.BackColor = Color.SkyBlue
            Form1.GroupBox3.BackColor = Color.Blue
            Form1.GroupBox1.BackColor = Color.Blue
            Form1.GroupBox2.BackColor = Color.Blue
            Form1.Label1.ForeColor = Color.White
            Form1.Panel1.BackColor = Color.Blue
        ElseIf RadioButton6.Checked = True Then
            Form1.BackColor = Color.Plum
            Form1.GroupBox3.BackColor = Color.Purple
            Form1.Panel1.BackColor = Color.Purple
            Form1.GroupBox1.BackColor = Color.Purple
            Form1.GroupBox2.BackColor = Color.Purple
            Form1.Label1.ForeColor = Color.White
        ElseIf RadioButton3.Checked = True Then
            Form1.BackColor = Color.AntiqueWhite
            Form1.GroupBox3.BackColor = Color.SaddleBrown
            Form1.Panel1.BackColor = Color.SaddleBrown
            Form1.GroupBox1.BackColor = Color.SaddleBrown
            Form1.GroupBox2.BackColor = Color.SaddleBrown
            Form1.Label1.ForeColor = Color.White
        Else
            Form1.BackColor = Color.LavenderBlush
            Form1.GroupBox3.BackColor = Color.Maroon
            Form1.Panel1.BackColor = Color.Maroon
            Form1.GroupBox1.BackColor = Color.Maroon
            Form1.GroupBox2.BackColor = Color.Maroon
            Form1.Label1.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Enabled = True
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RadioButton1.Checked = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RadioButton2.Checked = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RadioButton3.Checked = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        RadioButton4.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        RadioButton5.Checked = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        RadioButton6.Checked = True
    End Sub
End Class