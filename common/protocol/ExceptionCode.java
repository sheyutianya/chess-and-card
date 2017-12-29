package net.uyo.common.define;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

/**
 * 
* @ClassName: ExceptionCode 
* @Description: 这里定义提示码
* @author 刘锦新
* @date 2015年8月29日 下午3:56:24 
*
 */
public class ExceptionCode {
	private static Logger logger = LoggerFactory.getLogger(ExceptionCode.class);
	

	public static final int Ok 						 = 0;
	public static final int SysError                    = -1;//系统错误
	public static final int ConfigError					= -2;//配置表错误
	public static final int TypeNoMatch					= -3;//类型不匹配
	public static final int CodecError			    = -4;//加解密错误
	public static final int VersionError			    = -5;//协议号错误
	public static final int PlayerSAccountIsExist       = -101;
	public static final int PlayerInsertFail            = -102;
	public static final int PlayerNotExist              = -103;
	public static final int KeyRandomTypeInvalid        = -104;
	public static final int PetIdIsInvalid              = -105;
	public static final int ChipIdIsInvalid             = -106;
	public static final int ChipNumIsNotEnough          = -107;
	public static final int RandomItemFail              = -108;
	public static final int SignInHasDone               = -109;
	public static final int PetLevelIsMax               = -110;
	public static final int PetStarLevelIsMax           = -111;
	public static final int PetIdIsExist                = -112;
	
	public static final int LonginAcccountIsNull        = -113;//登录账号为空
	public static final int LoginPwdIsNull              = -114;//登录密码为空
	public static final int LoginDeviceIdIsNull         = -115;//登录设备号为空
	public static final int BindAccountIsNull           = -116;//绑定账号为空
	public static final int BindAccountPwdIsNull        = -117;//绑定账号密码为空
	
	public static final int EquipSyntheNull		    = -130;//装备合成上限
	public static final int ItemSyntheNull				= -131;//道具合成上限
	public static final int ItemNumLack				= -132;//道具不足
	public static final int stageBattleMax				= -133;//战斗上限
	public static final int playerSilverLack			= -134;//玩家银币不足
	public static final int skillIsMax					= -135;//技能达到上限
	public static final int playerNotFind		    = -136;//玩家未找到
	public static final int playerCharError         = -137;//角色名有非法字符
	public static final int userNotLogined          =-138;//账号未登录
	public static final int playerOtherLogined      =-139;//已经登录了其他角色,请先退出
	public static final int playeridError      =-140;//错误的角色ID
	public static final int areaIsNotStart     =-141;//服务器尚未启动,请稍等
	public static final int kikOutException    =-142;//顶号异常
	public static final int areaUpperlimit     =-143;//非常抱歉:当前在线人数已达到系统上限,请选择其他分区试试
	public static final int initHeroError = -144;//初始英雄异常
	public static final int initPlayerError = -145;//初始角色数据异常
	public static final int getPlayerError = -146;//获取在线玩家异常
	
	public static final int readEmailEmpty = -147;//读取邮件不存在
	public static final int readEmailRepeat = -148;//读取邮件重复
	
	public static final int playerFightError = -149;//玩家已在战斗中，战斗未结束，不可开始新战斗
	public static final int playerFightEmpty = -150;//此战斗Id不在战斗数据中
	
	
	public static final int stageEmpty = -151;//关卡不存在
	public static final int chapterIsNotOpen = -152;//章节未开启
	public static final int stageIsNotOpen = -153;//关卡未开启
	public static final int fightStrenghtNotEnough = -154;//战斗体力不够
	public static final int fightCountLimtIsEnough = -155;//超过关卡挑战次数 
	public static final int stageRestIsEnough = -156;//重置次数已用完
	public static final int moneyIsnotEnough = -157;//银币不够用
	public static final int openChestIsStarNotEnough = -158;//开宝箱 星级不够
	public static final int initPlayerDataEmpty = -159;//初始化玩家配置数据为空
	public static final int chapterBaoxiangNoConfig=-160;//章节宝箱配置不存在
	public static final int chapterBaoxiangRepeat=-161;//宝箱重复领取
	
	public static final int isNullPlayerName = -162;//空角色名
	public static final int isUsedPlayerName = -163;//角色名已被使用
	public static final int createPlayerNameExiption = -164;//随机角色名异常
	public static final int temporaryDoesNotSupportModifyPlayerName = -165;//暂不开放改名功能
	public static final int canotModifyPlayerAttr = -166;//不能修改玩家该属性
	public static final int playerNameBlockword   = -167;// 角色名含有违规字符
	
