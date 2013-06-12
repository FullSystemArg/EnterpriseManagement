Imports System.Data.SqlClient

Public Class Form_ConsultaProveedores

#Region "Load_Unload"

    Private Sub Form_ConceptosFacturables_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaProveedores_ConsultaProveedores = 0
        ImeC = 0
    End Sub

    Private Sub Form_ConsultaProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oConsultaProveedores.CargarDD_Codigo(DD_Codigo)
    End Sub

#End Region

#Region "Funciones"

    Public Function FiltroSQL()
        Dim SQLstring As String = ""
        If Trim(DD_Codigo.Text) <> "" Then
            SQLstring = "Select NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CP, CUIT, ESTADO From PROVEEDORES where NUM_PROV = " & Val(DD_Codigo.Text)
        End If

        If Trim(tb_NombreFantasia.Text) <> "" Then
            If Trim(SQLstring) <> "" Then
                SQLstring = SQLstring & " and NOM_FANTASIA Like '%" & Trim(tb_NombreFantasia.Text) & "%'"
            Else
                SQLstring = "Select NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CP, CUIT, ESTADO From PROVEEDORES where NOM_FANTASIA Like '%" & Trim(tb_NombreFantasia.Text) & "%'"
            End If
        End If

        If Trim(tb_RazonSocial.Text) <> "" Then
            If Trim(SQLstring) <> "" Then
                SQLstring = SQLstring & " and RAZON like '%" & Trim(tb_RazonSocial.Text) & "%'"
            Else
                SQLstring = "Select NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CP, CUIT, ESTADO From PROVEEDORES where RAZON Like '%" & Trim(tb_RazonSocial.Text) & "%'"
            End If
        End If

        If Trim(SQLstring) = "" Then
            SQLstring = "Select NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CP, CUIT, ESTADO From PROVEEDORES"
        End If

        Return SQLstring
    End Function

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        tb_NombreFantasia.Text = ""
        tb_RazonSocial.Text = ""
        DD_Codigo.Text = ""
        LimpiarDG(DG_ConsultaProveedores)
        ImeC = 0
    End Sub

#End Region

#Region "ABM"

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim Cadena As String = FiltroSQL()
        oConsultaProveedores.CargarDG_ConsultaProveedores(DG_ConsultaProveedores, Cadena)
    End Sub

    Private Sub DG_ConsultaProveedores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ConsultaProveedores.DoubleClick
        oConsultaProveedores.MostrarProveedor(DG_ConsultaProveedores)
    End Sub

#End Region


End Class