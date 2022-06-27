Imports System.Data.Odbc
Public Class Pemeliharaan

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox3.SelectedIndex = -1
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox3.Enabled = False
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
        da = New OdbcDataAdapter("select kode_pemeliharaan, kode_barang, tindakan, tgl_tindakan, keterangan from tbl_pemeliharaan", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_pemeliharaan")
        DataGridView1.DataSource = (ds.Tables("tbl_pemeliharaan"))

        'atur grid
        DataGridView1.Columns(0).HeaderText = "KODE PEMELIHARAAN"
        DataGridView1.Columns(1).HeaderText = "KODE BARANG"
        DataGridView1.Columns(2).HeaderText = "TINDAKAN"
        DataGridView1.Columns(3).HeaderText = "TGL TINDAKAN"
        DataGridView1.Columns(4).HeaderText = "KETERANGAN"
    End Sub

    Sub siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox3.Enabled = True
        DateTimePicker1.Enabled = True
        RichTextBox1.Enabled = True
    End Sub

    Sub tampilbarang()
        'menampilkan database kode_barang di combobox3
        cmd = New OdbcCommand("select kode_barang From tbl_barang", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox3.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox3.TextChanged
        cmd = New OdbcCommand(" select * from tbl_barang where kode_barang = '" & ComboBox3.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            Label1.Text = rd.Item(1)
            Label2.Text = rd.Item(2)
            Label3.Text = rd.Item(3)
            Label4.Text = rd.Item(6)
            Label5.Text = rd.Item(7)
            Label6.Text = rd.Item(8)
        ElseIf ComboBox3.Text = "" Then
            Label1.Text = "-"
            Label2.Text = "-"
            Label3.Text = "-"
            Label4.Text = "-"
            Label5.Text = "-"
            Label6.Text = "-"
        End If
    End Sub

    Private Sub Pemeliharaan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call tampilbarang()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Input "
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapisi()
            'kosongkan
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox3.SelectedIndex = -1
            DateTimePicker1.Text = ""
            RichTextBox1.Text = ""
        ElseIf Label4.Text = 0 Then
            MsgBox("Tidak ada Barang yang rusak", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox3.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim simpandata As String = "insert into tbl_pemeliharaan values('" & TextBox1.Text & "', '" & ComboBox3.Text & "', '" & TextBox2.Text & "', '" & DateTimePicker1.Text & "', '" & RichTextBox1.Text & "')"
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
            Call siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox3.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_pemeliharaan set kode_barang ='" & ComboBox3.Text & "', tindakan='" & TextBox2.Text & "', tgl_tindakan='" & DateTimePicker1.Text & "', keterangan='" & RichTextBox1.Text & "' where kode_pemeliharaan='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diedit", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then
                Call koneksi()
                Dim hapusdata As String = "delete from tbl_pemeliharaan where kode_pemeliharaan='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
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
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox1.Enabled = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'pencarian cepat2
        If e.KeyChar = Chr(13) Then
            TextBox1.Enabled = False
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_pemeliharaan where kode_pemeliharaan = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                ComboBox3.Text = rd.Item("kode_barang")
                TextBox2.Text = rd.Item("tindakan")
                DateTimePicker1.Text = rd.Item("tgl_tindakan")
                RichTextBox1.Text = rd.Item("keterangan")
            Else
                MsgBox("Data tidak ada", MsgBoxStyle.Information, "Pemberitahuan")
            End If
        End If
    End Sub
End Class