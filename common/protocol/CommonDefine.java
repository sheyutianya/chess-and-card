package net.uyo.common.define;

import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

import net.uyo.frame.utils.Tool;


/**
 * 
* @ClassName: CommonDefine 
* @Description: 各种静态定义
* @author 刘锦新
* @date 2015年8月25日 下午2:32:54 
*
 */
public class CommonDefine {

	
	//临时(用于流量记录)
	public static boolean isOpenNetTest = true;
	public static Map<Long,Long> inBytes = new ConcurrentHashMap<Long,Long>();
	public static Map<Long,Long> outBytes = new ConcurrentHashMap<Long,Long>();
	public static long allInBytes = 0;//入口流量
	public static long allOutBytes = 0;//出口流量
	// 临时ID开始
	public final static int TEMP_DBID_BEGIN = 100000;
	// 玩家状态定义(是否在线、封号等)
	public final static int STATUS_NONE = 0; // 无
	public final static int STATUS_ONLINE = 1 << 0; // 在线

	//分区状态
	public final static int server_status_none = 0;//0=什么都不是
	public final static int server_status_full = 1;//满载
	public final static int server_status_busy = 2;//繁忙
	public final static int server_status_idle = 3;//通畅
	public final static int server_status_free = 4;//空闲
	public final static int server_status_maintenance = 11;//维护
	public final static int server_stop_wait_time = 60;//关服等待时间 秒
	//分区状态设定
	public static final float AREA_STATE_FREE_PERCENT = 0.4f;//流畅
	public static final float AREA_STATE_BUSYNESS_PERCENT = 0.6f;//繁忙
	public static final float AREA_STATE_HOT_PERCENT = 0.8f;//爆满
	//自动保存在线玩家的时间间隔,即最大允许的回档时间
	public final static int AUTO_SAVE_TIME_MINUTE = 15;//分散到15分钟里,只能0~59
	//登录用户类型 0普通玩家账号,1游客账号,2超级账号
	public final static int PLAYER_TYPE_NURMAL = 0;//普通玩家账号
	public final static int PLAYER_TYPE_GUEST = 1;//游客访客账号
	public final static int PLAYER_TYPE_GM = 2;//超级账号(gm)
	public final static int UNION_PK_SCORE_COREE = 100000000; // 公会战积分每次修正数值
	//渠道
	public final static int CHANNELID_SELF = 10001;//自用渠道
	// 同一个好友可以赠送数量
	public final static int SAME_FRIEND_GIVE_NUM = 	3;
	// 能显示的最大日志数量
	public final static int UNION_LOG_MAX_NUM		= 100;
	// 公会总战力排行榜  ***排行榜往后面加
	public final static String RankUnionFightKey 	= "RankUnionFight";
	// 公会总奖杯排行榜
	public final static String RankUnionCupKey		= "RankUnionCup";
	// 武将战斗力排行榜
	public final static String RankHeroFightKey		= "RankHeroFight";
	// 招呼师总战斗力排行榜
	public final static String RankTotalFightKey	= "RankTotalFight";
	// 最高阵形战斗力排行榜
	public final static String RankHightFightKey	= "RankHightFight";
	// 关卡通关星星排行榜
	public final static String RankStageStarKey		= "RankStageStar";
	// PVP积分排行榜
	public final static String RankPvpScoreKey 		= "RankPvpScore";
	// PVP奖杯排行榜
	public final static String RankPvpCupKey		= "RankPvpCup";
	// 公会战积分排行榜
	public final static String RankUnionPkKey		= "RankUnionPk";
	//夺宝排行榜(远征)
	public final static String RankIndianaKey		= "RankIndiana";
	// 公会战报名申请人数
	public final static String UnionPkApplyNumKey	= "UnionPkApplyNum";
	
	// 公会战决赛，半决赛排名
	public final static int union_pk_halfmatch_num	= 16;
	public final static int union_pk_finalmatch_num = 4;
	//初始角色默认值
	public final static int player_default_Diamond = 10000;//钻石数量
	public final static int player_default_Exp = 0;//经验
	public final static int player_default_Icon = 2001;//图标
	public final static int player_default_serliver = 10000;//银币
	public final static int player_default_infinite = 0;//无尽币
	public final static int player_default_trial = 0;//试炼币
	public final static int player_default_honour = 0;//荣誉币
	public final static int player_default_PlayerLevel = 1;//玩家等级
	public final static int player_default_IconType = 1;//图标类型1:代表英雄ID，2，代表特殊icon
	public final static int player_default_VipExp = 0;//vip等级
	public final static int player_default_VipLevel = 0;//VIP经验
	public final static int player_default_Strength = 10000;//体力值
	
//	public final  static int player_default_level_Max = 79;//玩家最大等级
//	public final static int hero_default_level_Max = 79;//英雄最大等级
	
