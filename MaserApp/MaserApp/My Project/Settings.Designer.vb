﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\maser")>  _
        Public Property WorkDir() As String
            Get
                Return CType(Me("WorkDir"),String)
            End Get
            Set
                Me("WorkDir") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("taxa1332.zip")>  _
        Public Property Taxa1332File() As String
            Get
                Return CType(Me("Taxa1332File"),String)
            End Get
            Set
                Me("Taxa1332File") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ftp1.msnj.us")>  _
        Public Property Taxa1332FTP() As String
            Get
                Return CType(Me("Taxa1332FTP"),String)
            End Get
            Set
                Me("Taxa1332FTP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("edmunds")>  _
        Public Property Taxa1332User() As String
            Get
                Return CType(Me("Taxa1332User"),String)
            End Get
            Set
                Me("Taxa1332User") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("obbidtig")>  _
        Public Property Taxa1332Pwd() As String
            Get
                Return CType(Me("Taxa1332Pwd"),String)
            End Get
            Set
                Me("Taxa1332Pwd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("gis1332.zip")>  _
        Public Property AcegisFile() As String
            Get
                Return CType(Me("AcegisFile"),String)
            End Get
            Set
                Me("AcegisFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ftp1.msnj.us")>  _
        Public Property AcegisFTP() As String
            Get
                Return CType(Me("AcegisFTP"),String)
            End Get
            Set
                Me("AcegisFTP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("mhgis")>  _
        Public Property AcegisUser() As String
            Get
                Return CType(Me("AcegisUser"),String)
            End Get
            Set
                Me("AcegisUser") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("hakfomak")>  _
        Public Property AcegisPwd() As String
            Get
                Return CType(Me("AcegisPwd"),String)
            End Get
            Set
                Me("AcegisPwd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecTaxa1332() As Boolean
            Get
                Return CType(Me("SecTaxa1332"),Boolean)
            End Get
            Set
                Me("SecTaxa1332") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecAcegis() As Boolean
            Get
                Return CType(Me("SecAcegis"),Boolean)
            End Get
            Set
                Me("SecAcegis") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecModiv() As Boolean
            Get
                Return CType(Me("SecModiv"),Boolean)
            End Get
            Set
                Me("SecModiv") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecCo() As Boolean
            Get
                Return CType(Me("SecCo"),Boolean)
            End Get
            Set
                Me("SecCo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecSeptics() As Boolean
            Get
                Return CType(Me("SecSeptics"),Boolean)
            End Get
            Set
                Me("SecSeptics") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecBCO() As Boolean
            Get
                Return CType(Me("SecBCO"),Boolean)
            End Get
            Set
                Me("SecBCO") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecZBA() As Boolean
            Get
                Return CType(Me("SecZBA"),Boolean)
            End Get
            Set
                Me("SecZBA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecPLA() As Boolean
            Get
                Return CType(Me("SecPLA"),Boolean)
            End Get
            Set
                Me("SecPLA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecCD() As Boolean
            Get
                Return CType(Me("SecCD"),Boolean)
            End Get
            Set
                Me("SecCD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecCPM() As Boolean
            Get
                Return CType(Me("SecCPM"),Boolean)
            End Get
            Set
                Me("SecCPM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecFTG() As Boolean
            Get
                Return CType(Me("SecFTG"),Boolean)
            End Get
            Set
                Me("SecFTG") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SecZone() As Boolean
            Get
                Return CType(Me("SecZone"),Boolean)
            End Get
            Set
                Me("SecZone") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SecMac() As Boolean
            Get
                Return CType(Me("SecMac"),Boolean)
            End Get
            Set
                Me("SecMac") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("taxa1332.dat")>  _
        Public Property Taxa1332UnzipFile() As String
            Get
                Return CType(Me("Taxa1332UnzipFile"),String)
            End Get
            Set
                Me("Taxa1332UnzipFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("gis1332.txt")>  _
        Public Property AcegisUnzipFile() As String
            Get
                Return CType(Me("AcegisUnzipFile"),String)
            End Get
            Set
                Me("AcegisUnzipFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\johnadams\Documents\workdb.mdb")>  _
        Public Property WorkDB() As String
            Get
                Return CType(Me("WorkDB"),String)
            End Get
            Set
                Me("WorkDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\johnadams\Documents\CONew.mdb")>  _
        Public Property CONewDB() As String
            Get
                Return CType(Me("CONewDB"),String)
            End Get
            Set
                Me("CONewDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\johnadams\Documents\Send\workdb.mdb")>  _
        Public Property SendDB() As String
            Get
                Return CType(Me("SendDB"),String)
            End Get
            Set
                Me("SendDB") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.MaserApp.My.MySettings
            Get
                Return Global.MaserApp.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
