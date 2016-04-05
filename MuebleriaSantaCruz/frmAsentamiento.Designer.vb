<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsentamiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsentamiento))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.btdeshacer = New System.Windows.Forms.ToolStripButton()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MunicipiosComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMunicipioCombo = New MuebleriaCasaCruz.DataSetMunicipioCombo()
        Me.Tipos_asentamientosComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipos_asentamientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTipoAsentamientoCombo = New MuebleriaCasaCruz.DataSetTipoAsentamientoCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.lbtipoestado = New System.Windows.Forms.Label()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tipos_asentamientosTableAdapter = New MuebleriaCasaCruz.DataSetTipoAsentamientoComboTableAdapters.tipos_asentamientosTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetTipoAsentamientoComboTableAdapters.TableAdapterManager()
        Me.MunicipiosTableAdapter = New MuebleriaCasaCruz.DataSetMunicipioComboTableAdapters.municipiosTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetMunicipioComboTableAdapters.TableAdapterManager()
        Me.DataSetAsentamiento = New MuebleriaCasaCruz.DataSetAsentamiento()
        Me.AsentamientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsentamientosTableAdapter = New MuebleriaCasaCruz.DataSetAsentamientoTableAdapters.asentamientosTableAdapter()
        Me.TableAdapterManager2 = New MuebleriaCasaCruz.DataSetAsentamientoTableAdapters.TableAdapterManager()
        Me.AsentamientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_asentamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMunicipioCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipos_asentamientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTipoAsentamientoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAsentamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsentamientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsentamientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.MunicipiosComboBox)
        Me.GroupBox1.Controls.Add(Me.Tipos_asentamientosComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxActivo)
        Me.GroupBox1.Controls.Add(Me.lbtipoestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtCP)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 260)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'MunicipiosComboBox
        '
        Me.MunicipiosComboBox.DataSource = Me.MunicipiosBindingSource
        Me.MunicipiosComboBox.DisplayMember = "nombre"
        Me.MunicipiosComboBox.FormattingEnabled = True
        Me.MunicipiosComboBox.Location = New System.Drawing.Point(109, 110)
        Me.MunicipiosComboBox.Name = "MunicipiosComboBox"
        Me.MunicipiosComboBox.Size = New System.Drawing.Size(211, 21)
        Me.MunicipiosComboBox.TabIndex = 3
        Me.MunicipiosComboBox.ValueMember = "id"
        '
        'MunicipiosBindingSource
        '
        Me.MunicipiosBindingSource.DataMember = "municipios"
        Me.MunicipiosBindingSource.DataSource = Me.DataSetMunicipioCombo
        '
        'DataSetMunicipioCombo
        '
        Me.DataSetMunicipioCombo.DataSetName = "DataSetMunicipioCombo"
        Me.DataSetMunicipioCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipos_asentamientosComboBox
        '
        Me.Tipos_asentamientosComboBox.DataSource = Me.Tipos_asentamientosBindingSource
        Me.Tipos_asentamientosComboBox.DisplayMember = "nombre"
        Me.Tipos_asentamientosComboBox.FormattingEnabled = True
        Me.Tipos_asentamientosComboBox.Location = New System.Drawing.Point(109, 78)
        Me.Tipos_asentamientosComboBox.Name = "Tipos_asentamientosComboBox"
        Me.Tipos_asentamientosComboBox.Size = New System.Drawing.Size(211, 21)
        Me.Tipos_asentamientosComboBox.TabIndex = 2
        Me.Tipos_asentamientosComboBox.ValueMember = "id"
        '
        'Tipos_asentamientosBindingSource
        '
        Me.Tipos_asentamientosBindingSource.DataMember = "tipos_asentamientos"
        Me.Tipos_asentamientosBindingSource.DataSource = Me.DataSetTipoAsentamientoCombo
        '
        'DataSetTipoAsentamientoCombo
        '
        Me.DataSetTipoAsentamientoCombo.DataSetName = "DataSetTipoAsentamientoCombo"
        Me.DataSetTipoAsentamientoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo asentamiento:"
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Checked = True
        Me.cbxActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxActivo.Location = New System.Drawing.Point(11, 215)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbxActivo.TabIndex = 6
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
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.White
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(109, 177)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(71, 20)
        Me.txtCP.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(109, 144)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Código postal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Asentamiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Municipio"
        '
        'Tipos_asentamientosTableAdapter
        '
        Me.Tipos_asentamientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetTipoAsentamientoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MunicipiosTableAdapter
        '
        Me.MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetMunicipioComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSetAsentamiento
        '
        Me.DataSetAsentamiento.DataSetName = "DataSetAsentamiento"
        Me.DataSetAsentamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsentamientosBindingSource
        '
        Me.AsentamientosBindingSource.DataMember = "asentamientos"
        Me.AsentamientosBindingSource.DataSource = Me.DataSetAsentamiento
        '
        'AsentamientosTableAdapter
        '
        Me.AsentamientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = MuebleriaCasaCruz.DataSetAsentamientoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AsentamientosDataGridView
        '
        Me.AsentamientosDataGridView.AllowUserToAddRows = False
        Me.AsentamientosDataGridView.AllowUserToDeleteRows = False
        Me.AsentamientosDataGridView.AutoGenerateColumns = False
        Me.AsentamientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsentamientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.tipo_asentamiento, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.municipio, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.AsentamientosDataGridView.DataSource = Me.AsentamientosBindingSource
        Me.AsentamientosDataGridView.Location = New System.Drawing.Point(373, 49)
        Me.AsentamientosDataGridView.Name = "AsentamientosDataGridView"
        Me.AsentamientosDataGridView.ReadOnly = True
        Me.AsentamientosDataGridView.Size = New System.Drawing.Size(474, 252)
        Me.AsentamientosDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'tipo_asentamiento
        '
        Me.tipo_asentamiento.DataPropertyName = "tipo_asentamiento"
        Me.tipo_asentamiento.HeaderText = "tipo_asentamiento"
        Me.tipo_asentamiento.Name = "tipo_asentamiento"
        Me.tipo_asentamiento.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cp"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'municipio
        '
        Me.municipio.DataPropertyName = "municipio"
        Me.municipio.HeaderText = "municipio"
        Me.municipio.Name = "municipio"
        Me.municipio.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipo_asentamiento_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipo_asentamiento_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "municipio_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "municipio_id"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAsentamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 321)
        Me.Controls.Add(Me.AsentamientosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.MaximizeBox = False
        Me.Name = "frmAsentamiento"
        Me.Text = "Asentamiento(s) | Mueblería Casa Cruz"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMunicipioCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipos_asentamientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTipoAsentamientoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAsentamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsentamientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsentamientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraHerramientas As ToolStrip
    Friend WithEvents btnuevo As ToolStripButton
    Friend WithEvents btguardar As ToolStripButton
    Friend WithEvents btdeshacer As ToolStripButton
    Friend WithEvents bteditar As ToolStripButton
    Friend WithEvents btbuscar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxActivo As CheckBox
    Friend WithEvents lbtipoestado As Label
    Friend WithEvents lbestado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataSetTipoAsentamientoCombo As DataSetTipoAsentamientoCombo
    Friend WithEvents Tipos_asentamientosBindingSource As BindingSource
    Friend WithEvents Tipos_asentamientosTableAdapter As DataSetTipoAsentamientoComboTableAdapters.tipos_asentamientosTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTipoAsentamientoComboTableAdapters.TableAdapterManager
    Friend WithEvents Tipos_asentamientosComboBox As ComboBox
    Friend WithEvents DataSetMunicipioCombo As DataSetMunicipioCombo
    Friend WithEvents MunicipiosBindingSource As BindingSource
    Friend WithEvents MunicipiosTableAdapter As DataSetMunicipioComboTableAdapters.municipiosTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetMunicipioComboTableAdapters.TableAdapterManager
    Friend WithEvents MunicipiosComboBox As ComboBox
    Friend WithEvents DataSetAsentamiento As DataSetAsentamiento
    Friend WithEvents AsentamientosBindingSource As BindingSource
    Friend WithEvents AsentamientosTableAdapter As DataSetAsentamientoTableAdapters.asentamientosTableAdapter
    Friend WithEvents TableAdapterManager2 As DataSetAsentamientoTableAdapters.TableAdapterManager
    Friend WithEvents AsentamientosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents tipo_asentamiento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents municipio As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