	//初始英雄默认值
	public final static int player_default_hero_exp = 0;//经验
	public final static int player_default_hero_level = 1;//等级
	public final static int player_default_hero_star = 1;//星级
	public final static int player_default_hero_skill_level = 1;//技能等级
	/**英雄状态 0,无；1，pvp守城；2，巡逻中*/
	public final static short player_hero_status_none = 0;//
	public final static short player_hero_status_pvp = 1;//
	public final static short player_hero_status_patrol = 2;//
	
	//章节默认值
	public final static int player_default_chapter_start_num = 0;//默认星级
	public final static int player_default_chapter_State =2;//默认状态1,已通关 2，播放章节过度动画 3，可打章节
	public final static int Player_chapter_state_pass = 1;
	public final static int player_chapter_state_ok = 3;
	public final static int player_default_chapter_chest = 0;//默认宝箱状态 0未开启 1开启
	public final static int player_chapter_chapter_chest1 = 1;
	//关卡默认值
	public final static int stage_default_reset_num = 0;//重置次数
	public final static int stage_default_battle_num = 0;//当日战斗次数
	public final static int stage_default_stage_state = 2;//状态1,已通关 2，播放关卡过度动画 3，可打关卡 4,猫咪抵押通关
	public final static int stage_state_pass = 1;
	public final static int stage_state_ok = 3;
	public final static int stage_state_kitty = 4;
	public final static int stage_default_star = 0;//默认星级
	// 公会长和普通成员
	public final static int union_jobtitle_chiarman = 1;// 会长
	public final static int union_jobtitle_vice_chiarman = 2;// 副会长
	public final static int union_jobtitle_elder = 3;// 长老
	public final static int union_jobtitle_member = 4;// 成员
	// 公会审批类型
	public final static int union_approve_public = 0; //任务人可以加入
	public final static int union_approve_protected = 1;//需要批准
	public final static int union_approve_private = 2;//不接受任何人
	// 公会状态
	public final static int union_state_dissolve = 0; //公会解散
	public final static int union_state_run = 1;//公会运作状态
	public final static String union_no_join = "暂时未加入公会";
	// 公会红包最低金额
	public final static int union_hongbao_minimum_money = 1;
	
	public final static int secret_state_dissolve = 0; //秘境解散
	public final static int secret_state_team = 1;//秘境组队中
	public final static int secret_state_run = 2;//秘境副本中
	
	public final static int stage_difficulty_common =0;//主线/普通关卡
	public final static int stage_difficulty_elite =1;//精英关卡
	public final static int stage_difficulty_trial =2;//试炼关卡
	public final static int stage_difficulty_GVE =3;//GVE关卡
	//道具默认值
	public final static int item_default_isnew =1;//是否新增 1是，0否
	public final static int item_isnew_no = 0;
	//初始道具1
	public final static int item_init_id_1 = 100001;
	public final static int item_init_num_1 = 50;
	//初始道具2
	public final static int item_init_id_2 = 100002;
	public final static int item_init_num_2 = 40;
	//初始章节
	public final static int chapter_init_id = 101;
	//初始关卡
	public final static int stage_init_id =10101;
	//英雄阵容最小个数
	public final static int player_default_camp_count = 1;
	//公会免费创建数
	public final static int union_create_free_count = 30;
//	public final static int union_create_free_count = 4;
	public static int getMoneyItemId(int moneyType){
		   int moneyItemId = 0;
		   switch (moneyType) {
			case CommonDefine.MONEY_TYPE_MONEY1:
				moneyItemId = CommonDefine.ITEM_SILVER_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY2:
				moneyItemId = CommonDefine.ITEM_DIAMOND_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY3:
				moneyItemId = CommonDefine.ITEM_TRIAL_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY4:
				moneyItemId = CommonDefine.ITEM_INFINITE_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY5:
				moneyItemId = CommonDefine.ITEM_HONOUR_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY6:
				moneyItemId = CommonDefine.ITEM_INVESTIGATE_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY7:
				moneyItemId = CommonDefine.ITEM_MILITARYORDERS_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY8:
				moneyItemId = CommonDefine.ITEM_PATROL_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY9:
				moneyItemId = CommonDefine.ITEM_GUILD_ID;
				break;
			case CommonDefine.MONEY_TYPE_MONEY10:
				moneyItemId = CommonDefine.IITEM_SKILL_POINT;
				break;
			default:
				break;
			}
		   return moneyItemId;
	   }
	//货币定义
	public final static int MONEY_TYPE_NONE = 0;//无
	public final static int MONEY_TYPE_MONEY1 = 1;//银币
	public final static int MONEY_TYPE_MONEY2 = 2;//钻石
	public final static int MONEY_TYPE_MONEY3 = 3;//试炼币
	public final static int MONEY_TYPE_MONEY4 = 4;//无尽币
	public final static int MONEY_TYPE_MONEY5 = 5;//荣誉币
	public final static int MONEY_TYPE_MONEY6 = 6;//侦查令
	public final static int MONEY_TYPE_MONEY7 = 7;//军令
	public final static int MONEY_TYPE_MONEY8 = 8;//巡逻币
	public final static int MONEY_TYPE_MONEY9 = 9;//公会贡献币
	public final static int MONEY_TYPE_MONEY10 = 10;//技能点
	
