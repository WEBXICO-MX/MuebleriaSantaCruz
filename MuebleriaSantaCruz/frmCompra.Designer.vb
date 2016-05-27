<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btproducto = New System.Windows.Forms.ToolStripButton()
        Me.btproveedor = New System.Windows.Forms.ToolStripButton()
        Me.btfacturas = New System.Windows.Forms.ToolStripButton()
        Me.txtfechacompra = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbformapago = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProveedorCombo = New MuebleriaCasaCruz.DataSetProveedorCombo()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProductoCombo = New MuebleriaCasaCruz.DataSetProductoCombo()
        Me.cbxPagado = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New MuebleriaCasaCruz.DataSetProductoComboTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetProductoComboTableAdapters.TableAdapterManager()
        Me.ProveedoresTableAdapter = New MuebleriaCasaCruz.DataSetProveedorComboTableAdapters.proveedoresTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetProveedorComboTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProveedorCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btproducto, Me.btproveedor, Me.btfacturas})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(427, 38)
        Me.BarraHerramientas.TabIndex = 33
        Me.BarraHerramientas.Text = "ToolStrip1"
        '
        'btnuevo
        '
        Me.btnuevo.Enabled = False
        Me.btnuevo.Image = CType(resources.GetObject("btnuevo.Image"), System.Drawing.Image)
        Me.btnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(46, 35)
        Me.btnuevo.Text = "&Nuevo"
        Me.btnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btguardar
        '
        Me.btguardar.Enabled = False
        Me.btguardar.Image = CType(resources.GetObject("btguardar.Image"), System.Drawing.Image)
        Me.btguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(53, 35)
        Me.btguardar.Text = "&Guardar"
        Me.btguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btdeshacer
        '
        Me.btdeshacer.Enabled = False
        Me.btdeshacer.Image = CType(resources.GetObject("btdeshacer.Image"), System.Drawing.Image)
        Me.btdeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdeshacer.Name = "btdeshacer"
        Me.btdeshacer.Size = New System.Drawing.Size(59, 35)
        Me.btdeshacer.Text = "&Deshacer"
        Me.btdeshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bteditar
        '
        Me.bteditar.Enabled = False
        Me.bteditar.Image = CType(resources.GetObject("bteditar.Image"), System.Drawing.Image)
        Me.bteditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(41, 35)
        Me.bteditar.Text = "&Editar"
        Me.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btproducto
        '
        Me.btproducto.Image = CType(resources.GetObject("btproducto.Image"), System.Drawing.Image)
        Me.btproducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btproducto.Name = "btproducto"
        Me.btproducto.Size = New System.Drawing.Size(60, 35)
        Me.btproducto.Text = "&Producto"
        Me.btproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btproveedor
        '
        Me.btproveedor.Image = CType(resources.GetObject("btproveedor.Image"), System.Drawing.Image)
        Me.btproveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btproveedor.Name = "btproveedor"
        Me.btproveedor.Size = New System.Drawing.Size(65, 35)
        Me.btproveedor.Text = "Proveedor"
        Me.btproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btfacturas
        '
        Me.btfacturas.Image = CType(resources.GetObject("btfacturas.Image"), System.Drawing.Image)
        Me.btfacturas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btfacturas.Name = "btfacturas"
        Me.btfacturas.Size = New System.Drawing.Size(55, 35)
        Me.btfacturas.Text = "Facturas"
        Me.btfacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtfechacompra
        '
        Me.txtfechacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechacompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechacompra.Location = New System.Drawing.Point(102, 73)
        Me.txtfechacompra.Name = "txtfechacompra"
        Me.txtfechacompra.Size = New System.Drawing.Size(107, 20)
        Me.txtfechacompra.TabIndex = 116
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbproducto)
        Me.GroupBox1.Controls.Add(Me.cmbproveedor)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbformapago)
        Me.GroupBox1.Controls.Add(Me.cbxPagado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtcosto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfechacompra)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtNumFactura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 381)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(102, 248)
        Me.txtDescuento.MaxLength = 100
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(132, 20)
        Me.txtDescuento.TabIndex = 5
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Descuento:"
        '
        'cmbformapago
        '
        Me.cmbformapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbformapago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbformapago.Enabled = False
        Me.cmbformapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbformapago.FormattingEnabled = True
        Me.cmbformapago.Items.AddRange(New Object() {"Efectivo", "Crédito"})
        Me.cmbformapago.Location = New System.Drawing.Point(102, 303)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Size = New System.Drawing.Size(161, 21)
        Me.cmbformapago.TabIndex = 7
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSetProveedorCombo
        '
        'DataSetProveedorCombo
        '
        Me.DataSetProveedorCombo.DataSetName = "DataSetProveedorCombo"
        Me.DataSetProveedorCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.DataSetProductoCombo
        '
        'DataSetProductoCombo
        '
        Me.DataSetProductoCombo.DataSetName = "DataSetProductoCombo"
        Me.DataSetProductoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxPagado
        '
        Me.cbxPagado.AutoSize = True
        Me.cbxPagado.Enabled = False
        Me.cbxPagado.Location = New System.Drawing.Point(102, 340)
        Me.cbxPagado.Name = "cbxPagado"
        Me.cbxPagado.Size = New System.Drawing.Size(15, 14)
        Me.cbxPagado.TabIndex = 8
        Me.cbxPagado.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Pagado:"
        '
        'txtcosto
        '
        Me.txtcosto.BackColor = System.Drawing.Color.White
        Me.txtcosto.Enabled = False
        Me.txtcosto.Location = New System.Drawing.Point(102, 223)
        Me.txtcosto.MaxLength = 100
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(132, 20)
        Me.txtcosto.TabIndex = 4
        Me.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Costo:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(102, 195)
        Me.txtCantidad.MaxLength = 100
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 20)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Cantidad:"
        '
        'lbtipoestado
        '
        Me.lbtipoestado.AutoSize = True
        Me.lbtipoestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtipoestado.ForeColor = System.Drawing.Color.Blue
        Me.lbtipoestado.Location = New System.Drawing.Point(235, 24)
        Me.lbtipoestado.Name = "lbtipoestado"
        Me.lbtipoestado.Size = New System.Drawing.Size(0, 13)
        Me.lbtipoestado.TabIndex = 2
        Me.lbtipoestado.Visible = False
        '
        'lbestado
        '
        Me.lbestado.AutoSize = True
        Me.lbestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbestado.ForeColor = System.Drawing.Color.Black
        Me.lbestado.Location = New System.Drawing.Point(184, 24)
        Me.lbestado.Name = "lbestado"
        Me.lbestado.Size = New System.Drawing.Size(50, 13)
        Me.lbestado.TabIndex = 3
        Me.lbestado.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(102, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(102, 276)
        Me.txtTotal.MaxLength = 100
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 20)
        Me.txtTotal.TabIndex = 6
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumFactura
        '
        Me.txtNumFactura.BackColor = System.Drawing.Color.White
        Me.txtNumFactura.Enabled = False
        Me.txtNumFactura.Location = New System.Drawing.Point(102, 107)
        Me.txtNumFactura.MaxLength = 100
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(107, 20)
        Me.txtNumFactura.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Forma de pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No. de Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de compra:"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetProductoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetProveedorComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbproveedor
        '
        Me.cmbproveedor.DataSource = Me.ProveedoresBindingSource
        Me.cmbproveedor.DisplayMember = "nombre_comercial"
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(102, 133)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(284, 21)
        Me.cmbproveedor.TabIndex = 1
        Me.cmbproveedor.ValueMember = "id"
        '
        'cmbproducto
        '
        Me.cmbproducto.DataSource = Me.ProductosBindingSource
        Me.cmbproducto.DisplayMember = "nombre"
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(102, 162)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(284, 21)
        Me.cmbproducto.TabIndex = 2
        Me.cmbproducto.ValueMember = "id"
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProveedorCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProductoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents btnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btguardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btdeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents bteditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btproducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtfechacompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbtipoestado As System.Windows.Forms.Label
    Friend WithEvents lbestado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxPagado As System.Windows.Forms.CheckBox
    Friend WithEvents DataSetProductoCombo As MuebleriaCasaCruz.DataSetProductoCombo
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As MuebleriaCasaCruz.DataSetProductoComboTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetProductoComboTableAdapters.TableAdapterManager
    Friend WithEvents DataSetProveedorCombo As MuebleriaCasaCruz.DataSetProveedorCombo
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As MuebleriaCasaCruz.DataSetProveedorComboTableAdapters.proveedoresTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetProveedorComboTableAdapters.TableAdapterManager
    Friend WithEvents cmbformapago As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btproveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btfacturas As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
End Class
