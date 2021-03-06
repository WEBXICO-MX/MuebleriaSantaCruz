﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConsultaCompras
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader


    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If (cmbproveedor.FindStringExact(cmbproveedor.Text) < 0) Then
            ErrorProvider1.SetError(cmbproveedor, "Seleccione un proveedor")
            cmbproveedor.Focus()
            Exit Sub
        End If

        If (cmbFolioFactura.FindStringExact(cmbFolioFactura.Text) < 0) Then
            ErrorProvider1.SetError(cmbFolioFactura, "Seleccione factura")
            cmbFolioFactura.Focus()
            Exit Sub
        End If

        If (cmbformapago.FindStringExact(cmbformapago.Text) < 0) Then
            ErrorProvider1.SetError(cmbformapago, "Seleccione la forma de pago")
            cmbformapago.Focus()
            Exit Sub
        End If

        If (txttotalimporte.Text.Length = 0) Then
            ErrorProvider1.SetError(txttotalimporte, "Capture el importe de la factura")
            txttotalimporte.Focus()
            Exit Sub
        End If

        If (txtdescuento.Text.Length = 0) Then
            ErrorProvider1.SetError(txtdescuento, "Capture el descuento de la factura")
            txtdescuento.Focus()
            Exit Sub
        End If

        If (txtsubtotal.Text.Length = 0) Then
            ErrorProvider1.SetError(txtsubtotal, "Capture el subtotal de la factura")
            txtsubtotal.Focus()
            Exit Sub
        End If

        If (txtIVA.Text.Length = 0) Then
            ErrorProvider1.SetError(txtIVA, "Capture el IVA de la factura")
            txtIVA.Focus()
            Exit Sub
        End If

        If (txtTotal.Text.Length = 0) Then
            ErrorProvider1.SetError(txtTotal, "Capture el total de la factura")
            txtTotal.Focus()
            Exit Sub
        End If

        If (DetalleFactura.Rows.Count = 0) Then
            MsgBox("Falta cargar los productos")
            Exit Sub
        End If

        DesactivarErroresCajasdeTexto()
        EditarFactura()
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

    Private Sub btdeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdeshacer.Click
        lbtipoestado.Visible = False
        lbtipoestado.Text = ""

        LimpiarCajasdeTexto(False)
        EstadoCajasdeTexto(False)
        EstadoBotones(True, False, False, False, True)
        'proveedoresDataGridView.Enabled = True
        DesactivarErroresCajasdeTexto()
    End Sub

    Private Sub btproducto_Click(sender As Object, e As EventArgs) Handles btproducto.Click
        frmProducto.externa = True
        frmProducto.Show()
    End Sub

    Private Sub btproveedor_Click(sender As Object, e As EventArgs) Handles btproveedor.Click
        frmProveedor.externa = True
        frmProveedor.Show()
    End Sub

    Private Sub btfacturas_Click(sender As Object, e As EventArgs)
        frmfacturascompra.Show()
    End Sub

    Private Sub LimpiarCajasdeTexto(ByVal Estado As Boolean)
        If (Estado) Then
            cmbproducto.Text = ""
            txtprecio.Text = ""
            txtcantidad.Text = ""
            txtimporte.Text = ""
        Else
            txtID.Clear()
            txtfechacompra.Text = ""
            cmbproveedor.Text = ""
            cmbFolioFactura.Text = ""
            cmbformapago.Text = ""
            cbxPagado.Checked = False
            cmbproducto.Text = ""
            txtprecio.Clear()
            txtcantidad.Clear()
            txtimporte.Clear()
            txtobservacion.Clear()
            txttotalimporte.Clear()
            txtdescuento.Clear()
            txtsubtotal.Clear()
            txtIVA.Clear()
            txtTotal.Clear()
        End If
    End Sub

    Private Sub EstadoBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal deshacer As Boolean, ByVal editar As Boolean, ByVal buscar As Boolean)
        btnuevo.Enabled = nuevo
        btguardar.Enabled = guardar
        btdeshacer.Enabled = deshacer
        bteditar.Enabled = editar
    End Sub

    Private Sub EstadoCajasdeTexto(ByVal nombre_status As Boolean)
        txtfechacompra.Enabled = nombre_status
        cmbproveedor.Enabled = nombre_status
        cmbFolioFactura.Enabled = nombre_status
        cmbformapago.Enabled = nombre_status
        cbxPagado.Enabled = nombre_status
        cmbproducto.Enabled = nombre_status
        txtprecio.Enabled = nombre_status
        txtcantidad.Enabled = nombre_status
        txtimporte.Enabled = nombre_status
        txtobservacion.Enabled = nombre_status
        txttotalimporte.Enabled = nombre_status
        txtdescuento.Enabled = nombre_status
        txtsubtotal.Enabled = nombre_status
        txtIVA.Enabled = nombre_status
        txtTotal.Enabled = nombre_status
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(cmbproveedor, Nothing)
        ErrorProvider1.SetError(cmbFolioFactura, Nothing)
        ErrorProvider1.SetError(cmbformapago, Nothing)
        ErrorProvider1.SetError(cmbproducto, Nothing)
        ErrorProvider1.SetError(txttotalimporte, Nothing)
        ErrorProvider1.SetError(txtdescuento, Nothing)
        ErrorProvider1.SetError(txtsubtotal, Nothing)
        ErrorProvider1.SetError(txtIVA, Nothing)
        ErrorProvider1.SetError(txtTotal, Nothing)
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If (txtprecio.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtprecio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprecio.KeyUp
        If (txtprecio.Text <> "") Then
            If (txtprecio.Text < 1) Then
                txtprecio.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcantidad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyUp
        If (txtcantidad.Text <> "") Then
            If (txtcantidad.Text < 1) Then
                txtcantidad.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcantidad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.Enter
        Dim ObjTextBox As TextBox = CType(sender, TextBox)
        ObjTextBox.SelectAll()
    End Sub

    Private Sub txtimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimporte.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtimporte_TextChanged(sender As Object, e As EventArgs) Handles txtimporte.TextChanged
        If (txtprecio.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtimporte_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtimporte.KeyUp
        If (txtimporte.Text <> "") Then
            If (txtimporte.Text < 1) Then
                txtimporte.Text = ""
            End If
        End If
    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click
        Dim Agregado As Boolean
        Dim FRepetida As Integer, F As Integer

        If (txtcantidad.Text <> "") Then
            If (txtcantidad.Text < 1) Then
                txtcantidad.Text = ""
                Exit Sub
            End If
        End If

        If (cmbproducto.SelectedValue <> 0 And txtprecio.Text <> "" And txtcantidad.Text <> "" And txtimporte.Text <> "") Then
            For Fila = 0 To DetalleFactura.Rows.Count - 1
                If (DetalleFactura.Rows(Fila).Cells(0).Value = cmbproducto.SelectedValue) Then
                    FRepetida = Fila
                    Agregado = True
                    Exit For
                End If
            Next

            If (Not Agregado) Then
                F = DetalleFactura.Rows.Count
                DetalleFactura.Rows.Add()
                DetalleFactura.Rows(F).Cells(0).Value = cmbproducto.SelectedValue
                DetalleFactura.Rows(F).Cells(1).Value = cmbproducto.Text
                DetalleFactura.Rows(F).Cells(2).Value = FormatCurrency(txtprecio.Text, 2)
                DetalleFactura.Rows(F).Cells(3).Value = txtcantidad.Text
                DetalleFactura.Rows(F).Cells(4).Value = FormatCurrency(txtimporte.Text)
                txtcantidad.Focus()
            Else
                DetalleFactura.Rows(FRepetida).Cells(2).Value = FormatCurrency(txtprecio.Text, 2)
                DetalleFactura.Rows(FRepetida).Cells(3).Value = txtcantidad.Text
                DetalleFactura.Rows(FRepetida).Cells(4).Value = FormatCurrency(txtimporte.Text)
            End If

            Totales()
            LimpiarCajasdeTexto(True)
            cmbproducto.Focus()
        End If
    End Sub

    Private Sub txttotalimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotalimporte.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txttotalimporte_TextChanged(sender As Object, e As EventArgs) Handles txttotalimporte.TextChanged
        If (txttotalimporte.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txttotalimporte_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotalimporte.KeyUp
        If (txttotalimporte.Text <> "") Then
            If (txttotalimporte.Text < 1) Then
                txttotalimporte.Text = ""
            End If
        End If
    End Sub

    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescuento_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged
        Dim totalImporte As Double

        If (txttotalimporte.Text = "") Then
            totalImporte = 0
        Else
            totalImporte = CDbl(txttotalimporte.Text)
        End If

        If (txtdescuento.Text <> "") Then
            txtsubtotal.Text = FormatCurrency(totalImporte - CDbl(txtdescuento.Text), 2)
        Else
            txtdescuento.Text = 0
            txtsubtotal.Text = txttotalimporte.Text
        End If

        If (txtdescuento.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub Totales()
        Dim Subtotal As Double

        For Fila = 0 To DetalleFactura.Rows.Count - 1
            Subtotal = Subtotal + DetalleFactura.Rows(Fila).Cells(4).Value
        Next

        Subtotal = FormatCurrency(Subtotal, 2)
        txtsubtotal.Text = FormatCurrency(Subtotal, 2)
        'IVA = FormatCurrency(Subtotal * IVABD, 2)
        'txtIVA.Text = FormatCurrency(IVA, 2)
        txttotalimporte.Text = FormatCurrency(Subtotal, 2)

        If (txtdescuento.Text <> "") Then
            txtsubtotal.Text = FormatCurrency(Subtotal - CDbl(txtdescuento.Text), 2)
        End If
    End Sub




    Private Sub txtsubtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsubtotal.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged
        If (txtsubtotal.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtsubtotal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsubtotal.KeyUp
        If (txtsubtotal.Text <> "") Then
            If (txtsubtotal.Text < 1) Then
                txtsubtotal.Text = ""
            End If
        End If
    End Sub

    Private Sub txtIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIVA.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtIVA_TextChanged(sender As Object, e As EventArgs) Handles txtIVA.TextChanged
        If (txtIVA.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = " ") Then
            e.KeyChar = ""
        End If

        If (e.KeyChar = Convert.ToChar(8) Or e.KeyChar = " " Or e.KeyChar = "-") Then
            ' Se pulsó la tecla retroceso
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'Desechar los caracteres que no son dígitos
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If (txtTotal.Text.Length <> 0) Then
            DesactivarErroresCajasdeTexto()
        End If
    End Sub

    Private Sub txtTotal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyUp
        If (txtTotal.Text <> "") Then
            If (txtTotal.Text < 1) Then
                txtTotal.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbproveedor_TextChanged(sender As Object, e As EventArgs) Handles cmbproveedor.TextChanged
        If (cmbproveedor.FindStringExact(cmbproveedor.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(cmbproveedor, Nothing)
        End If
    End Sub

    Private Sub cmbFolioFactura_TextChanged(sender As Object, e As EventArgs) Handles cmbFolioFactura.TextChanged
        If (cmbFolioFactura.FindStringExact(cmbFolioFactura.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(cmbFolioFactura, Nothing)
        End If
    End Sub

    Private Sub cmbformapago_TextChanged(sender As Object, e As EventArgs) Handles cmbformapago.TextChanged
        If (cmbformapago.FindStringExact(cmbformapago.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(cmbformapago, Nothing)
        End If
    End Sub

    Private Sub DetalleFactura_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DetalleFactura.RowsRemoved
        If (DetalleFactura.Rows.Count = 0) Then

        End If
        Totales()
    End Sub

    Public Sub BuscarFactura(ByVal idFactura As Integer, ByVal idProveedor As Integer)
        Dim Consulta As String

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta       
        Consulta = "SELECT * " &
                   "FROM factura_compra fc " &
                   "INNER JOIN proveedores p on p.id=fc.id_proveedor " &
                   "WHERE fc.id=" & idFactura &
                   " AND p.id=" & idProveedor

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            If (Lector.HasRows = False) Then
                'Llamar siempre a Close una vez finalizada la lectura
                CerrarConexion()
                btguardar.Enabled = False
                MsgBox("No existe la Factura Número: " + cmbFolioFactura.Text + " con ese proveedor")
            Else
                txtID.Text = Lector("id")
                txtfechacompra.Text = Lector("fecha_compra")

                If (Lector("tipo_pago") = 1) Then
                    cmbformapago.Text = "Efectivo"
                ElseIf (Lector("tipo_pago") = 2) Then
                    cmbformapago.Text = "Crédito"
                End If

                If (Lector("pagado")) Then
                    cbxPagado.Checked = True
                Else
                    cbxPagado.Checked = False
                End If

                txtobservacion.Text = Lector("observacion")

                If (IsDBNull(Lector("importe"))) Then
                    txttotalimporte.Text = "0.0"
                Else
                    txttotalimporte.Text = FormatCurrency(Lector("importe"), 2)
                End If

                If (IsDBNull(Lector("descuento"))) Then
                    txtdescuento.Text = "0.0"
                Else
                    txtdescuento.Text = FormatCurrency(Lector("descuento"), 2)
                End If

                If (IsDBNull(Lector("subtotal"))) Then
                    txtsubtotal.Text = "0.0"
                Else
                    txtsubtotal.Text = FormatCurrency(Lector("subtotal"), 2)
                End If

                If (IsDBNull(Lector("IVA"))) Then
                    txtIVA.Text = "0.0"
                Else
                    txtIVA.Text = FormatCurrency(Lector("IVA"), 2)
                End If

                If (IsDBNull(Lector("total"))) Then
                    txtTotal.Text = "0.0"
                Else
                    txtTotal.Text = FormatCurrency(Lector("total"), 2)
                End If

                'Llamar siempre a Close una vez finalizada la lectura
                CerrarConexion()

                BuscarDetalleFactura()
                DetalleFactura.Enabled = True
                btguardar.Enabled = True
            End If
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)
            CerrarConexion()
        End Try
    End Sub

    Public Sub BuscarDetalleFactura()
        Dim Consulta As String
        Dim F As Integer

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta       
        Consulta = "SELECT p.id,p.nombre,dfc.consecutivo,dfc.cantidad,dfc.costo,dfc.total " &
                   "FROM detalle_factura_compra dfc " &
                   "inner join productos p on p.id=dfc.id_producto " &
                   "WHERE dfc.id=" & txtID.Text & " ORDER BY consecutivo"

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()

            F = 0

            While Lector.Read()
                DetalleFactura.Rows.Add()
                DetalleFactura.Rows(F).Cells(0).Value = Lector("id")
                DetalleFactura.Rows(F).Cells(1).Value = Lector("nombre")
                DetalleFactura.Rows(F).Cells(2).Value = FormatCurrency(Lector("costo"), 2)
                DetalleFactura.Rows(F).Cells(3).Value = Lector("cantidad")
                DetalleFactura.Rows(F).Cells(4).Value = FormatCurrency(Lector("total"), 2)
                F = F + 1
            End While

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)
            CerrarConexion()
        End Try
    End Sub

    Public Sub EditarFactura()
        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Dim Consulta As String = "UPDATE factura_compra " &
                                 "SET id_proveedor = " & cmbproveedor.SelectedValue &
                                 ", tipo_pago= " & cmbformapago.SelectedIndex + 1 &
                                 ", pagado = " & If(cbxPagado.Checked, 1, 0) &
                                 ", importe = " & CDbl(txttotalimporte.Text) &
                                 ", descuento = " & CDbl(txtdescuento.Text) &
                                 ", subtotal = " & CDbl(txtsubtotal.Text) &
                                 ", IVA = " & CDbl(txtIVA.Text) &
                                 ", total = " & CDbl(txtTotal.Text) &
                                 ", observacion = '" & txtobservacion.Text & "'" &
                                 " WHERE id_proveedor=" & cmbproveedor.SelectedValue &
                                 " AND id=" & txtID.Text

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()
            EliminarDetalleFactura()
            MsgBox("Datos actualizados")
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)

            CerrarConexion()
        End Try
    End Sub

    Public Sub EliminarDetalleFactura()
        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Dim Consulta As String = "DELETE detalle_factura_compra " &
                                 "WHERE id=" & txtID.Text

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()

            For Fila = 0 To DetalleFactura.Rows.Count - 1
                InsertarDetalleFactura(DetalleFactura.Item(0, Fila).Value, Fila + 1, DetalleFactura.Item(3, Fila).Value, DetalleFactura.Item(2, Fila).Value, DetalleFactura.Item(4, Fila).Value)
            Next Fila
        Catch ex As SqlException
            If (ex.Number = 2601) Then
                ' MessageBox.Show("El producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (ex.Number = 2627) Then
                'MessageBox.Show("La clave ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Error: " + ex.Message)
            End If

            CerrarConexion()
        End Try
    End Sub

    Public Sub InsertarDetalleFactura(ByVal cveProducto As String, ByVal consecutivo As Integer, ByVal cantidad As Integer, ByVal costo As Double, ByVal total As Double)
        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Dim Consulta As String = "INSERT INTO detalle_factura_compra (id, id_producto, consecutivo, cantidad, costo, total) VALUES (" & txtID.Text & _
                                 "," & cveProducto & "," & consecutivo & "," & cantidad & "," & costo & "," & total & ")"

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()
            Lector.Read()

            'Llamar siempre a Close una vez finalizada la lectura
            CerrarConexion()
            
        Catch ex As SqlException
            If (ex.Number = 2627) Then
                MessageBox.Show("La factura No." + cmbFolioFactura.Text & " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Error: " + ex.Message)
            End If

            CerrarConexion()
        End Try
    End Sub

    Private Sub cmbproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproveedor.SelectedIndexChanged
        Me.Factura_compraTableAdapter.FillByIdProveedor(Me.DataSetFacturaCompra.factura_compra, cmbproveedor.SelectedValue)
        cmbFolioFactura.Text = ""
    End Sub

    Private Sub cmbFolioFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFolioFactura.SelectedIndexChanged
        If (cmbFolioFactura.FindStringExact(cmbFolioFactura.Text) < 0) Then
            ErrorProvider1.SetError(cmbFolioFactura, "Seleccione un factura")
            cmbFolioFactura.Focus()
            Exit Sub
        Else
            Dim nombreProveedor = cmbproveedor.Text
            Dim numfactura = cmbFolioFactura.Text

            LimpiarCajasdeTexto(False)
            cmbproveedor.Text = nombreProveedor
            cmbFolioFactura.Text = numfactura
            DetalleFactura.Rows.Clear()
            BuscarFactura(cmbFolioFactura.SelectedValue, cmbproveedor.SelectedValue)
        End If
    End Sub

    Private Sub frmConsultaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fuente As Font = New Font("Microsoft Sans Serif", 8.25)

        Me.Top = 100

        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)

        DetalleFactura.DefaultCellStyle.ForeColor = Color.Black
        DetalleFactura.DefaultCellStyle.Font = fuente
    End Sub

    Private Sub frmConsultaCompras_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Desactivar para no se active el foco de la tabla de sectores
        LimpiarCajasdeTexto(False)
        EstadoBotones(True, False, False, False, False)
        EstadoCajasdeTexto(True)
        cmbproveedor.Focus()
    End Sub
End Class