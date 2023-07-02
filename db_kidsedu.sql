-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 12, 2022 at 08:19 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kidsedu`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_guru`
--

CREATE TABLE `tbl_guru` (
  `id_guru` int(11) NOT NULL,
  `password` int(11) NOT NULL,
  `nama_guru` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_guru`
--

INSERT INTO `tbl_guru` (`id_guru`, `password`, `nama_guru`, `email`) VALUES
(2001, 111, 'Entis', 'entis@gmail.com'),
(2002, 111, 'Sutisna', 'sutisna@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_score`
--

CREATE TABLE `tbl_score` (
  `id_score` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `score` int(11) NOT NULL,
  `tanggal` varchar(30) NOT NULL,
  `komentar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_score`
--

INSERT INTO `tbl_score` (`id_score`, `id_siswa`, `score`, `tanggal`, `komentar`) VALUES
(55, 1001, 80, '09-01-2022 05:58:58', 'Nilainya bagus, dan lebih di tingkatkan'),
(56, 1001, 80, '09-01-2022 06:00:24', 'bagus'),
(57, 1001, 40, '09-01-2022 06:04:57', 'Halo'),
(59, 1001, 100, '10-01-2022 11:10:14', 'halo, pertahankan nilainya'),
(60, 1002, 100, '10-01-2022 11:50:50', 'test'),
(61, 1002, 40, '10-01-2022 12:49:35', 'bagus'),
(62, 1001, 20, '10-01-2022 12:50:17', ''),
(63, 1001, 20, '10-01-2022 12:50:23', ''),
(64, 1001, 20, '10-01-2022 12:56:59', ''),
(65, 1001, 40, '10-01-2022 01:01:02', ''),
(66, 1001, 80, '10-01-2022 01:08:26', ''),
(67, 1001, 20, '11-01-2022 06:20:45', 'Bagus Banget'),
(68, 1001, 100, '12-01-2022 01:00:20', ''),
(69, 1001, 60, '12-01-2022 01:12:04', ''),
(70, 1001, 60, '12-01-2022 01:52:57', ''),
(71, 1001, 20, '12-01-2022 02:04:05', ''),
(72, 1002, 20, '12-01-2022 02:05:20', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_siswa`
--

CREATE TABLE `tbl_siswa` (
  `id_siswa` int(11) NOT NULL,
  `password` varchar(30) NOT NULL,
  `nama_siswa` varchar(60) NOT NULL,
  `kelas` varchar(30) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_siswa`
--

INSERT INTO `tbl_siswa` (`id_siswa`, `password`, `nama_siswa`, `kelas`, `email`) VALUES
(1001, '111', 'Davi Rama Fadillah', 'E', 'davi@gmail.co.id'),
(1002, '111', 'Kevin', 'C', 'kevin@gmail.com'),
(1004, '111', 'Andrew Kurniawan', 'D', 'Andrew@gmail.com'),
(1005, '111', 'Brilianto', 'A', 'BR@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_guru`
--
ALTER TABLE `tbl_guru`
  ADD PRIMARY KEY (`id_guru`);

--
-- Indexes for table `tbl_score`
--
ALTER TABLE `tbl_score`
  ADD PRIMARY KEY (`id_score`),
  ADD KEY `id_siswa` (`id_siswa`);

--
-- Indexes for table `tbl_siswa`
--
ALTER TABLE `tbl_siswa`
  ADD PRIMARY KEY (`id_siswa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_score`
--
ALTER TABLE `tbl_score`
  MODIFY `id_score` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_score`
--
ALTER TABLE `tbl_score`
  ADD CONSTRAINT `id_siswa` FOREIGN KEY (`id_siswa`) REFERENCES `tbl_siswa` (`id_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