	public static final int strengthReachUppeerLimit = -168;// 体力达到最大上限值 不能增加
	public final static int paramOutOfrange = -169;//参数越界
	public final static int playerNameLengthRange = -170;//角色名长度超出界限
	public static final int stageMopupStarNoReach=-171;//关卡扫荡星级不够
	public static final int stageMopupdNoEliteStage = -172;//扫荡关卡不是精英关卡
	public static final int stageIsPass = -173;//猫咪抵押关卡，关卡已经通关
	public static final int stagePassIsNotByKitty = -174;//不能重复抵押通关
	public static final int accountBindIsExist = -175;//绑定账号已经存在，不能绑定
	public static final int askAccountBind = -176;//新账号并且有游客登录过，需要询问是否绑定，然后做后续操作
	public static final int dwardStarAwardStarsNotEnough = -177;//领取星星奖励，星星数不够
	
	
	
	//邮件操作定义-----------------------------------------------------通关--------------
	//读取的邮件为空
	public final static int emailReadEmpty			= -201;
	//重复读取邮件内容
	public final static int emailReadRepeat 		= -202;
	//邮件已经过期
	public final static int emailHadExpire			= -203;
	
	//背包操作定义-------------------------------------------------------------------
	//背包物品不够
	public final static int bagItemNotEnough		= -211;
	//背包物品数量超出
	public final static int bagItemNumOver			= -212;
	//背包物品配置为空
	public final static int bagItemConfigEmpty		= -213;
	//背包物品数据库操作异常
	public final static int bagItemDbError			= -214;
	//物品不能出售
	public final static int bagItemNotSell			= -215;
	//物品不能使用
	public final static int bagItemNotUseable		= -216;
	//物品背包中不存在
	public final static int bagItemNoExist			= -217;
	//背包物品合成金币不足
	public final static int bagCompositeGoldLess	= -218;
	//背包物品使用时目标不存在
	public final static int bagItemUseTargetNull	= -219;
	//背包物品不能购买
	public final static int bagItemNotBuy			= -220;
	//背包中使用体力达到上限
	public final static int bagUseStrengthLimit		= -221;
	
	//武将操作定义-------------------------------------------------------------------
	//武将没有获取到该装备
	public final static int heroEquipNoGet			= -231;
	//武将升级装备强化等级不够
	public final static int heroUpEquipLvEnough		= -232;
	//武将升星等级不够
	public final static int heroUpStarLvEnough		= -233;
	//武将不存在
	public final static int heroNoExist 			= -234;
	//星级已满
	public final static int heroStarIsTop			= -235;
	//此技能已经超过最大限制
	public final static int skillNoUp				= -236;
	//武将阵营不存在
	public final static int heroCampNoExist			= -237;
	//技能不存在
	public final static int skillNoExist			= -238;
	//技能点不够
	public final static int skillPointNoEnough		= -239;
	//武将杀气进阶等级不够
	public final static int heroUpOrderLvNoEnough	= -240;
	//武将官职升级等级不够
	public final static int heroUpOfficeLvNoEnough	= -241;
	//武将升级所需材料不够
	public final static int heroUpMaterialNoEnough	= -242;
	//武将等级已满
	public final static int heroLevelIsTop			= -243;
	//武将等级不能大于主公等级
	public final static int heroLevelIsGreaterPlayerLevel			= -244;
	
	//好友操作定义-------------------------------------------------------------------
	//申请加为好友处于CD状态
	public final static int friendApplyCD			= -251;
	//赠送好友体力处于CD状态
	public final static int friendStrengthCD		= -252;
	//已经是好友关系
	public final static int friendAlreadyExist		= -253;
	//好友操作目标不在线
	public final static int friendTargetOffline		= -254;
	//好友申请重复
	public final static int friendApplyRepeat		= -255;
	//好友DB操作错误
	public final static int friendDbError			= -256;
	//好友申请记录不存在
	public final static int friendAddNoExist		= -257;
	//好友ID角色不存在
	public final static int friendIdNoExist			= -258;
	//好友关系不存在
	public final static int friendRelationNoExist 	= -259;
	//获取推荐好友处于CD状态
	public final static int friendLookCD			= -260;
	
