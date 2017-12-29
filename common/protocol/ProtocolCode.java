package net.uyo.common.define;

/**
 * 
* @ClassName: ProtocolCode 
* @Description: 协议号定义
* @author 刘锦新
* @date 2015年8月25日 下午2:33:59 
*
 */
public interface ProtocolCode {
	
	/*--内部协议不暴露给客户端-------------------------------------------*/
	/**实时PVP玩家状态变化*/
	public static final int PVP_ONLINE_PLAYER_STATE			= 1000001;
	
	/*--通用-------------------------------------------*/

	/**通用结果*/
	public static final int COMMON_RESULT 		= 1001;
	/**心跳*/
	public static final int COMMON_HEART_BEAT 	= 1002;
	/**login测试*/
	public static final int TEST_CODE 			= 1003;
	/**游戏服登录校验 登录第二步*/
	public static final int GAME_CHECK_LOGIN 	= 1004;
	/**角色登录 登录第三步 完成登录*/
	public static final int GAME_PRIME_LOGIN 	= 1005;
	/**登录服登录  登录第一步*/
	public static final int USER_LOGIN 			= 1006;
	/**服务器时间同步*/
	public static final int SERVIE_TIME_SYNC	= 1007;
	/**刷新玩家恢复类CD时间*/
	public static final int REFRESH_PLAYER_CD	= 1008;
	/**获取账号角色列表*/
	public static final int ACCOUNT_PLAYER_LIST = 1009;
	/**获取系统推荐角色名*/
	public static final int SYSTEM_PLAYER_NAME  = 1011;
	/**修改角色名称*/
	public static final int MODIFY_PLAYER_NAME  = 1012;
	/**角色重复登陆*/
	public static final int USER_REPEAT_LOGIN	= 1013;
	/**绑定账号*/
	public static final int BIND_ACCOUNT		= 1014;
	/**提示账号绑定游客账号*/
	public static final int BIND_CAPION_ACCOUNT	= 1015;
	/**领取星星奖励*/
	public static final int DRAW_STAR_AWARD		= 1016;
	/**首次平台登陆奖励*/
	public static final int PLATLOGIN_REWARD_NOTICE=1017;
	/**领取首次平台登陆奖励*/
	public static final int PLATLOGIN_REWARD_GET= 1018;
	/**战前引导*/
	public static final int PLAYER_GUIDE        = 1019;
	/**第三方登录校验*/
	public static final int LOGINCHACK          = 1020;
	/**游戏参数表*/
	public static final int COMCONFIG 			= 1021;
	/**已领取星星奖励ID列表*/
	public static final int DRAW_STAR_AWARD_IDS	= 1022;
	/**获取游戏区服信息*/
	public static final int PLAT_SERVER_LIST 	= 2002;
	/**玩家登录后的第一条协议，获取玩家基本讯息*/
	public static final int PLAYER_INFO 		= 2003;
	/**获取玩家武将讯息列表*/
	public static final int PLAYER_HERO_INFO_LIST= 2004;
	/**获取玩家单个武将讯息*/
	public static final int PLAYER_HERO_INFO 	= 2005;
	/**获取道具列表 */
	public static final int PLAYER_ITEM_INFO_LIST=2006;
	/**获取单个章节信息 */
	public static final int CHAPTER_INFO 		= 2007;
	/**获取所有章节信息 */
	public static final int CHAPTER_INFO_LIST 	= 2008;
	/**获取单个关卡信息 */
	public static final int STAGE_INFO 			= 2009;
	/**获取指定章节的所有关卡信息*/
	public static final int STAGE_INFO_LIST 	= 2010;
	/**GM命令*/
	public static final int GAME_COMMAND		= 2011;
	/**玩家属性信息*/
	public static final int PLAYER_ATTR_INFO	= 2012;
	/**武将属性信息*/
	public static final int HERO_ATTR_INFO		= 2013;
	/**玩家统计数据*/
	public static final int PLAYER_STATISTIC_DATA=2014;
	/**玩家武将战斗存储信息*/
	public static final int HERO_DUMP_LIST		= 2015;
	/**获取武将阵容*/
	public static final int PLAYER_HERO_CAMP_LIST=2016;
	/**上传武将信息*/
	public static final int UPLOAD_HERO_INFO	= 2017;
	/**玩家个人展示信息*/
	public static final int PLAYER_SHOW_INFO	= 2018;
	/**新手引导ID*/
	public static final int PLAYER_GUIDE_ID		= 2019;
	/**红点列表*/
	public static final int RED_DOTS_LIST		= 2020;
	 