	//策划已经立下保证，打死不修改ID
	public final static int ITEM_DIAMOND_ID 	= 5000001; 	//钻石ID
	public final static int ITEM_SILVER_ID	 	= 5000002;	//银币ID
	public final static int ITEM_STRENGTH_ID 	= 5000003;	//体力ID
	public final static int ITEM_EXP_ID		 	= 5000004;	//招唤师ID
	public final static int ITEM_TRIAL_ID	 	= 5000006;	//试炼币ID 
	public final static int ITEM_INFINITE_ID	= 5000007;	//无尽币ID
	public final static int ITEM_HONOUR_ID		= 5000008;	//荣誉币ID
	public final static int ITEM_PATROL_ID		= 5000009;	//巡逻币
	public final static int ITEM_GUILD_ID		= 5000010;	//公会贡献币
	public final static int ITEM_MILITARYORDERS_ID= 5000011;//军令
	public final static int ITEM_INVESTIGATE_ID	= 5000012;	//侦查令
	public final static int IITEM_SKILL_POINT	= 5000013;	//技能点
	public final static int ITEM_HONOUR_SCORE	= 5000014;	//荣誉积分
	public final static int ITEM_UNLIMIT_STRENGTH= 209003;//无限爱心(体力)
	public final static int ITEM_KITTY_ID 		 = 107009;//猫咪
	//PVP产出类道具
	public final static int ITEM_FOOD_ID	    = 5000015;	//粮草
	public final static int ITEM_WOOD_ID	    = 5000016;	//木材
	public final static int ITEM_METAL_ID	    = 5000017;	//金属
	public final static int ITEM_GRANITE_ID	    = 5000018;	//水晶矿脉
	public final static int ITEM_MARBLE_ID	    = 5000019;	//大理石
	
	public final static int CHESTS_FIRST_CARD_ID= 800001;	//首次招募（抽卡）宝箱
	public final static int CHESTS_FIRST_PVP_ID	= 800002;	//第1个PVP箱子
	public final static int CHESTS_SECOND_PVP_ID= 800003;	//第2个PVP箱子
	public final static int CHESTS_THIRD_PVP_ID	= 800004;	//第3个PVP箱子
	public final static int CHESTS_FOURTH_PVP_ID= 800005;	//第4个PVP箱子
	public final static int CHESTS_FIFTH_PVP_ID	= 800006;	//第5个PVP箱子
	
	
	public final static int ITEM_FRIEND_STRENGTH_ID = 201003; // 小体力药水物品(主要用玩好友赠送体力）
	public final static int ITEM_INTERMEDIATE_EXPERIENCE_POTION_ID = 203001;//中级经验药水
	
	public final static int ITEM_COPPER_KEY_ID = 5000021;//远征铜钥匙
	public final static int ITEM_SILVER_KEY_ID = 5000021;//远征银钥匙
	public final static int ITEM_GOLD_KEY_ID = 5000021;//远征金钥匙
	public final static int ITEM_RECOVER_POINT_ID = 5000020;//远征恢复药水
	
	public final static int COPPER_KEY_LIMIT_NUM = 3;//远征铜钥匙上限
	public final static int SILVER_KEY_LIMIT_NUM = 2;//远征银钥匙上限
	public final static int GOLD_KEY_LIMIT_NUM = 1;//远征金钥匙上限
	
	//扫荡券固定道具Id
	public final static int fight_Mopup_itme_id= 203004;
	//战斗相关定义
	public final static int fight_start_strength_default = 1;//战斗开始之前默认扣取体力
	//每天关卡刷新重置次数
	public final static int stage_default_rest_count = 2;
	//每天重置数据时间小时点,改写成读取配置表数据，这里的配置只有在读配置没有的情况下 使用by jinxin
	public final static int day_rest_hour = 9;
	// 推荐好友刷新数量
	public final static int friend_refresh_look_num = 100;
	// 推荐好友数量
	public final static int friend_look_num = 5;
	// 概率基础值
	public final static int probability_base_value = 100000;
	
