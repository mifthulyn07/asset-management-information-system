Imports System.Data.Odbc
Public Class MainMenu

    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        GantiPasswordToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        LihatProfilSekolahToolStripMenuItem.Visible = False

        ToolStripStatusLabel1.Visible = False
        ToolStripStatusLabel2.Visible = False
        ToolStripStatusLabel3.Visible = False
        ToolStripStatusLabel5.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = TimeOfDay
    End Sub

    Private Sub MainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is MdiClient Then c.BackColor = Me.BackColor
        Next
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        GantiPassword.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        Admin.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnggotaToolStripMenuItem.Click
        Anggota.ShowDialog()
    End Sub

    Private Sub AsetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsetToolStripMenuItem.Click
        AsetBarang.ShowDialog()
    End Sub

    Private Sub PeminjamanAsetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PeminjamanAsetToolStripMenuItem.Click
        Peminjaman.Show()
        Peminjaman.MdiParent = Me
    End Sub

    Private Sub PenyusutanAsetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PenyusutanAsetToolStripMenuItem.Click
        Pemeliharaan.ShowDialog()
    End Sub

    Private Sub LihatProfilSekolahToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LihatProfilSekolahToolStripMenuItem.Click
        Profil.ShowDialog()
    End Sub

    Private Sub LaporanAnggotaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaporanAnggotaToolStripMenuItem.Click
        LaporanAnggota.ShowDialog()
    End Sub

    Private Sub LaporanAsetBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaporanAsetBarangToolStripMenuItem.Click
        LaporanAsetBarang.ShowDialog()
    End Sub

    Private Sub LaporanTindakanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaporanTindakanToolStripMenuItem.Click
        LaporanPemeliharaan.ShowDialog()
    End Sub

    Private Sub LaporanPeminjamanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaporanPeminjamanToolStripMenuItem.Click
        LaporanPeminjaman.ShowDialog()
    End Sub
End Class