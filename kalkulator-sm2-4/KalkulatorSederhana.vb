Public Class KalkulatorSederhana

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(textAngka1.Text)
        Angka2 = Val(textAngka2.Text)
        Hasil = Angka1 + Angka2
        hasilnya.Text = Hasil
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(textAngka1.Text)
        Angka2 = Val(textAngka2.Text)
        Hasil = Angka1 - Angka2
        hasilnya.Text = Hasil
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(textAngka1.Text)
        Angka2 = Val(textAngka2.Text)
        Hasil = Angka1 * Angka2
        hasilnya.Text = Hasil
    End Sub

    Private Sub bagi_Click(sender As Object, e As EventArgs) Handles bagi.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(textAngka1.Text)
        Angka2 = Val(textAngka2.Text)
        Hasil = Angka1 / Angka2
        hasilnya.Text = Hasil
    End Sub
End Class
