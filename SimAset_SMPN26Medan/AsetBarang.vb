Imports System.Data.Odbc
Public Class AsetBarang

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = ""
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        RichTextBox1.Enabled = False

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        'memasukkan data ke datagridview
        Call koneksi()
        da = New OdbcDataAdapter("select kode_barang, nama, merk, bahan, satuan, baik, rusak, harga, tgl_peroleh, keterangan from tbl_barang", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = (ds.Tables("tbl_barang"))

        'atur grid
        DataGridView1.Columns(0).HeaderText = "KODE"
        DataGridView1.Columns(1).HeaderText = "NAMA"
        DataGridView1.Columns(2).HeaderText = "MERK"
        DataGridView1.Columns(3).HeaderText = "BAHAN"
        DataGridView1.Columns(4).HeaderText = "SATUAN"
        DataGridView1.Columns(5).HeaderText = "BAIK"
        DataGridView1.Columns(6).HeaderText = "RUSAK"
        DataGridView1.Columns(7).HeaderText = "HARGA"
        DataGridView1.Columns(8).HeaderText = "TGL PEROLEH"
        DataGridView1.Columns(9).HeaderText = "KETERANGAN"
    End Sub

    Sub siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        ComboBox1.Enabled = True
        DateTimePicker1.Enabled = True
        RichTextBox1.Enabled = True
    End Sub

    Private Sub AsetBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Input "
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapisi()
            'kosongkan
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            ComboBox1.Text = ""
            ComboBox1.SelectedIndex = -1
            DateTimePicker1.Text = ""
            RichTextBox1.Text = ""
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan field Kode dan Nama terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim simpandata As String = "insert into tbl_barang values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & ComboBox1.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox5.Text & "', '" & DateTimePicker1.Text & "', '" & RichTextBox1.Text & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button1.Enabled = False
            Button2.Text = "Edit "
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan field Kode dan Nama terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_barang set nama='" & TextBox2.Text & "', merk='" & TextBox3.Text & "', bahan='" & TextBox4.Text & "', satuan='" & ComboBox1.Text & "', baik='" & TextBox7.Text & "', rusak='" & TextBox8.Text & "', harga='" & TextBox5.Text & "', tgl_peroleh='" & DateTimePicker1.Text & "', keterangan='" & RichTextBox1.Text & "' where kode_barang='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diedit", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Pastikan Kode Anggota terisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then
                    Call koneksi()
                    Dim hapusdata As String = "delete from tbl_barang where kode_barang='" & TextBox1.Text & "'"
                    cmd = New OdbcCommand(hapusdata, conn)
                    cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            Else
                MsgBox("Batal Menghapus", MsgBoxStyle.Information, "Pemberitahuan")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            kondisiawal()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'pencarian cepat1
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox1.Enabled = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'pencarian cepat2
        If e.KeyChar = Chr(13) Then
            TextBox1.Enabled = False
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_barang where kode_barang = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox2.Text = rd.Item("nama_barang")
                TextBox3.Text = rd.Item("merk_barang")
                TextBox4.Text = rd.Item("bahan")
                ComboBox1.Text = rd.Item("satuan")
                TextBox7.Text = rd.Item("baik")
                TextBox8.Text = rd.Item("rusak")
                TextBox5.Text = rd.Item("harga")
                DateTimePicker1.Text = rd.Item("tgl_peroleh")
                RichTextBox1.Text = rd.Item("keterangan")
            Else
                MsgBox("Data tidak ada", MsgBoxStyle.Information, "Pemberitahuan")
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        'pencarian 3
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_barang where nama Like '%" & TextBox6.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New OdbcDataAdapter("select * from tbl_barang where nama Like '%" & TextBox6.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            DataGridView1.DataSource = ds.Tables("KetemuData")
            DataGridView1.ReadOnly = True
        End If
    End Sub
End Class