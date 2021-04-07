Public Class Frlatihan1

    Private Sub Frlatihan1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Latihan Pertama Menampilkan Nilai Object"
        ' Mengisi Properti Form
        Me.lblKelamin.Text = "Jenis Kelamin"
        Me.lblAlamat.Text = "Alamat Lengkap"
        Me.lblKota.Text = "K o t a"

        ' Mengisi objek Button
        Me.btList.Text = "List"
        Me.btClear.Text = "Clear"
        Me.btExit.Text = "E&xit"

        ' Mengisi objek label
        Me.lblNim234.Text = "No.Induk Mahasiswa"
        Me.lblNama.Text = "Nama Lengkap"
    End Sub

    Private Sub btList_Click(sender As Object, e As EventArgs) Handles btList.Click
        Me.txtNim234.Text = "2007-001"
        Me.txtNama.Text = "Khoirul Mustofa"
        Me.txtKelamin.Text = "Pria"
        Me.txtAlamat.Text = "Jl. Gatsu No 123, Binong Jati"
        Me.txtKota.Text = "Solo"

    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        Me.txtNim234.Clear()
        Me.txtNama.Clear()
        Me.txtKelamin.Clear()
        Me.txtAlamat.Clear()
        Me.txtKota.Clear()
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
End Class
