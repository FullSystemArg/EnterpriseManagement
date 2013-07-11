Public Class Form_Ventas

#Region "Load-Unload"
    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaVentas_Ventas = 0
    End Sub

    Private Sub Form_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oArticulos.CargarDD_Codigo(tb_Codigo)
        oArticulos.CargarDD_Articulo(cb_Articulo)
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
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Costo.TextChanged
        Calculo()
    End Sub

    Private Sub tb_Precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Precio.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
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

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        MonthCalendar1.Visible = True
    End Sub

    Private Sub tb_Fecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Fecha.GotFocus
        MonthCalendar1.Visible = True
    End Sub

    Private Sub tb_Fecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Fecha.LostFocus
        MonthCalendar1.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        tb_Fecha.Text = e.Start
    End Sub

    Private Sub MonthCalendar1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar1.LostFocus
        MonthCalendar1.Visible = False
    End Sub

    Private Sub DG_Ventas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Ventas.CellClick
        tb_Operacion.Text = DG_Ventas.CurrentRow.Cells(0).EditedFormattedValue.ToString
        tb_Fecha.Text = DG_Ventas.CurrentRow.Cells(1).EditedFormattedValue.ToString
        tb_Garantia.Text = DG_Ventas.CurrentRow.Cells(2).EditedFormattedValue.ToString
        tb_Facturacion.Text = DG_Ventas.CurrentRow.Cells(3).EditedFormattedValue.ToString
        cb_Origen.Text = DG_Ventas.CurrentRow.Cells(4).EditedFormattedValue.ToString
        cb_Forma.Text = DG_Ventas.CurrentRow.Cells(5).EditedFormattedValue.ToString
        cb_Envio.Text = DG_Ventas.CurrentRow.Cells(6).EditedFormattedValue.ToString
        tb_Codigo.Text = DG_Ventas.CurrentRow.Cells(7).EditedFormattedValue.ToString
        cb_Articulo.Text = DG_Ventas.CurrentRow.Cells(8).EditedFormattedValue.ToString
        tb_Cantidad.Text = DG_Ventas.CurrentRow.Cells(9).EditedFormattedValue.ToString
        tb_Costo.Text = DG_Ventas.CurrentRow.Cells(10).EditedFormattedValue.ToString
        tb_Precio.Text = DG_Ventas.CurrentRow.Cells(11).EditedFormattedValue.ToString
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

#Region "ABM"
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        oVentas.CargarDG_Ventas(DG_Ventas)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        oVentas.Eliminar_Venta(tb_Operacion, DgD, DG_Ventas)
        btn_Limpiar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar.Click
        If tb_Operacion.Text <> "" Then
            Tbnumero = tb_Operacion.Text
            If Trim(tb_Precio.Text) = "" Then tb_Precio.Text = "0"
            If Trim(tb_Costo.Text) = "" Then tb_Costo.Text = "0"
            strCadena_Ventas = ("Select Id from Ventas where Id = " & Val(tb_Operacion.Text))
            strAlta_Ventas = "INSERT INTO Ventas " _
                                        & "(Id, Fecha, Garantia, Facturacion, Origen, Forma, Envio, Cantidad, Codigo, Articulo, Precio, Costo, Ganancia) VALUES " _
                                        & "(" & Val(tb_Operacion.Text) & ",'" & Trim(tb_Fecha.Text) & "'," & Val(tb_Garantia.Text) _
                                        & "," & Val(tb_Facturacion.Text) & ",'" & Trim(cb_Origen.Text) & "','" & Trim(cb_Forma.Text) & "','" & Trim(cb_Envio.Text) _
                                        & "'," & Val(tb_Cantidad.Text) & ",'" & Trim(tb_Codigo.Text) & "','" & Trim(cb_Articulo.Text) & "'," & CDbl(tb_Precio.Text) _
                                        & "," & CDbl(tb_Costo.Text) & "," & CDbl(lbl_Ganancia.Text) & ");"
            strMod_Ventas = "UPDATE Ventas SET Id = " & Val(tb_Operacion.Text) & ", Fecha = '" & Trim(tb_Fecha.Text) _
                                          & "', Garantia = " & Val(tb_Garantia.Text) & ", Facturacion = " & Val(tb_Facturacion.Text) _
                                          & ", Origen = '" & Trim(cb_Origen.Text) & "', Forma = '" & Trim(cb_Forma.Text) _
                                          & "', Envio = '" & Trim(cb_Envio.Text) & "', Cantidad = " & Val(tb_Cantidad.Text) _
                                          & ", Codigo = '" & Trim(tb_Codigo.Text) & "', Articulo = '" & Trim(cb_Articulo.Text) _
                                          & "', Precio = " & CDbl(tb_Precio.Text) & ", Costo = " & CDbl(tb_Costo.Text) _
                                          & ", Ganancia = " & CDbl(lbl_Ganancia.Text) & " WHERE Id = " & Val(tb_Operacion.Text)
            oVentas.Grabar_Venta(DgD, DG_Ventas)
        Else
            Mensaje(3)
        End If
    End Sub
#End Region

End Class