-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2022 at 01:05 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `systdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `salesrecords`
--

CREATE TABLE `salesrecords` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Customer_name` varchar(100) NOT NULL,
  `Product_type` varchar(100) NOT NULL,
  `Product_name` varchar(100) NOT NULL,
  `Selling_price` float NOT NULL,
  `Other_Services` varchar(100) NOT NULL,
  `Additional_charges` float NOT NULL,
  `Value` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salesrecords`
--

INSERT INTO `salesrecords` (`ID`, `Date`, `Customer_name`, `Product_type`, `Product_name`, `Selling_price`, `Other_Services`, `Additional_charges`, `Value`) VALUES
(1, '2022-04-26', 'name1', 'wood', 'hardwood', 20000, 'na', 100, 5000),
(2, '2022-03-26', 'name2', 'wd', 'hwd', 5000, 'n', 200, 1000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `salesrecords`
--
ALTER TABLE `salesrecords`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
