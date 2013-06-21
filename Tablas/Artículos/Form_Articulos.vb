Public Class Form_Articulos

#Region "Load_Unload"

    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaStock_Articulos = 0
        ListadoActivo = 0
    End Sub

    Private Sub Form_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oArticulos.CargarDD_Codigo(cb_Codigo)
        oConsultaProveedores.CargarDD_Codigo(cb_Proveedor)
        oArticulos.CargarDD_Monedas(tb_Moneda)
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
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

    Private Sub tb_Destino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Destino.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

#End Region

#Region "Funciones"
    Public Function FiltroSQL()
        Dim SQLstring As String = ""
        If Trim(cb_Codigo.Text) <> "" Then
            SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO from ARTICULOS where COD_ARTICULO Like '%" & Trim(cb_Codigo.Text) & "%'"
        End If

        If Trim(tb_Descripcion.Text) <> "" Then
            If Trim(SQLstring) <> "" Then
                SQLstring = SQLstring & " and DESCRIP_ARTI Like '%" & Trim(tb_Descripcion.Text) & "%'"
            Else
                SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO from ARTICULOS where DESCRIP_ARTI Like '%" & Trim(tb_Descripcion.Text) & "%'"
            End If
        End If

        If Trim(SQLstring) = "" Then
            SQLstring = "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO from ARTICULOS"
        End If

        Return SQLstring
    End Function

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        cb_Proveedor.Text = ""
        tb_Moneda.Text = ""
        tb_Origen.Text = ""
        tb_Destino.Text = ""
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
        oArticulos.Eliminar_Articulo(cb_Codigo, DG_Articulos)
        btn_Limpiar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Grabar_Articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar_Articulo.Click
        If cb_Codigo.Text <> "" Then
            Tbnumero = cb_Codigo.Text
            strCadena_Articulos = ("Select COD_ARTICULO from ARTICULOS where COD_ARTICULO = '" & Trim(cb_Codigo.Text) & "'")
            strAlta_Articulos = "INSERT INTO ARTICULOS " _
                                        & "(COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO) VALUES " _
                                        & "('" & Trim(cb_Codigo.Text) & "','" & Trim(tb_Barras.Text) & "','" & Trim(tb_Descripcion.Text) & "'," _
                                        & Val(TextBox6.Text) & "," & Val(TextBox2.Text) & "," & Val(TextBox15.Text) & ",'" _
                                        & Trim(TextBox1.Text) & "');"
            strMod_Articulos = "UPDATE ARTICULOS SET COD_ARTICULO = '" & Trim(cb_Codigo.Text) & "', COD_BARRAS = '" & Trim(tb_Barras.Text) _
                                      & "', DESCRIP_ARTI = '" & Trim(tb_Descripcion.Text) & "', PRECIO_UNI = " & Val(TextBox6.Text) _
                                      & ", STOCK_MIN = " & Val(TextBox2.Text) & ", CANT_STOCK = " & Val(TextBox15.Text) _
                                      & ", PUNTO_REPO = '" & Trim(TextBox1.Text) & "' WHERE COD_ARTICULO = " & Val(cb_Codigo.Text)
            oArticulos.Grabar_Articulo(DgD, DG_Articulos)
        Else
            Mensaje(3)
        End If
    End Sub

#End Region

End Class