	//邀请平台好友操作定义------------------------------------------------------------
	//领取邀请平台好友奖励条件没达到不能领取
	public final static int platInviteRewardNoReach	= -270;
	//重复邀请平台好友奖励， 明日再来
	public final static int platInviteRewardRepeat 	= -271;
	
	
	//GM操作定义---------------------------------------------------------------------
	// 命令类型不规范
	public final static int gmCommandIrregular		= -281;
	// GM命令不存在
	public final static int gmCommandNoExist		= -282;
	// GM参数个数错误
	public final static int gmParamNumWrong			= -283;
	// GM目标玩家不在线
	public final static int gmTargetOffline			= -284;
	// GM指令执行异常
	public final static int gmCommandExcetpion		= -285;
	// GM指令参数类型不存在
	public final static int gmParamTypeNoExist		= -286;
	
	//任务操作定义---------------------------------------------------------------------
	//领取任务异常，任务Id/积分错误
	public final static int taskTaskError           = -291;
	//领取任务异常，任务状态不正确，只有可领取状态的任务才能领取
	public final static int taskTaskAwardStatusError= -292;
	//领取积分任务异常，积分错误
	public final static int taskPointError          = -293;
	
	//商店操作定义---------------------------------------------------------------------
	// 商店不存在
	public final static int shopNotExist			= -301;
	// 商店物品售完
	public final static int shopItemSellOut			= -302;
	// 商店物品配置信息为空
	public final static int shopItemConfigEmpty		= -303;
	// 商店物品购买时余额不足
	public final static int shopBalanceNotEnough	= -304;
	// 商店扣除余额失败
	public final static int shopDeductedBalanceFail = -305;
	// 商店配置信息为空
	public final static int shopConfigEmplty		= -306;
	// 商店刷新达到上限
	public final static int shopRefreshReachMax 	= -307;
	// 商店刷新失败
	public final static int shopRefreshFail			= -308;
	// 商店快捷购买没有的统计
	public final static int shopQuickBuyNoStat		= -309;
	// 商店快捷购买达到每日上限
	public final static int quickBuyReachLimit		= -310;
	// 商店快捷购买钻石不够
	public final static int quickBuyDiamondNoEnough	= -311;
	// 体力达到购买的最大值
	public final static int strengthReachBuyMaxNum  = -312;
	// 商店快捷购买技能点不为0
	public final static int quickBuySkillPointNoZero= -313;
	
	//PVP操作定义---------------------------------------------------------------------
	// 匹配对手失败
	public final static int matchEnemyFail			= -321;
	// Pvp开启异常，已经开启或等级不够
	public static final int pvpOpenError 			= -322;
	//城池不存在
	public static final int pvpCityNoExist          = -323;
	//城池状态错误
	public static final int pvpCityStatusError      = -324;
	//云块已开过，不能重复开启
	public static final int pvpCloudIsExist      = -325;
	//城池已开过，不能重复开启
	public static final int pvpCityIsExist      = -326;
	//城池侦查CD
	public static final int pvpInvestigateIsCd = -327;
	//城池进攻CD
	public static final int pvpFightIsCd = -328;
	//城池正在被进攻中\更换阵容中
	public static final int pvpIsAttacked = -329;
	//没有产出
	public static final int pvpNoOutPutItem = -330;
	//领取产出异常
	public static final int pvpOutPutItemError = -331;
	//云块不存在
	public static final int pvpCloudNoExist = -332;
	//侦查令不够
	public static final int pvpInvestigateNotEnough = -333;
	//军令不够
	public static final int PvpMilitaryOrderNotEnough = -334;
	//侦查令达到使用上限
	public static final int pvpInvestigateLimit = -335;
	//军令达到使用上限
	public static final int PvpMilitaryOrderLimit = -336;
	//有英雄已经驻守在其他城池
	public static final int PvpHeroIsExistCity = -337;
	//英雄PVP任务中
	public static final int heroStatusPvp = -338;
	//英雄巡逻任务中
	public static final int heroStatuspatrol = -339;
	//更换对手CD中
	public static final int pvpChanageMatchIsCd = -340;
	//云块下面没有宝箱
	public static final int pvpCloudChestNoExist= -341;
	//PVP没有上阵武将
	public final static int pvpNoSelectHero	= -342;
	
	
	//远征操作定义---------------------------------------------------------------------
	// 远征关卡未开启
	public final static int expeditionStageState	= -351;
	// 远征关卡战斗中
	public final static int expeditionStageFight	= -356;
	//远征关卡已打完
	public final static int expeditionStageOver	= -357;
	//远征使用恢复药水，没有可恢复武将
	public final static int expeditionRecoverHeroIsZore = -358;
	// 远征上阵武将前后不致
	public final static int expeditionHeroDifferent	= -352;
	// 远征上报数据异常
	public final static int expeditionUpDataError	= -353;
	// 远征没有上阵武将
	public final static int expeditionNoSelectHero	= -354;
	// 远征重生次数达到上限
	public final static int expeditionResetHpMax	= -355;
	//远征活动
	public static final int ExpitionLimitDate = -178;//活动未开启或者已结束
	public static final int ExpitionUnOpen = -179;//玩家未激活远征活动
	public static final int ExpitionBuyKeyLimit = -180;//玩家购买钥匙超过限制
	public static final int ExpitionOpenBoxError = -181;//宝箱未开启
	public static final int ExpitionOpenBoxIsOver = -182;//宝箱已经领取过了

