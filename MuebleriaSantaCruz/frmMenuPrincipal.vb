Public Class frmMenuPrincipal

    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub LineasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLineaProducto.Show()
    End Sub

    Private Sub ClasificacionesDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmClasificacionCliente.Show()
    End Sub

    Private Sub ClasificacionesDeContratoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmClasificacionesContrato.Show()
    End Sub

    Private Sub ConceptosDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmConceptoPago.Show()
    End Sub

    Private Sub GruposDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmGrupoSeguridad.Show()
    End Sub

    Private Sub OcupacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmOcupacion.Show()

    End Sub

    Private Sub PuestoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmPuesto.Show()
    End Sub

    Private Sub TiposDeMedioDeComunicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmTipoMedioComunicacion.Show()
    End Sub

    Private Sub SucursaleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSucursal.Show()
    End Sub

    Private Sub LineasDeProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LineasDeProductosToolStripMenuItem.Click
        frmLineaProducto.Show()
    End Sub

    Private Sub TiposDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeProductosToolStripMenuItem.Click
        frmTipoProducto.Show()
    End Sub

    Private Sub GruposDeSeguridadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GruposDeSeguridadToolStripMenuItem.Click
        frmGrupoSeguridad.Show()
    End Sub

    Private Sub ModulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulosToolStripMenuItem.Click
        frmModulo.Show()
    End Sub

    Private Sub ClasificacionesDeClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClasificacionesDeClientesToolStripMenuItem.Click
        frmClasificacionCliente.Show()
    End Sub

    Private Sub OcupacionesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OcupacionesToolStripMenuItem.Click
        frmOcupacion.Show()
    End Sub

    Private Sub PuestoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PuestoToolStripMenuItem.Click
        frmPuesto.Show()
    End Sub

    Private Sub TiposDeMedioDeComunicaciónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TiposDeMedioDeComunicaciónToolStripMenuItem.Click
        frmTipoMedioComunicacion.Show()
    End Sub

    Private Sub ClasificacionesDeContratoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClasificacionesDeContratoToolStripMenuItem.Click
        frmClasificacionesContrato.Show()
    End Sub

    Private Sub ConceptosDePagoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConceptosDePagoToolStripMenuItem.Click
        frmConceptoPago.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        frmSucursal.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem2.Click
        frmUsuario.Show()
    End Sub

    Private Sub ProductosMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductosMenuItem2.Click
        frmProducto.Show()
    End Sub

    Private Sub ClientesMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesMenuItem2.Click
        frmCliente.Show()
    End Sub

    Private Sub PersonalMenuItem2_Click(sender As Object, e As EventArgs) Handles PersonalMenuItem2.Click
        frmEmpleado.Show()
    End Sub

    Private Sub TiposDeIdentificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeIdentificaciónToolStripMenuItem.Click
        frmTipoIdentificacion.Show()
    End Sub

    Private Sub RutasMenuItem_Click(sender As Object, e As EventArgs) Handles RutasMenuItem.Click
        frmRuta.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedor.Show()
    End Sub

    Private Sub ComrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComrasToolStripMenuItem.Click
        frmCompras.Show()
    End Sub

    Private Sub AsentamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsentamientosToolStripMenuItem.Click
        frmAsentamiento.Show()
    End Sub

    Private Sub FacturasDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasDeComprasToolStripMenuItem.Click
        frmConsultaCompras.Show()
    End Sub

    Private Sub HistorialDeComprasAProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeComprasAProveedoresToolStripMenuItem.Click
        frmfacturascompra.Show()
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim posicionX As Integer = (Me.Width - logo.Width) \ 2
        Dim posicionY As Integer = (Me.Height - logo.Height) \ 2

        logo.Location = New Point(posicionX, posicionY)
    End Sub
End Class