	/**任务类型**/
	//主线任务
	public final static int task_type_main = 1;
	//支线任务
	public final static int task_type_branch = 2;
	//日常任务
	public final static int task_type_day = 3;
	//成就任务
	public final static int task_type_achievement = 4;
	/**任务状态，0：未完成，1：可领取奖励，2：已领取奖励**/
	public final static int task_status_unfinished = 0;
	public final static int task_status_reward =1;
	public final static int task_status_finished = 2;
	/**积分任务状态 0：未领取，1：已领取*/
	public final static int task_point_undarw = 0;
	public final static int task_point_darwed = 1;
	/**任务条件定义**/
	public final static int task_condition_1 = 1;
	public final static int task_condition_2 = 2;
	public final static int task_condition_3 = 3;
	public final static int task_condition_4 = 4;
	public final static int task_condition_5 = 5;
	public final static int task_condition_6 = 6;
	public final static int task_condition_7 = 7;
	public final static int task_condition_8 = 8;
	public final static int task_condition_9 = 9;
	public final static int task_condition_10 = 10;
	public final static int task_condition_11= 11;
	public final static int task_condition_12 = 12;
	public final static int task_condition_13 = 13;
	public final static int task_condition_14 = 14;
	public final static int task_condition_15 = 15;
	public final static int task_condition_16= 16;
	public final static int task_condition_17 = 17;
	public final static int task_condition_18 = 18;
	public final static int task_condition_19 = 19;
	public final static int task_condition_20 = 20;
	public final static int task_condition_21 = 21;
	public final static int task_condition_22 = 22;
	public final static int task_condition_1001 = 1001;
	public final static int task_condition_1002 = 1002;
	public final static int task_condition_1003 = 1003;
	public final static int task_condition_1004 = 1004;
	public final static int task_condition_1005 = 1005;
	public final static int task_condition_1006 = 1006;
	public final static int task_condition_1007 = 1007;
	public final static int task_condition_1008 = 1008;
	public final static int task_condition_1009 = 1009;
	public final static int task_condition_1010 = 1010;
	public final static int task_condition_1011 = 1011;
	public final static int task_condition_1012 = 1012;
	public final static int task_condition_1013 = 1013;
	public final static int task_condition_1014 = 1014;
	public final static int task_condition_1015 = 1015;
	public final static int task_condition_1016 = 1016;
	public final static int task_condition_1017 = 1017;
	public final static int task_condition_1018 = 1018;
//	public final static int task_condition_1019 = 1019;
//	public final static int task_condition_1020 = 1020;
	public enum TaskConditon{
		condition_1(1),//主线通关
		condition_2(2),//精英通关
		condition_3(3),//试炼关卡
		condition_4(4),//GVE关卡
		condition_5(5),//强化装备次数
		condition_6(6),//升级技能次数
		condition_7(7),//武将强化次数
		condition_8(8),//抽卡
		condition_9(9),//PVP胜利次数
		condition_10(10),//PVP参与次数
		condition_11(11),//成功挑战哈迪斯
		condition_12(12),//提升星级次数（武将突破）
		condition_13(13),//登录次数
		condition_14(14),//加入公会
		condition_15(15),//武将升级次数
		condition_16(16),//武将杀气进阶次数
		condition_17(17),//赠送体力
		condition_18(18),//点金手
		condition_19(19),//购买体力
		condition_20(20),//消耗钻石
		condition_21(21),//邀请好友
		condition_22(22),//索要体力
		condition_1001(1001),//装备品阶达到
		condition_1002(1002),//技能等级达到
		condition_1003(1003),//科技等级达到
		condition_1004(1004),//洗练等级
		condition_1005(1005),//拥有好友
		condition_1006(1006),//等级达到
		condition_1007(1007),//战力达到
		condition_1008(1008),//无尽挑战层数
		condition_1009(1009),//竞技场排名
		condition_1010(1010),//通关公会副本
		condition_1011(1011),//VIP等级达到
		condition_1012(1012),//收集英雄个数
		condition_1013(1013),//收集特定英雄
		condition_1014(1014),//收集星级英雄
		condition_1015(1015),//任意武将强化等级
		condition_1016(1016),//某个时间段在线
		condition_1017(1017),//排行榜排名
		condition_1018(1018);//拥有N阶的武将多少个
//		condition_1019(1019),//进行一次巅峰对决
//		condition_1020(1020);//巅峰对决胜利一场
		
