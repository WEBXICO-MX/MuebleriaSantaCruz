Imports System.Data.SqlClient
Public Class frmAsentamiento
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM asentamientos ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                Tipos_asentamientosComboBox.Focus()
            Else
                txtID.Text = Lector("id") + 1
                Tipos_asentamientosComboBox.Focus()
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
        Dim Consulta As String = "INSERT INTO asentamientos (id, tipo_asentamiento_id, municipio_id, nombre, cp, activo) VALUES (@id, @tipo_asentamiento_id, @municipio_id, @nombre, @cp, @activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@tipo_asentamiento_id", SqlDbType.Int).Value = Tipos_asentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@municipio_id", SqlDbType.Int).Value = MunicipiosComboBox.SelectedValue
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@cp", SqlDbType.VarChar).Value = txtCP.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            Me.AsentamientosTableAdapter.Fill(Me.DataSetAsentamiento.asentamientos)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To AsentamientosDataGridView.Rows.Count - 1
                If (AsentamientosDataGridView.Item(2, Fila).Value = txtNombre.Text) Then
                    AsentamientosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El asentamiento '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            AsentamientosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El asentamiento ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim Consulta As String = "UPDATE asentamientos SET tipo_asentamiento_id = @tipo_asentamiento_id, municipio_id = @municipio_id, nombre = @nombre, cp = @cp, activo = @activo WHERE id = @id"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@tipo_asentamiento_id", SqlDbType.Int).Value = Tipos_asentamientosComboBox.SelectedValue
        Orden.Parameters.Add("@municipio_id", SqlDbType.Int).Value = MunicipiosComboBox.SelectedValue
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@cp", SqlDbType.VarChar).Value = txtCP.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            Me.AsentamientosTableAdapter.Fill(Me.DataSetAsentamiento.asentamientos)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El asentamiento '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            AsentamientosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El asentamiento ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtCP.Clear()
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
        Tipos_asentamientosComboBox.Enabled = nombre_status
        MunicipiosComboBox.Enabled = nombre_status
        txtNombre.Enabled = nombre_status
        txtCP.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = AsentamientosDataGridView.Rows(F).Cells(0).Value
        Tipos_asentamientosComboBox.SelectedValue = AsentamientosDataGridView.Rows(F).Cells(5).Value
        MunicipiosComboBox.SelectedValue = AsentamientosDataGridView.Rows(F).Cells(6).Value
        txtNombre.Text = AsentamientosDataGridView.Rows(F).Cells(2).Value
        txtCP.Text = AsentamientosDataGridView.Rows(F).Cells(3).Value
        cbxActivo.Checked = AsentamientosDataGridView.Rows(F).Cells(7).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
    End Sub

    Private Sub asentamientosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AsentamientosDataGridView.CellClick
        If (AsentamientosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub asentamientosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AsentamientosDataGridView.RowEnter
        If (AsentamientosDataGridView.Enabled = True) Then
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
        AsentamientosDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNombre.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombre, "Capture el nombre del asentamiento")
            txtNombre.Focus()
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
        AsentamientosDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = AsentamientosDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            AsentamientosDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione un asentamiento para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub frmAsentamiento_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (AsentamientosBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        AsentamientosDataGridView.ClearSelection()
    End Sub
    Private Sub frmAsentamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAsentamiento.asentamientos' table. You can move, or remove it, as needed.
        Me.AsentamientosTableAdapter.Fill(Me.DataSetAsentamiento.asentamientos)
        'TODO: This line of code loads data into the 'DataSetMunicipioCombo.municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DataSetMunicipioCombo.municipios)
        'TODO: This line of code loads data into the 'DataSetTipoAsentamientoCombo.tipos_asentamientos' table. You can move, or remove it, as needed.
        Me.Tipos_asentamientosTableAdapter.Fill(Me.DataSetTipoAsentamientoCombo.tipos_asentamientos)

    End Sub
End Class