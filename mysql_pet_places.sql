-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 01, 2022 at 11:12 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mysql_pet_places`
--

-- --------------------------------------------------------

--
-- Table structure for table `pet_table`
--

CREATE TABLE `pet_table` (
  `ID` int(11) NOT NULL,
  `AnimalType` varchar(100) NOT NULL,
  `PetName` varchar(100) NOT NULL,
  `Breed` varchar(100) NOT NULL,
  `Colour` varchar(50) NOT NULL,
  `Suburb` varchar(100) NOT NULL,
  `OwnerName` varchar(100) NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pet_table`
--

INSERT INTO `pet_table` (`ID`, `AnimalType`, `PetName`, `Breed`, `Colour`, `Suburb`, `OwnerName`, `CreatedAt`) VALUES
(20, 'asdasd', 'asd', 'ads', 'ads', 'ads', 'ads', '2022-11-01 09:51:33'),
(21, 'Cat', 'Lucky', 'French Bulldog', 'Brindle', 'Mira Mar', 'Talitha', '2022-11-01 09:58:37');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pet_table`
--
ALTER TABLE `pet_table`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pet_table`
--
ALTER TABLE `pet_table`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
