<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisorDeActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemasDeAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablasToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.VentasToolStripMenuItem, Me.StockToolStripMenuItem, Me.AdministracionToolStripMenuItem})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TablasToolStripMenuItem.Text = "Tablas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem3, Me.ConsultaProveedoresToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem3
        '
        Me.ProveedoresToolStripMenuItem3.Name = "ProveedoresToolStripMenuItem3"
        Me.ProveedoresToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem3.Text = "Proveedores"
        '
        'ConsultaProveedoresToolStripMenuItem1
        '
        Me.ConsultaProveedoresToolStripMenuItem1.Name = "ConsultaProveedoresToolStripMenuItem1"
        Me.ConsultaProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaProveedoresToolStripMenuItem1.Text = "Consulta Proveedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.AltaDeStockToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'AltaDeStockToolStripMenuItem
        '
        Me.AltaDeStockToolStripMenuItem.Name = "AltaDeStockToolStripMenuItem"
        Me.AltaDeStockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDeStockToolStripMenuItem.Text = "Consulta Stock"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpresionesToolStripMenuItem, Me.BackupToolStripMenuItem, Me.ODBCToolStripMenuItem, Me.ConfiguraciónDeUsuariosToolStripMenuItem, Me.VisorDeActividadesToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ImpresionesToolStripMenuItem
        '
        Me.ImpresionesToolStripMenuItem.Name = "ImpresionesToolStripMenuItem"
        Me.ImpresionesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ImpresionesToolStripMenuItem.Text = "Impresiones"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'ODBCToolStripMenuItem
        '
        Me.ODBCToolStripMenuItem.Name = "ODBCToolStripMenuItem"
        Me.ODBCToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ODBCToolStripMenuItem.Text = "ODBC"
        '
        'ConfiguraciónDeUsuariosToolStripMenuItem
        '
        Me.ConfiguraciónDeUsuariosToolStripMenuItem.Name = "ConfiguraciónDeUsuariosToolStripMenuItem"
        Me.ConfiguraciónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConfiguraciónDeUsuariosToolStripMenuItem.Text = "Configuración de Usuarios"
        '
        'VisorDeActividadesToolStripMenuItem
        '
        Me.VisorDeActividadesToolStripMenuItem.Name = "VisorDeActividadesToolStripMenuItem"
        Me.VisorDeActividadesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VisorDeActividadesToolStripMenuItem.Text = "Visor De Actividades"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.TemasDeAyudaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'TemasDeAyudaToolStripMenuItem
        '
        Me.TemasDeAyudaToolStripMenuItem.Name = "TemasDeAyudaToolStripMenuItem"
        Me.TemasDeAyudaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TemasDeAyudaToolStripMenuItem.Text = "Temas De Ayuda"
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 732)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formulario"
        Me.Text = "Enterprise Management 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TablasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpresionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODBCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisorDeActividadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemasDeAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
