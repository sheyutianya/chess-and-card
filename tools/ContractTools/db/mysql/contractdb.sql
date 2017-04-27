/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50614
Source Host           : localhost:3306
Source Database       : contractdb

Target Server Type    : MYSQL
Target Server Version : 50614
File Encoding         : 65001

Date: 2017-04-19 15:09:18
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for agreementclass
-- ----------------------------
DROP TABLE IF EXISTS `agreementclass`;
CREATE TABLE `agreementclass` (
  `AgreementID` int(11) NOT NULL AUTO_INCREMENT,
  `GameID` int(11) DEFAULT NULL,
  `Title` varchar(200) DEFAULT NULL,
  `Describe` longtext,
  `CreateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`AgreementID`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of agreementclass
-- ----------------------------

-- ----------------------------
-- Table structure for contract
-- ----------------------------
DROP TABLE IF EXISTS `contract`;
CREATE TABLE `contract` (
  `ID` int(11) NOT NULL,
  `Descption` varchar(100) NOT NULL,
  `ParentID` int(11) NOT NULL,
  `SlnID` int(11) NOT NULL,
  `Complated` bit(1) NOT NULL DEFAULT b'0',
  `AgreementID` int(11) DEFAULT '0',
  `VerId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`,`SlnID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of contract
-- ----------------------------

-- ----------------------------
-- Table structure for contractversion
-- ----------------------------
DROP TABLE IF EXISTS `contractversion`;
CREATE TABLE `contractversion` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) DEFAULT NULL,
  `SlnID` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of contractversion
-- ----------------------------
INSERT INTO `contractversion` VALUES ('3', '1.0.0.0', '10');

-- ----------------------------
-- Table structure for enuminfo
-- ----------------------------
DROP TABLE IF EXISTS `enuminfo`;
CREATE TABLE `enuminfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `SlnID` int(11) NOT NULL,
  `enumName` varchar(50) NOT NULL,
  `enumDescription` varchar(200) DEFAULT NULL,
  `enumValueInfo` longtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1004 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of enuminfo
-- ----------------------------

-- ----------------------------
-- Table structure for paraminfo
-- ----------------------------
DROP TABLE IF EXISTS `paraminfo`;
CREATE TABLE `paraminfo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ContractID` int(11) NOT NULL,
  `ParamType` smallint(6) NOT NULL,
  `Field` varchar(30) NOT NULL,
  `FieldType` smallint(6) NOT NULL,
  `Descption` varchar(100) DEFAULT NULL,
  `FieldValue` varchar(100) DEFAULT NULL,
  `Required` bit(1) NOT NULL,
  `Remark` text,
  `SortID` int(11) NOT NULL,
  `Creator` int(11) NOT NULL,
  `CreateDate` datetime NOT NULL,
  `Modifier` int(11) NOT NULL,
  `ModifyDate` datetime NOT NULL,
  `SlnID` int(11) NOT NULL,
  `MinValue` int(11) NOT NULL,
  `MaxValue` int(11) NOT NULL,
  `VerId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17097 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of paraminfo
-- ----------------------------

-- ----------------------------
-- Table structure for solutions
-- ----------------------------
DROP TABLE IF EXISTS `solutions`;
CREATE TABLE `solutions` (
  `SlnID` int(11) NOT NULL AUTO_INCREMENT,
  `SlnName` varchar(100) NOT NULL,
  `Namespace` varchar(200) DEFAULT NULL,
  `RefNamespace` varchar(200) DEFAULT NULL,
  `Url` varchar(200) DEFAULT NULL,
  `GameID` int(11) DEFAULT NULL,
  `SerUseScript` varchar(20) DEFAULT NULL,
  `CliUseScript` varchar(20) DEFAULT NULL,
  `IsDParam` bit(1) NOT NULL DEFAULT b'1',
  `RespContentType` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`SlnID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of solutions
-- ----------------------------
INSERT INTO `solutions` VALUES ('10', 'ChessAndCard', 'GameServer.CsScript.Action', '', '127.0.0.1:9001', '1', 'C#', 'C#', '', '0');
