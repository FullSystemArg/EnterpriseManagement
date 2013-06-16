Public Class oArticulos

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select COD_ARTICULO From ARTICULOS").Tables(0)
        DD.DisplayMember = "COD_ARTICULO"
        DD.ValueMember = "COD_ARTICULO"
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

End Class
