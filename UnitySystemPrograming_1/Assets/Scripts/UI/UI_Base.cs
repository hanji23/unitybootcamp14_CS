using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class UI_Base : MonoBehaviour
{
    // �� �ڽĵ��� ���� �ִ� ���۳�Ʈ���� ������ ���� (Ÿ�Ժ��� ��Ƴ���)
    Dictionary<Type, UnityEngine.Object[]> _objects = new Dictionary<Type, UnityEngine.Object[]>();

    public abstract void Init();

    // ���� �������� ��������� �� ���ĺ��� ���۳�Ʈ���� ���
    protected void Bind<T>(Type type) where T : UnityEngine.Object // ����Ƽ ������Ʈ�� ��� �� �� ����
    {
        // Ÿ������ �Ѱܹ��� �̳��� �̸����� ����
        string[] names = Enum.GetNames(type);

        // �ش� Ÿ���� �̸� ���� ��ŭ �迭 ����
        UnityEngine.Object[] objects = new UnityEngine.Object[names.Length];
        // ��ųʸ��� Ÿ���� Ű�� ����, �׸��� ���� ��迭�� �ϴ� �־��ֱ�
        _objects.Add(typeof(T), objects);

        for (int i = 0; i < names.Length; i++)
        {
            // ��迭�� ���ؼ� �ϳ��� ���۳�Ʈ���� ã�Ƽ� �־��ֱ�
            if (typeof(T) == typeof(GameObject))
                objects[i] = Util.FindChild(gameObject, names[i], true);
            else
                objects[i] = Util.FindChild<T>(gameObject, names[i], true);

            if (objects[i] == null)
                Debug.Log($"failed to bind({names[i]})!!!");
        }
    }

    // ���۳�Ʈ�� ������ �������� ���۳�Ʈ ������ ����
    protected T Get<T>(int index) where T : UnityEngine.Object
    {
        // ������Ʈ�� �޾ƿ� �� �迭 �����
        UnityEngine.Object[] objects = null;
        // �ش��ϴ� Ÿ���� Ű������ �ؼ� ����������� �迭 ��������
        if (_objects.TryGetValue(typeof(T), out objects) == false)
            return null;

        // �迭�� ���������� �ű⼭ �ε����� �����ؼ� �¸� ��ȯ���ֱ�
        return objects[index] as T;
    }

    protected Text GetText(int index) => Get<Text>(index);
    protected Button GetButton(int index) => Get<Button>(index);
    protected Image GetImage(int index) => Get<Image>(index);
    protected GameObject GetGameObject(int index) => Get<GameObject>(index);

    public static void BindEvent(GameObject go, Action<PointerEventData> action, Define.UIEvent type = Define.UIEvent.Click)
    {
        UI_EventHandler evt = Util.GetorAddComponent<UI_EventHandler>(go);

        switch (type)
        {
            case Define.UIEvent.Click:
                evt.OnClickHandler += action;
                break;
            case Define.UIEvent.Drag:
                evt.OnDragHandler += action;
                break;
        }
    }
}