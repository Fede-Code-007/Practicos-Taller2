<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BGuardar = New Button()
        BEliminar = New Button()
        BSalir = New Button()
        LApellido = New Label()
        LNombre = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(52, 203)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(94, 29)
        BGuardar.TabIndex = 0
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(161, 203)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(94, 29)
        BEliminar.TabIndex = 1
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(334, 203)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(94, 29)
        BSalir.TabIndex = 2
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        BSalir.Visible = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(52, 42)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(66, 20)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(52, 102)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(64, 20)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 39)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 34)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 102)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 34)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(296, 39)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 107)
        TextBox3.TabIndex = 7
        ' 
        ' Formulario1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 253)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(BSalir)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Name = "Formulario1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mi Primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox

End Class
