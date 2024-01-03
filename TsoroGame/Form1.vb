Public Class Form1

    Dim holder As Integer = 0
    Dim i As Integer
    Dim stonem1 As Integer = 3
    Dim stonem2 As Integer = 3
    Dim stonem3 As Integer = 3
    Dim stonem4 As Integer = 3
    Dim stonem5 As Integer = 3
    Dim stonem6 As Integer = 3
    Dim stonem7 As Integer = 3
    Dim stonem8 As Integer = 3
    Dim stonem9 As Integer = 3
    Dim stonem10 As Integer = 3

    Public Sub Chooser(control As String)
        If control = "m1" Or control = "m2" Or control = "m3" Or control = "m4" Or control = "m5" Or control = "m6" Or control = "m7" Or control = "m8" Or control = "m9" Or control = "m10" Then
            m1.Enabled = False
            m2.Enabled = False
            m3.Enabled = False
            m4.Enabled = False
            m5.Enabled = False
            m6.Enabled = False
            m7.Enabled = False
            m8.Enabled = False
            m9.Enabled = False
            m10.Enabled = False

            If Form5.RadioButton1.Checked = True Then
            Else
                n1.Enabled = True
            End If
            If Form5.RadioButton2.Checked = True Then
            Else
                n2.Enabled = True
            End If
            If Form5.RadioButton3.Checked = True Then
            Else
                n3.Enabled = True
            End If
            If Form5.RadioButton4.Checked = True Then
            Else
                n4.Enabled = True
            End If
            If Form5.RadioButton5.Checked = True Then
            Else
                n5.Enabled = True
            End If
            If Form5.RadioButton6.Checked = True Then
            Else
                n6.Enabled = True
            End If
            If Form5.RadioButton7.Checked = True Then
            Else
                n7.Enabled = True
            End If
            If Form5.RadioButton8.Checked = True Then
            Else
                n8.Enabled = True
            End If
            If Form5.RadioButton9.Checked = True Then
            Else
                n9.Enabled = True
            End If
            If Form5.RadioButton10.Checked = True Then
            Else
                n10.Enabled = True
            End If

            'ff
        Else
            n1.Enabled = False
            n2.Enabled = False
            n3.Enabled = False
            n4.Enabled = False
            n5.Enabled = False
            n6.Enabled = False
            n7.Enabled = False
            n8.Enabled = False
            n9.Enabled = False
            n10.Enabled = False

            'mm
            If Form5.RadioButton11.Checked = True Then
            Else
                m1.Enabled = True
            End If
            If Form5.RadioButton12.Checked = True Then
            Else
                m2.Enabled = True
            End If
            If Form5.RadioButton13.Checked = True Then
            Else
                m3.Enabled = True
            End If
            If Form5.RadioButton14.Checked = True Then
            Else
                m4.Enabled = True
            End If
            If Form5.RadioButton15.Checked = True Then
            Else
                m5.Enabled = True
            End If
            If Form5.RadioButton16.Checked = True Then
            Else
                m6.Enabled = True
            End If
            If Form5.RadioButton17.Checked = True Then
            Else
                m7.Enabled = True
            End If
            If Form5.RadioButton18.Checked = True Then
            Else
                m8.Enabled = True
            End If
            If Form5.RadioButton19.Checked = True Then
            Else
                m9.Enabled = True
            End If
            If Form5.RadioButton20.Checked = True Then
            Else
                m10.Enabled = True
            End If


        End If
    End Sub

    'pic choosers
    Private Sub n1p(k As String)
        If k = "1" Then
            n1.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n1.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n1.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n1.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n1.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n1.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n1.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n1.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n1.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n1.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n1.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n1.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n1.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n1.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n1.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n1.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n1.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n1.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n1.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n1.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n1.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n1.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n1.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n1.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n1.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n1.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n1.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n1.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n1.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n1.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n1.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n2p(k As String)
        If k = "1" Then
            n2.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n2.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n2.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n2.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n2.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n2.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n2.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n2.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n2.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n2.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n2.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n2.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n2.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n2.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n2.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n2.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n2.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n2.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n2.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n2.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n2.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n2.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n2.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n2.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n2.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n2.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n2.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n2.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n2.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n2.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n2.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n3p(k As String)
        If k = "1" Then
            n3.BackgroundImage = My.Resources._1
        ElseIf k = "2" Then
            n3.BackgroundImage = My.Resources._2
        ElseIf k = "0" Then
            n3.BackgroundImage = My.Resources._0
        ElseIf k = "3" Then
            n3.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n3.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n3.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n3.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n3.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n3.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n3.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n3.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n3.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n3.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n3.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n3.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n3.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n3.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n3.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n3.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n3.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n3.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n3.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n3.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n3.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n3.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n3.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n3.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n3.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n3.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n3.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n3.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n4p(k As String)
        If k = "1" Then
            n4.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n4.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n4.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n4.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n4.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n4.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n4.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n4.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n4.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n4.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n4.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n4.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n4.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n4.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n4.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n4.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n4.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n4.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n4.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n4.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n4.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n4.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n4.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n4.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n4.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n4.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n4.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n4.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n4.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n4.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n4.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n5p(k As String)
        If k = "1" Then
            n5.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n5.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n5.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n5.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n5.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n5.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n5.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n5.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n5.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n5.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n5.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n5.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n5.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n5.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n5.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n5.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n5.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n5.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n5.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n5.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n5.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n5.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n5.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n5.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n5.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n5.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n5.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n5.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n5.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n5.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n5.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n6p(k As String)
        If k = "1" Then
            n6.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n6.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n6.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n6.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n6.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n6.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n6.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n6.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n6.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n6.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n6.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n6.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n6.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n6.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n6.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n6.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n6.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n6.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n6.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n6.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n6.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n6.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n6.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n6.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n6.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n6.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n6.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n6.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n6.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n6.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n6.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n7p(k As String)
        If k = "1" Then
            n7.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n7.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n7.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n7.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n7.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n7.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n7.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n7.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n7.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n7.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n7.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n7.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n7.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n7.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n7.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n7.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n7.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n7.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n7.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n7.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n7.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n7.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n7.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n7.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n7.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n7.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n7.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n7.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n7.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n7.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n7.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n8p(k As String)
        If k = "1" Then
            n8.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n8.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n8.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n8.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n8.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n8.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n8.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n8.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n8.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n8.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n8.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n8.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n8.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n8.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n8.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n8.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n8.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n8.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n8.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n8.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n8.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n8.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n8.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n8.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n8.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n8.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n8.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n8.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n8.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n8.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n8.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n9p(k As String)
        If k = "1" Then
            n9.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            n9.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            n9.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            n9.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n9.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n9.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n9.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n9.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n9.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n9.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n9.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n9.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n9.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n9.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n9.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n9.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n9.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n9.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n9.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n9.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n9.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n9.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n9.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n9.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n9.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n9.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n9.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n9.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n9.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n9.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n9.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub n10p(k As String)
        If k = "1" Then
            n10.BackgroundImage = My.Resources._1
        ElseIf k = "2" Then
            n10.BackgroundImage = My.Resources._2
        ElseIf k = "0" Then
            n10.BackgroundImage = My.Resources._0
        ElseIf k = "3" Then
            n10.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            n10.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            n10.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            n10.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            n10.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            n10.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            n10.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            n10.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            n10.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            n10.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            n10.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            n10.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            n10.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            n10.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            n10.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            n10.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            n10.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            n10.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            n10.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            n10.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            n10.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            n10.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            n10.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            n10.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            n10.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            n10.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            n10.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            n10.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m1p(k As String)
        If k = "1" Then
            m1.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m1.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m1.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m1.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m1.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m1.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m1.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m1.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m1.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m1.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m1.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m1.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m1.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m1.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m1.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m1.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m1.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m1.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m1.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m1.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m1.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m1.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m1.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m1.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m1.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m1.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m1.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m1.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m1.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m1.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m1.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m2p(k As String)
        If k = "1" Then
            m2.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m2.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m2.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m2.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m2.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m2.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m2.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m2.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m2.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m2.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m2.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m2.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m2.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m2.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m2.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m2.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m2.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m2.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m2.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m2.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m2.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m2.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m2.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m2.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m2.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m2.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m2.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m2.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m2.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m2.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m2.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m3p(k As String)
        If k = "1" Then
            m3.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m3.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m3.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m3.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m3.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m3.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m3.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m3.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m3.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m3.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m3.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m3.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m3.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m3.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m3.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m3.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m3.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m3.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m3.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m3.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m3.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m3.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m3.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m3.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m3.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m3.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m3.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m3.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m3.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m3.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m3.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m4p(k As String)
        If k = "1" Then
            m4.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m4.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m4.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m4.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m4.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m4.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m4.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m4.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m4.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m4.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m4.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m4.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m4.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m4.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m4.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m4.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m4.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m4.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m4.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m4.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m4.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m4.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m4.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m4.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m4.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m4.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m4.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m4.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m4.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m4.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m4.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m5p(k As String)
        If k = "1" Then
            m5.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m5.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m5.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m5.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m5.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m5.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m5.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m5.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m5.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m5.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m5.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m5.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m5.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m5.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m5.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m5.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m5.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m5.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m5.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m5.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m5.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m5.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m5.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m5.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m5.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m5.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m5.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m5.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m5.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m5.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m5.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m6p(k As String)
        If k = "1" Then
            m6.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m6.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m6.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m6.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m6.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m6.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m6.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m6.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m6.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m6.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m6.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m6.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m6.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m6.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m6.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m6.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m6.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m6.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m6.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m6.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m6.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m6.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m6.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m6.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m6.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m6.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m6.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m6.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m6.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m6.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m6.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m7p(k As String)
        If k = "1" Then
            m7.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m7.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m7.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m7.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m7.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m7.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m7.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m7.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m7.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m7.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m7.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m7.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m7.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m7.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m7.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m7.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m7.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m7.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m7.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m7.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m7.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m7.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m7.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m7.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m7.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m7.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m7.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m7.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m7.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m7.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m7.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m8p(k As String)
        If k = "1" Then
            m8.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m8.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m8.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m8.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m8.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m8.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m8.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m8.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m8.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m8.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m8.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m8.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m8.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m8.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m8.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m8.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m8.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m8.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m8.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m8.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m8.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m8.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m8.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m8.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m8.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m8.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m8.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m8.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m8.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m8.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m8.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m9p(k As String)
        If k = "1" Then
            m9.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m9.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m9.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m9.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m9.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m9.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m9.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m9.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m9.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m9.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m9.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m9.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m9.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m9.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m9.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m9.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m9.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m9.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m9.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m9.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m9.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m9.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m9.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m9.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m9.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m9.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m9.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m9.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m9.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m9.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m9.BackgroundImage = My.Resources._30
        End If
    End Sub

    Private Sub m10p(k As String)
        If k = "1" Then
            m10.BackgroundImage = My.Resources._1
        ElseIf k = "0" Then
            m10.BackgroundImage = My.Resources._0
        ElseIf k = "2" Then
            m10.BackgroundImage = My.Resources._2
        ElseIf k = "3" Then
            m10.BackgroundImage = My.Resources._3
        ElseIf k = "4" Then
            m10.BackgroundImage = My.Resources._4
        ElseIf k = "5" Then
            m10.BackgroundImage = My.Resources._5
        ElseIf k = "6" Then
            m10.BackgroundImage = My.Resources._6
        ElseIf k = "7" Then
            m10.BackgroundImage = My.Resources._7
        ElseIf k = "8" Then
            m10.BackgroundImage = My.Resources._8
        ElseIf k = "9" Then
            m10.BackgroundImage = My.Resources._9
        ElseIf k = "10" Then
            m10.BackgroundImage = My.Resources._10
        ElseIf k = "11" Then
            m10.BackgroundImage = My.Resources._11
        ElseIf k = "12" Then
            m10.BackgroundImage = My.Resources._12
        ElseIf k = "13" Then
            m10.BackgroundImage = My.Resources._13
        ElseIf k = "14" Then
            m10.BackgroundImage = My.Resources._14
        ElseIf k = "15" Then
            m10.BackgroundImage = My.Resources._15
        ElseIf k = "16" Then
            m10.BackgroundImage = My.Resources._16
        ElseIf k = "17" Then
            m10.BackgroundImage = My.Resources._17
        ElseIf k = "18" Then
            m10.BackgroundImage = My.Resources._18
        ElseIf k = "19" Then
            m10.BackgroundImage = My.Resources._19
        ElseIf k = "20" Then
            m10.BackgroundImage = My.Resources._20
        ElseIf k = "21" Then
            m10.BackgroundImage = My.Resources._21
        ElseIf k = "22" Then
            m10.BackgroundImage = My.Resources._22
        ElseIf k = "23" Then
            m10.BackgroundImage = My.Resources._23
        ElseIf k = "24" Then
            m10.BackgroundImage = My.Resources._24
        ElseIf k = "25" Then
            m10.BackgroundImage = My.Resources._25
        ElseIf k = "26" Then
            m10.BackgroundImage = My.Resources._26
        ElseIf k = "27" Then
            m10.BackgroundImage = My.Resources._27
        ElseIf k = "28" Then
            m10.BackgroundImage = My.Resources._28
        ElseIf k = "29" Then
            m10.BackgroundImage = My.Resources._29
        ElseIf k = "30" Then
            m10.BackgroundImage = My.Resources._30
        End If
    End Sub
    'choosers

    Private Sub Computer()
        Dim rnd As New Random
        Dim play As Integer
        play = rnd.Next(1, 10)
        MsgBox("Computer's Turn...")
        For Me.i = 0 To 1000
            play = rnd.Next(1, 10)
            If play = 1 Then
                If stonen1 = 0 Or Form5.RadioButton1.Checked = True Then
                    Continue For
                Else
                    n1_Click()
                    Exit For
                End If
            ElseIf play = 2 Then
                If stonen2 = 0 Or Form5.RadioButton2.Checked = True Then
                    Continue For
                Else
                    n2_Click()
                    Exit For
                End If
            ElseIf play = 3 Then
                If stonen3 = 0 Or Form5.RadioButton3.Checked = True Then
                    Continue For
                Else
                    n3_Click()
                    Exit For
                End If
            ElseIf play = 4 Then
                If stonen4 = 0 Or Form5.RadioButton4.Checked = True Then
                    Continue For
                Else
                    n4_Click()
                    Exit For
                End If
            ElseIf play = 5 Then
                If stonen5 = 0 Or Form5.RadioButton5.Checked = True Then
                    Continue For
                Else
                    n5_Click()
                    Exit For
                End If
            ElseIf play = 6 Then
                If stonen6 = 0 Or Form5.RadioButton6.Checked = True Then
                    Continue For
                Else
                    n6_Click()
                    Exit For
                End If
            ElseIf play = 7 Then
                If stonen7 = 0 Or Form5.RadioButton7.Checked = True Then
                    Continue For
                Else
                    n7_Click()
                    Exit For
                End If
            ElseIf play = 8 Then
                If stonen8 = 0 Or Form5.RadioButton8.Checked = True Then
                    Continue For
                Else
                    n8_Click()
                    Exit For
                End If
            ElseIf play = 9 Then
                If stonen9 = 0 Or Form5.RadioButton9.Checked = True Then
                    Continue For
                Else
                    n9_Click()
                    Exit For
                End If
            ElseIf play = 10 Then
                If stonen10 = 0 Or Form5.RadioButton10.Checked = True Then
                    Continue For
                Else
                    n10_Click()
                    Exit For
                End If

            End If
        Next
        MsgBox("Your Turn...")
    End Sub


    'THESE CONTROLS ARE FOR PLAYER 2 UP TILL THE NEXT COMMENT IN THIS CONTEXT!!!!


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If GroupBox3.Visible = False Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False

        End If
    End Sub

    Private Sub m10_Click(sender As Object, e As EventArgs) Handles m10.Click
        If stonem10 <> 0 Then
            holder = holder + stonem10
            Label16.Text = holder.ToString
            stonem10 = 0
            m10.BackgroundImage = My.Resources.hand
            m10.Update()
            m10.Update()
            m10.Update()
            m10p(stonem10.ToString)
            m10.Update()
            For Me.i = 0 To 1000000

                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                    Label16.Text = holder.ToString
                End If
                'Timer(2)
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString
                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'time()
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    'passer
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If

            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m2_Click(sender As Object, e As EventArgs) Handles m2.Click
        If stonem2 <> 0 Then
            holder = holder + stonem2
            stonem2 = 0
            m2.BackgroundImage = My.Resources.hand
            m2.Update()
            m2.Update()
            m2.Update()
            m2p(stonem2.ToString)
            m2.Update()
            For Me.i = 0 To 1000000
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If


                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                Label9.Text = stonem7.ToString
                m7.Update()
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        holder = holder + stonem2
                        stonem2 = 0
                        m2p(stonem2.ToString)

                    End If
                    m2.Update()
                End If

            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m3_Click(sender As Object, e As EventArgs) Handles m3.Click
        If stonem3 <> 0 Then
            holder = holder + stonem3
            stonem3 = 0
            m3.BackgroundImage = My.Resources.hand
            m3.Update()
            m3.Update()
            m3.Update()
            m3p(stonem3.ToString)
            m3.Update()
            For Me.i = 0 To 1000000

                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If


            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m4_Click(sender As Object, e As EventArgs) Handles m4.Click
        If stonem4 <> 0 Then
            holder = holder + stonem4
            stonem4 = 0
            m4.BackgroundImage = My.Resources.hand
            m4.Update()
            m4.Update()
            m4.Update()
            m4p(stonem4.ToString)
            m4.Update()
            For Me.i = 0 To 1000000

                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m5_Click(sender As Object, e As EventArgs) Handles m5.Click
        If stonem5 <> 0 Then
            holder = holder + stonem5
            stonem5 = 0
            m5.BackgroundImage = My.Resources.hand
            m5.Update()
            m5.Update()
            m5.Update()
            m5p(stonem5.ToString)
            m5.Update()
            For Me.i = 0 To 1000000

                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m6_Click(sender As Object, e As EventArgs) Handles m6.Click
        If stonem6 <> 0 Then
            holder = holder + stonem6
            stonem6 = 0
            m6.BackgroundImage = My.Resources.hand
            m6.Update()
            m6.Update()
            m6.Update()
            m6p(stonem6.ToString)
            m6.Update()
            For Me.i = 0 To 1000000

                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m7_Click(sender As Object, e As EventArgs) Handles m7.Click
        If stonem7 <> 0 Then
            holder = holder + stonem7
            stonem7 = 0
            m7.BackgroundImage = My.Resources.hand
            m7.Update()
            m7.Update()
            m7.Update()
            m7p(stonem7.ToString)
            m7.Update()
            For Me.i = 0 To 1000000
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8

            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m8_Click(sender As Object, e As EventArgs) Handles m8.Click
        If stonem8 <> 0 Then
            holder = holder + stonem8
            stonem8 = 0
            m8.BackgroundImage = My.Resources.hand
            m8.Update()
            m8.Update()
            m8.Update()
            m8p(stonem8.ToString)
            m8.Update()
            For Me.i = 0 To 1000000

                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m9_Click(sender As Object, e As EventArgs) Handles m9.Click
        If stonem9 <> 0 Then
            holder = holder + stonem9
            stonem9 = 0
            m9.BackgroundImage = My.Resources.hand
            m9.Update()
            m9.Update()
            m9.Update()
            m9p(stonem9.ToString)
            m9.Update()
            For Me.i = 0 To 1000000

                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If
                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If

            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub m1_Click(sender As Object, e As EventArgs) Handles m1.Click
        If stonem1 <> 0 Then
            holder = holder + stonem1
            stonem1 = 0
            m1.BackgroundImage = My.Resources.hand
            m1.Update()
            m1.Update()
            m1.Update()
            m1p(stonem1.ToString)
            m1.Update()
            For Me.i = 0 To 1000000

                'for shape m2
                If m2.BorderWidth = 10 Then
                    'for shape m2 bank
                    If holder <> 1 Then

                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        stonem2 = stonem2 + 1
                        m2p(stonem2.ToString)
                        If stonem2 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m2.Update()
                    Label9.Text = stonem2.ToString

                Else
                    If holder <> 1 Then
                        stonem2 = stonem2 + 1
                        holder = holder - 1
                        m2p(stonem2.ToString)
                    Else
                        If stonem2 <> 0 Then
                            holder = holder + stonem2
                            stonem2 = 0
                            m2p(stonem2.ToString)
                        End If
                    End If
                    m2.Update()
                End If
                'for shape m3
                If m3.BorderWidth = 10 Then
                    'for shape m3 bank
                    If holder <> 1 Then

                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        stonem3 = stonem3 + 1
                        m3p(stonem3.ToString)
                        If stonem3 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m3.Update()
                    Label9.Text = stonem3.ToString

                Else
                    If holder <> 1 Then
                        stonem3 = stonem3 + 1
                        holder = holder - 1
                        m3p(stonem3.ToString)
                    Else
                        If stonem3 <> 0 Then
                            holder = holder + stonem3
                            stonem3 = 0
                            m3p(stonem3.ToString)
                        End If
                    End If
                    m3.Update()
                End If
                'for shape m4
                If m4.BorderWidth = 10 Then
                    'for shape m4 bank
                    If holder <> 1 Then

                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        stonem4 = stonem4 + 1
                        m4p(stonem4.ToString)
                        If stonem4 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m4.Update()
                    Label9.Text = stonem4.ToString

                Else
                    If holder <> 1 Then
                        stonem4 = stonem4 + 1
                        holder = holder - 1
                        m4p(stonem4.ToString)
                    Else
                        If stonem4 <> 0 Then
                            holder = holder + stonem4
                            stonem4 = 0
                            m4p(stonem4.ToString)

                        End If
                    End If
                    m4.Update()
                End If
                'for shape m5
                If m5.BorderWidth = 10 Then
                    'for shape m5 bank
                    If holder <> 1 Then

                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        stonem5 = stonem5 + 1
                        m5p(stonem5.ToString)
                        If stonem5 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m5.Update()
                    Label9.Text = stonem5.ToString

                Else
                    If holder <> 1 Then
                        stonem5 = stonem5 + 1
                        holder = holder - 1
                        m5p(stonem5.ToString)
                    Else
                        If stonem5 <> 0 Then
                            holder = holder + stonem5
                            stonem5 = 0
                            m5p(stonem5.ToString)
                        End If
                    End If
                    m5.Update()
                End If
                'for shape m6
                If m6.BorderWidth = 10 Then
                    'for shape m6 bank
                    If holder <> 1 Then

                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        stonem6 = stonem6 + 1
                        m6p(stonem6.ToString)
                        If stonem6 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m6.Update()
                    Label9.Text = stonem6.ToString

                Else
                    If holder <> 1 Then
                        stonem6 = stonem6 + 1
                        holder = holder - 1
                        m6p(stonem6.ToString)
                    Else
                        If stonem6 <> 0 Then
                            holder = holder + stonem6
                            stonem6 = 0
                            m6p(stonem6.ToString)

                        End If
                    End If
                    m6.Update()
                End If
                'for shape m7
                If m7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        stonem7 = stonem7 + 1
                        m7p(stonem7.ToString)
                        If stonem7 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m7.Update()
                    Label9.Text = stonem7.ToString

                Else
                    If holder <> 1 Then
                        stonem7 = stonem7 + 1
                        holder = holder - 1
                        m7p(stonem7.ToString)
                    Else
                        If stonem7 <> 0 Then
                            holder = holder + stonem7
                            stonem7 = 0
                            m7p(stonem7.ToString)

                        End If
                    End If
                    m7.Update()
                End If
                m7.Update()
                Label9.Text = stonem7.ToString
                'for shape m8
                If m8.BorderWidth = 10 Then
                    'for shape m8 bank
                    If holder <> 1 Then

                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        stonem8 = stonem8 + 1
                        m8p(stonem8.ToString)
                        If stonem8 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m8.Update()
                    Label9.Text = stonem8.ToString

                Else
                    If holder <> 1 Then
                        stonem8 = stonem8 + 1
                        holder = holder - 1
                        m8p(stonem8.ToString)
                    Else
                        If stonem8 <> 0 Then
                            holder = holder + stonem8
                            stonem8 = 0
                            m8p(stonem8.ToString)

                        End If
                    End If
                    m8.Update()
                End If
                'for shape m9
                If m9.BorderWidth = 10 Then
                    'for shape m9 bank
                    If holder <> 1 Then

                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        stonem9 = stonem9 + 1
                        m9p(stonem9.ToString)
                        If stonem9 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m9.Update()
                    Label9.Text = stonem9.ToString

                Else
                    If holder <> 1 Then
                        stonem9 = stonem9 + 1
                        holder = holder - 1
                        m9p(stonem9.ToString)
                    Else
                        If stonem9 <> 0 Then
                            holder = holder + stonem9
                            stonem9 = 0
                            m9p(stonem9.ToString)

                        End If
                    End If
                    m9.Update()
                End If
                'for shape m10
                If m10.BorderWidth = 10 Then
                    'for shape m10 bank
                    If holder <> 1 Then

                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        stonem10 = stonem10 + 1
                        m10p(stonem10.ToString)
                        If stonem10 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m10.Update()
                    Label9.Text = stonem10.ToString

                Else
                    If holder <> 1 Then
                        stonem10 = stonem10 + 1
                        holder = holder - 1
                        m10p(stonem10.ToString)
                    Else
                        If stonem10 <> 0 Then
                            holder = holder + stonem10
                            stonem10 = 0
                            m10p(stonem10.ToString)

                        End If
                    End If
                    m10.Update()
                End If
                'for shape m1
                If m1.BorderWidth = 10 Then
                    'for shape m1 bank
                    If holder <> 1 Then

                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        stonem1 = stonem1 + 1
                        m1p(stonem1.ToString)
                        If stonem1 = 30 Then
                            MsgBox("Congratulations Player 2, you've won. Press OK to start a new game...!")
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    m1.Update()
                    Label9.Text = stonem1.ToString

                Else
                    If holder <> 1 Then
                        stonem1 = stonem1 + 1
                        holder = holder - 1
                        m1p(stonem1.ToString)
                    Else
                        If stonem1 <> 0 Then
                            holder = holder + stonem1
                            stonem1 = 0
                            m1p(stonem1.ToString)

                        End If
                    End If
                    m1.Update()
                End If

            Next
            holder = 0
            'If stonem7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonem1 = 3 And stonem2 = 3 And stonem3 = 3 And stonem4 = 3 And stonem5 = 3 And stonem6 = 3 And stonem7 = 3 And stonem8 = 3 And stonem9 = 3 And stonem10 = 3 Then
            Else : Chooser("m10")
            End If
        End If
        If Label11.Text = "COMPUTER" Then
            Computer()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label4_Click()

        'vvvvv
        
        'vvvvv
        n1.BorderWidth = 5
        n1.BorderColor = Color.Red
        n1.Enabled = True
        n2.BorderWidth = 5
        n2.BorderColor = Color.Red
        n2.Enabled = True
        n3.BorderWidth = 5
        n3.BorderColor = Color.Red
        n3.Enabled = True
        n4.BorderWidth = 5
        n4.BorderColor = Color.Red
        n4.Enabled = True
        n5.BorderWidth = 5
        n5.BorderColor = Color.Red
        n5.Enabled = True
        n6.BorderWidth = 5
        n6.BorderColor = Color.Red
        n6.Enabled = True
        n7.BorderWidth = 5
        n7.BorderColor = Color.Red
        n7.Enabled = True
        n8.BorderWidth = 5
        n8.BorderColor = Color.Red
        n8.Enabled = True
        n9.BorderWidth = 5
        n9.BorderColor = Color.Red
        n9.Enabled = True
        n10.BorderWidth = 5
        n10.BorderColor = Color.Red
        n10.Enabled = True
        m1.BorderWidth = 5
        m1.BorderColor = Color.Gray
        m1.Enabled = True
        m2.BorderWidth = 5
        m2.BorderColor = Color.Gray
        m2.Enabled = True
        m3.BorderWidth = 5
        m3.BorderColor = Color.Gray
        m3.Enabled = True
        m4.BorderWidth = 5
        m4.BorderColor = Color.Gray
        m4.Enabled = True
        m5.BorderWidth = 5
        m5.BorderColor = Color.Gray
        m5.Enabled = True
        m6.BorderWidth = 5
        m6.BorderColor = Color.Gray
        m6.Enabled = True
        m7.BorderWidth = 5
        m7.BorderColor = Color.Gray
        m7.Enabled = True
        m8.BorderWidth = 5
        m8.BorderColor = Color.Gray
        m8.Enabled = True
        m9.BorderWidth = 5
        m9.BorderColor = Color.Gray
        m9.Enabled = True
        m10.BorderWidth = 5
        m10.BorderColor = Color.Gray
        m10.Enabled = True
        Form5.RadioButton1.Checked = False
        Form5.RadioButton2.Checked = False
        Form5.RadioButton3.Checked = False
        Form5.RadioButton4.Checked = False
        Form5.RadioButton5.Checked = False
        Form5.RadioButton6.Checked = False
        Form5.RadioButton7.Checked = False
        Form5.RadioButton8.Checked = False
        Form5.RadioButton9.Checked = False
        Form5.RadioButton10.Checked = False
        Form5.RadioButton11.Checked = False
        Form5.RadioButton12.Checked = False
        Form5.RadioButton13.Checked = False
        Form5.RadioButton14.Checked = False
        Form5.RadioButton15.Checked = False
        Form5.RadioButton16.Checked = False
        Form5.RadioButton17.Checked = False
        Form5.RadioButton18.Checked = False
        Form5.RadioButton19.Checked = False
        Form5.RadioButton20.Checked = False

        Form4.Show()
        Me.Hide()
        GroupBox3.Visible = False

    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.White
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.White
    End Sub
    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.Black
    End Sub

    Private Sub Label4_Click() Handles Label4.Click
        GroupBox3.Visible = False
        m1.Enabled = True
        m2.Enabled = True
        m3.Enabled = True
        m4.Enabled = True
        m5.Enabled = True
        m6.Enabled = True
        m7.Enabled = True
        m8.Enabled = True
        m9.Enabled = True
        m10.Enabled = True
        n1.Enabled = True
        n2.Enabled = True
        n3.Enabled = True
        n4.Enabled = True
        n5.Enabled = True
        n6.Enabled = True
        n7.Enabled = True
        n8.Enabled = True
        n9.Enabled = True
        n10.Enabled = True

        If Form5.RadioButton1.Checked = True Then
            n1.BorderColor = Color.OrangeRed
            n1.BorderWidth = 10
            n1.Enabled = False
        ElseIf Form5.RadioButton2.Checked = True Then
            n2.BorderColor = Color.OrangeRed
            n2.BorderWidth = 10
            n2.Enabled = False
        ElseIf Form5.RadioButton3.Checked = True Then
            n3.BorderColor = Color.OrangeRed
            n3.BorderWidth = 10
            n3.Enabled = False
        ElseIf Form5.RadioButton4.Checked = True Then
            n4.BorderColor = Color.OrangeRed
            n4.BorderWidth = 10
            n4.Enabled = False
        ElseIf Form5.RadioButton5.Checked = True Then
            n5.BorderColor = Color.OrangeRed
            n5.BorderWidth = 10
            n5.Enabled = False
        ElseIf Form5.RadioButton6.Checked = True Then
            n6.BorderColor = Color.OrangeRed
            n6.BorderWidth = 10
            n6.Enabled = False
        ElseIf Form5.RadioButton7.Checked = True Then
            n7.BorderColor = Color.OrangeRed
            n7.BorderWidth = 10
            n7.Enabled = False
        ElseIf Form5.RadioButton8.Checked = True Then
            n8.BorderColor = Color.OrangeRed
            n8.BorderWidth = 10
            n8.Enabled = False
        ElseIf Form5.RadioButton9.Checked = True Then
            n9.BorderColor = Color.OrangeRed
            n9.BorderWidth = 10
            n9.Enabled = False
        ElseIf Form5.RadioButton10.Checked = True Then
            n10.BorderColor = Color.OrangeRed
            n10.BorderWidth = 10
            n10.Enabled = False
        End If

        If Form5.RadioButton11.Checked = True Then
            m1.BorderColor = Color.Chocolate
            m1.BorderWidth = 10
            m1.Enabled = False
        ElseIf Form5.RadioButton12.Checked = True Then
            m2.BorderColor = Color.Chocolate
            m2.BorderWidth = 10
            m2.Enabled = False
        ElseIf Form5.RadioButton13.Checked = True Then
            m3.BorderColor = Color.Chocolate
            m3.BorderWidth = 10
            m3.Enabled = False
        ElseIf Form5.RadioButton14.Checked = True Then
            m4.BorderColor = Color.Chocolate
            m4.BorderWidth = 10
            m4.Enabled = False
        ElseIf Form5.RadioButton15.Checked = True Then
            m5.BorderColor = Color.Chocolate
            m5.BorderWidth = 10
            m5.Enabled = False
        ElseIf Form5.RadioButton16.Checked = True Then
            m6.BorderColor = Color.Chocolate
            m6.BorderWidth = 10
            m6.Enabled = False
        ElseIf Form5.RadioButton17.Checked = True Then
            m7.BorderColor = Color.Chocolate
            m7.BorderWidth = 10
            m7.Enabled = False
        ElseIf Form5.RadioButton18.Checked = True Then
            m8.BorderColor = Color.Chocolate
            m8.BorderWidth = 10
            m8.Enabled = False
        ElseIf Form5.RadioButton19.Checked = True Then
            m9.BorderColor = Color.Chocolate
            m9.BorderWidth = 10
            m9.Enabled = False
        ElseIf Form5.RadioButton20.Checked = True Then
            m10.BorderColor = Color.Chocolate
            m10.BorderWidth = 10
            m10.Enabled = False
        End If

        If Form5.Label2.Text = "COMPUTER" Then
            Chooser("n10")
        End If

        stonem1 = 3
        m1p(stonem1.ToString)
        stonem2 = 3
        m2p(stonem2.ToString)
        stonem3 = 3
        m3p(stonem3.ToString)
        stonem4 = 3
        m4p(stonem4.ToString)
        stonem5 = 3
        m5p(stonem5.ToString)
        stonem6 = 3
        m6p(stonem6.ToString)
        stonem7 = 3
        m7p(stonem7.ToString)
        stonem8 = 3
        m8p(stonem8.ToString)
        stonem9 = 3
        m9p(stonem9.ToString)
        stonem10 = 3
        m10p(stonem10.ToString)
        Label9.Text = "3"

        stonen1 = 3
        n1p(stonen1.ToString)
        stonen2 = 3
        n2p(stonen2.ToString)
        stonen3 = 3
        n3p(stonen3.ToString)
        stonen4 = 3
        n4p(stonen4.ToString)
        stonen5 = 3
        n5p(stonen5.ToString)
        stonen6 = 3
        n6p(stonen6.ToString)
        stonen7 = 3
        n7p(stonen7.ToString)
        stonen8 = 3
        n8p(stonen8.ToString)
        stonen9 = 3
        n9p(stonen9.ToString)
        stonen10 = 3
        n10p(stonen10.ToString)
        Label8.Text = "3"
    End Sub
    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
    End Sub
    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Enabled = False
        Form3.Show()
        GroupBox3.Visible = False
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.White
    End Sub
    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Black
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub m1_MouseLeave(sender As Object, e As EventArgs) Handles m1.MouseLeave
        m1.BorderColor = Color.Gray
    End Sub









    'THESE CONTROLS ARE FOR PLAYER 1

    Dim stonen1 As Integer = 3
    Dim stonen2 As Integer = 3
    Dim stonen3 As Integer = 3
    Dim stonen4 As Integer = 3
    Dim stonen5 As Integer = 3
    Dim stonen6 As Integer = 3
    Dim stonen7 As Integer = 3
    Dim stonen8 As Integer = 3
    Dim stonen9 As Integer = 3
    Dim stonen10 As Integer = 3

    'gfgherghrugfhirgtrgrnbnjbgknbjnfbkjfrnblrknrjtkrnkjbnkjgnfkjgntfjnfkjgnhklfnfkllgnbhlkdnl
    Private Sub n10_Click() Handles n10.Click
        If stonen10 <> 0 Then
            holder = holder + stonen10
            Label16.Text = holder.ToString
            stonen10 = 0
            n10.BackgroundImage = My.Resources.handn
            n10.Update()
            n10.Update()
            n10.Update()
            n10p(stonen10.ToString)
            n10.Update()
            For Me.i = 0 To 1000000

                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    Label8.Text = stonen1.ToString
                    n1.Update()
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If

                    Label16.Text = holder.ToString
                    n1.Update()
                End If
                'Timer(2)
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen2.ToString
                    n2.Update()
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'time()
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen3.ToString
                    n3.Update()
                Else
                    'passer
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen4.ToString
                    n4.Update()
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen5.ToString
                    n5.Update()
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen6.ToString
                    n6.Update()
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen7.ToString
                    n7.Update()
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen8.ToString
                    n8.Update()
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen9.ToString
                    n9.Update()
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen10.ToString
                    n10.Update()
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If

            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n2_Click() Handles n2.Click
        If stonen2 <> 0 Then
            holder = holder + stonen2
            stonen2 = 0
            n2.BackgroundImage = My.Resources.handn
            n2.Update()
            n2.Update()
            n2.Update()
            n2p(stonen2.ToString)
            n2.Update()
            For Me.i = 0 To 1000000
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen3.ToString
                    n3.Update()
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If


                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen4.ToString
                    n4.Update()
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen5.ToString
                    n5.Update()
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen6.ToString
                    n6.Update()
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen7.ToString
                    n7.Update()
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                Label8.Text = stonen7.ToString
                n7.Update()
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen8.ToString
                    n8.Update()
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen9.ToString
                    n9.Update()
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen10.ToString
                    n10.Update()
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen1.ToString
                    n1.Update()
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen2.ToString
                    n2.Update()
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        holder = holder + stonen2
                        stonen2 = 0
                        n2p(stonen2.ToString)

                    End If
                    n2.Update()
                End If

            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n3_Click() Handles n3.Click
        If stonen3 <> 0 Then
            holder = holder + stonen3
            stonen3 = 0
            n3.BackgroundImage = My.Resources.handn
            n3.Update()
            n3.Update()
            n3.Update()
            n3p(stonen3.ToString)
            n3.Update()
            For Me.i = 0 To 1000000

                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen4.ToString
                    n4.Update()
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen5.ToString
                    n5.Update()
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen6.ToString
                    n6.Update()
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen7.ToString
                    n7.Update()
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen8.ToString
                    n8.Update()
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen9.ToString
                    n9.Update()
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen10.ToString
                    n10.Update()
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen1.ToString
                    n1.Update()
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen2.ToString
                    n2.Update()
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen3.ToString
                    n3.Update()
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If


            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n4_Click() Handles n4.Click
        If stonen4 <> 0 Then
            holder = holder + stonen4
            stonen4 = 0
            n4.BackgroundImage = My.Resources.handn
            n4.Update()
            n4.Update()
            n4.Update()
            n4p(stonen4.ToString)
            n4.Update()
            For Me.i = 0 To 1000000

                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen5.ToString
                    n5.Update()
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen6.ToString
                    n6.Update()
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen7.ToString
                    n7.Update()
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen8.ToString
                    n8.Update()
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen9.ToString
                    n9.Update()
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen10.ToString
                    n10.Update()
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen1.ToString
                    n1.Update()
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen2.ToString
                    n2.Update()
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen3.ToString
                    n3.Update()
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen4.ToString
                    n4.Update()
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n5_Click() Handles n5.Click
        If stonen5 <> 0 Then
            holder = holder + stonen5
            stonen5 = 0
            n5.BackgroundImage = My.Resources.handn
            n5.Update()
            n5.Update()
            n5.Update()
            n5p(stonen5.ToString)
            n5.Update()
            For Me.i = 0 To 1000000

                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen6.ToString
                    n6.Update()
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen7.ToString
                    n7.Update()
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen8.ToString
                    n8.Update()
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen9.ToString
                    n9.Update()
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If

                    Label8.Text = stonen10.ToString
                    n10.Update()
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n6_Click() Handles n6.Click
        If stonen6 <> 0 Then
            holder = holder + stonen6
            stonen6 = 0
            n6.BackgroundImage = My.Resources.handn
            n6.Update()
            n6.Update()
            n6.Update()
            n6p(stonen6.ToString)
            n6.Update()
            For Me.i = 0 To 1000000

                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n7.Update()
                    Label8.Text = stonen7.ToString
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n8.Update()
                    Label8.Text = stonen8.ToString
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n9.Update()
                    Label8.Text = stonen9.ToString
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n10.Update()
                    Label8.Text = stonen10.ToString
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n6.Update()
                    Label8.Text = stonen6.ToString
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n7_Click() Handles n7.Click
        If stonen7 <> 0 Then
            holder = holder + stonen7
            stonen7 = 0
            n7.BackgroundImage = My.Resources.handn
            n7.Update()
            n7.Update()
            n7.Update()
            n7p(stonen7.ToString)
            n7.Update()
            For Me.i = 0 To 1000000
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n8.Update()
                    Label8.Text = stonen8.ToString
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n9.Update()
                    Label8.Text = stonen9.ToString
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n10.Update()
                    Label8.Text = stonen10.ToString
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n6.Update()
                    Label8.Text = stonen6.ToString
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n7.Update()
                    Label8.Text = stonen7.ToString
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8

            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n8_Click() Handles n8.Click
        If stonen8 <> 0 Then
            holder = holder + stonen8
            stonen8 = 0
            n8.BackgroundImage = My.Resources.handn
            n8.Update()
            n8.Update()
            n8.Update()
            n8p(stonen8.ToString)
            m8.Update()
            For Me.i = 0 To 1000000

                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n9.Update()
                    Label8.Text = stonen9.ToString
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n10.Update()
                    Label8.Text = stonen10.ToString
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n6.Update()
                    Label8.Text = stonen6.ToString
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n7.Update()
                    Label8.Text = stonen7.ToString
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n8.Update()
                    Label8.Text = stonen8.ToString
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If

            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n9_Click() Handles n9.Click
        If stonen9 <> 0 Then
            holder = holder + stonen9
            stonen9 = 0
            n9.BackgroundImage = My.Resources.handn
            n9.Update()
            n9.Update()
            n9.Update()
            n9p(stonen9.ToString)
            n9.Update()
            For Me.i = 0 To 1000000

                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n10.Update()
                    Label8.Text = stonen10.ToString
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If
                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n6.Update()
                    Label8.Text = stonen6.ToString
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n7.Update()
                    Label8.Text = stonen7.ToString
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n8.Update()
                    Label8.Text = stonen8.ToString
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n9.Update()
                    Label8.Text = stonen9.ToString
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If

            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub

    Private Sub n1_Click() Handles n1.Click
        If stonen1 <> 0 Then
            holder = holder + stonen1
            stonen1 = 0
            n1.BackgroundImage = My.Resources.handn
            n1.Update()
            n1.Update()
            n1.Update()
            n1p(stonen1.ToString)
            n1.Update()
            For Me.i = 0 To 1000000

                'for shape n2
                If n2.BorderWidth = 10 Then
                    'for shape n2 bank
                    If holder <> 1 Then

                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        stonen2 = stonen2 + 1
                        n2p(stonen2.ToString)
                        If stonen2 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n2.Update()
                    Label8.Text = stonen2.ToString
                Else
                    If holder <> 1 Then
                        stonen2 = stonen2 + 1
                        holder = holder - 1
                        n2p(stonen2.ToString)
                    Else
                        If stonen2 <> 0 Then
                            holder = holder + stonen2
                            stonen2 = 0
                            n2p(stonen2.ToString)
                        End If
                    End If
                    n2.Update()
                End If
                'for shape n3
                If n3.BorderWidth = 10 Then
                    'for shape n3 bank
                    If holder <> 1 Then

                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        stonen3 = stonen3 + 1
                        n3p(stonen3.ToString)
                        If stonen3 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n3.Update()
                    Label8.Text = stonen3.ToString
                Else
                    If holder <> 1 Then
                        stonen3 = stonen3 + 1
                        holder = holder - 1
                        n3p(stonen3.ToString)
                    Else
                        If stonen3 <> 0 Then
                            holder = holder + stonen3
                            stonen3 = 0
                            n3p(stonen3.ToString)
                        End If
                    End If
                    n3.Update()
                End If
                'for shape n4
                If n4.BorderWidth = 10 Then
                    'for shape n4 bank
                    If holder <> 1 Then

                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        stonen4 = stonen4 + 1
                        n4p(stonen4.ToString)
                        If stonen4 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n4.Update()
                    Label8.Text = stonen4.ToString
                Else
                    If holder <> 1 Then
                        stonen4 = stonen4 + 1
                        holder = holder - 1
                        n4p(stonen4.ToString)
                    Else
                        If stonen4 <> 0 Then
                            holder = holder + stonen4
                            stonen4 = 0
                            n4p(stonen4.ToString)

                        End If
                    End If
                    n4.Update()
                End If
                'for shape n5
                If n5.BorderWidth = 10 Then
                    'for shape n5 bank
                    If holder <> 1 Then

                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        stonen5 = stonen5 + 1
                        n5p(stonen5.ToString)
                        If stonen5 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n5.Update()
                    Label8.Text = stonen5.ToString
                Else
                    If holder <> 1 Then
                        stonen5 = stonen5 + 1
                        holder = holder - 1
                        n5p(stonen5.ToString)
                    Else
                        If stonen5 <> 0 Then
                            holder = holder + stonen5
                            stonen5 = 0
                            n5p(stonen5.ToString)
                        End If
                    End If
                    n5.Update()
                End If
                'for shape n6
                If n6.BorderWidth = 10 Then
                    'for shape n6 bank
                    If holder <> 1 Then

                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        stonen6 = stonen6 + 1
                        n6p(stonen6.ToString)
                        If stonen6 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n6.Update()
                    Label8.Text = stonen6.ToString
                Else
                    If holder <> 1 Then
                        stonen6 = stonen6 + 1
                        holder = holder - 1
                        n6p(stonen6.ToString)
                    Else
                        If stonen6 <> 0 Then
                            holder = holder + stonen6
                            stonen6 = 0
                            n6p(stonen6.ToString)

                        End If
                    End If
                    n6.Update()
                End If
                'for shape n7
                If n7.BorderWidth = 10 Then
                    If holder <> 1 Then

                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        stonen7 = stonen7 + 1
                        n7p(stonen7.ToString)
                        If stonen7 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n7.Update()
                    Label8.Text = stonen7.ToString
                Else
                    If holder <> 1 Then
                        stonen7 = stonen7 + 1
                        holder = holder - 1
                        n7p(stonen7.ToString)
                    Else
                        If stonen7 <> 0 Then
                            holder = holder + stonen7
                            stonen7 = 0
                            n7p(stonen7.ToString)

                        End If
                    End If
                    n7.Update()
                End If
                n7.Update()
                Label8.Text = stonen7.ToString
                'for shape n8
                If n8.BorderWidth = 10 Then
                    'for shape n8 bank
                    If holder <> 1 Then

                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        stonen8 = stonen8 + 1
                        n8p(stonen8.ToString)
                        If stonen8 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n8.Update()
                    Label8.Text = stonen8.ToString
                Else
                    If holder <> 1 Then
                        stonen8 = stonen8 + 1
                        holder = holder - 1
                        n8p(stonen8.ToString)
                    Else
                        If stonen8 <> 0 Then
                            holder = holder + stonen8
                            stonen8 = 0
                            n8p(stonen8.ToString)

                        End If
                    End If
                    n8.Update()
                End If
                'for shape n9
                If n9.BorderWidth = 10 Then
                    'for shape n9 bank
                    If holder <> 1 Then

                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        stonen9 = stonen9 + 1
                        n9p(stonen9.ToString)
                        If stonen9 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n9.Update()
                    Label8.Text = stonen9.ToString
                Else
                    If holder <> 1 Then
                        stonen9 = stonen9 + 1
                        holder = holder - 1
                        n9p(stonen9.ToString)
                    Else
                        If stonen9 <> 0 Then
                            holder = holder + stonen9
                            stonen9 = 0
                            n9p(stonen9.ToString)

                        End If
                    End If
                    n9.Update()
                End If
                'for shape n10
                If n10.BorderWidth = 10 Then
                    'for shape n10 bank
                    If holder <> 1 Then

                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        stonen10 = stonen10 + 1
                        n10p(stonen10.ToString)
                        If stonen10 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n10.Update()
                    Label8.Text = stonen10.ToString
                Else
                    If holder <> 1 Then
                        stonen10 = stonen10 + 1
                        holder = holder - 1
                        n10p(stonen10.ToString)
                    Else
                        If stonen10 <> 0 Then
                            holder = holder + stonen10
                            stonen10 = 0
                            n10p(stonen10.ToString)

                        End If
                    End If
                    n10.Update()
                End If
                'for shape n1
                If n1.BorderWidth = 10 Then
                    'for shape n1 bank
                    If holder <> 1 Then

                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        stonen1 = stonen1 + 1
                        n1p(stonen1.ToString)
                        If stonen1 = 30 Then
                            If Label11.Text = "COMPUTER" Then
                                MsgBox("You've Lost To Computer, Press OK to start a new game...")
                            Else : MsgBox("Congratulations Player 1, you've won. Press OK to start a new game...!")
                            End If
                            Label4_Click()
                        End If
                        Exit For
                    End If
                    n1.Update()
                    Label8.Text = stonen1.ToString
                Else
                    If holder <> 1 Then
                        stonen1 = stonen1 + 1
                        holder = holder - 1
                        n1p(stonen1.ToString)
                    Else
                        If stonen1 <> 0 Then
                            holder = holder + stonen1
                            stonen1 = 0
                            n1p(stonen1.ToString)

                        End If
                    End If
                    n1.Update()
                End If

            Next
            holder = 0
            'If stonen7 = 30 Then
            '    MsgBox("Congratulations player 2, you have won...!")
            'End If
            If stonen1 = 3 And stonen2 = 3 And stonen3 = 3 And stonen4 = 3 And stonen5 = 3 And stonen6 = 3 And stonen7 = 3 And stonen8 = 3 And stonen9 = 3 And stonen10 = 3 Then
            Else : Chooser("n10")
            End If
        End If
        If Label11.Text = "s" Then
            Computer()
        End If
    End Sub


    'fhwugeyfgwfgewiufghwehefhsughewifuhewufhrwughfgdfkjghdekgfhrugherifuhefiuerhgiuerghiuewhgiru

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label10.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button1.Visible = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label10.Visible = True
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button1.Visible = False
        GroupBox3.Visible = False
        If RadioButton2.Checked = True Then
            My.Computer.Audio.Stop()
            Form4.RadioButton2.Checked = True
            Form4.RadioButton1.Checked = False
        Else
            My.Computer.Audio.Play("C:\Users\Kudzi Biza\Music\tsoro.wav")
            Form4.RadioButton2.Checked = False
            Form4.RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.White
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.Black
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Enabled = False
        Form6.Show()
        GroupBox3.Visible = False
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        GroupBox3.Visible = False
    End Sub

    
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub LineShape10_Click(sender As Object, e As EventArgs) Handles LineShape10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        GroupBox3.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intH As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim intW As Integer = Screen.PrimaryScreen.Bounds.Width

        If Me.Height > intH Then
            Me.Height = intH
            Me.Width = intW
        End If
    End Sub
End Class
