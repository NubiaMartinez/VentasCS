Imports System.Data.SqlClient

Public Class BODetalleCompra
    Private _Id_DetalleCompra As Integer
    Private _Cantidad As Integer
    Private _Total As Double
    Private _Id_Producto As Integer
    Private _Id_Compra As Integer
    Private _Id_Ucrear As Integer
    Private _Id_Umodificar As Integer
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_DetalleCompra = 0
        _Cantidad = 0
        _Total = 0
        _Id_Producto = 0
        _Id_Compra = 0
        _Id_Ucrear = 0
        _Id_Umodificar = 0
    End Sub
    Public Sub New(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idcompra As Integer,
                   idcrear As Integer, idmodificar As Integer)
        _Id_DetalleCompra = id
        _Cantidad = cant
        _Total = tot
        _Id_Producto = idproducto
        _Id_Compra = idcompra
        _Id_Ucrear = idcrear
        _Id_Umodificar = idmodificar
    End Sub
    Public Sub New(row As DataRow)
        _Id_DetalleCompra = row.Field(Of Integer)("Id_DetalleCompra")
        _Cantidad = row.Field(Of Integer)("Cantidad")
        _Total = row.Field(Of Double)("Total")
        _Id_Producto = row.Field(Of Integer)("Id_Producto")
        _Id_Compra = row.Field(Of Integer)("Id_Compra")
        _Id_Ucrear = row.Field(Of Integer)("Id_Ucrear")
        _Id_Umodificar = row.Field(Of Integer)("Id_Umodificar")
    End Sub
    Property Id_DetalleCompra As Integer
        Get
            Return _Id_DetalleCompra
        End Get
        Set(value As Integer)
            _Id_DetalleCompra = value
        End Set
    End Property
    Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property
    Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property
    Property Id_Producto As Integer
        Get
            Return _Id_Producto
        End Get
        Set(value As Integer)
            _Id_Producto = value
        End Set
    End Property
    Property Id_Compra As Integer
        Get
            Return _Id_Compra
        End Get
        Set(value As Integer)
            _Id_Compra = value
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
    Function RegistrarDCompra(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idcompra As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroDetalleCompra", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleCompra", id))
        cmd.Parameters.Add(New SqlParameter("Cantidad", cant))
        cmd.Parameters.Add(New SqlParameter("@Total", tot))
        cmd.Parameters.Add(New SqlParameter("@Id_Producto", idproducto))
        cmd.Parameters.Add(New SqlParameter("@Id_Compra", idcompra))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleCompra = id
            Cantidad = cant
            Total = tot
            Id_Producto = idproducto
            Id_Compra = idcompra
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarDCompra(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idcompra As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarDetalleCompra", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleCompra", id))
        cmd.Parameters.Add(New SqlParameter("Cantidad", cant))
        cmd.Parameters.Add(New SqlParameter("@Total", tot))
        cmd.Parameters.Add(New SqlParameter("@Id_Producto", idproducto))
        cmd.Parameters.Add(New SqlParameter("@Id_Compra", idcompra))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleCompra = id
            Cantidad = cant
            Total = tot
            Id_Producto = idproducto
            Id_Compra = idcompra
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarDCompra(id As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarDetalleCompra", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleCompra", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleCompra = id
        End If
        conn.Close()
        Return response
    End Function
End Class