	/**使用背包物品*/
	public static final int BAG_ITEM_USE		= 2101;
	/**出售背包物品*/
	public static final int BAG_ITEM_SELL		= 2102;
	/**合成背包物品*/
	public static final int BAG_ITEM_SYNTHETIC	= 2103;
	/**合成武将装备*/
	public static final int EQUIP_ITEM_SYNTHETIC= 2104;
	/**物品属性旧变新*/
	public static final int BAG_ITEM_OLD		= 2105;
	/**背包物品购买*/
	public static final int BAG_ITEM_BUY		= 2106; 

	/**获取好友列表*/
	public static final int FRIEND_INFO_LIST	= 2201;
	/**获取好友申请列表*/
	public static final int FRIEND_APPLY_LIST	= 2202;
	/**获取好友体力赠送列表*/
	public static final int FRIEND_STRENGTH_LIST= 2203;
	/**获取好友推荐列表*/
	public static final int FRIEND_LOOK_LIST	= 2204;
	/**申请加为好友*/
	public static final int FRIEND_ADD_APPLY	= 2205;
	/**同意好友申请*/
	public static final int FRINED_ADD_AGREE	= 2206;
	/**解除好友关系*/
	public static final int FRIEND_RELEATION_DEL= 2207;
	/**赠送好友体力*/
	public static final int FRIEND_SRTENGTH_GIFT= 2208;
	/**领取赠送体*/
	public static final int FRIEND_SRTENGTH_GET	= 2209;
	/**查看好友阵营信息*/
	public static final int FRIEND_CAMP_INFO	= 2210;
	/**好友搜索*/
	public static final int FRIEND_SEARCH_INFO	= 2211;
	/**好友索要体力*/
	public static final int FRIEND_ASKFOR_STRENGTH=2212;
	/**好友求体力管理*/
	public static final int FRIEND_ASKFOR_MANAGER=2213;
	/**好友超越炫耀*/
	public static final int FRIEND_OVERSTEP_SHOW= 2214;
	/**好友平台关系链同步*/
	public static final int FRIEND_PLATFORM_SYNC= 2215;
	/**好友状态变化*/
	public static final int FRIEND_STATE_CHANGE = 2216;
	
	/**获取玩家邮件列表信息*/
	public static final int EMAIL_INFO_LIST 	= 2301;
	/**读取邮件内容*/
	public static final int EMAIL_INFO_READ		= 2302;
	/**一键领取邮件附件*/
	public static final int EMAIL_ONE_KEY_RECEIVE_ATTACHMENTS = 2303;
	
	/**获取旅行商店信息*/
	public static final int TRAVEL_SHOP_LIST	= 2401;
	/**神秘商店信息*/
	public static final int SECRET_SHOP_INFO	= 2402;
	/**购买商店物品*/
	public static final int BUY_SHOP_ITEM		= 2403;
	/**刷新商店*/
	public static final int REFRESH_SHOP		= 2404;
	/**快捷购买*/
	public static final int BUY_QUICK_BUY		= 2405;
	/**领取新手礼包*/
	public static final int NEWPLAYER_GOODIE_BAG= 2406;
	
	
	
