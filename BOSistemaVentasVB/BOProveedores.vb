Imports System.Data.SqlClient

Public Class BOProveedores
    Private _Id_Proveedor As Integer
    Private _Nombre As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _Estatus As Integer
    Private _Id_Ucrear As Integer
    Private _Id_Umodificar As Integer
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_Proveedor = 0
        _Nombre = ""
        _Direccion = ""
        _Telefono = ""
        _Email = ""
        _Estatus = 0
        _Id_Ucrear = 0
        _Id_Umodificar = 0
    End Sub
    Public Sub New(id As Integer, nom As String, address As String, tel As String, mail As String,
                   status As Integer, idcrear As Integer, idmodificar As Integer)
        _Id_Proveedor = id
        _Nombre = nom
        _Direccion = address
        _Telefono = tel
        _Email = mail
        _Estatus = status
        _Id_Ucrear = idcrear
        _Id_Umodificar = idmodificar
    End Sub

    Public Sub New(row As DataRow)
        _Id_Proveedor = row.Field(Of Integer)("Id_Proveedor")
        _Nombre = row.Field(Of String)("Nombre")
        _Direccion = row.Field(Of String)("Direccion")
        _Telefono = row.Field(Of String)("Telefono")
        _Email = row.Field(Of String)("Email")
        _Estatus = row.Field(Of Integer)("Estatus")
        _Id_Ucrear = row.Field(Of Integer)("Id_Ucrear")
        _Id_Umodificar = row.Field(Of Integer)("Id_Umodificar")
    End Sub
    Property Id_Proveedor As Integer
        Get
            Return _Id_Proveedor
        End Get
        Set(value As Integer)
            _Id_Proveedor = value
        End Set
    End Property
    Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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
    Property Id_Ucrear As Integer
        Get
            Return _Id_Ucrear
        End Get
        Set(value As Integer)
            _Id_Ucrear = value
        End Set
    End Property
    Property Id_Umodificar As Integer
        Get
            Return _Id_Umodificar
        End Get
        Set(value As Integer)
            _Id_Umodificar = value
        End Set
    End Property
    Function RegistrarProveedor(id As Integer, nom As String, address As String, tel As String, mail As String,
                   status As Integer, idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroProveedores", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Proveedor", id))
        cmd.Parameters.Add(New SqlParameter("Nombre", nom))
        cmd.Parameters.Add(New SqlParameter("@Direccion", address))
        cmd.Parameters.Add(New SqlParameter("@Telefono", tel))
        cmd.Parameters.Add(New SqlParameter("@Email", mail))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Proveedor = id
            Nombre = nom
            Direccion = address
            Telefono = tel
            Email = mail
            Estatus = status
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarProveedor(id As Integer, nom As String, address As String, tel As String, mail As String,
                   status As Integer, idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarProveedores", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Proveedor", id))
        cmd.Parameters.Add(New SqlParameter("Nombre", nom))
        cmd.Parameters.Add(New SqlParameter("@Direccion", address))
        cmd.Parameters.Add(New SqlParameter("@Telefono", tel))
        cmd.Parameters.Add(New SqlParameter("@Email", mail))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Proveedor = id
            Nombre = nom
            Direccion = address
            Telefono = tel
            Email = mail
            Estatus = status
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarProveedor(id As Integer)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarProveedores", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Proveedor", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Proveedor = id
        End If
        conn.Close()
        Return response
    End Function
End Class
