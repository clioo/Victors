Imports System.Text.RegularExpressions
Module NumerosALetras_modulo
    'Para validar solo núneros, en el evento Keypress pegar esto: e.Handled = txtNumericoentero(txt_importe, e.KeyChar, true)
    'El evento sería este:  Private Sub txt_importe_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_importe.KeyPress
    'Sustituye "txt_importe" por el nombre del TXT en ambas
    Public Function txtNumericoreal(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function
    Public Function txtNumericoentero(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = False Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function
    Function NumeroALetra(ByVal Numero As Double) As String
        Select Case Numero
            Case 0 : NumeroALetra = "CERO"
            Case 1 : NumeroALetra = "UNO"
            Case 2 : NumeroALetra = "DOS"
            Case 3 : NumeroALetra = "TRES"
            Case 4 : NumeroALetra = "CUATRO"
            Case 5 : NumeroALetra = "CINCO"
            Case 6 : NumeroALetra = "SEIS"
            Case 7 : NumeroALetra = "SIETE"
            Case 8 : NumeroALetra = "OCHO"
            Case 9 : NumeroALetra = "NUEVE"
            Case 10 : NumeroALetra = "DIEZ"
            Case 11 : NumeroALetra = "ONCE"
            Case 12 : NumeroALetra = "DOCE"
            Case 13 : NumeroALetra = "TRECE"
            Case 14 : NumeroALetra = "CATORCE"
            Case 15 : NumeroALetra = "QUINCE"
            Case Is < 20 : NumeroALetra = "DIECI" & NumeroALetra(Numero - 10)
            Case 20 : NumeroALetra = "VEINTE"
            Case Is < 30 : NumeroALetra = "VEINTI" & NumeroALetra(Numero - 20)
            Case 30 : NumeroALetra = "TREINTA"
            Case Is < 40 : NumeroALetra = "TREINTA Y " & NumeroALetra(Numero - 30)
            Case 40 : NumeroALetra = "CUARENTA"
            Case Is < 50 : NumeroALetra = "CUARENTA Y " & NumeroALetra(Numero - 40)
            Case 50 : NumeroALetra = "CINCUENTA"
            Case Is < 60 : NumeroALetra = "CINCUENTA Y " & NumeroALetra(Numero - 50)
            Case 60 : NumeroALetra = "SESENTA"
            Case Is < 70 : NumeroALetra = "SESENTA Y " & NumeroALetra(Numero - 60)
            Case 70 : NumeroALetra = "SETENTA"
            Case Is < 80 : NumeroALetra = "SETENTA Y " & NumeroALetra(Numero - 70)
            Case 80 : NumeroALetra = "OCHENTA"
            Case Is < 90 : NumeroALetra = "OCHENTA Y " & NumeroALetra(Numero - 80)
            Case 90 : NumeroALetra = "NOVENTA"
            Case Is < 100 : NumeroALetra = "NOVENTA Y " & NumeroALetra(Numero - 90)
            Case 100 : NumeroALetra = "CIEN"
            Case Is < 200 : NumeroALetra = "CIENTO " & NumeroALetra(Numero - 100)
            Case 200 : NumeroALetra = "DOSCIENTOS"
            Case Is < 300 : NumeroALetra = "DOSCIENTOS " & NumeroALetra(Numero - 200)
            Case 300 : NumeroALetra = "TRESCIENTOS"
            Case Is < 400 : NumeroALetra = "TRESCIENTOS " & NumeroALetra(Numero - 300)
            Case 400 : NumeroALetra = "CUATROCIENTOS"
            Case Is < 500 : NumeroALetra = "CUATROCIENTOS " & NumeroALetra(Numero - 400)
            Case 500 : NumeroALetra = "QUINIENTOS"
            Case Is < 600 : NumeroALetra = "QUINIENTOS " & NumeroALetra(Numero - 500)
            Case 600 : NumeroALetra = "SEISCIENTOS"
            Case Is < 700 : NumeroALetra = "SEISCIENTOS " & NumeroALetra(Numero - 600)
            Case 700 : NumeroALetra = "SETECIENTOS"
            Case Is < 800 : NumeroALetra = "SETECIENTOS " & NumeroALetra(Numero - 700)
            Case 800 : NumeroALetra = "OCHOCIENTOS"
            Case Is < 900 : NumeroALetra = "OCHOCIENTOS " & NumeroALetra(Numero - 800)
            Case 900 : NumeroALetra = "NOVECIENTOS"
            Case Is < 1000 : NumeroALetra = "NOVECIENTOS " & NumeroALetra(Numero - 900)
            Case 1000 : NumeroALetra = "MIL"
            Case Is < 2000 : NumeroALetra = "MIL " & NumeroALetra(Numero Mod 1000)
            Case Is < 1000000 : NumeroALetra = NumeroALetra(Int(Numero / 1000)) & " MIL"
                If (Numero Mod 1000 <> 0) Then NumeroALetra = NumeroALetra & " " & NumeroALetra(Numero Mod 1000)
            Case 1000000 : NumeroALetra = "UN MILLÓN"
            Case Is < 2000000 : NumeroALetra = "UN MILLÓN " & NumeroALetra(Numero Mod 1000)
            Case Is < 1000000000000 : NumeroALetra = NumeroALetra(Int(Numero / 1000000)) & " MILLONES"
                If (Numero Mod 1000000 <> 0) Then NumeroALetra = NumeroALetra & " " & NumeroALetra(Numero Mod 1000000)
            Case 1000000000000 : NumeroALetra = "UN BILLÓN"
            Case Is < 2000000000000 : NumeroALetra = "UN BILLÓN " & NumeroALetra(Numero Mod 1000000000000)
            Case Is < 1000000000000000000 : NumeroALetra = NumeroALetra(Int(Numero / 1000000000000)) & " BILLONES"
                If (Numero Mod 1000000000000 <> 0) Then NumeroALetra = NumeroALetra & " " & NumeroALetra(Numero Mod 1000000000000)
            Case 1000000000000000000 : NumeroALetra = "UN TRILLÓN"
            Case Else
                Beep()
                NumeroALetra = "EL NÚMERO EXCEDE EL RANGO"
        End Select
    End Function
    Function convertir(ByVal num As Double) As String
        Dim centavos, valor As Double
        centavos = Int(100 * (Val(num) - Int(Val(num))))
        valor = Int(num)
        If centavos <> 0 Then
            convertir = NumeroALetra(valor) & " PESOS " & centavos & "/100 M.N."
        ElseIf centavos < 10 Then
            convertir = NumeroALetra(valor) & " PESOS 0" & centavos & "/100 M.N."
        Else
            convertir = NumeroALetra(valor) & "PESOS 00/100 M.N."
        End If
    End Function
    Public Function validar_eMail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
End Module
