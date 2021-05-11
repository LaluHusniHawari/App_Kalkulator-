Public Class Form1
    Dim Angka1, Angka2, Hasil As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 + Angka2
        txtHasil.Text = Hasil
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 / Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub TxtAngka1_TextChanged(sender As Object, e As EventArgs) Handles txtAngka1.TextChanged

    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 - Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 * Angka2
        txtHasil.Text = Hasil
    End Sub
End Class
