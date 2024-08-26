Public Class PequeñoFormulario
    Private Sub PequeñoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
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

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
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
                TTelefono.Clear()
                MsgBox("El cliente: " + name + " se eliminó correctamente", vbInformation, "Eliminar")
            End If
        End If
    End Sub

    Private Sub LDni_Click(sender As Object, e As EventArgs) Handles LDni.Click

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            PictureBox1.BackgroundImage = My.Resources.VaronIcono
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBox1.BackgroundImage = My.Resources.MujerIcono
        End If
    End Sub

    Private Sub LTitulo_Click(sender As Object, e As EventArgs) Handles LTitulo.Click

    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
