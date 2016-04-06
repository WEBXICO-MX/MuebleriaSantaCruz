Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
    Private cmd As SqlCommand
    Private objcon As New Conexion
    Private lector As SqlDataReader

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            login()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        Finally
            If (objcon.con.State = ConnectionState.Open) Then objcon.con.Close()
        End Try
    End Sub

    Public Sub login()

        If (txtUsuario.Text = "" Or txtContrasena.Text = "") Then
            Exit Sub
        End If

        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim sql As String = "SELECT * FROM usuarios WHERE login = @login AND password = @password AND activo=1"
        cmd = New SqlCommand(sql, objcon.con)
        cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = txtUsuario.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtContrasena.Text

        'ExecuteReader hace la consulta y devuelve un SqlDataReader
        lector = cmd.ExecuteReader()
        lector.Read()

        If (lector.HasRows = False) Then
            MessageBox.Show("El nombre de usuario o contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Clear()
            txtContrasena.Clear()
            txtUsuario.Focus()
        Else
            objcon.con.Close()
            Me.Hide()
            frmMenuPrincipal.Show()
        End If
    End Sub
End Class
