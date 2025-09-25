using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T>//싱글톤들의 베이스 클래스
{
    protected bool m_IsDestroyOnLoad = false; // DestroyOnLoad 여부

    protected static T m_Instance;

    public static T Instance
    {
        get { return m_Instance; }
    }

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        if (m_Instance == null)
        {
            m_Instance = (T)this;
            if (!m_IsDestroyOnLoad) 
            {
                DontDestroyOnLoad(this);
            }
        }
        else
        {
            Destroy(gameObject);
        }
           
    }

    protected virtual void OnDestroy()
    {
        Dispose();
    }
    
    protected virtual void Dispose()
    {
        m_Instance = null;
    }
}



