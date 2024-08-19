<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PequeñoFormulario
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
        LNya = New Label()
        LDni = New Label()
        LModificar = New Label()
        LApellido = New Label()
        LNombre = New Label()
        TGuardar = New Button()
        TEliminar = New Button()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(35, 49)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(35, 89)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 1
        LDni.Text = "DNI"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(162, 49)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 2
        LModificar.Text = "modificar"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(35, 115)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(35, 145)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' TGuardar
        ' 
        TGuardar.Location = New Point(35, 206)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(75, 23)
        TGuardar.TabIndex = 5
        TGuardar.Text = "Guardar"
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.Location = New Point(127, 206)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(75, 23)
        TEliminar.TabIndex = 6
        TEliminar.Text = "Eliminar"
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(127, 81)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 7
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(127, 110)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 8
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(127, 139)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 9
        ' 
        ' PequeñoFormulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 263)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDni)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(LModificar)
        Controls.Add(LDni)
        Controls.Add(LNya)
        Name = "PequeñoFormulario"
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox

End Class
