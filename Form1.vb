Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class Form1

    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function hash_generator(ByRef hash_type As String, ByRef file_name As String)

        Dim hash
        hash = MD5.Create

        Dim hashValue() As Byte

        Dim filestream As FileStream = File.OpenRead(file_name)
        filestream.Position = 0
        hashValue = hash.ComputeHash(filestream)
        Dim hash_hex = PrintByteArray(hashValue)

        filestream.Close()

        Return hash_hex
    End Function

    Public Function PrintByteArray(ByRef array() As Byte)

        Dim hex_value As String = ""

        Dim i As Integer
        For i = 0 To array.Length - 1

            hex_value += array(i).ToString("x2")
        Next i

        Return hex_value.ToLower
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trayProcess.Text = "Virusless AntiVirus " + My.Settings.Edition + " " + My.Settings.Version + " b" + My.Settings.Build + " (FUT)"
        lblResult.Text = ""
        btnBrowse.Focus()
        If My.Settings.txtMD5Status = 1 Then
            txtMD5.Enabled = True
            txtMD5.Visible = True
            txtMD5.ReadOnly = False
            txtMD5.Visible = True
            lblMD5.Visible = True
            SzerkeszthetőToolStripMenuItem.Enabled = False
        ElseIf My.Settings.txtMD5Status = 2 Then
            txtMD5.Enabled = True
            txtMD5.Visible = True
            txtMD5.ReadOnly = True
            txtMD5.Visible = True
            lblMD5.Visible = True
            CsakLáthatóToolStripMenuItem.Enabled = True
            CsakOlvashatóToolStripMenuItem.Enabled = False
            SzerkeszthetőToolStripMenuItem.Enabled = True
            KikapcsoltToolStripMenuItem.Enabled = True
        ElseIf My.Settings.txtMD5Status = 3 Then
            txtMD5.Enabled = False
            txtMD5.Visible = True
            txtMD5.ReadOnly = True
            txtMD5.Visible = True
            lblMD5.Visible = True
            CsakLáthatóToolStripMenuItem.Enabled = False
            CsakOlvashatóToolStripMenuItem.Enabled = True
            SzerkeszthetőToolStripMenuItem.Enabled = True
            KikapcsoltToolStripMenuItem.Enabled = True
        ElseIf My.Settings.txtMD5Status = 4 Then
            txtMD5.Enabled = True
            txtMD5.Visible = False
            txtMD5.Visible = False
            txtMD5.ReadOnly = True
            lblMD5.Visible = False
            CsakLáthatóToolStripMenuItem.Enabled = True
            CsakOlvashatóToolStripMenuItem.Enabled = True
            SzerkeszthetőToolStripMenuItem.Enabled = True
            KikapcsoltToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        trayProcess.Visible = False
        Form2.Close()
        Me.Close()

    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.WindowState = FormWindowState.Minimized
        trayProcess.Visible = True
        Me.Hide()
    End Sub

    Private Sub trayProcess_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles trayProcess.MouseDoubleClick
        Me.Show()

        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If My.Settings.WarningGiven = True Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                txtLocation.Text = path

                Dim sample As String
                sample = md5_hash(path)
                txtMD5.Text = md5_hash(path)

                Using f As System.IO.FileStream = System.IO.File.OpenRead("md5.txt")
                    Using s As System.IO.StreamReader = New System.IO.StreamReader(f)
                        While Not s.EndOfStream
                            Dim line As String = s.ReadLine

                            If (line = sample) Then
                                trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájl egy fertőzött fájl! Amennyiben biztonságban akar maradni, NE NYISSA MEG!", ToolTipIcon.Error)
                                lblResult.Text = "Win32/Malware-generic(Sign)"
                                lblResult.ForeColor = Color.Red

                            Else
                                trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájlban nem találtunk fertőzést! De vigyázzon és ne töltsön le ismeretlen forrásból fájlokat!", ToolTipIcon.Info)
                                lblResult.Text = "Nem található fertőzés!"
                                lblResult.ForeColor = Color.Green

                            End If
                        End While
                    End Using
                End Using
            End If
        ElseIf My.Settings.WarningGiven = False Then
            If My.Settings.WarningGivenPerm = False Then
                MsgBox("Ön még nem importált be egy fájlt sem a szoftverbe. FIGYELMEZTETÉS: Ezzel a szoftverrel egyszerre csak egy fájlt vizsgálhat át, ami a számítógépétől függően gyors vagy lassú is lehet. Ilyenkor az ablak lefagy, és csak akkor fejezze be a folyamatot, ha az ablak legalább 10 perce lefagyott. Emellett előfordulhat, hogy az aláírások elavultak. A telepített kiadás: " + My.Settings.Edition + " A telepített verzió: " + My.Settings.Version + " b" + My.Settings.Build + " - Azzal, hogy Ön rákattint az OK gombra, tudomásul veszi ezt és ennek tudatában használja a szoftvert. (Ezt a figyelmeztetést be lehet kapcsolni a VAV menüben.)")
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim path As String = OpenFileDialog1.FileName
                    txtLocation.Text = path

                    Dim sample As String
                    sample = md5_hash(path)
                    txtMD5.Text = md5_hash(path)

                    Using f As System.IO.FileStream = System.IO.File.OpenRead("md5.txt")
                        Using s As System.IO.StreamReader = New System.IO.StreamReader(f)
                            While Not s.EndOfStream
                                Dim line As String = s.ReadLine

                                If (line = sample) Then
                                    trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájl egy fertőzött fájl! Amennyiben biztonságban akar maradni, NE NYISSA MEG!", ToolTipIcon.Error)
                                    lblResult.Text = "Win32/Malware-generic(sign)"
                                    lblResult.ForeColor = Color.Red

                                Else
                                    trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájlban nem találtunk fertőzést! De vigyázzon és ne töltsön le ismeretlen forrásból fájlokat!", ToolTipIcon.Info)
                                    lblResult.Text = "Nem található fertőzés!"
                                    lblResult.ForeColor = Color.Green

                                End If
                            End While
                        End Using
                    End Using
                End If
                My.Settings.WarningGiven = True
                My.Settings.Save()
            ElseIf My.Settings.WarningGivenPerm = True Then
                MsgBox("Ön még nem importált be egy fájlt sem a szoftverbe. FIGYELMEZTETÉS: Ezzel a szoftverrel egyszerre csak egy fájlt vizsgálhat át, ami a számítógépétől függően gyors vagy lassú is lehet. Ilyenkor az ablak lefagy, és csak akkor fejezze be a folyamatot, ha az ablak legalább 10 perce lefagyott. Emellett előfordulhat, hogy az aláírások elavultak. A telepített kiadás: " + My.Settings.Edition + " A telepített verzió: " + My.Settings.Version + " b" + My.Settings.Build + " - Azzal, hogy Ön rákattint az OK gombra, tudomásul veszi ezt és ennek tudatában használja a szoftvert. (Ezt a figyelmeztetést be lehet kapcsolni a VAV menüben.)")
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim path As String = OpenFileDialog1.FileName
                    txtLocation.Text = path

                    Dim sample As String
                    sample = md5_hash(path)
                    txtMD5.Text = md5_hash(path)

                    Using f As System.IO.FileStream = System.IO.File.OpenRead("md5.txt")
                        Using s As System.IO.StreamReader = New System.IO.StreamReader(f)
                            While Not s.EndOfStream
                                Dim line As String = s.ReadLine

                                If (line = sample) Then
                                    trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájl egy fertőzött fájl! Amennyiben biztonságban akar maradni, NE NYISSA MEG!", ToolTipIcon.Error)
                                    lblResult.Text = "Win32/Malware-generic(sign)"
                                    lblResult.ForeColor = Color.Red

                                Else
                                    trayProcess.ShowBalloonTip(1000, "Virusless AntiVirus", "Az elemzett fájlban nem találtunk fertőzést! De vigyázzon és ne töltsön le ismeretlen forrásból fájlokat!", ToolTipIcon.Info)
                                    lblResult.Text = "Nem található fertőzés!"
                                    lblResult.ForeColor = Color.Green

                                End If
                            End While
                        End Using
                    End Using
                End If
            End If
        End If

    End Sub

    Private Sub AViruslessAntiVirusMegnyitásaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AViruslessAntiVirusMegnyitásaToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub NévjegyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NévjegyToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub BezárásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BezárásToolStripMenuItem.Click
        btnClose.PerformClick()
    End Sub

    Private Sub MinimalizálásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimalizálásToolStripMenuItem.Click
        btnMinimise.PerformClick()
    End Sub

    Private Sub SzerkeszthetőToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SzerkeszthetőToolStripMenuItem.Click
        My.Settings.txtMD5Status = 1
        My.Settings.Save()
        txtMD5.Enabled = True
        txtMD5.Visible = True
        txtMD5.ReadOnly = False
        lblMD5.Visible = True
        txtMD5.Visible = True
        SzerkeszthetőToolStripMenuItem.Enabled = False
        CsakOlvashatóToolStripMenuItem.Enabled = True
        CsakLáthatóToolStripMenuItem.Enabled = True
        KikapcsoltToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CsakOlvashatóToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CsakOlvashatóToolStripMenuItem.Click
        My.Settings.txtMD5Status = 2
        My.Settings.Save()
        txtMD5.Enabled = True
        txtMD5.Visible = True
        txtMD5.ReadOnly = True
        lblMD5.Visible = True
        txtMD5.Visible = True
        CsakOlvashatóToolStripMenuItem.Enabled = False
        SzerkeszthetőToolStripMenuItem.Enabled = True
        CsakLáthatóToolStripMenuItem.Enabled = True
        KikapcsoltToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CsakLáthatóToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CsakLáthatóToolStripMenuItem.Click
        My.Settings.txtMD5Status = 3
        My.Settings.Save()
        txtMD5.Enabled = False
        txtMD5.Visible = True
        txtMD5.ReadOnly = False
        lblMD5.Visible = True
        txtMD5.Visible = True
        CsakLáthatóToolStripMenuItem.Enabled = False
        CsakOlvashatóToolStripMenuItem.Enabled = True
        SzerkeszthetőToolStripMenuItem.Enabled = True
        KikapcsoltToolStripMenuItem.Enabled = True
    End Sub

    Private Sub KikapcsoltToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KikapcsoltToolStripMenuItem.Click
        My.Settings.txtMD5Status = 4
        My.Settings.Save()
        txtMD5.Enabled = True
        txtMD5.Visible = True
        txtMD5.ReadOnly = False
        txtMD5.Visible = False
        lblMD5.Visible = False
        KikapcsoltToolStripMenuItem.Enabled = False
        CsakOlvashatóToolStripMenuItem.Enabled = True
        CsakLáthatóToolStripMenuItem.Enabled = True
        SzerkeszthetőToolStripMenuItem.Enabled = True
    End Sub

    Private Sub BekapcsolásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BekapcsolásToolStripMenuItem.Click
        My.Settings.WarningGiven = False
        My.Settings.Save()
        My.Settings.WarningGivenPerm = False
        My.Settings.Save()
        MsgBox("A Scan előtti figyelmeztetés egy alkalomra be lett kapcsolva.", MsgBoxStyle.Information, "Scan előtti figyelmeztetés")
    End Sub

    Private Sub BekapcsolásÖrökkéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BekapcsolásÖrökkéToolStripMenuItem.Click
        My.Settings.WarningGiven = False
        My.Settings.Save()
        My.Settings.WarningGivenPerm = True
        My.Settings.Save()
        MsgBox("A Scan előtti figyelmeztetés be lett kapcsolva, addig ameddig manuálisan nem kerül kikapcsolásra.", MsgBoxStyle.Information, "Scan előtti figyelmeztetés")
    End Sub

    Private Sub KikapcsolásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KikapcsolásToolStripMenuItem.Click
        My.Settings.WarningGiven = True
        My.Settings.Save()
        My.Settings.WarningGivenPerm = False
        My.Settings.Save()
        MsgBox("A Scan előtti figyelmeztetés ki lett kapcsolva.", MsgBoxStyle.Information, "Scan előtti figyelmeztetés")
    End Sub
End Class
