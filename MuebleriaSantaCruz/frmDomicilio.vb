Imports System.Data.SqlClient
Public Class frmDomicilio
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Public persona_id As Integer
    Public nombre_completo As String

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM domicilios ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                txtCP.Focus()
            Else
                txtID.Text = Lector("id") + 1
                txtCP.Focus()
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
        'Dim Consulta As String = "INSERT INTO domicilios (id, tipo_medio_comunicacion_id, persona_id, valor, activo) VALUES (" & txtID.Text & "," & (Tipos_domiciliosComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO domicilios (id, persona_id, asentamiento_id, tipo_vivienda_id, calle, numero_interior, numero_exterior, descripcion, fecha_registro, fecha_modificacion, activo) VALUES (@id, @persona_id, @asentamiento_id, @tipo_vivienda_id, @calle, @numero_interior, @numero_exterior, @descripcion, GETDATE(), NULL, @activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@asentamiento_id", SqlDbType.Int).Value = AsentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@tipo_vivienda_id", SqlDbType.Int).Value = Tipos_viviendasComboBox.SelectedValue
        Orden.Parameters.Add("@calle", SqlDbType.VarChar).Value = txtCalle.Text
        Orden.Parameters.Add("@numero_interior", SqlDbType.VarChar).Value = txtNumInt.Text
        Orden.Parameters.Add("@numero_exterior", SqlDbType.VarChar).Value = txtNumExt.Text
        Orden.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.DomiciliosTableAdapter.FillByPersonaId(Me.DataSetDomicilio.domicilios, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To DomiciliosDataGridView.Rows.Count - 1
                If (DomiciliosDataGridView.Item(3, Fila).Value = txtCalle.Text) Then
                    DomiciliosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El domicilio ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            DomiciliosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El domicilio ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim Consulta As String = "UPDATE domicilios SET persona_id = @persona_id, asentamiento_id = @asentamiento_id, tipo_vivienda_id = @tipo_vivienda_id, calle = @calle, numero_interior = @numero_interior, numero_exterior = @numero_exterior, descripcion = @descripcion, fecha_modificacion = GETDATE(), activo = @activo WHERE id = @id "
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@asentamiento_id", SqlDbType.Int).Value = AsentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@tipo_vivienda_id", SqlDbType.Int).Value = Tipos_viviendasComboBox.SelectedValue
        Orden.Parameters.Add("@calle", SqlDbType.VarChar).Value = txtCalle.Text
        Orden.Parameters.Add("@numero_interior", SqlDbType.VarChar).Value = txtNumInt.Text
        Orden.Parameters.Add("@numero_exterior", SqlDbType.VarChar).Value = txtNumExt.Text
        Orden.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.DomiciliosTableAdapter.FillByPersonaId(Me.DataSetDomicilio.domicilios, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El domicilio ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            DomiciliosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El domicilio ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtCP.Clear()
        txtNombreAsentamiento.Clear()
        txtCalle.Clear()
        txtNumInt.Clear()
        txtNumExt.Clear()
        txtDescripcion.Clear()
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
        txtCP.Enabled = nombre_status
        txtNombreAsentamiento.Enabled = nombre_status
        AsentamientosComboBox.Enabled = nombre_status
        Tipos_viviendasComboBox.Enabled = nombre_status
        txtCalle.Enabled = nombre_status
        txtNumInt.Enabled = nombre_status
        txtNumExt.Enabled = nombre_status
        txtDescripcion.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = DomiciliosDataGridView.Rows(F).Cells(0).Value
        Tipos_viviendasComboBox.SelectedValue = DomiciliosDataGridView.Rows(F).Cells(10).Value
        AsentamientosComboBox.SelectedValue = DomiciliosDataGridView.Rows(F).Cells(9).Value
        txtCalle.Text = DomiciliosDataGridView.Rows(F).Cells(3).Value
        txtNumInt.Text = DomiciliosDataGridView.Rows(F).Cells(4).Value
        txtNumExt.Text = DomiciliosDataGridView.Rows(F).Cells(5).Value
        txtDescripcion.Text = DomiciliosDataGridView.Rows(F).Cells(6).Value
        cbxActivo.Checked = DomiciliosDataGridView.Rows(F).Cells(13).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtCalle, Nothing)
    End Sub

    Private Sub domiciliosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DomiciliosDataGridView.CellClick
        If (DomiciliosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub domiciliosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DomiciliosDataGridView.RowEnter
        If (DomiciliosDataGridView.Enabled = True) Then
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
        DomiciliosDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtCalle.Text.Length = 0) Then
            ErrorProvider1.SetError(txtCalle, "Capture la calle por favor")
            txtCalle.Focus()
            Exit Sub
        End If

        If (txtNumInt.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNumInt, "Capture el numero interior por favor")
            txtNumInt.Focus()
            Exit Sub
        End If

        If (txtNumExt.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNumExt, "Capture el numero exterior por favor")
            txtNumExt.Focus()
            Exit Sub
        End If

        If (txtDescripcion.Text.Length = 0) Then
            ErrorProvider1.SetError(txtDescripcion, "Capture la descripción  por favor")
            txtDescripcion.Focus()
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
        DomiciliosDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = DomiciliosDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtCalle.Focus()
            EstadoBotones(False, True, True, False, False)
            DomiciliosDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione un domicilio para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtCalle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCalle.TextChanged
        If (txtCalle.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtCalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalle.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmMedioComunicacion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (DomiciliosBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        DomiciliosDataGridView.ClearSelection()
    End Sub
    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If e.KeyChar = Convert.ToChar(13) And txtCP.Text <> "" Then
            Me.AsentamientosTableAdapter.FillByCP(Me.DataSetAsentamientoCombo.asentamientos, txtCP.Text)
            AsentamientosComboBox.Enabled = True
        End If
    End Sub


    Private Sub txtNombreAsentamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreAsentamiento.KeyPress
        If e.KeyChar = Convert.ToChar(13) And txtCP.Text <> "" Then
            Me.AsentamientosTableAdapter.FillByNombre(Me.DataSetAsentamientoCombo.asentamientos, txtNombreAsentamiento.Text)
            AsentamientosComboBox.Enabled = True
        End If
    End Sub

    Private Sub frmDomicilio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetDomicilio.domicilios' Puede moverla o quitarla según sea necesario.
        Me.DomiciliosTableAdapter.FillByPersonaId(Me.DataSetDomicilio.domicilios, persona_id)
        'TODO: esta línea de código carga datos en la tabla 'DataSetTipoViviendaCombo.tipos_viviendas' Puede moverla o quitarla según sea necesario.
        Me.Tipos_viviendasTableAdapter.Fill(Me.DataSetTipoViviendaCombo.tipos_viviendas)
        txtNombreCompleto.Text = nombre_completo
    End Sub

End Class