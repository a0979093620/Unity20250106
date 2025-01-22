using UnityEngine;

namespace Lotta_4
{
    /// <summary>
    /// 陣列
    /// </summary>

    public class Class_6_2_Array : MonoBehaviour
    {
        // 不使用陣列的寫法
        // 皮卡丘、小火龍、  卡比獸
        public string card_1 = "皮卡丘", card_2 = "小火龍", card_3 = "卡比獸";

        // 陣列 : 用來處存多筆相同類型的資料
        // 第一種 : 不指定值，透過 Unity 面板輸入
        // 修飾詞 資料類型 [] 陣列名稱 ;
        public string[] cards;

        //  第二種 : 直接定義陣列的數量
        // 定義一個牌組1，可以放5張牌
        public string[] deck_1 = new string[5];

        //第三種 : 直接定義陣列的值
        public string[] deck_2 = { "急凍鳥", "可達鴨", "寶石海星" };

        // 二維陣列
        public string[,] inventory = { {"紅色藥水","藍色藥水"}, {"炸彈","金幣"} };

        private void Start()
        {
            #region 一維陣列
            // 存取陣列 Set、Get
            // Get 取得陣列的資訊
            // 陣列名稱[ 編號 ]
            Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[2]}");

            // 超出陣列範圍會出錯
            // 錯誤會導致閃退、當機或者不會執行下方程式
            // Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[2]}");

            // Set 設定陣列的資訊
            // 陣列名稱 [ 編號 ] 指定 值;
            // 將寶石海星換成傑尼龜
            deck_2[2] = "傑尼龜";
            Debug.Log($"<color=#f32>deck_2 的第三張卡片 : {deck_2[2]}");
            #endregion

            // 存放二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具 :{inventory[0, 1]}</color>");

            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具 :{inventory[1, 1]}</color>");


        }
    }

    
}