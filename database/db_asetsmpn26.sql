-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2024 at 09:37 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_asetsmpn26`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kode_admin` varchar(12) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`kode_admin`, `nama`, `password`, `status`) VALUES
('ADM001', 'admin', 'admin', 'Sapras');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_anggota`
--

CREATE TABLE `tbl_anggota` (
  `kode_anggota` varchar(12) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telepon` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_anggota`
--

INSERT INTO `tbl_anggota` (`kode_anggota`, `nama`, `jenis_kelamin`, `status`, `alamat`, `no_telepon`) VALUES
('AGT001', 'Nurli Masito Lubis', 'Perempuan', 'Guru', 'Jl. Pancing 5 Link III', '081276005676'),
('AGT002', 'Cindai Lahmana', 'Perempuan', 'Murid', 'Jl. Cipuden', '083245763454'),
('AGT003', 'Anta Sari', 'Laki-Laki', 'Pembimbing', 'Jl. Ramayana', '096754356234'),
('AGT004', 'Lala Silili', 'Perempuan', 'Murid', 'Jl. Cempaka', '089823456743'),
('AGT005', 'Indah Sari', 'Perempuan', 'Karyawan', 'Jl. Jauh Jauh', '089723436547'),
('AGT006', 'Ridwan ', 'Laki-Laki', 'Guru', 'Jl.Pinang dibelah Dua', '084323453423'),
('AGT007', 'Sapri', 'Laki-Laki', 'Karyawan', 'Jl. Siputar Putar', '087654673454'),
('AGT008', 'Nina Indria', 'Perempuan', 'Pembimbing', 'Jl. Simambang', '085432345432');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kode_barang` varchar(12) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `merk` varchar(50) NOT NULL,
  `bahan` varchar(50) NOT NULL,
  `satuan` varchar(50) NOT NULL,
  `baik` int(11) NOT NULL,
  `rusak` int(11) NOT NULL,
  `harga` double NOT NULL,
  `tgl_peroleh` varchar(50) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_barang`
--

INSERT INTO `tbl_barang` (`kode_barang`, `nama`, `merk`, `bahan`, `satuan`, `baik`, `rusak`, `harga`, `tgl_peroleh`, `keterangan`) VALUES
('BRG001', 'Meja Siswa', 'Karya', 'Kayu', 'Unit', 120, 0, 45000, '22 July 2021', 'APBN'),
('BRG002', 'Meja Guru', 'Karya', 'Kayu', 'Unit', 40, 2, 60000, '27 July 2021', 'BOS'),
('BRG003', 'Kursi Siswa', 'Karya', 'Besi', 'Unit', 320, 2, 50000, '09 July 2021', 'APBN'),
('BRG004', 'Infocus', 'Toshiba', '', 'Unit', 20, 0, 800000, '19 July 2021', 'APBN'),
('BRG005', 'Kursi Guru', 'Cipta Sentosa', 'Besi & Kayu', 'Unit', 130, 0, 70000, '26 June 2018', 'BOS'),
('BRG006', 'Papan Tulis', 'Karya', 'Kayu', 'Unit', 50, 0, 120000, '06 July 2021', 'BOS'),
('BRG007', 'Kipas Angin', 'Mito', '-', 'Unit', 70, 0, 300000, '23 August 2021', 'APBN'),
('BRG008', 'Lemari', 'Cipta Sentosa', 'Kayu', 'Unit', 70, 8, 300000, '04 April 2021', 'BOS'),
('BRG009', 'Jam Dinding', 'Oclock', 'Plastik', 'Unit', 40, 11, 20000, '08 July 2021', 'BOS');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_identitas`
--

