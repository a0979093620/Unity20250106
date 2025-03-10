using lotta.tools;
using UnityEngine;

namespace lotta_15
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object invertoryfirst;
        public object invertorysecond;

        private void Awake()
        {
            int random = Random.Range(0, 3);    // 隨機 0~3 (不會出現 3 )
            LogSystem.LogWithColor($"隨機 {random}", "#f33");

            #region 按下數字鍵 1
            if (random == 0)
            {
                invertoryfirst = new Prop();
            }
            else if (random == 1)
            {
                invertoryfirst = new Equipment();
            }
            else if (random == 2)
            {
                invertoryfirst = new Map();
            }
            #endregion

            #region 有介面
            int randomsecond = Random.Range(0, 3);    // 隨機 0~3 (不會出現 3 )
            if (randomsecond == 0)
            {
                invertorysecond = new Weapon();
            }
            else if (randomsecond == 1)
            {
                invertorysecond = new Potion();
            }
            else if (randomsecond == 2)
            {
                invertorysecond = new Chest();
            }
            #endregion
        }

        private void Update()
        {
            // 按下左邊數字鍵 1 可以使用第一個物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // 第一格是道具，就使用道具
                if(invertoryfirst is Prop)
                {
                    ((Prop)invertoryfirst).Use();
                }
                // 第一格是裝備，就使用裝備
                if(invertoryfirst is Equipment)
                {
                    ((Equipment)invertoryfirst).Use();
                }
                // 第一格是地圖，就使用地圖
                if(invertoryfirst is Map)
                {
                    ((Map)invertoryfirst).Use();
                }

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                // 如果第二格道具有實作介面，就使用
                if (invertorysecond is IUse)
                {
                    ((IUse)invertorysecond).Use();
                }

                if(invertorysecond is IDestory)
                {
                    ((IDestory)invertorysecond).Destory();             
                }
                // 如果擴充物品，判斷式不用增加，只需要讓物品實作介面就好
            }




        }

    }

    public class Prop
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用道具，恢復血量", "#f96");
        }
    }

    public class Equipment
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，裝到對應位置", "#9f6");
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#96f");
        }
    }
}