		private int value = 0;
		TaskConditon(int value){
			this.value=value;
		}
		public int value(){
			return value;
		}
	}
	// cd类型定义
	public enum ECDType {
		eGameDataRefreshHour(1),	// 游戏数据刷新时间点
		eFriendStrengthCD(2),		// 好友体力赠送CD时间
		eFriendLookCD(3),			// 好友推荐间隔CD时间
		eSecretStoreCD(4),			// 神秘商店刷新CD时间
		eTravelStoreCD(5),			// 旅行商店刷新CD时间
		eTrialStoreCD(6),			// 试炼商店刷新CD时间
		ePVPStoreCD(7),				// PVP商店刷新CD时间
		eEndlessStoreCD(8),			// 无尽商店刷新CD时间
		ePVPFightCD(9),				// PVP战斗刷新CD时间
		eTrialFightCD(10),			// 试炼战斗刷新CD时间
		eFriendApplyCD(11),			// 好友申请刷新CD时间
		eStrengthRecoverCD(12),		// 体力自然恢复CD时间
		ePvPArmyTokenRecoverCD(13),	// PVP军令恢复CD时间
		ePvPSearchTokenRecoverCD(14),//PVP侦查令恢复CD时间
		ePvPSearchCD(15),			// PVP侦察CD
		ePvPAttackCD(16),			// PVP攻击CD
		eExpeditionRecoverHour(17),	// 远征英雄重置CD时间
		eSkillPointCD(18),			// 技能点重置CD时间
		eRankRefreshCD(19),			// 排行榜刷新CD时间
		eGoldCardFreeCD(20),        // 金币免费抽卡CD
		ePvPRankRewardCD(21),		// PVP排名奖励
		eDiamondCardFreeRefreshHour(22),// 钻石免费抽卡次数重置时间
		eGoldCardFreeRefreshHour(23),// 金币免费抽卡次数重置时间
		ePvpDropChestLv1(24),		// 实时PVP掉落宝箱级别1CD时间
		ePvpDropChestLv2(25),		// 实时PVP掉落宝箱级别2CD时间
		ePvpDropChestLv3(26),		// 实时PVP掉落宝箱级别3CD时间
		ePvpDropChestLv4(27),		// 实时PVP掉落宝箱级别4CD时间
		ePvpDropChestLv5(28),		// 实时PVP掉落宝箱级别5CD时间
		ePvpDropChestLv6(29),		// 实时PVP掉落宝箱级别6CD时间
		
		eGiftCardValueCD(30),		// 公会捐赠卡牌价值刷新时间
		eGiftCardApplyCD(31),		// 公会请求支援卡牌的时间cd
		
		ePvpOlFreeChestCD(33),		// 实时pvp免费宝箱CD时间
		ePvpOlStarChestCD(34),		// 实时PVP星级宝箱CD时间
		ePvpDropChestLv9(35),		// 实时PVP掉落宝箱级别0CD时间
		eHongbaoFreeRefreshHour(36),// 系统红包刷新时间
		eHongbaoPersonRefreshHour(37),//个人红包收发刷新时间
		
		eGameLocalDeleteMessageTime(38),//游戏反馈本地消息删除时间
		eExpitionedCopperKey(39),//远征活动铜钥匙恢复CD时间
		eExpitionedSilverKey(40),//远征活动银钥匙恢复CD时间
		eExpitionedGoldKey(41);//远征活动金钥匙恢复CD时间
		private int value = 0;
		
		ECDType(int order) {
			this.value = order;
		}
		
		public int value() {
			return value;
		}
	}
	
	// 武将技能开放类型
	public enum ESkillOpenType {
		eSkillInitOpen(1),			// 初始化时开放技能
		eSkillUpStarOpen(2),		// 升级时开放技能
		eSkillWakeOpen(3);			// 常见醒时开放技能
		
		private int value = 0;
		
		ESkillOpenType(int order) {
			this.value = order;
		}
		
		public int value() {
			return value;
		}
	}
	//英雄品质
	public enum EHeroQuality{
		eGeneral(1),		//普通
		eRare(2),			//稀有
		ePic(3),			//史诗
		eTradition(4);		//传说
		
		private int value = 0;
		
		EHeroQuality(int quality) {
			this.value = quality;
		}
		//品质对应的捐赠价值
		public static int HeroValue(int quality){
			switch (quality) {
			case 1:
				return 1;
			case 2:
				return 10;
			case 3:
				return 100;
			case 4:
				return 1000;
			default:
				return 0;
			}
		}
		public static EHeroQuality valueOf(int quality){
			switch (quality) {
			case 1:
				return eGeneral;
			case 2:
				return eRare;
			case 3:
				return ePic;
			case 4:
				return eTradition;
			default:
				return null;
			}
		}
		public int value() {
			return value;
		}
	}
	
