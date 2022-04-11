<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNota1 = New System.Windows.Forms.Label()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.lblNota2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplica = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Location = New System.Drawing.Point(13, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(137, 16)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Notas de alumnos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblNota1
        '
        Me.lblNota1.AutoSize = True
        Me.lblNota1.BackColor = System.Drawing.Color.Teal
        Me.lblNota1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota1.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota1.Location = New System.Drawing.Point(122, 96)
        Me.lblNota1.Name = "lblNota1"
        Me.lblNota1.Size = New System.Drawing.Size(113, 16)
        Me.lblNota1.TabIndex = 1
        Me.lblNota1.Text = "Ingrese nota 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNota1
        '
        Me.txtNota1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota1.Location = New System.Drawing.Point(245, 85)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(86, 27)
        Me.txtNota1.TabIndex = 2
        Me.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNota2
        '
        Me.txtNota2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota2.Location = New System.Drawing.Point(245, 118)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(86, 27)
        Me.txtNota2.TabIndex = 4
        Me.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNota2
        '
        Me.lblNota2.AutoSize = True
        Me.lblNota2.BackColor = System.Drawing.Color.Teal
        Me.lblNota2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota2.Location = New System.Drawing.Point(122, 129)
        Me.lblNota2.Name = "lblNota2"
        Me.lblNota2.Size = New System.Drawing.Size(113, 16)
        Me.lblNota2.TabIndex = 3
        Me.lblNota2.Text = "Ingrese nota 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.Color.Red
        Me.txtResultado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.SystemColors.Window
        Me.txtResultado.Location = New System.Drawing.Point(245, 161)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(86, 27)
        Me.txtResultado.TabIndex = 5
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.BackColor = System.Drawing.Color.Teal
        Me.lblResultado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.Window
        Me.lblResultado.Location = New System.Drawing.Point(122, 172)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(79, 16)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Resultado"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(393, 85)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(96, 23)
        Me.btnSuma.TabIndex = 7
        Me.btnSuma.Text = "Sumar"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(495, 114)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(96, 23)
        Me.btnDividir.TabIndex = 8
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplica.Location = New System.Drawing.Point(393, 114)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Size = New System.Drawing.Size(96, 23)
        Me.btnMultiplica.TabIndex = 9
        Me.btnMultiplica.Text = "Multiplicar"
        Me.btnMultiplica.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(495, 85)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(96, 23)
        Me.btnResta.TabIndex = 10
        Me.btnResta.Text = "Restar"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPotencia.Location = New System.Drawing.Point(443, 143)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(96, 23)
        Me.btnPotencia.TabIndex = 11
        Me.btnPotencia.Text = "Potenciar"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(495, 207)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(96, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(634, 254)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnMultiplica)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtNota2)
        Me.Controls.Add(Me.lblNota2)
        Me.Controls.Add(Me.txtNota1)
        Me.Controls.Add(Me.lblNota1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNota1 As Label
    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents lblNota2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnMultiplica As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnCerrar As Button
End Class
