Public Class Form_Conversion

    Public Sub Form_Proveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaConversion_Cambiaria = 0
    End Sub

    Private Sub Form_Conversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarDG(DG_Monedas)
        DG_Monedas.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select * from MONEDAS").Tables(0)
    End Sub

End Class