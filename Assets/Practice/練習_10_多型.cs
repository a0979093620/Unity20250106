using lotta.tools;
using UnityEngine;
namespace lotta_10
{
    public class 練習_10_多型 : MonoBehaviour
    {
        private void Awake()
        {
            Water red = new Water("紅水");
            Water blue = new Water("藍水");
            Equipage equipage = new Equipage("頭盔");
            
            red.Use();
            blue.Use(10);
            equipage.Use();
        }

    }

    public class Item
    {
        protected string itemname;
        public Item(string _itemname)
        {
            itemname = _itemname;
        }
        public virtual void Use()
        {
            LogSystem.LogWithColor($"道具名稱 : {itemname}", "yellow");
        }
    }

    public class Water : Item
    {
        public Water(string _itemname) : base(_itemname)
        {
        }
        public void Use(int _monna)
        {
            LogSystem.LogWithColor($"道具名稱 : {itemname}，魔力消耗 : {_monna}", "yellow");
            
        }
    }

    public class Equipage : Item
    {
        public Equipage(string _itemname) : base(_itemname)
        {
        }
        public override void Use()
        {
            LogSystem.LogWithColor($"裝備名稱 : {itemname}", "green");
        }
    }
}

