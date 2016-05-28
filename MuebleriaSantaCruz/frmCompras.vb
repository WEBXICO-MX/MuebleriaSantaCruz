Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCompras
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
        Consulta = "SELECT id FROM factura_compra ORDER BY id DESC"
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

    Public Sub CerrarConexion()
        ' Cerrar la conexión cuando ya no sea necesaria
        If (Not Lector Is Nothing) Then
            Lector.Close()
        End If
        If (Not ConexionConBD Is Nothing) Then
            ConexionConBD.Close()
        End If
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        lbtipoestado.Visible = True
        lbtipoestado.Text = "Nuevo"
        EstadoBotones(False, True, True, False, False)
        LimpiarCajasdeTexto()
        EstadoCajasdeTexto(True)
        'proveedoresDataGridView.Enabled = False
        DesactivarErroresCajasdeTexto()
        Nuevo()
    End Sub

    Private Sub LimpiarCajasdeTexto()
        txtID.Clear()
        cmbProveedor.Text = ""
        cmbProducto.Text = ""
        txtfechacompra.Text = ""
        txtNumFactura.Clear()
        txtCantidad.Clear()
        'txtcosto.Clear()
        txtTotal.Clear()
        cmbformapago.Text = ""
        cbxPagado.Checked = False
    End Sub

    Private Sub EstadoBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal deshacer As Boolean, ByVal editar As Boolean, ByVal buscar As Boolean)
        btnuevo.Enabled = nuevo
        btguardar.Enabled = guardar
        btdeshacer.Enabled = deshacer
        bteditar.Enabled = editar
    End Sub

    Private Sub EstadoCajasdeTexto(ByVal nombre_status As Boolean)
        txtfechacompra.Enabled = nombre_status
        txtNumFactura.Enabled = nombre_status
        cmbproveedor.Enabled = nombre_status
        cmbformapago.Enabled = nombre_status
        cbxPagado.Enabled = nombre_status
        cmbproducto.Enabled = nombre_status
        txtcosto.Enabled = nombre_status
        txtcantidad.Enabled = nombre_status
        txtobservacion.Enabled = nombre_status
        txtimporte.Enabled = nombre_status
        txtdescuento.Enabled = nombre_status
        txtsubtotal.Enabled = nombre_status
        txtIVA.Enabled = nombre_status
        txtTotal.Enabled = nombre_status
    End Sub

    Private Sub DesactivarErroresCajasdeTexto()
        ErrorProvider1.SetError(txtNumFactura, Nothing)
        ErrorProvider1.SetError(cmbproveedor, Nothing)
        ErrorProvider1.SetError(cmbformapago, Nothing)
        ErrorProvider1.SetError(cmbproducto, Nothing)
        ErrorProvider1.SetError(txtimporte, Nothing)
        ErrorProvider1.SetError(txtdescuento, Nothing)
        ErrorProvider1.SetError(txtsubtotal, Nothing)
        ErrorProvider1.SetError(txtIVA, Nothing)
        ErrorProvider1.SetError(txtTotal, Nothing)
    End Sub

    Private Sub frmCompras_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fuente As Font = New Font("Microsoft Sans Serif", 8.25)

        Me.Top = 100

        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)


        DetalleFactura.DefaultCellStyle.ForeColor = Color.Black
        DetalleFactura.DefaultCellStyle.Font = fuente
    End Sub
End Class