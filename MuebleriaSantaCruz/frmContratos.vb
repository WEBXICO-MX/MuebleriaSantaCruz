Public Class frmContratos

   
    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetEmpleadoCombo.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetEmpleadoCombo.empleados)
        'TODO: esta línea de código carga datos en la tabla 'DataSetClienteCombo.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSetClienteCombo.clientes)
        'TODO: esta línea de código carga datos en la tabla 'DataSetConceptoPagoCombo.conceptos_pago' Puede moverla o quitarla según sea necesario.
        Me.Conceptos_pagoTableAdapter.Fill(Me.DataSetConceptoPagoCombo.conceptos_pago)

    End Sub
End Class