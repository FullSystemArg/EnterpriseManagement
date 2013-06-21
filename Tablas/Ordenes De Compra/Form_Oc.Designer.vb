<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Oc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Oc))
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.cb_Proveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Moneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Fecha = New System.Windows.Forms.TextBox()
        Me.tb_Cotizacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_Entrega = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DG_Ordenes = New System.Windows.Forms.DataGridView()
        Me.cb_Articulo = New System.Windows.Forms.ComboBox()
        Me.tb_Precio = New System.Windows.Forms.TextBox()
        Me.DgD = New System.Windows.Forms.DataGridView()
        Me.tb_Cliente = New System.Windows.Forms.ComboBox()
        CType(Me.DG_Ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(391, 425)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(57, 27)
        Me.btn_Eliminar.TabIndex = 60
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(57, 415)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 59
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(15, 415)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 58
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(454, 425)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(63, 27)
        Me.btn_Grabar.TabIndex = 10
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'cb_Proveedor
        '
        Me.cb_Proveedor.FormattingEnabled = True
        Me.cb_Proveedor.Location = New System.Drawing.Point(85, 55)
        Me.cb_Proveedor.Name = "cb_Proveedor"
        Me.cb_Proveedor.Size = New System.Drawing.Size(119, 21)
        Me.cb_Proveedor.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Proveedor"
        '
        'cb_Moneda
        '
        Me.cb_Moneda.FormattingEnabled = True
        Me.cb_Moneda.Location = New System.Drawing.Point(274, 92)
        Me.cb_Moneda.Name = "cb_Moneda"
        Me.cb_Moneda.Size = New System.Drawing.Size(70, 21)
        Me.cb_Moneda.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Moneda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 26)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Precio de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Codigo de articulo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Cantidad"
        '
        'tb_Cantidad
        '
        Me.tb_Cantidad.Location = New System.Drawing.Point(274, 21)
        Me.tb_Cantidad.Name = "tb_Cantidad"
        Me.tb_Cantidad.Size = New System.Drawing.Size(70, 20)
        Me.tb_Cantidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Fecha"
        '
        'tb_Fecha
        '
        Me.tb_Fecha.Location = New System.Drawing.Point(404, 20)
        Me.tb_Fecha.Name = "tb_Fecha"
        Me.tb_Fecha.Size = New System.Drawing.Size(79, 20)
        Me.tb_Fecha.TabIndex = 3
        '
        'tb_Cotizacion
        '
        Me.tb_Cotizacion.Location = New System.Drawing.Point(414, 93)
        Me.tb_Cotizacion.Name = "tb_Cotizacion"
        Me.tb_Cotizacion.Size = New System.Drawing.Size(71, 20)
        Me.tb_Cotizacion.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(352, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Cotización"
        '
        'tb_Entrega
        '
        Me.tb_Entrega.Location = New System.Drawing.Point(419, 56)
        Me.tb_Entrega.Name = "tb_Entrega"
        Me.tb_Entrega.Size = New System.Drawing.Size(66, 20)
        Me.tb_Entrega.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(361, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 26)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  entrega"
        '
        'DG_Ordenes
        '
        Me.DG_Ordenes.AllowUserToAddRows = False
        Me.DG_Ordenes.AllowUserToDeleteRows = False
        Me.DG_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Ordenes.Location = New System.Drawing.Point(9, 129)
        Me.DG_Ordenes.Name = "DG_Ordenes"
        Me.DG_Ordenes.ReadOnly = True
        Me.DG_Ordenes.Size = New System.Drawing.Size(505, 280)
        Me.DG_Ordenes.TabIndex = 72
        '
        'cb_Articulo
        '
        Me.cb_Articulo.FormattingEnabled = True
        Me.cb_Articulo.Location = New System.Drawing.Point(115, 20)
        Me.cb_Articulo.Name = "cb_Articulo"
        Me.cb_Articulo.Size = New System.Drawing.Size(89, 21)
        Me.cb_Articulo.TabIndex = 1
        '
        'tb_Precio
        '
        Me.tb_Precio.Location = New System.Drawing.Point(274, 56)
        Me.tb_Precio.Name = "tb_Precio"
        Me.tb_Precio.Size = New System.Drawing.Size(70, 20)
        Me.tb_Precio.TabIndex = 5
        '
        'DgD
        '
        Me.DgD.AllowUserToAddRows = False
        Me.DgD.AllowUserToDeleteRows = False
        Me.DgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgD.Location = New System.Drawing.Point(167, 428)
        Me.DgD.Name = "DgD"
        Me.DgD.ReadOnly = True
        Me.DgD.Size = New System.Drawing.Size(25, 24)
        Me.DgD.TabIndex = 75
        Me.DgD.Visible = False
        '
        'tb_Cliente
        '
        Me.tb_Cliente.FormattingEnabled = True
        Me.tb_Cliente.Items.AddRange(New Object() {"MercadoLibre", "Página"})
        Me.tb_Cliente.Location = New System.Drawing.Point(68, 89)
        Me.tb_Cliente.Name = "tb_Cliente"
        Me.tb_Cliente.Size = New System.Drawing.Size(136, 21)
        Me.tb_Cliente.TabIndex = 7
        '
        'Form_Oc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 459)
        Me.Controls.Add(Me.tb_Cliente)
        Me.Controls.Add(Me.DgD)
        Me.Controls.Add(Me.tb_Precio)
        Me.Controls.Add(Me.cb_Articulo)
        Me.Controls.Add(Me.DG_Ordenes)
        Me.Controls.Add(Me.tb_Entrega)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_Cotizacion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_Fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Cantidad)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.cb_Proveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_Moneda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form_Oc"
        Me.Text = "Ordenes de compra"
        CType(Me.DG_Ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents cb_Proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents tb_Cotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_Entrega As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DG_Ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents cb_Articulo As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Precio As System.Windows.Forms.TextBox
    Friend WithEvents DgD As System.Windows.Forms.DataGridView
    Friend WithEvents tb_Cliente As System.Windows.Forms.ComboBox
End Class