	//试炼操作定义---------------------------------------------------------------------
	// 试炼关卡今日不开放
	public final static int trialStageNoOpen		= -361;
	// 试炼关卡等级限制
	public final static int trialStageLvLimit		= -362;
	// 试炼关卡挑战次数达到上限
	public final static int trialStageFightMax 		= -363;
	// 试炼关卡体力不够
	public final static int trialStrengthNoEnough	= -364;
	// 试炼扫荡星级不够
	public final static int trialMopupStarNoReach	= -365;
	// 试炼扫荡卡不够
	public final static int trialMopupItemNoEnough	= -366;
	
	//巡逻任务异常定义-------------------------------------------------------
	//巡逻任务不存在
	public final static int patrolTaskIsNoExist	= -371;
	//巡逻任务状态错误
	public final static int patrolTaskStatusIsError	= -372;
	//巡逻任务未达到完成时间
	public final static int patrolTaskNotCompletionedTime	= -373;
	//钻石不够用
	public final static int diamondnoEnough	= -374;
	//替换巡逻任务次数已经用完
	public final static int patrolReplaceUseUp	= -375;
	
	
	//公会操作定义---------------------------------------------------------------------
	// 没有达到公会开放等级，无法执行此操作
	public final static int unionNoReachOpenLv 		= -380;
	// 已经加入公会，执行操作前先退出公会
	public final static int unionHadJoin			= -381;
	// 创建公会需要钻石不够
	public final static int unionDiamondNoEnough	= -382;
	// 创建公会设置错误
	public final static int unionInvalidSetting		= -383;
	// 公会查询条件为空
	public final static int unionQueryConditonNull 	= -384;
	// 没有加入任何公会
	public final static int unionNoJoinAnyone		= -385;
	// 没有权限执行此操作.
	public final static int unionNoPermissionOp		= -386;
	// 该公会不存在，或已经解散
	public final static int unionNoExist			= -387;
	// 没有申请记录
	public final static int unionNoApplyRecord		= -388;
	// 公会成员达到上限，无法添加 
	public final static int unionReachMemberLimit	= -389;
	// 公会长暂不支持的管理操作
	public final static int unionNoSupportOp		= -390;
	// 对方非公会成员
	public final static int unionTargetNoMembers	= -391;
	// 公会会长，公会还有成员，不能申请退出公会
	public final static int unionChairmanCanotQuit	= -392;
	// 今日频繁退出公会
	public final static int unionTooMuchQuit		= -393;
	// 今日频繁解散公会
	public final static int unionTooMuchDissolve	= -394;
	// 今日频繁申请公会
	public final static int unionTooMuchApply		= -395;
	// 公会活动达今日上限
	public final static int unionActivityReachLimit	= -396;
	// 公会活动花费不够
	public final static int unionActitityMoneyLess	= -397;
	// 公会活动宝箱重复领取
	public final static int unionActivityBoxRepeat	= -398;
	// 公会活动宝箱未达成不能领取
	public final static int unionActivityBoxNoReach	= -399;
	// 公会红包已经不存在
	public final static int unionHongbaoNoExist		= -430;
	// 公会红包重复领取
	public final static int unionHongbaoGetRepeat	= -431;
	//公会会长只能有一名
	public final static int unionChairmanOnlyOne	= -432;
	//超过公会人数限制，不能再加入
	public final static int unionMembersLimt   		= -433;
	//申请加入公会PVP积分不够
	public final static int unionMembersPvpRnakNoEnough = -434;
	//公会红包手慢领完了
	public final static int unionHongbaoGetFinish	= -435;
	//公会红包次数用尽提示
	public final static int unionSystemHBReachLimit = -436;
	//个人红包抢、发次数用尽提示
	public final static int unoinPersonHBReachLimit = -437;
	//公会战报名成员数量不够
	public final static int unionPkApplyMemberLess 	= -438;
	//公会战当前时间内不能执行该操作
	public final static int unionPkNotAppointTime	= -439;
	// 公会捐卡信息不存在
	public final static int unionGiftCardNoExist 	= -440;
	//公会战报名钻石不够
	public final static int unionPKDiamondNoEnough 	= -441;
	
