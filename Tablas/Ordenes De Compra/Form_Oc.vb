Public Class Form_Oc

#Region "Load-Unload"
    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaOrdenes_Compra = 0
        Im = 0
    End Sub

    Private Sub Form_Oc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oArticulos.CargarDD_Codigo(cb_Articulo)
        oArticulos.CargarDD_Monedas(cb_Moneda)
        oCompras.CargarDD_Proveedor(cb_Proveedor)
        Im = 1
    End Sub
#End Region

#Region "Funciones"
    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        cb_Articulo.Text = ""
        cb_Proveedor.Text = ""
        cb_Moneda.Text = ""
        tb_Cantidad.Text = ""
        tb_Cliente.Text = ""
        tb_Cotizacion.Text = ""
        tb_Entrega.Text = ""
        tb_Fecha.Text = ""
        tb_Precio.Text = ""
    End Sub
#End Region

#Region "ABM"
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        oCompras.CargarDG_Ordenes(DG_Ordenes)
    End Sub

    Private Sub btn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar.Click
        If cb_Articulo.Text <> "" Then
            Tbnumero = cb_Articulo.Text
            strAlta_Compras = "INSERT INTO PROVEEDORES " _
                                        & "(Codigo, Cantidad, Fecha, Proveedor, Precio, Entrega, Cliente, Moneda, Cotizacion) VALUES " _
                                        & "('" & Trim(cb_Articulo.Text) & "'," & Val(tb_Cantidad.Text) & ",'" & CDate(tb_Fecha.Text) & "','" _
                                        & Trim(cb_Proveedor.Text) & "'," & Val(tb_Precio.Text) & ",'" & CDate(tb_Entrega.Text) & ",'" _
                                        & Trim(tb_Cliente.Text) & ",'" & Trim(cb_Moneda.Text) & "," & Val(tb_Cotizacion.Text) & ");"
            oCompras.Grabar_Orden(DG_Ordenes, DgD, cb_Articulo)
        Else
            Mensaje(3)
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        oCompras.Eliminar_Orden(cb_Articulo, DgD)
    End Sub

    Private Sub cb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Moneda.SelectedIndexChanged
        If Im = 1 Then
            oCompras.Cargar_Cotizacion(DgD, tb_Cotizacion, cb_Moneda)
        End If
    End Sub
#End Region

#Region "Keypress"
    Private Sub Form_Oc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub tb_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Precio.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub
#End Region

End Class