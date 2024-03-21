-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 21, 2024 at 01:53 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rentalproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `CarID` int(11) NOT NULL,
  `carName` varchar(225) DEFAULT NULL,
  `Year` int(11) NOT NULL,
  `Capacity` int(11) NOT NULL,
  `Transmission` varchar(30) DEFAULT NULL,
  `TopSpeed` varchar(10) DEFAULT NULL,
  `ImageUrl` varchar(255) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Category` varchar(10) DEFAULT NULL,
  `mileage` int(11) DEFAULT NULL,
  `rate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`CarID`, `carName`, `Year`, `Capacity`, `Transmission`, `TopSpeed`, `ImageUrl`, `Description`, `Category`, `mileage`, `rate`) VALUES
(1, 'Toyota Corolla', 2024, 5, 'Automatic', '140 mph', 'https://images.unsplash.com/photo-1619682817481-e994891cd1f5?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8VG95b3RhJTIwY29yb2xsYXxlbnwwfHwwfHx8MA%3D%3D', 'The world\'s best-selling car, known for its reliability and fuel efficiency.', 'Sedan', 20000, 1500),
(2, 'Honda Civic', 2024, 5, 'CVT', '130 mph', 'https://images.unsplash.com/photo-1594070319944-7c0cbebb6f58?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8aG9uZGElMjBjaXZpY3xlbnwwfHwwfHx8MA%3D%3D', 'A sporty and fuel-efficient compact car with a fun driving experience.', 'Sedan', 18000, 1000),
(3, 'Ford F-150', 2024, 6, 'Automatic', '110 mph', 'https://images.unsplash.com/photo-1605893477799-b99e3b8b93fe?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Zm9yZCUyMGYxNTB8ZW58MHx8MHx8fDA%3D', 'The best-selling truck in America, offering power, capability, and various configurations.', 'Truck', 30000, 2500),
(4, 'Chevrolet Silverado', 2024, 6, 'Automatic', '110 mph', 'https://images.unsplash.com/photo-1645830122484-e0aa9955456a?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8N3x8Q2hldnJvbGV0JTIwU2lsdmVyYWRvfGVufDB8fDB8fHww', 'A strong contender in the full-size truck segment, known for its towing capacity and comfort.', 'Truck', 27000, 3000),
(5, 'Toyota RAV4', 2024, 5, 'Automatic', '115 mph', 'https://images.unsplash.com/photo-1706509234538-9831b1b33d66?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8VG95b3RhJTIwcmF2NHxlbnwwfHwwfHx8MA%3D%3D', 'A popular compact SUV offering a blend of practicality, fuel efficiency, and capability.', 'SUV', 22000, 2000),
(6, 'Honda CR-V', 2024, 5, 'CVT', '115 mph', 'https://images.unsplash.com/photo-1623597780975-38ccd5030c83?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fEhvbmRhJTIwY3J2fGVufDB8fDB8fHww', 'Spacious and comfortable SUV known for its reliability and safety features.', 'SUV', 24000, 1700),
(7, 'Tesla Model 3', 2024, 5, 'Automatic', '162 mph', 'https://images.unsplash.com/photo-1560958089-b8a1929cea89?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8VGVzbGElMjBtb2RlbCUyMDN8ZW58MHx8MHx8fDA%3D', 'A sleek and powerful electric car with long range and impressive performance.', 'Electric', 15000, 4000),
(8, 'Tesla Model Y', 2024, 5, 'Automatic', '155 mph', 'https://images.unsplash.com/photo-1619317222672-9bd411411d63?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8VGVzbGElMjBtb2RlbCUyMFl8ZW58MHx8MHx8fDA%3D', 'A spacious and versatile electric SUV offering luxury features and long range.', 'Electric', 10000, 5000),
(9, 'Nissan Altima', 2024, 5, 'CVT', '130 mph', 'https://images.unsplash.com/photo-1581540222194-0def2dda95b8?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8Tmlzc2FuJTIwQWx0aW1hfGVufDB8fDB8fHww', 'A stylish and comfortable mid-size sedan with a focus on fuel efficiency.', 'Sedan', 19000, 3200),
(10, 'Hyundai Sonata', 2024, 5, 'Automatic', '140 mph', 'https://images.unsplash.com/photo-1681361270520-4cc3961d3b00?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8SHl1bmRhaSUyMFNvbmF0YXxlbnwwfHwwfHx8MA%3D%3D', 'A feature-rich mid-size sedan offering a compelling value proposition.', 'Sedan', 17000, 2300);

