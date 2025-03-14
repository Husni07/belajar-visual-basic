Public Class TugasHitungNilaiAkhir
    Private Sub buttonHitung_Click(sender As Object, e As EventArgs) Handles buttonHitung.Click
        Dim Kehadiran, Tugas, Quiz, Uts, Uas, NilaiAkhir As Double
        Kehadiran = Val(txtKehadiran.Text)
        Tugas = Val(txtTugas.Text)
        Quiz = Val(txtQuiz.Text)
        Uts = Val(txtUts.Text)
        Uas = Val(txtUas.Text)

        NilaiAkhir = (Kehadiran * 0.15) + (Tugas * 0.15) + (Quiz * 0.2) + (Uts * 0.25) + (Uas * 0.25)
        txtNilaiAkhir.Text = NilaiAkhir
    End Sub

    Private Sub TugasHitungNilaiAkhir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class