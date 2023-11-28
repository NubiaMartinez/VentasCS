Imports System.Data.SqlClient

Public Class BOVentas
    Private _Id_Venta As Integer
    Private _Fecha As Date
    Private _IVA As Double
    Private _Subtotal As Double
    Private _Estatus As Integer
    Private _Id_Cliente As Integer
    Private _Id_Ucrear As Integer
    Private _Id_Umodificar As Integer
    Private conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true"
    Public Sub New()
        _Id_Venta = 0
        _Fecha = DateSerial(0, 0, 0)
        _IVA = 0
        _Subtotal = 0
        _Estatus = 0
        _Id_Cliente = 0
        _Id_Ucrear = 0
        _Id_Umodificar = 0
    End Sub
    Public Sub New(id As Integer, fecha_ As Date, iva_ As Double, subtotal_ As Double,
                   status As Integer, idcliente As Integer, idcrear As Integer, idmodificar As Integer)
        _Id_Venta = id
        _Fecha = fecha_
        _IVA = iva_
        _Subtotal = subtotal_
        _Estatus = status
        _Id_Cliente = idcliente
        _Id_Ucrear = idcrear
        _Id_Umodificar = idmodificar
    End Sub
    Public Sub New(row As DataRow)
        _Id_Venta = row.Field(Of Integer)("Id_Venta")
        _Fecha = row.Field(Of Date)("Fecha")
        _IVA = row.Field(Of Double)("IVA")
        _Subtotal = row.Field(Of Double)("Subtotal")
        _Estatus = row.Field(Of Integer)("Estatus")
        _Id_Cliente = row.Field(Of Integer)("Id_Proveedor")
        _Id_Ucrear = row.Field(Of Integer)("Id_Ucrear")
        _Id_Umodificar = row.Field(Of Integer)("Id_Umodificar")
    End Sub

    Property Id_Venta As Integer
        Get
            Return _Id_Venta
        End Get
        Set(value As Integer)
            _Id_Venta = value
        End Set
    End Property
    Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property
    Property IVA As Double
        Get
            Return _IVA
        End Get
        Set(value As Double)
            _IVA = value
        End Set
    End Property
    Property Subtotal As Double
        Get
            Return _Subtotal
        End Get
        Set(value As Double)
            _Subtotal = value
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
    Property Id_Cliente As Integer
        Get
            Return _Id_Cliente
        End Get
        Set(value As Integer)
            _Id_Cliente = value
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
    Function RegistrarVenta(id As Integer, fecha_ As Date, iva_ As Double, subtotal_ As Double,
                   status As Integer, idventa As Integer, idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("RegistroVentas", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Venta", id))
        cmd.Parameters.Add(New SqlParameter("Fecha", fecha_))
        cmd.Parameters.Add(New SqlParameter("@IVA", iva_))
        cmd.Parameters.Add(New SqlParameter("@Subtotal", subtotal_))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Cliente", idventa))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Venta = id
            Fecha = fecha_
            IVA = iva_
            Subtotal = subtotal_
            Estatus = status
            Id_Cliente = idventa
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function ModificarVenta(id As Integer, fecha_ As Date, iva_ As Double, subtotal_ As Double,
                   status As Integer, idcliente As Integer, idcrear As Integer, idmodificar As Integer)

        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("ModificarVentas", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Venta", id))
        cmd.Parameters.Add(New SqlParameter("Fecha", fecha_))
        cmd.Parameters.Add(New SqlParameter("@IVA", iva_))
        cmd.Parameters.Add(New SqlParameter("@Subtotal", subtotal_))
        cmd.Parameters.Add(New SqlParameter("@Estatus", status))
        cmd.Parameters.Add(New SqlParameter("@Id_Cliente", idcliente))
        cmd.Parameters.Add(New SqlParameter("@Id_Ucrear", idcrear))
        cmd.Parameters.Add(New SqlParameter("@Id_Umodificar", idmodificar))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Venta = id
            Fecha = fecha_
            IVA = iva_
            Subtotal = subtotal_
            Estatus = status
            Id_Cliente = idcliente
            Id_Ucrear = idcrear
            Id_Umodificar = idmodificar
        End If
        conn.Close()
        Return response
    End Function
    Function EliminarVenta(id As Integer)
        Dim response As Boolean = False
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("EliminarVentas", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id_Venta", id))
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read
                response = rdr("response")
            End While
        End Using
        If response = 1 Then
            Id_Venta = id
        End If
        conn.Close()
        Return response
    End Function
End Class
