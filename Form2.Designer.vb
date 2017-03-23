<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.wbInfo = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = CType(resources.GetObject("pnlLogo.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogo.Cursor = System.Windows.Forms.Cursors.No
        Me.pnlLogo.Location = New System.Drawing.Point(67, 12)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(313, 100)
        Me.pnlLogo.TabIndex = 0
        '
        'wbInfo
        '
        Me.wbInfo.Location = New System.Drawing.Point(9, 179)
        Me.wbInfo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbInfo.Name = "wbInfo"
        Me.wbInfo.Size = New System.Drawing.Size(410, 250)
        Me.wbInfo.TabIndex = 0
        Me.wbInfo.Url = New System.Uri("http://go.winizsol.ml/vavinfo", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Virusless AntiVirus ALPHA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(C) 2017 Virusless"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 441)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wbInfo)
        Me.Controls.Add(Me.pnlLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Súgó"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLogo As Panel
    Friend WithEvents wbInfo As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
