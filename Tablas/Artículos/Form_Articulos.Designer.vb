<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Articulos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_Proveedor = New System.Windows.Forms.ComboBox()
        Me.tb_Moneda = New System.Windows.Forms.ComboBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Alta = New System.Windows.Forms.Button()
        Me.tb_Origen = New System.Windows.Forms.TextBox()
        Me.tb_Destino = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_Fecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_Codigo = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Reposicion = New System.Windows.Forms.Label()
        Me.lbl_Minimo = New System.Windows.Forms.Label()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Grabar_Articulo = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Eliminar_Articulo = New System.Windows.Forms.Button()
        Me.tb_Barras = New System.Windows.Forms.TextBox()
        Me.tb_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_Barra = New System.Windows.Forms.Label()
        Me.lbl_Fabricante = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DG_Articulos = New System.Windows.Forms.DataGridView()
        Me.DgD = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DG_Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cb_Codigo)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_Buscar)
        Me.Panel1.Controls.Add(Me.btn_Grabar_Articulo)
        Me.Panel1.Controls.Add(Me.btn_Limpiar)
        Me.Panel1.Controls.Add(Me.btn_Eliminar_Articulo)
        Me.Panel1.Controls.Add(Me.tb_Barras)
        Me.Panel1.Controls.Add(Me.tb_Descripcion)
        Me.Panel1.Controls.Add(Me.lbl_Descripcion)
        Me.Panel1.Controls.Add(Me.lbl_Barra)
        Me.Panel1.Controls.Add(Me.lbl_Fabricante)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 503)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cb_Proveedor)
        Me.Panel2.Controls.Add(Me.tb_Moneda)
        Me.Panel2.Controls.Add(Me.btn_Clear)
        Me.Panel2.Controls.Add(Me.btn_Alta)
        Me.Panel2.Controls.Add(Me.tb_Origen)
        Me.Panel2.Controls.Add(Me.tb_Destino)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.tb_Fecha)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-1, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 155)
        Me.Panel2.TabIndex = 40
        '
        'cb_Proveedor
        '
        Me.cb_Proveedor.FormattingEnabled = True
        Me.cb_Proveedor.Location = New System.Drawing.Point(85, 25)
        Me.cb_Proveedor.Name = "cb_Proveedor"
        Me.cb_Proveedor.Size = New System.Drawing.Size(176, 21)
        Me.cb_Proveedor.TabIndex = 53
        '
        'tb_Moneda
        '
        Me.tb_Moneda.FormattingEnabled = True
        Me.tb_Moneda.Location = New System.Drawing.Point(207, 50)
        Me.tb_Moneda.Name = "tb_Moneda"
        Me.tb_Moneda.Size = New System.Drawing.Size(54, 21)
        Me.tb_Moneda.TabIndex = 52
        '
        'btn_Clear
        '
        Me.btn_Clear.Image = CType(resources.GetObject("btn_Clear.Image"), System.Drawing.Image)
        Me.btn_Clear.Location = New System.Drawing.Point(11, 108)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(36, 37)
        Me.btn_Clear.TabIndex = 51
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Alta
        '
        Me.btn_Alta.Location = New System.Drawing.Point(207, 115)
        Me.btn_Alta.Name = "btn_Alta"
        Me.btn_Alta.Size = New System.Drawing.Size(63, 23)
        Me.btn_Alta.TabIndex = 50
        Me.btn_Alta.Text = "Alta"
        Me.btn_Alta.UseVisualStyleBackColor = True
        '
        'tb_Origen
        '
        Me.tb_Origen.Location = New System.Drawing.Point(65, 77)
        Me.tb_Origen.Name = "tb_Origen"
        Me.tb_Origen.Size = New System.Drawing.Size(70, 20)
        Me.tb_Origen.TabIndex = 49
        '
        'tb_Destino
        '
        Me.tb_Destino.Location = New System.Drawing.Point(190, 77)
        Me.tb_Destino.Name = "tb_Destino"
        Me.tb_Destino.Size = New System.Drawing.Size(71, 20)
        Me.tb_Destino.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(141, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Cantidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Articulo"
        '
        'tb_Fecha
        '
        Me.tb_Fecha.Location = New System.Drawing.Point(65, 51)
        Me.tb_Fecha.Name = "tb_Fecha"
        Me.tb_Fecha.Size = New System.Drawing.Size(84, 20)
        Me.tb_Fecha.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Proveedor"
        '
        'cb_Codigo
        '
        Me.cb_Codigo.FormattingEnabled = True
        Me.cb_Codigo.Location = New System.Drawing.Point(137, 22)
        Me.cb_Codigo.Name = "cb_Codigo"
        Me.cb_Codigo.Size = New System.Drawing.Size(131, 21)
        Me.cb_Codigo.TabIndex = 39
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox15)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBox6)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_Reposicion)
        Me.Panel3.Controls.Add(Me.lbl_Minimo)
        Me.Panel3.Controls.Add(Me.lbl_Precio)
        Me.Panel3.Location = New System.Drawing.Point(8, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(271, 157)
        Me.Panel3.TabIndex = 38
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(209, 105)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(46, 20)
        Me.TextBox15.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(168, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Stock"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(108, 8)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(72, 20)
        Me.TextBox6.TabIndex = 44
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(71, 31)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 43
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(87, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(67, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(87, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 40
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Flete $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Embalaje $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Costo $"
        '
        'lbl_Reposicion
        '
        Me.lbl_Reposicion.AutoSize = True
        Me.lbl_Reposicion.Location = New System.Drawing.Point(10, 132)
        Me.lbl_Reposicion.Name = "lbl_Reposicion"
        Me.lbl_Reposicion.Size = New System.Drawing.Size(108, 13)
        Me.lbl_Reposicion.TabIndex = 35
        Me.lbl_Reposicion.Text = "Punto De Reposicion"
        '
        'lbl_Minimo
        '
        Me.lbl_Minimo.AutoSize = True
        Me.lbl_Minimo.Location = New System.Drawing.Point(10, 108)
        Me.lbl_Minimo.Name = "lbl_Minimo"
        Me.lbl_Minimo.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Minimo.TabIndex = 34
        Me.lbl_Minimo.Text = "Stock Minimo"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(10, 11)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Precio.TabIndex = 33
        Me.lbl_Precio.Text = "Precio Costo Final"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(53, 289)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 21
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Grabar_Articulo
        '
        Me.btn_Grabar_Articulo.Location = New System.Drawing.Point(207, 303)
        Me.btn_Grabar_Articulo.Name = "btn_Grabar_Articulo"
        Me.btn_Grabar_Articulo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Grabar_Articulo.TabIndex = 37
        Me.btn_Grabar_Articulo.Text = "Grabar"
        Me.btn_Grabar_Articulo.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(11, 289)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 20
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar_Articulo
        '
        Me.btn_Eliminar_Articulo.Location = New System.Drawing.Point(135, 303)
        Me.btn_Eliminar_Articulo.Name = "btn_Eliminar_Articulo"
        Me.btn_Eliminar_Articulo.Size = New System.Drawing.Size(66, 23)
        Me.btn_Eliminar_Articulo.TabIndex = 20
        Me.btn_Eliminar_Articulo.Text = "Eliminar"
        Me.btn_Eliminar_Articulo.UseVisualStyleBackColor = True
        '
        'tb_Barras
        '
        Me.tb_Barras.Location = New System.Drawing.Point(117, 75)
        Me.tb_Barras.Name = "tb_Barras"
        Me.tb_Barras.Size = New System.Drawing.Size(151, 20)
        Me.tb_Barras.TabIndex = 34
        '
        'tb_Descripcion
        '
        Me.tb_Descripcion.Location = New System.Drawing.Point(92, 49)
        Me.tb_Descripcion.Name = "tb_Descripcion"
        Me.tb_Descripcion.Size = New System.Drawing.Size(176, 20)
        Me.tb_Descripcion.TabIndex = 33
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(23, 52)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 20
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'lbl_Barra
        '
        Me.lbl_Barra.AutoSize = True
        Me.lbl_Barra.Location = New System.Drawing.Point(23, 78)
        Me.lbl_Barra.Name = "lbl_Barra"
        Me.lbl_Barra.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Barra.TabIndex = 19
        Me.lbl_Barra.Text = "Código de Barras"
        '
        'lbl_Fabricante
        '
        Me.lbl_Fabricante.AutoSize = True
        Me.lbl_Fabricante.Location = New System.Drawing.Point(23, 25)
        Me.lbl_Fabricante.Name = "lbl_Fabricante"
        Me.lbl_Fabricante.Size = New System.Drawing.Size(108, 13)
        Me.lbl_Fabricante.TabIndex = 18
        Me.lbl_Fabricante.Text = "Código de Fabricante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Articulos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Alta De Stock"
        '
        'DG_Articulos
        '
        Me.DG_Articulos.AllowUserToAddRows = False
        Me.DG_Articulos.AllowUserToDeleteRows = False
        Me.DG_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Articulos.Location = New System.Drawing.Point(309, 14)
        Me.DG_Articulos.Name = "DG_Articulos"
        Me.DG_Articulos.ReadOnly = True
        Me.DG_Articulos.Size = New System.Drawing.Size(883, 501)
        Me.DG_Articulos.TabIndex = 40
        '
        'DgD
        '
        Me.DgD.AllowUserToAddRows = False
        Me.DgD.AllowUserToDeleteRows = False
        Me.DgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgD.Location = New System.Drawing.Point(259, 517)
        Me.DgD.Name = "DgD"
        Me.DgD.ReadOnly = True
        Me.DgD.Size = New System.Drawing.Size(50, 23)
        Me.DgD.TabIndex = 41
        Me.DgD.Visible = False
        '
        'Form_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 521)
        Me.Controls.Add(Me.DgD)
        Me.Controls.Add(Me.DG_Articulos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Articulos"
        Me.Text = "Articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DG_Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Barras As System.Windows.Forms.TextBox
    Friend WithEvents tb_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Barra As System.Windows.Forms.Label
    Friend WithEvents lbl_Fabricante As System.Windows.Forms.Label
    Friend WithEvents btn_Grabar_Articulo As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar_Articulo As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Reposicion As System.Windows.Forms.Label
    Friend WithEvents lbl_Minimo As System.Windows.Forms.Label
    Friend WithEvents lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents DG_Articulos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tb_Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Alta As System.Windows.Forms.Button
    Friend WithEvents tb_Origen As System.Windows.Forms.TextBox
    Friend WithEvents tb_Destino As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_Proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents DgD As System.Windows.Forms.DataGridView
End Class
