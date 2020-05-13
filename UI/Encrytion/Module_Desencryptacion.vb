﻿
Imports System.Xml
Imports BLL

Module Desencryptacion

    Private aes As New Class_Encryptacion()
    Public CnString As String
    Dim dbcnString As String
    Public appPwdUnique As String = "Ada369_en_Visual_Basic_Net_SQLServer.My.MySettings.BASEMACKEYS"

    Public Function checkServer()
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        dbcnString = root.Attributes.Item(0).Value
        CnString = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Return CnString

    End Function

    Public Function checkServerWEB()
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Conexion_web.xml")
        Dim root As XmlElement = doc.DocumentElement
        dbcnString = root.Attributes.Item(0).Value
        CnString = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Return CnString

    End Function
    Public Function UsuariosEncryp()
        Dim root As New Label()
        dbcnString = root.Text
        CnString = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Return CnString
    End Function
End Module
