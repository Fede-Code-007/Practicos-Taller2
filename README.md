# Prácticos de Taller de Programación II

Repositorio que reúne una serie de trabajos prácticos desarrollados durante la asignatura **Taller de Programación II** de la **Licenciatura en Sistemas de Información de la Universidad Nacional del Nordeste (UNNE)**.

Los trabajos fueron desarrollados utilizando **Visual Basic .NET** y **Windows Forms**, abordando progresivamente conceptos relacionados con el desarrollo de aplicaciones de escritorio, diseño de interfaces gráficas, manejo de eventos, validación de datos, formularios MDI y manipulación de información mediante controles de tipo `DataGridView`.

## 🛠️ Tecnologías y herramientas

* **Visual Basic .NET**
* **Windows Forms**
* **.NET 8**
* **Visual Studio**
* Programación orientada a eventos
* Controles y componentes de Windows Forms

## 📚 Contenido

El repositorio está organizado en cuatro prácticos:

| Práctico                                                         | Tema principal                                |
| ---------------------------------------------------------------- | --------------------------------------------- |
| [Práctico 1](#-práctico-1--primer-windows-forms)                 | Creación y configuración de Windows Forms     |
| [Práctico 2](#-práctico-2--validación-y-mensajes)                | Validación de campos y cuadros de diálogo     |
| [Práctico 3](#-práctico-3--mdi-y-personalización-de-la-interfaz) | Formularios MDI, controles e imágenes         |
| [Práctico 5](#-práctico-5--datagridview-e-imágenes)              | DataGridView, imágenes y gestión de registros |

> La numeración corresponde a los prácticos originales de la asignatura; por ese motivo el repositorio contiene los prácticos 1, 2, 3 y 5.

---

## 🖥️ Práctico 1 — Primer Windows Forms

Primer acercamiento al desarrollo de interfaces gráficas utilizando **Windows Forms**.

### Conceptos trabajados

* Creación de un proyecto Windows Forms.
* Configuración de propiedades de un formulario.
* Uso de `Label`.
* Uso de `TextBox`.
* Uso de `Button`.
* TextBox de una y múltiples líneas (`Multiline`).
* Manejo del evento `Click`.
* Concatenación de valores ingresados en controles.
* Limpieza de controles mediante `Clear()`.
* Configuración de la posición inicial del formulario.
* Finalización de la aplicación.
* Uso de atajos de teclado.

### Funcionalidades

La aplicación permite ingresar un nombre y apellido y, mediante el botón **Guardar**, concatenar ambos valores y mostrarlos en un tercer campo de texto.

También incorpora un botón **Eliminar** para limpiar el campo de resultado y un botón para salir de la aplicación.

---

## 📝 Práctico 2 — Validación y mensajes

En este práctico se profundiza el manejo de eventos y controles mediante la incorporación de **validaciones de entrada** y diferentes tipos de cuadros de diálogo.

### Conceptos trabajados

* Validación de datos ingresados en `TextBox`.
* Restricción de caracteres según el tipo de dato.
* Uso de operadores lógicos.
* Uso de `If`.
* Uso de `MsgBox`.
* `MsgBoxResult`.
* Mensajes de error.
* Mensajes de confirmación.
* Mensajes de información.
* Mensajes de advertencia.
* Confirmación de operaciones mediante las opciones **Sí/No**.
* Modificación dinámica del contenido de un `Label`.
* Limpieza de controles.

### Validaciones implementadas

La aplicación diferencia el tipo de información que puede ingresarse en cada campo:

* **DNI:** solamente números.
* **Nombre:** solamente letras.
* **Apellido:** solamente letras.

Antes de guardar o eliminar información se realizan las validaciones y confirmaciones correspondientes.

---

## 🖼️ Práctico 3 — MDI y personalización de la interfaz

Este práctico amplía el formulario anterior incorporando diferentes controles visuales y una arquitectura basada en **MDI (Multiple Document Interface)**.

### Conceptos trabajados

* Formularios `MDIParent`.
* Formularios secundarios.
* Propiedad `MdiParent`.
* Apertura de formularios mediante `Show()`.
* `Panel`.
* `PictureBox`.
* `RadioButton`.
* `CheckBox`.
* Recursos e imágenes.
* Eventos `CheckedChanged`.
* Personalización de botones.
* Propiedades `Image`, `ImageAlign` y `TextAlign`.
* Cierre de formularios mediante `Me.Close()`.

### Funcionalidades

El formulario incorpora:

* Selección de género mediante `RadioButton`.
* Cambio dinámico de la imagen mostrada en un `PictureBox`.
* Selección de diferentes opciones mediante `CheckBox`.
* Botones personalizados con imágenes y alineación de contenido.
* Un formulario principal MDI denominado **Pequeño Sistema**.
* Apertura del formulario de carga desde el menú del formulario principal.
* Restricción del formulario secundario al contenedor MDI.

---

## 📊 Práctico 5 — DataGridView e imágenes

Último práctico del repositorio, orientado a la manipulación de información mediante un **DataGridView**, incorporación de imágenes y gestión de registros.

### Conceptos trabajados

* `DataGridView`.
* Manipulación de filas y columnas.
* Eventos `CellClick` y `CellContentClick`.
* `PictureBox`.
* `OpenFileDialog`.
* `DateTimePicker`.
* Recursos del proyecto.
* Copia y utilización de archivos de imagen.
* Formateo de texto.
* Personalización de columnas y filas.
* Manejo de registros.
* Confirmación de eliminación.

### Funcionalidades

La aplicación permite gestionar información de clientes mediante una tabla.

Entre las funcionalidades implementadas se encuentran:

* Carga de datos en un `DataGridView`.
* Registro de nombre, apellido y otros datos.
* Selección de fecha mediante `DateTimePicker`.
* Selección de imágenes mediante `OpenFileDialog`.
* Visualización de la imagen seleccionada en un `PictureBox`.
* Almacenamiento de la ruta de la imagen.
* Formateo de nombres y apellidos.
* Personalización de las fuentes de las columnas.
* Eliminación de registros.
* Confirmación antes de eliminar información.
* Asociación del sexo seleccionado con los `RadioButton`.
* Carga automática de la imagen asociada al registro.
* Aplicación de formato visual a registros cuyo saldo sea inferior a `$50`.

---

## 📁 Estructura del repositorio

La estructura general del repositorio es:

```text
Practicos-Taller2/
│
├── Practico1/
│   ├── Form1.vb
│   ├── Form1.Designer.vb
│   ├── Form1.resx
│   ├── Practico1.sln
│   └── Practico1.vbproj
│
├── Practico2/
│   ├── Form1.vb
│   ├── Form1.Designer.vb
│   ├── Form1.resx
│   ├── Practico3.sln
│   └── Practico3.vbproj
│
├── Practico3/
│   ├── Form1.vb
│   ├── MDIParent1.vb
│   ├── Resources/
│   ├── Practico3.sln
│   └── Practico3.vbproj
│
├── Practico5/
│   └── Practico5/
│   │   ├── Form1.vb
│   │   ├── Resources/
│   │   └── Practico5.vbproj
│   └── Practico5.sln
│
└── README.md
```

> Los directorios `bin`, `obj` y `.vs` corresponden a archivos generados por Visual Studio durante la compilación y desarrollo de los proyectos.

---

## 🚀 Ejecución

Para ejecutar cualquiera de los prácticos:

1. Clonar el repositorio.

```bash
git clone https://github.com/Fede-Code-007/Practicos-Taller2.git
```

2. Abrir la solución (`.sln`) correspondiente con **Visual Studio**.

3. Seleccionar el proyecto como proyecto de inicio.

4. Ejecutar mediante:

```text
F5
```

o

```text
Ctrl + F5
```

Los proyectos están desarrollados para **Windows Forms sobre .NET**, por lo que se requiere un entorno Windows compatible con Visual Studio y las herramientas de desarrollo correspondientes.
