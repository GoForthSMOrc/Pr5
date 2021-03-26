-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: blog
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
-- Table structure for table `articles`
--

DROP TABLE IF EXISTS `articles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `articles` (
  `Id_Articles` int NOT NULL AUTO_INCREMENT,
  `TextArticles` longtext,
  `id_Conditions` int DEFAULT NULL,
  `id_Content` int DEFAULT NULL,
  `NameDate` date DEFAULT NULL,
  PRIMARY KEY (`Id_Articles`),
  KEY `articles_ibfk_1` (`id_Conditions`),
  KEY `fk_articles_Content_idx` (`id_Content`),
  CONSTRAINT `articles_ibfk_1` FOREIGN KEY (`id_Conditions`) REFERENCES `conditions` (`Id_Conditions`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_articles_Content` FOREIGN KEY (`id_Content`) REFERENCES `content` (`Id_Content`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articles`
--

LOCK TABLES `articles` WRITE;
/*!40000 ALTER TABLE `articles` DISABLE KEYS */;
INSERT INTO `articles` VALUES (1,'Структура блога',1,3,'2021-03-24'),(2,'Новое',2,4,'2021-03-23'),(3,'Старо ',3,5,'2021-03-22'),(4,'Артас Менетил',3,1,'2021-03-21'),(5,'Задача по программированию БД',1,2,'2021-03-25'),(6,'Артас Менетил',1,6,'2021-03-26');
/*!40000 ALTER TABLE `articles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conditions`
--

DROP TABLE IF EXISTS `conditions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conditions` (
  `Id_Conditions` int NOT NULL AUTO_INCREMENT,
  `NameConditions` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id_Conditions`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conditions`
--

LOCK TABLES `conditions` WRITE;
/*!40000 ALTER TABLE `conditions` DISABLE KEYS */;
INSERT INTO `conditions` VALUES (1,'Доступна втечение недели'),(2,'Доступна втечение месяца'),(3,'Доступна втечение года');
/*!40000 ALTER TABLE `conditions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `content`
--

DROP TABLE IF EXISTS `content`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `content` (
  `Id_Content` int NOT NULL AUTO_INCREMENT,
  `TextContent` longtext,
  PRIMARY KEY (`Id_Content`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `content`
--

LOCK TABLES `content` WRITE;
/*!40000 ALTER TABLE `content` DISABLE KEYS */;
INSERT INTO `content` VALUES (1,'Артас Менетил - кронпринц Лордерона и рыцарь Cеребряной Длани. Был сыном короля Теренаса Менетила II и наследником трона. Утер Светоносный обучал его бравому делу паладина, а к волшебнице Джайне Праудмур он испытывал романтические чувства. Но несмотря на многообещающее начало жизни, после объединения с Королем-личем, Артас стал одним из самых ужасных созданий, когда-либо встречавшихся на просторах Азерота.Принц Артас Менетил родился за четыре года до Первой войны в семье короля Теренаса Менетила II. Молодой принц рос в те времена, когда земли всего Азерота были пронизаны войной, Альянс находился в смятении, а темные облака всё ещё вырисовывались на горизонте. Будучи ещё ребенком, Артас подружился с Варианом Ринном. '),(2,'1)Спроектировать схему БД\n2)Разработать приложение\n3)Ссылочку на GitHub будьте добры EZ'),(3,'Очень много полезной информации '),(4,'Teenage Mutant Ninja Turtles \"Shredder\'s revenge\" - Игра разрабатывается студией Tribute Games и будет издана компанией Dotemu.\n10 марта 2021 года был выпущен трейлер игры, в котором команда сражается с такими классическими злодеями франшизы, как Рокстеди, Бибоп, и, конечно же, сам Шреддер. В нём также появляются учитель Сплинтер и Эйприл О’Нил.\nИгра будет пиксельным сайд-скроллером в жанре beat ’em up. В ней будет доступен режим кооперативной игры до 4 человек. Разработчики вдохновлялись мультсериалом 1987 года.'),(5,'Contra - 12 сентября 2631 года неподалёку от Новой Зеландии падает метеорит. Спустя два года появляется некая террористическая организация под названием «Красный сокол» (англ. Red Falcon), поставившая перед собой задачу уничтожить всё человечество. База «Красного сокола» находится на некоем острове. Действие игры начинается, когда два бойца Билл Райзер (Bill «Mad Dog» Rizer) и Лэнс Бин (Lance «Scorpion» Bean), ставшие до этого Контра (бойцами, мастерски владеющими навыками ведения партизанской войны), высаживаются на остров, чтобы уничтожить базу и спасти мир.\nПо мере проникновения на вражескую территорию бойцы выясняют, что за организацией «Красный сокол» стоят инопланетные пришельцы, прибывшие на метеорите. Главной задачей героев становится нахождение логова пришельцев и уничтожение их сердца.'),(6,'Принц Артас Менетил родился за четыре года до Первой войны в семье короля Теренаса Менетила II. Молодой принц рос в те времена, когда земли всего Азерота были пронизаны войной, Альянс находился в смятении, а темные облака всё ещё вырисовывались на горизонте. Будучи ещё ребенком, Артас подружился с Варианом Ринном.\nБоевому искусству Артаса обучал сам Мурадин Бронзобород, брат короля дворфов Магни Бронзоборода. Артас преуспел в этом начинании и стал экспертом-мечником. Под покровительством Утера Светоносного Артас вступил в орден рыцарей Серебряной Длани в возрасте 19 лет. Несмотря на свое безрассудство и упрямство, Артас стал прославленным воином. Одним из его самых известных подвигов стала контратака на троллей, атаковавших Кель\'Талас из Зул\'Амана.\nВ эти времена Артас встретил младшую дочь Даэлина Праудмура - волшебницу Джайну. На протяжении нескольких лет они росли бок о бок друг с другом, и всё это закончилось романтическими отношениями. Они очень сильно любили друг друга. Но когда Юный Принц стал паладином, он стал задаваться вопросом: готовы ли они быть вместе? И он решил навремя расстаться с Джайной, чтобы она могла сосредоточиться на своём магическом обучении, а он — на своих обязательствах перед Лордероном. Но вскоре после этого они решили возобновить свои отношения, но это случилось в самом начале нашествия Плети — события, которое навсегда изменило их жизни.');
/*!40000 ALTER TABLE `content` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `info`
--

DROP TABLE IF EXISTS `info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `info` (
  `Id_Info` int NOT NULL AUTO_INCREMENT,
  `NameArticle` varchar(45) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `id_Articles` int DEFAULT NULL,
  PRIMARY KEY (`Id_Info`),
  KEY `info_ibfk_1` (`id_Articles`),
  CONSTRAINT `info_ibfk_1` FOREIGN KEY (`id_Articles`) REFERENCES `articles` (`Id_Articles`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `info`
--

LOCK TABLES `info` WRITE;
/*!40000 ALTER TABLE `info` DISABLE KEYS */;
/*!40000 ALTER TABLE `info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usersdb`
--

DROP TABLE IF EXISTS `usersdb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usersdb` (
  `Id_UsersDB` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id_UsersDB`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usersdb`
--

LOCK TABLES `usersdb` WRITE;
/*!40000 ALTER TABLE `usersdb` DISABLE KEYS */;
INSERT INTO `usersdb` VALUES (1,'Admin','Admin'),(2,'YEPCock','3E3Lp'),(3,'InPognito','ZnA9e');
/*!40000 ALTER TABLE `usersdb` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-26 12:43:39