	//科技系统异常定义--------------------------------------------
   //科技系统棋子移动，剩余步数不足
	public final static int technologySurplusStepNoEnough = -400;
	//武将科技属性不存在
	public final static int technologyAttrIsNoExist = -401;
	//武将科技属性提升已经达到上限
	public final static int technologyAttrUpIsLimit = -402;
	
	//武将装备强化、附魔---------------------------------------------
	//武将装备强化，武将等级不够
	public final static int equipEnhancedHeroLveleNoEnough= -421;
	//武将装备强化，达到强化上限
	public final static int equipEnhancedIsLimit 	= -422;
	//武将装备附魔，达到附魔上限
	public final static int equipEnchantIsLimit 	= -423;
	//武将装备强化，金钱不够
	public final static int equipEnhancedMoneyNoEnough= -424;
	//武将装备附魔，道具不够
	public final static int equipEnchantItemNoEnough= -425;
	
	//抽卡---------------------------------------------
	//抽卡类型错误
	public final static int drawCardTypeError = -501;
	//抽卡CD中
	public final static int drawCardCD = -502;
	//抽卡免费次数已用完
	public final static int drawCardFreeCountIsOver = -503;
	//已经领取过新手礼包
	public final static int newGoodieBagRepeat	= -504;
	//活动操作定义---------------------------------------------------------------------
	//今日重复签到
	public final static int todaySigninRepeat		= -521;
	//累计签到奖励已经领取过了
	public final static int cumulativeSigninsRepeat		= -522;
	//累计签到奖励还没到领取时间
	public final static int cumulativeSigninsIsErrorTime		= -523;
	// 重复领取好评奖励
	public final static int gradeStarRewardRepeat = -524;
	// 已经放了好评奖励
	public final static int gradeStarRewardGiveup = -525;
	
	//聊天系统定义
	//聊天内容不能为空
	public final static int chatIsEmpty = -601;
	//对方不在线，不能发生信息
	public final static int chatPlayerUnline=-602;
	//聊天CD中
	public final static int chatIsCd =-603;
	//还未加入公会，不能发生公会信息
	public final static int chatUnionIsNotExit=-604;
	//解除屏蔽、屏蔽失败
	public final static int chatBlackFailure = -605;
	//对方超过三条未回复，则提示玩家
	public final static int chatUnreadCount = -606;
	//捐卡申请CD中
	public final static int GiftCardCD = -607;
	//捐卡申请卡牌类型错误
	public final static int GiftCardTypeError = -608;
	//捐赠者和被捐赠者不在同一公会
	public final static int GiftCardUnionNoSame = -609;
	//已经超过了捐赠价值上限
	public final static int UnionGiftCardValueLimit = -610;
	//已经超过了接受捐赠价值上限
	public final static int UnionAppectGiftCardValueLimit = -611;
	//已经超过援助卡片对每个人最多捐赠数量
	public final static int UnionGiftForPersonLimit = -612;
	//不能捐赚该品质的卡牌
	public final static int unionCantGiftCardQuaility = -613;
	
	//秘境操作定义---------------------------------------------------------------------
	// 秘境房间不存在
	public final static int secretRoomNoExist 		= -621;
	// 秘境地图不够
	public final static int secretMapNoEnough		= -622;
	// 秘境已经加入了房间
	public final static int secretHadJoinRoom		= -623;
	// 秘境章节不存在
	public final static int secretChapterNoExist	= -624;
	// 秘境还未加入房间
	public final static int secretNoJoinRoom		= -625;
	// 秘境不是队长无法执行操作
	public final static int secretNoCaptain			= -626;
	// 秘境达到人数限制
	public final static int secretReachPersonLimit	= -627;
	// 秘境状态不对，不能执行操作
	public final static int secretStateNoRight		= -628;
	// 秘境关卡没派上阵武将
	public final static int secretNoSelectHero		= -629;
	// 秘境关卡正在被攻击
	public final static int secretStageAttacking 	= -630;
	// 秘境关卡已经被占领
	public final static int secretStageOccupied		= -631;
	// 秘境上报数据异常
	public final static int secretUpDataError		= -632;
	// 秘境上报上阵武将前后不致
	public final static int secretHeroDifferent		= -633;
	
