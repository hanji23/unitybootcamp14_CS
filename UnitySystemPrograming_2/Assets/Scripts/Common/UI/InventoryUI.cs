using Gpm.Ui;
using TMPro;
using UnityEngine;

public enum InventorySortType
{
    ItemGrade,
    ItemType,
}

public class InventoryUI : BaseUI
{
    public EquippedItemSlot weaponSlot;
    public EquippedItemSlot shieldSlot;
    public EquippedItemSlot chestArmorSlot;
    public EquippedItemSlot bootsSlot;
    public EquippedItemSlot glovesSlot;
    public EquippedItemSlot accessorySlot;

    public InfiniteScroll InventoryScrollList;

    public TextMeshProUGUI SortButtonText;

    private InventorySortType m_inventorySortType;

    public override void SetInfo(BaseUIData uiData)
    {
        base.SetInfo(uiData);

        SetEquippedItems();
        SetInventory();
        SortInventory();
    }

    private void SetEquippedItems()
    {
        UserInventoryData userInventoryData = UserDataManager.Instance.GetUserData<UserInventoryData>();
        if(userInventoryData == null)
        {
            return;
        }

        if(userInventoryData.EquippedWeaponData != null)
        {
            weaponSlot.SetItem(userInventoryData.EquippedWeaponData);
        }
        else
        {
            weaponSlot.ClearItem();
        }

        if (userInventoryData.EquippedShiledData != null)
        {
            shieldSlot.SetItem(userInventoryData.EquippedShiledData);
        }
        else
        {
            shieldSlot.ClearItem();
        }

        if (userInventoryData.EquippedChestArmorData != null)
        {
            chestArmorSlot.SetItem(userInventoryData.EquippedChestArmorData);
        }
        else
        {
            chestArmorSlot.ClearItem();
        }

        if (userInventoryData.EquippedBootsData != null)
        {
            bootsSlot.SetItem(userInventoryData.EquippedBootsData);
        }
        else
        {
            bootsSlot.ClearItem();
        }

        if (userInventoryData.EquippedGlovesData != null)
        {
            glovesSlot.SetItem(userInventoryData.EquippedGlovesData);
        }
        else
        {
            glovesSlot.ClearItem();
        }

        if (userInventoryData.EquippedAccessoryData != null)
        {
            accessorySlot.SetItem(userInventoryData.EquippedAccessoryData);
        }
        else
        {
            accessorySlot.ClearItem();
        }
    }

    private void SetInventory()
    {
        InventoryScrollList.Clear();

        UserInventoryData userInventoryData = UserDataManager.Instance.GetUserData<UserInventoryData>();
        if(userInventoryData != null)
        {
            foreach (var item in userInventoryData.InventoryItemDataList)
            {
                var itemSlotData = new InventoryItemSlotData();
                itemSlotData.SerialNumber = item.SerialNumber;
                itemSlotData.ItemId = item.ItemId;
                InventoryScrollList.InsertData(itemSlotData);
            }
        }
    }

    private void SortInventory()
    {
        switch (m_inventorySortType)
        {
            case InventorySortType.ItemGrade:
                SortButtonText.text = "Grade";

                InventoryScrollList.SortDataList((a, b) =>
                {
                    var itemA = a.data as InventoryItemSlotData;
                    var itemB = b.data as InventoryItemSlotData;

                    int compareResult = ((itemB.ItemId / 1000) % 10).CompareTo((itemA.ItemId / 1000) % 10);

                    if(compareResult == 0)
                    {
                        var itemAIdString = itemA.ItemId.ToString();
                        var itemAComp = itemAIdString.Substring(0, 1) + itemAIdString.Substring(2, 3);

                        var itemBIdString = itemB.ItemId.ToString();
                        var itemBComp = itemBIdString.Substring(0, 1) + itemBIdString.Substring(2, 3);

                        compareResult = itemAComp.CompareTo(itemBComp);
                    }

                    return compareResult;
                });
                break;
            case InventorySortType.ItemType:
                SortButtonText.text = "Type";

                InventoryScrollList.SortDataList((a, b) =>
                {
                    var itemA = a.data as InventoryItemSlotData;
                    var itemB = b.data as InventoryItemSlotData;

                    var itemAIdString = itemA.ItemId.ToString();
                    var itemAComp = itemAIdString.Substring(0, 1) + itemAIdString.Substring(2, 3);

                    var itemBIdString = itemB.ItemId.ToString();
                    var itemBComp = itemBIdString.Substring(0, 1) + itemBIdString.Substring(2, 3);

                    int compareResult = itemAComp.CompareTo(itemBComp);

                    if (compareResult == 0)
                    {
                        compareResult = ((itemB.ItemId / 1000) % 10).CompareTo((itemA.ItemId / 1000) % 10);
                    }

                    return compareResult;
                });
                break;
            default:
                break;
        }
    }

    public void OnClickSortButon()
    {
        switch (m_inventorySortType)
        {
            case InventorySortType.ItemGrade:
                m_inventorySortType = InventorySortType.ItemType;
                break;
            case InventorySortType.ItemType:
                m_inventorySortType= InventorySortType.ItemGrade;
                break;
            default:
                break;
        }
        SortInventory();
    }
}
