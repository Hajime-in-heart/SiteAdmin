Public Class frmConverter
    Dim result As String
    Dim start As String
    Dim NUMbox As Integer
    Dim SSbox As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalculateResult_Button.Click
        result = 0
        Try
            start = EnterDigit_TextBox.Text
            NUMbox = EnterDigit_TextBox.Text
            SSbox = ChangeCurrNotation_ComboBox.Text
            Select Case SSbox
                Case "Bin"
                    Select Case True
                        Case OctalNotation_RadioButton.Checked
                            FromBinToDec()
                            FromDecToOct()

                        Case DecimalSystem_RadioButton.Checked
                            FromBinToDec()

                        Case HeximalSystem_RadioButton.Checked
                            FromBinToDec()
                            FromDecToHex()

                    End Select

                Case "Oct"
                    Select Case True
                        Case BinarySystem_RadioButton.Checked
                            FromOctToDec()
                            FromDecToBin()

                        Case DecimalSystem_RadioButton.Checked
                            FromOctToDec()

                        Case HeximalSystem_RadioButton.Checked
                            FromOctToDec()
                            FromDecToHex()

                    End Select

                Case "Dec"
                    Select Case True
                        Case BinarySystem_RadioButton.Checked
                            FromDecToBin()

                        Case OctalNotation_RadioButton.Checked
                            FromDecToOct()

                        Case HeximalSystem_RadioButton.Checked
                            FromDecToHex()

                    End Select

                Case "Hex"
                    Select Case True
                        Case BinarySystem_RadioButton.Checked
                            FromHexToDec()
                            FromDecToBin()

                        Case OctalNotation_RadioButton.Checked
                            FromHexToDec()
                            FromDecToOct()

                        Case DecimalSystem_RadioButton.Checked
                            FromHexToDec()

                    End Select
            End Select
            EnterDigit_TextBox.Text = start
            MessageBox.Show("Результат выполнения конвертации: " + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EnterDigit_TextBox.Clear()

        Catch ex As Exception

        End Try
    End Sub


    Sub FromBinToDec()
        Try
            result = Convert.ToString(Convert.ToInt32(EnterDigit_TextBox.Text, 2), 10)
            EnterDigit_TextBox.Text = result
        Catch ex As Exception

        End Try
    End Sub


    Sub FromDecToBin()
        Try
            NUMbox = EnterDigit_TextBox.Text
            result = (Convert.ToString(NUMbox, 2))
            EnterDigit_TextBox.Text = result
        Catch ex As Exception

        End Try
    End Sub


    Sub FromOctToDec()
        Try
            result = Convert.ToString(Convert.ToInt32(EnterDigit_TextBox.Text, 8), 10)
            EnterDigit_TextBox.Text = result
        Catch ex As Exception

        End Try
    End Sub


    Sub FromDecToOct()
        Try
            Dim i = Convert.ToInt32(EnterDigit_TextBox.Text)
            result = Convert.ToString(i, 8)
            EnterDigit_TextBox.Text = result
        Catch ex As Exception

        End Try
    End Sub

    Sub FromHexToDec()
        Try
            Dim hexChars As String = "0123456789ABCDEF"
            Dim inpHex As String = EnterDigit_TextBox.Text.Trim().ToUpper()
            Dim tmp As Integer = 0
            Dim n As Integer = 0

            Dim uIndex As Integer = inpHex.Length - 1 'верхний индекс строки
            Dim lIndex As Integer = 0 'нижний индекс. Используется в случае, если число отрицательное, при выполнении блока-условия ниже

            If inpHex.Length = 8 And hexChars.IndexOf(inpHex(0)) > 7 Then 'проверка на отрицательное число
                result = &H80000000 + ((hexChars.IndexOf(inpHex(0)) - 8) * &H10000000)
                lIndex = 1
            End If

            For i As Integer = uIndex To lIndex Step -1 'перебор символов в обратном порядке
                tmp = hexChars.IndexOf(inpHex(i))
                result = result + CInt(tmp * 2 ^ (4 * (uIndex - i)))
            Next
            EnterDigit_TextBox.Text = result
        Catch ex As Exception

        End Try
    End Sub

    Sub FromDecToHex()
        result = Hex(EnterDigit_TextBox.Text)
        EnterDigit_TextBox.Text = result
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChangeCurrNotation_ComboBox.SelectedIndexChanged
        BinarySystem_RadioButton.Enabled = True
        OctalNotation_RadioButton.Enabled = True
        DecimalSystem_RadioButton.Enabled = True
        HeximalSystem_RadioButton.Enabled = True

        Select Case ChangeCurrNotation_ComboBox.Text
            Case "Bin"
                BinarySystem_RadioButton.Enabled = False
            Case "Oct"
                OctalNotation_RadioButton.Enabled = False
            Case "Dec"
                DecimalSystem_RadioButton.Enabled = False
            Case "Hex"
                HeximalSystem_RadioButton.Enabled = False
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub frmConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
    End Sub
End Class