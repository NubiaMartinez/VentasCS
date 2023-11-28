Imports System.Data.SqlClient

Public Class BOProductos
    Private _Id_Producto As Integer
    Private _Nombre As String
    Private _PrecioUnitario As Double
    Private _Stock As Integer
    Private _Descripcion As String
    Private _Estatus As Integer
    Private _Id_Marca As Integer
    Private _Id_Categoria As Integer
    Private _Id_Ucrear As Integer
    Private _Id_Umodificar As Integer
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_Producto = 0
        _Nombre = ""
        _PrecioUnitario = 0
        _Stock = 0
        _Descripcion = ""
        _Estatus = 0
        _Id_Marca = 0
        _Id_Categoria = 0
        _Id_Ucrear = 0
        _Id_Umodificar = 0
    End Sub
    Public Sub New(id As Integer, nom As String, precio As Double, stock_ As Integer, descrip As String,
                   status As Integer, idmarca As Integer, idcategoria As Integer,
                   idcrear As Integer, idmodificar As Integer)

        _Id_Producto = id
        _Nombre = nom
        _PrecioUnitario = precio
        _Stock = stock_
        _Descripcion = descrip
        _Estatus = status
        _Id_Marca = idmarca
        _Id_Categoria = idcategoria
        _Id_Ucrear = idcrear
        _Id_Umodificar = idmodificar
    End Sub
    Public Sub New(row As DataRow)
        _Id_Producto = row.Field(Of Integer)("Id_Producto")
        _Nombre = row.Field(Of String)("Nombre")
        _PrecioUnitario = row.Field(Of Double)("PrecioUnitario")
        _Stock = row.Field(Of Integer)("Stock")
        _Descripcion = row.Field(Of String)("Descripcion")
        _Estatus = row.Field(Of Integer)("Estatus")
        _Id_Marca = row.Field(Of Integer)("Id_Marca")
        _Id_Categoria = row.Field(Of Integer)("Id_Categoria")
        _Id_Ucrear = row.Field(Of Integer)("Id_Ucrear")
        _Id_Umodificar = row.Field(Of Integer)("Id_Umodificar")
    End Sub
    Property Id_Producto As Integer
        Get
            Return _Id_Producto
        End Get
        Set(value As Integer)
            _Id_Producto = value
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
    Property PrecioUnitario As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Double)
            _PrecioUnitario = value
        End Set
    End Property
    Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property
    Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
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
    Property Id_Marca As Integer
        Get
            Return _Id_Marca
        End Get
        Set(value As Integer)
            _Id_Marca = value
        End Set
    End Property
    Property Id_Categoria As Integer
        Get
            Return _Id_Categoria
        End Get
        Set(value As Integer)
            _Id_Categoria = value
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
    Function RegistrarProducto(id As Integer, nom As String, precio As Double, stock_ As Integer, descrip As String,
                   status As Integer, idmarca As Integer, idcategoria As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroProductos", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Cliente", id))
        cmd.Parameters.Add(New SqlParameter("Nombre", nom))
        cmd.Parameters.Add(New SqlParameter("@PrecioUnitario", precio))
        cmd.Parameters.Add(New SqlParameter("@Stock", stock_))
        cmd.Parameters.Add(New SqlParameter("@Descripcion", descrip))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Marca", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Categoria", idmodificar))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Producto = id
            Nombre = nom
            PrecioUnitario = precio
            Stock = stock_
            Descripcion = descrip
            Estatus = status
            Id_Marca = idmarca
            Id_Categoria = idcategoria
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarProducto(id As Integer, nom As String, precio As Double, stock_ As Integer, descrip As String,
                   status As Integer, idmarca As Integer, idcategoria As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarProductos", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Cliente", id))
        cmd.Parameters.Add(New SqlParameter("Nombre", nom))
        cmd.Parameters.Add(New SqlParameter("@PrecioUnitario", precio))
        cmd.Parameters.Add(New SqlParameter("@Stock", stock_))
        cmd.Parameters.Add(New SqlParameter("@Descripcion", descrip))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Marca", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Categoria", idmodificar))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Producto = id
            Nombre = nom
            PrecioUnitario = precio
            Stock = stock_
            Descripcion = descrip
            Estatus = status
            Id_Marca = idmarca
            Id_Categoria = idcategoria
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarProducto(id As Integer)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarProductos", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Cliente", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Producto = id
        End If
        conn.Close()
        Return response
    End Function
End Class
