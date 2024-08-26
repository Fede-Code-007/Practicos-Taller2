Public Class PequeñoFormulario
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If LModificar.Text = "modificar" Then
            If TDni.Text = "" Or TNombre.Text = "" Or TApellido.Text = "" Then
                MsgBox("Debe completar todos los campos", vbCritical, "Error")
            Else
                Dim ask As MsgBoxResult
                ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", vbYesNo + vbDefaultButton1 + vbQuestion, "Confirmar Inserción")
                If ask = MsgBoxResult.Yes Then
                    LModificar.Text = TNombre.Text & " " & TApellido.Text
                    MsgBox("El cliente" + TNombre.Text + " " + TApellido.Text + " se insertó correctamente", vbInformation, "Guardar")
                End If
            End If
        End If

    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If LModificar.Text <> "modificar" Then
            Dim ask As MsgBoxResult
            Dim name As String
            ask = MsgBox("Está apunto de eliminar el Cliente: " + LModificar.Text, vbYesNo + vbDefaultButton1 + vbQuestion, "Confirmar Eliminación")
            If ask = MsgBoxResult.Yes Then
                name = LModificar.Text
                LModificar.Text = "modificar"
                TDni.Clear()
                TNombre.Clear()
                TApellido.Clear()
                MsgBox("El cliente: " + name + " se eliminó correctamente", vbInformation, "Eliminar")
            End If
        End If

    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
