<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CuentasBancarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CuentasBancarias))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DD_Banco = New System.Windows.Forms.ComboBox()
        Me.DD_Moneda = New System.Windows.Forms.ComboBox()
        Me.tb_CBU = New System.Windows.Forms.TextBox()
        Me.tb_Nro = New System.Windows.Forms.TextBox()
        Me.DD_Tipo = New System.Windows.Forms.ComboBox()
        Me.cb_TipoFondoFijo = New System.Windows.Forms.CheckBox()
        Me.cb_Inactiva = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_CuentasBancarias = New System.Windows.Forms.DataGridView()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DD_Banco)
        Me.Panel1.Controls.Add(Me.DD_Moneda)
        Me.Panel1.Controls.Add(Me.tb_CBU)
        Me.Panel1.Controls.Add(Me.tb_Nro)
        Me.Panel1.Controls.Add(Me.DD_Tipo)
        Me.Panel1.Controls.Add(Me.cb_TipoFondoFijo)
        Me.Panel1.Controls.Add(Me.cb_Inactiva)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 114)
        Me.Panel1.TabIndex = 1
        '
        'DD_Banco
        '
        Me.DD_Banco.FormattingEnabled = True
        Me.DD_Banco.Location = New System.Drawing.Point(183, 7)
        Me.DD_Banco.Name = "DD_Banco"
        Me.DD_Banco.Size = New System.Drawing.Size(189, 21)
        Me.DD_Banco.TabIndex = 11
        '
        'DD_Moneda
        '
        Me.DD_Moneda.FormattingEnabled = True
        Me.DD_Moneda.Location = New System.Drawing.Point(296, 34)
        Me.DD_Moneda.Name = "DD_Moneda"
        Me.DD_Moneda.Size = New System.Drawing.Size(76, 21)
        Me.DD_Moneda.TabIndex = 10
        '
        'tb_CBU
        '
        Me.tb_CBU.Location = New System.Drawing.Point(57, 61)
        Me.tb_CBU.Name = "tb_CBU"
        Me.tb_CBU.Size = New System.Drawing.Size(181, 20)
        Me.tb_CBU.TabIndex = 9
        '
        'tb_Nro
        '
        Me.tb_Nro.Location = New System.Drawing.Point(57, 37)
        Me.tb_Nro.Name = "tb_Nro"
        Me.tb_Nro.Size = New System.Drawing.Size(181, 20)
        Me.tb_Nro.TabIndex = 8
        '
        'DD_Tipo
        '
        Me.DD_Tipo.FormattingEnabled = True
        Me.DD_Tipo.Location = New System.Drawing.Point(57, 7)
        Me.DD_Tipo.Name = "DD_Tipo"
        Me.DD_Tipo.Size = New System.Drawing.Size(76, 21)
        Me.DD_Tipo.TabIndex = 7
        '
        'cb_TipoFondoFijo
        '
        Me.cb_TipoFondoFijo.AutoSize = True
        Me.cb_TipoFondoFijo.Location = New System.Drawing.Point(340, 64)
        Me.cb_TipoFondoFijo.Name = "cb_TipoFondoFijo"
        Me.cb_TipoFondoFijo.Size = New System.Drawing.Size(99, 17)
        Me.cb_TipoFondoFijo.TabIndex = 6
        Me.cb_TipoFondoFijo.Text = "Tipo Fondo Fijo"
        Me.cb_TipoFondoFijo.UseVisualStyleBackColor = True
        '
        'cb_Inactiva
        '
        Me.cb_Inactiva.AutoSize = True
        Me.cb_Inactiva.Location = New System.Drawing.Point(259, 64)
        Me.cb_Inactiva.Name = "cb_Inactiva"
        Me.cb_Inactiva.Size = New System.Drawing.Size(64, 17)
        Me.cb_Inactiva.TabIndex = 5
        Me.cb_Inactiva.Text = "Inactiva"
        Me.cb_Inactiva.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Moneda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Banco"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CBU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'DG_CuentasBancarias
        '
        Me.DG_CuentasBancarias.AllowUserToAddRows = False
        Me.DG_CuentasBancarias.AllowUserToDeleteRows = False
        Me.DG_CuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CuentasBancarias.Location = New System.Drawing.Point(10, 130)
        Me.DG_CuentasBancarias.Name = "DG_CuentasBancarias"
        Me.DG_CuentasBancarias.ReadOnly = True
        Me.DG_CuentasBancarias.Size = New System.Drawing.Size(509, 141)
        Me.DG_CuentasBancarias.TabIndex = 2
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(449, 300)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Grabar.TabIndex = 3
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(371, 301)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(10, 295)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 5
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Location = New System.Drawing.Point(293, 301)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Modificar.TabIndex = 6
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'Form_CuentasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 336)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.DG_CuentasBancarias)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_CuentasBancarias"
        Me.Text = "CuentasBancarias / Fondos Fijos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_TipoFondoFijo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Inactiva As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_CuentasBancarias As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents DD_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Nro As System.Windows.Forms.TextBox
    Friend WithEvents DD_Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents tb_CBU As System.Windows.Forms.TextBox
    Friend WithEvents DD_Banco As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
End Class
