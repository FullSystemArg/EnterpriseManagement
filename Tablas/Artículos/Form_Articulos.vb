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
        ListadoActivo = 1
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox14.Text = ""
        TextBox13.Text = ""
        ComboBox1.Text = ""
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

    Private Sub btn_Eliminar_Articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar_Articulo.Click
        oArticulos.Eliminar_Articulo(cb_Codigo, DG_Articulos)
        btn_Limpiar_Click(Nothing, Nothing)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListadoActivo = 2
    End Sub

    Private Sub btn_Grabar_Articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar_Articulo.Click
        If cb_Codigo.Text <> "" Then
            strCadena_Proveedor = ("Select NUM_PROV from PROVEEDORES where COD_ARTICULO = " & Val(cb_Codigo.Text))
            strAlta_Proveedor = "INSERT INTO ARTICULOS " _
                                        & "(NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CUIT, ESTADO) VALUES " _
                                        & "(" & Val(cb_Codigo.Text) & ",'" & Trim(tb_RazonSocial.Text) & "','" & Trim(tb_NombreFantasia.Text) & "','" _
                                        & Trim(tb_Domicilio.Text) & "','" & Trim(tb_CUIT.Text) & "','" & Trim(DD_Estado.Text) & "');"
            strMod_Proveedor = "UPDATE ARTICULOS SET COD_ARTICULO = " & Val(cb_Codigo.Text) & ", RAZON = '" & Trim(tb_RazonSocial.Text) _
                                      & "', NOM_FANTASIA = '" & Trim(tb_NombreFantasia.Text) & "', DOMICILIO = '" & Trim(tb_Domicilio.Text) _
                                      & "', CUIT = '" & Trim(tb_CUIT.Text) & "', ESTADO = '" & Trim(DD_Estado.Text) & "' WHERE COD_ARTICULO = " _
                                      & Val(cb_Codigo.Text)
            oConsultaProveedores.Grabar_Proveedor(DG_Articulos)
        Else
            Mensaje(3)
        End If
    End Sub
End Class