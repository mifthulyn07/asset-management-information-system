Imports System.Data.Odbc
Public Class Peminjaman

    Sub kodeotomatis()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_pinjam where kode_pinjam in (select max(kode_pinjam) from tbl_pinjam)", conn)
        Dim urutankode As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutankode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            urutankode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        Label1.Text = urutankode
    End Sub

    Sub kondisiawal()
        Call kodeotomatis()

        ComboBox1.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.Text = ""
        ComboBox2.SelectedIndex = -1
        ComboBox3.Text = ""
        ComboBox3.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RichTextBox1.Text = ""

        Label7A.Visible = True
        Label8A.Visible = True
        Label108A.Visible = True
        Label109A.Visible = True

        Label7B.Visible = False
        Label8B.Visible = False
        Label108B.Visible = False
        Label109B.Visible = False

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        RichTextBox1.Enabled = False

        Label7A.Text = Today
        Label7B.Text = Today
        Label2.Text = MainMenu.ToolStripStatusLabel2.Text

        Button1.Text = "Pinjam"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button5.Text = "Kembalikan"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True

        'memasukkan data ke datagridview
        Call koneksi()
        da = New OdbcDataAdapter("select kode_pinjam, kode_anggota, kode_barang, nama_ptg, tgl_pinjam, wkt_pinjam, jml_pinjam, status_kembali, tgl_kembali, wkt_kembali, kp_baik, kp_rusak, keterangan from tbl_pinjam", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_pinjam")
        DataGridView1.DataSource = (ds.Tables("tbl_pinjam"))

        'atur grid
        DataGridView1.Columns(0).HeaderText = "KODE PINJAM"
        DataGridView1.Columns(1).HeaderText = "KODE ANGGOTA"
        DataGridView1.Columns(2).HeaderText = "KODE BARANG"
        DataGridView1.Columns(3).HeaderText = "PETUGAS"
        DataGridView1.Columns(4).HeaderText = "TGL PINJAM"
        DataGridView1.Columns(5).HeaderText = "WKT PINJAM"
        DataGridView1.Columns(6).HeaderText = "JML PINJAM"
        DataGridView1.Columns(7).HeaderText = "STATUS"
        DataGridView1.Columns(8).HeaderText = "TGL KEMBALI"
        DataGridView1.Columns(9).HeaderText = "WKT KEMBALI"
        DataGridView1.Columns(10).HeaderText = "BAIK"
        DataGridView1.Columns(11).HeaderText = "RUSAK"
        DataGridView1.Columns(12).HeaderText = "KETERANGAN"
    End Sub

    Sub siapisi()
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        RichTextBox1.Enabled = True
    End Sub

    Sub tampilanggota()
        'menampilkan database kode_anggota ke combobox1
        cmd = New OdbcCommand("select kode_anggota from tbl_anggota", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub tampilbarang()
        'menampilkan database kode_barang ke combobox2
        cmd = New OdbcCommand("select kode_barang From tbl_barang", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox2.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label8A.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label8B.Text = TimeOfDay
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Sudah Dikembalikan" Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.TextChanged
        cmd = New OdbcCommand(" select * from tbl_anggota where kode_anggota = '" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            Label3.Text = rd.Item(1)
            Label4.Text = rd.Item(3)
            Label5.Text = rd.Item(4)
            Label6.Text = rd.Item(5)
        ElseIf ComboBox1.Text = "" Then
            Label3.Text = "-"
            Label4.Text = "-"
            Label5.Text = "-"
            Label6.Text = "-"
        Else
            MsgBox("Data Anggota tidak ada", MsgBoxStyle.Information, "Pemberitahuan")
        End If
    End Sub


    Private Sub ComboBox2_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.TextChanged
        cmd = New OdbcCommand(" select * from tbl_barang where kode_barang = '" & ComboBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            Label9.Text = rd.Item(1)
            Label10.Text = rd.Item(2)
            Label11.Text = rd.Item(3)
            Label12.Text = rd.Item(5)
        ElseIf ComboBox2.Text = "" Then
            Label9.Text = "-"
            Label10.Text = "-"
            Label11.Text = "-"
            Label12.Text = "-"
        End If
    End Sub

    Private Sub Peminjaman_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call tampilanggota()
        Call tampilbarang()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Pinjam" Then
            Button1.Text = "Pinjam "
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Button5.Enabled = False
            Call siapisi()
            'kosongkan
            ComboBox1.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.Text = ""
            ComboBox2.SelectedIndex = -1
            ComboBox3.Text = ""
            ComboBox3.SelectedIndex = -1
            TextBox1.Text = ""
            TextBox2.Text = " "
            TextBox3.Text = " "
            RichTextBox1.Text = ""
            ComboBox3.Text = "Belum Dikembalikan"
            ComboBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            Label7A.Text = Today
        Else
            If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
                MsgBox("Pastikan Kode Anggota, Kode Barang dan Jumlah Pinjaman terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Label7B.Text = "00/00/0000"
                Label8B.Text = "-"
                Call koneksi()
                Dim simpandata As String = "insert into tbl_pinjam values('" & Label1.Text & "', '" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & Label2.Text & "', '" & Label7A.Text & "', '" & Label8A.Text & "', '" & TextBox1.Text & "', '" & ComboBox3.Text & "', '" & Label7B.Text & "', '" & Label8B.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & RichTextBox1.Text & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button1.Enabled = False
            Button2.Text = "Edit "
            Button3.Enabled = False
            Button4.Text = "Batal"
            Button5.Enabled = False
            Call siapisi()
        Else
            If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
                MsgBox("Pastikan kode anggota dan kode barang terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_pinjam set kode_anggota='" & ComboBox1.Text & "', kode_barang='" & ComboBox2.Text & "', jml_pinjam='" & TextBox1.Text & "', status_kembali='" & ComboBox3.Text & "', kp_baik='" & TextBox2.Text & "', kp_rusak='" & TextBox3.Text & "', keterangan='" & RichTextBox1.Text & "' where kode_pinjam='" & Label1.Text & "'"
                cmd = New OdbcCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diedit", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub
    
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Pastikan kode anggota dan kode barang terisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then
                Call koneksi()
                Dim hapusdata As String = "delete from tbl_pinjam where kode_pinjam='" & Label1.Text & "'"
                cmd = New OdbcCommand(hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                Call kondisiawal()
            Else
                MsgBox("Batal Menghapus", MsgBoxStyle.Information, "Pemberitahuan")
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            kondisiawal()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "Kembalikan" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Button5.Text = "Kembalikan "

            Label7A.Visible = False
            Label8A.Visible = False
            Label108A.Visible = False
            Label109A.Visible = False

            Label7B.Visible = True
            Label8B.Visible = True
            Label108B.Visible = True
            Label109B.Visible = True

            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Label7B.Text = Today
        ElseIf TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Pastikan kode anggota dan kode barang terisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else

            Dim baik, buruk, jmlpinjam As Integer
            baik = Val(TextBox2.Text)
            buruk = Val(TextBox3.Text)
            jmlpinjam = Val(TextBox1.Text)
            If baik + buruk <> jmlpinjam Then
                ComboBox3.Text = "Belum Dikembalikan"
                TextBox1.Text = jmlpinjam - (baik + buruk)
            Else
                ComboBox3.Text = "Sudah Dikembalikan"
            End If
            Call koneksi()
            Dim kembalidata As String = "update tbl_pinjam set jml_pinjam ='" & TextBox1.Text & "',  status_kembali='" & ComboBox3.Text & "', tgl_kembali='" & Label7B.Text & "', wkt_kembali='" & Label8B.Text & "', kp_baik='" & TextBox2.Text & "', kp_rusak='" & TextBox3.Text & "', keterangan='" & RichTextBox1.Text & "' where kode_pinjam='" & Label1.Text & "'"
            cmd = New OdbcCommand(kembalidata, conn)
            cmd.ExecuteNonQuery()

            If baik + buruk <> jmlpinjam Then
                MsgBox("Masih Ada Barang yang belum dikembalikan", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            Else
                MsgBox("Barang berhasil dikembalikan", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'pencarian cepat1
        On Error Resume Next
        Label1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Label2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Label7A.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Label8A.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        Label7B.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        Label8B.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        CetakPeminjaman.Show()
        CetakPeminjaman.MdiParent = MainMenu
    End Sub
End Class