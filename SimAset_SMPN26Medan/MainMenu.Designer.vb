<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyusutanAsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAsetBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTindakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatProfilSekolahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LihatProfilSekolahToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.GantiPasswordToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.AsetToolStripMenuItem})
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MasterToolStripMenuItem.Image = CType(resources.GetObject("MasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AnggotaToolStripMenuItem.Text = "Anggota"
        '
        'AsetToolStripMenuItem
        '
        Me.AsetToolStripMenuItem.Name = "AsetToolStripMenuItem"
        Me.AsetToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AsetToolStripMenuItem.Text = "Aset Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanAsetToolStripMenuItem, Me.PenyusutanAsetToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PeminjamanAsetToolStripMenuItem
        '
        Me.PeminjamanAsetToolStripMenuItem.Name = "PeminjamanAsetToolStripMenuItem"
        Me.PeminjamanAsetToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PeminjamanAsetToolStripMenuItem.Text = "Peminjaman"
        '
        'PenyusutanAsetToolStripMenuItem
        '
        Me.PenyusutanAsetToolStripMenuItem.Name = "PenyusutanAsetToolStripMenuItem"
        Me.PenyusutanAsetToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PenyusutanAsetToolStripMenuItem.Text = "Pemeliharaan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanAnggotaToolStripMenuItem, Me.LaporanAsetBarangToolStripMenuItem, Me.LaporanPeminjamanToolStripMenuItem, Me.LaporanTindakanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanAnggotaToolStripMenuItem
        '
        Me.LaporanAnggotaToolStripMenuItem.Name = "LaporanAnggotaToolStripMenuItem"
        Me.LaporanAnggotaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LaporanAnggotaToolStripMenuItem.Text = "Laporan Anggota"
        '
        'LaporanAsetBarangToolStripMenuItem
        '
        Me.LaporanAsetBarangToolStripMenuItem.Name = "LaporanAsetBarangToolStripMenuItem"
        Me.LaporanAsetBarangToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LaporanAsetBarangToolStripMenuItem.Text = "Laporan Aset Barang"
        '
        'LaporanPeminjamanToolStripMenuItem
        '
        Me.LaporanPeminjamanToolStripMenuItem.Name = "LaporanPeminjamanToolStripMenuItem"
        Me.LaporanPeminjamanToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LaporanPeminjamanToolStripMenuItem.Text = "Laporan Peminjaman"
        '
        'LaporanTindakanToolStripMenuItem
        '
        Me.LaporanTindakanToolStripMenuItem.Name = "LaporanTindakanToolStripMenuItem"
        Me.LaporanTindakanToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LaporanTindakanToolStripMenuItem.Text = "Laporan Tindakan"
        '
        'LihatProfilSekolahToolStripMenuItem
        '
        Me.LihatProfilSekolahToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LihatProfilSekolahToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LihatProfilSekolahToolStripMenuItem.Image = CType(resources.GetObject("LihatProfilSekolahToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LihatProfilSekolahToolStripMenuItem.Name = "LihatProfilSekolahToolStripMenuItem"
        Me.LihatProfilSekolahToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.LihatProfilSekolahToolStripMenuItem.Text = "Lihat Profil Sekolah"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1149, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "KODE: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel2.Text = "NAMA: "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel3.Text = "STATUS:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel4.Text = "JAM: "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel5.Text = "TANGGAL: "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1149, 390)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenyusutanAsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LihatProfilSekolahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanAsetBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanTindakanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
