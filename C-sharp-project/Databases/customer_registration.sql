-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2022 at 09:08 PM
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
-- Table structure for table `customer_registration`
--

CREATE TABLE `customer_registration` (
  `nic` varchar(20) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `phone_number` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `province` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_registration`
--

INSERT INTO `customer_registration` (`nic`, `first_name`, `last_name`, `address`, `phone_number`, `email`, `province`) VALUES
('12546675', 'user', 'name1', 'no 80,province 1', 998907767, 'user1@gmail.com', 'province1'),
('2', 'a', 'a', 'a', 2, 'a', 'a'),
('v23355778', 'user', '1', 'a', 22679, 't', 'a'),
('v438809523', 'user', '2', 'adresssline 1,adadresssline 1,ad', 566798578, 'ghfdth', 'prov1'),
('v4388095232', 'user', '2', 'xvsawetyxvsawety', 566798578, 'ghfdth', 'prov1'),
('v43880952321', 'user', '2', 'xvsawetyxvsawety', 566798578, 'ghfdth', 'prov1'),
('v2384635079', 'john ', 'doe', 'no 58,street 1 city 2', 2246896, 'johndoe@gmail.com', 'province 1'),
('v23846350792', 'john ', 'doe', 'no 58,street 1 ', 2246896, 'johndoe@gmail.com', 'province 1'),
('v30088954', 'w', 'w', 'w w', 23456, 'a', 'e');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
