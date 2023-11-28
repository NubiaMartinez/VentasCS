Imports System.Data.SqlClient

Public Class BODetalleVenta
    Private _Id_DetalleVenta As Integer
    Private _Cantidad As Integer
    Private _Total As Double
    Private _Id_Producto As Integer
    Private _Id_Venta As Integer
    Private _Id_Ucrear As Integer
    Private _Id_Umodificar As Integer
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_DetalleVenta = 0
        _Cantidad = 0
        _Total = 0
        _Id_Producto = 0
        _Id_Venta = 0
        _Id_Ucrear = 0
        _Id_Umodificar = 0
    End Sub
    Public Sub New(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idventa As Integer,
                   idcrear As Integer, idmodificar As Integer)
        _Id_DetalleVenta = id
        _Cantidad = cant
        _Total = tot
        _Id_Producto = idproducto
        _Id_Venta = idventa
        _Id_Ucrear = idcrear
        _Id_Umodificar = idmodificar
    End Sub
    Public Sub New(row As DataRow)
        _Id_DetalleVenta = row.Field(Of Integer)("Id_DetalleVenta")
        _Cantidad = row.Field(Of Integer)("Cantidad")
        _Total = row.Field(Of Double)("Total")
        _Id_Producto = row.Field(Of Integer)("Id_Producto")
        _Id_Venta = row.Field(Of Integer)("Id_Venta")
        _Id_Ucrear = row.Field(Of Integer)("Id_Ucrear")
        _Id_Umodificar = row.Field(Of Integer)("Id_Umodificar")
    End Sub
    Property Id_DetalleVenta As Integer
        Get
            Return _Id_DetalleVenta
        End Get
        Set(value As Integer)
            _Id_DetalleVenta = value
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
    Property Id_Venta As Integer
        Get
            Return _Id_Venta
        End Get
        Set(value As Integer)
            _Id_Venta = value
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
    Function RegistrarDVenta(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idventa As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroDetalleVenta", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleVenta", id))
        cmd.Parameters.Add(New SqlParameter("Cantidad", cant))
        cmd.Parameters.Add(New SqlParameter("@Total", tot))
        cmd.Parameters.Add(New SqlParameter("@Id_Producto", idproducto))
        cmd.Parameters.Add(New SqlParameter("@Id_Venta", idventa))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleVenta = id
            Cantidad = cant
            Total = tot
            Id_Producto = idproducto
            Id_Venta = idventa
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarDVenta(id As Integer, cant As Integer, tot As Double, idproducto As Integer, idventa As Integer,
                   idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarDetalleVenta", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleVenta", id))
        cmd.Parameters.Add(New SqlParameter("Cantidad", cant))
        cmd.Parameters.Add(New SqlParameter("@Total", tot))
        cmd.Parameters.Add(New SqlParameter("@Id_Producto", idproducto))
        cmd.Parameters.Add(New SqlParameter("@Id_Venta", idventa))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleVenta = id
            Cantidad = cant
            Total = tot
            Id_Producto = idproducto
            Id_Venta = idventa
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarDVenta(id As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarDetalleVenta", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleVenta", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_DetalleVenta = id
        End If
        conn.Close()
        Return response
    End Function
End Class
