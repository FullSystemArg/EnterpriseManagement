Public Class Form_Ventas

#Region "Load-Unload"
    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaVentas_Ventas = 0
    End Sub
#End Region

#Region "Ganancia"
    Sub Calculo()
        If cb_Origen.Text = cb_Origen.Items.Item(0) Then
            Select Case cb_Forma.Text
                Case Is = cb_Forma.Items.Item(2)
                    lbl_Ganancia.Text = Val(tb_Precio.Text) - Val(tb_Costo.Text) - (Val(tb_Precio.Text) * 10 / 100)
                Case Is = cb_Forma.Items.Item(1)
                    lbl_Ganancia.Text = Val(tb_Precio.Text) - Val(tb_Costo.Text) - (Val(tb_Precio.Text) * 12.5 / 100)
                Case Is = cb_Forma.Items.Item(0)
                    lbl_Ganancia.Text = Val(tb_Precio.Text) - Val(tb_Costo.Text) - (Val(tb_Precio.Text) * 12.5 / 100)
            End Select
        ElseIf cb_Origen.Text = cb_Origen.Items.Item(1) Then
            Select Case cb_Forma.Text
                Case Is = cb_Forma.Items.Item(2)
                    lbl_Ganancia.Text = Val(tb_Precio.Text) - Val(tb_Costo.Text)
                Case Is = cb_Forma.Items.Item(1)
                    lbl_Ganancia.Text = Val(tb_Precio.Text) - Val(tb_Costo.Text) - (Val(tb_Precio.Text) * 13 / 100)
            End Select
        End If
    End Sub

    Private Sub tb_Costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Costo.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Costo.TextChanged
        Calculo()
    End Sub

    Private Sub tb_Precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Precio.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Precio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Precio.TextChanged
        Calculo()
    End Sub

    Private Sub cb_Forma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Forma.SelectedIndexChanged
        Calculo()
    End Sub

    Private Sub cb_Origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Origen.SelectedIndexChanged
        Calculo()
    End Sub
#End Region

#Region "Funciones"
    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        tb_Cantidad.Text = ""
        tb_Codigo.Text = ""
        tb_Costo.Text = ""
        tb_Facturacion.Text = ""
        tb_Fecha.Text = ""
        tb_Garantia.Text = ""
        tb_Operacion.Text = ""
        tb_Precio.Text = ""
        cb_Articulo.Text = ""
        cb_Envio.Text = ""
        cb_Forma.Text = ""
        cb_Origen.Text = ""
    End Sub
#End Region

#Region "Keypress"
    Private Sub Form_Ventas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub tb_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Operacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Operacion.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub
#End Region

End Class