	//玩家棋盘类型
	public enum EChessboardType{
		eTechnology(net.uyo.common.define.constant.TechnologyChessboardJson.class);//科技系统棋盘
		private Class value = null;
		EChessboardType(Class value){
			this.value=value;
		}
		public Class value(){
			return value;
		}
	}
	
	//玩家日志类型
	public enum ELogType{
		ePVPLog(net.uyo.common.define.constant.ExpeditionLogJson.class);//pvp日志
		private Class value =null;
		ELogType(Class value){
			this.value=value;
		}
		public Class value(){
			return value;
		}
	}
//	//玩家PVP日志类型
//	public enum EPVPLogType{
//		//0异族入侵，被山贼占领，1城池被进攻，2城池被攻陷，3起火，4内乱，5异族入侵，抢夺一次资源，6抵抗异族入侵，7灭火
//		eCounterattack(0),//异族入侵，被山贼占领
//		eAttack(1),//被进攻
//		eCompromised(2),//被攻陷
//		eOnFire(3),//起火
//		eCivilStrife(4),//内乱
//		eIvade(5),//异族入侵，抢夺一次资源
//		eResistanceIvade(6),//抵抗异族入侵
//		eOutFire(7);//灭火
//		private int value = 0;
//		EPVPLogType(int value){
//			this.value = value;
//		}
//		public int value(){
//			return value;
//		}
//	}
	
	// 邮件配置类型
	public enum EEmailConfig {
		eCreateRoleEmail(10001), 	// 创建角色邮件
		ePvpAttacked(10002),		//PVP城池被攻陷后产出奖励结算
		ePvpTheifAttacked(10003),	//PVP城池被山贼反攻后产出奖励结算
		eUnionByRefuse(10004),		//玩家公会加入申请被拒绝时
		eUnionApplyTimeout(10005),	//玩家公会加入申请超时
		eUnionDismiss(10006),		//玩家公会解散时
		eUnonByGoaway(10007),		//玩家被踢出公会时
		ePvpIntemalOutPut(10008),   //PVP内政产出
		ePvpAgainstAlienInvasion(10009),  //PVP城池抵抗异族入侵成功
		ePvpRobotOccupied(10010),   //PVP城池被机器人占领
		ePvpScoreRankReward(10011),	//PVP积分排名奖励
		eGiftCard(10012),			//接受捐卡通知
		eGmPersonEmail(10013),		//GM个人邮件
		eFeedbackEmail(10014),		//GM反馈邮件
        eOnePurchaseInit(10015),	//一元购活动初始提醒
        eOnePurchaseExpired(10016),	//一元购活动过期提醒'
		eUnionPkRankEmail(10017),	//公会战奖励
		eUnionPkChairmanEmail(10018);//公会战会长奖励
		private int value = 0;
		
		EEmailConfig(int order) {
			this.value = order;
		}
		
		public int value() {
			return value;
		}
	}
	
	// 数据统计类型
	public enum EStatDataType {
		eFreeDianJinShou(0),		// 免费点金手
		eUseStrength(1),			// 使用体力数目
		eInvestigate(2),           	// 侦查令使用上限
		eMilitaryOrder(3),         	// 军令使用上限
		ePatrolReplace(4),         	// 每天巡逻替换
		eDissolveUnion(5),			// 解散公会次数
		eQuitUnion(6),				// 退出公会次数
		eApplyUnion(7),				// 申请公会次数
		eExpeditonResetHp(8),		// 远征重置血值次数
		eBuyInvestigate(9),         // 购买侦查令次数
		eBuyMilitaryOrder(10),     	// 购买军令次数
		eBuySkillPoint(11),     	// 购买技能点次数
		eGoldCardFreeCount(12),     // 金币每日免费抽卡次数
		eDiamondsCardFreeCount(13), // 钻石每日免费抽卡次数
		eGoldCardCount(14),         // 金币抽卡次数
		eDiamondsCardCount(15),     // 钻石抽卡次数
		eTimeCardCount(16),			// 限时抽卡次数
		eUnionQifuCount(17),		// 公会祈福次数
		eUnionFanpaiCount(18),		// 公会翻牌次数
		eUnionDaFuWengCount(19),	// 公会大富翁次数
		eUnionDaFuWengRoll(20),		// 公会大富翁重摇骰子
		eGainFriendStrength(21),	// 领取好友体力次数
		eGiveFriendStrength(22),	// 赠送好友体力次数 
		eAskforFriendStrength(23),	// 索要好友体力次数
		eUnionPkLose(24),			// 公会战失败次数

