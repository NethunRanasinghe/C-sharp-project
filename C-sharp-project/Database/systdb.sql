-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2022 at 09:43 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

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
-- Table structure for table `buy`
--

CREATE TABLE `buy` (
  `id` int(11) NOT NULL,
  `Date` date NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `Type` varchar(30) NOT NULL,
  `woodCnd` varchar(30) NOT NULL,
  `specialNotes` varchar(100) NOT NULL,
  `EstimatedPrice` decimal(10,2) NOT NULL,
  `TotalCost` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buy`
--

INSERT INTO `buy` (`id`, `Date`, `SupplierName`, `Type`, `woodCnd`, `specialNotes`, `EstimatedPrice`, `TotalCost`) VALUES
(1, '2022-04-29', 'Chamara', '(2). As if.', '(3). Damaged.', 'Since the wood is damaged, this is used for auxilary purposes', '10000.00', '10100.00'),
(2, '2022-04-30', 'Nuwan', '(1). Fragmented timber.', '(1). Very Good.', 'This is Fragmented Teakwood.', '100000.00', '112000.00'),
(3, '2022-05-28', 'Sanidu', '(2). As if.', '(1). Very Good.', 'Jackwood Timber', '250000.00', '300000.00'),
(4, '2022-04-30', 'Kusal', '(3). Other.', '(2). Normal.', '', '75000.00', '80000.00'),
(5, '2022-04-30', 'Prasanna', '(1). Fragmented timber.', '(3). Damaged.', 'Damaged sandalwood', '12000.00', '12750.00');

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

-- --------------------------------------------------------

--
-- Table structure for table `otransaction`
--

CREATE TABLE `otransaction` (
  `id` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Service` varchar(50) NOT NULL,
  `AboutService` varchar(50) NOT NULL,
  `EstimatedCost` decimal(10,2) NOT NULL,
  `TotalCost` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `otransaction`
--

INSERT INTO `otransaction` (`id`, `Date`, `Service`, `AboutService`, `EstimatedCost`, `TotalCost`) VALUES
(1, '2022-04-19', '(1) Purchase of new machinery.', 'Bought a Toyota Forklift', '2500000.00', '2505000.00'),
(2, '2022-04-20', '(3) Repair of machinery.', 'Repaired the wood chipper', '5500.00', '5500.00'),
(3, '2022-04-22', '(2) Sale of old machinery.', 'Sold the Old wood Polisher', '12000.00', '12000.00'),
(4, '2022-04-27', '(3) Repair of machinery.', 'Repaired the Drill', '3200.00', '3250.00'),
(5, '2022-04-30', '(1) Purchase of new machinery.', 'Bought a Grinder', '16000.00', '16800.00');

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
  `Value` decimal(10,2) NOT NULL,
  `Other_Services` varchar(100) NOT NULL,
  `Additional_charges` decimal(10,2) NOT NULL,
  `Selling_price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `salesrecords`
--

INSERT INTO `salesrecords` (`ID`, `Date`, `Customer_name`, `Product_type`, `Product_name`, `Value`, `Other_Services`, `Additional_charges`, `Selling_price`) VALUES
(1, '2022-04-01', 'Jagath Chamila', 'Chair', 'Teak High End Chair', '60000.00', 'Transportation', '2500.00', '62500.00'),
(2, '2022-04-03', 'Sarath Karunarathne', 'Cupboard', 'Teak Cupboard', '95500.00', 'Transportation', '300.00', '95800.00'),
(3, '2022-04-04', 'Dilanka Senanayake', 'Table', 'Hardwood 6*4', '12250.00', 'Transportation', '3000.00', '15250.00'),
(4, '2022-04-21', 'Kevin De Silva', 'Chair-set', 'Teak A1 Chair Set', '89000.00', 'Transportation', '3500.00', '92500.00'),
(5, '2022-03-30', 'Sahansa Jayawardhana', 'Chair', 'Teak Chair A1', '40000.00', 'Transportation', '2500.00', '42500.00');

-- --------------------------------------------------------

--
-- Table structure for table `user_details`
--

CREATE TABLE `user_details` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `position` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `enabled` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_details`
--

INSERT INTO `user_details` (`id`, `first_name`, `last_name`, `email`, `position`, `password`, `enabled`) VALUES
(1, 'Nethun', 'Ranasingha', 'nethun223@gmail.com', 'CEO', 'Abcdf@12345', 1),
(2, 'Meth', 'Jaya', 'methjaya252@gmail.com', 'Manager', 'Meth@12345', 1),
(3, 'Sanidu', 'Anupama', 'dlsanupama@students.nsbm.ac.lk', 'Accountant', 'Sani@12345', 0),
(4, 'Senath', 'Kithsara', 'sksenathkithsara@gmail.com', 'Accountant', 'Senath#0900', 1),
(5, 'Sajeewa', 'Wijesinghe', 'Sajeewadw@gmail.com', 'Accountant', 'Sujee%%252252', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user_details_time`
--

CREATE TABLE `user_details_time` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `Time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buy`
--
ALTER TABLE `buy`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer_registration`
--
ALTER TABLE `customer_registration`
  ADD PRIMARY KEY (`nic`);

--
-- Indexes for table `otransaction`
--
ALTER TABLE `otransaction`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `salesrecords`
--
ALTER TABLE `salesrecords`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `user_details`
--
ALTER TABLE `user_details`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_details_time`
--
ALTER TABLE `user_details_time`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `buy`
--
ALTER TABLE `buy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `otransaction`
--
ALTER TABLE `otransaction`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `salesrecords`
--
ALTER TABLE `salesrecords`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user_details`
--
ALTER TABLE `user_details`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user_details_time`
--
ALTER TABLE `user_details_time`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
