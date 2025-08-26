
namespace _5_Lambda_func
{
    //lambda = 일회용 함수 만드는 방법

    class Item
    {
        public enum ItemType
        {
            Weapon,
            Armor,
            Amulet,
            Ring
        }

        public enum Rairry
        {
            Normal,
            Uncommon,
            Rare,
        }

        public ItemType itemtype;
        public Rairry rairry;
    }

    
        
    internal class Program
    {
        delegate void on();

        //반환값이 없는 미리 만들어둔 델리게이트
        Action action;
        // ㄴ delegate void Action();

        //반환값이 있는 미리 만들어둔 델리게이트 (마지막 T가 반환값) func<(매개값), 반환값)>
        Func<int, int> func;
        // ㄴ delegate int func(int);

        public static List<Item> _items = new List<Item>();

        //func도 외부에서 접근가능 이를 방지하고 싶으면 event 사용

        static Item FindWeapon()
        {
            foreach (Item item in _items)
            {
                if (item.itemtype == Item.ItemType.Weapon)
                    return item;
            }
            return null;
        }

        delegate bool ItemSelector(Item item);

        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        //static bool isWeapon()
        //{

        //}

        //여기서 "=>" 식본문 멤버
        //public void Test() => Console.WriteLine("!");

        //여기서 "=>" 람다연산자, 람다 오퍼레이터
        //FindItem((Item item) => item.itemtype == Item.ItemType.Weapon );

        static void Main(string[] args)
        {
            _items.Add(new Item() { itemtype = Item.ItemType.Weapon, rairry = Item.Rairry.Normal });
            _items.Add(new Item() { itemtype = Item.ItemType.Armor, rairry = Item.Rairry.Uncommon });
            _items.Add(new Item() { itemtype = Item.ItemType.Ring, rairry = Item.Rairry.Rare });

            //따로 함수를 만들지 않고 그자리에서 함수를 만들어 사용
            Item weapon = FindItem(delegate (Item item) { return item.itemtype == Item.ItemType.Weapon; });
            Item ammor = FindItem(delegate (Item item) { return item.itemtype == Item.ItemType.Armor; });
            Item ring = FindItem(delegate (Item item) { return item.itemtype == Item.ItemType.Ring; });

            FindItem((Item item) => item.itemtype == Item.ItemType.Weapon );
        }
    }
}
