CREATE DATABASE  IF NOT EXISTS `sales_inventory_system_for_grocery` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `sales_inventory_system_for_grocery`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: sales_inventory_system_for_grocery
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_actlog`
--

DROP TABLE IF EXISTS `tbl_actlog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_actlog` (
  `username` varchar(45) NOT NULL,
  `Activity` varchar(150) NOT NULL,
  `DateTime` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_actlog`
--

LOCK TABLES `tbl_actlog` WRITE;
/*!40000 ALTER TABLE `tbl_actlog` DISABLE KEYS */;
INSERT INTO `tbl_actlog` VALUES ('admin','Logged-In','05/16/2022 07:13:56 am'),('admin','Logged-In','05/16/2022 07:40:03 am'),('admin',' Added new product. Product: Sky flakes cracker','05/16/2022 07:41:41 am'),('admin','Added new customer account. Customer: Ronnel Ardales','05/16/2022 07:42:52 am'),('admin','Logged-out','05/16/2022 07:43:19 am'),('cashier','Logged-In','05/16/2022 07:43:42 am'),('cashier','Logged-In','05/16/2022 07:44:52 am'),('cashier','Logged-In','05/16/2022 07:55:37 am'),('cashier','Added new transaction. Customer name: Ronnel Ardales','05/16/2022 07:55:52 am'),('admin','Logged-In','05/16/2022 07:59:30 am'),('admin','Added new user account. Username: Vergel123','05/16/2022 08:00:31 am'),('admin','Update user account. Username: Vergel123','05/16/2022 08:00:53 am'),('admin','Update user account. Username: Vergel123','05/16/2022 08:01:07 am'),('admin',' Added new product. Product: Fita crackers  (1 pack)','05/16/2022 08:04:47 am'),('admin',' Added new stock. Product: Fita crackers  (1 pack)','05/16/2022 08:05:19 am'),('admin','Added new customer account. Customer: Luren  Macapanas','05/16/2022 08:07:32 am'),('admin','Logged-out','05/16/2022 08:09:00 am'),('cashier','Logged-In','05/16/2022 08:09:05 am'),('cashier','Logged-out','05/16/2022 08:13:01 am'),('admin','Logged-In','05/16/2022 08:16:45 am'),('admin','Logged-In','05/16/2022 08:17:10 am'),('admin','Logged-In','05/16/2022 08:50:28 am'),('admin','Logged-In','05/16/2022 09:04:54 am'),('admin','Logged-In','05/16/2022 09:07:22 am'),('admin','Logged-In','05/16/2022 09:16:13 am'),('admin','Logged-In','05/16/2022 09:18:11 am'),('admin','Added new user account. Username: jasper','05/16/2022 09:20:06 am'),('admin','Logged-In','05/16/2022 09:24:19 am'),('admin','Update user account. Username: jasper','05/16/2022 09:25:48 am'),('admin',' Added new stock. Product: Fita crackers  (1 pack)','05/16/2022 09:30:15 am'),('admin','Logged-In','05/16/2022 09:38:11 am'),('admin','Logged-In','05/16/2022 09:39:38 am'),('admin','Logged-out','05/16/2022 09:42:15 am'),('cashier','Logged-In','05/16/2022 09:42:18 am'),('admin','Logged-In','05/16/2022 09:47:42 am'),('admin','Logged-In','05/16/2022 09:50:22 am'),('cashier','Logged-In','05/16/2022 09:51:02 am'),('admin','Logged-In','05/16/2022 09:52:10 am'),('admin','Logged-In','05/16/2022 09:52:51 am'),('admin','Logged-In','05/16/2022 09:53:21 am'),('admin','Logged-In','05/16/2022 09:53:48 am'),('admin','Logged-In','05/16/2022 09:54:26 am'),('cashier','Logged-In','05/16/2022 09:56:49 am'),('cashier','Added new transaction. Customer name: Ronnel Ardales','05/16/2022 09:58:41 am'),('admin','Logged-In','05/16/2022 10:12:31 am'),('admin','Logged-In','05/16/2022 10:17:50 am'),('admin','Logged-out','05/16/2022 10:17:54 am'),('jasper','Logged-In','05/16/2022 10:18:32 am'),('admin','Logged-In','05/16/2022 10:20:51 am'),('admin','Logged-In','05/16/2022 10:24:05 am'),('admin','Logged-In','05/16/2022 10:30:18 am'),('jasper','Logged-In','05/16/2022 10:31:50 am'),('jasper','Added new transaction. Customer name: Ronnel Ardales','05/16/2022 10:32:11 am'),('jasper','Logged-out','05/16/2022 10:37:34 am'),('admin','Logged-In','05/16/2022 10:38:29 am'),('admin','Added new user account. Username: ronnel2192','05/16/2022 10:39:26 am'),('admin','Logged-out','05/16/2022 10:41:08 am'),('admin','Logged-In','05/16/2022 10:44:18 am'),('admin','Added new user account. Username: raja','05/16/2022 10:45:44 am'),('admin','Update user account. Username: Vergel123','05/16/2022 10:46:26 am'),('admin',' Added new product. Product: century tuna','05/16/2022 10:48:41 am'),('admin',' Added new stock. Product: Fita crackers  (1 pack)','05/16/2022 10:49:20 am'),('admin','Added new customer account. Customer: Vergel Bayona','05/16/2022 10:50:47 am'),('admin','Added new category. Category: Noodles','05/16/2022 10:55:34 am'),('admin','Updated category. Category: Beverage','05/16/2022 10:57:17 am'),('admin','Added new brand name. Brandname: Lucky Me','05/16/2022 10:57:55 am'),('admin','Logged-out','05/16/2022 10:58:42 am'),('jasper','Logged-In','05/16/2022 10:58:53 am'),('jasper','Added new transaction. Customer name: Vergel Bayona','05/16/2022 11:01:57 am'),('jasper','Logged-out','05/16/2022 11:02:51 am'),('admin','Logged-In','05/16/2022 11:03:29 am'),('admin','Logged-out','05/16/2022 11:03:35 am'),('ronnel2192','Logged-In','05/16/2022 11:03:50 am'),('admin','Logged-In','05/16/2022 07:26:53 pm'),('admin','Logged-out','05/16/2022 07:27:54 pm'),('ronnel2192','Logged-In','05/16/2022 07:28:10 pm'),('ronnel2192','Logged-out','05/16/2022 07:28:55 pm'),('cashier','Logged-In','05/16/2022 07:29:06 pm'),('cashier','Logged-out','05/16/2022 07:32:00 pm'),('ronnel2192','Logged-In','05/16/2022 07:32:11 pm'),('admin','Logged-In','05/17/2022 02:31:32 pm'),('admin','Logged-In','05/17/2022 10:13:34 pm'),('cashier','Added new transaction. Customer name: Ronnel Ardales','05/17/2022 10:55:24 pm'),('cashier','Added new transaction. Customer name: Vergel Bayona','05/18/2022 12:35:47 am'),('admin','Logged-In','05/18/2022 10:58:58 pm'),('admin','Added new user account. Username: Clerk123','05/18/2022 11:02:05 pm'),('admin','Update user account. Username: Clerk123','05/18/2022 11:02:48 pm'),('admin','Logged-out','05/19/2022 01:48:45 am'),('admin','Logged-out','05/19/2022 02:28:22 am'),('cashier','Added new transaction. Customer name: Ronnel Ardales','05/19/2022 03:05:26 am'),('cashier','Logged-out','05/19/2022 04:22:14 pm'),('admin','Logged-out','05/19/2022 05:08:04 pm'),('admin','Logged-out','05/19/2022 05:09:08 pm'),('cashier','Logged-out','05/19/2022 05:09:51 pm'),('admin','Logged-In','05/19/2022 05:18:05 pm'),('admin','Added new user account. Username: user123','05/19/2022 05:21:05 pm'),('admin','Update user account. Username: user123','05/19/2022 05:21:31 pm'),('admin','Added new category. Category: Personal care','05/19/2022 05:23:38 pm'),('admin','Added new category. Category: Alcoholic Drink','05/19/2022 05:24:14 pm'),('admin','Updated category. Category: Alcoholic drinks','05/19/2022 05:24:35 pm'),('admin','Added new category. Category: Dairy product ','05/19/2022 05:25:19 pm'),('admin','Logged-out','05/19/2022 05:27:21 pm'),('admin','Logged-In','05/19/2022 05:28:36 pm'),('admin','Logged-out','05/19/2022 05:28:47 pm'),('admin','Logged-In','05/19/2022 05:29:12 pm'),('admin','Logged-out','05/19/2022 05:29:21 pm'),('admin','Logged-In','05/19/2022 05:32:36 pm'),('admin','Added new brand name. Brandname: Magnolia','05/19/2022 05:32:51 pm'),('admin','Added new brand name. Brandname: Alaska','05/19/2022 05:33:27 pm'),('admin','Logged-out','05/19/2022 05:33:47 pm'),('admin','Logged-In','05/19/2022 05:34:13 pm'),('admin','Logged-out','05/19/2022 05:34:30 pm'),('admin','Logged-In','05/19/2022 05:34:47 pm'),('admin',' Added new product. Product: Alaska condensed milk (250g)','05/19/2022 05:36:14 pm'),('admin',' Added new stock. Product: Alaska condensed milk (250g)','05/19/2022 05:36:45 pm'),('admin','Added new customer account. Customer: Jasper Quijano','05/19/2022 05:37:33 pm'),('admin','Logged-out','05/19/2022 05:39:43 pm'),('cashier','Logged-In','05/19/2022 05:42:44 pm'),('cashier','Added new transaction. Customer name: Jasper Quijano','05/19/2022 05:43:56 pm'),('cashier','Logged-out','05/19/2022 05:44:19 pm'),('ronnel2192','Logged-In','05/19/2022 05:47:11 pm'),('ronnel2192','Logged-out','05/19/2022 05:47:23 pm');
/*!40000 ALTER TABLE `tbl_actlog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_addcart`
--

DROP TABLE IF EXISTS `tbl_addcart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_addcart` (
  `TransNo` int NOT NULL,
  `TransDate` varchar(45) NOT NULL,
  `TransTime` varchar(45) NOT NULL,
  `CustomerNo` varchar(45) NOT NULL,
  `Fullname` varchar(45) NOT NULL,
  `ProductCode` varchar(45) NOT NULL,
  `ProductName` varchar(45) NOT NULL,
  `Quantity` varchar(45) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `TotalAmount` int DEFAULT NULL,
  `Cash` int DEFAULT NULL,
  `Changed` int DEFAULT NULL,
  PRIMARY KEY (`TransNo`,`ProductCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_addcart`
--

LOCK TABLES `tbl_addcart` WRITE;
/*!40000 ALTER TABLE `tbl_addcart` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_addcart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_brand`
--

DROP TABLE IF EXISTS `tbl_brand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_brand` (
  `brandcode` int NOT NULL,
  `brandname` varchar(45) NOT NULL,
  PRIMARY KEY (`brandcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_brand`
--

LOCK TABLES `tbl_brand` WRITE;
/*!40000 ALTER TABLE `tbl_brand` DISABLE KEYS */;
INSERT INTO `tbl_brand` VALUES (1,'M.Y San'),(2,'Universal robina'),(3,'Lucky Me'),(4,'Magnolia'),(5,'Alaska');
/*!40000 ALTER TABLE `tbl_brand` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_category`
--

DROP TABLE IF EXISTS `tbl_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_category` (
  `categorycode` int NOT NULL,
  `categoryname` varchar(45) NOT NULL,
  PRIMARY KEY (`categorycode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_category`
--

LOCK TABLES `tbl_category` WRITE;
/*!40000 ALTER TABLE `tbl_category` DISABLE KEYS */;
INSERT INTO `tbl_category` VALUES (1,'Fresh product'),(2,'Meat'),(3,'Snacks'),(4,'Beverage'),(5,'Noodles'),(6,'Personal care'),(7,'Alcoholic drinks'),(8,'Dairy product ');
/*!40000 ALTER TABLE `tbl_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_product`
--

DROP TABLE IF EXISTS `tbl_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_product` (
  `ProductCode` int NOT NULL,
  `Productname` varchar(100) NOT NULL,
  `Productcategory` varchar(100) NOT NULL,
  `Brand` varchar(100) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `Quantity` varchar(45) NOT NULL,
  PRIMARY KEY (`ProductCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_product`
--

LOCK TABLES `tbl_product` WRITE;
/*!40000 ALTER TABLE `tbl_product` DISABLE KEYS */;
INSERT INTO `tbl_product` VALUES (1,'Sky flakes cracker','Snacks','M.Y San','10','39'),(2,'Fita crackers  (1 pack)','Snacks','M.Y San','58','92'),(3,'century tuna','Meat','M.Y San','20','40'),(4,'Alaska condensed milk (250g)','Dairy product ','Alaska','20','70');
/*!40000 ALTER TABLE `tbl_product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_productstock`
--

DROP TABLE IF EXISTS `tbl_productstock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_productstock` (
  `stockId` int NOT NULL,
  `productcode` varchar(45) NOT NULL,
  `productname` varchar(45) NOT NULL,
  `addedstock` int NOT NULL,
  `dateadded` varchar(45) NOT NULL,
  PRIMARY KEY (`stockId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_productstock`
--

LOCK TABLES `tbl_productstock` WRITE;
/*!40000 ALTER TABLE `tbl_productstock` DISABLE KEYS */;
INSERT INTO `tbl_productstock` VALUES (1,'2','Fita crackers  (1 pack)',5,'05/16/2022 08:05:18 am'),(2,'2','Fita crackers  (1 pack)',5,'05/16/2022 09:30:12 am'),(3,'2','Fita crackers  (1 pack)',5,'05/16/2022 10:49:19 am'),(4,'4','Alaska condensed milk (250g)',5,'05/19/2022 05:36:43 pm');
/*!40000 ALTER TABLE `tbl_productstock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_profile`
--

DROP TABLE IF EXISTS `tbl_profile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_profile` (
  `Customerno` int NOT NULL,
  `Firstname` varchar(45) NOT NULL,
  `Middlename` varchar(45) DEFAULT NULL,
  `Lastname` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `Contactno` varchar(45) NOT NULL,
  PRIMARY KEY (`Customerno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_profile`
--

LOCK TABLES `tbl_profile` WRITE;
/*!40000 ALTER TABLE `tbl_profile` DISABLE KEYS */;
INSERT INTO `tbl_profile` VALUES (1,'Ronnel','Casas','Ardales','Mahabang parang, Binangonan, Rizal','09266500868'),(2,'Luren ','','Macapanas','Taytay, Rizal','09768776787'),(3,'Vergel','','Bayona','Macamot, Binangonan, Rizal','0925674546'),(4,'Jasper','','Quijano','layunan, Binangonan, Rizal','09256575744');
/*!40000 ALTER TABLE `tbl_profile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transaction`
--

DROP TABLE IF EXISTS `tbl_transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaction` (
  `TransNo` int NOT NULL,
  `TransDate` varchar(45) NOT NULL,
  `TransTime` varchar(45) NOT NULL,
  `CustomerNo` varchar(45) NOT NULL,
  `Fullname` varchar(45) NOT NULL,
  `ProductCode` varchar(45) NOT NULL,
  `ProductName` varchar(45) NOT NULL,
  `Quantity` varchar(45) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `TotalAmount` varchar(45) DEFAULT NULL,
  `Cash` varchar(45) DEFAULT NULL,
  `Change` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`TransNo`,`ProductCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaction`
--

LOCK TABLES `tbl_transaction` WRITE;
/*!40000 ALTER TABLE `tbl_transaction` DISABLE KEYS */;
INSERT INTO `tbl_transaction` VALUES (1,'05/16/2022','07:45:13 am','1','Ronnel Ardales','1','Sky flakes cracker','2','20','20','30','10'),(2,'05/16/2022','09:58:08 am','1','Ronnel Ardales','1','Sky flakes cracker','3','30','204','210','6'),(2,'05/16/2022','09:57:21 am','1','Ronnel Ardales','2','Fita crackers  (1 pack)','3','174','204','210','6'),(3,'05/16/2022','10:19:08 am','1','Ronnel Ardales','2','Fita crackers  (1 pack)','2','116','116','120','4'),(4,'05/16/2022','11:01:12 am','3','Vergel Bayona','1','Sky flakes cracker','5','100','394','400','6'),(4,'05/16/2022','11:00:04 am','3','Vergel Bayona','2','Fita crackers  (1 pack)','3','174','394','400','6'),(4,'05/16/2022','11:00:35 am','3','Vergel Bayona','3','century tuna','6','120','394','400','6'),(5,'05/17/2022','10:51:41 pm','1','Ronnel Ardales','2','Fita crackers  (1 pack)','7','406','486','500','14'),(5,'05/17/2022','10:52:07 pm','1','Ronnel Ardales','3','century tuna','4','80','486','500','14'),(6,'05/18/2022','12:35:01 am','3','Vergel Bayona','2','Fita crackers  (1 pack)','4','232','232','300','68'),(7,'05/19/2022','03:04:39 am','1','Ronnel Ardales','1','Sky flakes cracker','1','10','10','10','0'),(8,'05/19/2022','05:43:42 pm','4','Jasper Quijano','2','Fita crackers  (1 pack)','4','232','332','400','68'),(8,'05/19/2022','05:43:22 pm','4','Jasper Quijano','4','Alaska condensed milk (250g)','5','100','332','400','68');
/*!40000 ALTER TABLE `tbl_transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `loginname` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES ('admin','admin','Ronnel Ardales','Administrator','Active'),('cashier','cashier','Luren','Cashier','Active'),('Clerk123','123','Inventory Clerk','Inventory Clerk','Active'),('jasper','jasper','jasper quijano','Cashier','Active'),('raja','raja','Raja Cerda','Cashier','Active'),('ronnel2192','ronnel2192','Ronnel Ardales','Inventory Clerk','Active'),('user123','123','Sample User','Administrator','Inactive'),('Vergel123','vergel','Vergel Bayona','Inventory Clerk','Inactive');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-19 18:25:21
