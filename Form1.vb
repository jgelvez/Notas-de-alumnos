Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        lblResultado1.Text = (Val(txtNota1.Text) + Val(txtNota2.Text) + Val(txtEvalUno.Text)) / 3
        lblResultado2.Text = (Val(txtNota3.Text) + Val(txtNota4.Text) + Val(txtEvalDos.Text)) / 3
        lblResultado3.Text = (Val(txtNota5.Text) + Val(txtNota6.Text) + Val(txtEvalTres.Text)) / 3
    End Sub

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        lblResultadoFinal.Text = (Val(lblResultado1.Text) + Val(lblResultado2.Text) + Val(lblResultado3.Text)) / 3
    End Sub
End Class
