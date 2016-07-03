Imports System.Data.SqlClient
Public Class frmMedioComunicacion
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Public persona_id As Integer
    Public nombre_completo As String

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM medios_comunicacion ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                Tipos_medios_comunicacionComboBox.Focus()
            Else
                txtID.Text = Lector("id") + 1
                Tipos_medios_comunicacionComboBox.Focus()
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
        'Dim Consulta As String = "INSERT INTO medios_comunicacion (id, tipo_medio_comunicacion_id, persona_id, valor, activo) VALUES (" & txtID.Text & "," & (Tipos_medios_comunicacionComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO medios_comunicacion (id, tipo_medio_comunicacion_id, persona_id, valor, fecha_registro, fecha_modificacion, activo) VALUES (@id,@tipo_medio_comunicacion_id,@persona_id,@valor,GETDATE(),NULL,@activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@tipo_medio_comunicacion_id", SqlDbType.Int).Value = Tipos_medios_comunicacionComboBox.SelectedValue
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@valor", SqlDbType.VarChar).Value = txtDato.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.Medios_comunicacionTableAdapter.FillBy(Me.DataSetMedioDeComunicacion.medios_comunicacion, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To Medios_comunicacionDataGridView.Rows.Count - 1
                If (Medios_comunicacionDataGridView.Item(2, Fila).Value = txtDato.Text) Then
                    Medios_comunicacionDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El medio de comunicación '" & txtDato.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            Medios_comunicacionDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("La ruta ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim Consulta As String = "UPDATE medios_comunicacion SET tipo_medio_comunicacion_id = @tipo_medio_comunicacion_id, persona_id = @persona_id, valor = @valor, fecha_modificacion = GETDATE(), activo = @activo WHERE id = @id "
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@tipo_medio_comunicacion_id", SqlDbType.Int).Value = Tipos_medios_comunicacionComboBox.SelectedValue
        Orden.Parameters.Add("@persona_id", SqlDbType.Int).Value = persona_id
        Orden.Parameters.Add("@valor", SqlDbType.VarChar).Value = txtDato.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.Medios_comunicacionTableAdapter.FillBy(Me.DataSetMedioDeComunicacion.medios_comunicacion, persona_id)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To Medios_comunicacionDataGridView.Rows.Count - 1
                If (Medios_comunicacionDataGridView.Item(2, Fila).Value = txtDato.Text) Then
                    Medios_comunicacionDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila


            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El medio de comunicación '" & txtDato.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            Medios_comunicacionDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El medio de comunicación ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtDato.Clear()
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
        Tipos_medios_comunicacionComboBox.Enabled = nombre_status
        txtDato.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = Medios_comunicacionDataGridView.Rows(F).Cells(0).Value
        Tipos_medios_comunicacionComboBox.SelectedValue = Medios_comunicacionDataGridView.Rows(F).Cells(4).Value
        txtDato.Text = Medios_comunicacionDataGridView.Rows(F).Cells(2).Value
        cbxActivo.Checked = Medios_comunicacionDataGridView.Rows(F).Cells(6).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
    End Sub

    Private Sub medios_comunicacionDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Medios_comunicacionDataGridView.CellClick
        If (Medios_comunicacionDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub medios_comunicacionDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Medios_comunicacionDataGridView.RowEnter
        If (Medios_comunicacionDataGridView.Enabled = True) Then
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
        Medios_comunicacionDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNombre.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombre, "Capture el nombre de la ruta")
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
        Medios_comunicacionDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = Medios_comunicacionDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            Medios_comunicacionDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione una ruta para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        If (txtDato.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDato.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmMedioComunicacion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (Medios_comunicacionBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        Medios_comunicacionDataGridView.ClearSelection()
    End Sub


    Private Sub frmMedioComunicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMedioDeComunicacion.medios_comunicacion' Puede moverla o quitarla según sea necesario.
        Me.Medios_comunicacionTableAdapter.FillBy(Me.DataSetMedioDeComunicacion.medios_comunicacion, persona_id)
        'TODO: esta línea de código carga datos en la tabla 'DataSetTipoMedioComunicacionCombo.tipos_medios_comunicacion' Puede moverla o quitarla según sea necesario.
        Me.Tipos_medios_comunicacionTableAdapter.Fill(Me.DataSetTipoMedioComunicacionCombo.tipos_medios_comunicacion)

        txtNombre.Text = nombre_completo

        Me.Top = 100
    End Sub


End Class