/*----------------------------------------------------------------
// 模块名：Resources加载类封装
// 模块描述：
//         1、用于测试环境资源加载
//		   2、已支持异步加载回调
//----------------------------------------------------------------*/
using System;
using UnityEngine;

public class ResourcesLoader : IResourceLoader
{
    private static readonly string cResourcesStartPath = "resources/";

    protected bool IsResLoaderFileName(ref string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return false;
        int startIdx = fileName.IndexOf(cResourcesStartPath, StringComparison.CurrentCultureIgnoreCase);
        if (startIdx >= 0)
        {
            startIdx += cResourcesStartPath.Length;

            fileName = fileName.Remove(0, startIdx);

            return true;
        }

        return false;
    }
    public T LoadObject<T>(string fileName, ResourceCacheType cacheType) where T : UnityEngine.Object
    {
        if (string.IsNullOrEmpty(fileName))
            return null;

        T ret = null;
        string orgFileName = fileName;

        bool isFirstLoad = (ret == null);
        if (isFirstLoad)
        {
            if (IsResLoaderFileName(ref fileName))
                ret = Resources.Load<T>(fileName);
            else
            {
                return null;
            }
        }

        return ret;
    }

//    public bool LoadObjectAsync<T>(string fileName, ResourceCacheType cacheType, int priority, Action<float, bool, T> onProcess) where T : UnityEngine.Object
//    {
//        if (string.IsNullOrEmpty(fileName))
//            return false;

//        string orgFileName = fileName;
//#if USE_HAS_EXT
//        T obj = FindCache<T>(orgFileName);
//        if (obj != null)
//        {
//            if (AddRefCache(orgFileName, obj, cacheType, typeof(T)) != null)
//            {
//                if (onProcess != null)
//                    onProcess(1.0f, true, obj);
//                return true;
//            }
//        }
//#endif

//        if (!IsResLoaderFileName(ref fileName))
//        {
//            return false;
//        }

//        // 同时反复调用可能产生多个Timer
//        ResourceRequest request = Resources.LoadAsync(fileName, typeof(T));
//        if (request == null)
//            return false;
//        if (request.isDone)
//        {
//            T orgObj = request.asset as T;
//            if (orgObj == null)
//            {
//                string err = string.Format("LoadObjectAsync: ({0}) error!", fileName);
//                LogMgr.Instance.LogError(err);
//                return false;
//            }

//            AssetCache cache = AddRefCache(orgFileName, orgObj, cacheType, typeof(T));

//#if USE_HAS_EXT
//            AddCacheMap(cache);
//#endif

//            if (onProcess != null)
//                onProcess(request.progress, request.isDone, orgObj);
//            return true;
//        }

//        request.priority = priority;

//        var ret = AsyncOperationMgr.Instance.AddAsyncOperation<ResourceRequest, System.Object>(request,
//                                                      delegate(ResourceRequest req)
//                                                      {
//                                                          if (req.isDone)
//                                                          {
//                                                              T orgObj = req.asset as T;
//                                                              if (orgObj == null)
//                                                              {
//                                                                  string err = string.Format("LoadObjectAsync: ({0}) error!", fileName);
//                                                                  LogMgr.Instance.LogError(err);
//                                                                  return;
//                                                              }

//                                                              AssetCache cache = AddRefCache(orgFileName, orgObj, cacheType, typeof(T));
//#if USE_HAS_EXT
//                AddCacheMap(cache);
//#endif

//                                                              if (onProcess != null)
//                                                                  onProcess(req.progress, req.isDone, orgObj);
//                                                          }
//                                                          else
//                                                          {
//                                                              if (onProcess != null)
//                                                                  onProcess(req.progress, req.isDone, null);
//                                                          }

//                                                      }
//        );

//        return ret != null;
//    }


    public override bool OnSceneLoad(string sceneName) { return false; }
    public override bool OnSceneLoadAsync(string sceneName, Action onEnd, int priority = 0) { return false; }
    public override bool OnSceneClose(string sceneName) { return false; }
    public override Font LoadFont(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadFontAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, Font> onProcess, int priority = 0) { return false; }
    public override GameObject LoadPrefab(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadPrefabAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, GameObject> onProcess, int priority = 0) { return false; }
    public override Material LoadMaterial(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadMaterialAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, Material> onProcess, int priority = 0) { return false; }
    public override Texture LoadTexture(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadTextureAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, Texture> onProcess, int priority = 0) { return false; }
    public override AudioClip LoadAudioClip(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadAudioClipAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, AudioClip> onProcess, int priority = 0) { return false; }
    public override string LoadText(string fileName, ResourceCacheType cacheType) {
        TextAsset text = LoadObject<TextAsset>(fileName, cacheType);
        if (text == null)
            return null;
        return System.Text.Encoding.UTF8.GetString(text.bytes);
    }

    public override byte[] LoadBytes(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadTextAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, TextAsset> onProcess, int priority = 0) { return false; }
    public override RuntimeAnimatorController LoadAniController(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadAniControllerAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, RuntimeAnimatorController> onProcess, int priority = 0) { return false; }
    public override AnimationClip LoadAnimationClip(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadAnimationClipAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, AnimationClip> onProcess, int priority = 0) { return false; }
    public override Shader LoadShader(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadShaderAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, Shader> onProcess, int priority = 0) { return false; }
    public override Sprite[] LoadSprites(string fileName) { return null; }
    public override bool LoadSpritesAsync(string fileName, Action<float, bool, UnityEngine.Object[]> onProcess, int priority = 0) { return false; }
    public override ScriptableObject LoadScriptableObject(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadScriptableObjectAsync(string fileName, ResourceCacheType cacheType, Action<float, bool, UnityEngine.ScriptableObject> onProcess, int priority = 0) { return false; }
    public override ShaderVariantCollection LoadShaderVarCollection(string fileName, ResourceCacheType cacheType) { return null; }
    public override bool LoadShaderVarCollectionAsync(string fileName, ResourceCacheType ResourceCacheType, Action<float, bool, ShaderVariantCollection> onProcess, int priority = 0) { return false; }
}