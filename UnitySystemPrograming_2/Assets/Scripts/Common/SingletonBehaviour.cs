using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T>//�̱������ ���̽� Ŭ����
{
    protected bool m_IsDestroyOnLoad = false; // DestroyOnLoad ����

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



