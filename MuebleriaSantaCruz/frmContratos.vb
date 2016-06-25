Public Class frmContratos

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        lbtipoestado.Visible = True
        lbtipoestado.Text = "Nuevo"
        EstadoBotones(False, True, True, False, False)
        LimpiarCajasdeTexto(False)
        'EstadoCajasdeTexto(True)

        'DesactivarErroresCajasdeTexto()
        DetalleFactura.Enabled = True
        DetalleFactura.Rows.Clear()
        'Nuevo()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

    End Sub

    Private Sub btdeshacer_Click(sender As Object, e As EventArgs) Handles btdeshacer.Click

    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click

    End Sub

    Private Sub LimpiarCajasdeTexto(ByVal Estado As Boolean)
        If (Estado) Then
            cmbproducto.Text = ""
            txtcantidad.Text = ""
        Else
            txtID.Clear()
            txtFolio.Clear()
            cmbTipoPago.Text = ""
            cmbformapago.Text = ""
            cmbCliente.Text = ""
            txtDireccion.Text = ""
            txtRuta.Text = ""
            cmbVendedor.Text = ""
            cmbPromotor.Text = ""

            cmbproducto.Text = ""
            txtcantidad.Clear()
            txttotal.Clear()
            txtEnganche.Clear()
            txtPago.Clear()
            txtFechaPrimerPago.Text = ""
            txtTotal.Clear()
        End If
    End Sub

    Private Sub EstadoBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal deshacer As Boolean, ByVal editar As Boolean, ByVal buscar As Boolean)
        btnuevo.Enabled = nuevo
        btguardar.Enabled = guardar
        btdeshacer.Enabled = deshacer
        bteditar.Enabled = editar
    End Sub

    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)
        Me.EmpleadosTableAdapter.Fill(Me.DataSetEmpleadoCombo.empleados)
        Me.ClientesTableAdapter.Fill(Me.DataSetClienteCombo.clientes)
        Me.Conceptos_pagoTableAdapter.Fill(Me.DataSetConceptoPagoCombo.conceptos_pago)
    End Sub

    Private Sub frmContratos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LimpiarCajasdeTexto(False)
        EstadoBotones(True, False, False, False, False)
    End Sub
End Class