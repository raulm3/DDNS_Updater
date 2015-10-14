Imports System.Net
Imports System.Text.RegularExpressions
Public Class frmUpdater

    Private Sub frmUpdater_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadSavedSettings()
        setInterval()
    End Sub
    Private Sub loadSavedSettings()
        txtHostname.Text = My.Settings.hostname
        txtPassword.Text = My.Settings.password
        nudInterval.Value = My.Settings.interval
    End Sub
    Private Function validInfo() As Boolean

        If String.IsNullOrEmpty(txtHostname.Text.Trim) Then
            lblResponse.Text = "Hostname is mandatory"
            txtHostname.Select()
            Return False
        End If
        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            lblResponse.Text = "Password is mandatory"
            txtPassword.Select()
            Return False
        End If
        txtLastIP.Text = getLastIP(txtHostname.Text.Trim)
        txtCurrentIP.Text = getCurrentIP()
        If String.IsNullOrEmpty(txtCurrentIP.Text.Trim) Then
            lblResponse.Text = "Error retrieving IP Current Address"
            Return False
        End If

        Return True
    End Function
    Private Sub updateIP()
        Dim currentIP As String
        Dim urlDynamicDNS As String
        Dim hostName As String
        Dim password As String
        Dim responseData As String = ""
        Dim strError As String = ""

        lblResponse.Text = ""
        lblResponse.Visible = True
        If Not validInfo() Then Exit Sub

        currentIP = txtCurrentIP.Text

        urlDynamicDNS = "http://dyn.dns.he.net/nic/update?hostname=@hostname&password=@password&myip=@myip"

        password = txtPassword.Text.Trim
        hostName = txtHostname.Text.Trim

        urlDynamicDNS = urlDynamicDNS.Replace("@hostname", hostName)
        urlDynamicDNS = urlDynamicDNS.Replace("@password", password)
        urlDynamicDNS = urlDynamicDNS.Replace("@myip", currentIP)

        If CUUHP_VB.UseUnsafeHeaderParsing(strError) Then
            System.Net.ServicePointManager.Expect100Continue = False
        End If

        Dim hwresponse As Net.HttpWebResponse = Nothing
        Try
            Dim cookieJar As New Net.CookieContainer()
            Dim hwrequest As Net.HttpWebRequest = Net.WebRequest.Create(urlDynamicDNS)
            With hwrequest
                .ProtocolVersion = HttpVersion.Version11
                .CookieContainer = cookieJar
                .Accept = "*/*"
                .AllowAutoRedirect = True
                .UserAgent = "chrome"
                .Timeout = 100000
                .Accept = "text/plain"
                .ServicePoint.Expect100Continue = False
                .ServicePoint.MaxIdleTime = 100000
                .KeepAlive = False
                .ContentType = "text/plain"
            End With

            hwresponse = hwrequest.GetResponse()
            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                New IO.StreamReader(hwresponse.GetResponseStream())
                responseData = responseStream.ReadToEnd()
                If responseData.Contains("abuse") Then responseData = "The hostname specified is blocked for abuse"
                If responseData.Contains("badauth") Then responseData = "Authentication Error"
                If responseData.Contains("nochg") Then responseData = "No Change"

                lblResponse.Text = Now.ToString & " """ & responseData.ToUpper & """"
            End If
            hwresponse.Close()
        Catch e As Exception
            lblResponse.Text = Now.ToString & "->" & e.Message
        End Try
    End Sub
    Private Function getCurrentIP() As String
        Try
            Dim currentIP As String
            currentIP = (New WebClient()).DownloadString("http://checkip.dns.he.net/")
            currentIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                         .Matches(currentIP)(0).ToString()
            Return currentIP
        Catch
            Return Nothing
        End Try
    End Function
    Private Function getLastIP(hostname As String) As String
        If hostname.Trim = "" Or hostname.Trim Is Nothing Then Return Nothing
        Try
            Dim lastIP As String
            lastIP = System.Net.Dns.GetHostEntry(txtHostname.Text).AddressList(0).ToString
            Return lastIP
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        updateIP()
    End Sub
    Private Sub btnRefreshLastIP_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshLastIP.Click
        Dim lastIP As String
        lastIP = getLastIP(txtHostname.Text.Trim)
        If lastIP IsNot Nothing Then txtLastIP.Text = lastIP
    End Sub
    Private Sub btnCurrentIP_Click(sender As System.Object, e As System.EventArgs) Handles btnCurrentIP.Click
        Dim currentIP As String
        currentIP = getCurrentIP()
        If currentIP IsNot Nothing Then txtCurrentIP.Text = currentIP
    End Sub
    Private Sub nudInterval_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudInterval.ValueChanged
        setInterval()
    End Sub
    Private Sub setInterval()
        tmrUpdate.Interval = (nudInterval.Value * 60000)
        tmrUpdate.Start()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        My.Settings.hostname = txtHostname.Text.Trim
        My.Settings.password = txtPassword.Text.Trim
        My.Settings.interval = nudInterval.Value
        My.Settings.Save()
    End Sub
    Private Sub tmrUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUpdate.Tick
        updateIP()
    End Sub
    Private Sub btnHide_Click(sender As System.Object, e As System.EventArgs) Handles btnHide.Click
        nfiUpdater.Visible = True
        Me.Hide()
    End Sub
    Private Sub ShowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        nfiUpdater.Visible = False
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub nfiUpdater_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles nfiUpdater.MouseDoubleClick
        Me.Show()
        nfiUpdater.Visible = False
    End Sub
    Private Sub btnInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnInfo.Click
        Dim infoForm As New frmAbout
        infoForm.ShowDialog()
    End Sub
End Class
