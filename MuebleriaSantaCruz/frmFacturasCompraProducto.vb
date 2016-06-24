Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmFacturasCompraProducto
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Dim EjecutarProcedimiento As Boolean
    Public cve_proveedor As Integer

    Private Sub BuscarFacturas()
        Dim Consulta As String
        Dim F As Integer
        Dim Filtro1 As String
        Dim Filtro2 As String

        If (cmbProducto.FindStringExact(cmbProducto.Text) >= 0) Then
            Filtro1 = " AND dfc.id_producto=" & cmbProducto.SelectedValue
        End If

        If (chkperiodo.Checked) Then
            Filtro2 = " AND fecha_compra between '" & txtfechainicio.Text & "' AND '" & txtfechafinal.Text & "'"
        End If

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta
        Consulta = "SELECT fc.fecha_compra, fc.folio_factura, pro.nombre_comercial, tipo_pago, pagado," &
                   "dfc.cantidad, p.nombre, dfc.costo, dfc.total, dfc.id_producto " &
                   "FROM factura_compra fc " &
                   "INNER JOIN detalle_factura_compra dfc on dfc.id=fc.id " &
                   "INNER JOIN productos p on p.id=dfc.id_producto " &
                   "INNER JOIN proveedores pro on pro.id=fc.id_proveedor " &
                   "WHERE fc.id_proveedor=" & cmbproveedor.SelectedValue & Filtro1 & Filtro2 &
                   "ORDER BY fc.fecha_compra DESC"


        Orden = New SqlCommand(Consulta, ConexionConBD)

        'Abrir la base de datos
        ConexionConBD.Open()

        Try
            'ExecuteReader hace la consulta y devuelve un SqlDataReader
            Lector = Orden.ExecuteReader()

            F = 0

            While Lector.Read()
                DetalleFacturas.Rows.Add()
                DetalleFacturas.Rows(F).Cells(0).Value = F + 1

                DetalleFacturas.Rows(F).Cells(1).Value = Lector("fecha_compra")
                DetalleFacturas.Rows(F).Cells(2).Value = Lector("folio_factura")
                DetalleFacturas.Rows(F).Cells(3).Value = Lector("nombre_comercial")

                If (Lector("tipo_pago") = 1) Then
                    DetalleFacturas.Rows(F).Cells(4).Value = "Efectivo"
                Else
                    DetalleFacturas.Rows(F).Cells(4).Value = "Crédito"
                End If

                If (Lector("pagado")) Then
                    DetalleFacturas.Rows(F).Cells(5).Value = "Sí"
                Else
                    DetalleFacturas.Rows(F).Cells(5).Value = "No"
                End If

                DetalleFacturas.Rows(F).Cells(6).Value = Lector("nombre")
                DetalleFacturas.Rows(F).Cells(7).Value = Lector("cantidad")
                DetalleFacturas.Rows(F).Cells(8).Value = Lector("costo")
                DetalleFacturas.Rows(F).Cells(9).Value = Lector("total")

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
        Dim total As Integer

        For Fila = 0 To DetalleFacturas.Rows.Count - 1
            total = total + DetalleFacturas.Rows(Fila).Cells(7).Value
        Next

        txttotal.Text = total
    End Sub

    Private Sub LimpiarCajasdeTexto()
        cmbproveedor.Text = ""
        cmbProducto.Text = ""
    End Sub

    Private Sub cmbproveedor_TextChanged(sender As Object, e As EventArgs) Handles cmbproveedor.TextChanged
        If (cmbproveedor.FindStringExact(cmbproveedor.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(cmbproveedor, Nothing)
        End If
    End Sub

    Private Sub cmbProducto_TextChanged(sender As Object, e As EventArgs) Handles cmbProducto.TextChanged
        If (cmbProducto.FindStringExact(cmbProducto.Text) >= 0) Then
            'Desactivar el icono de error
            ErrorProvider1.SetError(cmbProducto, Nothing)
        End If
    End Sub

    Private Sub btbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbuscar.Click
        If (cmbproveedor.FindStringExact(cmbproveedor.Text) < 0) Then
            ErrorProvider1.SetError(cmbproveedor, "Seleccione un proveedor")
            cmbproveedor.Focus()
            Exit Sub
        End If

        DetalleFacturas.Rows.Clear()
        BuscarFacturas()
    End Sub

    Private Sub frmFacturasCompraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fuente As Font = New Font("Microsoft Sans Serif", 8.25)
        Me.Top = 100

        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)
        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)

        DetalleFacturas.DefaultCellStyle.ForeColor = Color.Black
        DetalleFacturas.DefaultCellStyle.Font = fuente
    End Sub

    Private Sub frmFacturasCompraProducto_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LimpiarCajasdeTexto()
    End Sub
End Class