	/**分享通知*/
	public static final int SHARE_DATA_NOTICE	= 2501;
	/**推送分享数据*/
	public static final int SHARE_DATA_PUSH		= 2502;
	/**推送授权*/
	public static final int PUSH_AUTHORIZE 		= 2503;
	/**礼包码领取*/
	public static final int PACKAGE_CODE	 	= 2504;
	/**邀请好友通知*/
	public static final int INITVE_FRIEND_NOTICE= 2505;
	
	/*用户回流奖励*/
	public static final int PLAYER_REFLUX_REWARD = 2601;
	/*用户领取回流奖励*/
	public static final int PLAYER_DRAW_REFLUX_REWARD = 2602;
	/**领取好评奖励*/
	public static final int GET_GRADE_STAR_REWARD= 2701;
	/**标记游戏星级好评*/
	public static final int MARK_GAME_GRADE_STAR= 2702;
	/**通知游戏好评奖励*/
	public static final int NOTICE_GRADE_STAR_REWARD = 2703;
	
	/** 战斗开始*/
	public static final int STAGE_FIGHT_START 	= 3001;
	/** 战斗结算,*/
	public static final int STAGE_FIGHT_END  	= 3002;
	/** 扫荡*/
	public static final int STAGE_FIGHT_MOPUP 	= 3003;
	/** 重置关卡,返回通用结果*/
	public static final int STAGE_REST 			= 3004;
	/** 开宝箱，返回通用结果*/
	public static final int STAGE_OPNE_CHEST 	= 3005;
	/**跳过对话*/
	public static final int STAGE_JUMP_DIALOGUE = 3006;
	/**PVP侦察城池驻军*/
	public static final int PVP_SEARCH_ENEMY	= 3007;
	/**关卡猫咪抵押通关*/
	public static final int STAGE_PASS_BY_KITTY	= 3008;

	/**远征关卡列表*/
	public static final int EXPEDITION_LIST		= 3021;
	/**远征关卡宝箱开启*/
	public static final int EXPEDITION_OPEN_BOX	= 3022;
	/**远征战斗开始*/
	public static final int EXPEDITION_START	= 3023;
	/**远征战斗结束*/
	public static final int EXPEDITION_END		= 3024;
	/**远征宝箱列表*/
	public static final int EXPEDITION_BOX_LIST	= 3025;
	/**远征消息*/
	public static final int EXPEDITION_MESSAGE	= 3026;
	/**购买宝箱钥匙道具*/
	public static final int EXPEDITION_BUY_KEY	= 3027;
	/**购买恢复药水道具*/
	public static final int EXPEDITION_BUY_RECOVERPOTION	= 3028;
	/**使用恢复药水道具*/
	public static final int EXPEDITION_USE_RECOVERPOTION	= 3029;
	/**远征活动期限*/
	public static final int EXPEDITION_TIME_LIMIT	= 3030;
	/**谁偷了你的宝箱*/
	public static final int EXPEDITION_STEAL_BOX	= 3031;
	
	/**试炼开放章节列表*/
	public static final int TRAIL_CHAPTER_LIST	= 3041;
	/**试炼战斗开始*/
	public static final int TRAIL_FIGHT_START	= 3042;
	/**试炼战斗结束*/
	public static final int TRAIL_FIGHT_END		= 3043;
	/**试炼扫荡*/
	public static final int TRAIL_FIGHT_MOPUP	= 3044;
	
