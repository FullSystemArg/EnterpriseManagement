Public Class Form_Articulos

#Region "Load_Unload"

    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaStock_Articulos = 0
        ListadoActivo = 0
    End Sub

    Private Sub Form_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oArticulos.CargarDD_Codigo(cb_Codigo)
        oConsultaProveedores.CargarDD_Razon(cb_Proveedor)
        oArticulos.CargarDD_Monedas(cb_Moneda)
        oArticulos.CargarDD_Articulo(cb_Articulo)
        oArticulos.CargarDD_Articulo(tb_Descripcion)
    End Sub

#End Region

#Region "KeyPress"

    Private Sub Form_Articulos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Destino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

#End Region

#Region "Funciones"
    Public Function FiltroSQL()
        Dim SQLstring As String = ""
        If Trim(cb_Codigo.Text) <> "" Then
            SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS where COD_ARTICULO Like '%" & Trim(cb_Codigo.Text) & "%'"
        End If

        If Trim(tb_Descripcion.Text) <> "" Then
            If Trim(SQLstring) <> "" Then
                SQLstring = SQLstring & " and DESCRIP_ARTI Like '%" & Trim(tb_Descripcion.Text) & "%'"
            Else
                SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS where DESCRIP_ARTI Like '%" & Trim(tb_Descripcion.Text) & "%'"
            End If
        End If

        If Trim(SQLstring) = "" Then
            SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS"
        End If

        Return SQLstring
    End Function

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        cb_Proveedor.Text = ""
        cb_Moneda.Text = ""
        cb_Articulo.Text = ""
        tb_Cantidad.Text = ""
        tb_Fecha.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        cb_Codigo.Text = ""
        tb_Barras.Text = ""
        tb_Descripcion.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox15.Text = ""
    End Sub

    Private Sub DG_Articulos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Articulos.CellDoubleClick
        If ListadoActivo = 1 Then
            cb_Codigo.Text = DG_Articulos.CurrentRow.Cells(0).EditedFormattedValue.ToString
            tb_Barras.Text = DG_Articulos.CurrentRow.Cells(1).EditedFormattedValue.ToString
            tb_Descripcion.Text = DG_Articulos.CurrentRow.Cells(2).EditedFormattedValue.ToString
            TextBox6.Text = DG_Articulos.CurrentRow.Cells(3).EditedFormattedValue.ToString
            TextBox2.Text = DG_Articulos.CurrentRow.Cells(4).EditedFormattedValue.ToString
            TextBox15.Text = DG_Articulos.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TextBox1.Text = DG_Articulos.CurrentRow.Cells(6).EditedFormattedValue.ToString
        End If
    End Sub

#End Region

#Region "ABM"
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        CadenaArticulos = FiltroSQL()
        oArticulos.CargarDG_Articulos(DG_Articulos, CadenaArticulos)
        ListadoActivo = 1
    End Sub

    Private Sub btn_Eliminar_Articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar_Articulo.Click
        oArticulos.Eliminar_Articulo(cb_Codigo, DgD, DG_Articulos)
        btn_Limpiar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Grabar_Articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar_Articulo.Click
        If cb_Codigo.Text <> "" Then
            Tbnumero = cb_Codigo.Text
            strCadena_Articulos = ("Select COD_ARTICULO from ARTICULOS where COD_ARTICULO = '" & Trim(cb_Codigo.Text) & "'")
            strAlta_Articulos = "INSERT INTO ARTICULOS " _
                                        & "(COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE) VALUES " _
                                        & "('" & Trim(cb_Codigo.Text) & "','" & Trim(tb_Barras.Text) & "','" & Trim(tb_Descripcion.Text) & "'," _
                                        & CDbl(TextBox6.Text) & "," & Val(TextBox2.Text) & "," & Val(TextBox15.Text) & "," _
                                        & Val(TextBox1.Text) & "," & CDbl(TextBox5.Text) & "," & CDbl(TextBox4.Text) & "," & CDbl(TextBox3.Text) & ");"
            strMod_Articulos = "UPDATE ARTICULOS SET COD_ARTICULO = '" & Trim(cb_Codigo.Text) & "', COD_BARRAS = '" & Trim(tb_Barras.Text) _
                                      & "', DESCRIP_ARTI = '" & Trim(tb_Descripcion.Text) & "', PRECIO_UNI = " & CDbl(TextBox6.Text) _
                                      & ", STOCK_MIN = " & Val(TextBox2.Text) & ", CANT_STOCK = " & Val(TextBox15.Text) _
                                      & ", PUNTO_REPO = " & Val(TextBox1.Text) _
                                      & ", COSTO = " & CDbl(TextBox5.Text) & ", EMBALAJE = " & CDbl(TextBox4.Text) & ", FLETE = " & CDbl(TextBox3.Text) _
                                      & " WHERE COD_ARTICULO = '" & Trim(cb_Codigo.Text) & "'"
            oArticulos.Grabar_Articulo(DgD, DG_Articulos)
        Else
            Mensaje(3)
        End If
    End Sub

#End Region

    Private Sub btn_Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alta.Click
        If cb_Id.Text <> "" Then
            Tbnumero = cb_Articulo.Text
            strAlta_Stock = "INSERT INTO PROVEEDORES " _
                                & "(Proveedor, Fecha, Moneda, Articulo, Cantidad, Id) VALUES " _
                                & "('" & Trim(cb_Proveedor.Text) & "','" & CDate(tb_Fecha.Text) & "','" & Trim(cb_Moneda.Text) & "','" _
                                & Trim(cb_Articulo.Text) & "'," & Val(tb_Cantidad.Text) & "," & Val(cb_Id.Text) & ");"
            oArticulos.AltaStock(DgD, cb_Articulo)
        Else
            Mensaje(3)
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "," And e.KeyChar <> "." Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class