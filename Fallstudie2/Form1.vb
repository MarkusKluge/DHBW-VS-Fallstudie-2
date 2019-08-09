Public Class Form1

    Private Function validateInputCharacter(character As String)
        Dim validCharacters(0 To 12) As String
        validCharacters(0) = "0"
        validCharacters(1) = "1"
        validCharacters(2) = "2"
        validCharacters(3) = "3"
        validCharacters(4) = "4"
        validCharacters(5) = "5"
        validCharacters(6) = "6"
        validCharacters(7) = "7"
        validCharacters(8) = "8"
        validCharacters(9) = "9"
        validCharacters(10) = "+"
        validCharacters(11) = "-"
        validCharacters(12) = "="

        Dim validCharacterFound As Boolean = False
        For index As Integer = 0 To 12
            If character = validCharacters(index) Then
                validCharacterFound = True
            End If
        Next

        Return validCharacterFound
    End Function

    Private Function rechne(eingabe As String)
        Dim ergebnis As String = ""
        Dim lastNumber As Integer
        Dim lastOperator As String = ""

        For index As Integer = 0 To eingabe.Length - 1
            ' Überspringe Leerzeichen
            If eingabe(index) = " " Then
                Continue For
            End If
            ' Überspringe Istgleich-Zeichen wenn es an der letzten Stelle steht
            If eingabe(index) = "=" And index = eingabe.Length - 1 Then
                Continue For
            End If

            ' Überprüfe auf gültige Zeichen
            If validateInputCharacter(eingabe(index)) = True Then
                ' Überprüfe auf Operator / Operand und rechne
                If eingabe(index) = "+" Then
                    lastOperator = "+"
                    Continue For
                End If

                If eingabe(index) = "-" Then
                    lastOperator = "-"
                    Continue For
                Else
                    If lastOperator = "+" Then
                        lastNumber = lastNumber + Integer.Parse(eingabe(index))
                        lastOperator = ""
                    ElseIf lastOperator = "-" Then
                        lastNumber = lastNumber - Integer.Parse(eingabe(index))
                        lastOperator = ""
                    Else
                        ' Try n Catch falls nach einem Istgleich-Zeichen am Ende noch ein Buchstabe stehen würde
                        Try
                            If Integer.Parse(lastNumber) And Integer.Parse(eingabe(index)) Then
                                Return "Ungültige Zeichen! Nur einziffrige Operanden!"
                            End If
                        Catch ex As Exception
                            Return "Ungültige Zeichen! Nur einziffrige Operanden!"
                        End Try
                        lastNumber = Integer.Parse(eingabe(index))
                    End If

                End If
            Else
                ' ungültiges Zeichen erkannt
                Return "Ungültige Zeichen!"
                Exit For
            End If
        Next

        Return lastNumber.ToString
    End Function

    Private Sub Button_rechne_Click(sender As Object, e As EventArgs) Handles Button_rechne.Click
        Dim eingabe As String = TextBox_eingabe.Text
        Label_result.Text = rechne(eingabe)

    End Sub
End Class
