Public Class frmCompra

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProveedorCombo.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetProveedorCombo.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductoCombo.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductoCombo.productos)

    End Sub
End Class