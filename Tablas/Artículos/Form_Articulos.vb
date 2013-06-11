Public Class Form_Articulos

#Region "Load_Unload"

    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaStock_Articulos = 0
    End Sub

    Private Sub Form_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oArticulos.CargarDD_Codigo(cb_Codigo)
    End Sub

#End Region

#Region "KeyPress"

    Private Sub Form_Articulos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region

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


    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        CadenaArticulos = FiltroSQL()
        oArticulos.CargarDG_Articulos(DG_Articulos, CadenaArticulos)
    End Sub

    Private Sub cb_Codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Codigo.SelectedIndexChanged

    End Sub
End Class