		eTrialChapter1(301),		// 试炼章节1
		eTrialChapter2(302),		// 试炼章节2
		eTrialChapter3(303);		// 试炼章节3
		
		private int value = 0;
		EStatDataType(int value) {
			this.value = value;
		}
		
		public int value() {
			return value;
		}
	}
	
	// 匹配类型
	public enum EMatchType {
		eMatchStage,				// 匹配到关卡
		eMatchPlayer,				// 匹配到玩家
		eMatchRobot,				// 匹配机器人
	}
	
	/**掉落包权重基数，*/
	/***
	 * liujx:这个是没有配置表的，是写死的改了的吗？
	 * 醒醒：这个就是10W,不会改这个的，就是写死的，后面改 你打死我，外加请全公司吃小龙虾
	 * 醒醒:包有可能出多个，集合里面的道具只能出一个
	 */
	public final static int drop_bag_weight = 100000;
	/**国家定义 国家ID /国家 0：无国家，系统随机，1：魏国 2：蜀国 3：吴国*/
	public final static int pvp_country_none_id =  0;
	public final static int pvp_country_wei_id =  1;
	public final static int pvp_country_shu_id =  2;
	public final static int pvp_country_wu_id =  3;
	//pvp 随机国家奖励
	public final static int pvp_Romdom_country_reward_money =300;
	
	//pvp战斗结果
	public final static int pvp_attack_success_id 	= 1; 	//攻城成功
	public final static int pvp_attack_fail_id		= 2;	//攻城失败
	public final static int pvp_defend_success_id	= 3;	//守城成功
	public final static int pvp_defend_fail_id		= 4;	//守城失败
	
	/**城池状态 0无；1，自己占领；2，山贼占领;3,被其他玩家占领,4，机器人占领*/
	public final static short  pvp_city_none_status = 0;
	public final static short  pvp_city_oneself_status = 1;
	public final static short  pvp_city_thief_status = 2;
	public final static short  pvp_city_player_status = 3;
	public final static short  pvp_city_roboot_status = 4;
	
	public final static int pvp_open_level = 30;//pvp 开放等级
	
	public final static float pvp_random_scale = 0.3f;//pvp关卡匹配浮动百分比
	
	public final static float pvp_random_scale_civil = 0.1f;//pvp内乱匹配浮动百分比
	
	public final static int pvp_none_camp_out_put_scale = 30;//pvp没有驻守阵容产出比例
	
	public final static int pvp_receive_type_Id =1;//PVP 奖励类型 道具Id
	
	public final static int pvp_receive_type_setId =2;//PVP 奖励类型 道具集合Id
	
	public final static int pvp_investigate_use_one = 1;//每次消耗侦查令的数量
	public final static int pvp_militaryOrder_use_one =1;//每次消耗军令的数量
	
	public final static int pvp_log_out_date_hours = 48;//pvp日志过期小时数 
	
	public final static int player_name_length =14;//角色名长度
	//pvp科技ID定义
	public final static int pvp_keji_1 = 1;//超强体魄
	public final static int pvp_keji_2 = 2;//力大无穷
	public final static int pvp_keji_3 = 3;//稳如泰山
	public final static int pvp_keji_4 = 4;//斗气觉醒
	public final static int pvp_keji_5 = 5;//国富民强
	public final static int pvp_keji_6 = 6;//富甲天下
	public final static int pvp_keji_7 = 7;//兵多将广
	public final static int pvp_keji_8 = 8;//五谷丰登
	public final static int pvp_keji_9 = 9;//一叶知秋
	public final static int pvp_keji_10 = 10;//点石成金
	public final static int pvp_keji_11 = 11;//强取豪夺
	public final static int pvp_keji_12 = 12;//固诺金汤
	public final static int pvp_keji_13 = 13;//兵贵神速
	public final static int pvp_keji_14 = 14;//矿藏如山
	public final static int pvp_keji_15 = 15;//石料丰富
	//最大科技ID值
	public final static int pvp_keji_id_max = 15;
	//最大科技、主城、仓库等级值
	public final static int pvp_lv_max =30;
	//pvp事件定义
	public final static int pvp_event_fire = 1;//主城起火
	public final static int pvp_event_civil = 2;//城池内乱
	public final static int pvp_event_invade = 3;//异族入侵
	public final static int pvp_event_stronghold = 4;//黄巾据点
		
	public final static int system_pvp_id = 1019;//pvp系统ID
	/**事件状态 0无 1起火，2内乱，3异族入侵*/
	public final static short pvp_event_none_status = 0;
	public final static short pvp_event_fire_status = 1;
	public final static short pvp_event_civil_status = 2;
	public final static short pvp_event_invade_status = 3;
	
