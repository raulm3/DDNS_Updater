<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblPermission = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.lblTwitter = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Teal
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(387, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Small Windows application that will update dns.he.net's DDNS entries to point to " & _
    "your machine ."
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.Teal
        Me.lblCopyright.Location = New System.Drawing.Point(12, 370)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(261, 22)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "© Copyright 2015 - Raúl Marmolejo"
        '
        'lblPermission
        '
        Me.lblPermission.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermission.ForeColor = System.Drawing.Color.Black
        Me.lblPermission.Location = New System.Drawing.Point(12, 52)
        Me.lblPermission.Name = "lblPermission"
        Me.lblPermission.Size = New System.Drawing.Size(387, 116)
        Me.lblPermission.TabIndex = 2
        Me.lblPermission.Text = resources.GetString("lblPermission.Text")
        Me.lblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(387, 43)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "The above copyright notice and this permission notice shall be included in all co" & _
    "pies or substantial portions of the Software."
        '
        'lblSoftware
        '
        Me.lblSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftware.ForeColor = System.Drawing.Color.Black
        Me.lblSoftware.Location = New System.Drawing.Point(12, 202)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(387, 145)
        Me.lblSoftware.TabIndex = 4
        Me.lblSoftware.Text = resources.GetString("lblSoftware.Text")
        '
        'lblTwitter
        '
        Me.lblTwitter.AutoSize = True
        Me.lblTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwitter.LinkColor = System.Drawing.Color.Teal
        Me.lblTwitter.Location = New System.Drawing.Point(343, 372)
        Me.lblTwitter.Name = "lblTwitter"
        Me.lblTwitter.Size = New System.Drawing.Size(56, 13)
        Me.lblTwitter.TabIndex = 5
        Me.lblTwitter.TabStop = True
        Me.lblTwitter.Text = "@raulm3"
        Me.lblTwitter.VisitedLinkColor = System.Drawing.Color.Teal
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 400)
        Me.Controls.Add(Me.lblTwitter)
        Me.Controls.Add(Me.lblSoftware)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPermission)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblPermission As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents lblTwitter As System.Windows.Forms.LinkLabel
End Class
