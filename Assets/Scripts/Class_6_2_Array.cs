using UnityEngine;

namespace Lotta_4
{
    /// <summary>
    /// 陣列
    /// </summary>

    public class Class_6_2_Array : MonoBehaviour
    {
        #region 一到三維陣列認識
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
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };

        // 三維陣列
        public string[,,] shop =
        {
            // 第一頁
            {{"小刀","美工刀"},{"武士刀","屠龍刀"}} ,
            // 第二頁
            {{"精靈球","高級球"},{"大師球","巢穴球"}}
        };
        #endregion

        #region 不規則陣列
        //不規則陣列     形容詞 資料類型[][] = new 資料類型[][]
        private int[][] numbers = new int[2][];

        //不規則陣列_多維內容
        private int[][,] count = new int[2][,];
        #endregion

        private void Start()
        {
            #region 一維陣列
            // 存取陣列 Set、Get
            // Get 取得陣列的資訊
            // 陣列名稱[ 編號 ]
            Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[2]}");

            // 超出陣列範圍會出錯
            // 錯誤會導致閃退、當機或者不會執行下方程式
            // Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[3]}");

            // Set 設定陣列的資訊
            // 陣列名稱 [ 編號 ] 指定 值;
            // 將寶石海星換成傑尼龜
            deck_2[2] = "傑尼龜";
            Debug.Log($"<color=#f32>deck_2 的第三張卡片 : {deck_2[2]}");
            #endregion

            #region 二維陣列
            // 存放二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具 :{inventory[0, 1]}</color>");

            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具 :{inventory[1, 1]}</color>");

            #endregion

            #region 三維陣列
            // 存放三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#3fd>第一頁第二排第二個 : {shop[0, 1, 1]}</color>");

            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#3fd>第二頁第一排第二個 : {shop[1, 0, 1]}</color>");
            #endregion

            #region 取得長度和維度
            // 獲得陣列的長度或維度

            // 一維 ~ 多維 陣列的長度 : 陣列名稱 . Length
            Debug.Log($"<color=#f93>一維，排組 2 的長度 : {deck_2.Length}</color>");
            Debug.Log($"<color=#f93>二維，道具 的長度 : {inventory.Length}</color>");
            Debug.Log($"<color=#f93>三維，商品 的長度 : {shop.Length}</color>");

            // 陣列的維度 : 陣列名稱 . Rank
            Debug.Log($"<color=#f93>一維，排組 2 的維度 : {deck_2.Rank}</color>");
            Debug.Log($"<color=#f93>二維，道具 的維度 : {inventory.Rank}</color>");
            Debug.Log($"<color=#f93>三維，商品 的維度 : {shop.Rank}</color>");

            #endregion

            #region 不規則陣列
            // 不規則陣列基本練習
            // 設定不規則陣列 的值 (Unity 不支援最新寫法)
            numbers[0] = new int[] { 1, 2, 3, };
            numbers[1] = new int[] { 9, 8, 7, 6, 5, 4 };

            // 取的數字3、9
            Debug.Log($"<color=#3ff>3 : {numbers[0][2]}</color>");
            Debug.Log($"<color=#3ff>9 : {numbers[1][0]}</color>");

            // 將 8 改成 6
            numbers[1][1] = 6;
            Debug.Log($"<color=#3ff>第二排的第二個 : {numbers[1][1]}</color>");

            // 不規則陣列 : 包含多維陣列
            // 設定內容
            count[0] = new int[,] { { 1, 2} , { 3, 4 } };
            count[1] = new int[,] { { 5, 6, 7} , { 8, 9, 10 } };

            //取得第二列的[0, 0]
            Debug.Log($"<color=#3ff>第二列的[0, 0] :{count[1][0, 0]}</color>");

            #endregion
        }
    }


}