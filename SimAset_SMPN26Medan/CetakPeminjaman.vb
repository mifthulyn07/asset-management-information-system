Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class CetakPeminjaman
    Dim WithEvents pd As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Dim panjang As Integer
    
    Sub kondisiawal()
        'atur grid
        DataGridView1.Columns.Add("kode_pinjam", "KODE PINJAM")
        DataGridView1.Columns.Add("nama", "NAMA ANGGOTA")
        DataGridView1.Columns.Add("nama", "NAMA BARANG")
        DataGridView1.Columns.Add("jml_pinjam", "JML PINJAM")
        DataGridView1.Columns.Add("status_kembali", "STATUS")
    End Sub

    Private Sub CetakPeminjaman_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call ubahpanjang()
        ppd.Document = pd
        ppd.ShowDialog()
    End Sub

    Private Sub pd_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles pd.BeginPrint
        'mengatur size kertas
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 450, panjang)
        pd.DefaultPageSettings = pagesetup
    End Sub

    Private Sub pd_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        'tulisan
        Dim f10 As New Font("times new roman", 10, FontStyle.Regular)
        Dim f10b As New Font("times new roman", 10, FontStyle.Bold)
        Dim f12 As New Font("times new roman", 12, FontStyle.Bold)

        'margin
        Dim leftmargin As Integer = pd.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = pd.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = pd.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "============================================================================================"

        e.Graphics.DrawString("UPT.SMP NEGERI 26 MEDAN", f12, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.P Sicanang Belawan 20416", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Email : smpnmedan26@gmail.com", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString(Peminjaman.Label2.Text, f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString("tanggal", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 90)
        e.Graphics.DrawString(Peminjaman.Label7A.Text, f10, Brushes.Black, 75, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString("Kode Pinjam", f10b, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Nama", f10b, Brushes.Black, 100, 110)
        e.Graphics.DrawString("Barang", f10b, Brushes.Black, 220, 110)
        e.Graphics.DrawString("Jml", f10b, Brushes.Black, 295, 110)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 360, 110)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 120)

        DataGridView1.AllowUserToAddRows = False
        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 0, 115 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 100, 115 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 220, 115 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 300, 115 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 330, 115 + tinggi)
        Next

        tinggi = 125 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)

        e.Graphics.DrawString("Keterangan", f10, Brushes.Black, 0, 20 + tinggi)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 20 + tinggi)
        e.Graphics.DrawString(RichTextBox1.Text, f10, Brushes.Black, 75, 20 + tinggi)
    End Sub

    Sub ubahpanjang()
        Dim rowcount As Integer
        panjang = 0

        rowcount = DataGridView1.Rows.Count
        panjang = rowcount * 15
        panjang = panjang + 200
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Peminjaman.Label9.Text = "" Or Peminjaman.TextBox1.Text = "" Then
            MsgBox("Silahkan Masukkan Kode Buku yang akan dipinjam", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            DataGridView1.Rows.Add(New String() {Peminjaman.Label1.Text, Peminjaman.Label3.Text, Peminjaman.Label9.Text, Peminjaman.TextBox1.Text, Peminjaman.ComboBox3.Text})
        End If
    End Sub
End Class