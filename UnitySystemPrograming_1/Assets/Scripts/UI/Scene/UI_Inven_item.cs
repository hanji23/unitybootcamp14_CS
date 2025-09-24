using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI_Inven_item : UI_Base
{
    enum GameObjects
    {
        ItemIcon,
        ItemNameText
    }

    enum Texts
    {
        ItemNameText
    }

    enum Images
    {
        ItemIcon
    }
    string _name;

    private void Start()
    {
        Init();
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));

        GetGameObject((int)GameObjects.ItemNameText).GetComponent<Text>().text = _name;
        //GetGameObject((int)GameObjects.ItemIcon).GetComponent<Image>().sprite = 사용할 이미지;

        GetGameObject((int)GameObjects.ItemIcon).BindEvent((PointerEventData data) => { Debug.Log($"{_name}"); });
    }

    public void SetInfo(string name)
    {
        _name = name;
    }
}
