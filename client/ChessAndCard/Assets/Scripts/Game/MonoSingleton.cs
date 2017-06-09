using UnityEngine;
using System.Collections;

namespace hero
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T _instance = null;

        public static T Instance
        {
            get
            {
                if (null == _instance)
                {
                    return null;
                }
                return _instance;
            }
        }

        bool _isDuplicated = false;
        void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("Duplicate instance of singleton:" + typeof(T));
                _isDuplicated = true;
                Destroy(this);
                return;
            }
            _instance = this as T;
            OnAwake();
        }

        void OnEnable()
        {
            OnRegist();
        }

        void OnDisable()
        {
            OnUnRegist();
        }

        protected virtual void OnRegist() { }

        protected virtual void OnUnRegist() { }

        protected virtual void OnAwake() { }

        protected virtual void OnDestroy()
        {
            if (_isDuplicated) return;
            _instance = null;
        }
    }
}