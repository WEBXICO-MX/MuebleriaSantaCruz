<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.cmbformapago = New System.Windows.Forms.ComboBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbsubtotal = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.lbIVA = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.DetalleFactura = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtfechacompra = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btcancelar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 557)
        Me.Panel1.TabIndex = 16
        '
        'btcancelar
        '
        Me.btcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btcancelar.Location = New System.Drawing.Point(727, 573)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 24)
        Me.btcancelar.TabIndex = 68
        Me.btcancelar.Text = "&Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtimporte)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbproducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbproveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtfechacompra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Controls.Add(Me.cmbformapago)
        Me.GroupBox1.Controls.Add(Me.txtobservacion)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbsubtotal)
        Me.GroupBox1.Controls.Add(Me.txtsubtotal)
        Me.GroupBox1.Controls.Add(Me.lbIVA)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.DetalleFactura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 540)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(704, 515)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 124
        Me.Label22.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal.Location = New System.Drawing.Point(750, 508)
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 20)
        Me.txtTotal.TabIndex = 123
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(174, 515)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "Descuento:"
        '
        'txtdescuento
        '
        Me.txtdescuento.BackColor = System.Drawing.Color.White
        Me.txtdescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescuento.Location = New System.Drawing.Point(249, 508)
        Me.txtdescuento.MaxLength = 10
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.ReadOnly = True
        Me.txtdescuento.Size = New System.Drawing.Size(85, 20)
        Me.txtdescuento.TabIndex = 121
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbformapago
        '
        Me.cmbformapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbformapago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbformapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbformapago.FormattingEnabled = True
        Me.cmbformapago.Items.AddRange(New Object() {"Efectivo", "Cheques", "Tranferencia Electrónica", "Tarjeta de Débito", "Tarjeta de Crédito", "Efectivo y Tarjeta de Débito", "Efectivo y Tarjeta de Crédito"})
        Me.cmbformapago.Location = New System.Drawing.Point(105, 143)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Size = New System.Drawing.Size(161, 21)
        Me.cmbformapago.TabIndex = 4
        '
        'txtobservacion
        '
        Me.txtobservacion.BackColor = System.Drawing.Color.White
        Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.Location = New System.Drawing.Point(95, 424)
        Me.txtobservacion.MaxLength = 80
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservacion.Size = New System.Drawing.Size(743, 52)
        Me.txtobservacion.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Observación:"
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        Me.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcantidad.Location = New System.Drawing.Point(787, 172)
        Me.txtcantidad.MaxLength = 3
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(49, 20)
        Me.txtcantidad.TabIndex = 9
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(734, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Cantidad:"
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtprecio.Location = New System.Drawing.Point(635, 172)
        Me.txtprecio.MaxLength = 10
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(93, 20)
        Me.txtprecio.TabIndex = 92
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(583, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Costo: $"
        '
        'lbsubtotal
        '
        Me.lbsubtotal.AutoSize = True
        Me.lbsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbsubtotal.Location = New System.Drawing.Point(14, 515)
        Me.lbsubtotal.Name = "lbsubtotal"
        Me.lbsubtotal.Size = New System.Drawing.Size(62, 13)
        Me.lbsubtotal.TabIndex = 87
        Me.lbsubtotal.Text = "SubTotal:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BackColor = System.Drawing.Color.White
        Me.txtsubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsubtotal.Location = New System.Drawing.Point(76, 508)
        Me.txtsubtotal.MaxLength = 10
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(85, 20)
        Me.txtsubtotal.TabIndex = 86
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbIVA
        '
        Me.lbIVA.AutoSize = True
        Me.lbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbIVA.Location = New System.Drawing.Point(538, 515)
        Me.lbIVA.Name = "lbIVA"
        Me.lbIVA.Size = New System.Drawing.Size(31, 13)
        Me.lbIVA.TabIndex = 83
        Me.lbIVA.Text = "IVA:"
        Me.lbIVA.Visible = False
        '
        'txtIVA
        '
        Me.txtIVA.BackColor = System.Drawing.Color.White
        Me.txtIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIVA.Location = New System.Drawing.Point(575, 508)
        Me.txtIVA.MaxLength = 10
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(102, 20)
        Me.txtIVA.TabIndex = 82
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVA.Visible = False
        '
        'DetalleFactura
        '
        Me.DetalleFactura.AllowUserToAddRows = False
        Me.DetalleFactura.AllowUserToResizeColumns = False
        Me.DetalleFactura.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DetalleFactura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DetalleFactura.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DetalleFactura.Enabled = False
        Me.DetalleFactura.Location = New System.Drawing.Point(13, 199)
        Me.DetalleFactura.MultiSelect = False
        Me.DetalleFactura.Name = "DetalleFactura"
        Me.DetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DetalleFactura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DetalleFactura.Size = New System.Drawing.Size(825, 209)
        Me.DetalleFactura.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Compras"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(750, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(105, 29)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 127
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfechacompra
        '
        Me.txtfechacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechacompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechacompra.Location = New System.Drawing.Point(105, 60)
        Me.txtfechacompra.Name = "txtfechacompra"
        Me.txtfechacompra.Size = New System.Drawing.Size(107, 20)
        Me.txtfechacompra.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Fecha de compra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "No. de Factura:"
        '
        'txtNumFactura
        '
        Me.txtNumFactura.BackColor = System.Drawing.Color.White
        Me.txtNumFactura.Enabled = False
        Me.txtNumFactura.Location = New System.Drawing.Point(105, 86)
        Me.txtNumFactura.MaxLength = 100
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(107, 20)
        Me.txtNumFactura.TabIndex = 132
        '
        'cmbproveedor
        '
        Me.cmbproveedor.DisplayMember = "nombre_comercial"
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(105, 116)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(284, 21)
        Me.cmbproveedor.TabIndex = 133
        Me.cmbproveedor.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Proveedor:"
        '
        'cmbproducto
        '
        Me.cmbproducto.DisplayMember = "nombre"
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(105, 171)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(464, 21)
        Me.cmbproducto.TabIndex = 135
        Me.cmbproducto.ValueMember = "id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Forma de pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(362, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Importe:"
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.White
        Me.txtimporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtimporte.Location = New System.Drawing.Point(437, 508)
        Me.txtimporte.MaxLength = 10
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.ReadOnly = True
        Me.txtimporte.Size = New System.Drawing.Size(85, 20)
        Me.txtimporte.TabIndex = 138
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Column1
        '
        Me.Column1.HeaderText = "Clave"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 320
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Costo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column5
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "Importe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCompras"
        Me.Text = "Compras | Mueblería Casa Cruz"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btcancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents cmbformapago As System.Windows.Forms.ComboBox
    Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbsubtotal As System.Windows.Forms.Label
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lbIVA As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents DetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtfechacompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
