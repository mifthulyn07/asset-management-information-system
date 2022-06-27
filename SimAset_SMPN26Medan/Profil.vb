Imports System.Data.Odbc
Public Class Profil

    Sub kondisiawal()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False

        Button1.Text = "Update"
        Button2.Text = "Update"
        If MainMenu.ToolStripStatusLabel3.Text <> "Sapras" Then
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Sub tampilidentitas()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_identitas where npsn = '10210810'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        TextBox1.Text = rd.Item("nama")
        Label11.Text = rd.Item("nama")
        TextBox2.Text = rd.Item("status")
        TextBox3.Text = rd.Item("akreditasi")
        TextBox4.Text = rd.Item("alamat")
        TextBox5.Text = rd.Item("skpendirian")
        TextBox6.Text = rd.Item("skizin")
        TextBox7.Text = rd.Item("npsn")
        TextBox12.Text = rd.Item("tgl_skpendirian")
        TextBox13.Text = rd.Item("tgl_skizin")
        rd.Close()
    End Sub

    Sub tampilluastanah()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_tanah where  kode_tanah= '001'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        TextBox8.Text = rd.Item("status_pemilik")
        TextBox9.Text = rd.Item("luas_bangunan")
        TextBox10.Text = rd.Item("luas_halaman")
        TextBox11.Text = rd.Item("lain_lain")
        rd.Close()
    End Sub

    Sub siapisi1()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True
    End Sub

    Sub siapisi2()
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
    End Sub

    Sub hitung_luastanah()
        Dim luas_bangunan, luas_halaman, total_luas As Integer
        luas_bangunan = Val(TextBox9.Text)
        luas_halaman = Val(TextBox10.Text)
        total_luas = (luas_bangunan) + (luas_halaman)
        Label10.Text = total_luas
    End Sub

    Private Sub Profil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call tampilidentitas()
        Call tampilluastanah()
        Call hitung_luastanah()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Update" Then
            Button1.Text = "Simpan"
            Call siapisi1()
        Else
            If TextBox6.Text = "" Or TextBox1.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim updatedata1 As String = "update tbl_identitas set nama='" & TextBox1.Text & "', status='" & TextBox2.Text & "', akreditasi='" & TextBox3.Text & "', alamat='" & TextBox4.Text & "', skpendirian='" & TextBox5.Text & "', skizin='" & TextBox6.Text & "', tgl_skpendirian='" & TextBox12.Text & "', tgl_skizin='" & TextBox13.Text & "' where npsn='" & TextBox7.Text & "'"
                cmd = New OdbcCommand(updatedata1, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button1.Text = "Update" Then
            Button1.Text = "Simpan"
            Call siapisi2()
        Else
            If TextBox8.Text = "" Then
                MsgBox("Pastikan semua field terisi", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim updatedata2 As String = "update tbl_tanah set status_pemilik='" & TextBox8.Text & "', luas_bangunan='" & TextBox9.Text & "', luas_halaman='" & TextBox10.Text & "', lain_lain='" & TextBox11.Text & "' where kode_tanah='1'"
                cmd = New OdbcCommand(updatedata2, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub
End Class