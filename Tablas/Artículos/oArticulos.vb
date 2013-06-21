Public Class oArticulos

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select COD_ARTICULO From ARTICULOS").Tables(0)
        DD.DisplayMember = "COD_ARTICULO"
        DD.ValueMember = "COD_ARTICULO"
        DD.Text = ""
    End Sub

    Shared Sub CargarDD_Monedas(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select MONE From MONEDAS").Tables(0)
        DD.DisplayMember = "MONE"
        DD.ValueMember = "MONE"
        DD.Text = ""
    End Sub

    Shared Sub CargarDG_Articulos(ByVal DG As DataGridView, ByVal Cadena As String)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, Cadena).Tables(0)
    End Sub

    Shared Sub Eliminar_Articulo(ByVal Tnumero As ComboBox, ByVal DgD As DataGridView)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select COD_ARTICULO from ARTICULOS where COD_ARTICULO = " & Trim(Tnumero.Text))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(9)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From ARTICULOS Where COD_ARTICULO = '" & Trim(Tnumero.Text) & "'")
            End If
            Mensaje(10)
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Grabar_Articulo(ByVal DgD As DataGridView, ByVal DG As DataGridView)
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, strCadena_Articulos).Tables(0)
        If DgD.Rows.Count > 0 Then
            Mensaje(4)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Articulos)
        Else
            Mensaje(5)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strMod_Articulos)
        End If
        oArticulos.CargarDG_Articulos(DG, "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO from ARTICULOS")
        Mensaje(8)
    End Sub

    Shared Sub Borrar_Orden()

    End Sub

End Class
