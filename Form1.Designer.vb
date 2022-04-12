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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnPromedio = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblTrimestreUno = New System.Windows.Forms.Label()
        Me.txtEvalUno = New System.Windows.Forms.TextBox()
        Me.lblEvalUno = New System.Windows.Forms.Label()
        Me.txtEvalDos = New System.Windows.Forms.TextBox()
        Me.lblEvalDos = New System.Windows.Forms.Label()
        Me.lblTrimestreDos = New System.Windows.Forms.Label()
        Me.txtNota4 = New System.Windows.Forms.TextBox()
        Me.lblNota4 = New System.Windows.Forms.Label()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.lblNota3 = New System.Windows.Forms.Label()
        Me.txtEvalTres = New System.Windows.Forms.TextBox()
        Me.lblEvalTres = New System.Windows.Forms.Label()
        Me.lblTrimestreTres = New System.Windows.Forms.Label()
        Me.txtNota6 = New System.Windows.Forms.TextBox()
        Me.lblNota6 = New System.Windows.Forms.Label()
        Me.txtNota5 = New System.Windows.Forms.TextBox()
        Me.lblNota5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRes1 = New System.Windows.Forms.Label()
        Me.lblResultado1 = New System.Windows.Forms.Label()
        Me.lblResultado2 = New System.Windows.Forms.Label()
        Me.lblResultado3 = New System.Windows.Forms.Label()
        Me.lblResultadoFinal = New System.Windows.Forms.Label()
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
        Me.lblNota1.Location = New System.Drawing.Point(34, 100)
        Me.lblNota1.Name = "lblNota1"
        Me.lblNota1.Size = New System.Drawing.Size(37, 16)
        Me.lblNota1.TabIndex = 1
        Me.lblNota1.Text = "TP 1"
        '
        'txtNota1
        '
        Me.txtNota1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota1.Location = New System.Drawing.Point(157, 89)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(86, 27)
        Me.txtNota1.TabIndex = 2
        Me.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNota2
        '
        Me.txtNota2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota2.Location = New System.Drawing.Point(157, 122)
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
        Me.lblNota2.Location = New System.Drawing.Point(34, 133)
        Me.lblNota2.Name = "lblNota2"
        Me.lblNota2.Size = New System.Drawing.Size(37, 16)
        Me.lblNota2.TabIndex = 3
        Me.lblNota2.Text = "TP 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(34, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Resultado"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(37, 261)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(138, 27)
        Me.btnSuma.TabIndex = 7
        Me.btnSuma.Text = "Notas parciales"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnPromedio
        '
        Me.btnPromedio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromedio.Location = New System.Drawing.Point(37, 304)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(96, 27)
        Me.btnPromedio.TabIndex = 10
        Me.btnPromedio.Text = "Nota final"
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(501, 384)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(96, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblTrimestreUno
        '
        Me.lblTrimestreUno.AutoSize = True
        Me.lblTrimestreUno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrimestreUno.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTrimestreUno.Location = New System.Drawing.Point(34, 61)
        Me.lblTrimestreUno.Name = "lblTrimestreUno"
        Me.lblTrimestreUno.Size = New System.Drawing.Size(105, 16)
        Me.lblTrimestreUno.TabIndex = 13
        Me.lblTrimestreUno.Text = "1er Trimestre"
        '
        'txtEvalUno
        '
        Me.txtEvalUno.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvalUno.Location = New System.Drawing.Point(157, 155)
        Me.txtEvalUno.Name = "txtEvalUno"
        Me.txtEvalUno.Size = New System.Drawing.Size(86, 27)
        Me.txtEvalUno.TabIndex = 15
        Me.txtEvalUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEvalUno
        '
        Me.lblEvalUno.AutoSize = True
        Me.lblEvalUno.BackColor = System.Drawing.Color.Teal
        Me.lblEvalUno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalUno.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEvalUno.Location = New System.Drawing.Point(34, 166)
        Me.lblEvalUno.Name = "lblEvalUno"
        Me.lblEvalUno.Size = New System.Drawing.Size(106, 16)
        Me.lblEvalUno.TabIndex = 14
        Me.lblEvalUno.Text = "Evaluación 1°"
        '
        'txtEvalDos
        '
        Me.txtEvalDos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvalDos.Location = New System.Drawing.Point(399, 155)
        Me.txtEvalDos.Name = "txtEvalDos"
        Me.txtEvalDos.Size = New System.Drawing.Size(86, 27)
        Me.txtEvalDos.TabIndex = 22
        Me.txtEvalDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEvalDos
        '
        Me.lblEvalDos.AutoSize = True
        Me.lblEvalDos.BackColor = System.Drawing.Color.Teal
        Me.lblEvalDos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalDos.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEvalDos.Location = New System.Drawing.Point(276, 166)
        Me.lblEvalDos.Name = "lblEvalDos"
        Me.lblEvalDos.Size = New System.Drawing.Size(106, 16)
        Me.lblEvalDos.TabIndex = 21
        Me.lblEvalDos.Text = "Evaluación 2°"
        '
        'lblTrimestreDos
        '
        Me.lblTrimestreDos.AutoSize = True
        Me.lblTrimestreDos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrimestreDos.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTrimestreDos.Location = New System.Drawing.Point(276, 61)
        Me.lblTrimestreDos.Name = "lblTrimestreDos"
        Me.lblTrimestreDos.Size = New System.Drawing.Size(108, 16)
        Me.lblTrimestreDos.TabIndex = 20
        Me.lblTrimestreDos.Text = "2do Trimestre"
        '
        'txtNota4
        '
        Me.txtNota4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota4.Location = New System.Drawing.Point(399, 122)
        Me.txtNota4.Name = "txtNota4"
        Me.txtNota4.Size = New System.Drawing.Size(86, 27)
        Me.txtNota4.TabIndex = 19
        Me.txtNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNota4
        '
        Me.lblNota4.AutoSize = True
        Me.lblNota4.BackColor = System.Drawing.Color.Teal
        Me.lblNota4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota4.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota4.Location = New System.Drawing.Point(276, 133)
        Me.lblNota4.Name = "lblNota4"
        Me.lblNota4.Size = New System.Drawing.Size(37, 16)
        Me.lblNota4.TabIndex = 18
        Me.lblNota4.Text = "TP 4"
        '
        'txtNota3
        '
        Me.txtNota3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota3.Location = New System.Drawing.Point(399, 89)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.Size = New System.Drawing.Size(86, 27)
        Me.txtNota3.TabIndex = 17
        Me.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNota3
        '
        Me.lblNota3.AutoSize = True
        Me.lblNota3.BackColor = System.Drawing.Color.Teal
        Me.lblNota3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota3.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota3.Location = New System.Drawing.Point(276, 100)
        Me.lblNota3.Name = "lblNota3"
        Me.lblNota3.Size = New System.Drawing.Size(37, 16)
        Me.lblNota3.TabIndex = 16
        Me.lblNota3.Text = "TP 3"
        '
        'txtEvalTres
        '
        Me.txtEvalTres.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvalTres.Location = New System.Drawing.Point(651, 155)
        Me.txtEvalTres.Name = "txtEvalTres"
        Me.txtEvalTres.Size = New System.Drawing.Size(86, 27)
        Me.txtEvalTres.TabIndex = 29
        Me.txtEvalTres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEvalTres
        '
        Me.lblEvalTres.AutoSize = True
        Me.lblEvalTres.BackColor = System.Drawing.Color.Teal
        Me.lblEvalTres.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalTres.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEvalTres.Location = New System.Drawing.Point(528, 166)
        Me.lblEvalTres.Name = "lblEvalTres"
        Me.lblEvalTres.Size = New System.Drawing.Size(106, 16)
        Me.lblEvalTres.TabIndex = 28
        Me.lblEvalTres.Text = "Evaluación 3°"
        '
        'lblTrimestreTres
        '
        Me.lblTrimestreTres.AutoSize = True
        Me.lblTrimestreTres.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrimestreTres.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTrimestreTres.Location = New System.Drawing.Point(528, 61)
        Me.lblTrimestreTres.Name = "lblTrimestreTres"
        Me.lblTrimestreTres.Size = New System.Drawing.Size(105, 16)
        Me.lblTrimestreTres.TabIndex = 27
        Me.lblTrimestreTres.Text = "3er Trimestre"
        '
        'txtNota6
        '
        Me.txtNota6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota6.Location = New System.Drawing.Point(651, 122)
        Me.txtNota6.Name = "txtNota6"
        Me.txtNota6.Size = New System.Drawing.Size(86, 27)
        Me.txtNota6.TabIndex = 26
        Me.txtNota6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNota6
        '
        Me.lblNota6.AutoSize = True
        Me.lblNota6.BackColor = System.Drawing.Color.Teal
        Me.lblNota6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota6.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota6.Location = New System.Drawing.Point(528, 133)
        Me.lblNota6.Name = "lblNota6"
        Me.lblNota6.Size = New System.Drawing.Size(37, 16)
        Me.lblNota6.TabIndex = 25
        Me.lblNota6.Text = "TP 6"
        '
        'txtNota5
        '
        Me.txtNota5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota5.Location = New System.Drawing.Point(651, 89)
        Me.txtNota5.Name = "txtNota5"
        Me.txtNota5.Size = New System.Drawing.Size(86, 27)
        Me.txtNota5.TabIndex = 24
        Me.txtNota5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNota5
        '
        Me.lblNota5.AutoSize = True
        Me.lblNota5.BackColor = System.Drawing.Color.Teal
        Me.lblNota5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota5.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNota5.Location = New System.Drawing.Point(528, 100)
        Me.lblNota5.Name = "lblNota5"
        Me.lblNota5.Size = New System.Drawing.Size(37, 16)
        Me.lblNota5.TabIndex = 23
        Me.lblNota5.Text = "TP 5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(276, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(528, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Resultado"
        '
        'lblRes1
        '
        Me.lblRes1.AutoSize = True
        Me.lblRes1.BackColor = System.Drawing.Color.Red
        Me.lblRes1.Location = New System.Drawing.Point(342, 291)
        Me.lblRes1.Name = "lblRes1"
        Me.lblRes1.Size = New System.Drawing.Size(0, 16)
        Me.lblRes1.TabIndex = 35
        '
        'lblResultado1
        '
        Me.lblResultado1.BackColor = System.Drawing.Color.Red
        Me.lblResultado1.Location = New System.Drawing.Point(157, 206)
        Me.lblResultado1.Name = "lblResultado1"
        Me.lblResultado1.Size = New System.Drawing.Size(86, 27)
        Me.lblResultado1.TabIndex = 36
        '
        'lblResultado2
        '
        Me.lblResultado2.BackColor = System.Drawing.Color.Red
        Me.lblResultado2.Location = New System.Drawing.Point(399, 206)
        Me.lblResultado2.Name = "lblResultado2"
        Me.lblResultado2.Size = New System.Drawing.Size(86, 27)
        Me.lblResultado2.TabIndex = 37
        '
        'lblResultado3
        '
        Me.lblResultado3.BackColor = System.Drawing.Color.Red
        Me.lblResultado3.Location = New System.Drawing.Point(651, 206)
        Me.lblResultado3.Name = "lblResultado3"
        Me.lblResultado3.Size = New System.Drawing.Size(86, 27)
        Me.lblResultado3.TabIndex = 38
        '
        'lblResultadoFinal
        '
        Me.lblResultadoFinal.BackColor = System.Drawing.Color.Red
        Me.lblResultadoFinal.Location = New System.Drawing.Point(157, 304)
        Me.lblResultadoFinal.Name = "lblResultadoFinal"
        Me.lblResultadoFinal.Size = New System.Drawing.Size(86, 27)
        Me.lblResultadoFinal.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(827, 429)
        Me.Controls.Add(Me.lblResultadoFinal)
        Me.Controls.Add(Me.lblResultado3)
        Me.Controls.Add(Me.lblResultado2)
        Me.Controls.Add(Me.lblResultado1)
        Me.Controls.Add(Me.lblRes1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEvalTres)
        Me.Controls.Add(Me.lblEvalTres)
        Me.Controls.Add(Me.lblTrimestreTres)
        Me.Controls.Add(Me.txtNota6)
        Me.Controls.Add(Me.lblNota6)
        Me.Controls.Add(Me.txtNota5)
        Me.Controls.Add(Me.lblNota5)
        Me.Controls.Add(Me.txtEvalDos)
        Me.Controls.Add(Me.lblEvalDos)
        Me.Controls.Add(Me.lblTrimestreDos)
        Me.Controls.Add(Me.txtNota4)
        Me.Controls.Add(Me.lblNota4)
        Me.Controls.Add(Me.txtNota3)
        Me.Controls.Add(Me.lblNota3)
        Me.Controls.Add(Me.txtEvalUno)
        Me.Controls.Add(Me.lblEvalUno)
        Me.Controls.Add(Me.lblTrimestreUno)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnPromedio)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnPromedio As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTrimestreUno As Label
    Friend WithEvents txtEvalUno As TextBox
    Friend WithEvents lblEvalUno As Label
    Friend WithEvents txtEvalDos As TextBox
    Friend WithEvents lblEvalDos As Label
    Friend WithEvents lblTrimestreDos As Label
    Friend WithEvents txtNota4 As TextBox
    Friend WithEvents lblNota4 As Label
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents lblNota3 As Label
    Friend WithEvents txtEvalTres As TextBox
    Friend WithEvents lblEvalTres As Label
    Friend WithEvents lblTrimestreTres As Label
    Friend WithEvents txtNota6 As TextBox
    Friend WithEvents lblNota6 As Label
    Friend WithEvents txtNota5 As TextBox
    Friend WithEvents lblNota5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRes1 As Label
    Friend WithEvents lblResultado1 As Label
    Friend WithEvents lblResultado2 As Label
    Friend WithEvents lblResultado3 As Label
    Friend WithEvents lblResultadoFinal As Label
End Class
