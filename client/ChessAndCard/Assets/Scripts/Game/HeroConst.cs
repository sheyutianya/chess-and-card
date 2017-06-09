
public class SgHeroConst
{
    ////基础分
    //public static int NormalClear = 10;
    //public static int L_L_NegativeChess = 100; // 单冰，单铁 ，火，毒
    //public static int M_L_NegativeChess = 400; //炸弹、火药瓶、毒药瓶
    //public static int H_L_NegativeChess = 1000;//问号、藤蔓
    //public static int HH_L_NegativeChess = 1500; //爱心、石化、电石

    ////倍率
    //public static float ShockWaveRate = 1.5f; //四消倍率(冲击波倍率)
    //public static float BombRate = 2.0f;// T消倍率
    //public static float GasRate = 2.5f; //大招
    //public static float Gas2ShockWaveRate = 3.0f; //大招 + 4消
    //public static float Gas2BombRate = 3.5f;// 大招 + 炸弹
    //public static float Gas2GasRate = 5.0f; //大招 + 大招

    //public static float doubleHitRata = 1.0f; //连击倍率  连击数(大招不计算连击次数) * 连击倍率 * 基数

    ////技能消除单独得分
    //public static int ShockWave = 200;  //4消（冲击波）
    //public static int Bomb = 240; //T消
    //public static int Ghost = 300; //大招
    //public static int GhostShockWaveSwap = 2000;  //大招 + 冲击波
    //public static int GhostBombSwap = 2500;  //大招 + 炸弹
    //public static int Ghost2Swap = 5000; //大招 + 大招

    ////最后步数奖励
    //public const int StepAward = 3000;
    public static int Resolution_Width = 720;//分辨率
    public static int Resolution_Height = 1280;

    public static float RayDistance = 100;
    public static int StepToReward = 1;
    public static float ChessScale = 1f;
    public static int Max5StepsCount = 3;
    public static float TipTime = 5.0f;
    public static float PreGuideTipTime = 0.5f;
    public static float TechnologyTipTime = 3.0f;
    public static int MaxToolCount = 99;
    public static float FruitFrontDisplayScale = 0.6f;
    public static float FruitUpgradeScale = 0.35f;

    public static int m_iDefaulChessAttacker = 0;
    public static int m_iRandomChessBoradId = 901;
    public static int m_iLastFiveStepItemId = 21;
    public static int m_iTechnologyChessCount = 6;
    public static int DefaultLayer = 0;
    public static int BoardLayer = 10;
    public static int EffectLayer = 13;
    public static int UserGuideUILayer = 14;
    public static string MovableTag = "Movable";
    public static string UserGuideMovableTag = "UserGuideMovable";

    public static string ChessRoot = "ChessBoardRoot";
    public static string MovingChessRoot = "ChessRoot";
    public static string StaticChessRoot = "StaticRoot";
    public static string BoardGridRoot = "BoardGridRoot"; 
    public static string BoardGridRootKuang = "BoardGridRootKuang"; //框 ，用于8 * 8 ， 8 * 9 等棋子的适配
    public static string BoardHeiDi = "chess_background_center";
    public static string ComChessMat = "chess_com_mat";
    public static string ChessComObj = "chess_com_obj";
    public static string ChessHintRoot = "ChessHintRoot";
    public static string CollectPosRoot = "Collect1Condition";
    public static string RayBubbleRoot = "RayBubblePos";
    public static string ChessSelectRoot = "ChessSelectRoot";
    public static string SceneRoot = "SceneRoot";       //场景挂载点
    public static string SceneCamera = "HeroCamera";   //场景中的相机
    public static string SceneRootString = "scene_root"; //场景节点，方便遍历场景子元素
    public static string PhotoCamera = "photocamera";  //渲染到纹理相机
    public static string ChessCrushFx = "crush_fx";
    public static string ChessCamera = "ChessCamera";
    public static string GameUI = "GameUI";
    public static string GameScene = "GameScene";
    public static string BattleChessControl = "BattleChessControl";
    public static string UI_Root = "UI_Root";

    public static string Num1TipsPath = "Prefabs/UI/1_num";
    public static string m_strChessTextureBasePath = "UI/static/hero_chess/";
    public static string m_strChessTextureBasePath2 = "UI/static/hero_chess";

