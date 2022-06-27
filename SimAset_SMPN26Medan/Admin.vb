Imports System.Data.Odbc
Public Class Admin

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox1.SelectedIndex = -1

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False

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
        da = New OdbcDataAdapter("select kode_admin, nama, status from tbl_admin", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_admin")
        DataGridView1.DataSource = (ds.Tables("tbl_admin"))

        'atur grid
        DataGridView1.Columns(0).HeaderText = "KODE ADMIN"
        DataGridView1.Columns(1).HeaderText = "NAMA ADMIN"
        DataGridView1.Columns(2).HeaderText = "STATUS ADMIN"
    End Sub

    Sub siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "*"
        End If
    End Sub

    Private Sub Admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()

        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 30
        TextBox3.MaxLength = 30
        TextBox3.PasswordChar = "*"
        ComboBox1.MaxLength = 30
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
            TextBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox1.SelectedIndex = -1
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim simpandata As String = "insert into tbl_admin values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_admin set nama='" & TextBox2.Text & "', password='" & TextBox3.Text & "', status='" & ComboBox1.Text & "' where kode_admin='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diedit", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Pastikan Kode Admin terisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then
                Call koneksi()
                Dim hapusdata As String = "delete from tbl_admin where kode_admin='" & TextBox1.Text & "'"
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
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox1.Enabled = False
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_admin where kode_admin = '" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        TextBox3.Text = rd.Item("password")
        rd.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'pencarian cepat2
        If e.KeyChar = Chr(13) Then
            TextBox1.Enabled = False
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_admin where kode_admin = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox2.Text = rd.Item("nama")
                TextBox3.Text = rd.Item("password")
                ComboBox1.Text = rd.Item("status")
            Else
                MsgBox("Data tidak ada", MsgBoxStyle.Information, "Pemberitahuan")
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        'pencarian 3
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_admin where nama Like '%" & TextBox4.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New OdbcDataAdapter("select * from tbl_admin where nama Like '%" & TextBox4.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "KetemuData")
            DataGridView1.DataSource = ds.Tables("KetemuData")
            DataGridView1.ReadOnly = True
        End If
    End Sub
End Class