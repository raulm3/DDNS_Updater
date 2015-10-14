'Class published by Tom Hines
'http://geekswithblogs.net/THines01/archive/2010/12/03/responsestatusline.aspx

Option Explicit On
Option Strict On
Imports System
Imports System.Reflection

Public Class CUUHP_VB
         Public Shared Function UseUnsafeHeaderParsing(ByRef strError As String) As Boolean

        Dim assembly As [Assembly]
        assembly = [assembly].GetAssembly(GetType(System.Net.Configuration.SettingsSection))

        If (assembly Is Nothing) Then
            strError = "Could not access Assembly"
            Return False
        End If

        Dim type As Type
        type = [assembly].GetType("System.Net.Configuration.SettingsSectionInternal")
        If (type Is Nothing) Then
            strError = "Could not access internal settings"
            Return False
        End If

        Dim obj As Object
        obj = [type].InvokeMember("Section", _
            BindingFlags.Static Or BindingFlags.GetProperty Or BindingFlags.NonPublic, _
       Nothing, Nothing, New [Object]() {})

        If (obj Is Nothing) Then
            strError = "Could not invoke Section member"
            Return False
        End If

        ' If it's not already set, set it.
        Dim fi As FieldInfo
        fi = [type].GetField("useUnsafeHeaderParsing", BindingFlags.NonPublic Or BindingFlags.Instance)
        If (fi Is Nothing) Then
            strError = "Could not access useUnsafeHeaderParsing field"
            Return False
        End If

        If (Not Convert.ToBoolean(fi.GetValue(obj))) Then
            fi.SetValue(obj, True)
        End If

        Return True
    End Function
End Class