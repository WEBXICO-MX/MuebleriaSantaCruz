<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedioComunicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedioComunicacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tipos_medios_comunicacionComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipos_medios_comunicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTipoMedioComunicacionCombo = New MuebleriaCasaCruz.DataSetTipoMedioComunicacionCombo()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tipos_medios_comunicacionTableAdapter = New MuebleriaCasaCruz.DataSetTipoMedioComunicacionComboTableAdapters.tipos_medios_comunicacionTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetTipoMedioComunicacionComboTableAdapters.TableAdapterManager()
        Me.DataSetMedioDeComunicacion = New MuebleriaCasaCruz.DataSetMedioDeComunicacion()
        Me.Medios_comunicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medios_comunicacionTableAdapter = New MuebleriaCasaCruz.DataSetMedioDeComunicacionTableAdapters.medios_comunicacionTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetMedioDeComunicacionTableAdapters.TableAdapterManager()
        Me.Medios_comunicacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medio_comunicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_medio_comunicacion_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediocomunicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrecompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tipos_medios_comunicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTipoMedioComunicacionCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMedioDeComunicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medios_comunicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medios_comunicacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(832, 38)
        Me.BarraHerramientas.TabIndex = 32
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
        Me.GroupBox1.Controls.Add(Me.Tipos_medios_comunicacionComboBox)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDato)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 223)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Tipos_medios_comunicacionComboBox
        '
        Me.Tipos_medios_comunicacionComboBox.DataSource = Me.Tipos_medios_comunicacionBindingSource
        Me.Tipos_medios_comunicacionComboBox.DisplayMember = "nombre"
        Me.Tipos_medios_comunicacionComboBox.FormattingEnabled = True
        Me.Tipos_medios_comunicacionComboBox.Location = New System.Drawing.Point(135, 104)
        Me.Tipos_medios_comunicacionComboBox.Name = "Tipos_medios_comunicacionComboBox"
        Me.Tipos_medios_comunicacionComboBox.Size = New System.Drawing.Size(300, 21)
        Me.Tipos_medios_comunicacionComboBox.TabIndex = 2
        Me.Tipos_medios_comunicacionComboBox.ValueMember = "id"
        '
        'Tipos_medios_comunicacionBindingSource
        '
        Me.Tipos_medios_comunicacionBindingSource.DataMember = "tipos_medios_comunicacion"
        Me.Tipos_medios_comunicacionBindingSource.DataSource = Me.DataSetTipoMedioComunicacionCombo
        '
        'DataSetTipoMedioComunicacionCombo
        '
        Me.DataSetTipoMedioComunicacionCombo.DataSetName = "DataSetTipoMedioComunicacionCombo"
        Me.DataSetTipoMedioComunicacionCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(9, 172)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 4
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
        'txtDato
        '
        Me.txtDato.BackColor = System.Drawing.Color.White
        Me.txtDato.Enabled = False
        Me.txtDato.Location = New System.Drawing.Point(135, 135)
        Me.txtDato.MaxLength = 50
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(300, 20)
        Me.txtDato.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(135, 76)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(300, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Medio de comunicación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre completo:"
        '
        'Tipos_medios_comunicacionTableAdapter
        '
        Me.Tipos_medios_comunicacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetTipoMedioComunicacionComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSetMedioDeComunicacion
        '
        Me.DataSetMedioDeComunicacion.DataSetName = "DataSetMedioDeComunicacion"
        Me.DataSetMedioDeComunicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medios_comunicacionBindingSource
        '
        Me.Medios_comunicacionBindingSource.DataMember = "medios_comunicacion"
        Me.Medios_comunicacionBindingSource.DataSource = Me.DataSetMedioDeComunicacion
        '
        'Medios_comunicacionTableAdapter
        '
        Me.Medios_comunicacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetMedioDeComunicacionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Medios_comunicacionDataGridView
        '
        Me.Medios_comunicacionDataGridView.AllowUserToAddRows = False
        Me.Medios_comunicacionDataGridView.AllowUserToDeleteRows = False
        Me.Medios_comunicacionDataGridView.AllowUserToResizeRows = False
        Me.Medios_comunicacionDataGridView.AutoGenerateColumns = False
        Me.Medios_comunicacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Medios_comunicacionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Medios_comunicacionDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Medios_comunicacionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Medios_comunicacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Medios_comunicacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MediocomunicacionDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn, Me.NombrecompletoDataGridViewTextBoxColumn, Me.TipomediocomunicacionidDataGridViewTextBoxColumn, Me.PersonaidDataGridViewTextBoxColumn, Me.ActivoDataGridViewCheckBoxColumn})
        Me.Medios_comunicacionDataGridView.DataSource = Me.Medios_comunicacionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Medios_comunicacionDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Medios_comunicacionDataGridView.Location = New System.Drawing.Point(473, 53)
        Me.Medios_comunicacionDataGridView.MultiSelect = False
        Me.Medios_comunicacionDataGridView.Name = "Medios_comunicacionDataGridView"
        Me.Medios_comunicacionDataGridView.ReadOnly = True
        Me.Medios_comunicacionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Medios_comunicacionDataGridView.Size = New System.Drawing.Size(339, 220)
        Me.Medios_comunicacionDataGridView.TabIndex = 34
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
        'medio_comunicacion
        '
        Me.medio_comunicacion.DataPropertyName = "medio_comunicacion"
        Me.medio_comunicacion.HeaderText = "medio_comunicacion"
        Me.medio_comunicacion.Name = "medio_comunicacion"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'tipo_medio_comunicacion_id
        '
        Me.tipo_medio_comunicacion_id.DataPropertyName = "tipo_medio_comunicacion_id"
        Me.tipo_medio_comunicacion_id.HeaderText = "tipo_medio_comunicacion_id"
        Me.tipo_medio_comunicacion_id.Name = "tipo_medio_comunicacion_id"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "id"
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipo_medio_comunicacion_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipo_medio_comunicacion_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 43
        '
        'MediocomunicacionDataGridViewTextBoxColumn
        '
        Me.MediocomunicacionDataGridViewTextBoxColumn.DataPropertyName = "medio_comunicacion"
        Me.MediocomunicacionDataGridViewTextBoxColumn.HeaderText = "Medio comunicación"
        Me.MediocomunicacionDataGridViewTextBoxColumn.Name = "MediocomunicacionDataGridViewTextBoxColumn"
        Me.MediocomunicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.MediocomunicacionDataGridViewTextBoxColumn.Width = 135
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Dato"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorDataGridViewTextBoxColumn.Width = 59
        '
        'NombrecompletoDataGridViewTextBoxColumn
        '
        Me.NombrecompletoDataGridViewTextBoxColumn.DataPropertyName = "nombre_completo"
        Me.NombrecompletoDataGridViewTextBoxColumn.HeaderText = "Nombre completo"
        Me.NombrecompletoDataGridViewTextBoxColumn.Name = "NombrecompletoDataGridViewTextBoxColumn"
        Me.NombrecompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombrecompletoDataGridViewTextBoxColumn.Width = 119
        '
        'TipomediocomunicacionidDataGridViewTextBoxColumn
        '
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn.DataPropertyName = "tipo_medio_comunicacion_id"
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn.HeaderText = "tipo_medio_comunicacion_id"
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn.Name = "TipomediocomunicacionidDataGridViewTextBoxColumn"
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipomediocomunicacionidDataGridViewTextBoxColumn.Visible = False
        '
        'PersonaidDataGridViewTextBoxColumn
        '
        Me.PersonaidDataGridViewTextBoxColumn.DataPropertyName = "persona_id"
        Me.PersonaidDataGridViewTextBoxColumn.HeaderText = "persona_id"
        Me.PersonaidDataGridViewTextBoxColumn.Name = "PersonaidDataGridViewTextBoxColumn"
        Me.PersonaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonaidDataGridViewTextBoxColumn.Visible = False
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActivoDataGridViewCheckBoxColumn.Width = 49
        '
        'frmMedioComunicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 299)
        Me.Controls.Add(Me.Medios_comunicacionDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMedioComunicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medio de comunicación | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tipos_medios_comunicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTipoMedioComunicacionCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMedioDeComunicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medios_comunicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medios_comunicacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSetTipoMedioComunicacionCombo As MuebleriaCasaCruz.DataSetTipoMedioComunicacionCombo
    Friend WithEvents Tipos_medios_comunicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipos_medios_comunicacionTableAdapter As MuebleriaCasaCruz.DataSetTipoMedioComunicacionComboTableAdapters.tipos_medios_comunicacionTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetTipoMedioComunicacionComboTableAdapters.TableAdapterManager
    Friend WithEvents Tipos_medios_comunicacionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetMedioDeComunicacion As MuebleriaCasaCruz.DataSetMedioDeComunicacion
    Friend WithEvents Medios_comunicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medios_comunicacionTableAdapter As MuebleriaCasaCruz.DataSetMedioDeComunicacionTableAdapters.medios_comunicacionTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetMedioDeComunicacionTableAdapters.TableAdapterManager
    Friend WithEvents Medios_comunicacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medio_comunicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_medio_comunicacion_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediocomunicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrecompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipomediocomunicacionidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
