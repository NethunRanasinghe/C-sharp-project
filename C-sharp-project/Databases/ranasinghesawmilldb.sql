-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 22, 2022 at 06:40 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ranasinghesawmilldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `salesrecords`
--

DROP TABLE IF EXISTS `salesrecords`;
CREATE TABLE IF NOT EXISTS `salesrecords` (
  `Customer_ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Customer_name` varchar(100) NOT NULL,
  `Product_type` varchar(100) NOT NULL,
  `Wood_type` varchar(100) NOT NULL,
  `Estimation` float NOT NULL,
  `Other_Services` varchar(100) NOT NULL,
  `Additional_charges` float NOT NULL,
  `Extra_charges` float NOT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
