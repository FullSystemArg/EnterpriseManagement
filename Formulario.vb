Public Class Formulario
    Public Sub ProveedoresToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem3.Click
        Dim Frm_Proveedores As New Form_Proveedores
        If Int_VentanaProveedores_Proveedores = 0 Then
            If Im = 0 Then
                Frm_Proveedores.MdiParent = Me
                Frm_Proveedores.Show()
                Int_VentanaProveedores_Proveedores = 1
            Else
                Frm_Proveedores.ShowDialog()
            End If
        Else
            If Im = 0 Then
                Mensaje(1)
            End If
        End If
    End Sub

    Public Sub ConsultaProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaProveedoresToolStripMenuItem1.Click
        If Int_VentanaProveedores_ConsultaProveedores = 0 Then
            Dim Frm_ConsultaProveedores As New Form_ConsultaProveedores
            Frm_ConsultaProveedores.MdiParent = Me
            Frm_ConsultaProveedores.Show()
            Int_VentanaProveedores_ConsultaProveedores = 1
        Else
            Mensaje(1)
        End If
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        If Int_VentanaStock_Articulos = 0 Then
            Dim Frm_Articulos As New Form_Articulos
            Frm_Articulos.MdiParent = Me
            Frm_Articulos.Show()
            Int_VentanaStock_Articulos = 1
        Else
            Mensaje(1)
        End If
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        Dim Frm_Ventas As New Form_Ventas
        If Int_VentanaVentas_Ventas = 0 Then
                Frm_Ventas.MdiParent = Me
                Frm_Ventas.Show()
                Int_VentanaVentas_Ventas = 1
        Else
                Mensaje(1)
        End If
    End Sub

    Private Sub OrdenesDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesDeCompraToolStripMenuItem.Click
        Dim frm_OC As New Form_Oc
        If Int_VentanaOrdenes_Compra = 0 Then
            frm_OC.MdiParent = Me
            frm_OC.Show()
            Int_VentanaOrdenes_Compra = 1
        Else
            Mensaje(1)
        End If
    End Sub

    Private Sub ODBCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODBCToolStripMenuItem.Click
        Dim frm_Monedas As New Form_Conversion
        If Int_VentanaConversion_Cambiaria = 0 Then
            frm_Monedas.MdiParent = Me
            frm_Monedas.Show()
            Int_VentanaConversion_Cambiaria = 1
        Else
            Mensaje(1)
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim frm_About As New About
        If Int_VentanaAbout = 0 Then
            frm_About.MdiParent = Me
            frm_About.Show()
            Int_VentanaAbout = 1
        Else
            Mensaje(1)
        End If
    End Sub
End Class
