using UnityEngine;

public class PoolManager
{
    Transform _root;

    void Init()
    {
        if (_root == null)
        {
            _root = new GameObject { name = "@Pool" }.transform;
            Object.DontDestroyOnLoad(_root);
        }
    }
    
    public void Push(Poolable poolable)
    {

    }

    public Poolable Pop(GameObject original, Transform parent = null)
    {
        return null;
    }

    public GameObject GetOtiginal(string name)
    {
        return null;
    }
}
