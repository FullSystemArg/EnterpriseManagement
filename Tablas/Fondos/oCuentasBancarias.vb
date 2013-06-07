Imports System.Data.SqlClient

Public Class oCuentasBancarias
    'Cuentas bancarias
    Shared Sub CargarDG_CuentasBancarias(ByVal DG As DataGridView)
        Dim strSQL As New SqlDataAdapter("Select CODI_BANCO, CUENTA_NUM, CBU, CUENTA_TIPO, MONE, INACTIVA, TIPO_FF From BANCOS_CUENTAS", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        LimpiarDG(DG)
        DG.DataSource = ds.Tables(0)
        DG.Columns(0).HeaderText = "Banco"
        DG.Columns(1).HeaderText = "Cuenta"
        DG.Columns(2).HeaderText = "CBU"
        DG.Columns(3).HeaderText = "Tipo"
        DG.Columns(4).HeaderText = "Moneda"
        DG.Columns(5).HeaderText = "Inactiva"
        DG.Columns(6).HeaderText = "Tipo FF"

        'If ds.Tables(0).TableName Then

    End Sub

    Shared Sub CargarDD_Banco(ByVal DD As ComboBox)
        Dim strSQL As New SqlDataAdapter("Select CODI_BANCO, DESCRIP_BANCO From BANCOS", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        DD.DataSource = ds.Tables(0)
        DD.DisplayMember = "DESCRIP_BANCO"
        DD.ValueMember = "CODI_BANCO"
        DD.Text = ""
    End Sub

    Shared Sub CargarDD_Tipo(ByVal DD As ComboBox)
        DD.Items.Add("CA")
        DD.Items.Add("CC")
    End Sub

    Shared Sub CargarDD_Moneda(ByVal DD As ComboBox)
        Dim strSQL As New SqlDataAdapter("Select MONE, CODI_AFIP From MONEDAS", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        DD.DataSource = ds.Tables(0)
        DD.DisplayMember = "MONE"
        DD.ValueMember = "CODI_AFIP"
        DD.Text = ""
    End Sub

    Shared Sub EliminarFilaDG_CuentasBancarias(ByVal DG As DataGridView, ByVal Banco As String, ByVal NroCuenta As String)
        SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, "factu_bancos_cuentas_baja", Banco, NroCuenta)
    End Sub

End Class
