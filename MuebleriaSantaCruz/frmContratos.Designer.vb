<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratos
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataSetConceptoPagoCombo = New MuebleriaCasaCruz.DataSetConceptoPagoCombo()
        Me.Conceptos_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conceptos_pagoTableAdapter = New MuebleriaCasaCruz.DataSetConceptoPagoComboTableAdapters.conceptos_pagoTableAdapter()
        Me.TableAdapterManager = New MuebleriaCasaCruz.DataSetConceptoPagoComboTableAdapters.TableAdapterManager()
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.DataSetClienteCombo = New MuebleriaCasaCruz.DataSetClienteCombo()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New MuebleriaCasaCruz.DataSetClienteComboTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager1 = New MuebleriaCasaCruz.DataSetClienteComboTableAdapters.TableAdapterManager()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataSetEmpleadoCombo = New MuebleriaCasaCruz.DataSetEmpleadoCombo()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New MuebleriaCasaCruz.DataSetEmpleadoComboTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager2 = New MuebleriaCasaCruz.DataSetEmpleadoComboTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.DataSetConceptoPagoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conceptos_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetClienteCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataSetEmpleadoCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(808, 351)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Datos de la venta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 329)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Productos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(184, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(808, 446)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos generales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFolio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Location = New System.Drawing.Point(15, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Contrato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de pago:"
        '
        'txtFolio
        '
        Me.txtFolio.BackColor = System.Drawing.Color.White
        Me.txtFolio.Enabled = False
        Me.txtFolio.Location = New System.Drawing.Point(95, 50)
        Me.txtFolio.MaxLength = 50
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(204, 20)
        Me.txtFolio.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Folio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(95, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 5
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(816, 472)
        Me.TabControl1.TabIndex = 1
        '
        'DataSetConceptoPagoCombo
        '
        Me.DataSetConceptoPagoCombo.DataSetName = "DataSetConceptoPagoCombo"
        Me.DataSetConceptoPagoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Conceptos_pagoBindingSource
        '
        Me.Conceptos_pagoBindingSource.DataMember = "conceptos_pago"
        Me.Conceptos_pagoBindingSource.DataSource = Me.DataSetConceptoPagoCombo
        '
        'Conceptos_pagoTableAdapter
        '
        Me.Conceptos_pagoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MuebleriaCasaCruz.DataSetConceptoPagoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.DataSource = Me.Conceptos_pagoBindingSource
        Me.cmbTipoPago.DisplayMember = "nombre"
        Me.cmbTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPago.FormattingEnabled = True
        Me.cmbTipoPago.Location = New System.Drawing.Point(95, 76)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(204, 21)
        Me.cmbTipoPago.TabIndex = 10
        Me.cmbTipoPago.ValueMember = "id"
        '
        'DataSetClienteCombo
        '
        Me.DataSetClienteCombo.DataSetName = "DataSetClienteCombo"
        Me.DataSetClienteCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSetClienteCombo
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = MuebleriaCasaCruz.DataSetClienteComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRuta)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbCliente)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox3.Location = New System.Drawing.Point(15, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(778, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = ""
        Me.GroupBox3.Text = "Datos generales del cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.cmbCliente.DataSource = Me.ClientesBindingSource
        Me.cmbCliente.DisplayMember = "nombre"
        Me.cmbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(95, 22)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(298, 21)
        Me.cmbCliente.TabIndex = 12
        Me.cmbCliente.ValueMember = "persona_id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(95, 53)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(636, 20)
        Me.txtDireccion.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ruta:"
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.Color.White
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(95, 81)
        Me.txtRuta.MaxLength = 50
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(204, 20)
        Me.txtRuta.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox4.Location = New System.Drawing.Point(15, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(778, 114)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = ""
        Me.GroupBox4.Text = "Promotor/Vendedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Vendedor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Promotor:"
        '
        'DataSetEmpleadoCombo
        '
        Me.DataSetEmpleadoCombo.DataSetName = "DataSetEmpleadoCombo"
        Me.DataSetEmpleadoCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DataSetEmpleadoCombo
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = MuebleriaCasaCruz.DataSetEmpleadoComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpleadosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(298, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "persona_id"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.EmpleadosBindingSource
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(95, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(298, 21)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.ValueMember = "persona_id"
        '
        'frmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 496)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frmContratos"
        Me.Text = "Contratos"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DataSetConceptoPagoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conceptos_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetClienteCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataSetEmpleadoCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSetConceptoPagoCombo As MuebleriaCasaCruz.DataSetConceptoPagoCombo
    Friend WithEvents Conceptos_pagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Conceptos_pagoTableAdapter As MuebleriaCasaCruz.DataSetConceptoPagoComboTableAdapters.conceptos_pagoTableAdapter
    Friend WithEvents TableAdapterManager As MuebleriaCasaCruz.DataSetConceptoPagoComboTableAdapters.TableAdapterManager
    Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetClienteCombo As MuebleriaCasaCruz.DataSetClienteCombo
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As MuebleriaCasaCruz.DataSetClienteComboTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager1 As MuebleriaCasaCruz.DataSetClienteComboTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataSetEmpleadoCombo As MuebleriaCasaCruz.DataSetEmpleadoCombo
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As MuebleriaCasaCruz.DataSetEmpleadoComboTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager2 As MuebleriaCasaCruz.DataSetEmpleadoComboTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