	/**生成武将,返回通用结果*/
	public static final int CREATE_HERO 		= 3101;
	/**升级技能*/
	public static final int HERO_UP_SKILL 		= 3102;
	/**升星*/
	public static final int HERO_UP_STAR 		= 3103;
	/**武将阵营改变*/
	public static final int HERO_CHANGE_CAMP	= 3104;
	/**默认阵营设置*/
	public static final int HERO_DEFAULT_CAMP 	= 3105;
	/**英雄单个阵营信息*/
	public static final int HERO_CMAP_SINGLE	= 3106;
	/**英雄杀气进阶*/
	public static final int HERO_UP_PHASE_LEVEL	= 3107;
	/**英雄官职进阶*/
	public static final int HERO_UP_OFFICE_LEVEL= 3108;
	/**武将升级*/
	public static final int HERO_UP_LEVEL 		= 3109;
	/**点击图鉴中武将*/
	public static final int HERO_CLICK_PHOTO	= 3110;
	
	
	/**获取任务列表*/
	public static final int TASK_LIST           = 3201;
	/**领取任务奖励*/
	public static final int TASK_AWARD          = 3202;
	/**获取积分任务列表*/
	public static final int POINT_TASK_LIST     = 3203;
	/**领取积分任务奖励*/
	public static final int POINT_TASK_AWARD    = 3204; 
	
	/**巡逻任务列表*/
	public static final int PATROL_LIST 		= 4014;
	/**巡逻任务开始*/
	public static final int PATROL_START 		= 4015;
	/**巡逻任务加速完成*/
	public static final int PATROL_SPEED_COMPLETE= 4016;
	/**巡逻任务领奖*/
	public static final int PATROL_AWARD 		= 4017;
	/**替换巡逻任务*/
	public static final int PATROL_REPLACE		= 4018;
	
	/**公会创建游戏公会*/
	public static final int UNION_CREATE_NEW	= 4031;
	/**公会查询*/
	public static final int UNION_QUERY			= 4032;
	/**公会获取公会推荐*/
	public static final int UNION_GET_RECOMMEND	= 4033;
	/**公会申请加入公会*/
	public static final int UNION_JOIN_APPLY	= 4034;
	/**公会获取申请列表*/
	public static final int UNION_APPLY_LIST	= 4035;
	/**公会管理成员*/
	public static final int UNION_MANAGER_MEMBER= 4036;
	/**公会排行榜*/
	public static final int UNION_RANK_LIST		= 4037;
	/**公会我的公会信息*/
	public static final int UNION_GET_MYSELF	= 4038;
	/**公会成员列表*/
	public static final int UNION_MEMBER_LIST	= 4039;
	/**公会修改公会信息*/
	public static final int UNION_MODIFY_INFO	= 4040;
	/**公会解散*/
	public static final int UNION_DISMISS		= 4041;
	/**公会申请退出*/
	public static final int UNINO_QUIT_APPLY	= 4042;
	/**公会同意加入或退出公会*/
	public static final int UNION_JOIN_OR_KICKED= 4043;
	/**公会在线人数*/
	public static final int UNION_ONLINE_COUNT	= 4044;
	/**广播退出公会成员信息*/
	public static final int UNION_QUIT_MEMBER	= 4045;
	/**公会日志*/
	public static final int UNION_LOG_INFO		= 4046;
	/**公会奖杯排行榜*/
	public static final int UNION_CUP_RANK_LIST	= 4047;
	/**公会战申请*/
	public static final int UNION_APPLY_PK		= 4048;
	/**公会战积分排名*/
	public static final int UNION_PK_RANK_LIST	= 4049;
	/**公会战报名申请通知*/
	public static final int UNION_NOTICEPK_APPLY= 4050;
	/**公会战PK结果通知*/
	public static final int UNINT_NOTICEPK_RESULT=4051;
	/**公会战即将开放通知*/
	public static final int UNION_GVG_WILLOPEN	 =4052;
	/**创建公会是否收费*/
	public static final int UNION_CREATE_IS_FREE =4053;
	//公会解散时间
	public static final int UNION_DISMISS_TIME   =4201;
	/**聊天*/
	/**发言*/
	public static final int CHAT_CHAT 			= 5001;
	/**通用推送消息*/
	public static final int COMMON_CHAT_MSG 	= 5002;
	/**屏蔽玩家信息*/
	public static final int CHAT_BLOCK 			= 5003;
	/**屏蔽玩家信息列表*/
	public static final int CHAT_BLOCKI_LIST 	= 5004;
	/**解除屏蔽玩家信息*/
	public static final int CHAT_UNBLOCK 		= 5005;
	/**捐赠卡牌*/
	public static final int CHAT_GIFT_CARD 		= 5006;
	/**捐赠申请卡牌*/
	public static final int CHAT_GIFT_CARD_APPLY= 5007;
	/**捐赠申请列表*/
	public static final int CHAT_GIFT_CARD_APPLY_LIST= 5008;
	/**捐赠卡牌价值数*/
	public static final int CHAT_GIFT_CARD_VALUE= 5009;
	/**捐赠卡牌消息*/
	public static final int CHAT_GIFT_CARD_INFO = 5010;
	
