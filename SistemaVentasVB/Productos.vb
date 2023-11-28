Imports System.Data.SqlClient
Imports BOSistemaVentasVB

Public Class Productos
    Dim producto As New BOProductos()
    Dim etiqueta As Boolean = True

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProductos()
    End Sub
    Public Sub Limpiar()
        txtIdProducto.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        txtDescripcion.Clear()
        txtEstatus.Clear()
        txtIdMarca.Clear()
        txtIdCategoria.Clear()
        txtIdCrear.Clear()
        txtIdModificar.Clear()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim conexion As String = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from Productos where Id_Producto = @Id_Producto", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@Id_Producto", txtIdProducto.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtNombre.Text = dt.Rows(0)(1).ToString
                    txtPrecio.Text = dt.Rows(0)(2).ToString
                    txtStock.Text = dt.Rows(0)(3).ToString
                    txtDescripcion.Text = dt.Rows(0)(4).ToString
                    If dt.Rows(0)(5) = True Then
                        txtEstatus.Text = 1
                    Else
                        txtEstatus.Text = 0
                    End If
                    txtIdMarca.Text = dt.Rows(0)(6).ToString
                    txtIdCategoria.Text = dt.Rows(0)(7).ToString
                    txtIdCrear.Text = dt.Rows(0)(8).ToString
                    txtIdModificar.Text = dt.Rows(0)(9).ToString
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        Limpiar()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtPrecio.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtStock.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtDescripcion.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEstatus.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdMarca.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCategoria.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = producto.RegistrarProducto(txtIdProducto.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtDescripcion.Text, txtEstatus.Text, txtIdMarca.Text, txtIdCategoria.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarProductos()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProducto.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtPrecio.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtStock.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtDescripcion.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEstatus.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdMarca.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCategoria.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = producto.ModificarProducto(txtIdProducto.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtDescripcion.Text, txtEstatus.Text, txtIdMarca.Text, txtIdCategoria.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarProductos()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProducto.Text)) Then
            valido = False
        End If

        If valido Then
            etiqueta = producto.EliminarProducto(txtIdProducto.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarProductos()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub
    Public Sub MostrarProductos()
        Dim cnn As SqlConnection = New SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;")
        Dim cmd = New SqlCommand("SELECT * FROM Productos", cnn)
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
        dgvProductos.DataSource = dt
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Marcas.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Categorias.Show()
    End Sub
End Class