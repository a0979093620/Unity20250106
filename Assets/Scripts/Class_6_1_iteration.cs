using UnityEngine;

namespace Lotta_3
{
    /// <summary>
    /// 反覆運算陳述式 : 迴圈
    /// for、foreach、do 與while
    /// </summary>
    public class Class_6_1_iteration : MonoBehaviour
    {
        private void Awake()
        {
            // 迴圈請在一次性事件內使用 Awake 、 Start 
            // While 迴圈 : 當布林值為 true 時會持續執行
            // While  ( 布林值 ) { 程式區塊 } 
            // 無限迴圈 : 布林值一直是 true

            // 宣告變數 i 為 0
            int i = 0;

            // 測試 While 、 do 迴圈差異
            // i = 5;

            // 當 i < 5 就執行{}
            while (i < 5)
            {
                Debug.Log($"<color=#f33>While 迴圈 : {i}</color>");

                // i 遞增 (i + 1)
                i++;
            }

            // do 迴圈
            // do { 程式區塊 } While ( 布林值 )

            int j = 0;

            // 測試 While 、 do 迴圈差異
            // j = 5;

            do
            {
                Debug.Log($"<color=#f79>do 迴圈，j = {j}</color>");
                j++;
            }
            while (j < 5);

            // for 迴圈 :
            // for ( 初始值 ; 布林值 ; 迭代器 ) { 程式區塊 }
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=#78f>For 迴圈，k :{k}</color>");
            }

        }
    }
}
