
Imports System.Data.SqlClient

Public Class Login

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim conn = New SqlConnection("Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true")
        conn.Open()
        Dim query As String = ("select * from Usuarios where NombreUsuario= '" & txtUsuario.Text & "' and Contraseña= '" & txtPassword.Text & "'")
        Dim cmd As New SqlCommand(query, conn)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            MessageBox.Show("Acceso Exitoso")
            Inicio.ShowDialog()
        Else
            MessageBox.Show("Este usuario no existe o los datos son incorrectos.")
        End If
        conn.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class