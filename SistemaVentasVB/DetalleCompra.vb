Imports BOSistemaVentasVB
Imports System.Data.SqlClient

Public Class DetalleCompra
    Dim dcompra As New BODetalleCompra
    Dim etiqueta As Boolean = True

    Private Sub DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDVentas()
    End Sub
    Public Sub Limpiar()
        txtIdDetalleCompra.Clear()
        txtCantidad.Clear()
        txtTotal.Clear()
        txtIdProducto.Clear()
        txtIdCompra.Clear()
        txtIdCrear.Clear()
        txtIdModificar.Clear()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim conexion As String = "Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from DetalleCompra where Id_DetalleCompra = @Id_DetalleCompra", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleCompra", txtIdDetalleCompra.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtCantidad.Text = dt.Rows(0)(1).ToString
                    txtTotal.Text = dt.Rows(0)(2).ToString
                    txtIdProducto.Text = dt.Rows(0)(3).ToString
                    txtIdCompra.Text = dt.Rows(0)(4).ToString
                    txtIdCrear.Text = dt.Rows(0)(5).ToString
                    txtIdModificar.Text = dt.Rows(0)(6).ToString
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        Limpiar()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdDetalleCompra.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtCantidad.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtTotal.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdProducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCompra.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dcompra.RegistrarDCompra(txtIdCompra.Text, txtCantidad.Text, txtTotal.Text, txtIdProducto.Text, txtIdCompra.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdDetalleCompra.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtCantidad.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtTotal.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdProducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCompra.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dcompra.ModificarDCompra(txtIdCompra.Text, txtCantidad.Text, txtTotal.Text, txtIdProducto.Text, txtIdCompra.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdDetalleCompra.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dcompra.EliminarDCompra(txtIdCompra.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub
    Public Sub MostrarDVentas()
        Dim cnn As SqlConnection = New SqlConnection("Server=Server=LAPTOP-I2RJCKLJL;Database=VENTAS; Integrated Security=True;")
        Dim cmd = New SqlCommand("SELECT * FROM DetalleCompras", cnn)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt = New DataTable()
        Try
            cnn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

        ' Mostrar los datos en el DataGridView
        dgvDCompra.DataSource = dt
    End Sub
End Class