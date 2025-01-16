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
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
INSERT INTO `chat` VALUES (1,'gas, masuk?','2025-01-11 19:26:47','yanto','bagas'),(2,'gas, masuk?','2025-01-11 19:26:49','yanto','bagas'),(3,'gas, masuk?','2025-01-11 19:26:50','yanto','bagas'),(4,'masuk','2025-01-11 19:29:02','bagas','yanto'),(5,'aku','2025-01-15 18:13:16','bagas','yanto'),(6,'aku','2025-01-15 18:13:20','bagas','yanto'),(7,'coba','2025-01-15 18:16:10','bagas','yanto'),(8,'kirim','2025-01-15 18:16:14','bagas','yanto'),(9,'kamu ','2025-01-15 18:16:17','bagas','yanto'),(10,'chat','2025-01-15 18:16:21','bagas','yanto'),(11,'masuk','2025-01-15 18:16:29','bagas','yanto'),(12,'nggak?','2025-01-15 18:16:34','bagas','yanto'),(13,'yanto?','2025-01-15 18:17:21','bagas','yanto'),(14,'masuk gaaa?','2025-01-15 18:17:24','bagas','yanto'),(15,'aku kok dighosting','2025-01-15 18:17:31','bagas','yanto'),(16,'kamu marah ya?','2025-01-15 18:17:36','bagas','yanto'),(17,'CUY TUGAS DATABASE GIMANA?','2025-01-15 18:17:48','bagas','yanto'),(18,'database disuruh ngapain yak?','2025-01-15 18:17:55','bagas','yanto'),(19,'aku nyerah deh sama database','2025-01-15 18:18:00','bagas','yanto'),(20,'pasrah gua to','2025-01-15 18:18:05','bagas','yanto'),(21,'masa disuruh buat aplikasi social media','2025-01-15 18:18:20','bagas','yanto'),(22,'susah ga sih?','2025-01-15 18:18:23','bagas','yanto'),(23,'eh gampang ternyata','2025-01-15 18:18:27','bagas','yanto'),(24,'Ez puoll','2025-01-15 18:18:31','bagas','yanto'),(25,'GILA JAGO AMAT GUA','2025-01-15 18:18:35','bagas','yanto'),(26,'BALES GUA','2025-01-15 18:18:41','bagas','yanto'),(27,'Oy','2025-01-15 18:18:50','bagas','yanto'),(28,'test','2025-01-15 18:21:09','bagas','yanto'),(29,'1','2025-01-15 18:21:10','bagas','yanto'),(30,'2','2025-01-15 18:21:11','bagas','yanto'),(31,'3','2025-01-15 18:21:11','bagas','yanto'),(32,'4','2025-01-15 18:21:12','bagas','yanto'),(33,'5','2025-01-15 18:21:13','bagas','yanto'),(34,'6','2025-01-15 18:21:14','bagas','yanto'),(35,'7','2025-01-15 18:21:14','bagas','yanto'),(36,'8','2025-01-15 18:21:15','bagas','yanto'),(37,'9','2025-01-15 18:21:15','bagas','yanto'),(38,'0','2025-01-15 18:21:16','bagas','yanto'),(39,'1','2025-01-15 18:21:17','bagas','yanto'),(40,'2','2025-01-15 18:21:18','bagas','yanto'),(41,'3','2025-01-15 18:21:19','bagas','yanto'),(42,'4','2025-01-15 18:21:19','bagas','yanto'),(43,'5','2025-01-15 18:21:22','bagas','yanto'),(44,'6','2025-01-15 18:21:23','bagas','yanto'),(45,'7','2025-01-15 18:21:24','bagas','yanto'),(46,'8','2025-01-15 18:21:24','bagas','yanto'),(47,'9','2025-01-15 18:21:25','bagas','yanto'),(48,'0','2025-01-15 18:21:27','bagas','yanto'),(49,'bro','2025-01-15 18:21:31','bagas','yanto'),(50,'p','2025-01-15 18:21:33','bagas','yanto'),(51,'p','2025-01-15 18:21:34','bagas','yanto'),(52,'p','2025-01-15 18:21:36','bagas','yanto'),(53,'p','2025-01-15 18:21:36','bagas','yanto'),(54,'p','2025-01-15 18:21:37','bagas','yanto'),(55,'p','2025-01-15 18:21:38','bagas','yanto'),(56,'p','2025-01-15 18:21:38','bagas','yanto'),(57,'p','2025-01-15 18:21:39','bagas','yanto'),(58,'p','2025-01-15 18:21:40','bagas','yanto'),(59,'p','2025-01-15 18:21:41','bagas','yanto'),(60,'Bro evannnn','2025-01-15 22:02:20','hendra','evan'),(61,'Bro kevinnn','2025-01-15 22:02:27','hendra','kevin');
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
INSERT INTO `kisahhidup` VALUES (-1,'alvin','2024','2024',''),(-1,'bagas','2024','2024','Capek'),(-1,'budi','2024','2024','Budiii'),(-1,'evan','2024','2024',''),(-1,'hendra','2023','2026','Kuliah Informatika S1'),(-1,'joshua','2023','2026','Kuliah S1'),(-1,'kevin','2023','2026','Lelah Coding'),(-1,'vivi','2023','2026','Kuliah database disini keren banget'),(-1,'yanto','2024','2024','Database mantap'),(0,'joshua','2020','2023','SMA Tercinta'),(0,'kevin','2020','2023','SMA MANTAP'),(0,'vivi','2020','2023','SMA Ku disini, HIYA HIYA'),(1,'hendra','2020','2023','Aku menempuh sma disini'),(2,'alvin','2024','2024',''),(2,'evan','2024','2024',''),(2,'hendra','2024','2024',''),(2,'joshua','2024','2024','KUCING'),(2,'vivi','2024','2024','');
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
INSERT INTO `komen` VALUES (1,'meow','2025-01-15 17:02:33','yanto',3),(2,'Ganteng Broo','2025-01-15 21:59:59','hendra',6);
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
INSERT INTO `konten` VALUES (2,'Bersama Yanto dan Budi','C:\\PamerYuk\\bagasx20250111193130x2.jpg','null','2025-01-11 19:31:30','bagas'),(3,'kucing','C:\\PamerYuk\\yantox20250115165837x3.jpg','null','2025-01-15 16:58:37','yanto'),(4,'kucing lompat','null','C:\\PamerYuk\\bagasx20250115174404x4.mp4','2025-01-15 17:44:04','bagas'),(5,'Halo','C:\\PamerYuk\\vivix20250115213407x5.jpg','null','2025-01-15 21:34:07','vivi'),(6,'With Bro Kevin','C:\\PamerYuk\\hendrax20250115215800x6.jpg','null','2025-01-15 21:58:00','hendra'),(7,'Kucing Lompat in 4K','null','C:\\PamerYuk\\evanx20250115220030x7.mp4','2025-01-15 22:00:30','evan'),(8,'Hendra habis SE','null','C:\\PamerYuk\\evanx20250115220748x8.mp4','2025-01-15 22:07:48','evan');
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
INSERT INTO `like` VALUES ('bagas',2),('yanto',3);
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
INSERT INTO `organisasi` VALUES (-1,'Ubaya',1),(0,'SMA PETRA',1),(1,'SMA ST HENDRIKUS',1),(2,'Pecinta Kucing Ubaya',1);
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
INSERT INTO `tag` VALUES (2,'budi'),(2,'yanto'),(6,'kevin'),(8,'hendra'),(8,'joshua');
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
INSERT INTO `teman` VALUES ('evan','alvin','2025-01-15','Menunggu'),('evan','hendra','2025-01-15','Berteman'),('evan','joshua','2025-01-15','Berteman'),('evan','vivi','2025-01-15','Menunggu'),('hendra','alvin','2025-01-15','Menunggu'),('hendra','joshua','2025-01-15','Menunggu'),('hendra','kevin','2025-01-15','Berteman'),('hendra','vivi','2025-01-15','Menunggu'),('yanto','bagas','2025-01-11','Berteman');
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
INSERT INTO `user` VALUES ('alvin','alvin','alvin','2025-01-15','alvin','C:\\PamerYuk\\alvinxPFDx20250115215337.jpg','C:\\PamerYuk\\alvinxPFPx20250115215337.jpg','alvin',1),('bagas','bagas','bagas','2025-01-11','bagas','C:\\PamerYuk\\bagasxPFDx20250111155001.jpg','C:\\PamerYuk\\bagasxPFPx20250111155001.jpg','bagas',1),('budi','budi','a','2025-01-11','a','C:\\PamerYuk\\budixPFDx20250111194056.jpg','C:\\PamerYuk\\budixPFPx20250111194056.jpg','a',1),('evan','evan','evan','2025-01-15','evan','C:\\PamerYuk\\evanxPFDx20250115215156.jpg','C:\\PamerYuk\\evanxPFPx20250115215156.jpg','evan',1),('evanPecintaKucing','evan','Evan Pecinta Kucing','2025-01-15','1234567890','C:\\PamerYuk\\evanPecintaKucingxPFDx20250115215','C:\\PamerYuk\\evanPecintaKucingxPFPx20250115215','evan@gmail.com',1),('hendra','hendra','hendra','2005-06-14','1234567890','C:\\PamerYuk\\hendraxPFDx20250115213812.jpg','C:\\PamerYuk\\hendraxPFPx20250115213812.jpg','hendra@gmail.com',1),('joshua','joshua','joshua','2025-01-15','joshua','C:\\PamerYuk\\joshuaxPFDx20250115214744.jpg','C:\\PamerYuk\\joshuaxPFPx20250115214744.jpg','joshua@gmail.com',1),('kevin','kevin','kevin','2025-01-15','1234567890','C:\\PamerYuk\\kevinxPFDx20250115214331.jpg','C:\\PamerYuk\\kevinxPFPx20250115214331.jpg','kevin@gmail.com',1),('vivi','vivi','vivi','1999-07-28','1234567890','C:\\PamerYuk\\vivixPFDx20250115213220.jpg','C:\\PamerYuk\\vivixPFPx20250115213220.jpg','vivi@gmail.com',1),('yanto','yanto','yanto','2025-01-11','1234567890','C:\\PamerYuk\\yantoxPFDx20250111185748.jpg','C:\\PamerYuk\\yantoxPFPx20250111185748.jpg','yanto',1);
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

-- Dump completed on 2025-01-16  7:51:41
