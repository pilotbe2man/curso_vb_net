﻿Public Class FormCalculoFiguras
    Private Sub numAncho_ValueChanged(sender As Object, e As EventArgs) Handles numAncho.ValueChanged, numAlto.ValueChanged
        Dim rectangulo As Rectangulo = New Rectangulo(numAlto.Value, numAncho.Value)

        numArea.Value = rectangulo.CalcularArea()
        numPerimetro.Value = rectangulo.CalcularPerimetro()
    End Sub
    Private Sub numRadio_ValueChanged(sender As Object, e As EventArgs) Handles numRadio.ValueChanged
        Dim circulo As Circulo = New Circulo(numRadio.Value, Nothing)

        numArea.Value = circulo.CalcularArea()
        numPerimetro.Value = circulo.CalcularPerimetro()
    End Sub
    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radRectangulo.CheckedChanged
        grupoRectangulo.Visible = radRectangulo.Checked
        grupoCirculo.Visible = radCirculo.Checked
    End Sub

    Private Sub numRadio2_ValueChanged(sender As Object, e As EventArgs) Handles numRadio2.ValueChanged, cbxTipoCalculoCirculo.SelectedIndexChanged
        Dim circulo As Circulo = New Circulo(numRadio2.Value, Nothing)

        If cbxTipoCalculoCirculo.SelectedIndex = 0 Then
            numResultadoCirculo.Value = circulo.CalcularArea()
        Else
            numResultadoCirculo.Value = circulo.CalcularPerimetro()
        End If
    End Sub

    Private Sub numRectangulo_ValueChanged(sender As Object, e As EventArgs) Handles numAncho2.ValueChanged, numAlto2.ValueChanged, cbxTipoCalculoRectangulo.SelectedIndexChanged
        Dim rectangulo As Rectangulo = New Rectangulo(numAlto2.Value, numAncho2.Value)

        If cbxTipoCalculoRectangulo.SelectedIndex = 0 Then
            numResultadoRectangulo.Value = rectangulo.CalcularArea()
        Else
            numResultadoRectangulo.Value = rectangulo.CalcularPerimetro()
        End If
    End Sub
End Class
