Imports System.Data.SqlClient
Public Class frmProveedor
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Public externa As Boolean = False

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM proveedores ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                txtNombreComercial.Focus()
            Else
                txtID.Text = Lector("id") + 1
                txtNombreComercial.Focus()
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
        'Dim Consulta As String = "INSERT INTO proveedores (id, nombre_comercial,razon_social,activo) VALUES (" & txtID.Text & ",'" & txtNombreComercial.Text & "','" & (txtRazonSocial.Text) & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO proveedores (id, nombre_comercial,razon_social,nombre_contacto,direccion,telefonos,email,fecha_registro,fecha_modificacion,activo) VALUES (@id,@nombre_comercial,@razon_social,@nombre_contacto,@direccion,@telefonos,@email,GETDATE(),NULL,@activo)"

        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = txtNombreComercial.Text
        Orden.Parameters.Add("@razon_social", SqlDbType.VarChar).Value = txtRazonSocial.Text
        Orden.Parameters.Add("@nombre_contacto", SqlDbType.VarChar).Value = txtNombreContacto.Text
        Orden.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text
        Orden.Parameters.Add("@telefonos", SqlDbType.VarChar).Value = txtTelefonos.Text
        Orden.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            If (externa) Then
                frmCompras.ProveedoresTableAdapter.Fill(frmCompras.DataSetProveedorCombo.proveedores)
            End If


            Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedor.proveedores)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To proveedoresDataGridView.Rows.Count - 1
                If (proveedoresDataGridView.Item(1, Fila).Value = txtNombreComercial.Text) Then
                    proveedoresDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El proveedor '" & txtNombreComercial.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            proveedoresDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El proveedor ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'Dim Consulta As String = "UPDATE proveedores SET nombre_comercial = '" & txtNombreComercial.Text & "', razon_social = '" & (txtRazonSocial.Text) & "', activo = " & (If(cbxActivo.Checked, 1, 0)) & " WHERE id = " & txtID.Text
        Dim Consulta As String = "UPDATE proveedores SET nombre_comercial = @nombre_comercial , razon_social = @razon_social, nombre_contacto = @nombre_contacto, direccion = @direccion, telefonos = @telefonos, email = @email, fecha_modificacion = GETDATE(), activo = @activo  WHERE id = @id "
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = txtNombreComercial.Text
        Orden.Parameters.Add("@razon_social", SqlDbType.VarChar).Value = txtRazonSocial.Text
        Orden.Parameters.Add("@nombre_contacto", SqlDbType.VarChar).Value = txtNombreContacto.Text
        Orden.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text
        Orden.Parameters.Add("@telefonos", SqlDbType.VarChar).Value = txtTelefonos.Text
        Orden.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Orden.ExecuteNonQuery()

            Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedor.proveedores)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El proveedor '" & txtNombreComercial.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            proveedoresDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El proveedor ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtNombreComercial.Clear()
        txtRazonSocial.Clear()
        txtNombreContacto.Clear()
        txtDireccion.Clear()
        txtTelefonos.Clear()
        txtEmail.Clear()
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
        txtNombreComercial.Enabled = nombre_status
        txtRazonSocial.Enabled = nombre_status
        txtNombreContacto.Enabled = nombre_status
        txtDireccion.Enabled = nombre_status
        txtTelefonos.Enabled = nombre_status
        txtEmail.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = proveedoresDataGridView.Rows(F).Cells(0).Value
        txtNombreComercial.Text = ProveedoresDataGridView.Rows(F).Cells(1).Value
        txtRazonSocial.Text = ProveedoresDataGridView.Rows(F).Cells(2).Value
        txtNombreContacto.Text = ProveedoresDataGridView.Rows(F).Cells(3).Value
        txtDireccion.Text = ProveedoresDataGridView.Rows(F).Cells(4).Value
        txtTelefonos.Text = ProveedoresDataGridView.Rows(F).Cells(5).Value
        txtEmail.Text = ProveedoresDataGridView.Rows(F).Cells(6).Value
        cbxActivo.Checked = ProveedoresDataGridView.Rows(F).Cells(9).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombreComercial, Nothing)
    End Sub

    Private Sub proveedoresDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellClick
        If (proveedoresDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub proveedoresDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.RowEnter
        If (proveedoresDataGridView.Enabled = True) Then
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
        proveedoresDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNombreComercial.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombreComercial, "Capture el nombre del tipo de identificación")
            txtNombreComercial.Focus()
            Exit Sub
        End If

        If (txtRazonSocial.Text.Length = 0) Then
            ErrorProvider1.SetError(txtRazonSocial, "Capture el nombre de la razón social")
            txtRazonSocial.Focus()
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
        proveedoresDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = proveedoresDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombreComercial.Focus()
            EstadoBotones(False, True, True, False, False)
            proveedoresDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione un proveedor para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNombreComercial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreComercial.TextChanged
        If (txtNombreComercial.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtNombreComercial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreComercial.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtRazonSocial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.TextChanged, txtTelefonos.TextChanged, txtNombreContacto.TextChanged, txtEmail.TextChanged, txtDireccion.TextChanged
        If (txtRazonSocial.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazonSocial.KeyPress, txtTelefonos.KeyPress, txtNombreContacto.KeyPress, txtEmail.KeyPress, txtDireccion.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmProveedor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (proveedoresBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        proveedoresDataGridView.ClearSelection()
    End Sub
    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProveedor.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedor.proveedores)
        Me.Top = 100
    End Sub
End Class