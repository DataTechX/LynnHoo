Public Class LynnHoo2
    Private Sub BackHomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackHomeToolStripMenuItem.Click
        LynnHoo.Show()
        Me.Visible = False
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://discord.com/users/800312400905633802")
    End Sub

    Private Sub LynnHoo2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("คุณต้องการปิดแอปพลิเคชันนี้จริงๆหรือ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        'xxxxxxxxxxxx
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://discord.com/users/412823233809743884")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://discord.com/users/311187998253252611")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://discord.com/users/484011475237601281")
    End Sub
End Class