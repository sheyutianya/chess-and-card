/*###########################################################
## Dbseeker For Frm File 1.0
## Author: Long Qing （龍　慶）
## For more detailed information please visit http://www.dbseeker.com
###########################################################

###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\manager.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `manager`
###########################################################*/
DROP TABLE IF EXISTS `manager`;
CREATE TABLE `manager` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `power_id`  int(11) NOT NULL,
  `name`  varchar(50) NOT NULL,
  `telephone`  varchar(11) DEFAULT NULL,
  `password`  varchar(32) NOT NULL,
  `actualCard`  int(11) NOT NULL DEFAULT '0',
  `totalCards`  int(11) NOT NULL DEFAULT '0',
  `manager_up_id`  int(11) DEFAULT '1',
  `status`  char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `PK_MANANGER_MANAGER_ID` (`manager_up_id`),
  KEY `PK_MANAGER_POWER_M_ID` (`power_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ###########################################################
-- ## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\noticetable.frm
-- ## Created with MySQL Version 5.5.53
-- ## CREATE statement for table `noticetable`
-- ###########################################################
DROP TABLE IF EXISTS `noticetable`;
CREATE TABLE `noticetable` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `content`  varchar(255) DEFAULT NULL,
  `type`  int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\operatelog.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `operatelog`
########################################################### */
DROP TABLE IF EXISTS `operatelog`;
CREATE TABLE `operatelog` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `manager_id`  int(11) NOT NULL,
  `manager_down_id`  int(11) DEFAULT NULL,
  `account_id`  int(11) DEFAULT NULL,
  `createTime`  datetime NOT NULL,
  `mark`  varchar(255) DEFAULT NULL,
  `type`  char(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_OPERATELOG_MANAGER` (`manager_id`),
  KEY `PK_OPERATELOG_MANAGER_DOWN` (`manager_down_id`),
  KEY `PK_OPERATELOG_ACCOUNT` (`account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\paylog.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `paylog`
########################################################### */
DROP TABLE IF EXISTS `paylog`;
CREATE TABLE `paylog` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `send_manager_Id`  int(11) DEFAULT NULL,
  `reced_Id`  int(11) DEFAULT NULL,
  `receType`  int(11) DEFAULT NULL,
  `payCount`  int(11) DEFAULT NULL,
  `payTime`  datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_PAYLOG_MANAGER_ID` (`send_manager_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\playrecord.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `playrecord`
########################################################### */
DROP TABLE IF EXISTS `playrecord`;
CREATE TABLE `playrecord` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `playrecord`  longtext,
  `standingsDetail_id`  int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_STANDINGSDETAIL_PLAYRECORDID` (`standingsDetail_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/* 
###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\power.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `power`
########################################################### */
DROP TABLE IF EXISTS `power`;
CREATE TABLE `power` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `name`  varchar(50) NOT NULL,
  `status`  char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\prize.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `prize`
########################################################### */
DROP TABLE IF EXISTS `prize`;
CREATE TABLE `prize` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `index_id`  int(11) NOT NULL,
  `prize_name`  varchar(255) NOT NULL,
  `image_url`  varchar(255) NOT NULL,
  `probability`  int(6) NOT NULL DEFAULT '100',
  `status`  char(1) NOT NULL DEFAULT '0',
  `prizecount`  int(11) NOT NULL DEFAULT '1',
  `type`  char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\prizerule.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `prizerule`
########################################################### */
DROP TABLE IF EXISTS `prizerule`;
CREATE TABLE `prizerule` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `content`  varchar(255) DEFAULT NULL,
  `precount`  int(11) DEFAULT NULL,
  `status`  char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\roominfo.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `roominfo`
########################################################### */
DROP TABLE IF EXISTS `roominfo`;
CREATE TABLE `roominfo` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `gameType`  char(1) DEFAULT NULL,
  `isHong`  char(1) DEFAULT NULL,
  `roomid`  int(11) DEFAULT NULL,
  `sevenDouble`  char(1) DEFAULT NULL,
  `ma`  int(11) DEFAULT NULL,
  `zimo`  char(1) DEFAULT NULL,
  `xiayu`  int(2) DEFAULT NULL,
  `addWordCard`  char(1) DEFAULT NULL,
  `name`  varchar(100) DEFAULT NULL,
  `createTime`  datetime DEFAULT '0000-00-00 00-00-00',
  `cardNumb`  int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\standings.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `standings`
########################################################### */
DROP TABLE IF EXISTS `standings`;
CREATE TABLE `standings` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `roomid`  int(11) NOT NULL,
  `content`  varchar(255) NOT NULL,
  `createTime`  datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_ROOM_STANDINGS_ID` (`roomid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\standingsaccountrelation.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `standingsaccountrelation`
########################################################### */
DROP TABLE IF EXISTS `standingsaccountrelation`;
CREATE TABLE `standingsaccountrelation` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `standings_id`  int(11) NOT NULL,
  `account_id`  int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_STANDINGS_ACCOUNT_ID` (`standings_id`),
  KEY `PK_ACCOUNT_STANDINGS_ID` (`account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\standingsdetail.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `standingsdetail`
########################################################### */
DROP TABLE IF EXISTS `standingsdetail`;
CREATE TABLE `standingsdetail` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `content`  varchar(255) NOT NULL,
  `createTime`  datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\standingsrelation.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `standingsrelation`
########################################################### */
DROP TABLE IF EXISTS `standingsrelation`;
CREATE TABLE `standingsrelation` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `standings_id`  int(11) NOT NULL,
  `standingsDetail_id`  int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_STANDINGS_⁯ID` (`standings_id`),
  KEY `PK_STANDINGSDETAIL_ID` (`standingsDetail_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\techargerecord.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `techargerecord`
###########################################################*/
DROP TABLE IF EXISTS `techargerecord`;
CREATE TABLE `techargerecord` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `account_id`  int(11) DEFAULT NULL,
  `manager_id`  int(11) DEFAULT NULL,
  `manager_up_id`  int(11) NOT NULL DEFAULT '0',
  `createtime`  datetime NOT NULL,
  `techargeMoney`  int(11) NOT NULL,
  `mark`  varchar(255) DEFAULT NULL,
  `status`  char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `PK_TECHARGEREORD_ACCOUNT_ID` (`account_id`),
  KEY `PK_TECHARGEREORD_MANAGER_ID` (`manager_id`),
  KEY `PK_TECHARGEREORD_MANAGER_UP_ID` (`manager_up_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/* ###########################################################
## File Path :F:\BaiduYunDownload\duoheyi2\服务端安装文件\数据库\roledata\winnersinfo.frm
## Created with MySQL Version 5.5.53
## CREATE statement for table `winnersinfo`
########################################################### */
DROP TABLE IF EXISTS `winnersinfo`;
CREATE TABLE `winnersinfo` (
  `id`  int(11) NOT NULL AUTO_INCREMENT,
  `prize_id`  int(11) NOT NULL,
  `account_id`  int(11) NOT NULL,
  `createTime`  datetime NOT NULL,
  `awardTime`  datetime DEFAULT NULL,
  `status`  char(1) NOT NULL DEFAULT '0',
  `mark`  varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `PK_PRIZE_WINNERSINFO_ID` (`prize_id`),
  KEY `PK_ACCOUNT_WINNERSINFO_ID` (`account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
