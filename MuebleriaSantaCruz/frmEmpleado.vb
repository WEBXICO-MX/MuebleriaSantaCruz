﻿Imports System.Data.SqlClient
Public Class frmEmpleado
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM personas ORDER BY id DESC"
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
        'Dim Consulta As String = "INSERT INTO empleados (id, linea_producto_id, nombre,activo) VALUES (" & txtID.Text & "," & (PuestosComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO personas (id,nombre,ap_paterno,ap_materno,fecha_nacimiento,sexo,estado_civil_id,fecha_registro,fecha_modificacion,activo) VALUES (@id,@nombre,@ap_paterno,@ap_materno,@fecha_nacimiento,@sexo,@estado_civil_id,GETDATE(),NULL,@activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtApPaterno.Text
        Orden.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtApMaterno.Text
        Orden.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Format(dtpFechaNacimiento.Value, "dd-MM-yyyy")
        Orden.Parameters.Add("@sexo", SqlDbType.VarChar).Value = If(rbMasculino.Checked, "M", If(rbFemenino.Checked, "F", "X"))
        Orden.Parameters.Add("@estado_civil_id", SqlDbType.Int).Value = Estados_civilesComboBox.SelectedValue
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            If (Orden.ExecuteNonQuery() <> -1) Then

                Consulta = "INSERT INTO empleados (persona_id,puesto_id,fecha_laboral_inicio, fecha_laboral_fin,fecha_registro,fecha_modificacion,activo) VALUES (@persona_id,@puesto_id,@fecha_laboral_inicio, @fecha_laboral_fin,GETDATE(),NULL,@activo)"
                Orden = New SqlCommand(Consulta, objcon.con)
                Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = txtID.Text
                Orden.Parameters.Add("@puesto_id", SqlDbType.Int).Value = PuestosComboBox.SelectedValue
                Orden.Parameters.Add("@fecha_laboral_inicio", SqlDbType.Date).Value = Format(dtpFechaLaboralInicio.Value, "dd-MM-yyyy")
                Orden.Parameters.Add("@fecha_laboral_fin", SqlDbType.Date).Value = Format(dtpFechaLaboralFin.Value, "dd-MM-yyyy")
                Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)

                Orden.ExecuteNonQuery()

            End If

            Me.EmpleadosTableAdapter.Fill(Me.DataSetEmpleado.empleados)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To EmpleadosDataGridView.Rows.Count - 1
                If (EmpleadosDataGridView.Item(1, Fila).Value = txtNombre.Text And EmpleadosDataGridView.Item(2, Fila).Value = txtApPaterno.Text And EmpleadosDataGridView.Item(3, Fila).Value = txtApMaterno.Text) Then
                    EmpleadosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El empleado '" & (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text) & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            EmpleadosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El empleado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'Dim Consulta As String = "UPDATE empleados SET linea_producto_id = " & (PuestosComboBox.SelectedValue) & ", nombre = '" & txtNombre.Text & "', activo = " & (If(cbxActivo.Checked, 1, 0)) & " WHERE id = " & txtID.Text
        Dim Consulta As String = "UPDATE personas SET nombre = @nombre, ap_paterno = @ap_paterno, ap_materno = @ap_materno, fecha_nacimiento = @fecha_nacimiento, sexo = @sexo, estado_civil_id = @estado_civil_id, fecha_modificacion = GETDATE(), activo = @activo WHERE id = @id"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtApPaterno.Text
        Orden.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtApMaterno.Text
        Orden.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Format(dtpFechaNacimiento.Value, "dd-MM-yyyy")
        Orden.Parameters.Add("@sexo", SqlDbType.VarChar).Value = If(rbMasculino.Checked, "M", If(rbFemenino.Checked, "F", "X"))
        Orden.Parameters.Add("@estado_civil_id", SqlDbType.Int).Value = Estados_civilesComboBox.SelectedValue
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            If (Orden.ExecuteNonQuery <> -1) Then

                Consulta = "UPDATE empleados SET puesto_id = @puesto_id,fecha_laboral_inicio = @fecha_laboral_inicio, fecha_laboral_fin = @fecha_laboral_fin, fecha_modificacion = GETDATE(),activo = @activo WHERE persona_id = @persona_id"
                Orden = New SqlCommand(Consulta, objcon.con)
                Orden.Parameters.Add("@puesto_id", SqlDbType.VarChar).Value = PuestosComboBox.SelectedValue
                Orden.Parameters.Add("@fecha_laboral_inicio", SqlDbType.Date).Value = Format(dtpFechaLaboralInicio.Value, "dd-MM-yyyy")
                Orden.Parameters.Add("@fecha_laboral_fin", SqlDbType.Date).Value = Format(dtpFechaLaboralFin.Value, "dd-MM-yyyy")
                Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
                Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = txtID.Text

                Orden.ExecuteNonQuery()


            End If

            Me.EmpleadosTableAdapter.Fill(Me.DataSetEmpleado.empleados)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To EmpleadosDataGridView.Rows.Count - 1
                If (EmpleadosDataGridView.Item(1, Fila).Value = txtNombre.Text And EmpleadosDataGridView.Item(2, Fila).Value = txtApPaterno.Text And EmpleadosDataGridView.Item(3, Fila).Value = txtApMaterno.Text) Then
                    EmpleadosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El empleado '" & (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text) & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            EmpleadosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El empleado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtID.Clear()
        PuestosComboBox.Text = ""
        txtNombre.Clear()
        txtApPaterno.Clear()
        txtApMaterno.Clear()
        dtpFechaNacimiento.ResetText()
        Estados_civilesComboBox.Text = ""
        rbMasculino.Checked = False
        rbFemenino.Checked = False
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
        PuestosComboBox.Enabled = nombre_status
        Estados_civilesComboBox.Enabled = nombre_status
        txtNombre.Enabled = nombre_status
        txtApPaterno.Enabled = nombre_status
        txtApMaterno.Enabled = nombre_status
        dtpFechaNacimiento.Enabled = nombre_status
        dtpFechaLaboralInicio.Enabled = nombre_status
        dtpFechaLaboralFin.Enabled = nombre_status
        rbMasculino.Enabled = nombre_status
        rbFemenino.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = EmpleadosDataGridView.Rows(F).Cells(0).Value
        PuestosComboBox.Text = EmpleadosDataGridView.Rows(F).Cells(7).Value
        Estados_civilesComboBox.Text = EmpleadosDataGridView.Rows(F).Cells(6).Value
        txtNombre.Text = EmpleadosDataGridView.Rows(F).Cells(1).Value
        txtApPaterno.Text = EmpleadosDataGridView.Rows(F).Cells(2).Value
        txtApMaterno.Text = EmpleadosDataGridView.Rows(F).Cells(3).Value
        If (EmpleadosDataGridView.Rows(F).Cells(5).Value = "M") Then
            rbMasculino.Checked = True
            rbFemenino.Checked = False
        Else
            rbFemenino.Checked = True
            rbMasculino.Checked = False
        End If
        dtpFechaNacimiento.Text = EmpleadosDataGridView.Rows(F).Cells(4).Value
        dtpFechaLaboralInicio.Text = EmpleadosDataGridView.Rows(F).Cells(8).Value
        dtpFechaLaboralFin.Text = EmpleadosDataGridView.Rows(F).Cells(9).Value
        cbxActivo.Checked = EmpleadosDataGridView.Rows(F).Cells(13).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
    End Sub

    Private Sub empleadosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellClick
        If (EmpleadosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub empleadosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.RowEnter
        If (EmpleadosDataGridView.Enabled = True) Then
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
        EmpleadosDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
        PuestosComboBox.Focus()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNombre.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombre, "Capture el nombre del empleado")
            txtNombre.Focus()
            Exit Sub
        End If

        If (txtApPaterno.Text.Length = 0) Then
            ErrorProvider1.SetError(txtApPaterno, "Capture el apellido paterno del empleado")
            txtApPaterno.Focus()
            Exit Sub
        End If

        If (txtApMaterno.Text.Length = 0) Then
            ErrorProvider1.SetError(txtApMaterno, "Capture el apellido materno del empleado")
            txtApMaterno.Focus()
            Exit Sub
        End If

        If (rbMasculino.Checked = False And rbFemenino.Checked = False) Then
            ErrorProvider1.SetError(rbFemenino, "Elija el sexo del empleado")
            rbMasculino.Focus()
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
        EmpleadosDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = EmpleadosDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            EmpleadosDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione un empleado para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If (txtNombre.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtApPaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApPaterno.TextChanged
        If (txtApPaterno.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtApPaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApPaterno.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtApMaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApMaterno.TextChanged
        If (txtApMaterno.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtApMaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApMaterno.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub rbMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rbMasculino.CheckedChanged
        If (rbMasculino.Checked) Then
            ErrorProvider1.SetError(rbMasculino, Nothing)
        End If
    End Sub


    Private Sub rbFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemenino.CheckedChanged
        If (rbFemenino.Checked) Then
            ErrorProvider1.SetError(rbFemenino, Nothing)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (txtID.Text <> "") Then

            frmMedioComunicacion.persona_id = Convert.ToInt32(txtID.Text)
            frmMedioComunicacion.nombre_completo = (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text)
            frmMedioComunicacion.Show()

        Else
            MsgBox("Debe cargar previamente a un empleado para entrar a esta opción")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If (txtID.Text <> "") Then

            frmDomicilio.persona_id = Convert.ToInt32(txtID.Text)
            frmDomicilio.nombre_completo = (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text)
            frmDomicilio.Show()

        Else
            MsgBox("Debe cargar previamente a un empleado para entrar a esta opción")
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If (txtID.Text <> "") Then

            frmReferencia.persona_id = Convert.ToInt32(txtID.Text)
            frmReferencia.nombre_completo = (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text)
            frmReferencia.Show()

        Else
            MsgBox("Debe cargar previamente a un cliente para entrar a esta opción")
        End If
    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetEstadoCivilCombo.estados_civiles' Puede moverla o quitarla según sea necesario.
        Me.Estados_civilesTableAdapter.Fill(Me.DataSetEstadoCivilCombo.estados_civiles)
        'TODO: esta línea de código carga datos en la tabla 'DataSetEmpleado.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetEmpleado.empleados)
        'TODO: esta línea de código carga datos en la tabla 'DataSetPuestoCombo.puestos' Puede moverla o quitarla según sea necesario.
        Me.PuestosTableAdapter.Fill(Me.DataSetPuestoCombo.puestos)

        Me.Top = 100
    End Sub

    Private Sub frmEmpleado_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (EmpleadosBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        EmpleadosDataGridView.ClearSelection()

        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()
    End Sub
End Class