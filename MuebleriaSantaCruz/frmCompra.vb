Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class frmCompra
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader


    Public Sub Nuevo()
        Dim Consulta As String

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Consulta = "SELECT id FROM compras ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                txtfechacompra.Focus()
            Else
                txtID.Text = Lector("id") + 1
                txtfechacompra.Focus()
            End If

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)
            CerrarConexion()
        End Try
    End Sub

    Public Sub InsertaNuevo()
        Dim Consulta As String

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        'Dim Consulta As String = "INSERT INTO proveedores (id, nombre_comercial,razon_social,activo) VALUES (" & txtID.Text & ",'" & txtNombreComercial.Text & "','" & (txtRazonSocial.Text) & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        'Dim Consulta As String = "INSERT INTO compras (id, id_proveedor,id_producto,fecha_compra,folio_factura,cantidad,costo,total,tipo_pago,pagado) VALUES (@id,@id_proveedor,@id_producto,@fecha_compra,@folio_factura,@cantidad,@costo,total,@tipo_pago,@pagado)"

        'Orden = New SqlCommand(Consulta, objcon.con)
        'Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        'Orden.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = cmbProveedor.SelectedValue
        'Orden.Parameters.Add("@id_producto", SqlDbType.Int).Value = cmbProducto.SelectedValue
        'Orden.Parameters.Add("@fecha_compra", SqlDbType.DateTime).Value = txtfechacompra.Value
        'Orden.Parameters.Add("@folio_factura", SqlDbType.VarChar).Value = txtNumFactura.Text
        'Orden.Parameters.Add("@cantidad", SqlDbType.Int).Value = txtCantidad.Text
        'Orden.Parameters.Add("@costo", SqlDbType.Float).Value = txtcosto.Text
        'Orden.Parameters.Add("@total", SqlDbType.Float).Value = txtTotal.Text
        'Orden.Parameters.Add("@tipo_pago", SqlDbType.Int).Value = cmbformapago.Text
        'Orden.Parameters.Add("@pagado", SqlDbType.Bit).Value = If(cbxPagado.Checked, 1, 0)

        Consulta = "INSERT INTO compras (id, id_proveedor,id_producto,fecha_compra,folio_factura,cantidad,costo,descuento,total,tipo_pago,pagado) VALUES (" & txtID.Text & _
                     "," & cmbProveedor.SelectedValue & "," & cmbProducto.SelectedValue & ",'" & txtfechacompra.Text & "','" & txtNumFactura.Text & "'," & txtCantidad.Text & _
                     "," & CDbl(txtcosto.Text) & "," & If(txtDescuento.Text = "", 0, CDbl(txtDescuento.Text)) & "," & CDbl(txtTotal.Text) & "," & cmbformapago.SelectedIndex + 1 & "," & If(cbxPagado.Checked, 1, 0) & ")"


        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            'Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedor.proveedores)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'For Fila = 0 To proveedoresDataGridView.Rows.Count - 1
            'If (proveedoresDataGridView.Item(1, Fila).Value = txtNombreComercial.Text) Then
            'proveedoresDataGridView.Item(0, Fila).Selected = True
            'Exit For
            'End If
            'Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("La factura '" & txtNumFactura.Text & "' ha sido guardada", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto2()
            Nuevo()
            lbtipoestado.Visible = False
            'proveedoresDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("La factura ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (ex.Number = 2627) Then
                MessageBox.Show("El ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Error: " + ex.Message)
            End If

            CerrarConexion()
        End Try
    End Sub

    Public Sub Editar()
        ''Crear la conexión con la base de datos
        'If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        ''Crear una consulta
        ''Dim Consulta As String = "UPDATE proveedores SET nombre_comercial = '" & txtNombreComercial.Text & "', razon_social = '" & (txtRazonSocial.Text) & "', activo = " & (If(cbxActivo.Checked, 1, 0)) & " WHERE id = " & txtID.Text
        'Dim Consulta As String = "UPDATE proveedores SET nombre_comercial = @nombre_comercial , razon_social = @razon_social, nombre_contacto = @nombre_contacto, direccion = @direccion, telefonos = @telefonos, email = @email, fecha_modificacion = GETDATE(), activo = @activo  WHERE id = @id "
        'Orden = New SqlCommand(Consulta, objcon.con)
        'Orden.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = txtNombreComercial.Text
        'Orden.Parameters.Add("@razon_social", SqlDbType.VarChar).Value = txtRazonSocial.Text
        'Orden.Parameters.Add("@nombre_contacto", SqlDbType.VarChar).Value = txtNombreContacto.Text
        'Orden.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text
        'Orden.Parameters.Add("@telefonos", SqlDbType.VarChar).Value = txtTelefonos.Text
        'Orden.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
        'Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        'Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text

        'Try
        '    'ExecuteReader hace la consulta y devuelve un SqlDataReader
        '    Orden.ExecuteNonQuery()

        '    Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedor.proveedores)

        '    EstadoBotones(True, False, False, False, True)
        '    EstadoCajasdeTexto(False)

        '    'Llamar siempre a Close una vez finalizada la lectura
        '    CerrarConexion()

        '    MessageBox.Show("El proveedor '" & txtNombreComercial.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

        '    LimpiarCajasdeTexto()
        '    lbtipoestado.Visible = False
        '    proveedoresDataGridView.Enabled = True
        'Catch ex As SqlException
        '    If (ex.Number = 2601) Then
        '        MessageBox.Show("El proveedor ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf (ex.Number = 2627) Then
        '        MessageBox.Show("El ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        MsgBox("Error: " + ex.Message)
        '    End If

        '    CerrarConexion()
        'End Try
    End Sub

    Private Sub LimpiarCajasdeTexto()
        txtID.Clear()
        cmbProveedor.Text = ""
        cmbProducto.Text = ""
        txtfechacompra.Text = ""
        txtNumFactura.Clear()
        txtCantidad.Clear()
        txtcosto.Clear()
        txtTotal.Clear()
        cmbformapago.Text = ""
        cbxPagado.Checked = False
    End Sub

    Private Sub LimpiarCajasdeTexto2()
        cmbProducto.Text = ""
        txtCantidad.Clear()
        txtcosto.Clear()
        txtTotal.Clear()
        cmbformapago.Text = ""
        cbxPagado.Checked = False
    End Sub

    Private Sub EstadoBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal deshacer As Boolean, ByVal editar As Boolean, ByVal buscar As Boolean)
        btnuevo.Enabled = nuevo
        btguardar.Enabled = guardar
        btdeshacer.Enabled = deshacer
        bteditar.Enabled = editar
        'btproducto.Enabled = buscar
    End Sub

    Private Sub EstadoCajasdeTexto(ByVal nombre_status As Boolean)
        cmbProveedor.Enabled = nombre_status
        cmbProducto.Enabled = nombre_status
        txtfechacompra.Enabled = nombre_status
        txtNumFactura.Enabled = nombre_status
        txtCantidad.Enabled = nombre_status
        txtcosto.Enabled = nombre_status
        txtDescuento.Enabled = nombre_status
        txtTotal.Enabled = nombre_status
        cmbformapago.Enabled = nombre_status
        cbxPagado.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        'txtID.Text = proveedoresDataGridView.Rows(F).Cells(0).Value
        'txtNombreComercial.Text = ProveedoresDataGridView.Rows(F).Cells(1).Value
        'txtRazonSocial.Text = ProveedoresDataGridView.Rows(F).Cells(2).Value
        'txtNombreContacto.Text = ProveedoresDataGridView.Rows(F).Cells(3).Value
        'txtDireccion.Text = ProveedoresDataGridView.Rows(F).Cells(4).Value
        'txtTelefonos.Text = ProveedoresDataGridView.Rows(F).Cells(5).Value
        'txtEmail.Text = ProveedoresDataGridView.Rows(F).Cells(6).Value
        'cbxActivo.Checked = ProveedoresDataGridView.Rows(F).Cells(9).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(cmbProveedor, Nothing)
        ErrorProvider1.SetError(cmbProducto, Nothing)
        ErrorProvider1.SetError(txtNumFactura, Nothing)
        ErrorProvider1.SetError(txtCantidad, Nothing)
        ErrorProvider1.SetError(txtcosto, Nothing)
        ErrorProvider1.SetError(txtTotal, Nothing)
        ErrorProvider1.SetError(cmbformapago, Nothing)
    End Sub

    'Private Sub proveedoresDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellClick
    '    If (proveedoresDataGridView.Enabled = True) Then
    '        If (e.RowIndex >= 0) Then
    '            PegarDatosTabla_CajasdeTexto(e.RowIndex)
    '            EstadoBotones(True, False, True, True, True)
    '        End If
    '    End If
    'End Sub

    'Private Sub proveedoresDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.RowEnter
    '    If (proveedoresDataGridView.Enabled = True) Then
    '        If (e.RowIndex >= 0) Then
    '            PegarDatosTabla_CajasdeTexto(e.RowIndex)
    '            EstadoBotones(True, False, True, True, True)
    '        End If
    '    End If
    'End Sub

    Private Sub btnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        lbtipoestado.Visible = True
        lbtipoestado.Text = "Nuevo"
        EstadoBotones(False, True, True, False, False)
        LimpiarCajasdeTexto()
        EstadoCajasdeTexto(True)
        'proveedoresDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click

        If (txtNumFactura.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNumFactura, "Capture el folio de la factura")
            txtNumFactura.Focus()
            Exit Sub
        End If

        If (txtCantidad.Text.Length = 0) Then
            ErrorProvider1.SetError(txtCantidad, "Capture la cantidad del producto")
            txtCantidad.Focus()
            Exit Sub
        End If

        If (txtcosto.Text.Length = 0) Then
            ErrorProvider1.SetError(txtcosto, "Capture el costo del producto")
            txtcosto.Focus()
            Exit Sub
        End If

        If (txtTotal.Text.Length = 0) Then
            ErrorProvider1.SetError(txtTotal, "Capture el total del producto")
            txtTotal.Focus()
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
        'proveedoresDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            'Dim F As Integer = proveedoresDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            'PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNumFactura.Focus()
            EstadoBotones(False, True, True, False, False)
            'proveedoresDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione una compra para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btproducto_Click(sender As Object, e As EventArgs) Handles btproducto.Click
        frmProducto.externa = True
        frmProducto.Show()
    End Sub

    Private Sub btproveedor_Click(sender As Object, e As EventArgs) Handles btproveedor.Click
        frmProveedor.externa = True
        frmProveedor.Show()
    End Sub

    Private Sub btfacturas_Click(sender As Object, e As EventArgs) Handles btfacturas.Click
        frmfacturascompra.Show()
    End Sub
    Private Sub txtNumFactura_TextChanged(sender As Object, e As EventArgs) Handles txtNumFactura.TextChanged
        If (txtNumFactura.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtNumFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumFactura.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub CerrarConexion()
        ' Cerrar la conexión cuando ya no sea necesaria
        If (Not Lector Is Nothing) Then
            Lector.Close()
        End If
        If (Not ConexionConBD Is Nothing) Then
            ConexionConBD.Close()
        End If
    End Sub

    Private Sub frmCompra_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto()

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        'If (ProveedoresBindingSource.Count = 0) Then
        EstadoBotones(True, False, False, False, False)
        'Else
        '    EstadoBotones(True, False, False, False, True)
        'End If

        'proveedoresDataGridView.ClearSelection()
    End Sub

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProveedorCombo.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductoCombo.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)
        Me.Top = 100
    End Sub
End Class