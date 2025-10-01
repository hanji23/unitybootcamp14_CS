using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentUIData : BaseUIData
{
    public bool IsEquipped = false;
    public long SerialNumber;
    public int ItemId;
}

public class EquipmentUI : BaseUI
{
    public Image _itemGradeBg;
    public Image _itemIcon;
    public TextMeshProUGUI _itemGradeText;
    public TextMeshProUGUI _itemIconText;
    public TextMeshProUGUI _attackPowerAmountText;
    public TextMeshProUGUI _defenseAmountText;

    private EquipmentUIData m_equipmentUIData;

    public override void SetInfo(BaseUIData uiData)
    {
        base.SetInfo(uiData);

        m_equipmentUIData = uiData as EquipmentUIData;
        if (m_equipmentUIData == null)
        {
            Logger.LogError("m_equipmentUIData == null");
            return;
        }

        ItemData itemData = DataTableManager.Instance.GetItemData(m_equipmentUIData.ItemId);
        if (itemData == null) 
        {
            Logger.LogError("itemData == null");
            return;
        }

        ItemGrade itemGrade = (ItemGrade)((m_equipmentUIData.ItemId / 1000) % 10);
        Texture2D gradeBgTexture = Resources.Load<Texture2D>($"Texture/{itemGrade}");
        if (gradeBgTexture != null) 
        {
            _itemGradeBg.sprite = Sprite.Create(gradeBgTexture, new Rect(0, 0, gradeBgTexture.width, gradeBgTexture.height), new Vector2(1f, 1f));
        }

        _itemGradeText.text = itemGrade.ToString();
        string hexColor = string.Empty;
        switch (itemGrade)
        {
            case ItemGrade.Common:
                hexColor = "#1AB3FF";
                break;
            case ItemGrade.Uncommon:
                hexColor = "#51C52C";
                break;
            case ItemGrade.Rare:
                hexColor = "#EA5AFF";
                break;
            case ItemGrade.Epic:
                hexColor = "#FF9900";
                break;
            case ItemGrade.Legendary:
                hexColor = "#F24949";
                break;
        }
        Color color;
        if (ColorUtility.TryParseHtmlString(hexColor, out color)) 
        {
            _itemGradeText.color = color;
        }

        StringBuilder sb = new StringBuilder(m_equipmentUIData.ItemId.ToString());

        sb[1] = '1';
        var itemIconName = sb.ToString();

        Texture2D itemIconTexture = Resources.Load<Texture2D>($"Textures/{itemIconName}");
        if (itemIconTexture != null)
        {
            _itemIcon.sprite = Sprite.Create(itemIconTexture, new Rect(0, 0, itemIconTexture.width, itemIconTexture.height), new Vector2(1f, 1f));
        }

        _itemIconText.text = itemData.ItemName;
        _attackPowerAmountText.text = $"+{itemData.AttackPower}";
        _defenseAmountText.text = $"+{itemData.Defense}";
    }

}
