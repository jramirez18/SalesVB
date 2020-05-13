Imports System.Security.Cryptography
Imports System.Text

Module Module_EncryptarEnTexto
    Public des As New TripleDESCryptoServiceProvider
    Public hashmd5 As New MD5CryptoServiceProvider
    Public Function Encriptar(ByVal texto As String) As String

        If Trim(texto) = String.Empty Then
            Encriptar = String.Empty
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(appPwdUnique))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function
    Public Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = String.Empty Then
            Desencriptar = String.Empty
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(appPwdUnique))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function
End Module
