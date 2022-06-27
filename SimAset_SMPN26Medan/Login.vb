Imports System.Data.Odbc
Public Class Login

    Sub terbuka()
        MainMenu.LoginToolStripMenuItem.Visible = False
        MainMenu.LogoutToolStripMenuItem.Visible = True
        MainMenu.GantiPasswordToolStripMenuItem.Visible = True
        MainMenu.MasterToolStripMenuItem.Visible = True
        MainMenu.TransaksiToolStripMenuItem.Visible = True
        MainMenu.LaporanToolStripMenuItem.Visible = True
        MainMenu.LihatProfilSekolahToolStripMenuItem.Visible = True

        MainMenu.ToolStripStatusLabel1.Visible = True
        MainMenu.ToolStripStatusLabel2.Visible = True
        MainMenu.ToolStripStatusLabel3.Visible = True
        MainMenu.ToolStripStatusLabel1.Text = rd.GetString(0)
        MainMenu.ToolStripStatusLabel2.Text = rd.GetString(1)
        MainMenu.ToolStripStatusLabel3.Text = rd.GetString(3)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'jika dienterkan langsung pindah ke textbox2
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'jika dienterkan langsung pindah ke button1
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username atau Password Tidak Boleh Kosong!")
        Else
            Call koneksi()
            cmd = New OdbcCommand("Select * From tbl_admin where kode_admin ='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
            rd = cmd.ExecuteReader 'membaca
            rd.Read()
            If rd.HasRows Then 'datanya ada
                Me.Close()
                Call terbuka()
                If MainMenu.ToolStripStatusLabel3.Text <> "Sapras" Then
                    MainMenu.MasterToolStripMenuItem.Enabled = False
                    MainMenu.TransaksiToolStripMenuItem.Enabled = False
                End If
            Else
                MsgBox("Username atau Password Salah!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class