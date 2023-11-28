Imports System.Data.SqlClient
Imports BOSistemaVentasVB

Public Class Proveedores
    Dim proveedor As New BOProveedores
    Dim etiqueta As Boolean = True

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProveedores()
    End Sub
    Public Sub Limpiar()
        txtIdProveedor.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtEstatus.Clear()
        txtIdCrear.Clear()
        txtIdModificar.Clear()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim conexion As String = "Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;"
        Dim conn As SqlConnection = New SqlConnection(conexion)
        conn.Open()
        Dim cmd As New SqlCommand("select * from Proveedores where Id_Proveedor = @Id_Proveedor", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New SqlParameter("@Id_Proveedor", txtIdProveedor.Text))
        Using sda As New SqlDataAdapter()
            sda.SelectCommand = cmd
            Using dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count Then
                    txtNombre.Text = dt.Rows(0)(1).ToString
                    txtDireccion.Text = dt.Rows(0)(2).ToString
                    txtTelefono.Text = dt.Rows(0)(3).ToString
                    txtEmail.Text = dt.Rows(0)(4).ToString
                    If dt.Rows(0)(5) = True Then
                        txtEstatus.Text = 1
                    Else
                        txtEstatus.Text = 0
                    End If
                    txtIdCrear.Text = dt.Rows(0)(6).ToString
                    txtIdModificar.Text = dt.Rows(0)(7).ToString
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        Limpiar()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProveedor.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtDireccion.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtTelefono.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEstatus.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = proveedor.RegistrarProveedor(txtIdProveedor.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtEstatus.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha registrado con Exito")
            Limpiar()
            MostrarProveedores()
        Else
            MsgBox("No se ha podido registrar la informacion.")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProveedor.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtDireccion.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtTelefono.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtEstatus.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdCrear.Text)) Then
            valido = False
        End If
        If (String.IsNullOrEmpty(txtIdModificar.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = proveedor.ModificarProveedor(txtIdProveedor.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtEstatus.Text, txtIdCrear.Text, txtIdModificar.Text)
            MsgBox("La informacion se ha modificado con Exito")
            Limpiar()
            MostrarProveedores()
        Else
            MsgBox("No se ha podido modificar la informacion.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim valido As Boolean = True

        If (String.IsNullOrEmpty(txtIdProveedor.Text)) Then
            valido = False
        End If
        If valido Then
            etiqueta = proveedor.EliminarProveedor(txtIdProveedor.Text)
            MsgBox("La informacion se ha modificado con Exito")
            Limpiar()
            MostrarProveedores()
        Else
            MsgBox("No se ha podido modificar la informacion.")
        End If
    End Sub
    Public Sub MostrarProveedores()
        Dim cnn As SqlConnection = New SqlConnection("Server=LAPTOP-I2RJCKLJ;Database=VENTAS; Integrated Security=True;")
        Dim cmd = New SqlCommand("SELECT * FROM Proveedores", cnn)
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
        dgvProveedores.DataSource = dt
    End Sub
End Class