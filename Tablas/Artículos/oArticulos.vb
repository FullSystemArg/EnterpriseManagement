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

End Class