	// 公会秘境玩法
	/**公会秘境可邀请的在线成员列表*/
	public static final int SECRET_ONLINE_MEMBERS=5011;
	/**公会秘境创建房间*/
	public static final int SECRET_CREATE_ROOM	= 5012;
	/**公会秘境获取成员列表*/
	public static final int SECRET_GET_MEMBERS	= 5013;
	/**公会邀请秘境成员*/
	public static final int SECRET_INVITE_MEMBER= 5014;
	/**公会秘境同意加入*/
	public static final int SECRET_AGREE_JOIN	= 5015;
	/**公会秘境踢出成员*/
	public static final int SECRET_KICK_MEMBER	= 5016;
	/**公会秘境成员退出*/
	public static final int SECRET_MEMBER_QUIT	= 5017;
	/**公会秘境成员变化*/
	public static final int SECRET_CHANGE_MEMBER= 5018;
	/**公会秘境战斗开始*/
	public static final int SECRET_FIGHT_BEGIN	= 5019;
	/**公会秘境战斗结束*/
	public static final int SECRET_FIGHT_END	= 5020;
	/**公会秘境关卡状态变化*/
	public static final int SECRET_STAGE_CHANGE	= 5021;
	/**公会秘境Buf变化*/
	public static final int SECRET_BUFF_CHANGE	= 5022;
	/**公会秘境房间开启*/
	public static final int SECRET_ROOM_OPEN	= 5023;
	/**公会秘境房间关闭*/
	public static final int SECRET_ROOM_CLOSE	= 5024;
	/**公会秘境房间变化*/
	public static final int SECRET_ROOM_CHANGE	= 5025;
	
	// 公会活动玩法
	/**公会祈福玩法信息*/
	public static final int UNION_QIFU_INFO		= 5050;
	/**公会祈福开始*/
	public static final int UNION_QIFU_START	= 5051;
	/**公会活动宝箱领取*/
	public static final int UNION_ACTIVITY_BOX	= 5052;
	/**公会翻牌玩法信息*/
	public static final int UNION_FANPAI_INFO	= 5053;
	/**公会翻牌开始*/
	public static final int UNION_FANPAI_START	= 5054;
	/**公会大富翁玩法信息*/
	public static final int UNION_DAFUWENG_INFO	= 5055;
	/**公会大富翁开始即前进*/
	public static final int UNINO_DAFUWENG_START= 5056;
	/**公会大富翁重新摇骰子*/
	public static final int UNION_DAFUWENG_ROLL	= 5057;
	/**公会红包系统红包信息*/
	public static final int UNION_HONGBAO_SYSTEM= 5058;
	/**公会红包个人红包信息*/
	public static final int UNION_HONGBAO_PERSON= 5059;
	/**公会红包领取系统红包*/
	public static final int UNION_HONGBAO_RECEVIE=5060;
	/**公会发送个人红包*/
	public static final int UNION_HONGBAO_SEND	= 5061;
	/**公会领到个人红包列表*/
	public static final int UNION_PERSON_HB_LIST= 5062;
	/**公会某个红包的领取记录*/
	public static final int UNION_HB_GET_RECORD	= 5063;
	/**公会红包消息推送*/
	public static final int UNION_HONGBAO_MSG	= 5064;
	/**公会翻牌获取奖励*/
	public static final int UNION_FANPAI_REWARD	= 5065;
	/**公会成员红包排行榜*/
	public static final int UNION_HONGBAO_RANK	= 5066;
	/**公会个人红包发送次数*/
	public static final int UNION_HB_SEND_NUM	= 5067;
	
	
//	/*科技系统 棋盘列表**/
//	public static final int TENCH_CHESSBOARD_LIST= 4050;
//	/*科技系统 客户端上传棋盘**/
//	public static final int TENCH_CHESSBOARD_UP	= 4051;
//	/*科技系统 棋子移动**/
//	public static final int TENCH_CHESS_MOVE	= 4052;
//	/*科技系统 购买步数**/
//	public static final int TENCH_BUY_STEP		= 4053;
	
