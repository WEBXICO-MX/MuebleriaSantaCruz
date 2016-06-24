Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmBuscarNombreProducto
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader
    Dim EjecutarProcedimiento As Boolean

    Public Sub BuscarClaveProducto()
        Dim Consulta As String

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Crear una consulta       
        Consulta = "SELECT * " & _
                   "FROM productos " & _
                   "WHERE id = " & cmbProducto.SelectedValue

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
            Else

                'frmProducto.txtcantidad.Enabled = False
                frmProducto.btdeshacer.Enabled = True
                frmProducto.bteditar.Enabled = True

                frmProducto.ProductosDataGridView.Enabled = False

                For Fila = 0 To frmProducto.ProductosDataGridView.Rows.Count - 1
                    If (frmProducto.ProductosDataGridView.Item(0, Fila).Value = Lector("id")) Then
                        frmProducto.ProductosDataGridView.Item(0, Fila).Selected = True
                        frmProducto.PegarDatosTabla_CajasdeTexto(Fila)
                        Exit For
                    End If
                Next Fila

                frmProducto.ProductosDataGridView.Enabled = True


                frmProducto.EstadoBotones(True, False, True, True, True)


                'Llamar siempre a Close una vez finalizada la lectura
                CerrarConexion()
            End If
        Catch ex As SqlException
            MsgBox("Error: " + ex.Message)
            CerrarConexion()
        End Try
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.SelectedIndexChanged
        If (cmbProducto.Text <> "") Then
            BuscarClaveProducto()
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

    Private Sub LimpiarCajasdeTexto()
        cmbproducto.Text = ""
    End Sub

    Private Sub frmBuscarNombreProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)

        LimpiarCajasdeTexto()
    End Sub
End Class