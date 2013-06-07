<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Proveedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.tb_Numero = New System.Windows.Forms.TextBox()
        Me.tb_RazonSocial = New System.Windows.Forms.TextBox()
        Me.tb_NombreFantasia = New System.Windows.Forms.TextBox()
        Me.tb_Domicilio = New System.Windows.Forms.TextBox()
        Me.tb_Cp = New System.Windows.Forms.TextBox()
        Me.tb_CUIT = New System.Windows.Forms.TextBox()
        Me.DD_Estado = New System.Windows.Forms.ComboBox()
        Me.DgD = New System.Windows.Forms.DataGridView()
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razón Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Fantasia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Domicilio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(330, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "C.U.I.T"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(330, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Codigo Postal"
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(12, 151)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 16
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(405, 157)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 24)
        Me.btn_Eliminar.TabIndex = 15
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(483, 157)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(75, 24)
        Me.btn_Grabar.TabIndex = 14
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(54, 151)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 18
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tb_Numero
        '
        Me.tb_Numero.Location = New System.Drawing.Point(117, 15)
        Me.tb_Numero.Name = "tb_Numero"
        Me.tb_Numero.Size = New System.Drawing.Size(103, 20)
        Me.tb_Numero.TabIndex = 19
        '
        'tb_RazonSocial
        '
        Me.tb_RazonSocial.Location = New System.Drawing.Point(117, 38)
        Me.tb_RazonSocial.Name = "tb_RazonSocial"
        Me.tb_RazonSocial.Size = New System.Drawing.Size(427, 20)
        Me.tb_RazonSocial.TabIndex = 20
        '
        'tb_NombreFantasia
        '
        Me.tb_NombreFantasia.Location = New System.Drawing.Point(117, 62)
        Me.tb_NombreFantasia.Name = "tb_NombreFantasia"
        Me.tb_NombreFantasia.Size = New System.Drawing.Size(427, 20)
        Me.tb_NombreFantasia.TabIndex = 21
        '
        'tb_Domicilio
        '
        Me.tb_Domicilio.Location = New System.Drawing.Point(117, 84)
        Me.tb_Domicilio.Name = "tb_Domicilio"
        Me.tb_Domicilio.Size = New System.Drawing.Size(207, 20)
        Me.tb_Domicilio.TabIndex = 22
        '
        'tb_Cp
        '
        Me.tb_Cp.Location = New System.Drawing.Point(408, 84)
        Me.tb_Cp.Name = "tb_Cp"
        Me.tb_Cp.Size = New System.Drawing.Size(136, 20)
        Me.tb_Cp.TabIndex = 26
        '
        'tb_CUIT
        '
        Me.tb_CUIT.Location = New System.Drawing.Point(408, 107)
        Me.tb_CUIT.Name = "tb_CUIT"
        Me.tb_CUIT.Size = New System.Drawing.Size(136, 20)
        Me.tb_CUIT.TabIndex = 27
        '
        'DD_Estado
        '
        Me.DD_Estado.FormattingEnabled = True
        Me.DD_Estado.Items.AddRange(New Object() {"A", "S", "I"})
        Me.DD_Estado.Location = New System.Drawing.Point(117, 111)
        Me.DD_Estado.Name = "DD_Estado"
        Me.DD_Estado.Size = New System.Drawing.Size(164, 21)
        Me.DD_Estado.TabIndex = 30
        '
        'DgD
        '
        Me.DgD.AllowUserToAddRows = False
        Me.DgD.AllowUserToDeleteRows = False
        Me.DgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgD.Location = New System.Drawing.Point(141, 254)
        Me.DgD.Name = "DgD"
        Me.DgD.ReadOnly = True
        Me.DgD.Size = New System.Drawing.Size(79, 28)
        Me.DgD.TabIndex = 33
        Me.DgD.Visible = False
        '
        'Form_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 197)
        Me.Controls.Add(Me.DgD)
        Me.Controls.Add(Me.DD_Estado)
        Me.Controls.Add(Me.tb_CUIT)
        Me.Controls.Add(Me.tb_Cp)
        Me.Controls.Add(Me.tb_Domicilio)
        Me.Controls.Add(Me.tb_NombreFantasia)
        Me.Controls.Add(Me.tb_RazonSocial)
        Me.Controls.Add(Me.tb_Numero)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_Proveedores"
        Me.Text = "Proveedores"
        CType(Me.DgD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tb_Numero As System.Windows.Forms.TextBox
    Friend WithEvents tb_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents tb_NombreFantasia As System.Windows.Forms.TextBox
    Friend WithEvents tb_Domicilio As System.Windows.Forms.TextBox
    Friend WithEvents tb_Cp As System.Windows.Forms.TextBox
    Friend WithEvents tb_CUIT As System.Windows.Forms.TextBox
    Friend WithEvents DD_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents DgD As System.Windows.Forms.DataGridView
End Class
