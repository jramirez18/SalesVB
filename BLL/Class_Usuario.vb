Imports DAL.DS_UsuariosTableAdapters

Public Class Class_Usuario

    'atributos
    Private usuario As sp_ListarUsuariosTableAdapter

    'propiedades
    Private ReadOnly Property USUARIOS As sp_ListarUsuariosTableAdapter
        Get
            If usuario Is Nothing Then usuario = New sp_ListarUsuariosTableAdapter
            Return usuario
        End Get
    End Property

    'METODOS
    Public Function InsertarUsuario(ByVal nombre_apellidos As String, ByVal login As String, ByVal password As String, ByVal icono As Byte(), ByVal nombre_icono As String, ByVal correo As String, ByVal rol As String, ByVal estado As String) As String
        Dim msj = ""
        Try
            USUARIOS.GetDataInsertarUsuario(nombre_apellidos, login, password, icono, nombre_icono, correo, rol, estado, msj)
        Catch ex As Exception
            msj = ex.Message
        End Try
        Return msj
    End Function

    'PARA QUE FUNCIONE HAY QUE CREAR EL SP DESDE ACA Y NO EN EL SQL sp_ExistsUser
    Public Function ExisteUser(ByVal usuario As String) As Boolean
        If USUARIOS.GetDataExistsUser(usuario) Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ListarUsuarios() As DataTable
        Return USUARIOS.GetDataListarUsuarios()
    End Function

    Public Function BuscarUsuario(ByVal buscar As String) As DataTable
        Return USUARIOS.GetDataBuscarUsuario(buscar)
    End Function

    Public Function UpdateUser(ByVal idUsuario As Integer, ByVal nombre_apellidos As String, ByVal login As String, ByVal password As String, ByVal icono As Byte(), ByVal nombre_icono As String, ByVal correo As String, ByVal rol As String)
        Dim msj = ""
        Try
            USUARIOS.GetDataUpdateUser(idUsuario, nombre_apellidos, login, password, icono, nombre_icono, correo, rol, msj)
        Catch ex As Exception
            msj = ex.Message
        End Try
        Return msj
    End Function

    Public Function DeleteUser(ByVal idUsuario As Integer, ByVal login As String)
        Dim msj = ""
        Try
            USUARIOS.GetDataDeleteUser(idUsuario, login, msj)
        Catch ex As Exception
            msj = ex.Message
        End Try

        Return msj
    End Function

    Public Function RestaurarUser(ByVal idUsuario As Integer, ByVal login As String)
        Dim msj = ""
        Try
            USUARIOS.GetDataRestaurarUser(idUsuario, login, msj)
        Catch ex As Exception
            msj = ex.Message
        End Try

        Return msj
    End Function

    Public Function UsuariosActivos() As DataTable
        Return USUARIOS.GetDataUsersActivos()
    End Function

    Public Function ValidarUsuario(ByVal user As String, ByVal pass As String) As DataTable
        Return USUARIOS.GetDataValidarUser(user, pass)
    End Function

    Public Function CorreosActivos() As DataTable
        Return USUARIOS.GetDataCorreoActivos()
    End Function

    Public Function ObtenerPassword(ByVal correo As String)
        Return USUARIOS.GetDataObtenerPassword(correo)
    End Function

End Class
