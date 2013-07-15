Imports System.Data.SqlClient

Public Class oArticulos

#Region " Private Properties "

    Protected miCodArticulo As String = Nothing
    'Protected miCodBarras As String = Nothing
    'Protected miDescripArticulo As String = Nothing
    'Protected miPrecioUni As Double = Nothing
    'Protected miStockMin As Integer = Nothing
    Protected miCantStock As Integer = Nothing
    'Protected miPuntoRep As Integer = Nothing
    'Protected miCosto As Double = Nothing
    'Protected miEmbalaje As Double = Nothing
    'Protected miFlete As Double = Nothing

#End Region

#Region "Constructor"

    Sub New(ByVal CodArticulo As String)
        If Not CodArticulo = "" Then
            Dim oTable As SqlDataReader = SqlHelper.ExecuteReader(SQLProvider.ConnectionString, CommandType.Text, "Select * from ARTICULOS where COD_ARTICULO = '" & Trim(CodArticulo) & "'")
            While oTable.Read
                miCodArticulo = oTable.Item("COD_ARTICULO")
                'miCodBarras = oTable.Item("COD_BARRAS")
                'miDescripArticulo = oTable.Item("DESCRIP_ARTI")
                'miPrecioUni = oTable.Item("PRECIO_UNI")
                'miStockMin = oTable.Item("STOCK_MIN")
                miCantStock = oTable.Item("CANT_STOCK")
                'miPuntoRep = oTable.Item("PUNTO_REPO")
                'miCosto = oTable.Item("COSTO")
                'miEmbalaje = oTable.Item("EMBALAJE")
                'miFlete = oTable.Item("FLETE")
            End While
            oTable.Close()
        End If
    End Sub

#End Region

#Region " Public Properties "

    Public ReadOnly Property COD_ARTICULO As Integer
        Get
            Return miCodArticulo
        End Get
    End Property


    'Public Property COD_BARRAS As String
    '    Get
    '        Return miCodBarras
    '    End Get
    '    Set(ByVal value As String)
    '        miCodBarras = value
    '    End Set
    'End Property

    'Public Property DESCRIP_ARTI As String
    '    Get
    '        Return miDescripArticulo
    '    End Get
    '    Set(ByVal value As String)
    '        miDescripArticulo = value
    '    End Set
    'End Property


    'Public Property PRECIO_UNI As String
    '    Get
    '        Return miPrecioUni
    '    End Get
    '    Set(ByVal value As String)
    '        miPrecioUni = value
    '    End Set
    'End Property


    'Public Property STOCK_MIN As String
    '    Get
    '        Return miStockMin
    '    End Get
    '    Set(ByVal value As String)
    '        miStockMin = value
    '    End Set
    'End Property

    Public Property CANT_STOCK As String
        Get
            Return miCantStock
        End Get
        Set(ByVal value As String)
            miCantStock = value
        End Set
    End Property

    'Public Property PUNTO_REPO As String
    '    Get
    '        Return miPuntoRep
    '    End Get
    '    Set(ByVal value As String)
    '        miPuntoRep = value
    '    End Set
    'End Property

    'Public Property COSTO As String
    '    Get
    '        Return miCosto
    '    End Get
    '    Set(ByVal value As String)
    '        miCosto = value
    '    End Set
    'End Property

    'Public Property EMBALAJE As String
    '    Get
    '        Return miEmbalaje
    '    End Get
    '    Set(ByVal value As String)
    '        miEmbalaje = value
    '    End Set
    'End Property

    'Public Property FLETE As String
    '    Get
    '        Return miFlete
    '    End Get
    '    Set(ByVal value As String)
    '        miFlete = value
    '    End Set
    'End Property

#End Region

#Region "Public Funtions"

    Shared Sub AltaStock(ByVal Articulo As String, ByVal Cantidad As Integer)
        Mensaje(11)
        If Msg = vbOK Then
            Dim Suma As Integer, Stock As Integer, strFinal As String
            SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Stock)
            Dim MiArticulos As New oArticulos(Articulo)
            Stock = MiArticulos.CANT_STOCK
            Suma = Cantidad + Stock
            strFinal = "UPDATE ARTICULOS SET CANT_STOCK = " & Val(Cantidad) & " WHERE COD_ARTICULO = '" & Trim(Articulo) & "'"
            SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strFinal)
            Mensaje(12)
        End If
    End Sub

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select COD_ARTICULO From ARTICULOS").Tables(0)
        DD.DisplayMember = "COD_ARTICULO"
        DD.ValueMember = "COD_ARTICULO"
        DD.Text = ""
    End Sub

    Shared Sub CargarDD_Articulo(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select DESCRIP_ARTI From ARTICULOS").Tables(0)
        DD.DisplayMember = "DESCRIP_ARTI"
        DD.ValueMember = "DESCRIP_ARTI"
        DD.Text = ""
    End Sub

    Shared Sub CargarDD_Monedas(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select MONE From MONEDAS").Tables(0)
        DD.DisplayMember = "MONE"
        DD.ValueMember = "MONE"
        DD.Text = ""
    End Sub

    Shared Sub CargarDG_Articulos(ByVal DG As DataGridView, ByVal Cadena As String)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, Cadena).Tables(0)
    End Sub

    Shared Sub Eliminar_Articulo(ByVal Tnumero As ComboBox, ByVal DgD As DataGridView, ByVal DG As DataGridView)
        If Tnumero.Text <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select COD_ARTICULO from ARTICULOS where COD_ARTICULO = '" & Trim(Tnumero.Text) & "'").Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(9)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From ARTICULOS Where COD_ARTICULO = '" & Trim(Tnumero.Text) & "'")
                Mensaje(10)
                CargarDG_Articulos(DG, "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS")
            End If
        Else
            Mensaje(3)
        End If
    End Sub

    Shared Sub Grabar_Articulo(ByVal DgD As DataGridView, ByVal DG As DataGridView)
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, strCadena_Articulos).Tables(0)
        If DgD.Rows.Count = 0 Then
            Mensaje(4)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strAlta_Articulos)
            oArticulos.CargarDG_Articulos(DG, "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS")
            Mensaje(8)
        Else
            Mensaje(5)
            If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strMod_Articulos)
            oArticulos.CargarDG_Articulos(DG, "Select COD_ARTICULO, COD_BARRAS, DESCRIP_ARTI, PRECIO_UNI, STOCK_MIN, CANT_STOCK, PUNTO_REPO, COSTO, EMBALAJE, FLETE from ARTICULOS")
            Mensaje(8)
        End If
    End Sub

    Shared Sub CargarDD_IdStock(ByVal DD As ComboBox)
        DD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "Select Id From Stock").Tables(0)
        DD.DisplayMember = "Id"
        DD.ValueMember = "Id"
        DD.Text = ""
    End Sub

#End Region

End Class
