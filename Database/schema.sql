-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pameryuk
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pesan` text NOT NULL,
  `tglTerkirim` datetime NOT NULL,
  `pengirim` varchar(40) NOT NULL,
  `penerima` varchar(40) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Chats_User1_idx` (`pengirim`),
  KEY `fk_Chats_User2_idx` (`penerima`),
  CONSTRAINT `fk_Chats_User1` FOREIGN KEY (`pengirim`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Chats_User2` FOREIGN KEY (`penerima`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
INSERT INTO `chat` VALUES (1,'gas, masuk?','2025-01-11 19:26:47','yanto','bagas'),(2,'gas, masuk?','2025-01-11 19:26:49','yanto','bagas'),(3,'gas, masuk?','2025-01-11 19:26:50','yanto','bagas'),(4,'masuk','2025-01-11 19:29:02','bagas','yanto');
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kisahhidup`
--

DROP TABLE IF EXISTS `kisahhidup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kisahhidup` (
  `Organisasi_id` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  `thawal` varchar(4) DEFAULT NULL,
  `thakhir` varchar(4) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL,
  PRIMARY KEY (`Organisasi_id`,`username`),
  KEY `fk_Organisasi_username_username1_idx` (`username`),
  KEY `fk_Organisasi_username_Organisasi1_idx` (`Organisasi_id`),
  CONSTRAINT `fk_Organisasi_username_Organisasi1` FOREIGN KEY (`Organisasi_id`) REFERENCES `organisasi` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Organisasi_username_username1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kisahhidup`
--

LOCK TABLES `kisahhidup` WRITE;
/*!40000 ALTER TABLE `kisahhidup` DISABLE KEYS */;
INSERT INTO `kisahhidup` VALUES (-1,'bagas','2024','2024','Capek'),(-1,'budi','2024','2024','Budiii'),(-1,'yanto','2024','2024','Database mantap');
/*!40000 ALTER TABLE `kisahhidup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `komen`
--

DROP TABLE IF EXISTS `komen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `komen` (
  `id` int(11) NOT NULL,
  `Komentar` text DEFAULT NULL,
  `tgl` datetime DEFAULT NULL,
  `username` varchar(40) NOT NULL,
  `Konten_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Komen_User1_idx` (`username`),
  KEY `fk_Komen_Konten1_idx` (`Konten_id`),
  CONSTRAINT `fk_Komen_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Komen_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `komen`
--

LOCK TABLES `komen` WRITE;
/*!40000 ALTER TABLE `komen` DISABLE KEYS */;
/*!40000 ALTER TABLE `komen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konten`
--

DROP TABLE IF EXISTS `konten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konten` (
  `id` int(11) NOT NULL,
  `caption` text DEFAULT NULL,
  `foto` varchar(45) DEFAULT NULL,
  `video` varchar(45) DEFAULT NULL,
  `tglUpload` datetime DEFAULT NULL,
  `username` varchar(40) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Konten_User1_idx` (`username`),
  CONSTRAINT `fk_Konten_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konten`
--

LOCK TABLES `konten` WRITE;
/*!40000 ALTER TABLE `konten` DISABLE KEYS */;
INSERT INTO `konten` VALUES (2,'Bersama Yanto','C:\\PamerYuk\\bagasx20250111193130x2.jpg','null','2025-01-11 19:31:30','bagas');
/*!40000 ALTER TABLE `konten` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kota`
--

DROP TABLE IF EXISTS `kota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kota` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kota`
--

LOCK TABLES `kota` WRITE;
/*!40000 ALTER TABLE `kota` DISABLE KEYS */;
INSERT INTO `kota` VALUES (1,'Surabaya'),(2,'Jakarta'),(3,'Tokyo'),(4,'Malang'),(5,'Denpasar');
/*!40000 ALTER TABLE `kota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `like`
--

DROP TABLE IF EXISTS `like`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `like` (
  `username` varchar(40) NOT NULL,
  `Konten_id` int(11) NOT NULL,
  PRIMARY KEY (`username`,`Konten_id`),
  KEY `fk_User_has_Konten_Konten1_idx` (`Konten_id`),
  KEY `fk_User_has_Konten_User1_idx` (`username`),
  CONSTRAINT `fk_User_has_Konten_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_has_Konten_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `like`
--

LOCK TABLES `like` WRITE;
/*!40000 ALTER TABLE `like` DISABLE KEYS */;
INSERT INTO `like` VALUES ('bagas',2);
/*!40000 ALTER TABLE `like` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `organisasi`
--

DROP TABLE IF EXISTS `organisasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `organisasi` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `Kota_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Organisasi_Kota_idx` (`Kota_id`),
  CONSTRAINT `fk_Organisasi_Kota` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `organisasi`
--

LOCK TABLES `organisasi` WRITE;
/*!40000 ALTER TABLE `organisasi` DISABLE KEYS */;
INSERT INTO `organisasi` VALUES (-1,'Ubaya',1);
/*!40000 ALTER TABLE `organisasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag`
--

DROP TABLE IF EXISTS `tag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tag` (
  `Konten_id` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  PRIMARY KEY (`Konten_id`,`username`),
  KEY `fk_Konten_User_User1_idx` (`username`),
  KEY `fk_Konten_User_Konten1_idx` (`Konten_id`),
  CONSTRAINT `fk_Konten_User_Konten1` FOREIGN KEY (`Konten_id`) REFERENCES `konten` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Konten_User_User1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag`
--

LOCK TABLES `tag` WRITE;
/*!40000 ALTER TABLE `tag` DISABLE KEYS */;
INSERT INTO `tag` VALUES (2,'yanto');
/*!40000 ALTER TABLE `tag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teman`
--

DROP TABLE IF EXISTS `teman`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teman` (
  `username1` varchar(40) NOT NULL,
  `username2` varchar(40) NOT NULL,
  `tglBerteman` date DEFAULT NULL,
  `statusPertemanan` enum('Menunggu','Berteman','Ditolak','Diblokir') DEFAULT NULL,
  PRIMARY KEY (`username1`,`username2`),
  KEY `fk_User_User_User2_idx` (`username2`),
  KEY `fk_User_User_User1_idx` (`username1`),
  CONSTRAINT `fk_User_User_User1` FOREIGN KEY (`username1`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_User_User2` FOREIGN KEY (`username2`) REFERENCES `user` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teman`
--

LOCK TABLES `teman` WRITE;
/*!40000 ALTER TABLE `teman` DISABLE KEYS */;
INSERT INTO `teman` VALUES ('yanto','bagas','2025-01-11','Berteman');
/*!40000 ALTER TABLE `teman` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `username` varchar(40) NOT NULL,
  `password` varchar(128) DEFAULT NULL,
  `namaLengkap` varchar(45) DEFAULT NULL,
  `tglLahir` date DEFAULT NULL,
  `noKTP` varchar(16) DEFAULT NULL,
  `fotoDiri` varchar(45) DEFAULT NULL,
  `fotoProfil` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `Kota_id` int(11) NOT NULL,
  PRIMARY KEY (`username`),
  KEY `fk_User_Kota1_idx` (`Kota_id`),
  CONSTRAINT `fk_User_Kota1` FOREIGN KEY (`Kota_id`) REFERENCES `kota` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('bagas','bagas','bagas','2025-01-11','bagas','C:\\PamerYuk\\bagasxPFDx20250111155001.jpg','C:\\PamerYuk\\bagasxPFPx20250111155001.jpg','bagas',1),('budi','budi','a','2025-01-11','a','C:\\PamerYuk\\budixPFDx20250111194056.jpg','C:\\PamerYuk\\budixPFPx20250111194056.jpg','a',1),('yanto','yanto','yanto','2025-01-11','1234567890','C:\\PamerYuk\\yantoxPFDx20250111185748.jpg','C:\\PamerYuk\\yantoxPFPx20250111185748.jpg','yanto',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-11 19:51:11
