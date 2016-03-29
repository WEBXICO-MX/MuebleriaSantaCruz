Imports System.Data.SqlClient
Public Class frmCliente
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
        'Dim Consulta As String = "INSERT INTO clientes (id, linea_producto_id, nombre,activo) VALUES (" & txtID.Text & "," & (OcupacionesComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO personas (id,nombre,ap_paterno,ap_materno,fecha_nacimiento,sexo) VALUES (@id,@nombre,@ap_paterno,@ap_materno,@fecha_nacimiento,@sexo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtApPaterno.Text
        Orden.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtApMaterno.Text
        Orden.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Format(dtpFechaNacimiento.Value, "dd-MM-yyyy")
        Orden.Parameters.Add("@sexo", SqlDbType.VarChar).Value = If(rbMasculino.Checked, "M", If(rbFemenino.Checked, "F", "X"))

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            If (Orden.ExecuteNonQuery() <> -1) Then

                Consulta = "INSERT INTO clientes (persona_id,ocupacion_id,tipo_identificacion_id,fecha_registro,activo) VALUES (@persona_id,@ocupacion_id,@tipo_identificacion_id,GETDATE(),@activo)"
                Orden = New SqlCommand(Consulta, objcon.con)
                Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = txtID.Text
                Orden.Parameters.Add("@ocupacion_id", SqlDbType.Int).Value = OcupacionesComboBox.SelectedValue
                Orden.Parameters.Add("@tipo_identificacion_id", SqlDbType.Int).Value = Tipos_identificacionComboBox.SelectedValue
                Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)

                Orden.ExecuteNonQuery()

            End If

            Me.ClientesTableAdapter.Fill(Me.DataSetCliente.clientes)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To clientesDataGridView.Rows.Count - 1
                If (ClientesDataGridView.Item(3, Fila).Value = txtNombre.Text And ClientesDataGridView.Item(4, Fila).Value = txtApPaterno.Text And ClientesDataGridView.Item(5, Fila).Value = txtApMaterno.Text) Then
                    ClientesDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El cliente '" & (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text) & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            clientesDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'Dim Consulta As String = "UPDATE clientes SET linea_producto_id = " & (OcupacionesComboBox.SelectedValue) & ", nombre = '" & txtNombre.Text & "', activo = " & (If(cbxActivo.Checked, 1, 0)) & " WHERE id = " & txtID.Text
        Dim Consulta As String = "UPDATE personas SET nombre = @nombre, ap_paterno = @ap_paterno, ap_materno = @ap_materno, fecha_nacimiento = @fecha_nacimiento, sexo = @sexo WHERE id = @id"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtApPaterno.Text
        Orden.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtApMaterno.Text
        Orden.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Format(dtpFechaNacimiento.Value, "dd-MM-yyyy")
        Orden.Parameters.Add("@sexo", SqlDbType.VarChar).Value = If(rbMasculino.Checked, "M", If(rbFemenino.Checked, "F", "X"))
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            If (Orden.ExecuteNonQuery <> -1) Then

                Consulta = "UPDATE clientes SET ocupacion_id = @ocupacion_id, tipo_identificacion_id = @tipo_identificacion_id, activo = @activo WHERE persona_id = @persona_id"
                Orden = New SqlCommand(Consulta, objcon.con)
                Orden.Parameters.Add("@ocupacion_id", SqlDbType.VarChar).Value = OcupacionesComboBox.SelectedValue
                Orden.Parameters.Add("@tipo_identificacion_id", SqlDbType.VarChar).Value = Tipos_identificacionComboBox.SelectedValue
                Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
                Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = txtID.Text

                Orden.ExecuteNonQuery()


            End If

            Me.ClientesTableAdapter.Fill(Me.DataSetCliente.clientes)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El cliente '" & (txtNombre.Text & " " & txtApPaterno.Text & " " & txtApMaterno.Text) & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            clientesDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtNombre.Clear()
        txtApPaterno.Clear()
        txtApMaterno.Clear()
        dtpFechaNacimiento.ResetText()
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
        OcupacionesComboBox.Enabled = nombre_status
        Tipos_identificacionComboBox.Enabled = nombre_status
        txtNombre.Enabled = nombre_status
        txtApPaterno.Enabled = nombre_status
        txtApMaterno.Enabled = nombre_status
        dtpFechaNacimiento.Enabled = nombre_status
        rbMasculino.Enabled = nombre_status
        rbFemenino.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = clientesDataGridView.Rows(F).Cells(0).Value
        OcupacionesComboBox.SelectedValue = ClientesDataGridView.Rows(F).Cells(8).Value
        Tipos_identificacionComboBox.SelectedValue = ClientesDataGridView.Rows(F).Cells(9).Value
        txtNombre.Text = ClientesDataGridView.Rows(F).Cells(3).Value
        txtApPaterno.Text = ClientesDataGridView.Rows(F).Cells(4).Value
        txtApMaterno.Text = ClientesDataGridView.Rows(F).Cells(5).Value
        If (ClientesDataGridView.Rows(F).Cells(7).Value = "M") Then
            rbMasculino.Checked = True
            rbFemenino.Checked = False
        Else
            rbFemenino.Checked = True
            rbMasculino.Checked = False
        End If
        dtpFechaNacimiento.Text = ClientesDataGridView.Rows(F).Cells(6).Value
        cbxActivo.Checked = ClientesDataGridView.Rows(F).Cells(11).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
    End Sub

    Private Sub clientesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        If (clientesDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub clientesDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.RowEnter
        If (clientesDataGridView.Enabled = True) Then
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
        clientesDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
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
        clientesDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = clientesDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            clientesDataGridView.Enabled = False
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

    Private Sub frmEmpleado_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (clientesBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        clientesDataGridView.ClearSelection()
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCliente.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSetCliente.clientes)
        'TODO: esta línea de código carga datos en la tabla 'DataSetTipoIdentificacionCombo.tipos_identificacion' Puede moverla o quitarla según sea necesario.
        Me.Tipos_identificacionTableAdapter.Fill(Me.DataSetTipoIdentificacionCombo.tipos_identificacion)
        'TODO: esta línea de código carga datos en la tabla 'DataSetOcupacionCombo.ocupaciones' Puede moverla o quitarla según sea necesario.
        Me.OcupacionesTableAdapter.Fill(Me.DataSetOcupacionCombo.ocupaciones)

    End Sub
End Class