    public static string StoneEyeType0 = "UI/static/hero_chess/chess_eye0";
    public static string StoneEyeType1 = "UI/static/hero_chess/chess_eye1";
    public static string StoneEyeType2 = "UI/static/hero_chess/chess_eye2";
    public static string StoneEyeType3 = "UI/static/hero_chess/chess_eye3";
    public static string StoneEyeType4 = "UI/static/hero_chess/chess_eye4";

    public static int HeartPerNormalStage = 5;


    //public static string m_strChapterItemPath = "UI/panel/dng/big_map_item";

    public static string m_strHeroBigIconBasePath = "UI/static/hero_big_icon/";
    public static string m_strTexturePath = "UI/static/hero_texture/";

    public static string m_gatherTexturePath="UI/static/hero_texture/gather";
    public static string m_chatguildfightPath = "UI/static/hero_texture/chat";

    public static string m_strTransitAnimFxPath = "Game/Effect/Prefab/UI/Effect_guochang";
    public static string m_strHeroUpFxPath = "JieSuan_LVUPeff";

    //public static string m_strCostFitFx1 = "Game/Effect/Prefab/UI/fx_ui_kaishizhandou_01";
    //public static string m_strCostFitFx2 = "Game/Effect/Prefab/UI/fx_ui_kaishizhandou_02";

    public static string m_PageBgPath = "UI/static/hero_dng_big_map/";
    public static string m_PageBgBaseName = "map_no_";
    public static string m_ExpditionPageBgBaseName = "endless_map_";

    public static string m_TexturePath = "Textures/";

    //public static string m_TChessNode = "TChessNode"; //科技棋盘节点
    public static string m_ChessSelect = "chess_select";

    public static string m_S_ExpeditionHeroList = "store_expedition_hero_list";

    public static string m_S_PVPHeroList = "store_PVP_hero_list";

    public static string m_S_PVPCompHeroList = "store_PVPComp_hero_list";

    public static string m_S_TrialsHeroList = "store_Trials_hero_list";

    public static string m_S_TechnologyHeroId = "store_technology_hero_id";

    public static string m_S_ChessBoardData = "store_chess_board";

    public static string m_S_ChessToolFirstOpen = "store_chess_tool_open";
    public static string m_S_DeviceId = "store_device_id";
    public static string m_S_BuffBubbleList = "store_buffbubble_list";

    public static string m_PhotoRoot = "Photo";

    public static string m_S_UIBaseTexturePath = "UI/static/hero_texture/";

    public static string ChessBgMask = "chess_kuang_mask";

    public static string ChessBg = "chess_background";

    public static string m_strBoxComeOutAnim = "fx_kaibaoxiang_01";
    public static string m_strBoxOpenAnim = "fx_kaibaoxiang_03";
    public static string m_strBoxComeOutAnim2 = "fx_kaibaoxiang_04";

    public static string m_configOnMusic = "comfig_onmusic";
    public static string m_configOnAudio = "config_onaudio";
    public static string m_configMusicValue = "config_musicvalue";
    public static string m_configAudioValue = "config_audiovalue";


    public static string switchover_btn = "switchover_btn7";//帐号切换
    public static string startGame_btn = "startGame_btn7";//开始OYU登录
   // public static string register_btn = "register_btn3";//uyo直接登录
    public static string visitors_btn = "visitors_btn7";//游客登录
    public static string UYO_btn = "UYO_btn7";//UYO登录
    public static string chat_btn = "chat";//聊天

    //公会战提示
    public static string Guildfight_OpenTips = "guildfight_opentips";
    public static string Guildfight_PreliminaryOne = "guildfight_preliminaryone";
    public static string Guildfight_PreliminaryTwo = "guildfight_preliminarytwo";
    public static string Guildfight_PreliminaryThree = "guildfight_preliminarythree";
    public static string Guildfight_Semifinal = "guildfight_semifinal";
    public static string Guildfight_Final = "guildfight_final";
    public static string Guildfight_AwardTips = "guildfight_awardtips";

    public static string GuideBubbleFinish = "guidebubble_finish";

