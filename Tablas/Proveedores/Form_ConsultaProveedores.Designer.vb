<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ConsultaProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ConsultaProveedores))
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.DG_ConsultaProveedores = New System.Windows.Forms.DataGridView()
        Me.tb_NombreFantasia = New System.Windows.Forms.TextBox()
        Me.tb_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DD_Codigo = New System.Windows.Forms.ComboBox()
        CType(Me.DG_ConsultaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(661, 410)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 20
        Me.btn_Buscar.Tag = "|"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(620, 410)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 19
        Me.btn_Limpiar.Tag = "|"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'DG_ConsultaProveedores
        '
        Me.DG_ConsultaProveedores.AllowUserToAddRows = False
        Me.DG_ConsultaProveedores.AllowUserToDeleteRows = False
        Me.DG_ConsultaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ConsultaProveedores.Location = New System.Drawing.Point(12, 83)
        Me.DG_ConsultaProveedores.Name = "DG_ConsultaProveedores"
        Me.DG_ConsultaProveedores.ReadOnly = True
        Me.DG_ConsultaProveedores.Size = New System.Drawing.Size(686, 321)
        Me.DG_ConsultaProveedores.TabIndex = 21
        '
        'tb_NombreFantasia
        '
        Me.tb_NombreFantasia.Location = New System.Drawing.Point(105, 49)
        Me.tb_NombreFantasia.Name = "tb_NombreFantasia"
        Me.tb_NombreFantasia.Size = New System.Drawing.Size(174, 20)
        Me.tb_NombreFantasia.TabIndex = 36
        '
        'tb_RazonSocial
        '
        Me.tb_RazonSocial.Location = New System.Drawing.Point(476, 49)
        Me.tb_RazonSocial.Name = "tb_RazonSocial"
        Me.tb_RazonSocial.Size = New System.Drawing.Size(221, 20)
        Me.tb_RazonSocial.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nombre Fantasia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Razón Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Código"
        '
        'DD_Codigo
        '
        Me.DD_Codigo.FormattingEnabled = True
        Me.DD_Codigo.Location = New System.Drawing.Point(297, 12)
        Me.DD_Codigo.Name = "DD_Codigo"
        Me.DD_Codigo.Size = New System.Drawing.Size(173, 21)
        Me.DD_Codigo.TabIndex = 39
        '
        'Form_ConsultaProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 459)
        Me.Controls.Add(Me.DD_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_NombreFantasia)
        Me.Controls.Add(Me.tb_RazonSocial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DG_ConsultaProveedores)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ConsultaProveedores"
        Me.Text = "Consulta Proveedores"
        CType(Me.DG_ConsultaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents DG_ConsultaProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents tb_NombreFantasia As System.Windows.Forms.TextBox
    Friend WithEvents tb_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DD_Codigo As System.Windows.Forms.ComboBox
End Class
