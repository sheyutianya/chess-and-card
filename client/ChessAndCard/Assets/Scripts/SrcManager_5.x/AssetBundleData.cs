/******************************************************************
**负责人: 羊韵谕	
**日期:   2016/06/14
**描述：  AssetBundle实体类
********************************************************************/
using UnityEngine;
using System.Collections;

public enum AssetBundleType
{
    None,

    eConfig,
    Dependencies,//依赖包，这个标志不对外开放

    //资源加载
    eUpdateSrc,

    //新手引导
    eTutorial,

    //战斗分类
    eBattle,    //战斗
    eBattleChess, //战斗棋子

    //主场景分类
    eHeroBigIcon,
    
    eUIModule,     // UI模块
    
    eTempRes, //临时stay资源，切换场景的时候释放掉
    eStayRes, //常驻资源，游戏退出的时候释放
}

//延迟卸载
public class AssetBundleTypeInfo
{
    public float lifeTime = -1.0f;//默认是立即卸载
    public float tempTime;
    public bool releseInstanse = false;
    public bool unLoaded;//是否卸载

    public AssetBundleTypeInfo()
    {
        Reset();
    }

    public AssetBundleTypeInfo(float life_time)
    {
        lifeTime = life_time;
        tempTime = life_time;
    }

    public AssetBundleTypeInfo(bool releseIns)
    {
        releseInstanse = releseIns;
    }


    public void Reset()
    {
        tempTime = lifeTime;
        unLoaded = false;
    }
}

public class AssetBundleData
{
    private AssetBundle _assetBundle;   //AssetBundle
    public AssetBundle AssetBundle
    {
        get { return _assetBundle; }
        set { _assetBundle = value; }
    }
    private string name;    //Bundle名称，例如：updatesrc\ui\updatesrcui
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private AssetBundleType type;//类型
    public AssetBundleType Type
    {
        get { return type; }
        set { //if (type == AssetBundleType.None) Debug.LogError("AssetBundleType == None"); 
            type = value; 
        }
    }
    private int refCount;//引用计数
    public int RefCount
    {
        get { return refCount; }
        set { refCount = value; }
    }
    private string[] dependences;//依赖项
    public string[] Dependences
    {
        get { return dependences; }
        set { dependences = value; }
    }
    private bool loaded;    //加载标识
    public bool Loaded
    {
        get { return loaded; }
        set { loaded = value; }
    }
}