    public static int m_iZhaoYun = 5003;
    public static int m_iCaoRen = 5001;
    public static int m_iZhouQing = 5002;
    public static int m_iMaYunLu = 5004;
    public static int m_iXiaoNan = 5005;
    public static long m_lStandalonePlayerId = -100;
       
    #region New Battle
    public static readonly string AnimNameIdle = "idle";
    public static readonly string AnimNameIdle1 = "idle1";
    public static readonly string AnimNameStand = "stand";
    public static readonly string AnimNameRun = "run";
    public static readonly string AnimNameAttack1 = "attack1";
    public static readonly string AnimNameAttack2 = "attack2";
    public static readonly string AnimNameAttack3 = "attack3";
    public static readonly string AnimNameWin = "win";

    public static readonly string LotteryBoxIdle = "box_idle";
    public static readonly string LotteryBoxOpen = "box_open";
    public static readonly string LotteryBoxClose = "box_close";

    public static string CameraHeroParentString = "HeroCameraParent";
    public static string CameraHeroShakeString = "HeroCameraShake";

    public static string BattlePointString = "BattlePoind"; //jasonbao
    public static string BattleEffectPoindString = "EffectPoint"; //jasonbao
    public static string BakeMeshPointString = "BakeMeshPoind"; //jasonbao
    public static string CenterPointString = "CenterPoind"; //jasonbao

    public static string EffectRootString = "EffectRoot";

    public static string MonsterRootString = "MonsterRoot";
    public static string MonsterKeyString = "Monster_";

    public static string HeroRootString = "HeroRoot";
    public static string HeroKeyString = "Hero_";

    public static string EnemyRootString = "EnemyRoot";
    public static string EnemyKeyString = "Enemy_";

    public static string HitPointString = "HitPoint";
    public static string TopPointString = "HitPoint";
    public static string ShadowPointString = "Point001/Shadow";

    public static string PrefabModelPath = "Prefabs/Model/";
    public static string PrefabEffectPath = "Prefabs/Effect/";
    public static string PrefabChessPath = "Prefabs/Chess/";
    public static string PrefabUIPath = "Prefabs/UI/";

    public static string PrefabChessFxPath = "Game/Effect/Prefab/Chess/";
    public static string PrefabChessFxPath2 = "Game/";

    public static string SoundVoicePath = "Sounds/Voice/";

    public static string AnimationPath = "Animations/";

    public static string BloodBarString = "Prefabs/Battle/BloodBar"; 

    public static readonly string DropItemUI = "DropItem_UI";
    //public static readonly string DropItemBox = "DropItem_box";
    //public static readonly string DropItemRed = "DropItem_red";
    //public static readonly string DropItemBlue = "DropItem_blue";
    public static readonly string DropItemGold = "DropItem_gold";
    public static readonly string DropItemSilver = "DropItem_silver";
    public static readonly string DropItemCopper = "DropItem_copper";

    public static readonly int ReviveSkillAIID = 100005;    //复活固定技能ID

    public static readonly int MaxRandomValue = 100000; //随机数分母

    public static readonly int ParabolaCurvedId = 10004;    //抛物线掉落曲线动画id
    public static readonly int MoveUpCurvedId = 10005;  //向上移动曲线动画id
    #endregion


    public static string m_strNegativeAttrBuff = "negative_attr_buff";
    public static string m_strNumBuff = "num";


    public enum LastPangType
    {
        LastPang,
        StepReward,
        StepRewardPetEnd
    }

    public class ChessLife
    {
        public static int ChessIce = 2;
        public static int ChessDeepIce = 3;
        public static int ChessLock = 2;
        public static int ChessDoubleLock = 3;
    }