-- --------------------------------------------------------

--
-- Table structure for table `rent_history`
--

CREATE TABLE `rent_history` (
  `rentID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `carID` int(11) NOT NULL,
  `rentStart` datetime NOT NULL,
  `rentEnd` datetime NOT NULL,
  `rentDuration` int(11) NOT NULL,
  `TotalPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rent_history`
--

INSERT INTO `rent_history` (`rentID`, `userID`, `carID`, `rentStart`, `rentEnd`, `rentDuration`, `TotalPrice`) VALUES
(2, 7, 9, '2024-03-22 10:06:12', '2024-03-23 10:06:12', 2, 6400),
(3, 5, 9, '2024-03-22 10:06:12', '2024-03-23 10:06:12', 2, 6400),
(4, 3, 5, '2024-03-23 10:06:12', '2024-03-24 10:06:12', 3, 6000),
(6, 1, 7, '2024-03-21 11:04:21', '2024-03-21 11:04:21', 2, 8000),
(7, 0, 4, '2024-03-21 11:04:21', '2024-03-21 11:04:21', 2, 6000),
(8, 16, 5, '2024-03-29 11:36:37', '2024-03-30 11:36:37', 2, 4000),
(9, 16, 4, '2024-03-22 11:40:24', '2024-03-23 11:40:24', 2, 6000),
(10, 17, 7, '2023-03-21 22:00:57', '2024-03-21 12:00:57', 2, 8000),
(11, 18, 10, '2024-03-22 23:30:27', '2024-03-22 02:30:27', 4, 9200),
(12, 19, 10, '2024-03-22 23:30:27', '2024-03-22 05:30:27', 6, 13800),
(13, 17, 4, '2024-03-22 01:30:27', '2024-03-22 04:30:27', 3, 9000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `PhoneNumber` int(15) NOT NULL,
  `National_ID` int(15) NOT NULL,
  `LicenseNumber` varchar(10) NOT NULL,
  `is_Admin` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Name`, `Email`, `Password`, `PhoneNumber`, `National_ID`, `LicenseNumber`, `is_Admin`) VALUES
(1, 'Admin User', 'admin@gmail.com', '4a0fc034e740a4acbe94a405ace6e4bec28da4a6125bd6e8e9cdbc0efc4c55b5', 706934606, 123456789, 'LLL-NNNL', 1),
(16, 'Wendy Mukami', 'wendy@kabarak.ac.ke', '@IamWendy1234', 707392838, 39284203, 'CGJ-584D', 1),
(17, 'Joy Chebet', 'joy@kabarak.ac.ke', '@IamJoy1234', 707392853, 39284258, 'CGJ-5564D', 1),
(18, 'Lydia Manyeki', 'manyeki@kabarak.ac.ke', '@IamManyeki1234', 705833488, 39284386, 'CGJ-502D', 1),
(19, 'Doreen Korir', 'doreen@kabarak.ac.ke', '@IamDoreen1234', 798393967, 58260284, 'OTS-752', 1),
(20, 'ALLAN LENGIMA', 'lengima@kabarak.ac.ke', '4619f752488969dd499a3e01e1f91e28748b2037bb5770ee869d113dec075b96', 743575786, 57392759, 'CMD-953D', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`CarID`);

--
-- Indexes for table `rent_history`
--
ALTER TABLE `rent_history`
  ADD PRIMARY KEY (`rentID`),
  ADD KEY `user_ID_fk` (`userID`),
  ADD KEY `car_ID_fk` (`carID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `National_ID` (`National_ID`),
  ADD UNIQUE KEY `LicenseNumber` (`LicenseNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `CarID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `rent_history`
--
ALTER TABLE `rent_history`
  MODIFY `rentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
