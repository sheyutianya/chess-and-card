
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


DROP database IF EXISTS `chessandcard`;
create database `chessandcard` DEFAULT CHARACTER SET gbk COLLATE gbk_chinese_ci;

select 'create databases:chessandcard successfull!';


--
-- Table structure for table `TbPlayer`
--
use chessandcard;

DROP TABLE IF EXISTS `TbPlayer`;

CREATE TABLE `TbPlayer` (
  `id` bigint(20) NOT NULL COMMENT '唯一标识',
  `accountId` bigint(20) NOT NULL COMMENT '账号id',
  `openId` varchar(128) DEFAULT '' COMMENT '登陆的平台ID',
  `name` varchar(64) DEFAULT NULL COMMENT '角色名称',
  `status` int(11) DEFAULT '0' COMMENT '当前状态',
  `createTime` datetime DEFAULT NULL COMMENT '创建时间',
  `modifyTime` datetime DEFAULT NULL COMMENT '修改时间',
  `lastlogindate` datetime DEFAULT NULL COMMENT '角色最后一次登录时间',
  `lastlogoutdate` datetime DEFAULT NULL COMMENT '角色最后一次登出时间',
  `areaid` int(11) DEFAULT '0' COMMENT '所属分区编号',
  `channelId` int(11) NOT NULL DEFAULT '10001' COMMENT '渠道ID',
  `loginType` int(11) DEFAULT '0' COMMENT '登陆方式',
  `online` tinyint(4) DEFAULT '0' COMMENT '当前是否在线:0不在线,1在线',
  `onlinetimes` bigint(20) DEFAULT '0' COMMENT '总在线时长:ms',
  `trial` int(11) DEFAULT '0' COMMENT '试炼币',
  `infinite` int(11) DEFAULT '0' COMMENT '无尽币',
  `honour` int(11) DEFAULT '0' COMMENT '荣誉币',
  `silver` int(11) DEFAULT '0' COMMENT '银币',
  `diamond` int(11) DEFAULT '0' COMMENT '钻石',
  `patrolMoney` int(11) DEFAULT '0' COMMENT '巡逻币',
  `guildMoney` int(11) DEFAULT '0' COMMENT '公会贡献币',
  `exp` int(11) DEFAULT '0' COMMENT '经验',
  `level` int(11) DEFAULT '0' COMMENT '等级',
  `vipLevel` int(11) DEFAULT '0' COMMENT 'vip等级',
  `vipExp` int(11) DEFAULT '0' COMMENT 'vip经验',
  `strength` int(11) DEFAULT '0' COMMENT '体力',
  `skillPoint` int(11) NOT NULL DEFAULT '0' COMMENT '技能点',
  `iconType` int(11) DEFAULT '0' COMMENT '玩家头像类型, 按位区分0位-为武将ID, 1位-为玩家URL, 2位-取得过PVP排名第一',
  `icon` varchar(256) DEFAULT '' COMMENT '玩家头像ID, 或头像URL',
  `nameChanage` int(11) DEFAULT '0' COMMENT '改名次数，0未取名，1，第一次创建名称...',
  `fightingForce` int(11) NOT NULL DEFAULT '0' COMMENT '战斗力',
  `pvpFight` int(11) NOT NULL DEFAULT '0' COMMENT 'pvp的战斗力',
  `country` smallint(2) NOT NULL DEFAULT '0' COMMENT '国家，0：无国家，1：魏国 2：蜀国 3：吴国',
  `investigate` int(11) NOT NULL DEFAULT '0' COMMENT '侦查令',
  `militaryOrder` int(11) NOT NULL DEFAULT '0' COMMENT '军令',
  `technoloySteps` int(11) NOT NULL DEFAULT '0' COMMENT '科技系统剩余步数',
  `pvpScore` int(11) NOT NULL DEFAULT '0' COMMENT 'PVP积分',
  `pvpScoreDaily` int(11) NOT NULL DEFAULT '0' COMMENT 'PVP积分 每日重置',
  `isFristCard` int(11) NOT NULL DEFAULT '0' COMMENT '是否首次抽卡,0是其他否',
  `secretRoomId` int(11) NOT NULL DEFAULT '0' COMMENT '参加的秘境房间Id',
  `fightItemRandomNum` int(11) NOT NULL DEFAULT '0' COMMENT '战斗道具随机次数',
  `fightItemRandomID` int(11) NOT NULL DEFAULT '0' COMMENT '战斗道具随机Id',
  `pvpRank` int(11) NOT NULL DEFAULT '0' COMMENT 'PVP阶级',
  `unionId` int(11) DEFAULT '0' COMMENT '加入的公会ID',
  `unlimitStrengthTime` datetime DEFAULT NULL COMMENT '无限体力到期时间',
  `language` VARCHAR(12) NULL COMMENT '语言',
  PRIMARY KEY (`id`),
  KEY `indAccountId` (`accountId`),
  KEY `indName` (`name`),
  KEY `indCreateTime` (`createTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='角色表,一个玩家在一个区里唯一';



















