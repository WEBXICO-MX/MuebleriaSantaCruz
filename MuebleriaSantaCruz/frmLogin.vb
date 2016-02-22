Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
    Private conexion As Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            login()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        Finally
            Conexion.cerrarConexion()
        End Try
    End Sub

    Public Sub login()

        If (txtUsuario.Text = "") Then
            Exit Sub
        End If

        If (txtContrasena.Text = "") Then
            Exit Sub
        End If

        conexion = New Conexion

        'Crear una consulta
        Dim Consulta As String = "SELECT * FROM usuarios WHERE activo=1 AND login = '" & txtUsuario.Text & "' AND password = '" & txtContrasena.Text & "'"

        Orden = New SqlCommand(Consulta, conexion.getConexion)

        'ExecuteReader hace la consulta y devuelve un SqlDataReader
        Lector = Orden.ExecuteReader()
        Lector.Read()

        If (Lector.HasRows = False) Then
            MessageBox.Show("El nombre de usuario o contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Clear()
            txtContrasena.Clear()
            txtUsuario.Focus()
        Else
            conexion.cerrarConexion()
            Me.Hide()

            frmMenuPrincipal.Show()

        End If
    End Sub
End Class