	/**巡逻任务状态，0未开始，1进行中，2已完成*/
	public final static int patrol_status_not_start = 0;//
	
	public final static int patrol_status_ongoing = 1;
	
	public final static int patrol_status_completed = 2;

	public final static int patrol_max_unfinished_entry = 20;//玩家未完成巡逻任务的最大数
	
	public final static int patrol_day_refresh_entry = 5;//玩家每天刷新巡逻任务的条目数
	
	public final static int patrol_day_refresh_Time = 1;//玩家每天自己替换巡逻任务次数
	
	public final static float patrol_speed_complete_diamond_base = 5;//加速完成巡逻任务计算基数
	
	/**棋盘类型*/
	public final static int player_chessboard_type_tech=1;//科技棋盘
	
	//科技系统武将属性  0：科技闪避属性，1：科技模仿属性，2：科技暴击属性 3：科技防御属性，4：科技攻击属性，5：科技生命属性
	public final static int hero_technology_attr_dodge = 0;
	public final static int hero_technology_attr_res = 1;
	public final static int hero_technology_attr_crit = 2;
	public final static int hero_technology_attr_def = 3;
	public final static int hero_technology_attr_att = 4;
	public final static int hero_technology_attr_life = 5;
	
	//抽卡类型
	public enum EDrawCardType{
		eGoldCard(1),
		eTenGoldCard(2),
		eDiamondCard(3),
		eTenDiamondCard(4),
		eTimeCard(5),
		eTenTimeCard(6);
		private int value = 0;
		EDrawCardType(int value) {
			this.value = value;
		}
		
		public int value() {
			return value;
		}
	}
	/**聊天*/
	//发言字符长度限制
	public final static int chat_char_long = 100;
	//世界聊天CD时长ms
	public final static long chat_word_cd_time = 30*1000;
	//公会聊天CD时长ms
	public final static long chat_union_cd_time = 5*1000;
	
	//聊天类型1，世界  2，公会 3，私聊
	public enum EChatType{
		eWordChat(1),
		eUnionChat(2),
		ePrivateChat(3);
		private int value = 0;
		EChatType(int value) {
			this.value = value;
		}
		public int value() {
			return value;
		}
	}
	//pvp资源定义
	//粮草
	public final static int pvp_ziyuan_provender = 1;
	//木材
	public final static int pvp_ziyuan_wood = 2;
	//金属
	public final static int pvp_ziyuan_metal = 3;
	//花岗岩
	public final static int pvp_ziyuan_granite = 4;
	//大理石
	public final static int pvp_ziyuan_marble = 5;
	//掠夺加成
	public final static int pvp_ziyuan_plunder = 6;
	//被掠夺保护加成
	public final static int pvp_ziyuan_plundered = 7;
	//战斗次数恢复时间加成
	public final static int pvp_ziyuan_fight_time_speed = 8;
	
	//pvp匹配机器人上下浮动比例
	public final static float pvp_random_robot_scale = 0.1f;//pvp关卡匹配浮动百分比
	// 实时PVP随机数数量
	public final static int pvp_ol_random_count = 30;
	// 实时PVP战斗配置类型
	public enum EBattleOptionType {
		eOptionNull,			// 无
		eWaitEnterFight,		// 等待进入战斗配置
		eOptionSingleRound,		// 单个回合配置 
		eOptionAllRound,		// 总回合配置 
		eOptionSelectCamp,		// 选择阵营配置
		eOptionChangeCamp,		// 调整阵营配置
		eOptionOffline,			// 掉线
		eOptionLoadRes			// 资源加载配置			
	}
	
	// 公会小游戏类型
	public enum EUnionGameType {
		eNoneUnionGame,			// 
		eSystemHongbao,			// 系统红包玩法
		ePersonHongbao,			// 个人红包玩法
	}
	/****************************第三方极光服务平台参数***************************************/
	//极光APP参数
	public static final String jguangAppKey = "2cb3700e0b9172d9a87e257d";
	public static final String jguangMasterSecret = "a8d61285e6d8ed9dc2b86bd7";
	//注册极光用户统一密码
	public static final String jguangUserPass = "123456";
	/****************************第三方极光服务平台参数***************************************/
	
	// 生成平台唯一ID　　平台openID::登陆方式
	public static String platformOpenId(String srcOpenId, int loginType) {
		return (loginType + "::" + srcOpenId);
	}
	
	// 解析平台唯一ID 
	public static String parsePlatformOpenId(String srcOpenId, int loginType) {
		String[] strs = srcOpenId.split("::");
		if (strs.length < 2) return "";
		return strs[1];
	}
	
	
}