using UnityEngine;

public class Util
{
    public static T GetorAddComponent<T>(GameObject go) where T : Component
    {
        T component = go.GetComponent<T>();
        if (component == null)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }

    // �θ� ������Ʈ�� ã������ �ڽĿ����� �̸��� �޾Ƽ� �����, �Ǵ� ������� ���� Ž�� �� ���� ������Ʈ�� ��ȯ
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        Transform transform = FindChild<Transform>(go, name, recursive);
        if (transform == null)
            return null;

        return transform.gameObject;
    }

    // �θ� ������Ʈ�� ã������ �ڽĿ�����Ʈ �̸��� �޾Ƽ� �����, �Ǵ� ������� ���� Ž�� �� ã������ ���۳�Ʈ ��ȯ
    public static T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : Object
    {
        // �θ� ������Ʈ�� �� �̸� �� ��ȯ
        if (go == null)
            return null;

        // ��������� ã���� ����
        if (recursive == false) // ���� �ڽĸ� ã�� ���
        {
            // �θ� ��� �ִ� �ڽ� �� ��ŭ �ݺ�
            for (int i = 0; i < go.transform.childCount; i++)
            {
                // 0��° �ڽĺ��� �ϳ��� Ʈ�������� ������
                Transform transform = go.transform.GetChild(i);
                // ������ Ʈ�������� ������� �̸��� ���Ұǵ�
                // �̸��� ��������� ���� ó���� ã�� ���۳�Ʈ�� �ٷ� ��ȯ�� ��, 
                // �̸��� �ִٸ� �ش� �̸��� �����ִ� ������Ʈ�� ���۳�Ʈ�� ��ȯ
                if (string.IsNullOrEmpty(name) || transform.name == name)
                {
                    // 0��° �ڽĺ��� �ڽ��� ���۳�Ʈ�� ������
                    T component = transform.GetComponent<T>();
                    // ���۳�Ʈ�� null �� �ƴϸ� �ش� ���۳�Ʈ ��ȯ
                    if (component != null)
                        return component;
                }
            }
        }
        else // ��������� �ڽ��� �ڽ� ���� ��� ã�� ���
        {
            // �ڽ��� �ڽı��� ������ ���δ� ������ �ϳ��� ��ü �ݺ�
            foreach (T component in go.GetComponentsInChildren<T>())
            {
                // ������ ���۳�Ʈ�� ������� �̸��� ���Ұǵ�
                // �̸��� ��������� ���� ó���� ã�� ���۳�Ʈ�� �ٷ� ��ȯ�� ��, 
                // �̸��� �ִٸ� �ش� �̸��� �����ִ� ������Ʈ�� ���۳�Ʈ�� ��ȯ
                if (string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }
}