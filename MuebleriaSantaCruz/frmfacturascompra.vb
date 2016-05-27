Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmfacturascompra
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Dim EjecutarProcedimiento As Boolean
    Public cve_proveedor As Integer

    Private Sub BuscarPedidos()
        Dim Consulta As String
        Dim F As Integer
        Dim Filtro As String

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Consulta = "SELECT c.folio_factura, pro.nombre_comercial, p.nombre as proveedor, c.cantidad, c.costo, c.total, c.tipo_pago, c.pagado, c.descuento " &
                   "FROM compras c " &
                   "INNER JOIN productos p on p.id=c.id_producto " &
                   "INNER JOIN proveedores pro on pro.id=c.id_proveedor " &
                   "WHERE c.id_proveedor=" & cmbProveedor.SelectedValue &
                   " AND c.folio_factura='" & txtNumFactura.Text & "'"

        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()

            F = 0

            While Lector.Read()
                DetalleFacturas.Rows.Add()
                DetalleFacturas.Rows(F).Cells(0).Value = Lector("folio_factura")
                DetalleFacturas.Rows(F).Cells(1).Value = Lector("nombre_comercial")
                DetalleFacturas.Rows(F).Cells(2).Value = Lector("proveedor")
                DetalleFacturas.Rows(F).Cells(3).Value = Lector("cantidad")
                DetalleFacturas.Rows(F).Cells(4).Value = Lector("costo")
                DetalleFacturas.Rows(F).Cells(5).Value = Lector("total")

                If (Lector("tipo_pago") = 1) Then
                    DetalleFacturas.Rows(F).Cells(6).Value = "Efectivo"
                Else
                    DetalleFacturas.Rows(F).Cells(6).Value = "Crédito"
                End If

                If (Lector("pagado")) Then
                    DetalleFacturas.Rows(F).Cells(7).Value = "Sí"
                Else
                    DetalleFacturas.Rows(F).Cells(7).Value = "No"
                End If

                DetalleFacturas.Rows(F).Cells(8).Value = Lector("tipo_pago")
                DetalleFacturas.Rows(F).Cells(9).Value = Lector("descuento")

                F = F + 1
            End While

            Totales()
            MsgBox("Búsqueda Completada")
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

    Private Sub Totales()
        Dim efectivo As Double, credito As Double, descuento As Double, total As Double

        For Fila = 0 To DetalleFacturas.Rows.Count - 1
            If (DetalleFacturas.Rows(Fila).Cells(8).Value = 1) Then
                efectivo = efectivo + DetalleFacturas.Rows(Fila).Cells(5).Value
            Else
                credito = credito + DetalleFacturas.Rows(Fila).Cells(5).Value
            End If

            If (DetalleFacturas.Rows(Fila).Cells(9).Value <> 0) Then
                descuento = descuento + DetalleFacturas.Rows(Fila).Cells(9).Value
            End If
        Next

        total = (efectivo / 1.16) + (credito / 1.16)

        If (efectivo <> 0 And descuento <> 0) Then
            txtefectivo.Text = FormatCurrency((efectivo / 1.16) - descuento, 2)
        Else
            txtefectivo.Text = FormatCurrency(efectivo, 2)
        End If

        If (credito <> 0 And descuento <> 0) Then
            txtcredito.Text = FormatCurrency((credito / 1.16) - descuento, 2)
        Else
            txtcredito.Text = FormatCurrency(credito, 2)
        End If


        txtDescuento.Text = FormatCurrency(descuento, 2)
        txttotal.Text = FormatCurrency((total - descuento) * 1.16, 2)
    End Sub

    Private Sub LimpiarCajasdeTexto()
        cmbproveedor.Text = ""
    End Sub

    Private Sub btbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbuscar.Click
        If (cmbproveedor.Text = "") Then
            MsgBox("Seleccione un cliente")
            cmbproveedor.Focus()
            Exit Sub
        End If

        DetalleFacturas.Rows.Clear()
        BuscarPedidos()
    End Sub

    Private Sub frmfacturascompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fuente As Font = New Font("Microsoft Sans Serif", 8.25)
        Me.Top = 100

        'TODO: esta línea de código carga datos en la tabla 'DataSetProveedorCombo.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)

        DetalleFacturas.DefaultCellStyle.ForeColor = Color.Black
        DetalleFacturas.DefaultCellStyle.Font = fuente
    End Sub

    Private Sub frmfacturascompra_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LimpiarCajasdeTexto()
    End Sub
End Class