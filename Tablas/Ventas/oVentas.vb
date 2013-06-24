Public Class oVentas
    Shared Sub CargarDG_Ventas(ByVal DG As DataGridView)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select * From Ventas").Tables(0)
    End Sub

    Shared Sub Eliminar_Venta(ByVal Tnumero As TextBox, ByVal DgD As DataGridView, ByVal DG As DataGridView)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select Id from Ventas where Id = " & Val(Tnumero.Text))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(16)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From Ventas Where Id = " & Val(Tnumero.Text))
                CargarDG_Ventas(DG)
            End If
            Mensaje(17)
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Grabar_Venta(ByVal DgD As DataGridView, ByVal DG As DataGridView)
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, strCadena_Ventas).Tables(0)
        If DgD.Rows.Count = 0 Then
            Mensaje(4)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Ventas)
            Mensaje(8)
            CargarDG_Ventas(DG)
        Else
            Mensaje(5)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strMod_Ventas)
            Mensaje(8)
            CargarDG_Ventas(DG)
        End If
    End Sub
End Class
