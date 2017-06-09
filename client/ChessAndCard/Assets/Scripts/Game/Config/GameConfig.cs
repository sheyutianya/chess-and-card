
using ConfigDate;
using Core.CSV;
public class GameConfig : Singleton<GameConfig> {

    bool m_isInit = false;

    public void Init() 
    {
        if (m_isInit) return;
        m_isInit = true;

        CSVManager.Instance.Register<Hero>(ResourceManager.Instance.LoadText("resources/Config/csv/Hero", ResourceCacheType.rctNone));
    }
}
