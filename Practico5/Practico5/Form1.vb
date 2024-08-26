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
        Dim sexo As String
        If RBHombre.Checked Then
            sexo = "Hombre"
        Else
            sexo = "Mujer"
        End If
        If TNombre.Text = "" Or TApellido.Text = "" Or TSaldo.Text = "" Then
            MsgBox("Debe completar todos los campos", vbCritical, "Error")
        Else
            If Decimal.Parse(TSaldo.Text) < 50 Then
                DataGridView1.Rows(DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Value, sexo, "eliminar", TSaldo.Text, PictureBox1.Image, TFoto.Text)).DefaultCellStyle.BackColor = Color.Red
            Else
                DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Value, sexo, "eliminar", TSaldo.Text, PictureBox1.Image, TFoto.Text)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("Eliminar").Index Then
            ' Mostrar un mensaje de confirmación antes de eliminar
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Eliminar la fila seleccionada
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub TSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSaldo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
