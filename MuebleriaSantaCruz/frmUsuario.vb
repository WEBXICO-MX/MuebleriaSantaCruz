﻿Imports System.Data.SqlClient

Public Class frmUsuario
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM Usuarios ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                txtNombre.Focus()
            Else
                txtID.Text = Lector("id") + 1
                txtNombre.Focus()
            End If

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)
            CerrarConexion()
        End Try
    End Sub

    Public Sub InsertaNuevo()

        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "INSERT INTO Usuarios (id, nombre_completo,login,password,fecha_reg,fecha_mod,activo) VALUES (" & txtID.Text & ",'" & txtNombre.Text & "','" & txtLogin.Text & "','" & txtPassword.Text & "'," & "GETDATE()" & ",NULL," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Orden = New SqlCommand(Consulta, objcon.con)

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            Me.UsuariosTableAdapter.Fill(Me.DataSetUsuario.Usuarios)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To UsuariosDataGridView.Rows.Count - 1
                If (UsuariosDataGridView.Item(1, Fila).Value = txtNombre.Text) Then
                    UsuariosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El Usuario '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            UsuariosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El Usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (ex.Number = 2627) Then
                MessageBox.Show("El ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Error: " + ex.Message)
            End If

            CerrarConexion()
        End Try
    End Sub

    Public Sub Editar()
        'Crear la conexión con la base de datos
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "UPDATE Usuarios SET nombre_completo = '" & txtNombre.Text &
                                 "', login='" & txtLogin.Text &
                                 "', password='" & txtPassword.Text &
                                 "', activo = " & (If(cbxActivo.Checked, 1, 0)) & ", fecha_mod = GETDATE() WHERE id = " & txtID.Text
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            Me.UsuariosTableAdapter.Fill(Me.DataSetUsuario.Usuarios)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To UsuariosDataGridView.Rows.Count - 1
                If (UsuariosDataGridView.Item(1, Fila).Value = txtNombre.Text) Then
                    UsuariosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila


            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("La Usuario '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            UsuariosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("La Usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (ex.Number = 2627) Then
                MessageBox.Show("El ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Error: " + ex.Message)
            End If

            CerrarConexion()
        End Try
    End Sub

    Public Sub CerrarConexion()
        ' Cerrar la conexión cuando ya no sea necesaria
        If (Not Lector Is Nothing) Then
            Lector.Close()
        End If
        If (objcon.con.State = ConnectionState.Open) Then objcon.con.Close()
    End Sub

    Private Sub LimpiarCajasdeTexto()
        txtID.Text = ""
        txtNombre.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        cbxActivo.Checked = True
    End Sub

    Private Sub EstadoBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal deshacer As Boolean, ByVal editar As Boolean, ByVal buscar As Boolean)
        btnuevo.Enabled = nuevo
        btguardar.Enabled = guardar
        btdeshacer.Enabled = deshacer
        bteditar.Enabled = editar
        btbuscar.Enabled = buscar
    End Sub

    Private Sub EstadoCajasdeTexto(ByVal nombre_status As Boolean)
        txtNombre.Enabled = nombre_status
        txtLogin.Enabled = nombre_status
        txtPassword.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = UsuariosDataGridView.Rows(F).Cells(0).Value
        txtNombre.Text = UsuariosDataGridView.Rows(F).Cells(1).Value
        txtLogin.Text = UsuariosDataGridView.Rows(F).Cells(2).Value
        txtPassword.Text = UsuariosDataGridView.Rows(F).Cells(3).Value
        cbxActivo.Checked = UsuariosDataGridView.Rows(F).Cells(6).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
        ErrorProvider1.SetError(txtLogin, Nothing)
        ErrorProvider1.SetError(txtPassword, Nothing)
    End Sub

    Private Sub UsuariosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellClick
        If (UsuariosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub UsuariosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.RowEnter
        If (UsuariosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub btnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        lbtipoestado.Visible = True
        lbtipoestado.Text = "Nuevo"
        EstadoBotones(False, True, True, False, False)
        LimpiarCajasdeTexto()
        EstadoCajasdeTexto(True)
        UsuariosDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNombre.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombre, "Capture el nombre de la Usuario")
            txtNombre.Focus()
            Exit Sub
        End If

        If (txtLogin.Text.Length = 0) Then
            ErrorProvider1.SetError(txtLogin, "Capture el login")
            txtLogin.Focus()
            Exit Sub
        End If

        If (txtPassword.Text.Length = 0) Then
            ErrorProvider1.SetError(txtPassword, "Capture el password")
            txtPassword.Focus()
            Exit Sub
        End If

        DesactivarErroresCajasdeTexto()

        If (lbtipoestado.Text = "Nuevo") Then
            InsertaNuevo()
        Else
            Editar()
        End If
    End Sub

    Private Sub btdeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdeshacer.Click
        lbtipoestado.Visible = False
        lbtipoestado.Text = ""

        LimpiarCajasdeTexto()
        EstadoCajasdeTexto(False)
        EstadoBotones(True, False, False, False, True)
        UsuariosDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = UsuariosDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            UsuariosDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione una Usuario para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtPassword.TextChanged, txtLogin.TextChanged
        If (txtNombre.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtPassword.KeyPress, txtLogin.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmUsuario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (UsuariosBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        UsuariosDataGridView.ClearSelection()
    End Sub


    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.DataSetUsuario.usuarios)
        Me.Top = 100
    End Sub
End Class