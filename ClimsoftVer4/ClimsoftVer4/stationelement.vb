'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class stationelement
    Public Property id As Long
    Public Property recordedFrom As String
    Public Property describedBy As Nullable(Of Long)
    Public Property recordedWith As String
    Public Property instrumentcode As String
    Public Property scheduledFor As String
    Public Property height As Nullable(Of Single)
    Public Property beginDate As String
    Public Property endDate As String

    Public Overridable Property instrument As instrument
    Public Overridable Property obselement As obselement
    Public Overridable Property obsscheduleclass As obsscheduleclass
    Public Overridable Property station As station

End Class