	/**装备强化*/
	public static final int EQUIP_ENHANCED		= 4054;
	/**装备附魔*/
	public static final int EQUIP_ENCHANT		= 4055;
	
//	/**购买侦查令*/
//	public static final int BUY_INVESTIGATE 	= 4056;
//	/**购买军令*/
//	public static final int BUY_MILITARYORDER 	= 4057;
	
	
	/**排行榜*/
	/**武将总战斗力排行榜*/
	public static final int RANK_HERO_TOTAL_FIGHT= 4061;
	/**通关总星数排行榜*/
	public static final int RANK_STAGE_TOTAL_STAR= 4062;
	/**单个武将战斗力排行榜*/
	public static final int RANK_HERO_SINGLE_FIGHT=4063;
	/**PVP积分排行榜*/
	public static final int RANK_PVP_SCORE_RANK	= 4064;
	/**PVP奖杯排行榜*/
	public static final int RANK_PVP_CUP_RANK	= 4065;
	/**远征积分排行榜*/
	public static final int RANK_EXPEDITION	= 4066;
	/**关卡积分排行榜*/
	public static final int RANK_STAGE	= 4067;
	
	/**查看玩家阵营信息*/
	public static final int QUERY_PLAYER_CAMP_INFO=4071;
	
	/**抽卡系统*/
	public static final int DRAW_CARD           = 4081;
	/**热门英雄*/
	public static final int HOT_HEROS   		= 4082;
	
	/**活动系统，协议号往后加*/
	/**活动签到信息*/
	public static final int ACTIVIY_SIGNIN_INFO	= 4091;
	/**活动今日签到*/
	public static final int ACTIVIY_TODAY_SIGNIN= 4092;
	/**累计签到信息*/
	public static final int ACTIVIY_CUMULATIVE_SIGNIN_INFO= 4093;
	/**领取累计签到奖励*/
	public static final int ACTIVIY_CUMULATIVE_SIGNIN_DRARW= 4094;
	
	/***好友邀请/回馈4101-4199**/
	/** 好友回馈列表*/
	public static final int INVITE_FRIEND_LIST	= 4101;
	/** 回馈邀请人*/
	public static final int INVITE_FRIEND_FEELBACK=4102;
	/** 宝箱领取*/
	public static final int INVITE_FRIEND_RECEIVE=4103;
	/** 邀请好友成功 */ 
	public static final int INVITE_FRIEND_SUCCESS=4104;
	/**获取邀请平台信息 */
	public static final int INVITE_PLAT_GET_INFO=4105;
	/**同步邀请平台好友列表 */
	public static final int INVITE_PLAT_SYNC_LIST=4106;
	/**领取邀请平台好友奖励*/
	public static final int INVITE_PLAT_GET_REWARD=4107;
	/**邀请平台好友成功的列表*/
	public static final int INVITE_PLAT_SUCCESS_LIST=4108;
	/**领取邀请平台好友成功奖励*/
	public static final int INVITE_PLAT_SUCCESS_REWARD=4109;
	/**领取邀请微信好友成功奖励*/
	public static final int INVITE_WX_SUCCESS_REWARD=4116;
	/**好友申请通知*/
	public static final int FRIEND_APPLY_NOTICE=4110;
	/**新邮件通知*/
	public static final int EMAIL_NEW_NOTICE=4111;
	/**获取推荐(假)好友*/
	public static final int RECOMMEND_FRIEND=4112;
	/**获取推荐(假)好友列表*/
	public static final int RECOMMEND_FRIEND_LIST=4113;
	/**同意推荐(假)好友*/
	public static final int ARGEEE_RECOMMEND_FRIEND=4114;
	/**被删除推荐好友关系玩家ID*/
	public static final int DEL_RECOMMEND_FRIEND=4115;
	
	
	
