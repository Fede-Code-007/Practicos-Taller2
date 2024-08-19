Public Class PequeñoFormulario
    Private Sub PequeñoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TDni.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmar Insercion")
            If ask = MsgBoxResult.Yes Then
                MsgBox("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se insertó correctamente", MsgBoxStyle.Information, "Guardar")
                LModificar.Text = TNombre.Text + " " + TApellido.Text
            End If
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        If LModificar.Text = "modificar" Then
            TApellido.Clear()
            TNombre.Clear()
            TDni.Clear()
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Esta a punto de eliminar el Cliente: " + LModificar.Text, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Confirmar Eliminación")
            If ask = MsgBoxResult.Yes Then
                MsgBox("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminar")
                LModificar.Text = "modificar"
                TApellido.Clear()
                TNombre.Clear()
                TDni.Clear()
            End If
        End If
    End Sub
End Class
