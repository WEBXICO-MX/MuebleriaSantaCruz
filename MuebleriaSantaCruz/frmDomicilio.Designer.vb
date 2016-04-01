<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDomicilio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDomicilio))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tipos_viviendasComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipos_viviendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTipoViviendaCombo = New MuebleriaCasaCruz.DataSetTipoViviendaCombo()
        Me.AsentamientosComboBox = New System.Windows.Forms.ComboBox()
        Me.AsentamientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAsentamientoCombo = New MuebleriaCasaCruz.DataSetAsentamientoCombo()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombreAsentamiento = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.txtNumInt = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AsentamientosTableAdapter = New MuebleriaCasaCruz.DataSetAsentamientoComboTableAdapters.asentamientosTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetAsentamientoComboTableAdapters.TableAdapterManager()
        Me.Tipos_viviendasTableAdapter = New MuebleriaCasaCruz.DataSetTipoViviendaComboTableAdapters.tipos_viviendasTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetTipoViviendaComboTableAdapters.TableAdapterManager()
        Me.DataSetDomicilio = New MuebleriaCasaCruz.DataSetDomicilio()
        Me.DomiciliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DomiciliosTableAdapter = New MuebleriaCasaCruz.DataSetDomicilioTableAdapters.domiciliosTableAdapter()
        Me.TableAdapterManager2 = New MuebleriaCasaCruz.DataSetDomicilioTableAdapters.TableAdapterManager()
        Me.DomiciliosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoviviendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsentamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumerointeriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroexteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrecompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsentamientoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoviviendaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecharegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechamodificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tipos_viviendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTipoViviendaCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsentamientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAsentamientoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomiciliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomiciliosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(840, 38)
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
        Me.GroupBox1.Controls.Add(Me.Tipos_viviendasComboBox)
        Me.GroupBox1.Controls.Add(Me.AsentamientosComboBox)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNombreAsentamiento)
        Me.GroupBox1.Controls.Add(Me.txtCP)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Controls.Add(Me.txtNumExt)
        Me.GroupBox1.Controls.Add(Me.txtNumInt)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 495)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Tipos_viviendasComboBox
        '
        Me.Tipos_viviendasComboBox.DataSource = Me.Tipos_viviendasBindingSource
        Me.Tipos_viviendasComboBox.DisplayMember = "nombre"
        Me.Tipos_viviendasComboBox.FormattingEnabled = True
        Me.Tipos_viviendasComboBox.Location = New System.Drawing.Point(105, 245)
        Me.Tipos_viviendasComboBox.Name = "Tipos_viviendasComboBox"
        Me.Tipos_viviendasComboBox.Size = New System.Drawing.Size(300, 21)
        Me.Tipos_viviendasComboBox.TabIndex = 6
        Me.Tipos_viviendasComboBox.ValueMember = "id"
        '
        'Tipos_viviendasBindingSource
        '
        Me.Tipos_viviendasBindingSource.DataMember = "tipos_viviendas"
        Me.Tipos_viviendasBindingSource.DataSource = Me.DataSetTipoViviendaCombo
        '
        'DataSetTipoViviendaCombo
        '
        Me.DataSetTipoViviendaCombo.DataSetName = "DataSetTipoViviendaCombo"
        Me.DataSetTipoViviendaCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsentamientosComboBox
        '
        Me.AsentamientosComboBox.DataSource = Me.AsentamientosBindingSource
        Me.AsentamientosComboBox.DisplayMember = "nombre"
        Me.AsentamientosComboBox.Enabled = False
        Me.AsentamientosComboBox.FormattingEnabled = True
        Me.AsentamientosComboBox.Location = New System.Drawing.Point(105, 211)
        Me.AsentamientosComboBox.Name = "AsentamientosComboBox"
        Me.AsentamientosComboBox.Size = New System.Drawing.Size(300, 21)
        Me.AsentamientosComboBox.TabIndex = 5
        Me.AsentamientosComboBox.ValueMember = "id"
        '
        'AsentamientosBindingSource
        '
        Me.AsentamientosBindingSource.DataMember = "asentamientos"
        Me.AsentamientosBindingSource.DataSource = Me.DataSetAsentamientoCombo
        '
        'DataSetAsentamientoCombo
        '
        Me.DataSetAsentamientoCombo.DataSetName = "DataSetAsentamientoCombo"
        Me.DataSetAsentamientoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(9, 465)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 11
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
        'txtNombreAsentamiento
        '
        Me.txtNombreAsentamiento.BackColor = System.Drawing.Color.White
        Me.txtNombreAsentamiento.Enabled = False
        Me.txtNombreAsentamiento.Location = New System.Drawing.Point(197, 155)
        Me.txtNombreAsentamiento.MaxLength = 50
        Me.txtNombreAsentamiento.Name = "txtNombreAsentamiento"
        Me.txtNombreAsentamiento.Size = New System.Drawing.Size(208, 20)
        Me.txtNombreAsentamiento.TabIndex = 4
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.White
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(197, 118)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(75, 20)
        Me.txtCP.TabIndex = 3
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.White
        Me.txtNombreCompleto.Enabled = False
        Me.txtNombreCompleto.Location = New System.Drawing.Point(105, 82)
        Me.txtNombreCompleto.MaxLength = 50
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(300, 20)
        Me.txtNombreCompleto.TabIndex = 2
        '
        'txtNumExt
        '
        Me.txtNumExt.BackColor = System.Drawing.Color.White
        Me.txtNumExt.Enabled = False
        Me.txtNumExt.Location = New System.Drawing.Point(290, 315)
        Me.txtNumExt.MaxLength = 50
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(115, 20)
        Me.txtNumExt.TabIndex = 9
        '
        'txtNumInt
        '
        Me.txtNumInt.BackColor = System.Drawing.Color.White
        Me.txtNumInt.Enabled = False
        Me.txtNumInt.Location = New System.Drawing.Point(105, 311)
        Me.txtNumInt.MaxLength = 50
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(82, 20)
        Me.txtNumInt.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 368)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(399, 88)
        Me.txtDescripcion.TabIndex = 10
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.Color.White
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(105, 277)
        Me.txtCalle.MaxLength = 100
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Descripción de la fachada y señas de ubicación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Numero Ext:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numero Int:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Calle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo de vivienda:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Buscar por nombre del asentamiento::"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Buscar por CP del asentamiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre completo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Asentamiento:"
        '
        'AsentamientosTableAdapter
        '
        Me.AsentamientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetAsentamientoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tipos_viviendasTableAdapter
        '
        Me.Tipos_viviendasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetTipoViviendaComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSetDomicilio
        '
        Me.DataSetDomicilio.DataSetName = "DataSetDomicilio"
        Me.DataSetDomicilio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DomiciliosBindingSource
        '
        Me.DomiciliosBindingSource.DataMember = "domicilios"
        Me.DomiciliosBindingSource.DataSource = Me.DataSetDomicilio
        '
        'DomiciliosTableAdapter
        '
        Me.DomiciliosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = MuebleriaCasaCruz.DataSetDomicilioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DomiciliosDataGridView
        '
        Me.DomiciliosDataGridView.AllowUserToAddRows = False
        Me.DomiciliosDataGridView.AllowUserToDeleteRows = False
        Me.DomiciliosDataGridView.AutoGenerateColumns = False
        Me.DomiciliosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DomiciliosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TipoviviendaDataGridViewTextBoxColumn, Me.AsentamientoDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.NumerointeriorDataGridViewTextBoxColumn, Me.NumeroexteriorDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.NombrecompletoDataGridViewTextBoxColumn, Me.PersonaidDataGridViewTextBoxColumn, Me.AsentamientoidDataGridViewTextBoxColumn, Me.TipoviviendaidDataGridViewTextBoxColumn, Me.FecharegistroDataGridViewTextBoxColumn, Me.FechamodificacionDataGridViewTextBoxColumn, Me.ActivoDataGridViewCheckBoxColumn})
        Me.DomiciliosDataGridView.DataSource = Me.DomiciliosBindingSource
        Me.DomiciliosDataGridView.Location = New System.Drawing.Point(462, 63)
        Me.DomiciliosDataGridView.Name = "DomiciliosDataGridView"
        Me.DomiciliosDataGridView.ReadOnly = True
        Me.DomiciliosDataGridView.Size = New System.Drawing.Size(358, 484)
        Me.DomiciliosDataGridView.TabIndex = 35
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoviviendaDataGridViewTextBoxColumn
        '
        Me.TipoviviendaDataGridViewTextBoxColumn.DataPropertyName = "tipo_vivienda"
        Me.TipoviviendaDataGridViewTextBoxColumn.HeaderText = "tipo_vivienda"
        Me.TipoviviendaDataGridViewTextBoxColumn.Name = "TipoviviendaDataGridViewTextBoxColumn"
        Me.TipoviviendaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsentamientoDataGridViewTextBoxColumn
        '
        Me.AsentamientoDataGridViewTextBoxColumn.DataPropertyName = "asentamiento"
        Me.AsentamientoDataGridViewTextBoxColumn.HeaderText = "asentamiento"
        Me.AsentamientoDataGridViewTextBoxColumn.Name = "AsentamientoDataGridViewTextBoxColumn"
        Me.AsentamientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumerointeriorDataGridViewTextBoxColumn
        '
        Me.NumerointeriorDataGridViewTextBoxColumn.DataPropertyName = "numero_interior"
        Me.NumerointeriorDataGridViewTextBoxColumn.HeaderText = "numero_interior"
        Me.NumerointeriorDataGridViewTextBoxColumn.Name = "NumerointeriorDataGridViewTextBoxColumn"
        Me.NumerointeriorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroexteriorDataGridViewTextBoxColumn
        '
        Me.NumeroexteriorDataGridViewTextBoxColumn.DataPropertyName = "numero_exterior"
        Me.NumeroexteriorDataGridViewTextBoxColumn.HeaderText = "numero_exterior"
        Me.NumeroexteriorDataGridViewTextBoxColumn.Name = "NumeroexteriorDataGridViewTextBoxColumn"
        Me.NumeroexteriorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrecompletoDataGridViewTextBoxColumn
        '
        Me.NombrecompletoDataGridViewTextBoxColumn.DataPropertyName = "nombre_completo"
        Me.NombrecompletoDataGridViewTextBoxColumn.HeaderText = "nombre_completo"
        Me.NombrecompletoDataGridViewTextBoxColumn.Name = "NombrecompletoDataGridViewTextBoxColumn"
        Me.NombrecompletoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonaidDataGridViewTextBoxColumn
        '
        Me.PersonaidDataGridViewTextBoxColumn.DataPropertyName = "persona_id"
        Me.PersonaidDataGridViewTextBoxColumn.HeaderText = "persona_id"
        Me.PersonaidDataGridViewTextBoxColumn.Name = "PersonaidDataGridViewTextBoxColumn"
        Me.PersonaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonaidDataGridViewTextBoxColumn.Visible = False
        '
        'AsentamientoidDataGridViewTextBoxColumn
        '
        Me.AsentamientoidDataGridViewTextBoxColumn.DataPropertyName = "asentamiento_id"
        Me.AsentamientoidDataGridViewTextBoxColumn.HeaderText = "asentamiento_id"
        Me.AsentamientoidDataGridViewTextBoxColumn.Name = "AsentamientoidDataGridViewTextBoxColumn"
        Me.AsentamientoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AsentamientoidDataGridViewTextBoxColumn.Visible = False
        '
        'TipoviviendaidDataGridViewTextBoxColumn
        '
        Me.TipoviviendaidDataGridViewTextBoxColumn.DataPropertyName = "tipo_vivienda_id"
        Me.TipoviviendaidDataGridViewTextBoxColumn.HeaderText = "tipo_vivienda_id"
        Me.TipoviviendaidDataGridViewTextBoxColumn.Name = "TipoviviendaidDataGridViewTextBoxColumn"
        Me.TipoviviendaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoviviendaidDataGridViewTextBoxColumn.Visible = False
        '
        'FecharegistroDataGridViewTextBoxColumn
        '
        Me.FecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro"
        Me.FecharegistroDataGridViewTextBoxColumn.HeaderText = "fecha_registro"
        Me.FecharegistroDataGridViewTextBoxColumn.Name = "FecharegistroDataGridViewTextBoxColumn"
        Me.FecharegistroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechamodificacionDataGridViewTextBoxColumn
        '
        Me.FechamodificacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_modificacion"
        Me.FechamodificacionDataGridViewTextBoxColumn.HeaderText = "fecha_modificacion"
        Me.FechamodificacionDataGridViewTextBoxColumn.Name = "FechamodificacionDataGridViewTextBoxColumn"
        Me.FechamodificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        '
        'frmDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 567)
        Me.Controls.Add(Me.DomiciliosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDomicilio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Domicilio | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tipos_viviendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTipoViviendaCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsentamientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAsentamientoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomiciliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomiciliosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lbtipoestado As System.Windows.Forms.Label
    Friend WithEvents lbestado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumExt As System.Windows.Forms.TextBox
    Friend WithEvents txtNumInt As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSetAsentamientoCombo As MuebleriaCasaCruz.DataSetAsentamientoCombo
    Friend WithEvents AsentamientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsentamientosTableAdapter As MuebleriaCasaCruz.DataSetAsentamientoComboTableAdapters.asentamientosTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetAsentamientoComboTableAdapters.TableAdapterManager
    Friend WithEvents AsentamientosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetTipoViviendaCombo As MuebleriaCasaCruz.DataSetTipoViviendaCombo
    Friend WithEvents Tipos_viviendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipos_viviendasTableAdapter As MuebleriaCasaCruz.DataSetTipoViviendaComboTableAdapters.tipos_viviendasTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetTipoViviendaComboTableAdapters.TableAdapterManager
    Friend WithEvents Tipos_viviendasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetDomicilio As MuebleriaCasaCruz.DataSetDomicilio
    Friend WithEvents DomiciliosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DomiciliosTableAdapter As MuebleriaCasaCruz.DataSetDomicilioTableAdapters.domiciliosTableAdapter
    Friend WithEvents TableAdapterManager2 As MuebleriaCasaCruz.DataSetDomicilioTableAdapters.TableAdapterManager
    Friend WithEvents DomiciliosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreAsentamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoviviendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsentamientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumerointeriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroexteriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrecompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsentamientoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoviviendaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecharegistroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechamodificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
