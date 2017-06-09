//游戏的全局枚举
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace hero
{
    public struct GoodsConfigData
    {
        public int m_iConfigId;
        public int m_iCount;
        public GoodsConfigData(int iConfigId, int iCount)
        {
            m_iConfigId = iConfigId;
            m_iCount = iCount;
        }

    }
    public struct CStage
    {
        public int m_iStageId;
        public int m_iFightNum;
        public int m_iResetNum;
        public int m_iStar;
        public int m_iState;  //关卡状态
    }
    public enum InventoryType
    {
        CONTAINER_FLAGTYPE_NULL = 0,        //非法类型
        CONTAINER_FLAGTYPE_PACKET = 1,		//物品栏
        CONTAINER_FLAGTYPE_EQUIP = 2,		//装备栏
    }

    public enum EResType
    {
        eNone,
        eResAtlas = 1,
        eResScene = 2,
        eResChess = 3,
        eResChessTexture = 4,
        eResBigIcon = 5,
        eResUI = 6,
        eResConfig = 7,
        eResDrop = 8,
        eResModelCommonEffect = 9,
    }

    //物品类型
    public enum EGoodsItemType
    {
        eMaterialItem = 1, //材料
        eUseItem,  //消耗品  ----取消了消耗品类型但需保留其当作枚举增量使用
        eScrollItem, //卷轴
        eFragment, //碎片/灵魂石
        eOther, //其他
        eHeroCard, //武将卡牌
        eProp, //道具
        eCurrencyType = 50, //货币类型
        eMax,
        //1 材料
        //2 消耗品
        //3 卷轴
        //4 灵魂石
        //5 其他
        //6武将卡牌
        //50.数值项，纯客户端显示用，服务器不进行存储
        //7.战斗道具
    }



    //货币类型V_GetPlayerCurrencyNum
    public enum ECurrencyType 
    {
        eDiamond        = 5000001,//钻石
        eGold           = 5000002,//金币/银币
        eStrength       = 5000003,//体力
        ePlayerExp      = 5000004,//召唤师经验
        eHeroExp        = 5000005,//角色经验
        eTrial          = 5000006,//试炼币
        eInfinite       = 5000007,//远征币
        eHonour         = 5000008,//荣誉币
        ePatrolMoney    = 5000009,//巡逻币
        //公会贡献
        eMilitaryOrder  = 5000011,//军令
        eInvestigate    = 5000012,//侦查令
        eSkillPoint     = 5000013,//技能点
        eHonorPoint     = 5000014,//荣誉积分
        eFood           = 5000015,//粮食
        eWood           = 5000016,//木材
        eMetal          = 5000017,//金属
        eCrystalMine    = 5000018,//水晶矿脉
        eMarble         = 5000019,//大理石
    }

    //价值类型，货币类型
    public enum EPriceType
    {
        //1、银币  2、钻石  3、试炼币  4、无尽币  5、荣誉币  6、侦查令 7、军令 8、巡逻币 9、公会币

        eGold = 1,//金币/银币
        eDiamond = 2,//钻石
       
        eTrial = 3,//试炼币
        eInfinite = 4,//远征币
        eHonour = 5,//荣誉币
        eInvestigate = 6,//侦查令
        eMilitaryOrder = 7,//军令
        ePatrolMoney = 8,
        eUnion = 9,
    }

    
    //物品排序相关
    public enum ERank
    {
        eFirst = 0,
        eSecond,
        eThird,
        eFourth,
        eFivth
    }
    //品质
    public enum EGoodsRank
    {
        eNone = 0,
        eWhiteRank = 1,
        eGreenRank,
        eBlueRank,
        eBlueRank_1, //蓝+1
        ePurpleRank,
        ePurpleRank_1, //紫+1
        ePurpleRank_2, //紫+2
        eOrangeRank,
        eOrangeRank_1, //橙+1
        eOrangeRank_2, //橙+2
        eOrangeRank_3, //橙+3
        eMax = 12,
    }

    //品质
    public enum EEquipsRank
    {
        eNone = 0,
        eWhiteRank = 1,
        eGreenRank,
        eGreenRank_1,
        eGreenRank_2,
        eBlueRank,
        eBlueRank_1, //蓝+1
        eBlueRank_2, //蓝+1
        eBlueRank_3, //蓝+1
        ePurpleRank,
        ePurpleRank_1, //紫+1
        ePurpleRank_2, //紫+2
        ePurpleRank_3, //紫+2
        ePurpleRank_4, //紫+2
        eOrangeRank,
        eOrangeRank_1, //橙+1
        eOrangeRank_2, //橙+2
        eOrangeRank_3, //橙+3
        eOrangeRank_4, //橙+3
        eOrangeRank_5, //橙+3
        eMax = 20,
    }

    //物品产出类型
    public enum EGoodsOutPutType
    {
        eCompound = 1, //合成配方
        eOutPutDesc,  //产出说明
        eOutPutIndex, //产出索引
    }

    //物品是否可以买卖
    public enum EGoodsSell
    {
        eCan = 0,
        eCanNot = 1,
    }

    //物品是否可以使用
    public enum EGoodsUse
    {
        eCan = 0,
        eCanNot = 1,
    }

    //英雄类型
    public enum EHeroType
    {
        eHeroNull = 0,
        eHeroTank = 1,  //肉盾
        eHeroHalfTrank, //战士
        eHeroAssassin,  //刺客
        eHeroMagic,     //法师
        eHeroMilk,      //奶妈
        eHeroArcher = 6,//弓箭
    }

    //英雄阵形站位排序枚举
    public enum EHeroFormationRank
    {
        eHeroTank = 0,  //肉盾  最前面
        eHeroHalfTrank, //战士
        eHeroAssassin,  //刺客
        eHeroMagic,     //法师
        eHeroArcher,    //弓箭  
        eHeroMilk,      //奶妈
    }

    public enum EHeroChessType
    {
        eHeroNone = -1,
        eHeroTank = 0,  //肉盾
        eHeroHalfTrank, //战士
        eHeroAssassin,  //刺客
        eHeroMagic,     //法师,弓箭
        eHeroMilk,      //奶妈
    }

    //国家势力
    public enum ECountry
    {
        Wei = 1,
        Shu,
        Wu,
        Qun
    }

    //怪物类型
    public enum EMonsterType
    {
        eMonster = 0,  //普通怪
        eCaptain,      //队长
        eBoss,         //boss
    }

    //生物属性 火克木  木克风  风克雷  雷克水  水克火
    public enum ECreatureAttrType
    {
        eFire = 1, //火
        eWater,    //水
        eWood,     //木
        eThunder,   //雷
        eWind,  //风
    }

    public enum GameLayer
    {
        eEL_Default = 0,
        eEL_Water = 4,
        eEL_UI = 5,
        eEL_Hero = 8,
        eEL_Photo = 9,
        eEL_UIEffect = 10,
        eEL_City = 11,
        eEL_chessEffect = 12,
        eEL_PvPCity = 13,
        eEL_Dialog = 14,
        eEL_Hide = 16,
    }
    //跟服务器对应的关卡状态
    public enum ESeverStageState
    {
        ePassed = 1,  //已经通关
        eNotPassFirst, //没有通关，第一次打开有动画
        eNotPass,  //没有通关，没有动画
    }

    public enum ELevelType
    {
        eNormal = 1, //普通关卡
        eBoss,      //boss关卡
        eSpecial    //特殊解密关卡
    }
    public enum ESmallLevelState
    {
        ePassed = 1,
        eNotPassAniming,
        eNotPassNoAnim,
        eCatSkipPassed,
        eNotPassButCanNot,
        //optional int32   stageState		=5;//1,已通关  2，播放章节过度动画  3，可打关卡
    }

    public enum ENegativeChessAttackType
    {
        eFireAttack = 6,      //火攻击
        ePoisonAttack = 5,        //毒攻击
        eElectricityAttack = 14,   //电攻击
        eBombAttack = 8, //炸弹攻击
        eRedHeartAttack = 12, //爱心攻击，给怪物加血
        ePoisonBottle = 9,  //毒瓶
        eFireBottle = 10,   //火瓶
        eMystical = 11, //问号
    }



    /// <summary>
    /// 对应字体规范文档
    /// </summary>
    public enum FontStyleType 
    {
        eBlue1,
        eBlue2,
        eBlue3,
        eBlue4,
        eBlue5,
        eBlue6,
        eBlue7,
        eBlue8,
        eBlue9,
        eBlue10,
        eBlue11,
        eBlue12,
        eYellow1,
        eYellow2,
        eYellow3,
        eYellow4,
        eYellow5,
        eYellow6,
        eYellow7,
        eYellow8,
        eQuality1,
        eQuality2,
        eQuality3,
        eQuality4,
        eQuality5,
    }


    public enum EServerListState
    {
        eBusy = 1, //繁忙
        eCrowd, //拥挤
        eFluency, //流程
        eFree,  //空闲
        ePreserve = 11, //维护
    }

    //负向棋子包含的类型
    public enum ENegativeChessType
    {
        eNone = 0,
        eIce = 1, //冰
        eDeepIce, //厚冰
        eLock, //锁
        eDoubleLock, //双锁
        ePoison,//中毒
        eFire, //火

        eVineObj, //藤蔓对象
        eBombObj, //炸弹
        eBombPoisonObj,//毒炸弹
        eVolcanoObj, //火山(火药品)
        eMysticalObj, //神秘物 ， ？号显示
        eRedHeart, //红心
        eStoneEye,//石眼
        eElectricityStone,//电石

        eSmallVineObj,//小藤蔓 -丢弃 

        //新增加
        eBox,
        eSnow1, //雪块1
        eSnow2, //雪块2
        eSnow3, //雪块3
        eSnow4, //雪块4
        eSnow5, //雪块5

        eThinIce1,//薄冰1
        eThinIce2,//薄冰2
        eThinIce3,//薄冰3

        eVineLock, //藤锁

        eLeft_Line,
        eBottom_Line,

        eStone,
        eStoneMove,
        eVenom,    //毒液
        eBallGrey, //灰色毛球
        eBallBrun, //褐色毛球
        eBallBlack,//黑色毛球

        eMaxStatic,
        eSilverCoin,//银币
        eCloud1,
        eCloud2,
        eGem1,
        eGem2,
        eGem3,

        eDinas,
        eGrass1,
        eGrass2,
        eGrass3,
        eGrass4,
        eGrass5,

        eMud1,
        eMud2,
        eMud3,

        eJelly,
        eOctopus,

        eEgg2,
        eEgg3,
        eEgg4,
        eEgg5,

        eKing1,
        eKing2,
        eKing3,
        eKing4,

        eCorn1,
        eCorn2,

        ePreFightChess, 
    }

    public enum EChessBuff
    {
        eNone = 0,
        eIce = 1, //冰
        eDeepIce, //厚冰
        eLock, //锁
        eDoubleLock, //双锁
        ePoison,//中毒
        eFire, //火
        eVineObj, //藤蔓对象
        eBombObj, //炸弹
        eBombPoisonObj,//毒炸弹
        eVolcanoObj, //火山(火药品)
        eMysticalObj, //神秘物 ， ？号显示
        eRedHeart, //红心
        eStoneEye,//石眼
        eElectricityStone,//电石       //这里的顺序是对应表的，不能乱

        eVineLock = 15, //魔法藤
        eVenom, //毒液
        eBallGrey, //灰色毛球

        eChess4Crush = 30, //4消
        eChessTCrush = 31, //T消
        eChess5Crush = 32, //5消
        eChessClear = 33,  //净化

    }


    //负向棋子产生的样式
    public enum ENegativeChessCreateStyle
    {
        eNone = 0,
        eOneCol = 1,      //一列
        eOneRow,      //一行
        eX,
        eLeftOblique, //向左倾斜
        eRightOblique, //右倾斜
        eVUp,         // v型向上
        eVDown,       // v型向下
        eNineGrid,//九宫格
        eRandom,  //随机
        eRandomTop,   //顶部随机

        eLeftOblique3, //丢弃
        eRightOblique3,//丢弃
    }

    //棋子状态
    public enum EChessGrayState
    {
        eNormalState = 0, //正常状态
        eGrayState,       //灰状态
    }

    public enum EChessGameType
    {
        eNone = -1,
        eHeroGame = 0,           //英雄棋盘
        eTechnologyGame,         //科技棋盘
    }
    //布阵类型
    public enum EFormationType
    {
        eNone = -1,
        eNormal = 0, //闯关、精英、试练等
        eExpedition, //远征
        ePvp, //pvp
        ePvpCHANAGE_COMP, //pvp 更换防守
        ePatrol, //巡逻
        eTrials, //试练
        ePvpOL,
        eGuild,//引导
        
        //.....
    }
    public enum BattleType
    {
        NONE = -1,
        PVE,    //闯关
        Trial,  //试炼
        Expedition, //远征（无尽）
        PVP,    //PVP
        PVP_Monster,    //PVP中与怪物战斗
        PVP_OL,   //对决（实时PVP）
        PVP_OL_Robot,  //对决（实时PVP）机器人
        Guide,    // 引导战斗
        MAX
    }

    public enum AttackSkillType
    {
        None = -1,
        Stand = 0,
        Attack1,
        Skill1,
        SuperSkill1,
        Dead,
        Hit,
        Crit,
        PassiveSkill1,
        PassiveSkill2,
        PassiveSkill3,
        PassiveSkillPVP,
        PassiveSkillHide1,
        PassiveSkillHide2,
        PassiveSkillHide3,
        Max,
    }

    //物品的使用类型
    public enum EGoodsUseType
    {
        eNone = 0,
        eGift = 1, //使用道具包
        eHeroExp = 2,  //增加武将经验
        ePlayerExp = 3, //增加召唤师经验
        eAddGold = 4, //增加金币
        eAddDiamond = 5,//增加钻石
        eAddVit = 6,//增加体力
        eAddSophisticationGold = 7,//增加洗练币
        eAddSoul = 8 //增加灵魂石
    }

    public enum CDConfig
    {
        eNone = 0,
        eGameReset = 1,
    }
    //科技购买类型
    public enum ETechnologyBuyType
    {
        eNone = 0,
        eBuyOne = 1,
        eBugTen = 2,
    }

    //消除棋子类型
    public enum ECrushChessAttr 
    { 
        eNormalCrush = 1, //普通三消
        e4Crush = 2, //四消
        eTCrush = 3, 
        e5Crush = 4,
    }

    public enum ECityActivity
    {
        eChouKa = 0, //抽卡
        eShiLian = 1, //试练
        eChuangGuan = 2,//闯关
        eYouXiang = 3, //邮箱

        eQiangHua = 4, //武将强化
        eShenMiShangRen = 5,  //神秘商人
        eYuanZheng = 6,
        eLvXingShangRen = 7, //旅行商人
        eZhuangBeiQiangHua = 8,
        eXunLuo = 9, //巡逻
        eJueXingChi = 10,   //觉醒池
        eGongHui = 11, //工会
        ePaiHangBang = 12,//排行榜
        eMax = 13,
    }

    public enum EAttrMenuBtn
    {
        eNone = 0,
        eRole = 1,    //角色
        eTask,        //任务
        eUnion,       //公会
        ePvPOL,       //巅峰
        eDisableFocus,//取消选中任何系统
    }


    public enum ELeftMenuBtn
    {
        eNone = -1,
        eWarlord = 0, //军阀(pvpol)
        eChallenge, //挑战(试炼）
        eUnion, //工会
        eChouKa, //抽卡
    }

    public enum EExpandBtn
    {
        eNone = -1,
        eHandbook, //图鉴
        //eFriend,//好友（变为排榜）
        eSysseting,//设置
        eMax = 2,
    }

    public enum EActivityMenuBtn
    {
        eLottery = 0, //抽卡
        eMysteryShop, //神秘商店
        eActivity, // 活动
        eRecharge, //首冲(充值)
        eSign,//签到
    }

    public enum EMainPlayMenuBtn
    {
        eChallengeDng = 0,//闯关挑战 ,挑战副本
        eTavern,//酒馆
        eFrient, //好友
        eTravelingSalesman, //旅行商人
        eUnion, //工会
        eArena,  //擂台，竞技场
        eTechnology //科技
    }

    //全局的系统类型 对应这配置表的系统类型
    public enum ESystemType
    {
        eNone = -1,
        eChouKa = 0, //抽卡
        eShiLian = 1, //试练
        eChuangGuan = 2,//闯关
        eYouXiang = 3, //邮箱
        eQiangHua = 4, //武将强化
        eShenMiShangRen = 5,  //神秘商人
        eYuanZheng = 6,
        eLvXingShangRen = 7, //旅行商人
        eZhuangBeiQiangHua = 8,
        eXunLuo = 9, //巡逻
        eJueXingChi = 10,   //觉醒池
        eGongHui = 11, //工会
        ePaiHangBang = 12,//排行榜

        eActivity = 13, //活动
        eFriend = 14,
        eVip = 15,
        eSign = 16, //签到
        eShop = 17, //商城
        eFirstRecharge = 18, //首冲

        eHuntGem = 19,     //寻宝 -> 变成了攻城 --> Pvp
        eTask = 20,        //任务
        ePackage = 21,     //背包
        eRole = 22,        //角色
        eChat = 23,        //聊天
    }


    public enum EChallengeMenuType
    {
        eNone = -1,
        eChallengePatrol = 0,  //巡逻
        eChallengeExpedition, //远征
        eChallengeTrial, //试练 
        eChallengeParadise //缤纷乐园
    }

    public enum ESystemId
    {
        eNone = -1,
        eChouKa = 1000, //抽卡
        eShiLian = 1001, //试练
        eChuangGuan = 1002,//闯关
        eChuangGuanHard = 10021,//精英闯关
        eYouXiang = 1003, //邮箱
        eQiangHua = 1004, //技能升级
        eEquipMagic = 10041,//装备附魔
        eEquipStrenth = 10042,//装备强化
        eHeroAttri = 10043,//英雄屬性
        eShenMiShangRen = 1005,  //神秘商人
        eYuanZheng = 1006,
        eLvXingShangRen = 1007, //旅行商人  
        eZhuangBeiQiangHua = 1008,
        //eXunLuo = 1009, //巡逻
        eJueXingChi = 1010,   //觉醒池
        eGongHui = 1011, //公会
        ePray = 10111,  //公会祈福
        eRedbag=10112,//公会红包
        ePaiHangBang = 1012,//排行榜

        eActivity = 1013, //活动
        eFriend = 1014,
        eInviteFriend = 10141,//邀请好友
        eAskforVit = 10142,//索要体力
        eInviteFFriend = 10143,//邀请f好友
        eVip = 1015,
        eSign = 1016, //签到
        eShop = 1017, //商城 --> 还没做
        eFirstRecharge = 1018, //首冲

        eHuntGem = 1019,     //寻宝 ->变成了攻城 --> Pvp
        eTask = 1020,        //任务
        ePackage = 1021,     //背包
        eRole = 1022,        //角色
        eChat = 1023,        //聊天

        eParadise = 1024,    //乐园
        eParadiseExp = 10241, //经验乐园
        eParadiseGold = 10242, //金币乐园

        eChallenge = 1025 , //挑战
        eTuJian = 1026, //图鉴

        eRecharge = 1027, //充值
        eSeySetting = 1028,//设置界面
        eBuyBox = 1029,//购买宝箱
        eBuyDiamond = 10291,//购买钻石
        eBuyGold = 10292,//购买金币
        eBuyVit = 10293,//购买体力
        
    }

    // 棋子积分类型
    public enum EChessScoreType
    {
        eNone = 0,
        eNormal = 1, //普通消除
        eL_LNegative, //低阶负面消除 火、毒等
        eM_LNegative, //中阶负面消除
        eH_LNegative, //高阶负面消除
        eHH_LNegative,  //最高级负面消除 爱心，电石，石化
        eSpecialShockWave, //4消冲击波
        eSpecialHurricane, //T消
        eSpecialGas, //5消
        eAllShockWave,
        eAllHurricane,
        eAllGas,
        eStepAward = 12,
        CrossShockWave, //十字冲击波  4消 + 4消
        ThickCrossShockWave, //粗十字冲击波 4消+ T消
        BigHurricane, //巨炸 t消 + T消

        eBox = 30, //盒子 ，镜子
        eCollect1,//气球
        eSnow, //雪块
        eThinIce,//薄冰
        eVineLock,//藤锁
        eVenom,//毒液
        eBallGrey, //灰色毛球
        eBallBrun, //褐色毛球
        eBallBlack,//黑色毛球
        eGiftBox, //棋子礼盒
        eMagicBall, //水晶球
        eCloud, //云
        eChick, //鸡窝，彩蛋
        eGem, //宝石
        eQuicksand, //流沙
        eIcicle, //冰柱
        eSilverCoin, //银币
        eSnowman, //雪人
        eSeaMonster, //海怪
        eSnail, //蜗牛
        eBigEyeRoad = 50, //大眼仔
        eBee = 51,//蜜蜂 ， 果冻
        eKing = 52, //国王
        eCorn = 53, //玉米
        //eEgg,   //彩蛋

    }

    public enum EChessScoreRate
    {
        eNone = 0,
        eShockRate = 1,
        eBombRate,
        eGasRate,
        eGas2ShockWaveRate,
        eGas2BombRate,
        eGas2GasRate,
        eDoubleHitRate,//连击倍率
        eCrossShockWaveRate,
        eThickCrossShockWaveRate,
        eBigHurricaneRate,
    }

    ////棋盘类型
    //public enum EChessBoardType
    //{
    //    eNone = -1, 
    //    eFight = 0,      //战斗棋盘
    //    eTechnology = 1, //科技棋盘
    //}

    //战斗结果
    public enum EFightState
    {
        eNone = -1, // 战斗中
        eWinHaveHeroSurvive = 0,  //胜利有玩家存活,怪物全死亡
        eFailedAllHeroDead = 1,   //失败所有玩家死亡
        eFaildStepPoor,    //失败，步数不够，
        eFaildChessDead,   //失败，死局了
    }

    //单局结果
    //public enum EStageResult
    //{
    //    eNone = 1,
    //    eWin,              //胜利, 1、步数足够，怪物全部死亡，有剩余步数，分数达到一星
    //    eFaildAllHeroDead, //失败，所有玩家死亡,

    //    eFaildScorePoor,   //失败，分数不够（没有达到一星）
    //}

    public enum UnitType
    {
        Hero,   //自己的武将英雄
        Monster,    //怪物
        PlayerEnemy //敌人玩家
    }

    public enum EBattleState
    {
        eNone = -1,
        eBattleStart, //战斗开始
        eBattleEnd, //战斗结束
    }

    public enum EChessStepState
    {
        eNone = -1,
        eStepStart, //步骤开始
        eStepEnd,   //步骤结束
        //eRealFinish,
    }

    public enum ESoulBoxOpenState
    {
        eNone = 0,
        eShow = 1, //显示
        eNotShow = 2, //不显示
        eOpen = 3, //开启
    }

    public enum ELotteryItemType
    {
        //required int32 type = 1[default=1];//抽卡类型 1 金币1次，2 金币10次，3 钻石1次，4 钻石10次，5 限时1次
        eNone = 0,
        eGoldOne = 1,  //金币一次
        //eGoldTen = 2, //金币10次         弃用
        eDiamondOne = 2,//钻石一次
        //eDiamondTen = 4, //钻石10次  //弃用
        eSoulLottery = 3, //魂匣抽卡

        eDailyAward = 4,
        eSnatchBox = 5,
    }

    public enum ELotteryBoxType
    {
        eNone = 0,  //无
        eIronBox = 1,   //铁质宝箱
        eSilverBox = 2, //白银宝箱
        eGoldBox = 3,   //黄金宝箱
        eSuperBox = 4,  //超大宝箱
        eMagicBox = 5,  //神奇宝箱
        eSuperMagicBox = 6, //超大神奇宝箱
        eFreeBox = 7,  //免费宝箱
        eWinBox = 8,   //胜场宝箱
        eNoviceBox = 9, //新手宝箱
    }

    //public enum ELotteryItemSubType
    //{
    //    eNone = 0,
    //    eGoldOneFree,          //金币一次免费
    //    eGoldOneCost,         //金币一次收费
    //    eGoldTen, //金币10次
    //    eDiamondOneFree, //钻石一次免费
    //    eDiamondOneCost, //钻石一次收费
    //    eDiamondTen, //钻石10次
    //    eSoulLottery, //魂匣
    //}

    public enum ELotteryType
    {
        eNone = -1,
        eGoldLottery,  //金币抽卡
        eDiamondLottery, //钻石抽卡
        eSoulLottery, //魂匣抽卡
    }

    public enum ELotteryGoldFree
    {
        eNone = -1,
        eFree = 0, //免费
        eCost = 1, //收费
    }

    public enum ELotteryDiamondFree
    {
        eNone = -1,
        eFree = 0, //免费
        eCost = 1, //收费
    }

    public enum ELotteryCostType
    {
        eNone = -1,
        eGold,
        eDiamond,
    }

    public enum ELotteryAwardType
    {
        eNone = -1,
        eGoods = 0,
        eHero = 1,  //最新获得的英雄
        eHeroSoul = 2,
    }

    public enum EPlayerIconType
    {
        eNone = -1,
        eNormalHeroIcon, //一般的英雄头像
        eNormalUrlIcon, //一般的Url头像
        ePvpFirstHeroIcon, //拿过pvp第一的英雄头像
        ePvpFirstUrlIcon, //拿过pvp第一的url头像
    }
    //关卡难度
    public enum EStageDifficulty
    {
        eNormal = 0, //普通
        eHard, //困难
        eSnatch, //夺宝
    }

    public enum EStageOpenType
    {
        eNormal = 0, //正常开启
        eFromFight,  //来自战斗结束
        eFromUIJump, //来自UI跳转
        eFromReStart, //重新开始
        eFromSnatchFight, //来自夺宝战斗
    }

    public enum ETrialsHeroLimit
    {
        eNone = -1, //没有限制
        eFemale = 0, //限制女角色
        eMale = 1, //限制男角色
    }

    public enum EHeroGender
    {
        eNone = -1, 
        eMale = 0,  //男
        eFemale = 1, //女
    }

    //技能等级系数成长公式 = 基础系数 + 技能等级 * 成长系数
    public enum ESkillLevelFormula
    {
        eSkillFactor = 0,   //技能系数
        eSkillEnhanceFactor,    //技能伤害加成系数
        eBuffProbFactor,    //buff概率系数
        eBuffFactor,    //buff效果系数
        eBuffTriggerFactor, //buff触发新技能系数
    }

    public enum EGuideGolbalEvent : int
    {
        ChangeLevel = 1,  //主公等级改变
        EnterInstance,//进入场景
        LeaveInstance,//离开场景
        ChangeExp = 4,//主公经验
        //FightRoundPre = 5,//回合前
        //FightRoundBack = 6, //波数后
        EnterStage = 7,//进入关卡
        FightBoPre = 8,//几波开始前
        FightEnd = 9,//战斗结束
        FinishState = 10,//完成某一关
        //FinishGuide = 11,//完成某一指引
        StateResult  = 11,//某一关结算
        EnterPvPOLPanel = 12,//进入pvpol对战界面
        StateSuccessResult = 13,//某一关胜利界面结算
        HaveHeroCanUpLevel = 14,//某一英雄可以升级
        HaveEquipChanAdmix = 15,//某一个装备可以进阶
        FinishGuide = 16,//某一指引完成
        ClosePvPUpgradepanel = 17,//关闭pvp等级升级界面
        OpenStageDetailPanel = 18,//打开某一关的关卡详情界面
    }

    //气泡指引事件
    public enum EGuideBubbleEvent : int 
    {
        EnterMainPage = 1,//进入主界面
        EnterStarAwardPage = 2,//打开星星奖励界面
    }

    //点击气泡指引路劲按钮
    public enum EGuildBubbleClickEvent : int 
    {
        eClickStarAwardBtn = 1,//点击打开星星奖励界面按钮
        eClickStarAwardOkBtn = 2,//点击领取星星奖励按钮
        eClickRoleBtn = 3,//点击打开角色详情按钮
    }

    //wait signal 
    public enum SignalEvents : byte//控制引导流程的事件
    {
        AnyClick = 1,
        ButtonClick = 2,
        FinishDialog = 3,
        Sleep = 4,
        StartGuide = 5,
        EnterResultPanel = 6,//到达结算界面
        EnterPvPPanel = 7,//pvp场景加载完成
        BakeMainPanel = 8,//回到主界面
        ChangeCampPos = 9,//更换阵容位置完成
        LottorypopuFinish = 10,//抽卡结束
        RenameFinish = 11,//起名结束
        XinShouLiBaoGet = 12,//领取新手礼包
        MsgReturn = 13,//协议返回
        FtueBubbleFinish = 14,//气泡消失
    }

    public enum PVPOLTimeType
    {
        WaitEnterTime = 1,  //等待进入游戏时间
        RoundTime,  //战斗单人每轮的时间
        TotalStep,  //战斗总回合数
        SelectHeroTime, //选人时间
        LineupTime, //调整阵容时间
        OffLineTime,    //调整阵容时间
        LoadResTime,    //进入战斗读条等待时间
    }

    public enum PVPOLRandType
    {
        Rand_Hit = 0,   //命中
        Rand_Crit,  //暴击
        Rand_PreBuff_Hit,   //前置Buff命中
        Rand_Buff_Hit,  //Buff命中
        Rand_Buff_Trigger,  //Buff触发
        Rand_Anti_Magic,    //Buff魔免
        Rand_Purify,    //净化
        Rand_Dispel,    //驱散

        Rand_Count, //类型数量
    }

    //弹窗
    public enum EPopWindowState
    {
        NONE = 0,

        NO_LOCAL_RES_VER,//本地版本文件不存在
        LOAD_FAIL_LOCAL_RES,//本地文件加载失败
        LOAD_FAIL_LOCAL_CACHE_VER,//加载缓冲目录版本文件失败        
        LOAD_FAIL_SERVER_RES_VER,//服务器版本文件加载失败
        LOAD_FAIL_SERVER_RES,//服务器文件加载失败
        NEED_UPDATE_ALL,//需要更新完整包，旧包仍可继续玩，弹窗
        FORCE_UPDATE_ALL,   //强制更新完整包
        //NO_NEED_UPDATE_ALL,//不需要更新完整包，旧包仍可继续玩，不弹
        INCREMENTAL_UPDATE,//增量更新
        UPDATE_CONFIRM,//更新确认
        DOWNLOAD404,//下載失敗資源文件不存在
    }

    public enum GuildGameType
    {
        None = 0,
        Pray,   //祈福
        RedBag, //红包
        Shop,   //商店
        Card,   //卡牌
        Dice,   //大富翁
        Stage,  //副本
        Battle  //公会战
    }

    //系统红点类型
    public enum ERedDotType 
    {
        ePvpChestOpen       = 1,//pvp宝箱可以开启
        eFriendAskStrngth   = 2,//好友索要体力
        eNewEmail           = 3,//新邮件
        eShopRefresh        = 4,//商店刷新
        eNewHeroPhoto       = 5,//新武将（图鉴）
        eSignin             = 6,//签到
        eFriendApply        = 7,//好友申请加为好友
        ePlatInviteFriend   = 8,//FB邀请未玩游戏好友
    }

    public enum EGuildFightStageType //公会战阶段
    {
        eNotOpen        = 0,//工会战未开始
        eApplyWaitTime  = 1,//报名等待时间
        eApplyTime      = 2,//报名时间
        ePreliminaryOneWaitTime    = 3,//预选赛1等待阶段
        ePreliminaryOneTime = 4, //预选赛1
        ePreliminaryOneResult = 5,//预选赛1奖励阶段
        ePreliminaryTwoWaitTime = 6,//预选赛2等待阶段
        ePreliminaryTwoTime = 7,//预选赛2
        ePreliminaryTwoResult = 8,//预选赛2奖励阶段
        ePreliminaryThreeWaitTime = 9,//预选赛3等待阶段
        ePreliminaryThreeTime = 10,//预选赛3阶段
        ePreliminaryThreeResult = 11,//预选赛3奖励阶段
        eSemifinalWaitTime = 12,//半决赛等待阶段
        eSemifinalTime = 13,//半决赛阶段
        eSemifinalResult = 14,//半决赛奖励阶段
        eFinalWaitTime = 15,//决赛等待阶段
        eFinalTime = 16,//决赛阶段
        eFinalResult = 17,//决赛结算阶段
    }

    public enum EUITexture
    {
        headicon,
        gather,
        loading,
        pvpol_debuff,
        box,
        star,
        goods,
    }

    public enum ESpecialBreakChess
    {
        eNone = -1,
        eMagic,
        eEgg,
        eBlackBall,
        eFurBall,
        //eBurnBall,
        eVenom,
        eNegativeChess, 
    }

    public enum EComButtonColor
    {
        Blue = 1,
        Green = 2,
        Red = 3,
        Yellow = 4
    }

    public enum ESnatchKey
    {
        //夺宝钥匙
        eNone = -1,
        eKeyCopper = 0, //铜
        eKeySilver = 1,
        eKeyGold = 2,
    }
    //夺宝类型
    public enum ESnatchType
    {
        eNone = -1,
        eMine = 0,//自己
        eOther = 1, //其他人
    }
    //夺宝关卡类型
    public enum ESnatchStageType
    {
        eNone = -1,
        eNotOpen = 0,
        eOpenNotPass = 1,
        ePassed = 2,
        eBatting = 3, //战斗中
    }

    public enum ESnatchBoxState
    {
        eNone = -1,
        eCanGet = 0, //可以领取
        eCanNotGet = 1, //不可以领取
        eYetGet = 2,
    }

    public enum ESnatchFrom
    {
        eNone = -1,
        eFromMainUI,
        eFromOther,
        eFromFight,
    }

    public enum ESnatchBoxRequestStage
    {
        eNone = -1,
        eRequesting = 0,
    }
    public enum VoiceType
    {
        #region chess
        /***************************************chess begin****************************************/
        #region 旧音效
        //爆炸combo声音
        //A_combo1,
        //A_combo2,
        //A_combo3,
        //A_combo4,
        //A_combo5,
        //A_combo6,
        chess_eliminate_1,   //
        chess_eliminate_2,
        chess_eliminate_3,
        chess_eliminate_4,
        chess_eliminate_5,
        chess_eliminate_6,
        chess_eliminate_7,
        chess_eliminate_8,

        chess_finish_good,
        chess_finish_great,
        chess_finish_wow,
        chess_finish_amazing,
        chess_finish_unbelievable,

        //消除个数声音
        //V_combo30,  //三消
        //V_combo40,
        //V_combo50,
        //V_combo60,
        //V_combo70,
        //V_combo80,

        chess_falsemove, //交换错误
        chess_select, //选中棋子
        chess_reward_step,
        //A_ground, 
        //chess_board_drop,   //棋子落地

        chess_icebroken,  //冰块破裂
        //G_boxbroken,  //盒子破碎(弃用)
        chess_lockbroken, //锁破裂
        //G_ballooncreate, //气球收集
        #endregion

        chess_show_shockwave,
        chess_show_l,
        chess_show_ghost,  //幽灵棋子出现音效

        chess_board_crush,
        chess_crush_shockwave,
        chess_crush_l,
        chess_crush_t,
        chess_crush_ghost,
        chess_crush_ghost_shockwave,
        chess_crush_ghost_l,
        chess_crush_ghost_ghost,

        chess_buff_magicvine_crush, //魔法藤被消除消失
        chess_buff_venom_crush,//毒液被消除
        chess_buff_venom_appear,//毒液出现
        chess_buff_brown_crush,//棕色毛球被消除
        chess_buff_brown_move,//棕色毛球移动音效
        chess_buff_grass1_crush,//一级草丛消除
        chess_buff_grass2_crush,//二级草丛消除
        chess_buff_grass3_crush,//三级草丛消除
        chess_buff_grass4_crush,//四级草丛消除
        chess_buff_grass5_crush,//五级草丛消除
        chess_buff_cat_collect,//猫咪被收集音效
        chess_buff_dirt1_crush,//泥土1级碎裂
        chess_buff_dirt2_crush,//泥土2级碎裂
        chess_buff_clod_crush,//土块碎裂


        chess_buff_lock,    //铁锁buff音效
        chess_buff_frozen,  //冰冻buff音效
        chess_buff_twolock, //双重铁锁buff音效
        chess_buff_twofrozen,   //双重冰冻buff音效
        chess_buff_cirrus,  //大藤蔓出现音效
        chess_buff_smallcirrus, //小藤蔓出现音效
        chess_buff_poisonappear,    //毒药瓶出现音效
        chess_buff_poisonboom,  //药瓶爆炸音效
        chess_buff_powderappear,    //火药瓶出现音效
        chess_buff_powderboom,  //火药瓶爆炸音效
        chess_buff_questionappear,  //问号出现音效
        chess_buff_questionboom,    //问号爆炸音效
        chess_buff_petrifactionappear,  //石化出现音效
        chess_buff_petrifaction,    //石化棋子音效
        chess_buff_calciumappear,   //电石出现音效
        chess_buff_calcium, //电石效果音效
        chess_buff_poisoningappear, //中毒出现音效
        chess_buff_poisoning,   //中毒持续音效
        chess_buff_burningappear,   //燃烧出现音效
        chess_buff_burning, //燃烧效果音效
        chess_buff_purify,  //棋子buff消除音效
        chess_buff_bombappear,  //炸弹出现音效
        chess_buff_bombboom,    //炸弹爆炸音效
        chess_buff_heartappear,   //爱心出现音效
        chess_buff_heart,   //爱心爆炸



        //king
        chess_pollyking_death,//波利被杀死音效
        chess_pollyking_eliminate,//波利国王被消除的音效
        chess_pollyking_vertigo,//波利国王眩晕音效

        //跳跃毛球
        chess_polly_vertigo,//波利被打晕音效
        chess_polly_jump,//波利跳跃音效
        chess_polly_eliminate,//波利被消除音效

        //玉米
        chess_angerkumamoto_eliminate,//愤怒的熊本被消除音效
        chess_kumamoto_eliminate,//熊本被消除音效

        //果冻
        chess_jelly_eliminate,//果冻破裂音效

        //鸡蛋
        chess_egg_eliminate,//鸡蛋爆炸音效

        //章鱼
        chess_octopus_eliminate,//章鱼吐泡泡音效
        chess_octopus_runshi, //毒液吃棋子



        /***************************************UI end****************************************/
        #endregion

        #region UI
        /***************************************UI begin****************************************/
        //旧声效
        UI_heartexplode,

        //公用
        ui_button_click,
        ui_system_change,
        ui_system_close,
        ui_system_open,
        //ui_system_tips,
        ui_player_uplevel,

        //装备系统
        //ui_equip_compose_ok,
        //ui_equip_strengthen,

        //武将系统
        //ui_hero_advanced,
        ui_hero_upskill,
        //  ui_hero_upstar,

        //背包系统
        //ui_sell_ok,

        //任务系统
        ui_task_reward,

        //战斗系统
        ui_battle_win,
        ui_battle_fail,
        ui_battle_star1,
        ui_battle_star2,
        ui_battle_star3,
        ui_battle_heroicon_hit,
        //ui_battle_heroicon_show,

        //图鉴
        ui_guide_open,  //图鉴打开
        /***************************************UI end****************************************/
        #endregion

        #region city
        /***************************************city begin****************************************/
        //city_environment_bird,         //鸟叫
        //city_environment_noise,         //吵闹声
        //city_environment_stream,        //流水声
        //city_environment_waterfall,     //瀑布声 
        /***************************************city end****************************************/
        #endregion

        #region model
        /***************************************model begin****************************************/
        //被击
        model_battle_man,
        model_battle_woman,

        //掉落
        // model_battle_gold,

        //脚步声
        model_step_grass,
        model_step_grass_arrive,
        model_step_ground,
        model_step_ground_arrive,

        //攻击技能
        model_M0001_attack,
        model_M0002_attack,
        model_M0003_attack,
        model_M0004_attack,
        model_M0005_attack,
        model_M0006_attack,
        model_M0007_attack,
        model_M0008_attack,
        model_M0009_attack,
        model_M0010_attack,
        model_M0011_attack,
        model_M0012_attack,
        model_M0013_attack,
        model_M0014_attack,
        model_M0015_attack,
        model_M0016_attack,
        model_M0017_attack,
        model_M0018_attack,
        model_M0019_attack,
        model_M0020_attack,
        model_M0021_attack,
        model_M0022_attack,
        model_M0037_attack,
        model_M0040_attack,
        model_M0043_attack,
        model_M0046_attack,
        model_M0049_attack,

        model_P1001_attack,
        model_P1001_skill,
        model_P1001_superskill,

        model_P1002_attack,
        model_P1002_skill,
        model_P1002_superskill,

        model_P1003_attack,
        model_P1003_skill,
        model_P1003_superskill,

        model_P1004_attack,
        model_P1004_skill,
        model_P1004_superskill,

        model_P1005_attack,
        model_P1005_skill,
        model_P1005_superskill,

        model_P1006_attack,
        model_P1006_skill,
        model_P1006_superskill,

        model_P1007_attack,
        model_P1007_skill,
        model_P1007_superskill,

        model_P1008_attack,
        model_P1008_skill,
        model_P1008_superskill,

        model_P1009_attack,
        model_P1009_skill,
        model_P1009_superskill,

        model_P1010_attack,
        model_P1010_skill,
        model_P1010_superskill,

        model_P1011_attack,
        model_P1011_skill,
        model_P1011_superskill,



        model_P2001_attack,
        model_P2001_skill,
        model_P2001_superskill,

        model_P2002_attack,
        model_P2002_skill,
        model_P2002_superskill,

        model_P2003_attack,
        model_P2003_skill,
        model_P2003_superskill,

        model_P2004_attack,
        model_P2004_skill,
        model_P2004_superskill,

        model_P2005_attack,
        model_P2005_skill,
        model_P2005_superskill,

        model_P2006_attack,
        model_P2006_skill,
        model_P2006_superskill,

        model_P2007_attack,
        model_P2007_skill,
        model_P2007_superskill,

        model_P2008_attack,
        model_P2008_skill,
        model_P2008_superskill,

        model_P2009_attack,
        model_P2009_skill,
        model_P2009_superskill,

        model_P2010_attack,
        model_P2010_skill,
        model_P2010_superskill,

        model_P2012_attack,
        model_P2012_skill,
        model_P2012_superskill,

        model_P3001_attack,
        model_P3001_skill,
        model_P3001_superskill,

        model_P3002_attack,
        model_P3002_skill,
        model_P3002_superskill,

        model_P3003_attack,
        model_P3003_skill,
        model_P3003_superskill,

        model_P3004_attack,
        model_P3004_skill,
        model_P3004_superskill,

        model_P3005_attack,
        model_P3005_skill,
        model_P3005_superskill,

        model_P3006_attack,
        model_P3006_skill,
        model_P3006_superskill,

        model_P3007_attack,
        model_P3007_skill,
        model_P3007_superskill,

        model_P3008_attack,
        model_P3008_skill,
        model_P3008_superskill,

        model_P3009_attack,
        model_P3009_skill,
        model_P3009_superskill,

        model_P3010_attack,
        model_P3010_skill,
        model_P3010_superskill,

        model_P3011_attack,
        model_P3011_skill,
        model_P3011_superskill,


        model_P4001_attack,
        model_P4001_skill,
        model_P4001_superskill,

        model_P4002_attack,
        model_P4002_skill,
        model_P4002_superskill,

        model_P4003_attack,
        model_P4003_skill,
        model_P4003_superskill,

        model_P4004_attack,
        model_P4004_skill,
        model_P4004_superskill,

        model_P4005_attack,
        model_P4005_skill,
        model_P4005_superskill,

        model_P4006_attack,
        model_P4006_skill,
        model_P4006_superskill,

        model_P4007_attack,
        model_P4007_skill,
        model_P4007_superskill,

        model_P4008_attack,
        model_P4008_skill,
        model_P4008_superskill,

        model_P4009_attack,
        model_P4009_skill,
        model_P4009_superskill,

        model_P4010_attack,
        model_P4010_skill,
        model_P4010_superskill,


        model_P4011_attack,
        model_P4011_skill,
        model_P4011_superskill,
        //武将上阵音效
        model_p1001_battleaction,
        model_p1002_battleaction,
        model_p1003_battleaction,
        model_p1004_battleaction,
        model_p1005_battleaction,
        model_p1006_battleaction,
        model_p1007_battleaction,

        model_P2001_battleaction,
        model_P2002_battleaction,
        model_P2003_battleaction,
        model_P2004_battleaction,
        model_P2005_battleaction,
        model_P2006_battleaction,
        model_P2007_battleaction,
        model_P2008_battleaction,
        model_P2009_battleaction,
        model_P2010_battleaction,

        model_P3001_battleaction,
        model_P3002_battleaction,
        model_P3003_battleaction,
        model_P3004_battleaction,
        model_P3005_battleaction,
        model_P3006_battleaction,


        model_P4001_battleaction,
        model_P4002_battleaction,
        model_P4003_battleaction,
        model_P4004_battleaction,
        model_P4005_battleaction,
        model_P4006_battleaction,
        model_P4007_battleaction,

        model_P1011_battleaction,
        model_P1010_battleaction,
        model_P2012_battleaction,
        model_P3007_battleaction,
        model_P3009_battleaction,
        model_P3010_battleaction,
        model_P3011_battleaction,
        model_P4009_battleaction,
        model_P4011_battleaction,
        model_P4010_battleaction,

        //武将系统休闲音效
        model_P1001_leisureaction,


        model_P1002_leisureaction,


        model_P1003_leisureaction,


        model_P1004_leisureaction,


        model_P1005_leisureaction,


        model_P1006_leisureaction,


        model_P1007_leisureaction,


        model_P2001_leisureaction,


        model_P2002_leisureaction,


        model_P2003_leisureaction,


        model_P2004_leisureaction,


        model_P2005_leisureaction,


        model_P2006_leisureaction,


        model_P2007_leisureaction,


        model_P2008_leisureaction,


        model_P2009_leisureaction,


        model_P2010_leisureaction,


        model_P3001_leisureaction,


        model_P3002_leisureaction,


        model_P3003_leisureaction,


        model_P3004_leisureaction,


        model_P3005_leisureaction,


        model_P3006_leisureaction,


        model_P4001_leisureaction,


        model_P4002_leisureaction,


        model_P4003_leisureaction,


        model_P4004_leisureaction,


        model_P4005_leisureaction,


        model_P4006_leisureaction,


        model_P4007_leisureaction,

        model_P1011_leisureaction,

        model_P1010_leisureaction,

        model_P2012_leisureaction,

        model_P3007_leisureaction,

        model_P3009_leisureaction,

        model_P3010_leisureaction,

        model_P3011_leisureaction,

        model_P4009_leisureaction,

        model_P4010_leisureaction,

        model_P4011_leisureaction,
        //宝箱抽卡音效
        chests_appear,//宝箱出现
        chests_open,//宝箱打开
        chests_neocaine,//抽到新卡
        card_appear,//卡片出现


        //关卡道具选择
        // ui_stage_item,
        //ui_stage_change,
        ui_stage_open,
        //购买成功
        ui_buy_ok,


        ui_system_boss,//boss报警音效
        ui_system_collection,//收集目标提醒音效
        ui_system_collectionl,//收集目标完成提醒 ui_system_collection1
        ui_system_complete,//胜利音效
        ui_system_logo,//logo音效
        ui_system_return,//武将复活音效

        chess_buff_bigvenom_crush,//大史莱姆分解
        chess_buff_box_crush,//礼盒被消除
        chess_buff_gold_crush,//金币被消除
        chess_buff_sonw_crush,//雪块被消除
        ui_levelup_hero,//武将升品音效
        ui_hero_upstar,//武将升级音效
        ui_hero_advanced,//武将上阵音效
        chess_crush_ghost_chess,//大招转换普通棋子的声音
        prop_thunder,//雷电道具
        prop_strengthen_chess,//强化棋子
        prop_realignment,//重新排列道具
        // prop_select_chess,//选中棋子

        Union_cat_select,//公会中点击猫的声音
        Union_cat_appear_dis,//猫出现/消失的声音
        Pvp_countdown,//PVP战斗倒计时3秒的音效.
        pvp_ready_go,//pvp ready go 的音效 
        #endregion
        Gold_increase,//金币奖励音效
        COUNT,
        NONE,
        ui_system_open_1,//面板横着出来的打开音效
        ui_system_close_1,//面板横着出来的关闭音效
        ui_system_open_2,//面板弹出来的打开音效
        ui_system_close_2,//面板弹出来的关闭音效

        ui_task_star_box,//任务列表星星切换宝箱
        ui_figure_list,//任务列表弹出
        ui_shop_system,//商店界面弹出
        ui_combat_clauses,//战斗中收集目标条目声音
        ui_gather_generate,//收集物生成音效

        OneArmBanditOpen,
        OneArmBandit,

        ui_expression_complacent,//表情得意
        ui_expression_happy,//表情开心
        ui_expression_anger,//表情生气
        ui_expression_cry,//表情大哭

        ui_fly_star,//飞星星
        ui_power_alter,//体力改变

        ui_hero_up,//pvp升阶音效

        ui_deblocking,//关卡道具解锁

        ui_test_gold,//试练获取金币钻石音效
    }


}

