using UnityEngine;
using System.Collections;
using System.IO;
using System;
using Object = UnityEngine.Object;

public class ResourceManager : Singleton<ResourceManager>
{
    private IResourceLoader mResLoader = new ResourcesLoader();
    private IResourceLoader mAssetLoader = new AssetLoader();


    private AssetBundle shared;

    /// <summary>
    /// 初始化
    /// </summary>
    public void initialize(Action func)
    {
        //            if (AppConst.ExampleMode) {
        //                byte[] stream;
        //                string uri = string.Empty;
        //                //------------------------------------Shared--------------------------------------
        //                uri = Util.DataPath + "shared" + AppConst.ExtName;
        //                Debug.LogWarning("LoadFile::>> " + uri);

        //                stream = File.ReadAllBytes(uri);
        //                shared = AssetBundle.LoadFromMemory(stream);
        //#if UNITY_5
        //        shared.LoadAsset("Dialog", typeof(GameObject));
        //#else
        //                shared.Load("Dialog", typeof(GameObject));
        //#endif
        //            }
        GameConfig.Instance.Init();

        if (func != null) func();    //资源初始化完成，回调游戏管理器，执行后续操作 
    }

    public string LoadText(string fileName, ResourceCacheType cacheType = ResourceCacheType.rctNone)
    {
        string ret = mAssetLoader.LoadText(fileName, cacheType);
        if (ret != null)
            return ret;
        return mResLoader.LoadText(fileName, cacheType);
    }

    /// <summary>
    /// 载入素材
    /// </summary>
    public AssetBundle LoadBundle(string name)
    {
        byte[] stream = null;
        AssetBundle bundle = null;
        string uri = Util.DataPath + name.ToLower() + AppConst.ExtName;
        stream = File.ReadAllBytes(uri);
        bundle = AssetBundle.LoadFromMemory(stream); //关联数据的素材绑定
        return bundle;
    }

    /// <summary>
    /// 销毁资源
    /// </summary>
    void OnDestroy()
    {
        if (shared != null) shared.Unload(true);
        Debug.Log("~ResourceManager was destroy!");
    }

    public static T LoadSrc<T>(string path, string subNmae, AssetBundleType type, bool instantiate = true) where T : Object
    {
        if (string.IsNullOrEmpty(path))
        {
            Debug.LogError("path is null!");
            return default(T);
        }

        //if (HeroGame.Instance.IsUseAssetBundle)
        //{
        //    AssetBundleData abData = HeroGame.Instance.SrcManager.SyncLoadBundle(path, type);
        //    if (abData == null)
        //        return null;

        //    UnityEngine.Object o = HeroGame.Instance.SrcManager.SynLoadSrc(path, subNmae, typeof(T), instantiate);
        //    if (o == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return (T)o;
        //    }
        //}
        //else
        {
            UnityEngine.Object res = Resources.Load(string.Format("{0}/{1}", path, subNmae));
            if (!instantiate)
                return (T)res;
            if (res == null)
            {
                return default(T);
            }
            if (res is GameObject)
            {
                return (T)GameObject.Instantiate(res);
            }
            else if (res is Texture || res is Texture2D || res is Texture3D || res is Sprite )
            {
                return (T)res;
            }
            else
            {
                return (T)UnityEngine.Object.Instantiate(res);
            }
        }
    }
}

