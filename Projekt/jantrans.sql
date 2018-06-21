-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 21, 2018 at 03:56 PM
-- Server version: 5.5.21-log
-- PHP Version: 5.3.20

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `jantrans`
--

-- --------------------------------------------------------

--
-- Table structure for table `ciezarowki`
--

CREATE TABLE IF NOT EXISTS `ciezarowki` (
  `ID_Pojazdu` int(11) NOT NULL AUTO_INCREMENT,
  `Ladownosc` int(11) DEFAULT NULL,
  `Pojemnosc` int(11) DEFAULT NULL,
  `Rejestracja` text NOT NULL,
  PRIMARY KEY (`ID_Pojazdu`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `ciezarowki`
--

INSERT INTO `ciezarowki` (`ID_Pojazdu`, `Ladownosc`, `Pojemnosc`, `Rejestracja`) VALUES
(2, 1500, 50, 'SZ2137E'),
(3, 1480, 25, 'SGL997JP'),
(4, 1500, 50, 'SZ2137E'),
(5, 1480, 25, 'SGL997JP');

-- --------------------------------------------------------

--
-- Table structure for table `kierowca_zajety`
--

CREATE TABLE IF NOT EXISTS `kierowca_zajety` (
  `Id_dat` int(11) NOT NULL AUTO_INCREMENT,
  `Id_kierowca` int(11) NOT NULL,
  `Data_pocz` date NOT NULL,
  `Data_kon` date NOT NULL,
  PRIMARY KEY (`Id_dat`),
  KEY `Id_kierowca` (`Id_kierowca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `kierowcy`
--

CREATE TABLE IF NOT EXISTS `kierowcy` (
  `ID_Kierowcy` int(11) NOT NULL AUTO_INCREMENT,
  `Imie` char(25) DEFAULT NULL,
  `Nazwisko` char(30) DEFAULT NULL,
  `Trasa` int(11) DEFAULT NULL,
  `Ciezarowka` int(11) DEFAULT NULL,
  `Zlecenie` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Kierowcy`),
  KEY `Ciezarowka` (`Ciezarowka`),
  KEY `Zlecenie` (`Zlecenie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `kierowcy`
--

INSERT INTO `kierowcy` (`ID_Kierowcy`, `Imie`, `Nazwisko`, `Trasa`, `Ciezarowka`, `Zlecenie`) VALUES
(1, 'Janusz', 'Andrzej', 911, NULL, NULL),
(2, 'Andrew', 'Janush', 1488, NULL, NULL),
(3, 'Hans', 'Kloss', 3400, 5, NULL),
(4, 'Jan', 'Skrzetuski', 1644, 3, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `klienci`
--

CREATE TABLE IF NOT EXISTS `klienci` (
  `ID_Klienta` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` char(40) DEFAULT NULL,
  `Imie_wlasciciel` char(25) DEFAULT NULL,
  `Nazwisko_wlasciciel` char(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Klienta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `klienci`
--

INSERT INTO `klienci` (`ID_Klienta`, `nazwa`, `Imie_wlasciciel`, `Nazwisko_wlasciciel`) VALUES
(1, 'MirServ', 'Miroslaw', 'Karcewicz'),
(2, 'CVector', 'Zenon', 'Uraga'),
(3, 'Umbrella Corporation', 'Oswell', 'Spencer'),
(4, 'Monsters Inc.', 'James P.', 'Sullivan'),
(5, 'BlasTech Industries', 'Mara', 'Jade'),
(6, 'Elektroda', 'Janusz', 'Tracz'),
(7, 'Nor-Mic', 'Sebastian', 'Anon');

-- --------------------------------------------------------

--
-- Table structure for table `towar`
--

CREATE TABLE IF NOT EXISTS `towar` (
  `ID_Towaru` int(11) NOT NULL AUTO_INCREMENT,
  `Klient` int(11) DEFAULT NULL,
  `Waga` int(11) DEFAULT NULL,
  `Objetosc` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Towaru`),
  KEY `Klient` (`Klient`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `towar`
--

INSERT INTO `towar` (`ID_Towaru`, `Klient`, `Waga`, `Objetosc`) VALUES
(1, 1, 21, 37),
(2, 2, 88, 14),
(3, 5, 333, 121),
(4, 4, 8, 0),
(5, 2, 100, 1000),
(6, 7, 3000, 10),
(7, 5, 60, 45);

-- --------------------------------------------------------

--
-- Table structure for table `zlecenia`
--

CREATE TABLE IF NOT EXISTS `zlecenia` (
  `ID_Zlecenia` int(11) NOT NULL AUTO_INCREMENT,
  `Towar` int(11) DEFAULT NULL,
  `Kierowca` int(11) DEFAULT NULL,
  `Trasa` int(11) DEFAULT NULL,
  `Koszt` int(11) NOT NULL,
  `Z` text NOT NULL,
  `Do` text NOT NULL,
  `Data_wyj` date NOT NULL,
  `Data_pow` date NOT NULL,
  PRIMARY KEY (`ID_Zlecenia`),
  KEY `Towar` (`Towar`),
  KEY `Kierowca` (`Kierowca`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `zlecenia`
--

INSERT INTO `zlecenia` (`ID_Zlecenia`, `Towar`, `Kierowca`, `Trasa`, `Koszt`, `Z`, `Do`, `Data_wyj`, `Data_pow`) VALUES
(1, 2, 3, 206, 5148, 'Kraków', 'Zielona Góra', '2018-06-13', '2018-06-14');

--
-- Triggers `zlecenia`
--
DROP TRIGGER IF EXISTS `dodajkoszt`;
DELIMITER //
CREATE TRIGGER `dodajkoszt` BEFORE INSERT ON `zlecenia`
 FOR EACH ROW set new.Koszt = (new.Trasa * 24.99)
//
DELIMITER ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kierowca_zajety`
--
ALTER TABLE `kierowca_zajety`
  ADD CONSTRAINT `kierowca_zajety_ibfk_1` FOREIGN KEY (`Id_kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`);

--
-- Constraints for table `kierowcy`
--
ALTER TABLE `kierowcy`
  ADD CONSTRAINT `kierowcy_ibfk_1` FOREIGN KEY (`Ciezarowka`) REFERENCES `ciezarowki` (`ID_Pojazdu`),
  ADD CONSTRAINT `kierowcy_ibfk_2` FOREIGN KEY (`Zlecenie`) REFERENCES `zlecenia` (`ID_Zlecenia`);

--
-- Constraints for table `towar`
--
ALTER TABLE `towar`
  ADD CONSTRAINT `towar_ibfk_1` FOREIGN KEY (`Klient`) REFERENCES `klienci` (`ID_Klienta`);

--
-- Constraints for table `zlecenia`
--
ALTER TABLE `zlecenia`
  ADD CONSTRAINT `zlecenia_ibfk_1` FOREIGN KEY (`Towar`) REFERENCES `towar` (`ID_Towaru`),
  ADD CONSTRAINT `zlecenia_ibfk_2` FOREIGN KEY (`Kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
