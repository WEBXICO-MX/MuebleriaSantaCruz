<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OcupacionesComboBox2 = New System.Windows.Forms.ComboBox()
        Me.OcupacionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOcupacionCombo2 = New MuebleriaCasaCruz.DataSetOcupacionCombo2()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Estados_civilesComboBox = New System.Windows.Forms.ComboBox()
        Me.Estados_civilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstadoCivilCombo = New MuebleriaCasaCruz.DataSetEstadoCivilCombo()
        Me.Tipos_identificacionComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipos_identificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTipoIdentificacionCombo = New MuebleriaCasaCruz.DataSetTipoIdentificacionCombo()
        Me.OcupacionesComboBox = New System.Windows.Forms.ComboBox()
        Me.OcupacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOcupacionCombo = New MuebleriaCasaCruz.DataSetOcupacionCombo()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombreConyuge = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OcupacionesTableAdapter = New MuebleriaCasaCruz.DataSetOcupacionComboTableAdapters.ocupacionesTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetOcupacionComboTableAdapters.TableAdapterManager()
        Me.Tipos_identificacionTableAdapter = New MuebleriaCasaCruz.DataSetTipoIdentificacionComboTableAdapters.tipos_identificacionTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetTipoIdentificacionComboTableAdapters.TableAdapterManager()
        Me.DataSetCliente = New MuebleriaCasaCruz.DataSetCliente()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New MuebleriaCasaCruz.DataSetClienteTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager2 = New MuebleriaCasaCruz.DataSetClienteTableAdapters.TableAdapterManager()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ap_paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ap_materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_conyuge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion_conyuge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion_conyuge_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Estados_civilesTableAdapter = New MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.estados_civilesTableAdapter()
        Me.TableAdapterManager3 = New MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager()
        Me.OcupacionesTableAdapter1 = New MuebleriaCasaCruz.DataSetOcupacionCombo2TableAdapters.ocupacionesTableAdapter()
        Me.TableAdapterManager4 = New MuebleriaCasaCruz.DataSetOcupacionCombo2TableAdapters.TableAdapterManager()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OcupacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOcupacionCombo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estados_civilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadoCivilCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipos_identificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTipoIdentificacionCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOcupacionCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(859, 38)
        Me.BarraHerramientas.TabIndex = 35
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
        Me.GroupBox1.Controls.Add(Me.OcupacionesComboBox2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Estados_civilesComboBox)
        Me.GroupBox1.Controls.Add(Me.Tipos_identificacionComboBox)
        Me.GroupBox1.Controls.Add(Me.OcupacionesComboBox)
        Me.GroupBox1.Controls.Add(Me.rbFemenino)
        Me.GroupBox1.Controls.Add(Me.rbMasculino)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNumIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtNombreConyuge)
        Me.GroupBox1.Controls.Add(Me.txtEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtApMaterno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtApPaterno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 454)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'OcupacionesComboBox2
        '
        Me.OcupacionesComboBox2.DataSource = Me.OcupacionesBindingSource1
        Me.OcupacionesComboBox2.DisplayMember = "nombre"
        Me.OcupacionesComboBox2.FormattingEnabled = True
        Me.OcupacionesComboBox2.Location = New System.Drawing.Point(123, 366)
        Me.OcupacionesComboBox2.Name = "OcupacionesComboBox2"
        Me.OcupacionesComboBox2.Size = New System.Drawing.Size(211, 21)
        Me.OcupacionesComboBox2.TabIndex = 14
        Me.OcupacionesComboBox2.ValueMember = "id"
        '
        'OcupacionesBindingSource1
        '
        Me.OcupacionesBindingSource1.DataMember = "ocupaciones"
        Me.OcupacionesBindingSource1.DataSource = Me.DataSetOcupacionCombo2
        '
        'DataSetOcupacionCombo2
        '
        Me.DataSetOcupacionCombo2.DataSetName = "DataSetOcupacionCombo2"
        Me.DataSetOcupacionCombo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(280, 418)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel3.TabIndex = 18
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Referencias"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(183, 418)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Domicilios"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 418)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Medios de comunicación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Sexo:"
        '
        'Estados_civilesComboBox
        '
        Me.Estados_civilesComboBox.DataSource = Me.Estados_civilesBindingSource
        Me.Estados_civilesComboBox.DisplayMember = "nombre"
        Me.Estados_civilesComboBox.FormattingEnabled = True
        Me.Estados_civilesComboBox.Location = New System.Drawing.Point(123, 196)
        Me.Estados_civilesComboBox.Name = "Estados_civilesComboBox"
        Me.Estados_civilesComboBox.Size = New System.Drawing.Size(211, 21)
        Me.Estados_civilesComboBox.TabIndex = 8
        Me.Estados_civilesComboBox.ValueMember = "id"
        '
        'Estados_civilesBindingSource
        '
        Me.Estados_civilesBindingSource.DataMember = "estados_civiles"
        Me.Estados_civilesBindingSource.DataSource = Me.DataSetEstadoCivilCombo
        '
        'DataSetEstadoCivilCombo
        '
        Me.DataSetEstadoCivilCombo.DataSetName = "DataSetEstadoCivilCombo"
        Me.DataSetEstadoCivilCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipos_identificacionComboBox
        '
        Me.Tipos_identificacionComboBox.DataSource = Me.Tipos_identificacionBindingSource
        Me.Tipos_identificacionComboBox.DisplayMember = "nombre"
        Me.Tipos_identificacionComboBox.FormattingEnabled = True
        Me.Tipos_identificacionComboBox.Location = New System.Drawing.Point(123, 279)
        Me.Tipos_identificacionComboBox.Name = "Tipos_identificacionComboBox"
        Me.Tipos_identificacionComboBox.Size = New System.Drawing.Size(211, 21)
        Me.Tipos_identificacionComboBox.TabIndex = 11
        Me.Tipos_identificacionComboBox.ValueMember = "id"
        '
        'Tipos_identificacionBindingSource
        '
        Me.Tipos_identificacionBindingSource.DataMember = "tipos_identificacion"
        Me.Tipos_identificacionBindingSource.DataSource = Me.DataSetTipoIdentificacionCombo
        '
        'DataSetTipoIdentificacionCombo
        '
        Me.DataSetTipoIdentificacionCombo.DataSetName = "DataSetTipoIdentificacionCombo"
        Me.DataSetTipoIdentificacionCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OcupacionesComboBox
        '
        Me.OcupacionesComboBox.DataSource = Me.OcupacionesBindingSource
        Me.OcupacionesComboBox.DisplayMember = "nombre"
        Me.OcupacionesComboBox.FormattingEnabled = True
        Me.OcupacionesComboBox.Location = New System.Drawing.Point(123, 223)
        Me.OcupacionesComboBox.Name = "OcupacionesComboBox"
        Me.OcupacionesComboBox.Size = New System.Drawing.Size(211, 21)
        Me.OcupacionesComboBox.TabIndex = 9
        Me.OcupacionesComboBox.ValueMember = "id"
        '
        'OcupacionesBindingSource
        '
        Me.OcupacionesBindingSource.DataMember = "ocupaciones"
        Me.OcupacionesBindingSource.DataSource = Me.DataSetOcupacionCombo
        '
        'DataSetOcupacionCombo
        '
        Me.DataSetOcupacionCombo.DataSetName = "DataSetOcupacionCombo"
        Me.DataSetOcupacionCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(202, 173)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 7
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(123, 171)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 6
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tipo de identificación:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Numero de identificación:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nombre del conyuge:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Empresa:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Ocupación conyuge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ocupación:"
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(11, 394)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 15
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Estado civil:"
        '
        'txtNumIdentificacion
        '
        Me.txtNumIdentificacion.BackColor = System.Drawing.Color.White
        Me.txtNumIdentificacion.Enabled = False
        Me.txtNumIdentificacion.Location = New System.Drawing.Point(141, 307)
        Me.txtNumIdentificacion.MaxLength = 30
        Me.txtNumIdentificacion.Name = "txtNumIdentificacion"
        Me.txtNumIdentificacion.Size = New System.Drawing.Size(193, 20)
        Me.txtNumIdentificacion.TabIndex = 12
        '
        'txtNombreConyuge
        '
        Me.txtNombreConyuge.BackColor = System.Drawing.Color.White
        Me.txtNombreConyuge.Enabled = False
        Me.txtNombreConyuge.Location = New System.Drawing.Point(123, 337)
        Me.txtNombreConyuge.MaxLength = 100
        Me.txtNombreConyuge.Name = "txtNombreConyuge"
        Me.txtNombreConyuge.Size = New System.Drawing.Size(211, 20)
        Me.txtNombreConyuge.TabIndex = 13
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Location = New System.Drawing.Point(123, 250)
        Me.txtEmpresa.MaxLength = 100
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(211, 20)
        Me.txtEmpresa.TabIndex = 10
        '
        'txtApMaterno
        '
        Me.txtApMaterno.BackColor = System.Drawing.Color.White
        Me.txtApMaterno.Enabled = False
        Me.txtApMaterno.Location = New System.Drawing.Point(123, 136)
        Me.txtApMaterno.MaxLength = 50
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(211, 20)
        Me.txtApMaterno.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido materno:"
        '
        'txtApPaterno
        '
        Me.txtApPaterno.BackColor = System.Drawing.Color.White
        Me.txtApPaterno.Enabled = False
        Me.txtApPaterno.Location = New System.Drawing.Point(123, 110)
        Me.txtApPaterno.MaxLength = 50
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(211, 20)
        Me.txtApPaterno.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellido paterno:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(123, 84)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre:"
        '
        'OcupacionesTableAdapter
        '
        Me.OcupacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetOcupacionComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tipos_identificacionTableAdapter
        '
        Me.Tipos_identificacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetTipoIdentificacionComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSetCliente
        '
        Me.DataSetCliente.DataSetName = "DataSetCliente"
        Me.DataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSetCliente
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = MuebleriaCasaCruz.DataSetClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.nombre, Me.ap_paterno, Me.ap_materno, Me.fecha_nacimiento, Me.sexo, Me.estado_civil, Me.ocupacion, Me.empresa, Me.tipo_identificacion, Me.numero_identificacion, Me.nombre_conyuge, Me.ocupacion_conyuge, Me.estado_civil_id, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ocupacion_conyuge_id, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(417, 59)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.Size = New System.Drawing.Size(430, 445)
        Me.ClientesDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "persona_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "persona_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'ap_paterno
        '
        Me.ap_paterno.DataPropertyName = "ap_paterno"
        Me.ap_paterno.HeaderText = "ap_paterno"
        Me.ap_paterno.Name = "ap_paterno"
        Me.ap_paterno.ReadOnly = True
        '
        'ap_materno
        '
        Me.ap_materno.DataPropertyName = "ap_materno"
        Me.ap_materno.HeaderText = "ap_materno"
        Me.ap_materno.Name = "ap_materno"
        Me.ap_materno.ReadOnly = True
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.DataPropertyName = "fecha_nacimiento"
        Me.fecha_nacimiento.HeaderText = "fecha_nacimiento"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        Me.fecha_nacimiento.ReadOnly = True
        '
        'sexo
        '
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        '
        'estado_civil
        '
        Me.estado_civil.DataPropertyName = "estado_civil"
        Me.estado_civil.HeaderText = "estado_civil"
        Me.estado_civil.Name = "estado_civil"
        Me.estado_civil.ReadOnly = True
        '
        'ocupacion
        '
        Me.ocupacion.DataPropertyName = "ocupacion"
        Me.ocupacion.HeaderText = "ocupacion"
        Me.ocupacion.Name = "ocupacion"
        Me.ocupacion.ReadOnly = True
        '
        'empresa
        '
        Me.empresa.DataPropertyName = "empresa"
        Me.empresa.HeaderText = "empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'tipo_identificacion
        '
        Me.tipo_identificacion.DataPropertyName = "tipo_identificacion"
        Me.tipo_identificacion.HeaderText = "tipo_identificacion"
        Me.tipo_identificacion.Name = "tipo_identificacion"
        Me.tipo_identificacion.ReadOnly = True
        '
        'numero_identificacion
        '
        Me.numero_identificacion.DataPropertyName = "numero_identificacion"
        Me.numero_identificacion.HeaderText = "numero_identificacion"
        Me.numero_identificacion.Name = "numero_identificacion"
        Me.numero_identificacion.ReadOnly = True
        '
        'nombre_conyuge
        '
        Me.nombre_conyuge.DataPropertyName = "nombre_conyuge"
        Me.nombre_conyuge.HeaderText = "nombre_conyuge"
        Me.nombre_conyuge.Name = "nombre_conyuge"
        Me.nombre_conyuge.ReadOnly = True
        '
        'ocupacion_conyuge
        '
        Me.ocupacion_conyuge.DataPropertyName = "ocupacion_conyuge"
        Me.ocupacion_conyuge.HeaderText = "ocupacion_conyuge"
        Me.ocupacion_conyuge.Name = "ocupacion_conyuge"
        Me.ocupacion_conyuge.ReadOnly = True
        '
        'estado_civil_id
        '
        Me.estado_civil_id.DataPropertyName = "estado_civil_id"
        Me.estado_civil_id.HeaderText = "estado_civil_id"
        Me.estado_civil_id.Name = "estado_civil_id"
        Me.estado_civil_id.ReadOnly = True
        Me.estado_civil_id.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ocupacion_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ocupacion_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo_identificacion_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tipo_identificacion_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'ocupacion_conyuge_id
        '
        Me.ocupacion_conyuge_id.DataPropertyName = "ocupacion_conyuge_id"
        Me.ocupacion_conyuge_id.HeaderText = "ocupacion_conyuge_id"
        Me.ocupacion_conyuge_id.Name = "ocupacion_conyuge_id"
        Me.ocupacion_conyuge_id.ReadOnly = True
        Me.ocupacion_conyuge_id.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_registro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha_registro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Estados_civilesTableAdapter
        '
        Me.Estados_civilesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OcupacionesTableAdapter1
        '
        Me.OcupacionesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = MuebleriaCasaCruz.DataSetOcupacionCombo2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 517)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OcupacionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOcupacionCombo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estados_civilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadoCivilCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipos_identificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTipoIdentificacionCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOcupacionCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rbFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lbtipoestado As System.Windows.Forms.Label
    Friend WithEvents lbestado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtApMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSetOcupacionCombo As MuebleriaCasaCruz.DataSetOcupacionCombo
    Friend WithEvents OcupacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OcupacionesTableAdapter As MuebleriaCasaCruz.DataSetOcupacionComboTableAdapters.ocupacionesTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetOcupacionComboTableAdapters.TableAdapterManager
    Friend WithEvents OcupacionesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetTipoIdentificacionCombo As MuebleriaCasaCruz.DataSetTipoIdentificacionCombo
    Friend WithEvents Tipos_identificacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipos_identificacionTableAdapter As MuebleriaCasaCruz.DataSetTipoIdentificacionComboTableAdapters.tipos_identificacionTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetTipoIdentificacionComboTableAdapters.TableAdapterManager
    Friend WithEvents Tipos_identificacionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetCliente As MuebleriaCasaCruz.DataSetCliente
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As MuebleriaCasaCruz.DataSetClienteTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager2 As MuebleriaCasaCruz.DataSetClienteTableAdapters.TableAdapterManager
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataSetEstadoCivilCombo As MuebleriaCasaCruz.DataSetEstadoCivilCombo
    Friend WithEvents Estados_civilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estados_civilesTableAdapter As MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.estados_civilesTableAdapter
    Friend WithEvents TableAdapterManager3 As MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager
    Friend WithEvents Estados_civilesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumIdentificacion As TextBox
    Friend WithEvents txtNombreConyuge As TextBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents DataSetOcupacionCombo2 As DataSetOcupacionCombo2
    Friend WithEvents OcupacionesBindingSource1 As BindingSource
    Friend WithEvents OcupacionesTableAdapter1 As DataSetOcupacionCombo2TableAdapters.ocupacionesTableAdapter
    Friend WithEvents TableAdapterManager4 As DataSetOcupacionCombo2TableAdapters.TableAdapterManager
    Friend WithEvents OcupacionesComboBox2 As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents ap_paterno As DataGridViewTextBoxColumn
    Friend WithEvents ap_materno As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents estado_civil As DataGridViewTextBoxColumn
    Friend WithEvents ocupacion As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents tipo_identificacion As DataGridViewTextBoxColumn
    Friend WithEvents numero_identificacion As DataGridViewTextBoxColumn
    Friend WithEvents nombre_conyuge As DataGridViewTextBoxColumn
    Friend WithEvents ocupacion_conyuge As DataGridViewTextBoxColumn
    Friend WithEvents estado_civil_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ocupacion_conyuge_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
