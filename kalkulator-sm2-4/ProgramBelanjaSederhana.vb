Public Class ProgramBelanjaSederhana
    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged

    End Sub

    Private Sub ProgramBelanjaSederhana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonUlang_Click(sender As Object, e As EventArgs) Handles ButtonUlang.Click
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtTotalBayar.Text = ""
        TxtTotalHarga.Text = ""
        txtDiskon.Text = ""
        txtBonus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub buttonHitung_Click(sender As Object, e As EventArgs) Handles buttonHitung.Click
        Dim Harga, Jumlah As Integer
        Dim Total, Diskon, Bayar As Double
        Dim Bonus As String

        Harga = txtHarga.Text
        Jumlah = txtJumlah.Text

        Total = Harga * Jumlah

        If Total >= 500000 Then
            Diskon = 0.2 * Total
            Bonus = "Lambo"
        ElseIf Total >= 200000 Then
            Diskon = 0.15 * Total
            Bonus = "Rolex"
        ElseIf Total >= 100000 Then
            Diskon = 0.1 * Total
            Bonus = "Kaos"
        ElseIf Total >= 50000 Then
            Diskon = 0.05 * Total
            Bonus = "Pena"
        Else
            Diskon = 0
            Bonus = "Tidak Ada"
        End If

        Bayar = Total - Diskon

        TxtTotalHarga.Text = Total
        txtDiskon.Text = Diskon
        txtTotalBayar.Text = Bayar
        txtBonus.Text = Bonus
    End Sub
End Class