using UnityEngine;

public class UI_Inven : UI_Scene
{
    enum GameObjects
    {
        GridPanel,

    }

    public override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        GameObject gridPanel = GetGameObject((int)GameObjects.GridPanel);
        foreach (Transform child in gridPanel.transform)
            Managers.Resource.Destroy(child.gameObject);

        for (int i = 0; i < 8; i++)
        {
            GameObject item = Managers.UI.MakeSubItem<UI_Inven_item>(gridPanel.transform).gameObject;

            //UI_Inven_item invenItem = Util.GetorAddComponent<UI_Inven_item>(item);
            UI_Inven_item invenItem = item.GetorAddComponent<UI_Inven_item>();
            invenItem.SetInfo($"»ç°ú{i}¹ø");
        }
    }

    void Start()
    {
       Init();
    }

    void Update()
    {
        
    }
}
