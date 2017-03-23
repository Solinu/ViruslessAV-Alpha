<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.trayProcess = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.trayProcessContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AViruslessAntiVirusMegnyitásaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblMD5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtMD5 = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VAVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimalizálásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezárásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanBeállításokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanElőttiFigyelmeztetésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BekapcsolásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BekapcsolásÖrökkéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KikapcsolásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5SzövegdobozTípusaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SzerkeszthetőToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CsakOlvashatóToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CsakLáthatóToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KikapcsoltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SúgóToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NévjegyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayProcessContext.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = CType(resources.GetObject("pnlLogo.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogo.Location = New System.Drawing.Point(176, 29)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(311, 103)
        Me.pnlLogo.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(597, 29)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'trayProcess
        '
        Me.trayProcess.ContextMenuStrip = Me.trayProcessContext
        Me.trayProcess.Icon = CType(resources.GetObject("trayProcess.Icon"), System.Drawing.Icon)
        Me.trayProcess.Text = "trayProcess.Text"
        Me.trayProcess.Visible = True
        '
        'trayProcessContext
        '
        Me.trayProcessContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AViruslessAntiVirusMegnyitásaToolStripMenuItem})
        Me.trayProcessContext.Name = "trayProcessContext"
        Me.trayProcessContext.Size = New System.Drawing.Size(246, 26)
        '
        'AViruslessAntiVirusMegnyitásaToolStripMenuItem
        '
        Me.AViruslessAntiVirusMegnyitásaToolStripMenuItem.Name = "AViruslessAntiVirusMegnyitásaToolStripMenuItem"
        Me.AViruslessAntiVirusMegnyitásaToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.AViruslessAntiVirusMegnyitásaToolStripMenuItem.Text = "A Virusless AntiVirus megnyitása"
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMinimise.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimise.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMinimise.Location = New System.Drawing.Point(564, 29)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(27, 30)
        Me.btnMinimise.TabIndex = 1
        Me.btnMinimise.Text = "_"
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 141)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(77, 21)
        Me.lblLocation.TabIndex = 2
        Me.lblLocation.Text = "Fájl helye:"
        '
        'lblMD5
        '
        Me.lblMD5.AutoSize = True
        Me.lblMD5.Location = New System.Drawing.Point(12, 169)
        Me.lblMD5.Name = "lblMD5"
        Me.lblMD5.Size = New System.Drawing.Size(84, 21)
        Me.lblMD5.TabIndex = 3
        Me.lblMD5.Text = "MD5 hash:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 21)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Állapot:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(91, 197)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(49, 21)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "result"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(95, 143)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(448, 23)
        Me.txtLocation.TabIndex = 6
        '
        'txtMD5
        '
        Me.txtMD5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtMD5.Location = New System.Drawing.Point(95, 172)
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.ReadOnly = True
        Me.txtMD5.Size = New System.Drawing.Size(529, 22)
        Me.txtMD5.TabIndex = 7
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBrowse.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBrowse.Location = New System.Drawing.Point(549, 143)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Tallózás"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Fájl neve"
        Me.OpenFileDialog1.Title = "Fájl tallózása"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VAVToolStripMenuItem, Me.SúgóToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VAVToolStripMenuItem
        '
        Me.VAVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimalizálásToolStripMenuItem, Me.BezárásToolStripMenuItem, Me.ScanBeállításokToolStripMenuItem})
        Me.VAVToolStripMenuItem.Name = "VAVToolStripMenuItem"
        Me.VAVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.VAVToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.VAVToolStripMenuItem.Text = "VAV"
        '
        'MinimalizálásToolStripMenuItem
        '
        Me.MinimalizálásToolStripMenuItem.Name = "MinimalizálásToolStripMenuItem"
        Me.MinimalizálásToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.MinimalizálásToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MinimalizálásToolStripMenuItem.Text = "Minimalizálás"
        '
        'BezárásToolStripMenuItem
        '
        Me.BezárásToolStripMenuItem.Name = "BezárásToolStripMenuItem"
        Me.BezárásToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.BezárásToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.BezárásToolStripMenuItem.Text = "Bezárás"
        '
        'ScanBeállításokToolStripMenuItem
        '
        Me.ScanBeállításokToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanElőttiFigyelmeztetésToolStripMenuItem, Me.MD5SzövegdobozTípusaToolStripMenuItem})
        Me.ScanBeállításokToolStripMenuItem.Name = "ScanBeállításokToolStripMenuItem"
        Me.ScanBeállításokToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ScanBeállításokToolStripMenuItem.Text = "Scan beállítások"
        '
        'ScanElőttiFigyelmeztetésToolStripMenuItem
        '
        Me.ScanElőttiFigyelmeztetésToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BekapcsolásToolStripMenuItem, Me.BekapcsolásÖrökkéToolStripMenuItem, Me.KikapcsolásToolStripMenuItem})
        Me.ScanElőttiFigyelmeztetésToolStripMenuItem.Name = "ScanElőttiFigyelmeztetésToolStripMenuItem"
        Me.ScanElőttiFigyelmeztetésToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ScanElőttiFigyelmeztetésToolStripMenuItem.Text = "Scan előtti figyelmeztetés"
        '
        'BekapcsolásToolStripMenuItem
        '
        Me.BekapcsolásToolStripMenuItem.Name = "BekapcsolásToolStripMenuItem"
        Me.BekapcsolásToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BekapcsolásToolStripMenuItem.Text = "Bekapcsolás egyszer"
        '
        'BekapcsolásÖrökkéToolStripMenuItem
        '
        Me.BekapcsolásÖrökkéToolStripMenuItem.Name = "BekapcsolásÖrökkéToolStripMenuItem"
        Me.BekapcsolásÖrökkéToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BekapcsolásÖrökkéToolStripMenuItem.Text = "Bekapcsolás örökké"
        '
        'KikapcsolásToolStripMenuItem
        '
        Me.KikapcsolásToolStripMenuItem.Name = "KikapcsolásToolStripMenuItem"
        Me.KikapcsolásToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KikapcsolásToolStripMenuItem.Text = "Kikapcsolás"
        '
        'MD5SzövegdobozTípusaToolStripMenuItem
        '
        Me.MD5SzövegdobozTípusaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SzerkeszthetőToolStripMenuItem, Me.CsakOlvashatóToolStripMenuItem, Me.CsakLáthatóToolStripMenuItem, Me.KikapcsoltToolStripMenuItem})
        Me.MD5SzövegdobozTípusaToolStripMenuItem.Name = "MD5SzövegdobozTípusaToolStripMenuItem"
        Me.MD5SzövegdobozTípusaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.MD5SzövegdobozTípusaToolStripMenuItem.Text = "MD5 szövegdoboz állapota"
        '
        'SzerkeszthetőToolStripMenuItem
        '
        Me.SzerkeszthetőToolStripMenuItem.Name = "SzerkeszthetőToolStripMenuItem"
        Me.SzerkeszthetőToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SzerkeszthetőToolStripMenuItem.Text = "Szerkeszthető"
        '
        'CsakOlvashatóToolStripMenuItem
        '
        Me.CsakOlvashatóToolStripMenuItem.Name = "CsakOlvashatóToolStripMenuItem"
        Me.CsakOlvashatóToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CsakOlvashatóToolStripMenuItem.Text = "Csak olvasható (alap)"
        '
        'CsakLáthatóToolStripMenuItem
        '
        Me.CsakLáthatóToolStripMenuItem.Name = "CsakLáthatóToolStripMenuItem"
        Me.CsakLáthatóToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CsakLáthatóToolStripMenuItem.Text = "Csak látható"
        '
        'KikapcsoltToolStripMenuItem
        '
        Me.KikapcsoltToolStripMenuItem.Name = "KikapcsoltToolStripMenuItem"
        Me.KikapcsoltToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.KikapcsoltToolStripMenuItem.Text = "Kikapcsolt"
        '
        'SúgóToolStripMenuItem
        '
        Me.SúgóToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NévjegyToolStripMenuItem})
        Me.SúgóToolStripMenuItem.Name = "SúgóToolStripMenuItem"
        Me.SúgóToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SúgóToolStripMenuItem.Text = "Súgó"
        '
        'NévjegyToolStripMenuItem
        '
        Me.NévjegyToolStripMenuItem.Name = "NévjegyToolStripMenuItem"
        Me.NévjegyToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NévjegyToolStripMenuItem.Text = "Névjegy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 231)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtMD5)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMD5)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnMinimise)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Virusless AntiVirus FREE"
        Me.trayProcessContext.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLogo As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents trayProcess As NotifyIcon
    Friend WithEvents btnMinimise As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblMD5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtMD5 As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents trayProcessContext As ContextMenuStrip
    Friend WithEvents AViruslessAntiVirusMegnyitásaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VAVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SúgóToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NévjegyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BezárásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimalizálásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanBeállításokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanElőttiFigyelmeztetésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BekapcsolásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BekapcsolásÖrökkéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KikapcsolásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MD5SzövegdobozTípusaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SzerkeszthetőToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CsakOlvashatóToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CsakLáthatóToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KikapcsoltToolStripMenuItem As ToolStripMenuItem
End Class
