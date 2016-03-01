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

    Private Sub ConceptosDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosDePagoToolStripMenuItem.Click
        frmConceptoPago.Show()
    End Sub

    Private Sub GruposDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposDeSeguridadToolStripMenuItem.Click
        frmGrupoSeguridad.Show()
    End Sub

    Private Sub ModulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulosToolStripMenuItem.Click
        frmModulo.Show()
    End Sub

    Private Sub OcupacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcupacionesToolStripMenuItem.Click
        frmOcupacion.Show()

    End Sub

    Private Sub PuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestoToolStripMenuItem.Click
        frmPuesto.Show()
    End Sub

    Private Sub TiposDeMedioDeComunicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMedioDeComunicaciónToolStripMenuItem.Click
        frmTipoMedioComunicacion.Show()
    End Sub

    Private Sub SucursaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursaleToolStripMenuItem.Click
        frmSucursal.Show()
    End Sub
End Class