CREATE TABLE `tbl_identitas` (
  `npsn` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `akreditasi` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `skpendirian` varchar(50) NOT NULL,
  `tgl_skpendirian` varchar(50) NOT NULL,
  `skizin` varchar(50) NOT NULL,
  `tgl_skizin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_identitas`
--

INSERT INTO `tbl_identitas` (`npsn`, `nama`, `status`, `akreditasi`, `alamat`, `skpendirian`, `tgl_skpendirian`, `skizin`, `tgl_skizin`) VALUES
(10210810, 'SMP Negeri 26 Medan', 'Negeri', 'A', 'Jl.Pulau Sicanang Belawan', '7139/D-05.4/83', '1983-10-20', 'No.21 Tahun 2018', '2018-10-20');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pemeliharaan`
--

CREATE TABLE `tbl_pemeliharaan` (
  `kode_pemeliharaan` varchar(12) NOT NULL,
  `kode_barang` varchar(12) NOT NULL,
  `tindakan` varchar(50) NOT NULL,
  `tgl_tindakan` varchar(50) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pemeliharaan`
--

INSERT INTO `tbl_pemeliharaan` (`kode_pemeliharaan`, `kode_barang`, `tindakan`, `tgl_tindakan`, `keterangan`) VALUES
('PML001', 'BRG002', 'Perbaiki', '28 July 2021', ''),
('PML002', 'BRG008', 'Perbaiki', '04 August 2021', ''),
('PML003', 'BRG009', 'Pembelian Baru', '03 August 2021', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pinjam`
--

CREATE TABLE `tbl_pinjam` (
  `kode_pinjam` varchar(12) NOT NULL,
  `kode_anggota` varchar(12) NOT NULL,
  `kode_barang` varchar(12) NOT NULL,
  `nama_ptg` varchar(50) NOT NULL,
  `tgl_pinjam` varchar(50) NOT NULL,
  `wkt_pinjam` time NOT NULL,
  `jml_pinjam` int(11) NOT NULL,
  `status_kembali` varchar(50) NOT NULL,
  `tgl_kembali` varchar(50) NOT NULL,
  `wkt_kembali` time NOT NULL,
  `kp_baik` int(11) NOT NULL,
  `kp_rusak` int(11) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pinjam`
--

INSERT INTO `tbl_pinjam` (`kode_pinjam`, `kode_anggota`, `kode_barang`, `nama_ptg`, `tgl_pinjam`, `wkt_pinjam`, `jml_pinjam`, `status_kembali`, `tgl_kembali`, `wkt_kembali`, `kp_baik`, `kp_rusak`, `keterangan`) VALUES
('PJM210714002', 'AGT002', 'BRG002', 'Miftahul Ulyana Hutabarat', '14/07/2021', '15:46:18', 3, 'Sudah Dikembalikan', '14/07/2021', '15:47:13', 3, 0, 'akan dipulangkan 15/07/2021'),
('PJM210714003', 'AGT003', 'BRG001', 'Miftahul Ulyana Hutabarat', '14/07/2021', '15:50:12', 5, 'Sudah Dikembalikan', '14/07/2021', '15:51:04', 5, 0, 'akan dipulangkan 16/07/2021'),
('PJM210714004', 'AGT003', 'BRG001', 'Miftahul Ulyana Hutabarat', '14/07/2021', '16:01:36', 6, 'Sudah Dikembalikan', '14/07/2021', '17:50:08', 6, 0, 'akan dipulangkan 17/07/2021'),
('PJM210714006', 'AGT002', 'BRG005', 'Miftahul Ulyana Hutabarat', '14/07/2021', '16:10:55', 6, 'Sudah Dikembalikan', '17/07/2021', '22:37:04', 6, 0, 'dipulangkan 15/07/2021'),
('PJM210719007', 'AGT004', 'BRG006', 'Miftahul Ulyana Hutabarat', '19/07/2021', '19:36:02', 2, 'Belum Dikembalikan', '19/07/2021', '19:43:31', 2, 0, 'akan dipulangkan 20/07/2021'),
('PJM210719008', 'AGT004', 'BRG005', 'Syafira Mukhaira', '19/07/2021', '23:03:13', 6, 'Belum Dikembalikan', '00/00/0000', '00:00:00', 0, 0, 'akan dipulangkan 20/07/2021');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tanah`
--

CREATE TABLE `tbl_tanah` (
  `kode_tanah` int(11) NOT NULL,
  `status_pemilik` varchar(50) NOT NULL,
  `luas_bangunan` int(11) NOT NULL,
  `luas_halaman` int(11) NOT NULL,
  `lain_lain` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_tanah`
--

INSERT INTO `tbl_tanah` (`kode_tanah`, `status_pemilik`, `luas_bangunan`, `luas_halaman`, `lain_lain`) VALUES
(1, 'Pemerintah Daerah', 777, 692, '-');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kode_admin`);

--
-- Indexes for table `tbl_anggota`
--
ALTER TABLE `tbl_anggota`
  ADD PRIMARY KEY (`kode_anggota`);

--
-- Indexes for table `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kode_barang`);

--
-- Indexes for table `tbl_identitas`
--
ALTER TABLE `tbl_identitas`
  ADD PRIMARY KEY (`npsn`);

--
-- Indexes for table `tbl_pemeliharaan`
--
ALTER TABLE `tbl_pemeliharaan`
  ADD PRIMARY KEY (`kode_pemeliharaan`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- Indexes for table `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD PRIMARY KEY (`kode_pinjam`),
  ADD KEY `kode_anggota` (`kode_anggota`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- Indexes for table `tbl_tanah`
--
ALTER TABLE `tbl_tanah`
  ADD PRIMARY KEY (`kode_tanah`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_pemeliharaan`
--
ALTER TABLE `tbl_pemeliharaan`
  ADD CONSTRAINT `tbl_pemeliharaan_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `tbl_barang` (`kode_barang`);

--
-- Constraints for table `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD CONSTRAINT `tbl_pinjam_ibfk_1` FOREIGN KEY (`kode_anggota`) REFERENCES `tbl_anggota` (`kode_anggota`),
  ADD CONSTRAINT `tbl_pinjam_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `tbl_barang` (`kode_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
