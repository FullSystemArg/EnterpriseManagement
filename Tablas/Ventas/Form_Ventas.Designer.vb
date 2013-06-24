<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Ventas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Fecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Operacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Garantia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Facturacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_Forma = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_Precio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_Ganancia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_Costo = New System.Windows.Forms.TextBox()
        Me.tb_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_Codigo = New System.Windows.Forms.ComboBox()
        Me.cb_Articulo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_Origen = New System.Windows.Forms.ComboBox()
        Me.cb_Envio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DG_Ventas = New System.Windows.Forms.DataGridView()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.DgD = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'tb_Fecha
        '
        Me.tb_Fecha.Location = New System.Drawing.Point(85, 54)
        Me.tb_Fecha.Name = "tb_Fecha"
        Me.tb_Fecha.Size = New System.Drawing.Size(171, 20)
        Me.tb_Fecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° de operación"
        '
        'tb_Operacion
        '
        Me.tb_Operacion.Location = New System.Drawing.Point(103, 22)
        Me.tb_Operacion.Name = "tb_Operacion"
        Me.tb_Operacion.Size = New System.Drawing.Size(67, 20)
        Me.tb_Operacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "N° de garantia"
        '
        'tb_Garantia
        '
        Me.tb_Garantia.Location = New System.Drawing.Point(120, 80)
        Me.tb_Garantia.Name = "tb_Garantia"
        Me.tb_Garantia.Size = New System.Drawing.Size(136, 20)
        Me.tb_Garantia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "N° de facturacion"
        '
        'tb_Facturacion
        '
        Me.tb_Facturacion.Location = New System.Drawing.Point(135, 106)
        Me.tb_Facturacion.Name = "tb_Facturacion"
        Me.tb_Facturacion.Size = New System.Drawing.Size(121, 20)
        Me.tb_Facturacion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Forma de pago"
        '
        'cb_Forma
        '
        Me.cb_Forma.FormattingEnabled = True
        Me.cb_Forma.Items.AddRange(New Object() {"MercadoPago", "Banco", "Contado"})
        Me.cb_Forma.Location = New System.Drawing.Point(126, 168)
        Me.cb_Forma.Name = "cb_Forma"
        Me.cb_Forma.Size = New System.Drawing.Size(130, 21)
        Me.cb_Forma.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.tb_Precio)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lbl_Ganancia)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tb_Costo)
        Me.GroupBox1.Controls.Add(Me.tb_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tb_Codigo)
        Me.GroupBox1.Controls.Add(Me.cb_Articulo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cb_Origen)
        Me.GroupBox1.Controls.Add(Me.cb_Envio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cb_Forma)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tb_Facturacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_Garantia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_Operacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 236)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(261, 54)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 33
        Me.MonthCalendar1.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(348, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(315, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Precio"
        '
        'tb_Precio
        '
        Me.tb_Precio.Location = New System.Drawing.Point(363, 173)
        Me.tb_Precio.Name = "tb_Precio"
        Me.tb_Precio.Size = New System.Drawing.Size(97, 20)
        Me.tb_Precio.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(348, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(315, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Costo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(428, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 16)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "$"
        '
        'lbl_Ganancia
        '
        Me.lbl_Ganancia.AutoSize = True
        Me.lbl_Ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ganancia.ForeColor = System.Drawing.Color.Green
        Me.lbl_Ganancia.Location = New System.Drawing.Point(440, 202)
        Me.lbl_Ganancia.Name = "lbl_Ganancia"
        Me.lbl_Ganancia.Size = New System.Drawing.Size(16, 16)
        Me.lbl_Ganancia.TabIndex = 45
        Me.lbl_Ganancia.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(348, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Ganancia"
        '
        'tb_Costo
        '
        Me.tb_Costo.Location = New System.Drawing.Point(363, 152)
        Me.tb_Costo.Name = "tb_Costo"
        Me.tb_Costo.Size = New System.Drawing.Size(97, 20)
        Me.tb_Costo.TabIndex = 11
        '
        'tb_Cantidad
        '
        Me.tb_Cantidad.Location = New System.Drawing.Point(362, 109)
        Me.tb_Cantidad.Name = "tb_Cantidad"
        Me.tb_Cantidad.Size = New System.Drawing.Size(162, 20)
        Me.tb_Cantidad.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Cantidad"
        '
        'tb_Codigo
        '
        Me.tb_Codigo.FormattingEnabled = True
        Me.tb_Codigo.Location = New System.Drawing.Point(391, 54)
        Me.tb_Codigo.Name = "tb_Codigo"
        Me.tb_Codigo.Size = New System.Drawing.Size(133, 21)
        Me.tb_Codigo.TabIndex = 8
        '
        'cb_Articulo
        '
        Me.cb_Articulo.FormattingEnabled = True
        Me.cb_Articulo.Location = New System.Drawing.Point(355, 80)
        Me.cb_Articulo.Name = "cb_Articulo"
        Me.cb_Articulo.Size = New System.Drawing.Size(169, 21)
        Me.cb_Articulo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Codigo Articulo"
        '
        'cb_Origen
        '
        Me.cb_Origen.FormattingEnabled = True
        Me.cb_Origen.Items.AddRange(New Object() {"MercadoLibre", "Página"})
        Me.cb_Origen.Location = New System.Drawing.Point(80, 135)
        Me.cb_Origen.Name = "cb_Origen"
        Me.cb_Origen.Size = New System.Drawing.Size(176, 21)
        Me.cb_Origen.TabIndex = 5
        '
        'cb_Envio
        '
        Me.cb_Envio.FormattingEnabled = True
        Me.cb_Envio.Items.AddRange(New Object() {"Falta Pagar Envio", "Enviar", "Enviado", "Retira", "Retirado"})
        Me.cb_Envio.Location = New System.Drawing.Point(126, 197)
        Me.cb_Envio.Name = "cb_Envio"
        Me.cb_Envio.Size = New System.Drawing.Size(130, 21)
        Me.cb_Envio.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Forma de Envio"
        '
        'DG_Ventas
        '
        Me.DG_Ventas.AllowUserToAddRows = False
        Me.DG_Ventas.AllowUserToDeleteRows = False
        Me.DG_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Ventas.Location = New System.Drawing.Point(12, 254)
        Me.DG_Ventas.Name = "DG_Ventas"
        Me.DG_Ventas.ReadOnly = True
        Me.DG_Ventas.Size = New System.Drawing.Size(550, 301)
        Me.DG_Ventas.TabIndex = 31
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(438, 569)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(59, 21)
        Me.btn_Eliminar.TabIndex = 15
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(50, 561)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 14
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(12, 561)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 17
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(503, 569)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(59, 21)
        Me.btn_Grabar.TabIndex = 13
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'DgD
        '
        Me.DgD.AllowUserToAddRows = False
        Me.DgD.AllowUserToDeleteRows = False
        Me.DgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgD.Location = New System.Drawing.Point(218, 594)
        Me.DgD.Name = "DgD"
        Me.DgD.ReadOnly = True
        Me.DgD.Size = New System.Drawing.Size(13, 16)
        Me.DgD.TabIndex = 32
        Me.DgD.Visible = False
        '
        'Form_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 605)
        Me.Controls.Add(Me.DgD)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.DG_Ventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Form_Ventas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_Operacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_Garantia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_Facturacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_Forma As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents cb_Envio As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents cb_Origen As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Articulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_Costo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_Ganancia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tb_Precio As System.Windows.Forms.TextBox
    Friend WithEvents DgD As System.Windows.Forms.DataGridView
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
