﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tipos_productosComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipos_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTipoProductoCombo = New MuebleriaCasaCruz.DataSetTipoProductoCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSetProducto = New MuebleriaCasaCruz.DataSetProducto()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New MuebleriaCasaCruz.DataSetProductoTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetProductoTableAdapters.TableAdapterManager()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tipos_productosTableAdapter = New MuebleriaCasaCruz.DataSetTipoProductoComboTableAdapters.tipos_productosTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetTipoProductoComboTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPagoSemanal = New System.Windows.Forms.TextBox()
        Me.txtEnganche = New System.Windows.Forms.TextBox()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.txtContado = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStockMaximo = New System.Windows.Forms.TextBox()
        Me.txtStockMinimo = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_contado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_enganche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_pago_semanal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_maximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tipos_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTipoProductoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(1114, 38)
        Me.BarraHerramientas.TabIndex = 34
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
        'btbuscar
        '
        Me.btbuscar.Enabled = False
        Me.btbuscar.Image = CType(resources.GetObject("btbuscar.Image"), System.Drawing.Image)
        Me.btbuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(46, 35)
        Me.btbuscar.Text = "&Buscar"
        Me.btbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btbuscar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tipos_productosComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 282)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Tipos_productosComboBox
        '
        Me.Tipos_productosComboBox.DataSource = Me.Tipos_productosBindingSource
        Me.Tipos_productosComboBox.DisplayMember = "nombre"
        Me.Tipos_productosComboBox.FormattingEnabled = True
        Me.Tipos_productosComboBox.Location = New System.Drawing.Point(103, 81)
        Me.Tipos_productosComboBox.Name = "Tipos_productosComboBox"
        Me.Tipos_productosComboBox.Size = New System.Drawing.Size(234, 21)
        Me.Tipos_productosComboBox.TabIndex = 2
        Me.Tipos_productosComboBox.ValueMember = "id"
        '
        'Tipos_productosBindingSource
        '
        Me.Tipos_productosBindingSource.DataMember = "tipos_productos"
        Me.Tipos_productosBindingSource.DataSource = Me.DataSetTipoProductoCombo
        '
        'DataSetTipoProductoCombo
        '
        Me.DataSetTipoProductoCombo.DataSetName = "DataSetTipoProductoCombo"
        Me.DataSetTipoProductoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo de producto:"
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(11, 259)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 5
        Me.cbxActivo.Text = "Activo"
        Me.cbxActivo.UseVisualStyleBackColor = True
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
        Me.txtID.Location = New System.Drawing.Point(78, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(103, 153)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(369, 90)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(103, 118)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(496, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Producto:"
        '
        'DataSetProducto
        '
        Me.DataSetProducto.DataSetName = "DataSetProducto"
        Me.DataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.DataSetProducto
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetProductoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.ProductosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.descripcion, Me.tipo_producto, Me.precio_costo, Me.precio_contado, Me.precio_credito, Me.precio_enganche, Me.precio_pago_semanal, Me.stock_minimo, Me.stock_maximo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(652, 57)
        Me.ProductosDataGridView.MultiSelect = False
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(450, 478)
        Me.ProductosDataGridView.TabIndex = 39
        '
        'Tipos_productosTableAdapter
        '
        Me.Tipos_productosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetTipoProductoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPagoSemanal)
        Me.GroupBox2.Controls.Add(Me.txtEnganche)
        Me.GroupBox2.Controls.Add(Me.txtCredito)
        Me.GroupBox2.Controls.Add(Me.txtContado)
        Me.GroupBox2.Controls.Add(Me.txtCosto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 86)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'txtPagoSemanal
        '
        Me.txtPagoSemanal.Location = New System.Drawing.Point(490, 48)
        Me.txtPagoSemanal.MaxLength = 10
        Me.txtPagoSemanal.Name = "txtPagoSemanal"
        Me.txtPagoSemanal.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoSemanal.TabIndex = 10
        '
        'txtEnganche
        '
        Me.txtEnganche.Location = New System.Drawing.Point(372, 48)
        Me.txtEnganche.MaxLength = 10
        Me.txtEnganche.Name = "txtEnganche"
        Me.txtEnganche.Size = New System.Drawing.Size(100, 20)
        Me.txtEnganche.TabIndex = 9
        '
        'txtCredito
        '
        Me.txtCredito.Location = New System.Drawing.Point(251, 48)
        Me.txtCredito.MaxLength = 10
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Size = New System.Drawing.Size(100, 20)
        Me.txtCredito.TabIndex = 8
        '
        'txtContado
        '
        Me.txtContado.Location = New System.Drawing.Point(135, 48)
        Me.txtContado.MaxLength = 10
        Me.txtContado.Name = "txtContado"
        Me.txtContado.Size = New System.Drawing.Size(100, 20)
        Me.txtContado.TabIndex = 7
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(26, 48)
        Me.txtCosto.MaxLength = 10
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(510, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Pago semanal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Enganche"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Crédito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Costo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtStockMaximo)
        Me.GroupBox3.Controls.Add(Me.txtStockMinimo)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 465)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 70)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de inventario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(315, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Stock máximo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(105, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Stock mínimo:"
        '
        'txtStockMaximo
        '
        Me.txtStockMaximo.Location = New System.Drawing.Point(397, 34)
        Me.txtStockMaximo.MaxLength = 5
        Me.txtStockMaximo.Name = "txtStockMaximo"
        Me.txtStockMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtStockMaximo.TabIndex = 12
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.Location = New System.Drawing.Point(186, 31)
        Me.txtStockMinimo.MaxLength = 5
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtStockMinimo.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 99
        '
        'tipo_producto
        '
        Me.tipo_producto.DataPropertyName = "tipo_producto"
        Me.tipo_producto.HeaderText = "Tipo producto"
        Me.tipo_producto.Name = "tipo_producto"
        Me.tipo_producto.ReadOnly = True
        Me.tipo_producto.Width = 102
        '
        'precio_costo
        '
        Me.precio_costo.DataPropertyName = "precio_costo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.precio_costo.DefaultCellStyle = DataGridViewCellStyle4
        Me.precio_costo.HeaderText = "Costo"
        Me.precio_costo.Name = "precio_costo"
        Me.precio_costo.ReadOnly = True
        Me.precio_costo.Width = 64
        '
        'precio_contado
        '
        Me.precio_contado.DataPropertyName = "precio_contado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.precio_contado.DefaultCellStyle = DataGridViewCellStyle5
        Me.precio_contado.HeaderText = "Contado"
        Me.precio_contado.Name = "precio_contado"
        Me.precio_contado.ReadOnly = True
        Me.precio_contado.Width = 79
        '
        'precio_credito
        '
        Me.precio_credito.DataPropertyName = "precio_credito"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        Me.precio_credito.DefaultCellStyle = DataGridViewCellStyle6
        Me.precio_credito.HeaderText = "Crédito"
        Me.precio_credito.Name = "precio_credito"
        Me.precio_credito.ReadOnly = True
        Me.precio_credito.Width = 72
        '
        'precio_enganche
        '
        Me.precio_enganche.DataPropertyName = "precio_enganche"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        Me.precio_enganche.DefaultCellStyle = DataGridViewCellStyle7
        Me.precio_enganche.HeaderText = "Enganche"
        Me.precio_enganche.Name = "precio_enganche"
        Me.precio_enganche.ReadOnly = True
        Me.precio_enganche.Width = 89
        '
        'precio_pago_semanal
        '
        Me.precio_pago_semanal.DataPropertyName = "precio_pago_semanal"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.precio_pago_semanal.DefaultCellStyle = DataGridViewCellStyle8
        Me.precio_pago_semanal.HeaderText = "Pago semanal"
        Me.precio_pago_semanal.Name = "precio_pago_semanal"
        Me.precio_pago_semanal.ReadOnly = True
        Me.precio_pago_semanal.Width = 102
        '
        'stock_minimo
        '
        Me.stock_minimo.DataPropertyName = "stock_minimo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.stock_minimo.DefaultCellStyle = DataGridViewCellStyle9
        Me.stock_minimo.HeaderText = "Stock mínimo"
        Me.stock_minimo.Name = "stock_minimo"
        Me.stock_minimo.ReadOnly = True
        '
        'stock_maximo
        '
        Me.stock_maximo.DataPropertyName = "stock_maximo"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.stock_maximo.DefaultCellStyle = DataGridViewCellStyle10
        Me.stock_maximo.HeaderText = "Stock máximo"
        Me.stock_maximo.Name = "stock_maximo"
        Me.stock_maximo.ReadOnly = True
        Me.stock_maximo.Width = 101
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipo_producto_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipo_producto_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 127
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 49
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 550)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tipos_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTipoProductoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents btnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btguardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btdeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents bteditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btbuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lbtipoestado As System.Windows.Forms.Label
    Friend WithEvents lbestado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSetProducto As MuebleriaCasaCruz.DataSetProducto
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As MuebleriaCasaCruz.DataSetProductoTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetProductoTableAdapters.TableAdapterManager
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetTipoProductoCombo As MuebleriaCasaCruz.DataSetTipoProductoCombo
    Friend WithEvents Tipos_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipos_productosTableAdapter As MuebleriaCasaCruz.DataSetTipoProductoComboTableAdapters.tipos_productosTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetTipoProductoComboTableAdapters.TableAdapterManager
    Friend WithEvents Tipos_productosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPagoSemanal As System.Windows.Forms.TextBox
    Friend WithEvents txtEnganche As System.Windows.Forms.TextBox
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtContado As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStockMaximo As System.Windows.Forms.TextBox
    Friend WithEvents txtStockMinimo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_contado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_credito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_enganche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_pago_semanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_minimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_maximo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
