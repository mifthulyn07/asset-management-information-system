Imports System.Data.Odbc
Public Class GantiPassword

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub GantiPassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_admin where kode_admin = '" & MainMenu.ToolStripStatusLabel1.Text & "' and password = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox1.Enabled = False
            Else
                MsgBox("password anda salah", MsgBoxStyle.Information, "Pemberitahuan")
                TextBox3.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Password Baru Harus Diisi", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password Baru & Konfirmasi Harus Sama", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_admin set password='" & TextBox3.Text & "' where kode_admin='" & MainMenu.ToolStripStatusLabel1.Text & "'"
                cmd = New OdbcCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Password berhasil di Ubah", MsgBoxStyle.Information, "Pemberitahuan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class