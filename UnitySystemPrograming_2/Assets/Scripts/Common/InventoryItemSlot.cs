using Gpm.Ui;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
public class InventoryItemSlotData : InfiniteScrollData
{
    public long SerialNumber;
    public int ItemId;
}
public class InventoryItemSlot : InfiniteScrollItem
{
    public Image _itemGradeBg;
    public Image _itemIcon;

    private InventoryItemSlotData m_inventoryItemSlotData;

    public override void UpdateData(InfiniteScrollData scrollData)
    {
        base.UpdateData(scrollData);

        m_inventoryItemSlotData = scrollData as InventoryItemSlotData;
        if(m_inventoryItemSlotData == null)
        {
            Logger.LogError("m_inventoryItemSlotData is invalid");
        }

        ItemGrade itemGrade = (ItemGrade)((m_inventoryItemSlotData.ItemId / 1000) % 10);
        Texture2D gradeBgTexture = Resources.Load<Texture2D>($"Textures/{itemGrade}");
        if (gradeBgTexture != null) 
        {
            _itemGradeBg.sprite = Sprite.Create(gradeBgTexture, new Rect(0, 0, gradeBgTexture.width, gradeBgTexture.height), new Vector2(1f, 1f));
        }

        StringBuilder sb = new StringBuilder(m_inventoryItemSlotData.ItemId.ToString());

        sb[1] = '1';
        var itemIconName = sb.ToString();

        Texture2D itemIconTexture =  Resources.Load<Texture2D>($"Textures/{itemIconName}");
        if (itemIconTexture != null)
        {
            _itemIcon.sprite = Sprite.Create(itemIconTexture, new Rect(0, 0, itemIconTexture.width, itemIconTexture.height), new Vector2(1f, 1f));
        }
    }

    public void OnClickInventoryItemSlot()
    {
        EquipmentUIData uiData = new EquipmentUIData();
        uiData.SerialNumber = m_inventoryItemSlotData.SerialNumber;
        uiData.ItemId = m_inventoryItemSlotData.ItemId;

        UIManager.Instance.OpenUI<EquipmentUI>(uiData);
    }
}
