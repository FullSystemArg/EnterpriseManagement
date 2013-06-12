<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(82, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Codigo de articulo"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(82, 115)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(136, 20)
        Me.TextBox7.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 26)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Precio de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   venta"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(110, 86)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(107, 20)
        Me.TextBox6.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cliente"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(82, 278)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 20)
        Me.TextBox9.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 26)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  entrega"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(82, 239)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(133, 20)
        Me.TextBox8.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Cotización"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(74, 208)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox3.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Moneda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Proveedor"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(74, 175)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox2.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 430)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de compra"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(176, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 21)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(54, 369)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Buscar.TabIndex = 40
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(6, 369)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 39
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 21)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(283, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(512, 425)
        Me.DataGridView1.TabIndex = 39
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 458)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
