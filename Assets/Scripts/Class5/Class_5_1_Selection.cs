using UnityEngine;

//命名空間 : 
//將類別分類，類似倉庫的概念，不同倉庫可以有相同名稱類別
//語法 : namespace 命名空間名稱 { 內容 }
namespace Lotta
{
    /// <summary>
    /// 選取陳述式 Selection statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapen;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int blood;

        private void Awake()
        {
            // if 判斷式
            // if ( 布林值 ) { 陳述式 }
            if (true)
            {
                Debug.Log("當布林值為 True ，會執行這裡。");
            }

            //快速完成 : 輸入 if 選取 if 陳述式案 Enter 或 Tab
            if (false)
            {
                Debug.Log("當布林值為 False ， 不會執行這裡會有綠蚯蚓");
            }
        }

        //更新事件 :  一秒鐘直行約 60 次 ( 60 fps) Frame Per Second
        private void Update()
        {
            // 常用快捷鍵
            // 1. 格式化(排版) Ctrl + K + D
            // 2. 程式碼片段 Ctrl + K + S
            #region 判斷式 IF
            Debug.Log("<color=#79f>更新事件</color>");

            // 如果已經開門，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }

            // 否則，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }

            // 比較運算子、邏輯運算子結果為布林值
            // if 會在最上方、else 在最下方，中間可以有多個 else if
            // 如果 分數 >= 60 就通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的 C# 課程過了</color>");
            }
            // 否則 如果 分數 >= 40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>你可以補考</color>");
            }
            // 否則 如果 分數 >= 20 可以補考並做一個小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>可以補考但要做一個 C# 小專題</color>");
            }
            // 否則 當掉
            else
            {
                Debug.Log("<color=#f33>你的 C# 課程被當了</color>");
            }
            #endregion

            #region Switch判斷式
            // switch 判斷式
            // switch (要判斷的值) { 陳述句 }
            // 快速完成 : switch + (Tab * 2)
            switch (weapen)
            {
                // case 值 :
                // 當判斷的值 等於值時 會執行這裡
                // break ; 跳出判斷式
                // 如果武器等於小刀，攻擊力等於 20
                case "蝴蝶刀":
                //不加 break 會一直向下執行 直到碰到 break
                case "小刀":
                    Debug.Log("<Color=#ff3>攻擊力 : 20</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<Color=#ff3>攻擊力 : 999</color>");
                    break;
                case "玩具刀":
                    Debug.Log("<Color=#ff3>攻擊力 : 10</color>");
                    break;

                // 當 weapen 不等於上述的值
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break;

            }
            #endregion

            #region 課堂練習
            // 錯誤寫法 判斷式只會執行一次陳述式
            if (blood >= 10)
            {
                Debug.Log("<color=red>快死掉了</color>");
            }
            else if (blood >= 40)
            {
                Debug.Log("<color=red>快喝水</color>");
            }
            else if (blood >= 60)
            {
                Debug.Log("<color=red>健康狀態有狀況</color>");
            }
            else if (blood >= 80)
            {
                Debug.Log("<color=red>血量安全</color>");
            }
            else if (blood == 0)
            {
                Debug.Log("<color=red>你已經死了</color>");
            }
            // 正確寫法1 順序
            if (blood >= 80)
            {
                Debug.Log("<color=red>血量安全</color>");
            }
            else if (blood >= 60)
            {
                Debug.Log("<color=red>健康狀態有狀況</color>");
            }
            else if (blood >= 40)
            {
                Debug.Log("<color=red>快喝水</color>");
            }
            else if (blood >= 10)
            {
                Debug.Log("<color=red>快死掉了</color>");
            }
            else if (blood == 0)
            {
                Debug.Log("<color=red>你已經死了</color>");
            }

            //寫法2 搭配邏輯運算子
            if (blood >= 10 && blood < 40)
            {
                Debug.Log("<color=red>快死掉了</color>");
            }
            else if (blood >= 40 && blood < 60)
            {
                Debug.Log("<color=red>快喝水</color>");
            }
            else if (blood >= 60 && blood < 80)
            {
                Debug.Log("<color=red>健康狀態有狀況</color>");
            }
            else if (blood >= 80)
            {
                Debug.Log("<color=red>血量安全</color>");
            }
            else if (blood == 0)
            {
                Debug.Log("<color=red>你已經死了</color>");
            } 
            #endregion


        }
    }

}
