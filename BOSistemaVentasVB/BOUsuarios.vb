Imports System.Data.SqlClient
Imports System.Net

Public Class BOUsuarios
    Private _Id_Usuario As Integer
    Private _NombreUsuario As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _Estatus As Integer
    Private _Contraseña As String
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_Usuario = 0
        _NombreUsuario = ""
        _Direccion = ""
        _Telefono = ""
        _Email = ""
        _Estatus = 0
        _Contraseña = ""
    End Sub
    Public Sub New(id As Integer, name As String, address As String, tel As String, mail As String, status As Integer, password As String)
        _Id_Usuario = id
        _NombreUsuario = name
        _Direccion = address
        _Telefono = tel
        _Email = mail
        _Estatus = status
        _Contraseña = password
    End Sub
    Public Sub New(row As DataRow)
        _Id_Usuario = row.Field(Of Integer)("Id_Usuario")
        _NombreUsuario = row.Field(Of String)("NombreUsuario")
        _Direccion = row.Field(Of String)("Direccion")
        _Telefono = row.Field(Of String)("Telefono")
        _Email = row.Field(Of String)("Email")
        _Estatus = row.Field(Of Integer)("Estatus")
        _Contraseña = row.Field(Of String)("Contraseña")
    End Sub
    Property Id_Usuario As Integer
        Get
            Return _Id_Usuario
        End Get
        Set(value As Integer)
            _Id_Usuario = value
        End Set
    End Property
    Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(value As String)
            _NombreUsuario = value
        End Set
    End Property
    Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Property Estatus As Integer
        Get
            Return _Estatus
        End Get
        Set(value As Integer)
            _Estatus = value
        End Set
    End Property
    Property Contraseña As String
        Get
            Return _Contraseña
        End Get
        Set(value As String)
            _Contraseña = value
        End Set
    End Property
    Function RegistrarUsuario(id As Integer, name As String, address As String, tel As String, mail As String, status As Integer, password As String)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroUsuarios", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Usuario", id))
        cmd.Parameters.Add(New SqlParameter("NombreUsuario", name))
        cmd.Parameters.Add(New SqlParameter("@Direccion", address))
        cmd.Parameters.Add(New SqlParameter("@Telefono", tel))
        cmd.Parameters.Add(New SqlParameter("@Email", mail))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Contraseña", password))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Usuario = id
            NombreUsuario = name
            Direccion = address
            Telefono = tel
            Email = mail
            Estatus = status
            Contraseña = password
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarUsuario(id As Integer, name As String, address As String, tel As String, mail As String, status As Integer, password As String)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarUsuarios", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Usuario", id))
        cmd.Parameters.Add(New SqlParameter("NombreUsuario", name))
        cmd.Parameters.Add(New SqlParameter("@Direccion", address))
        cmd.Parameters.Add(New SqlParameter("@Telefono", tel))
        cmd.Parameters.Add(New SqlParameter("@Email", mail))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Contraseña", password))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Usuario = id
            NombreUsuario = name
            Direccion = address
            Telefono = tel
            Email = mail
            Estatus = status
            Contraseña = password
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarUsuario(id As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarUsuarios", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Usuario", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Usuario = id
        End If
        conn.Close()
        Return response
    End Function
End Class
