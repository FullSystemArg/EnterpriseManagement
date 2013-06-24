Module Modulo

    'Variables Generales
    Public Msg As String
    Public Tbnumero As String
    Public Int_VentanaProveedores_Proveedores As Integer = 0
    Public Int_VentanaProveedores_ConsultaProveedores As Integer = 0
    Public Int_VentanaStock_Articulos As Integer = 0
    Public Int_VentanaOrdenes_Compra As Integer = 0
    Public Int_VentanaVentas_Ventas As Integer = 0
    Public Int_VentanaConversion_Cambiaria As Integer = 0
    Public Int_VentanaAbout As Integer = 0

    'Variables para Proveedores
    Public ImeC As Integer
    Public Im As Integer
    Public strCadena_Proveedor As String
    Public strAlta_Proveedor As String
    Public strMod_Proveedor As String
    Public strNumero As String
    Public strRazon As String
    Public strFantasia As String
    Public strCUIT As String
    Public strEstado As String
    Public strDomicilio As String
    Public strCP As String

    'Variables para Articulos
    Public CadenaArticulos As String
    Public ListadoActivo As Integer
    Public strCadena_Articulos As String
    Public strAlta_Articulos As String
    Public strMod_Articulos As String
    Public strAlta_Stock As String

    'Variables para Compras
    Public strCadena_Compras As String
    Public strAlta_Compras As String
    Public strMod_Compras As String

    'Variables para Ventas
    Public strCadena_Ventas As String
    Public strAlta_Ventas As String
    Public strMod_Ventas As String

    Public Sub Mensaje(ByVal Id As Integer)
        Select Case Id
            Case Is = 1
                Msg = MsgBox("El formulario que intenta mostrar ya está en pantalla", vbExclamation, "Enterprise Management")
            Case Is = 2
                Msg = MsgBox("Se va a borrar la cuenta especificada ¿Desea Continuar?", vbOKCancel, "Enterprise Management")
            Case Is = 3
                Msg = MsgBox("Debe ingresar un número de Proveedor para grabar o eliminar un registro", vbExclamation, "Enterprise Management")
            Case Is = 4
                Msg = MsgBox("Esta seguro que desea modificar el Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
            Case Is = 5
                Msg = MsgBox("Esta seguro que desea grabar el nuevo Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
            Case Is = 6
                Msg = MsgBox("Esta seguro que desea eliminar el Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
            Case Is = 7
                Msg = MsgBox("Se eliminó el registro" & Tbnumero & " de la tabla PROVEEDORES", vbInformation, "Enterprise Management")
            Case Is = 8
                Msg = MsgBox("Se grabo correctamente el registro" & Tbnumero & " en la tabla PROVEEDORES", vbInformation, "Enterprise Management")
            Case Is = 9
                Msg = MsgBox("Esta seguro que desea eliminar el Registro: " & Tbnumero & " de la tabla ARTICULOS", vbOKCancel, "Enterprise Management")
            Case Is = 10
                Msg = MsgBox("Se eliminó el registro" & Tbnumero & " de la tabla ARTICULOS", vbInformation, "Enterprise Management")
            Case Is = 11
                Msg = MsgBox("Esta seguro que desea crear una Orden de compra para: " & Tbnumero & " en la tabla COMPRAS", vbOKCancel, "Enterprise Management")
            Case Is = 12
                Msg = MsgBox("Se grabo correctamente la Orden de compra para" & Tbnumero & " en la tabla COMPRAS", vbInformation, "Enterprise Management")
            Case Is = 13
                Msg = MsgBox("La Orden de Compra que intenta grabar ya existe", vbInformation, "Enterprise Management")
            Case Is = 14
                Msg = MsgBox("Esta seguro que desea eliminar el Registro: " & Tbnumero & " de la tabla COMPRAS", vbOKCancel, "Enterprise Management")
            Case Is = 15
                Msg = MsgBox("Se eliminó el registro" & Tbnumero & " de la tabla COMPRAS", vbInformation, "Enterprise Management")
            Case Is = 16
                Msg = MsgBox("Esta seguro que desea eliminar el Registro: " & Tbnumero & " de la tabla Ventas", vbOKCancel, "Enterprise Management")
            Case Is = 17
                Msg = MsgBox("Se eliminó el registro" & Tbnumero & " de la tabla Ventas", vbInformation, "Enterprise Management")
        End Select
    End Sub

    Public Sub LimpiarDG(ByVal DG As DataGridView)
        DG.DataSource = Nothing
        DG.Refresh()
    End Sub

End Module
