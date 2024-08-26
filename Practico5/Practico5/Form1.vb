Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        ' Mostrar el diálogo para seleccionar un archivo
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim rutaArchivo As String = OpenFileDialog1.FileName

            ' Mostrar la imagen seleccionada en el PictureBox
            PictureBox1.Image = Image.FromFile(rutaArchivo)

            ' Mostrar la ruta del archivo en el TextBox
            TFoto.Text = rutaArchivo
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_Leave(sender As Object, e As EventArgs) Handles TNombre.Leave
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text.Length > 0 Then
            tb.Text = Char.ToUpper(tb.Text(0)) & tb.Text.Substring(1).ToLower()
        End If
    End Sub

    Private Sub TApellido_Leave(sender As Object, e As EventArgs) Handles TApellido.Leave
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text.Length > 0 Then
            tb.Text = Char.ToUpper(tb.Text(0)) & tb.Text.Substring(1).ToLower()
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1, , , TSaldo.Text, PictureBox1, TFoto.Text)

    End Sub
End Class
