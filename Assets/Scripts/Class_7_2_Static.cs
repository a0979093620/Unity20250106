using UnityEngine;
namespace lotta_7
{ 
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        // 非靜態變數
        public int inventorWater = 10;

        // 靜態變數 : 修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上
        public static int inventorProp = 20;

        private void Awake()
        {
            inventorWater = 7;
            inventorProp = 15;
            Debug.Log($"<color=#f31>藥水 : {inventorWater}</color>");
            Debug.Log($"<color=#f31>道具 : {inventorProp}</color>");

        }
    }

}
