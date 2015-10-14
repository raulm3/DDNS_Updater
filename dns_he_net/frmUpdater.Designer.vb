<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdater))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.lblHostname = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblCurrentIP = New System.Windows.Forms.Label()
        Me.txtCurrentIP = New System.Windows.Forms.TextBox()
        Me.lblLastIP = New System.Windows.Forms.Label()
        Me.txtLastIP = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nudInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.nfiUpdater = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnRefreshLastIP = New System.Windows.Forms.Button()
        Me.btnCurrentIP = New System.Windows.Forms.Button()
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(140, 187)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(159, 44)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(135, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "dae8246d"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtHostname
        '
        Me.txtHostname.Location = New System.Drawing.Point(159, 11)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(135, 20)
        Me.txtHostname.TabIndex = 0
        Me.txtHostname.Text = "casa.raulmarmolejo.com"
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = True
        Me.lblHostname.Location = New System.Drawing.Point(17, 14)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Size = New System.Drawing.Size(55, 13)
        Me.lblHostname.TabIndex = 3
        Me.lblHostname.Text = "Hostname"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(17, 47)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'lblResponse
        '
        Me.lblResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponse.ForeColor = System.Drawing.Color.Teal
        Me.lblResponse.Location = New System.Drawing.Point(20, 166)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(298, 15)
        Me.lblResponse.TabIndex = 5
        Me.lblResponse.Text = "Message"
        Me.lblResponse.Visible = False
        '
        'lblCurrentIP
        '
        Me.lblCurrentIP.AutoSize = True
        Me.lblCurrentIP.Location = New System.Drawing.Point(17, 113)
        Me.lblCurrentIP.Name = "lblCurrentIP"
        Me.lblCurrentIP.Size = New System.Drawing.Size(95, 13)
        Me.lblCurrentIP.TabIndex = 8
        Me.lblCurrentIP.Text = "Current IP Address"
        '
        'txtCurrentIP
        '
        Me.txtCurrentIP.Location = New System.Drawing.Point(159, 110)
        Me.txtCurrentIP.Name = "txtCurrentIP"
        Me.txtCurrentIP.ReadOnly = True
        Me.txtCurrentIP.Size = New System.Drawing.Size(135, 20)
        Me.txtCurrentIP.TabIndex = 4
        Me.txtCurrentIP.TabStop = False
        '
        'lblLastIP
        '
        Me.lblLastIP.AutoSize = True
        Me.lblLastIP.Location = New System.Drawing.Point(17, 80)
        Me.lblLastIP.Name = "lblLastIP"
        Me.lblLastIP.Size = New System.Drawing.Size(125, 13)
        Me.lblLastIP.TabIndex = 10
        Me.lblLastIP.Text = "Last Updated IP Address"
        '
        'txtLastIP
        '
        Me.txtLastIP.Location = New System.Drawing.Point(159, 77)
        Me.txtLastIP.Name = "txtLastIP"
        Me.txtLastIP.ReadOnly = True
        Me.txtLastIP.Size = New System.Drawing.Size(135, 20)
        Me.txtLastIP.TabIndex = 2
        Me.txtLastIP.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'nudInterval
        '
        Me.nudInterval.Location = New System.Drawing.Point(159, 139)
        Me.nudInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInterval.Name = "nudInterval"
        Me.nudInterval.Size = New System.Drawing.Size(72, 20)
        Me.nudInterval.TabIndex = 2
        Me.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Update Interval (minutes)"
        '
        'tmrUpdate
        '
        '
        'nfiUpdater
        '
        Me.nfiUpdater.ContextMenuStrip = Me.cmsNotifyIcon
        Me.nfiUpdater.Icon = CType(resources.GetObject("nfiUpdater.Icon"), System.Drawing.Icon)
        Me.nfiUpdater.Text = "DDNS Updater"
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.ShowImageMargin = False
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(79, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.ShowToolStripMenuItem.Text = "&Show"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(20, 187)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 17
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.BackgroundImage = Global.DDNS.My.Resources.Resources.info
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Location = New System.Drawing.Point(295, 187)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(24, 23)
        Me.btnInfo.TabIndex = 18
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnRefreshLastIP
        '
        Me.btnRefreshLastIP.Image = Global.DDNS.My.Resources.Resources.refresh
        Me.btnRefreshLastIP.Location = New System.Drawing.Point(295, 76)
        Me.btnRefreshLastIP.Name = "btnRefreshLastIP"
        Me.btnRefreshLastIP.Size = New System.Drawing.Size(24, 23)
        Me.btnRefreshLastIP.TabIndex = 5
        Me.btnRefreshLastIP.UseVisualStyleBackColor = True
        '
        'btnCurrentIP
        '
        Me.btnCurrentIP.Image = Global.DDNS.My.Resources.Resources.refresh
        Me.btnCurrentIP.Location = New System.Drawing.Point(295, 109)
        Me.btnCurrentIP.Name = "btnCurrentIP"
        Me.btnCurrentIP.Size = New System.Drawing.Size(24, 23)
        Me.btnCurrentIP.TabIndex = 6
        Me.btnCurrentIP.UseVisualStyleBackColor = True
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 222)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudInterval)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRefreshLastIP)
        Me.Controls.Add(Me.btnCurrentIP)
        Me.Controls.Add(Me.lblLastIP)
        Me.Controls.Add(Me.txtLastIP)
        Me.Controls.Add(Me.lblCurrentIP)
        Me.Controls.Add(Me.txtCurrentIP)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblHostname)
        Me.Controls.Add(Me.txtHostname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DNS Updater for dns.he.net"
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtHostname As System.Windows.Forms.TextBox
    Friend WithEvents lblHostname As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents lblCurrentIP As System.Windows.Forms.Label
    Friend WithEvents txtCurrentIP As System.Windows.Forms.TextBox
    Friend WithEvents lblLastIP As System.Windows.Forms.Label
    Friend WithEvents txtLastIP As System.Windows.Forms.TextBox
    Friend WithEvents btnCurrentIP As System.Windows.Forms.Button
    Friend WithEvents btnRefreshLastIP As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents nudInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents nfiUpdater As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button

End Class
