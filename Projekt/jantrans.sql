-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas wygenerowania: 24 Cze 2018, 16:20
-- Wersja serwera: 5.5.21-log
-- Wersja PHP: 5.3.20

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `jantrans`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ciezarowki`
--

CREATE TABLE IF NOT EXISTS `ciezarowki` (
  `ID_Pojazdu` int(11) NOT NULL AUTO_INCREMENT,
  `Ladownosc` double NOT NULL,
  `Pojemnosc` double NOT NULL,
  `Rejestracja` text NOT NULL,
  PRIMARY KEY (`ID_Pojazdu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kierowca_zajety`
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
-- Struktura tabeli dla tabeli `kierowcy`
--

CREATE TABLE IF NOT EXISTS `kierowcy` (
  `ID_Kierowcy` int(11) NOT NULL AUTO_INCREMENT,
  `Imie` char(25) DEFAULT NULL,
  `Nazwisko` char(30) DEFAULT NULL,
  `Trasa` double DEFAULT NULL,
  `Ciezarowka` int(11) DEFAULT NULL,
  `Zlecenie` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Kierowcy`),
  KEY `Ciezarowka` (`Ciezarowka`),
  KEY `Zlecenie` (`Zlecenie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Zrzut danych tabeli `kierowcy`
--

INSERT INTO `kierowcy` (`ID_Kierowcy`, `Imie`, `Nazwisko`, `Trasa`, `Ciezarowka`, `Zlecenie`) VALUES
(1, 'Janusz', 'Andrzej', NULL, NULL, NULL),
(2, 'Andrew', 'Janush', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klienci`
--

CREATE TABLE IF NOT EXISTS `klienci` (
  `ID_Klienta` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` char(40) DEFAULT NULL,
  `Imie_wlasciciel` char(25) DEFAULT NULL,
  `Nazwisko_wlasciciel` char(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Klienta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Zrzut danych tabeli `klienci`
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
-- Struktura tabeli dla tabeli `logowanie`
--

CREATE TABLE IF NOT EXISTS `logowanie` (
  `ID_kierowca` int(11) NOT NULL,
  `Typ` enum('admin','user') NOT NULL,
  `Login` text NOT NULL,
  `Haslo` text NOT NULL,
  UNIQUE KEY `ID_kierowca` (`ID_kierowca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `logowanie`
--

INSERT INTO `logowanie` (`ID_kierowca`, `Typ`, `Login`, `Haslo`) VALUES
(1, 'user', 'seksikociak', 'oral69'),
(2, 'admin', 'andrzej', 'duda');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `produkt`
--

CREATE TABLE IF NOT EXISTS `produkt` (
  `ID_Produkt` int(11) NOT NULL AUTO_INCREMENT,
  `Klient` int(11) NOT NULL,
  `Nazwa` text NOT NULL,
  `Waga` double NOT NULL,
  `Objetosc` double NOT NULL,
  PRIMARY KEY (`ID_Produkt`),
  KEY `Klient` (`Klient`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `towar`
--

CREATE TABLE IF NOT EXISTS `towar` (
  `ID_Towaru` int(11) NOT NULL AUTO_INCREMENT,
  `Zlecenie` int(11) DEFAULT NULL,
  `Produkt` int(11) NOT NULL,
  PRIMARY KEY (`ID_Towaru`),
  KEY `Klient` (`Zlecenie`),
  KEY `Produkt` (`Produkt`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zlecenia`
--

CREATE TABLE IF NOT EXISTS `zlecenia` (
  `ID_Zlecenia` int(11) NOT NULL AUTO_INCREMENT,
  `Kierowca` int(11) DEFAULT NULL,
  `trasa` double DEFAULT NULL,
  `Koszt` double DEFAULT NULL,
  `Z` text NOT NULL,
  `Do` text NOT NULL,
  `Data_wyj` date NOT NULL,
  `Data_pow` date NOT NULL,
  `Pozostala_Ladownosc` double NOT NULL,
  `Pozostala_Pojemnosc` double NOT NULL,
  PRIMARY KEY (`ID_Zlecenia`),
  KEY `Kierowca` (`Kierowca`),
  KEY `Kierowca_2` (`Kierowca`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Wyzwalacze `zlecenia`
--
DROP TRIGGER IF EXISTS `dodajkoszt`;
DELIMITER //
CREATE TRIGGER `dodajkoszt` BEFORE INSERT ON `zlecenia`
 FOR EACH ROW set new.Koszt = (new.Trasa * 24.99)
//
DELIMITER ;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `kierowca_zajety`
--
ALTER TABLE `kierowca_zajety`
  ADD CONSTRAINT `kierowca_zajety_ibfk_1` FOREIGN KEY (`Id_kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`);

--
-- Ograniczenia dla tabeli `kierowcy`
--
ALTER TABLE `kierowcy`
  ADD CONSTRAINT `kierowcy_ibfk_1` FOREIGN KEY (`Ciezarowka`) REFERENCES `ciezarowki` (`ID_Pojazdu`),
  ADD CONSTRAINT `kierowcy_ibfk_2` FOREIGN KEY (`Zlecenie`) REFERENCES `zlecenia` (`ID_Zlecenia`);

--
-- Ograniczenia dla tabeli `logowanie`
--
ALTER TABLE `logowanie`
  ADD CONSTRAINT `logowanie_ibfk_1` FOREIGN KEY (`ID_kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`);

--
-- Ograniczenia dla tabeli `produkt`
--
ALTER TABLE `produkt`
  ADD CONSTRAINT `produkt_ibfk_1` FOREIGN KEY (`Klient`) REFERENCES `klienci` (`ID_Klienta`);

--
-- Ograniczenia dla tabeli `towar`
--
ALTER TABLE `towar`
  ADD CONSTRAINT `towar_ibfk_1` FOREIGN KEY (`Zlecenie`) REFERENCES `zlecenia` (`ID_Zlecenia`),
  ADD CONSTRAINT `towar_ibfk_2` FOREIGN KEY (`Produkt`) REFERENCES `produkt` (`ID_Produkt`);

--
-- Ograniczenia dla tabeli `zlecenia`
--
ALTER TABLE `zlecenia`
  ADD CONSTRAINT `zlecenia_ibfk_2` FOREIGN KEY (`Kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
