Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Kiadás: " & My.Settings.Edition & " Verzió: " & My.Settings.Version & " Build száma: " & My.Settings.Build
        pnlLogo.Visible = False
        wbInfo.Visible = False
        If My.Settings.AboutWarningGiven = False Then
            MsgBox("Tisztelt Felhasználó! Amennyiben el szeretné olvasni az információkat, ahhoz internetkapcsolatra lesz szüksége.", MsgBoxStyle.Exclamation, "Figyelmeztetés")
            My.Settings.AboutWarningGiven1 = True
            My.Settings.Save()
            pnlLogo.Visible = True
            wbInfo.Visible = True
        Else
            pnlLogo.Visible = True
            wbInfo.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Settings.AboutWarningGiven = False
        My.Settings.Save()
        MsgBox("A visszaállítás sikeres!", MsgBoxStyle.OkOnly, "Információ")
    End Sub
End Class