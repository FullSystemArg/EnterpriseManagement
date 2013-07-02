Imports System.Data.SqlClient

Public Class oConsultaProveedores
#Region " Private Properties "

    Protected miNumProv As Integer = Nothing
    Protected miRazon As String = Nothing
    Protected miNomFantasia As String = Nothing
    Protected miDomicilio As String = Nothing
    Protected miCuit As String = Nothing
    Protected miEstado As String = Nothing

#End Region

#Region "Constructor"

    Sub New(ByVal NumProv As Integer)
        Using oTable As DataTable = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select NUM_PROV from PROVEEDORES where NUM_PROV = " & miNumProv).Tables(0)
            If oTable.Rows.Count = 1 Then
                miNumProv = oTable.Rows(0).Item("NUM_PROV")
                miRazon = oTable.Rows(0).Item("RAZON")
                miNomFantasia = oTable.Rows(0).Item("NOM_FANTASIA")
                miDomicilio = oTable.Rows(0).Item("DOMICILIO")
                miCuit = oTable.Rows(0).Item("CUIT")
                miEstado = oTable.Rows(0).Item("ESTADO")
            End If
        End Using
    End Sub

#End Region

#Region " Public Properties "

    Public Property NUM_PROV As Integer
        Get
            Return miNumProv
        End Get
        Set(ByVal value As Integer)
            miNumProv = value
        End Set
    End Property


    Public Property RAZON As String
        Get
            Return miRazon
        End Get
        Set(ByVal value As String)
            miRazon = value
        End Set
    End Property

    Public Property NOM_FANTASIA As String
        Get
            Return miNomFantasia
        End Get
        Set(ByVal value As String)
            miNomFantasia = value
        End Set
    End Property


    Public Property DOMICILIO As String
        Get
            Return miDomicilio
        End Get
        Set(ByVal value As String)
            miDomicilio = value
        End Set
    End Property


    Public Property CUIT As String
        Get
            Return miCuit
        End Get
        Set(ByVal value As String)
            miCuit = value
        End Set
    End Property

    Public Property ESTADO As String
        Get
            Return miEstado
        End Get
        Set(ByVal value As String)
            miEstado = value
        End Set
    End Property

#End Region

#Region "Consultas"

    Shared Sub CargarDD_Razon(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select RAZON From PROVEEDORES").Tables(0)
        DD.DisplayMember = "RAZON"
        DD.ValueMember = "RAZON"
        DD.Text = ""
    End Sub

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select NUM_PROV From PROVEEDORES").Tables(0)
        DD.DisplayMember = "NUM_PROV"
        DD.ValueMember = "NUM_PROV"
        DD.Text = ""
    End Sub

    Shared Sub CargarDG_ConsultaProveedores(ByVal DG As DataGridView, ByVal Cadena As String)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, Cadena).Tables(0)
        ImeC = 1
    End Sub

    Shared Sub MostrarProveedor(ByVal DG As DataGridView)
        If ImeC = 1 Then
            strNumero = DG.CurrentRow.Cells(0).EditedFormattedValue.ToString
            strRazon = DG.CurrentRow.Cells(1).EditedFormattedValue.ToString
            strFantasia = DG.CurrentRow.Cells(2).EditedFormattedValue.ToString
            strDomicilio = DG.CurrentRow.Cells(3).EditedFormattedValue.ToString
            strCP = DG.CurrentRow.Cells(4).EditedFormattedValue.ToString
            strCUIT = DG.CurrentRow.Cells(5).EditedFormattedValue.ToString
            strEstado = DG.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Im = 1
            Formulario.ProveedoresToolStripMenuItem3_Click(Nothing, Nothing)
        End If
    End Sub

#End Region

#Region "Proveedores"

    Shared Sub Eliminar_Proveedor(ByVal Tnumero As TextBox, ByVal DgD As DataGridView)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select NUM_PROV from PROVEEDORES where NUM_PROV = " & Trim(Tnumero.Text))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(6)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From PROVEEDORES Where NUM_PROV = '" & Trim(Tnumero.Text) & "'")
                Mensaje(7)
            End If
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Grabar_Proveedor(ByVal DgD As DataGridView)
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, strCadena_Proveedor).Tables(0)
        If DgD.Rows.Count = 0 Then
            Mensaje(4)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Proveedor)
            Mensaje(8)
        Else
            Mensaje(5)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strMod_Proveedor)
            Mensaje(8)
        End If
    End Sub

#End Region

End Class