	/**支付相关协议*/
	/**请求生成支付流水号*/
	public static final int PAY_GENERATE_SERIAL_NO= 4301;
	/**支付提交订单*/
	public static final int PAY_SUBMIT_ORDER	= 4302;
	/**发起支付*/
	public static final int PAY_START = 4303;
	/**微信发起支付结果*/
	public static final int PAY_WX_START_RESULT = 4304;
	
	public static final int PLAYER_INFO_RESULT 	= 6001;
	/**购买战斗道具*/
	public static final int FIGHT_ITEM_BUY 		= 7001;
	/**消耗战斗道具*/
	public static final int FIGHT_ITEM_USE		= 7002;
	/**随机战斗道具*/
	public static final int FIGHT_ITEM_RANDOM 	= 7003;
	
	/**实时PVP匹配相关协议 发至游戏服务器*/
	/**实时PVP随机匹配请求*/
	public static final int MATCH_PVP_RANDOM	= 8001;
	/**实时PVP好友对战*/
	public static final int MATCH_PVP_FRIEND	= 8002;
	/**实时PVP公会对战*/
	public static final int MATCH_PVP_UNION		= 8003;
	/**实时PVP匹配结果*/
	public static final int MATCH_PVP_RESULT	= 8004;
	/**实时PVP匹配取消*/
	public static final int MATCH_PVP_CANCEL	= 8005;
	/**实时PVP好友对战取消*/
	public static final int MATCH_FRIEND_CANCEL	= 8006;
	/**获取公会友谊战列表*/
	public static final int MATCH_UNIONFRIEND_LIST=8007;
	/**同步PVP机器人数据*/
	public static final int MATCH_SYNC_ROBOT_DATA= 8008;
	/**PVP Pk结果战报上传*/
	public static final int PVP_PK_RESULT_REPORT= 8009;
	/**实时PVP战斗结果*/
	public static final int PVP_ONLINE_FIGHT_END= 8500;
	/**实时PVP信息*/
	public static final int PVP_ONLNIE_INFO		= 8501;
	/**实时PVP开启免费宝箱*/
	public static final int PVPOL_OPEN_FREE_CHEST=8502;
	/**实时PVP开启掉落宝箱*/
	public static final int PVPOL_OPEN_DROP_CHEST=8503;
	/**实时PVP查询宝箱时间*/
	public static final int PVPOL_QUERY_CHEST_TIME=8504;
	
	/**战斗服务器相当协议 发至战斗服务器*/
	/**实时PVP请求进入战斗*/
	public static final int FIGHT_ENTER_ROOM	= 9001;
	/**实时PVP战斗开始*/
	public static final int FIGHT_PVP_START 	= 9002;
	/**实时PVP选择阵营*/
	public static final int FIGHT_SELECT_CAMP	= 9003;
	/**实时PVP调整阵营*/
	public static final int FIGHT_ADJUST_CAMP	= 9004;
	/**实时PVP上传战斗数据*/
	public static final int FIGHT_UPLOAD_DATA	= 9005;
	/**实时PVP房间状态变化*/
	public static final int FIGHT_ROOM_STATE	= 9006;
	/**实时PVP资源加载*/
	public static final int FIGHT_LOADING_RES	= 9007;
	/**实时PVP棋盘BUFF同步*/
	public static final int FIGHT_CHESS_BUFF	= 9008;
	/**实时PVP心跳包*/
	public static final int FIGHT_HEAT_BEAT		= 9010;
	/**实时PVP发送表情信息*/
	public static final int FIGHT_FACE_INFO		= 9011;
	/**实时pvp棋盘卡死*/
	public static final int FIGHT_CHESS_DEAD	= 9012;
	
