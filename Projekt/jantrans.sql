-- MySQL dump 10.13  Distrib 5.5.21, for Win32 (x86)
--
-- Host: localhost    Database: jantrans
-- ------------------------------------------------------
-- Server version	5.5.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ciezarowki`
--

DROP TABLE IF EXISTS `ciezarowki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciezarowki` (
  `ID_Pojazdu` int(11) NOT NULL AUTO_INCREMENT,
  `Ladownosc` int(11) DEFAULT NULL,
  `Pojemnosc` int(11) DEFAULT NULL,
  `Rejestracja` text NOT NULL,
  PRIMARY KEY (`ID_Pojazdu`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciezarowki`
--

LOCK TABLES `ciezarowki` WRITE;
/*!40000 ALTER TABLE `ciezarowki` DISABLE KEYS */;
INSERT INTO `ciezarowki` VALUES (1,2137,88,'SGLKEK'),(2,1500,50,'SZ2137E'),(3,1480,25,'SGL997JP'),(4,1500,50,'SZ2137E'),(5,1480,25,'SGL997JP');
/*!40000 ALTER TABLE `ciezarowki` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kierowca_zajety`
--

DROP TABLE IF EXISTS `kierowca_zajety`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kierowca_zajety` (
  `Id_dat` int(11) NOT NULL AUTO_INCREMENT,
  `Id_kierowca` int(11) NOT NULL,
  `Data_pocz` date NOT NULL,
  `Data_kon` date NOT NULL,
  PRIMARY KEY (`Id_dat`),
  KEY `Id_kierowca` (`Id_kierowca`),
  CONSTRAINT `kierowca_zajety_ibfk_1` FOREIGN KEY (`Id_kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kierowca_zajety`
--

LOCK TABLES `kierowca_zajety` WRITE;
/*!40000 ALTER TABLE `kierowca_zajety` DISABLE KEYS */;
/*!40000 ALTER TABLE `kierowca_zajety` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kierowcy`
--

DROP TABLE IF EXISTS `kierowcy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kierowcy` (
  `ID_Kierowcy` int(11) NOT NULL AUTO_INCREMENT,
  `Imie` char(25) DEFAULT NULL,
  `Nazwisko` char(30) DEFAULT NULL,
  `Trasa` int(11) DEFAULT NULL,
  `Ciezarowka` int(11) DEFAULT NULL,
  `Zlecenie` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Kierowcy`),
  KEY `Ciezarowka` (`Ciezarowka`),
  KEY `Zlecenie` (`Zlecenie`),
  CONSTRAINT `kierowcy_ibfk_1` FOREIGN KEY (`Ciezarowka`) REFERENCES `ciezarowki` (`ID_Pojazdu`),
  CONSTRAINT `kierowcy_ibfk_2` FOREIGN KEY (`Zlecenie`) REFERENCES `zlecenia` (`ID_Zlecenia`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kierowcy`
--

LOCK TABLES `kierowcy` WRITE;
/*!40000 ALTER TABLE `kierowcy` DISABLE KEYS */;
INSERT INTO `kierowcy` VALUES (1,'Janusz','Andrzej',911,NULL,NULL),(2,'Andrew','Janush',1488,NULL,NULL),(3,'Hans','Kloss',3400,5,NULL),(4,'Jan','Skrzetuski',1644,3,NULL);
/*!40000 ALTER TABLE `kierowcy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klienci`
--

DROP TABLE IF EXISTS `klienci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klienci` (
  `ID_Klienta` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` char(40) DEFAULT NULL,
  `Imie_wlasciciel` char(25) DEFAULT NULL,
  `Nazwisko_wlasciciel` char(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Klienta`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klienci`
--

LOCK TABLES `klienci` WRITE;
/*!40000 ALTER TABLE `klienci` DISABLE KEYS */;
INSERT INTO `klienci` VALUES (1,'MirServ','Miroslaw','Karcewicz'),(2,'CVector','Zenon','Uraga'),(3,'Umbrella Corporation','Oswell','Spencer'),(4,'Monsters Inc.','James P.','Sullivan'),(5,'BlasTech Industries','Mara','Jade'),(6,'Elektroda','Janusz','Tracz'),(7,'Nor-Mic','Sebastian','Anon');
/*!40000 ALTER TABLE `klienci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logowanie`
--

DROP TABLE IF EXISTS `logowanie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logowanie` (
  `ID_kierowca` int(11) NOT NULL,
  `Typ` enum('admin','user') NOT NULL,
  `Login` text NOT NULL,
  `Haslo` text NOT NULL,
  UNIQUE KEY `ID_kierowca` (`ID_kierowca`),
  CONSTRAINT `logowanie_ibfk_1` FOREIGN KEY (`ID_kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logowanie`
--

LOCK TABLES `logowanie` WRITE;
/*!40000 ALTER TABLE `logowanie` DISABLE KEYS */;
INSERT INTO `logowanie` VALUES (1,'user','seksikociak','oral69'),(3,'admin','andrzej','duda');
/*!40000 ALTER TABLE `logowanie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `towar`
--

DROP TABLE IF EXISTS `towar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `towar` (
  `ID_Towaru` int(11) NOT NULL AUTO_INCREMENT,
  `Klient` int(11) DEFAULT NULL,
  `Waga` int(11) DEFAULT NULL,
  `Objetosc` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Towaru`),
  KEY `Klient` (`Klient`),
  CONSTRAINT `towar_ibfk_1` FOREIGN KEY (`Klient`) REFERENCES `klienci` (`ID_Klienta`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `towar`
--

LOCK TABLES `towar` WRITE;
/*!40000 ALTER TABLE `towar` DISABLE KEYS */;
INSERT INTO `towar` VALUES (1,1,21,37),(2,2,88,14),(3,5,333,121),(4,4,8,0),(5,2,100,1000),(6,7,3000,10),(7,5,60,45);
/*!40000 ALTER TABLE `towar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zlecenia`
--

DROP TABLE IF EXISTS `zlecenia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zlecenia` (
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
  KEY `Kierowca` (`Kierowca`),
  CONSTRAINT `zlecenia_ibfk_1` FOREIGN KEY (`Towar`) REFERENCES `towar` (`ID_Towaru`),
  CONSTRAINT `zlecenia_ibfk_2` FOREIGN KEY (`Kierowca`) REFERENCES `kierowcy` (`ID_Kierowcy`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zlecenia`
--

LOCK TABLES `zlecenia` WRITE;
/*!40000 ALTER TABLE `zlecenia` DISABLE KEYS */;
INSERT INTO `zlecenia` VALUES (1,2,3,206,5148,'Kraków','Zielona Góra','2018-06-13','2018-06-14');
/*!40000 ALTER TABLE `zlecenia` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dodajkoszt` BEFORE INSERT ON `zlecenia`
 FOR EACH ROW set new.Koszt = (new.Trasa * 24.99) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-23 11:39:35
