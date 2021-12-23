-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 23, 2021 at 07:04 AM
-- Server version: 10.5.12-MariaDB-0+deb11u1
-- PHP Version: 7.4.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ProjectTesteDatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `Pessoas`
--

CREATE TABLE `Pessoas` (
  `id` int(11) NOT NULL,
  `nome` varchar(10) NOT NULL,
  `sobrenome` varchar(10) DEFAULT NULL,
  `idade` int(3) NOT NULL,
  `tipo_consulta` varchar(10) NOT NULL,
  `horario_consulta` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Pessoas`
--

INSERT INTO `Pessoas` (`id`, `nome`, `sobrenome`, `idade`, `tipo_consulta`, `horario_consulta`) VALUES
(1, 'Érick', 'Solon', 20, 'cirurgia', '2021-12-24 09:27:02'),
(2, 'Vanessa', 'Lima', 20, 'psicologo', '2021-12-25 09:27:28'),
(3, 'Jussara', 'Bezerra', 25, 'psicologo', '2021-12-26 09:28:06'),
(4, 'Mauro', 'Bezerra', 25, 'psiquiatra', '2021-12-27 09:28:17'),
(5, 'Daniel', 'Bezerra', 25, 'cirurgia', '2021-12-27 09:28:30'),
(6, 'Daniel', 'Lima', 25, 'cirurgia', '2021-12-24 09:28:46');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Pessoas`
--
ALTER TABLE `Pessoas`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Pessoas`
--
ALTER TABLE `Pessoas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
