-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: items_uch
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `id_item` int NOT NULL AUTO_INCREMENT,
  `name_item` varchar(40) DEFAULT NULL,
  `price` float DEFAULT NULL,
  `quantity` float DEFAULT NULL,
  PRIMARY KEY (`id_item`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (1,'шапка',300,30),(2,'одеяло',1000,10),(3,'подушка',400,-9),(4,'плюшевый мишка',400,28);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id_ord` int NOT NULL AUTO_INCREMENT,
  `id_tovar` int DEFAULT NULL,
  `quantity` float DEFAULT NULL,
  `price` float DEFAULT NULL,
  `employee` varchar(60) DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id_ord`),
  KEY `id_tovar` (`id_tovar`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`id_tovar`) REFERENCES `items` (`id_item`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,20,6000,'Херман Максим Чеславович','2021-01-19'),(2,2,5,5000,'Рунов Мефодий Маркович','2021-02-05'),(3,3,30,12000,'Воеводина Эмилия Тимофеевна','2021-02-11');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prihod`
--

DROP TABLE IF EXISTS `prihod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prihod` (
  `id_prih` int NOT NULL AUTO_INCREMENT,
  `quantity` float DEFAULT NULL,
  `price` float DEFAULT NULL,
  `income` float DEFAULT NULL,
  `id_tovar` int DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id_prih`),
  KEY `id_tovar` (`id_tovar`),
  CONSTRAINT `prihod_ibfk_1` FOREIGN KEY (`id_tovar`) REFERENCES `items` (`id_item`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prihod`
--

LOCK TABLES `prihod` WRITE;
/*!40000 ALTER TABLE `prihod` DISABLE KEYS */;
INSERT INTO `prihod` VALUES (4,5,1000,5000,2,'2021-02-23'),(5,20,300,6000,1,'2021-03-11'),(6,10,400,4000,3,'2021-04-21'),(8,4,44,176,4,'2021-03-09');
/*!40000 ALTER TABLE `prihod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rashod`
--

DROP TABLE IF EXISTS `rashod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rashod` (
  `id_ras` int NOT NULL AUTO_INCREMENT,
  `quantity` float DEFAULT NULL,
  `price` float DEFAULT NULL,
  `id_tovar` int DEFAULT NULL,
  `outcome` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id_ras`),
  KEY `id_tovar` (`id_tovar`),
  CONSTRAINT `rashod_ibfk_1` FOREIGN KEY (`id_tovar`) REFERENCES `items` (`id_item`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rashod`
--

LOCK TABLES `rashod` WRITE;
/*!40000 ALTER TABLE `rashod` DISABLE KEYS */;
INSERT INTO `rashod` VALUES (4,15,200,3,3000,'2021-01-26'),(5,8,500,2,4000,'2021-03-19'),(6,10,150,1,1500,'2021-04-01'),(7,3,50,3,150,'2021-03-09'),(8,46,100,3,4600,'2021-03-09');
/*!40000 ALTER TABLE `rashod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id_u` int NOT NULL AUTO_INCREMENT,
  `login` varchar(10) DEFAULT NULL,
  `password` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_u`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-23  5:47:11