    public class LaterTimes
    {
        public static float ChessCrushTime = 0.35f; //普通棋子爆炸时间
        public static float StaticChessCrushTime = 0.6f; //静态棋子爆炸时间
        public static float ShockWaveCrushTime = 0.45f; //冲击波爆炸
        public static float ShockWaveCrushRecyleTime = 0.9f; //冲击波回收爆炸
        public static float DropAnimTime = 0.25f; //掉落时间
        public static float SwapDropTime = 0.05f;
        public static float DelayCrushTime = 0.4f; //延迟爆炸每次延迟时间
        public static float LastDelayCrushTime = 0.5f; //延迟爆炸最后的延迟时间
        public static float PoCrushTime = 0.2f; //步数奖励延迟时间
        public static float LastPangWaitTime = 1.2f; //等待LastPang开始的时间
        public static float WaitStepRewardTime = 1.3f; //等待步数奖励开始的时间
        public static float WaitStepRewardTotalTime = 3f; //等待步数奖励开始的时间
        public static float StageCompleteWaitTime = 0.5f; //单局结束到结算等待时间
        public static float Collect1CrushTime = 0.5f; //气球收集的时间
        public static float GasCrushTime = 0.2f; //幽灵的时间
        public static float DelayGasCrushTime = 0.05f; //幽灵对幽灵的消除每次等待时间
        public static float LastDelayGasCrushTime = 0.05f; //幽灵对幽灵的消除每次等待时间
        public static float RearrangeStep1Time = 0.8f;
        public static float RearrangeStep1WaitTime = 0.4f;
        public static float RearrangeStep2Time = 1.0f;
        public static float FruitFightTime = 0.3f;
        public static float GasLineTime = 0.5f;
        public static float GasBlendTime = 0.3f;
        public static float Gas2GasBlendTime = 1.7f;
        public static float Gas2GasBombTime = 0.5f;
        public static float ChessGasCrushingTime = 0.5f;
        public static float BattleMoveTime = 1.5f;  //战斗移动到下一个位置的时间
        public static float BattleResultOutTime = 1f;//战斗结果面板弹出延时
        public static float UpDownMoveTime = 0.5f;

        public static float StepDelayCrushTime = 0.3f; //延迟爆炸每次延迟时间
        public static float StepLastDelayCrushTime = 0.3f; //延迟爆炸最后的延迟时间

        public static float BreakTime = 0.5f; //毒瓶、火山等爆发时间
        public static float BreakTimeChessJoin = 0.8f; //毒品、火山等爆炸后其他棋子加入时间

        public static float ChessFlyFxTime = 0.4f; //棋子飞向角色时间
        public static float ChessFxRecycleTime = 0.7f; //棋子特效回收时间
        public static float ChessFlyIconTime = 0.3f;//棋子飞向icon时间
        public static float GatherFlyTime = 0.45f;
        public static float ChessFurBallMoveTime = 0.3f;

        public static float ChessTreatTime = 1.3f;
    }

    public class AnimNames
    {
        public static string ChessCrush = "ChessCrush";
        public static string ChessDrop = "ChessDrop";
        public static string ChessDropUp = "ChessDropUp";
        public static string ChessSwap = "ChessSwap";
        public static string ChessSwap01 = "ChessSwap_01";
        public static string Gas = "Gas";
        public static string Collect1Crush = "Collect1Crush";
        public static string ChessCrushByGas = "Chessbaidong";
        public static string ChessEat = "Chessdie";
        public static string ChessHint = "chess_daxiao";

        //毛球动画
        public static string BallNormal = "ball_grey";
        public static string BallMove = "ball_brun_xiaotiao";
        public static string BrunBallShake = "ball_brun_doudong_down";
        public static string HamsterNormal = "chess_hamster_01";
        public static string BallonDrop = "ballon_02";
        public static string BallonShake = "ballon_01";

        public static string BlackBallNormal = "ball_black_nomal"; //黑球普通
        public static string BlackBallStun = "ball_black_yunxun"; //黑球晕眩
        //public static string BlackBallUp = "ball_black_up"; //黑球起跳
        //public static string BlackBallDown = "ball_black_down";  //黑球落下
    }

    //越小越靠前
    public class SortingOrders
    {
        //public static float Cage = -0.1f;
        public static float Cage = -2f;  //change by lei at 2015/9/25
        //public static float Ice = 0.1f;
        public static float Ice = -1f;  //change by lei at 2015/9/25
        
        public static float Box = -1.2f;
        public static float Thin_Ice = 1;
        public static float BelowChess = 1;
        public static float BgMask = 0.2f;
        public static float Chess = 0;
        public static float Special = -1.1f;
        public static float AboveChess = -2.2f;
        public static float AboveSpecial = -0.9f;
        public static float AboveAll = -5;
        public static float BoardGrid = 1;
        public static float Num = -1; // add by lei at 2015/10/7
        public static float Select = 0.2f;
        public static float Border = -3f; //边框
        public static float BoarderByMask = 0;
    }

