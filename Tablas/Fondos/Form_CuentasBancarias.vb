Public Class Form_CuentasBancarias
    Dim strBanco, strNro, strCBU, strTipo, strMoneda, strInactivo, strTipoFondoFijo As String
    'Estas son las variables
    Sub LimpiarCampos()
        tb_CBU.Text = ""
        tb_Nro.Text = ""
        cb_Inactiva.Checked = False
        cb_TipoFondoFijo.Checked = False
        DD_Banco.Text = ""
        DD_Moneda.Text = ""
        DD_Tipo.Text = ""
    End Sub
    'jojojo
    Sub CargarDatos()
        oCuentasBancarias.CargarDG_CuentasBancarias(DG_CuentasBancarias)
        oCuentasBancarias.CargarDD_Banco(DD_Banco)
        oCuentasBancarias.CargarDD_Tipo(DD_Tipo)
        oCuentasBancarias.CargarDD_Moneda(DD_Moneda)
    End Sub
    'todos son putos
    Sub MostrarDatosDG()
        strBanco = DG_CuentasBancarias.CurrentRow.Cells(0).EditedFormattedValue.ToString
        strNro = DG_CuentasBancarias.CurrentRow.Cells(1).EditedFormattedValue.ToString
        strCBU = DG_CuentasBancarias.CurrentRow.Cells(2).EditedFormattedValue.ToString
        strTipo = DG_CuentasBancarias.CurrentRow.Cells(3).EditedFormattedValue.ToString
        strMoneda = DG_CuentasBancarias.CurrentRow.Cells(4).EditedFormattedValue.ToString
        strInactivo = DG_CuentasBancarias.CurrentRow.Cells(5).EditedFormattedValue.ToString
        strTipoFondoFijo = DG_CuentasBancarias.CurrentRow.Cells(6).EditedFormattedValue.ToString

        DD_Banco.Text = strBanco
        tb_Nro.Text = strNro
        tb_CBU.Text = strCBU
        DD_Tipo.Text = strTipo
        DD_Moneda.Text = strMoneda

        If strInactivo <> "N" Then
            cb_Inactiva.Checked = True
        Else
            cb_Inactiva.Checked = False
        End If
        'vos
        If strTipoFondoFijo <> "N" Then
            cb_TipoFondoFijo.Checked = True
        Else
            cb_TipoFondoFijo.Checked = False
        End If
    End Sub

    Private Sub Form_CuentasBancarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub DG_CuentasBancarias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_CuentasBancarias.Click
        If DG_CuentasBancarias.CurrentRow IsNot Nothing Then
            MostrarDatosDG()
            btn_Eliminar.Enabled = True
            btn_Modificar.Enabled = True
        Else
            btn_Modificar.Enabled = False
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Mensaje(2)
        If Msg = vbOK Then
            oCuentasBancarias.EliminarFilaDG_CuentasBancarias(DG_CuentasBancarias, strBanco, strNro)
            oCuentasBancarias.CargarDG_CuentasBancarias(DG_CuentasBancarias)
            LimpiarCampos()
        End If
    End Sub

    Private Sub btn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar.Click

    End Sub
End Class