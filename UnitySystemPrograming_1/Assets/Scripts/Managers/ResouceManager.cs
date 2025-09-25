using UnityEngine;

public class ResouceManager
{
    public T Load<T>(string path) where T : Object
    {
        if(typeof(T) == typeof(GameObject))//프리펩을 로드할려는 확률이 높음
        {
            string name = path;
            int index = name.LastIndexOf('/');
            if(index >= 0)
                name = name.Substring(index + 1);

            GameObject go = Managers.Pool.GetOtiginal(name);
            if (go != null)
                return go as T;
        }
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject original = Load<GameObject>($"Prefabs/{path}");
        if (original == null)
            Debug.LogError($"{path} 프리펩 없어!");

        if (original.GetComponent<Poolable>() != null)
            return Managers.Pool.Pop(original, parent).gameObject;

        GameObject go = Object.Instantiate(original, parent);
        //int index = go.name.IndexOf("(Clone)");
        //if(index > 0)
        //    go.name = go.name.Substring(0, index);
        go.name = original.name;

        return go;
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
            return;

        Poolable poolable = go.GetComponent<Poolable>();
        if (poolable != null)
        {
            Managers.Pool.Push(poolable);
            return;
        }
        Object.Destroy(go);
    }
}
