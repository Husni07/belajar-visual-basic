Public Class Home

    Private Sub shutDown_Click(sender As Object, e As EventArgs) Handles shutDown.Click
        Application.Exit()
    End Sub

    Private Sub KalkulatorSederhana_Click(sender As Object, e As EventArgs) Handles ProgramKalkulatorSederhana.Click
        If KalkulatorSederhana.Visible Then KalkulatorSederhana.Close() Else KalkulatorSederhana.Show()
    End Sub

    Private Sub Tugas1_Click(sender As Object, e As EventArgs) Handles Tugas1.Click
        If TugasHitungNilaiAkhir.Visible Then TugasHitungNilaiAkhir.Close() Else TugasHitungNilaiAkhir.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BelanjaSederhana.Click
        If ProgramBelanjaSederhana.Visible Then ProgramBelanjaSederhana.Close() Else ProgramBelanjaSederhana.Show()
    End Sub
End Class