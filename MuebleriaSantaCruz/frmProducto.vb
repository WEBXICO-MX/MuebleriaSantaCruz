Imports System.Data.SqlClient
Public Class frmProducto
    Private objcon As New Conexion
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Public externa As Boolean = False

    Public Sub Nuevo()
        If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()

        'Crear una consulta
        Dim Consulta As String = "SELECT id FROM productos ORDER BY id DESC"
        Orden = New SqlCommand(Consulta, objcon.con)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                txtID.Text = "1"
                Tipos_productosComboBox.Focus()
            Else
                txtID.Text = Lector("id") + 1
                Tipos_productosComboBox.Focus()
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
        'Dim Consulta As String = "INSERT INTO productos (id, tipo_producto_id, nombre,fecha_registro,fecha_modificacion,activo) VALUES (" & txtID.Text & "," & (Tipos_productosComboBox.SelectedValue) & ",'" & txtNombre.Text & "'," & (If(cbxActivo.Checked, 1, 0)) & ")"
        Dim Consulta As String = "INSERT INTO productos (id, tipo_producto_id, nombre,descripcion, precio_costo, precio_contado, precio_credito, precio_enganche, precio_pago_semanal, stock_minimo, stock_maximo,fecha_registro,fecha_modificacion,activo) VALUES (@id,@tipo_producto_id,@nombre,@descripcion, @precio_costo, @precio_contado, @precio_credito, @precio_enganche, @precio_pago_semanal, @stock_minimo, @stock_maximo,GETDATE(),NULL,@activo)"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text
        Orden.Parameters.Add("@tipo_producto_id", SqlDbType.Int).Value = Tipos_productosComboBox.SelectedValue
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
        Orden.Parameters.Add("@precio_costo", SqlDbType.Decimal).Value = txtCosto.Text
        Orden.Parameters.Add("@precio_contado", SqlDbType.Decimal).Value = txtContado.Text
        Orden.Parameters.Add("@precio_credito", SqlDbType.Decimal).Value = txtCredito.Text
        Orden.Parameters.Add("@precio_enganche", SqlDbType.Decimal).Value = txtEnganche.Text
        Orden.Parameters.Add("@precio_pago_semanal", SqlDbType.Decimal).Value = txtPagoSemanal.Text
        Orden.Parameters.Add("@stock_minimo", SqlDbType.Int).Value = txtStockMinimo.Text
        Orden.Parameters.Add("@stock_maximo", SqlDbType.Int).Value = txtStockMaximo.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (externa) Then
                frmCompras.ProductosTableAdapter.Fill(frmCompras.DataSetProductoCombo.productos)
            End If

            Me.ProductosTableAdapter.Fill(Me.DataSetProducto.productos)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            For Fila = 0 To productosDataGridView.Rows.Count - 1
                If (ProductosDataGridView.Item(1, Fila).Value = txtNombre.Text) Then
                    ProductosDataGridView.Item(0, Fila).Selected = True
                    Exit For
                End If
            Next Fila

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El producto '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            productosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'Dim Consulta As String = "UPDATE productos SET tipo_producto_id = " & (Tipos_productosComboBox.SelectedValue) & ", nombre = '" & txtNombre.Text & "', activo = " & (If(cbxActivo.Checked, 1, 0)) & " WHERE id = " & txtID.Text
        Dim Consulta As String = "UPDATE productos SET tipo_producto_id = @tipo_producto_id, nombre = @nombre, descripcion = @descripcion, precio_costo = @precio_costo, precio_contado = @precio_contado, precio_credito = @precio_credito, precio_enganche = @precio_enganche, precio_pago_semanal = @precio_pago_semanal, stock_minimo = @stock_minimo, stock_maximo = @stock_maximo,fecha_modificacion = GETDATE(), activo = @activo WHERE id = @id"
        Orden = New SqlCommand(Consulta, objcon.con)
        Orden.Parameters.Add("@tipo_producto_id", SqlDbType.Int).Value = Tipos_productosComboBox.SelectedValue
        Orden.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        Orden.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
        Orden.Parameters.Add("@precio_costo", SqlDbType.Decimal).Value = txtCosto.Text
        Orden.Parameters.Add("@precio_contado", SqlDbType.Decimal).Value = txtContado.Text
        Orden.Parameters.Add("@precio_credito", SqlDbType.Decimal).Value = txtCredito.Text
        Orden.Parameters.Add("@precio_enganche", SqlDbType.Decimal).Value = txtEnganche.Text
        Orden.Parameters.Add("@precio_pago_semanal", SqlDbType.Decimal).Value = txtPagoSemanal.Text
        Orden.Parameters.Add("@stock_minimo", SqlDbType.Int).Value = txtStockMinimo.Text
        Orden.Parameters.Add("@stock_maximo", SqlDbType.Int).Value = txtStockMaximo.Text
        Orden.Parameters.Add("@activo", SqlDbType.Bit).Value = If(cbxActivo.Checked, 1, 0)
        Orden.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text


        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            Me.ProductosTableAdapter.Fill(Me.DataSetProducto.productos)

            EstadoBotones(True, False, False, False, True)
            EstadoCajasdeTexto(False)

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            MessageBox.Show("El producto '" & txtNombre.Text & "' ha sido guardado", "Guardar", MessageBoxButtons.OK)

            LimpiarCajasdeTexto()
            lbtipoestado.Visible = False
            productosDataGridView.Enabled = True
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                MessageBox.Show("El producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub LimpiarCajasdeTexto(Optional ByVal limpiar As Boolean = False)
        If (limpiar) Then
            Tipos_productosComboBox.Text = ""
        End If

        txtID.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtCosto.Clear()
        txtContado.Clear()
        txtCredito.Clear()
        txtEnganche.Clear()
        txtPagoSemanal.Clear()
        txtStockMinimo.Clear()
        txtStockMaximo.Clear()
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
        Tipos_productosComboBox.Enabled = nombre_status
        txtNombre.Enabled = nombre_status
        txtDescripcion.Enabled = nombre_status
        txtCosto.Enabled = nombre_status
        txtContado.Enabled = nombre_status
        txtCredito.Enabled = nombre_status
        txtEnganche.Enabled = nombre_status
        txtPagoSemanal.Enabled = nombre_status
        txtStockMinimo.Enabled = nombre_status
        txtStockMaximo.Enabled = nombre_status
        cbxActivo.Enabled = nombre_status
    End Sub

    Private Sub PegarDatosTabla_CajasdeTexto(ByVal F As Integer)
        txtID.Text = productosDataGridView.Rows(F).Cells(0).Value
        Tipos_productosComboBox.Text = ProductosDataGridView.Rows(F).Cells(3).Value
        txtNombre.Text = ProductosDataGridView.Rows(F).Cells(1).Value
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(2).Value)) Then
            txtDescripcion.Text = ""
        Else
            txtDescripcion.Text = ProductosDataGridView.Rows(F).Cells(2).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(4).Value)) Then
            txtCosto.Text = ""
        Else
            txtCosto.Text = ProductosDataGridView.Rows(F).Cells(4).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(5).Value)) Then
            txtContado.Text = ""
        Else
            txtContado.Text = ProductosDataGridView.Rows(F).Cells(5).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(6).Value)) Then
            txtCredito.Text = ""
        Else
            txtCredito.Text = ProductosDataGridView.Rows(F).Cells(6).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(7).Value)) Then
            txtEnganche.Text = ""
        Else
            txtEnganche.Text = ProductosDataGridView.Rows(F).Cells(7).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(8).Value)) Then
            txtPagoSemanal.Text = ""
        Else
            txtPagoSemanal.Text = ProductosDataGridView.Rows(F).Cells(8).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(9).Value)) Then
            txtStockMinimo.Text = ""
        Else
            txtStockMinimo.Text = ProductosDataGridView.Rows(F).Cells(9).Value
        End If
        If (IsDBNull(ProductosDataGridView.Rows(F).Cells(10).Value)) Then
            txtStockMaximo.Text = ""
        Else
            txtStockMaximo.Text = ProductosDataGridView.Rows(F).Cells(10).Value
        End If
        cbxActivo.Checked = ProductosDataGridView.Rows(F).Cells(12).Value
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNombre, Nothing)
        ErrorProvider1.SetError(txtDescripcion, Nothing)
        ErrorProvider1.SetError(txtCosto, Nothing)
        ErrorProvider1.SetError(txtContado, Nothing)
        ErrorProvider1.SetError(txtCredito, Nothing)
        ErrorProvider1.SetError(txtEnganche, Nothing)
        ErrorProvider1.SetError(txtPagoSemanal, Nothing)
        ErrorProvider1.SetError(txtStockMinimo, Nothing)
        ErrorProvider1.SetError(txtStockMaximo, Nothing)
    End Sub

    Private Sub productosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        If (productosDataGridView.Enabled = True) Then
            If (e.RowIndex >= 0) Then
                PegarDatosTabla_CajasdeTexto(e.RowIndex)
                EstadoBotones(True, False, True, True, True)
            End If
        End If
    End Sub

    Private Sub productosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.RowEnter
        If (productosDataGridView.Enabled = True) Then
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
        LimpiarCajasdeTexto(True)
        EstadoCajasdeTexto(True)
        productosDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub btguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btguardar.Click
        If (Tipos_productosComboBox.FindStringExact(Tipos_productosComboBox.Text) < 0) Then
            Tipos_productosComboBox.Text = ""
            ErrorProvider1.SetError(Tipos_productosComboBox, "Seleccione el tipo de producto")
            Exit Sub
        End If

        If (txtNombre.Text.Length = 0) Then
            ErrorProvider1.SetError(txtNombre, "Capture el nombre del producto")
            txtNombre.Focus()
            Exit Sub
        End If

        If (txtDescripcion.Text.Length = 0) Then
            ErrorProvider1.SetError(txtDescripcion, "Capture la descripcion del producto")
            txtDescripcion.Focus()
            Exit Sub
        End If

        If (txtCosto.Text.Length = 0) Then
            ErrorProvider1.SetError(txtCosto, "Capture el precio de costo del producto")
            txtCosto.Focus()
            Exit Sub
        End If

        If (txtContado.Text.Length = 0) Then
            ErrorProvider1.SetError(txtContado, "Capture el precio de contado del producto")
            txtContado.Focus()
            Exit Sub
        End If

        If (txtCredito.Text.Length = 0) Then
            ErrorProvider1.SetError(txtCredito, "Capture el precio de crédito del producto")
            txtCredito.Focus()
            Exit Sub
        End If

        If (txtEnganche.Text.Length = 0) Then
            ErrorProvider1.SetError(txtEnganche, "Capture el precio de enganche del producto")
            txtEnganche.Focus()
            Exit Sub
        End If

        If (txtPagoSemanal.Text.Length = 0) Then
            ErrorProvider1.SetError(txtPagoSemanal, "Capture el precio del pago semanal del producto")
            txtPagoSemanal.Focus()
            Exit Sub
        End If

        If (txtStockMinimo.Text.Length = 0) Then
            ErrorProvider1.SetError(txtStockMinimo, "Capture el stock mínimo del producto")
            txtStockMinimo.Focus()
            Exit Sub
        End If

        If (txtStockMaximo.Text.Length = 0) Then
            ErrorProvider1.SetError(txtStockMaximo, "Capture el stock máximo del producto")
            txtStockMaximo.Focus()
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

        LimpiarCajasdeTexto(True)
        EstadoCajasdeTexto(False)
        EstadoBotones(True, False, False, False, True)
        productosDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub bteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteditar.Click
        If (txtID.Text <> "") Then
            Dim F As Integer = productosDataGridView.CurrentCellAddress.Y

            lbtipoestado.Visible = True
            lbtipoestado.Text = "Editar"

            PegarDatosTabla_CajasdeTexto(F)
            EstadoCajasdeTexto(True)
            txtNombre.Focus()
            EstadoBotones(False, True, True, False, False)
            productosDataGridView.Enabled = False
        Else
            MessageBox.Show("Seleccione una producto para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtDescripcion.TextChanged
        If (txtNombre.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtDescripcion.KeyPress
        If (e.KeyChar = "'") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtCosto_TextChanged(sender As Object, e As EventArgs) Handles txtCosto.TextChanged
        If (txtCosto.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContado.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtContado_TextChanged(sender As Object, e As EventArgs) Handles txtContado.TextChanged
        If (txtContado.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredito.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtCredito_TextChanged(sender As Object, e As EventArgs) Handles txtCredito.TextChanged
        If (txtCredito.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtEnganche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnganche.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtEnganche_TextChanged(sender As Object, e As EventArgs) Handles txtEnganche.TextChanged
        If (txtEnganche.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtPagoSemanal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagoSemanal.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtPagoSemanal_TextChanged(sender As Object, e As EventArgs) Handles txtPagoSemanal.TextChanged
        If (txtPagoSemanal.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtStockMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockMinimo.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtStockMinimo_TextChanged(sender As Object, e As EventArgs) Handles txtStockMinimo.TextChanged
        If (txtStockMinimo.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtStockMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockMaximo.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtStockMaximo_TextChanged(sender As Object, e As EventArgs) Handles txtStockMaximo.TextChanged
        If (txtStockMaximo.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub
    Private Sub Tipos_productosComboBox_TextChanged(sender As Object, e As EventArgs) Handles Tipos_productosComboBox.TextChanged
        ' If (EjecutarProcedimiento = True) Then
        If (Tipos_productosComboBox.FindStringExact(Tipos_productosComboBox.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(Tipos_productosComboBox, Nothing)
        End If
        'End If
    End Sub

    Private Sub frmProducto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto(True)

        'Si la tabla sectores esta vacia, deshabilitar el boton de buscar
        If (productosBindingSource.Count = 0) Then
            EstadoBotones(True, False, False, False, False)
        Else
            EstadoBotones(True, False, False, False, True)
        End If

        productosDataGridView.ClearSelection()
    End Sub
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetTipoProductoCombo.productos' Puede moverla o quitarla según sea necesario.
        Me.Tipos_productosTableAdapter.Fill(Me.DataSetTipoProductoCombo.tipos_productos)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProducto.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProducto.productos)
        Me.Top = 100
    End Sub
End Class