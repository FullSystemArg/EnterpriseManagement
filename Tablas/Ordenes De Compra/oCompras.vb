Public Class oCompras

    Shared Sub CargarDD_Proveedor(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select RAZON From PROVEEDORES").Tables(0)
        DD.DisplayMember = "RAZON"
        DD.ValueMember = "RAZON"
        DD.Text = ""
    End Sub

    Shared Sub CargarDG_Ordenes(ByVal DG As DataGridView)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select * From Compras").Tables(0)
    End Sub

    Shared Sub Grabar_Orden(ByVal DG As DataGridView, ByVal DgD As DataGridView, ByVal Tnumero As ComboBox)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select Codigo from COMPRAS where Codigo = " & Trim(Tnumero.Text))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(11)
                If Msg = vbOK Then
                    SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Compras)
                    Mensaje(12)
                    oCompras.CargarDG_Ordenes(DG)
                End If
            Else
                Mensaje(13)
            End If
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Eliminar_Orden(ByVal Tnumero As ComboBox, ByVal DgD As DataGridView)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select Codigo from COMPRAS where Codigo = " & Trim(Tnumero.Text))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(14)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From COMPRAS Where Codigo = '" & Trim(Tnumero.Text) & "'")
            End If
            Mensaje(15)
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Cargar_Cotizacion(ByVal DgD As DataGridView, ByVal tb_Cotizacion As TextBox, ByVal cb_Moneda As ComboBox)
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select MONE_COTI from MONEDAS where MONE = '" & Trim(cb_Moneda.Text) & "'").Tables(0)
        If DgD.Rows.Count > 0 Then
            tb_Cotizacion.Text = DgD.Item(0, 0).Value.ToString
        End If
    End Sub

End Class
