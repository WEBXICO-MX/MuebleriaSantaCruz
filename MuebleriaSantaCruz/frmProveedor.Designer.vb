<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.txtNombreContacto = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtNombreComercial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProveedor = New MuebleriaCasaCruz.DataSetProveedor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ProveedoresTableAdapter = New MuebleriaCasaCruz.DataSetProveedorTableAdapters.proveedoresTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetProveedorTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_modificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.SystemColors.Control
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.btguardar, Me.btdeshacer, Me.bteditar, Me.btbuscar})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(950, 38)
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
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefonos)
        Me.GroupBox1.Controls.Add(Me.txtNombreContacto)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtNombreComercial)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 348)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(9, 322)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 7
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
        Me.txtID.Location = New System.Drawing.Point(120, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(120, 164)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(266, 84)
        Me.txtDireccion.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(120, 287)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BackColor = System.Drawing.Color.White
        Me.txtTelefonos.Enabled = False
        Me.txtTelefonos.Location = New System.Drawing.Point(120, 260)
        Me.txtTelefonos.MaxLength = 100
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(266, 20)
        Me.txtTelefonos.TabIndex = 5
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.BackColor = System.Drawing.Color.White
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Location = New System.Drawing.Point(121, 135)
        Me.txtNombreContacto.MaxLength = 50
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(266, 20)
        Me.txtNombreContacto.TabIndex = 3
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.Enabled = False
        Me.txtRazonSocial.Location = New System.Drawing.Point(120, 107)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(266, 20)
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.BackColor = System.Drawing.Color.White
        Me.txtNombreComercial.Enabled = False
        Me.txtNombreComercial.Location = New System.Drawing.Point(121, 76)
        Me.txtNombreComercial.MaxLength = 100
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Size = New System.Drawing.Size(266, 20)
        Me.txtNombreComercial.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefonos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre del contacto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Razón social:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre comercial:"
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.ProveedoresDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProveedoresDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProveedoresDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProveedoresDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.nombre_contacto, Me.direccion, Me.telefonos, Me.email, Me.fecha_registro, Me.fecha_modificacion, Me.DataGridViewCheckBoxColumn1})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(425, 66)
        Me.ProveedoresDataGridView.MultiSelect = False
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.ReadOnly = True
        Me.ProveedoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(513, 337)
        Me.ProveedoresDataGridView.TabIndex = 35
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSetProveedor
        '
        'DataSetProveedor
        '
        Me.DataSetProveedor.DataSetName = "DataSetProveedor"
        Me.DataSetProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetProveedorTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_comercial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre comercial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 122
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "razon_social"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'nombre_contacto
        '
        Me.nombre_contacto.DataPropertyName = "nombre_contacto"
        Me.nombre_contacto.HeaderText = "Nombre del contacto"
        Me.nombre_contacto.Name = "nombre_contacto"
        Me.nombre_contacto.ReadOnly = True
        Me.nombre_contacto.Width = 137
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 86
        '
        'telefonos
        '
        Me.telefonos.DataPropertyName = "telefonos"
        Me.telefonos.HeaderText = "Teléfonos"
        Me.telefonos.Name = "telefonos"
        Me.telefonos.ReadOnly = True
        Me.telefonos.Width = 88
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 62
        '
        'fecha_registro
        '
        Me.fecha_registro.DataPropertyName = "fecha_registro"
        Me.fecha_registro.HeaderText = "Fecha de registro"
        Me.fecha_registro.Name = "fecha_registro"
        Me.fecha_registro.ReadOnly = True
        Me.fecha_registro.Width = 120
        '
        'fecha_modificacion
        '
        Me.fecha_modificacion.DataPropertyName = "fecha_modificacion"
        Me.fecha_modificacion.HeaderText = "Fecha de modificación"
        Me.fecha_modificacion.Name = "fecha_modificacion"
        Me.fecha_modificacion.ReadOnly = True
        Me.fecha_modificacion.Width = 146
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 49
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 419)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProveedor, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSetProveedor As MuebleriaCasaCruz.DataSetProveedor
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As MuebleriaCasaCruz.DataSetProveedorTableAdapters.proveedoresTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetProveedorTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_contacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_registro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_modificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
