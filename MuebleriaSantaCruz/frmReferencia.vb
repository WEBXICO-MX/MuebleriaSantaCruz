Imports System.Data.SqlClient
Public Class frmReferencia
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Public persona_id As Integer
    Public nombre_completo As String

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM referencias ORDER BY id DESC"
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
        'Dim Consulta As String = "INSERT INTO referencias (id, tipo_medio_comunicacion_id, persona_id, valor, activo) VALUES (" & txtID.Text & "," & (Tipos_referenciasComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO referencias (id, persona_id, nombre_completo,asentamiento_id, calle, numero_interior, numero_exterior, 
        telefono, anios_conocerlo, parentesco, fecha_registro, fecha_modificacion, activo) 
        VALUES (@id, @persona_id, @nombre_completo, @asentamiento_id, @calle, @numero_interior, @numero_exterior, @telefono, @anios_conocerlo, @parentesco,  GETDATE(), NULL, @activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@nombre_completo", SqlDbType.VarChar).Value = txtNombreCompleto.Text
        Orden.Parameters.Add("@asentamiento_id", SqlDbType.Int).Value = AsentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@calle", SqlDbType.VarChar).Value = txtCalle.Text
        Orden.Parameters.Add("@numero_interior", SqlDbType.VarChar).Value = txtNumInt.Text
        Orden.Parameters.Add("@numero_exterior", SqlDbType.VarChar).Value = txtNumExt.Text
        Orden.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text
        Orden.Parameters.Add("@anios_conocerlo", SqlDbType.VarChar).Value = txtAniosConocerlo.Text
        Orden.Parameters.Add("@parentesco", SqlDbType.VarChar).Value = txtParentesco.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.ReferenciasTableAdapter.FillByPersonaId(Me.DataSetReferencia.referencias, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To ReferenciasDataGridView.Rows.Count - 1
                If (ReferenciasDataGridView.Item(3, Fila).Value = txtCalle.Text) Then
                    ReferenciasDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("La referencia ha sido guardada", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            ReferenciasDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("La referencia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim Consulta As String = "UPDATE referencias SET persona_id = @persona_id, nombre_completo = @nombre_completo,asentamiento_id = @asentamiento_id,
        calle = @calle, numero_interior = @numero_interior, numero_exterior = @numero_exterior, telefono = @telefono, 
        anios_conocerlo = @anios_conocerlo,parentesco = @parentesco,fecha_modificacion = GETDATE(), activo = @activo 
        WHERE id = @id "
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@nombre_completo", SqlDbType.VarChar).Value = txtNombreCompleto.Text
        Orden.Parameters.Add("@asentamiento_id", SqlDbType.Int).Value = AsentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@calle", SqlDbType.VarChar).Value = txtCalle.Text
        Orden.Parameters.Add("@numero_interior", SqlDbType.VarChar).Value = txtNumInt.Text
        Orden.Parameters.Add("@numero_exterior", SqlDbType.VarChar).Value = txtNumExt.Text
        Orden.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text
        Orden.Parameters.Add("@anios_conocerlo", SqlDbType.VarChar).Value = txtAniosConocerlo.Text
        Orden.Parameters.Add("@parentesco", SqlDbType.VarChar).Value = txtParentesco.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.ReferenciasTableAdapter.FillByPersonaId(Me.DataSetReferencia.referencias, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("La referencia ha sido guardada", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            ReferenciasDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("La referencia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtNombreCompleto.Clear()
        txtCalle.Clear()
        txtNumInt.Clear()
        txtNumExt.Clear()
        txtTelefono.Clear()
        txtAniosConocerlo.Clear()
        txtParentesco.Clear()
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
        txtNombreCompleto.Enabled = nombre_status
        AsentamientosComboBox.Enabled = nombre_status
        txtCalle.Enabled = nombre_status
        txtNumInt.Enabled = nombre_status
        txtNumExt.Enabled = nombre_status
        txtTelefono.Enabled = nombre_status
        txtAniosConocerlo.Enabled = nombre_status
        txtParentesco.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = ReferenciasDataGridView.Rows(F).Cells(0).Value
        txtNombreCompleto.Text = ReferenciasDataGridView.Rows(F).Cells(1).Value
        AsentamientosComboBox.SelectedValue = ReferenciasDataGridView.Rows(F).Cells(12).Value
        txtCalle.Text = ReferenciasDataGridView.Rows(F).Cells(3).Value
        txtNumInt.Text = ReferenciasDataGridView.Rows(F).Cells(4).Value
        txtNumExt.Text = ReferenciasDataGridView.Rows(F).Cells(5).Value
        txtTelefono.Text = ReferenciasDataGridView.Rows(F).Cells(6).Value
        txtAniosConocerlo.Text = ReferenciasDataGridView.Rows(F).Cells(7).Value
        txtParentesco.Text = ReferenciasDataGridView.Rows(F).Cells(8).Value
        cbxActivo.Checked = ReferenciasDataGridView.Rows(F).Cells(13).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtCalle, Nothing)
    End Sub

    Private Sub referenciasDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReferenciasDataGridView.CellClick
        If (ReferenciasDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub referenciasDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReferenciasDataGridView.RowEnter
        If (ReferenciasDataGridView.Enabled = True) Then
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
        ReferenciasDataGridView.Enabled = False
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

        If (txtTelefono.Text.Length = 0) Then
            ErrorProvider1.SetError(txtTelefono, "Capture el telefono por favor")
            txtTelefono.Focus()
            Exit Sub
        End If

        If (txtAniosConocerlo.Text.Length = 0) Then
            ErrorProvider1.SetError(txtAniosConocerlo, "Capture los años de conocerlo por favor")
            txtAniosConocerlo.Focus()
            Exit Sub
        End If

        If (txtParentesco.Text.Length = 0) Then
            ErrorProvider1.SetError(txtParentesco, "Capture el parentesco por favor")
            txtParentesco.Focus()
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
        ReferenciasDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = ReferenciasDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtCalle.Focus()
            EstadoBotones(False, True, True, False, False)
            ReferenciasDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione una referencia para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If (ReferenciasBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        ReferenciasDataGridView.ClearSelection()
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
    Private Sub frmReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetReferencia.referencias' table. You can move, or remove it, as needed.
        Me.ReferenciasTableAdapter.FillByPersonaId(Me.DataSetReferencia.referencias, persona_id)
        Me.AsentamientosTableAdapter.Fill(Me.DataSetAsentamientoCombo.asentamientos)
        Me.Top = 85
        txtCliente.Text = nombre_completo

    End Sub

End Class