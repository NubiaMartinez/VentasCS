Imports System.Data.SqlClient
Imports BOSistemaVentasVB

Public Class DetalleVenta
    Dim dventa As New BODetalleVenta
    Dim etiqueta As Boolean = True

    Private Sub DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDVentas()
    End Sub
    Public Sub Limpiar()
        txtIdDetalleVenta.Clear()
        txtCantidad.Clear()
        txtTotal.Clear()
        txtIdProducto.Clear()
        txtIdVenta.Clear()
        txtIdCrear.Clear()
        txtIdModificar.Clear()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim conexion As String = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from DetalleVenta where Id_DetalleVenta = @Id_DetalleVenta", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@Id_DetalleVenta", txtIdDetalleVenta.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtCantidad.Text = dt.Rows(0)(1).ToString
                    txtTotal.Text = dt.Rows(0)(2).ToString
                    txtIdProducto.Text = dt.Rows(0)(3).ToString
                    txtIdVenta.Text = dt.Rows(0)(4).ToString
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

        If (String.IsNullOrEmpty(txtIdDetalleVenta.Text)) Then
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
        If (String.IsNullOrEmpty(txtIdVenta.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dventa.RegistrarDVenta(txtIdVenta.Text, txtCantidad.Text, txtTotal.Text, txtIdProducto.Text, txtIdVenta.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdDetalleVenta.Text)) Then
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
        If (String.IsNullOrEmpty(txtIdVenta.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dventa.ModificarDVenta(txtIdVenta.Text, txtCantidad.Text, txtTotal.Text, txtIdProducto.Text, txtIdVenta.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdDetalleVenta.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = dventa.EliminarDVenta(txtIdVenta.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarDVentas()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub
    Public Sub MostrarDVentas()
        Dim cnn As SqlConnection = New SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;")
        Dim cmd = New SqlCommand("SELECT * FROM DetalleVentas", cnn)
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
        dgvDVenta.DataSource = dt
    End Sub

End Class