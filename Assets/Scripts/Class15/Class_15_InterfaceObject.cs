using lotta.tools;
using UnityEngine;

namespace lotta_15
{
    public class Class_15_InterfaceObject : MonoBehaviour
    {

    }

    // 介面的使用步驟
    // 1. 定義介面與介面成員
    // 2. 類別十座舊面
    // 3. 實作介面的成員
    // 備註 : 介面名稱的開頭使用 英文字母 I 來開頭

    // 步驟 1.
    // 帶有「使用」功能的介面，遊戲腦可使用的物品
    public interface IUse
    {
        // 抽象方法，不用大括號
        public void Use();
    }

    public interface IDestory
    {
        public void Destory();
    }

    // 步驟 2.
    // C# 單一繼承，多重實作介面
    public class Weapon : IUse
    {
        // 步驟 3. 
        public void Use()
        {
            LogSystem.LogWithColor("使用武器，施放武器技能", "#fa3");
        }
    }

    public class Potion : IUse, IDestory 
    {
        public void Destory()
        {
            LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");
        }

        // 步驟 3. 
        public void Use()
        {
            LogSystem.LogWithColor("使用藥水，恢復魔力", "#a3f");
        }
    }

    public class Chest : IUse, IDestory
    {
        public void Destory()
        {
            LogSystem.LogWithColor("寶箱使用完畢，刪除", "##11");            
        }

        // 步驟 3. 
        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，隨機獲取道具", "#af3");
        }
    }


}