    public class LocalizeTextID
    {
        public static int VersionDownloading = 1;
        public static int Extracting = 2;
        public static int Copying = 3;
        public static int Login = 4;
        public static int ConfigLoading = 5;
        public static int NoticeLoading = 6;
        public static int SceneLoading = 7;
        public static int NoLocalResVer = 8;
        public static int LoadFailLocalCacheVer = 9;
        public static int LoadFailLocalRes = 10;
        public static int LoadFailServerResVer = 11;
        public static int LoadFailServerRes = 12;
        public static int UpdateTips = 13;
        public static int NoticeTitle = 14;
        public static int Download400 = 15;
        public static int CheckUpdate = 16;
    }

    public class FBEvent
    {
        public static string RegActive = "RegActive";//1
        public static string RegBlackScreenBegin = "RegBlackScreenBegin";//2
        public static string RegBlackScreenEnd = "RegBlackScreenEnd";//3
        public static string RegBlueGuyBegin = "RegBlueGuyBegin";//4
        public static string RegBlueGuyEnd = "RegBlueGuyEnd";//5
        public static string RegFileCopyBegin = "RegFileCopyBegin";//6
        public static string RegFileCopyEnd = "RegFileCopyEnd";//7
        public static string RegUpdateCheckBegin = "RegUpdateCheckBegin";//8
        public static string RegUpdateCheckEnd = "RegUpdateCheckEnd";//9
        public static string RegUnzipBegin = "RegUnzipBegin";//10
        public static string RegUnzipEnd = "RegUnzipEnd";//11
        public static string RegFirstLoadBegin = "RegFirstLoadBegin";//12
        public static string RegFirstLoadEnd = "RegFirstLoadEnd";//13
        public static string RegAnimationBegin = "RegAnimationBegin";//14
        public static string RegAnimationEnd = "RegAnimationEnd";//15
        public static string RegGuideBegin = "RegGuideBegin";//16
        public static string RegGuideEnd = "RegGuideEnd";//17
        public static string RegFirstMatchBegin = "RegFirstMatchBegin";//18
        public static string RegFirstMatchEnd = "RegFirstMatchEnd";//19
        public static string RegSleepGuyBegin = "RegSleepGuyBegin";//20
        public static string RegSleepGuyEnd = "RegSleepGuyEnd";//21
        public static string RegSecondLoadBegin = "RegSecondLoadBegin";//22
        public static string RegSecondLoadEnd = "RegSecondLoadEnd";//23
        public static string RegMainPage = "RegMainPage";//24
    }

    public class FBAnEvent 
    {
        public static string RegAnActive = "RegAnActive";//1
        public static string RegAnWhiteScreenBegin = "RegAnWhiteScreenBegin";//2
        public static string RegAnWhiteScreenEnd = "RegAnWhiteScreenEnd";//3
        public static string RegAnBlackScreenBegin = "RegAnBlackScreenBegin";//4
        public static string RegAnBlackScreenEnd = "RegAnBlackScreenEnd";//5
        public static string RegAnBlueGuyBegin = "RegAnBlueGuyBegin";//6
        public static string RegAnBlueGuyEnd = "RegAnBlueGuyEnd";//7
        public static string RegAnUnzipObbBegin = "RegAnUnzipObbBegin";//8
        public static string RegAnUnzipObbEnd = "RegAnUnzipObbEnd";//9
        public static string RegAnUpdateCheckBegin = "RegAnUpdateCheckBegin";//10
        public static string RegAnUpdateCheckEnd = "RegAnUpdateCheckEnd";//11
        public static string RegAnLoadingBegin = "RegAnLoadingBegin";//12
        public static string RegAnLoadingEnd = "RegAnLoadingEnd";//13
        public static string RegAnMainPage = "RegAnMainPage";//14
        public static string RegAnLoginFacebook = "RegAnLoginFacebook";//15
        public static string RegAnLoginFast = "RegAnLoginFast";//15
        public static string RegAnGamePage = "RegAnGamePage";//16

    }
}