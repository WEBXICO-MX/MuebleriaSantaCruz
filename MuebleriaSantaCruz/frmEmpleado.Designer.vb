<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Estados_civilesComboBox = New System.Windows.Forms.ComboBox()
        Me.Estados_civilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstadoCivilCombo = New MuebleriaCasaCruz.DataSetEstadoCivilCombo()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.dtpFechaLaboralFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaLaboralInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.PuestosComboBox = New System.Windows.Forms.ComboBox()
        Me.PuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPuestoCombo = New MuebleriaCasaCruz.DataSetPuestoCombo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PuestosTableAdapter = New MuebleriaCasaCruz.DataSetPuestoComboTableAdapters.puestosTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetPuestoComboTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataSetEmpleado = New MuebleriaCasaCruz.DataSetEmpleado()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New MuebleriaCasaCruz.DataSetEmpleadoTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetEmpleadoTableAdapters.TableAdapterManager()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ap_paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ap_materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_laboral_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_laboral_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Estados_civilesTableAdapter = New MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.estados_civilesTableAdapter()
        Me.TableAdapterManager2 = New MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Estados_civilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadoCivilCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPuestoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(859, 38)
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
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Estados_civilesComboBox)
        Me.GroupBox1.Controls.Add(Me.rbFemenino)
        Me.GroupBox1.Controls.Add(Me.rbMasculino)
        Me.GroupBox1.Controls.Add(Me.dtpFechaLaboralFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaLaboralInicio)
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.PuestosComboBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtApMaterno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtApPaterno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 442)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(162, 411)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Domicilios"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 411)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Medios de comunicación"
        '
        'Estados_civilesComboBox
        '
        Me.Estados_civilesComboBox.DataSource = Me.Estados_civilesBindingSource
        Me.Estados_civilesComboBox.DisplayMember = "nombre"
        Me.Estados_civilesComboBox.FormattingEnabled = True
        Me.Estados_civilesComboBox.Location = New System.Drawing.Point(123, 334)
        Me.Estados_civilesComboBox.Name = "Estados_civilesComboBox"
        Me.Estados_civilesComboBox.Size = New System.Drawing.Size(300, 21)
        Me.Estados_civilesComboBox.TabIndex = 11
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
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(238, 304)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 10
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(123, 304)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 9
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'dtpFechaLaboralFin
        '
        Me.dtpFechaLaboralFin.Location = New System.Drawing.Point(123, 159)
        Me.dtpFechaLaboralFin.Name = "dtpFechaLaboralFin"
        Me.dtpFechaLaboralFin.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaLaboralFin.TabIndex = 4
        '
        'dtpFechaLaboralInicio
        '
        Me.dtpFechaLaboralInicio.Location = New System.Drawing.Point(123, 121)
        Me.dtpFechaLaboralInicio.Name = "dtpFechaLaboralInicio"
        Me.dtpFechaLaboralInicio.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaLaboralInicio.TabIndex = 3
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(123, 272)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaNacimiento.TabIndex = 8
        '
        'PuestosComboBox
        '
        Me.PuestosComboBox.DataSource = Me.PuestosBindingSource
        Me.PuestosComboBox.DisplayMember = "nombre"
        Me.PuestosComboBox.FormattingEnabled = True
        Me.PuestosComboBox.Location = New System.Drawing.Point(123, 91)
        Me.PuestosComboBox.Name = "PuestosComboBox"
        Me.PuestosComboBox.Size = New System.Drawing.Size(300, 21)
        Me.PuestosComboBox.TabIndex = 2
        Me.PuestosComboBox.ValueMember = "id"
        '
        'PuestosBindingSource
        '
        Me.PuestosBindingSource.DataMember = "puestos"
        Me.PuestosBindingSource.DataSource = Me.DataSetPuestoCombo
        '
        'DataSetPuestoCombo
        '
        Me.DataSetPuestoCombo.DataSetName = "DataSetPuestoCombo"
        Me.DataSetPuestoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha laboral fin:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha laboral inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Puesto"
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(11, 376)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 12
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
        Me.Label1.Location = New System.Drawing.Point(11, 50)
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
        Me.Label8.Location = New System.Drawing.Point(8, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sexo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estado civil:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de nacimiento:"
        '
        'txtApMaterno
        '
        Me.txtApMaterno.BackColor = System.Drawing.Color.White
        Me.txtApMaterno.Enabled = False
        Me.txtApMaterno.Location = New System.Drawing.Point(123, 240)
        Me.txtApMaterno.MaxLength = 50
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(211, 20)
        Me.txtApMaterno.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido materno:"
        '
        'txtApPaterno
        '
        Me.txtApPaterno.BackColor = System.Drawing.Color.White
        Me.txtApPaterno.Enabled = False
        Me.txtApPaterno.Location = New System.Drawing.Point(123, 214)
        Me.txtApPaterno.MaxLength = 50
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(211, 20)
        Me.txtApPaterno.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellido paterno:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(123, 188)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre:"
        '
        'PuestosTableAdapter
        '
        Me.PuestosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetPuestoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataSetEmpleado
        '
        Me.DataSetEmpleado.DataSetName = "DataSetEmpleado"
        Me.DataSetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DataSetEmpleado
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetEmpleadoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.nombre, Me.ap_paterno, Me.ap_materno, Me.fecha_nacimiento, Me.sexo, Me.estado_civil, Me.puesto, Me.fecha_laboral_inicio, Me.fecha_laboral_fin, Me.estado_civil_id, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(469, 58)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.ReadOnly = True
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(372, 438)
        Me.EmpleadosDataGridView.TabIndex = 38
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
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.HeaderText = "puesto"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        '
        'fecha_laboral_inicio
        '
        Me.fecha_laboral_inicio.DataPropertyName = "fecha_laboral_inicio"
        Me.fecha_laboral_inicio.HeaderText = "fecha_laboral_inicio"
        Me.fecha_laboral_inicio.Name = "fecha_laboral_inicio"
        Me.fecha_laboral_inicio.ReadOnly = True
        '
        'fecha_laboral_fin
        '
        Me.fecha_laboral_fin.DataPropertyName = "fecha_laboral_fin"
        Me.fecha_laboral_fin.HeaderText = "fecha_laboral_fin"
        Me.fecha_laboral_fin.Name = "fecha_laboral_fin"
        Me.fecha_laboral_fin.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "puesto_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "puesto_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha_registro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha_registro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Estados_civilesTableAdapter
        '
        Me.Estados_civilesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(271, 411)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel3.TabIndex = 15
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Referencias"
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 508)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Estados_civilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadoCivilCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPuestoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataSetPuestoCombo As MuebleriaCasaCruz.DataSetPuestoCombo
    Friend WithEvents PuestosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PuestosTableAdapter As MuebleriaCasaCruz.DataSetPuestoComboTableAdapters.puestosTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetPuestoComboTableAdapters.TableAdapterManager
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents PuestosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents rbFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents DataSetEmpleado As MuebleriaCasaCruz.DataSetEmpleado
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As MuebleriaCasaCruz.DataSetEmpleadoTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetEmpleadoTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataSetEstadoCivilCombo As MuebleriaCasaCruz.DataSetEstadoCivilCombo
    Friend WithEvents Estados_civilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estados_civilesTableAdapter As MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.estados_civilesTableAdapter
    Friend WithEvents TableAdapterManager2 As MuebleriaCasaCruz.DataSetEstadoCivilComboTableAdapters.TableAdapterManager
    Friend WithEvents Estados_civilesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents dtpFechaLaboralFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaLaboralInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ap_paterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ap_materno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_civil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents puesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_laboral_inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_laboral_fin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_civil_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
