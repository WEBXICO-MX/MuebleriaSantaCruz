Public Class frmMenuPrincipal

    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click

    End Sub

    Private Sub LineasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineasDeProductosToolStripMenuItem.Click
        frmLineaProducto.Show()
    End Sub

    Private Sub ClasificacionesDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificacionesDeClientesToolStripMenuItem.Click
        frmClasificacionCliente.Show()
    End Sub

    Private Sub ClasificacionesDeContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificacionesDeContratoToolStripMenuItem.Click
        frmClasificacionesContrato.Show()
    End Sub
End Class