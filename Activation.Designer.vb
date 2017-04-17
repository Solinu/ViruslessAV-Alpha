<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activation))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.trayProcess = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lnkGPL_en = New System.Windows.Forms.LinkLabel()
        Me.lnkGPL_hu = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(98, 116)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Aktiválás"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(12, 90)
        Me.txtKey.MaxLength = 29
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(261, 20)
        Me.txtKey.TabIndex = 1
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(232, 78)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'trayProcess
        '
        Me.trayProcess.Text = "trayProcess"
        Me.trayProcess.Visible = True
        '
        'lnkGPL_en
        '
        Me.lnkGPL_en.AutoSize = True
        Me.lnkGPL_en.Location = New System.Drawing.Point(9, 144)
        Me.lnkGPL_en.Name = "lnkGPL_en"
        Me.lnkGPL_en.Size = New System.Drawing.Size(81, 13)
        Me.lnkGPL_en.TabIndex = 3
        Me.lnkGPL_en.TabStop = True
        Me.lnkGPL_en.Text = "GPL v2 (angol)"
        '
        'lnkGPL_hu
        '
        Me.lnkGPL_hu.AutoSize = True
        Me.lnkGPL_hu.Location = New System.Drawing.Point(9, 157)
        Me.lnkGPL_hu.Name = "lnkGPL_hu"
        Me.lnkGPL_hu.Size = New System.Drawing.Size(196, 13)
        Me.lnkGPL_hu.TabIndex = 4
        Me.lnkGPL_hu.TabStop = True
        Me.lnkGPL_hu.Text = "GPL v2 (nem hivatalos magyar fordítás)"
        '
        'Activation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 181)
        Me.Controls.Add(Me.lnkGPL_hu)
        Me.Controls.Add(Me.lnkGPL_en)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.btnSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Activation"
        Me.Text = "Aktiváció"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents trayProcess As NotifyIcon
    Friend WithEvents lnkGPL_en As LinkLabel
    Friend WithEvents lnkGPL_hu As LinkLabel
End Class