	//系统开启错误－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
	public final static int systemOpenError         = -700;
	//pvp主城产出为0
	public final static int pvpMainCityOutPutIsNull = -701;
	//pvp科技不存在
	public final static int pvpTechNoExist          = -702;
	//pvp科技等级已经满级
	public final static int pvpTechLevelUperLimit         = -703;
	//pvp科技升级材料不够
	public final static int pvpTechUpItemsNoEnough          = -704;
	
	//城池在保护时间内
	public static final int pvpAttackedIsProtectionTime = -705;
	//pvp更换对手，次数花费金钱不够
	public static final int pvpChanageMatchMoneyNoEnough = -706;
	
	//pvp科技等级升级，主城等级不够
	public final static int pvpTechUpMianCityLevleNoEnough = -707;
	//pvp主城升级时间未到
	public final static int pvpMainCityUpTimeError         = -708;
	//pvp主城等级已经满级
	public final static int pvpMainCityLevelUperLimit         = -709;
	//pvp主城升级材料不够
	public final static int pvpMainCityUpItemsNoEnough          = -710;
	//pvp仓库等级已经满级
	public final static int pvpStoreHoseLevelUperLimit         = -711;
	//pvp仓库升级材料不够
	public final static int pvpStoreHoseUpItemsNoEnough          = -712;
	//收集城池产出时间没到
	public final static int pvpCityCollectiontimeError          = -713;
	//收集主城产出仓库未满，不能收集
	public final static int pvpMainCityCollectiontimeError          = -714;
	
	//一键领取邮件附件异常,没有可领取附件的邮件
	public final static int emailNoAttchment          = -801;
	//战斗道具购买错误
	public final static int fightItemBuyError          = -802;
	
	//实时PVP操作定义---------------------------------------------------------------------
	// 实时pvp检验失败
	public final static int pvpVerificationFail		= -901;
	// 实时pvp当前状态不能执行该操作
	public final static int pvpStateCanNotOperation = -902;
	// 实时pvp当前不是轮到自己的回合，不能执行操作
	public final static int pvpNoTurnSelfOperation	= -903;
	// 实时pvp数据前后不一致
	public final static int pvpDataDifferent		= -904;
	// 实时pvp重复选取该武将
	public final static int pvpSelectHeroRepeat		= -905;
	// 实时pvp选择的武将没激活
	public final static int pvpSelectHeroNoExist	= -906;
	// 实时pvp宝箱处理CD中
	public final static int pvpChestOpenCdTime		= -907;
	// 实时pvp胜场宝箱星星数不够
	public final static int pvpChestOpenStarLess	= -908;
	// 没有可移动的棋子，战斗失败
	public final static int pvpSelfChestDeadFail	= -909;
	// 对方没有可移动的棋子，战斗胜利
	public final static int pvpEnemyChestDeadSuccess= -910;
	
	
	//活动错误码 -10001到-20001活动用 -----------------------------------------------------------------------------------
	// 活动没有
	public final static int activityIdErro	= -10001;
	// 登录有礼天数错误
	public final static int activityLoginDayErro	= -10002;
	// 登录有礼未达成或者已领取
	public final static int activityLoginDayUnderage	= -10003;
	//活动参数错误
	public final static int activityParameterError	= -10004;
	
	//激活码奖励领取-921-929激活码用-----------------------------------------------------------
	//无效激活码
	public final static int activationNotExistsError=-921;
	//激活码已领取
	public final static int activationAlreadyError=-922;
	//激活码已过期
	public final static int activationOverdueError=-923;
	
	//一元购活动-941-949用-----------------------------------------------------------
	//宝箱已领取
	public final static int onePurchaseBoxAlreadyError=-941;
	//玩家宝箱不存在
	public final static int onePurchaseBoxNotError=-942;
	//没到宝箱开启时间
	public final static int onePurchaseBoxNotTimeError=-943;

}