	/*6002-6999留给活动定义*/
	/**活动列表*/
	public static final int ACTIVITY_LIST		= 6002;
	/**领取活动奖励*/
	public static final int ACTIVITY_DRAW		= 6003;
	
	/**4501-4505*/
	/**激活码奖励领取*/
	public static final int ACTIVATION_RECEIVE=4501;
	//获取你选我送活动列表
	public static final int CHOOSEACTIVITY_LIST=4502;
	//选择你选我送活动奖励
	public static final int CHOOSEACTIVITY_SELECT=4503;
	//领取你选我送活动奖励
	public static final int CHOOSEACTIVITY_RECEIVE=4504;
	
	/**4506-4510  一元购活动*/
	//推送活动是否开启状态
	public static final int ONEPUCHASE_INFO=4506;
	//宝箱开启
	public static final int ONEPUCHASE_OPEN_BOX=4507;
	//检查宝箱状态
	public static final int ONEPUCHASE_BOX_CHECK=4508;
	//检查宝箱状态
    public static final int ONEPUCHASE_BOX_PUSH=4509;
    //检查购买状态
    public static final int ONEPUCHASE_BOX_CHECK_BUY=4510;
    //检查购买状态
    public static final int ONEPUCHASE_BOX_REWARE_RESULT=4511;
	//测试用
	public static final int ONEPUCHASE_BOX_CHARG=4512;
	//关卡抽奖活动
	public static final int STAGE_DRAW_LIST = 4513;
	public static final int STAGE_DRAW = 4514;
	public static final int STAE_BUY_KEY = 4515;
	
	/**4521-4540登录有礼(签到)*/
	//查看签到信息
	public static final int LOGIN_SIGN_GIFT_INFO=4521;
	//登录有礼(签到)领取奖励
	public static final int LOGIN_SIGN_GIFT_RECEIVE=4522;
	//推送开关
	public static final int PUSH_SWITCH 		  = 4561;
	/**4541-4545游戏中公告*/
	public static final int NOTICE_GET=4541;
	
	/**4601-4610赌博机活动协议*/
	//赌博机面板
	public static final int GAMLE_PANEL=4601;
	//开始游戏
	public static final int GAMLE_START=4602;
	//结束游戏
	public static final int GAMLE_END=4603;
   //开宝箱
	public static final int GAMLE_OPEN_BOX=4604;
	//金币排行榜
	public static final int GAMLE_GOLD_RANK=4605;
	//钻石排行榜
	public static final int GAMLE_DOMAIN_RANK=4606;
	//时间奖励数据
	public static final int TIME_AWARD_DATA=4607;
	//领取时间奖励
	public static final int TIME_AWARD_DWARD=4608;
	
	/**4701-4710新活动协议号*/
	//活动掉落物品
	public static final int JAMBOREE_DORP = 4701;
	//有效活动列表
	public static final int JAMBOREE_LIST = 4702;
	//活动内容
	public static final int JAMOREE_ENTRY = 4703;
	//兑换活动设置提醒
	public static final int JAMOREE_NOTICE = 4704;
	//活动领奖
	public static final int JAMOREE_DRAWD = 4705;
	//活动红点
	public static final int JAMOREE_REDHOT = 4706;
	
	//同步极光聊天appKey
	public static final int SYSJMESSAGEAPPKEY = 4801;
	//申请重新加入聊天群组
	public static final int APPLYIMGROUP = 4802;
	
}
