Public Class Formulario1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LApellido.Click

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TextBox3.Text = TextBox1.Text & " " & TextBox2.Text
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox3.Clear()

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()

    End Sub

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        BSalir.Visible = False
    End Sub

    Private Sub Formulario1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            BSalir.Visible = True
        End If
    End Sub


End Class
