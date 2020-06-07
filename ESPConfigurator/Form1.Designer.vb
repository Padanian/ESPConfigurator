<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlocalIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlocalGW = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtlocalSN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlocalDN1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlocalDN2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Access point"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(102, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(128, 20)
        Me.txtIP.TabIndex = 1
        Me.txtIP.Text = "192.168.4.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SSID Wifi"
        '
        'txtSSID
        '
        Me.txtSSID.Location = New System.Drawing.Point(102, 51)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(128, 20)
        Me.txtSSID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password WiFi"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(102, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(128, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Indirizzo IP"
        '
        'txtlocalIP
        '
        Me.txtlocalIP.Location = New System.Drawing.Point(102, 103)
        Me.txtlocalIP.Name = "txtlocalIP"
        Me.txtlocalIP.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalIP.TabIndex = 4
        Me.txtlocalIP.Text = "192.168.1.2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Gateway IP"
        '
        'txtlocalGW
        '
        Me.txtlocalGW.Location = New System.Drawing.Point(102, 129)
        Me.txtlocalGW.Name = "txtlocalGW"
        Me.txtlocalGW.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalGW.TabIndex = 5
        Me.txtlocalGW.Text = "192.168.1.1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Subnet mask"
        '
        'txtlocalSN
        '
        Me.txtlocalSN.Location = New System.Drawing.Point(102, 155)
        Me.txtlocalSN.Name = "txtlocalSN"
        Me.txtlocalSN.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalSN.TabIndex = 6
        Me.txtlocalSN.Text = "255.255.255.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DNS primario"
        '
        'txtlocalDN1
        '
        Me.txtlocalDN1.Location = New System.Drawing.Point(102, 181)
        Me.txtlocalDN1.Name = "txtlocalDN1"
        Me.txtlocalDN1.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalDN1.TabIndex = 7
        Me.txtlocalDN1.Text = "1.1.1.1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DNS secondario"
        '
        'txtlocalDN2
        '
        Me.txtlocalDN2.Location = New System.Drawing.Point(102, 207)
        Me.txtlocalDN2.Name = "txtlocalDN2"
        Me.txtlocalDN2.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalDN2.TabIndex = 8
        Me.txtlocalDN2.Text = "1.0.0.1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Invia a ESP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 275)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(266, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 300)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtlocalDN2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtlocalDN1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtlocalSN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtlocalGW)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlocalIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSSID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "ESPConfigurator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlocalIP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlocalGW As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtlocalSN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlocalDN1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtlocalDN2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripLabel
End Class
