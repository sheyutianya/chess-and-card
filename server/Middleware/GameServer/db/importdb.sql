
/*create databases*/
DROP database IF EXISTS `snscenter`;
create database `snscenter` DEFAULT CHARACTER SET gbk COLLATE gbk_chinese_ci;

select 'create databases:snscentersuccessfull!';

/*grant user*/
Delete FROM mysql.user Where User='game_user';
grant select,insert,update,delete,create,alter,drop on *.* to game_user@"%" Identified by "123";

select 'grant user successfull!';


use snscenter;
/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50168
Source Host           : localhost:3306
Source Database       : snscenter

Target Server Type    : MYSQL
Target Server Version : 50168
File Encoding         : 65001

Date: 2013-11-22 16:01:11
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `limitdevice`
-- ----------------------------
DROP TABLE IF EXISTS `limitdevice`;
CREATE TABLE `limitdevice` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DeviceID` varchar(50) DEFAULT NULL,
  `AppTime` datetime DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of limitdevice
-- ----------------------------

-- ----------------------------
-- Table structure for `loguserlogin`
-- ----------------------------
DROP TABLE IF EXISTS `loguserlogin`;
CREATE TABLE `loguserlogin` (
  `LogID` bigint(20) NOT NULL AUTO_INCREMENT,
  `UserID` bigint(20) DEFAULT NULL,
  `LogTime` datetime DEFAULT NULL,
  `IPAddr` varchar(15) DEFAULT NULL,
  `LogType` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of loguserlogin
-- ----------------------------

-- ----------------------------
-- Table structure for `passportloginlog`
-- ----------------------------
DROP TABLE IF EXISTS `passportloginlog`;
CREATE TABLE `passportloginlog` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DeviceID` varchar(50) DEFAULT NULL,
  `PassportID` varchar(50) DEFAULT NULL,
  `LoginTime` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of passportloginlog
-- ----------------------------

-- ----------------------------
-- Table structure for `snspassportlog`
-- ----------------------------
DROP TABLE IF EXISTS `snspassportlog`;
CREATE TABLE `snspassportlog` (
  `PassportID` int(11) NOT NULL AUTO_INCREMENT,
  `CreateTime` datetime DEFAULT NULL,
  `Mark` int(11) DEFAULT NULL,
  `RegPushTime` datetime DEFAULT NULL,
  `RegTime` datetime DEFAULT NULL,
  PRIMARY KEY (`PassportID`)
) ENGINE=InnoDB AUTO_INCREMENT=10000 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of snspassportlog
-- ----------------------------

-- ----------------------------
-- Table structure for `snsuserinfo`
-- ----------------------------
DROP TABLE IF EXISTS `snsuserinfo`;
CREATE TABLE `snsuserinfo` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `PassportID` varchar(32) DEFAULT NULL,
  `PassportPwd` varchar(50) DEFAULT NULL,
  `DeviceID` varchar(50) DEFAULT NULL,
  `RegType` smallint(6) DEFAULT NULL,
  `RegTime` datetime DEFAULT NULL,
  `RetailID` varchar(50) DEFAULT NULL,
  `RetailUser` varchar(50) DEFAULT NULL,
  `Mobile` varchar(12) DEFAULT NULL,
  `Mail` varchar(50) DEFAULT NULL,
  `PwdType` int(11) DEFAULT NULL,
  `RealName` varchar(20) DEFAULT NULL,
  `IDCards` varchar(20) DEFAULT NULL,
  `ActiveCode` char(10) DEFAULT NULL,
  `SendActiveDate` datetime DEFAULT NULL,
  `ActiveDate` datetime DEFAULT NULL,
  `WeixinCode` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=1380000 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of snsuserinfo
-- ----------------------------

-- ----------------------------
-- Table structure for `userloginlog`
-- ----------------------------
DROP TABLE IF EXISTS `userloginlog`;
CREATE TABLE `userloginlog` (
  `SessionID` bigint(20) NOT NULL AUTO_INCREMENT,
  `UserID` bigint(20) DEFAULT NULL,
  `AddTime` datetime DEFAULT NULL,
  `Md5Hash` varchar(50) DEFAULT NULL,
  `Stat` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`SessionID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of userloginlog
-- ----------------------------

select 'create center table successfully!';

