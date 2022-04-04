
Imports System.Text

Imports Newtonsoft
Imports Newtonsoft.Json


Public Class LynnHoo

    Private Sub LynnHoo_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim A, B, C As Integer

        A = Int(Rnd() * 55)
        B = Int(Rnd() * 255)
        C = Int(Rnd() * 255)

        Label1.ForeColor = Color.FromArgb(A, B, C)

        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, 20)
            builder.Append("131aweg@!$(@Y($Y@!12gaw3".Substring(startIndex, 1))
            num += 1
        Loop While (num <= 14)
        Me.Text = builder.ToString
    End Sub

    Private Sub ขอมลToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ขอมลToolStripMenuItem1.Click
        If MessageBox.Show("สวัสดีครับนี่คือข้อมูลทดสอบ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        'ไม่มีสิ่งที่ต้องการ
    End Sub

    Private Sub ผพฒนาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ผพฒนาToolStripMenuItem.Click
        LynnHoo2.Show()
        Me.Visible = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LynnHoo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("คุณต้องการปิดแอปพลิเคชันนี้จริงๆหรือ?", "Alert", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub
End Class
