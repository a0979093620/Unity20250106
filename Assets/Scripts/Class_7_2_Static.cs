using UnityEngine;
using UnityEngine.SceneManagement;      //切換場景要加得
namespace lotta_7
{ 
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        // 成員 : 
        // 變數、屬性、方法

        // 非靜態變數
        public int inventorWater = 10;

        // 靜態變數 : 修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上
        public static int inventorProp = 20;

        // 非靜態屬性
        public string skillMain => "火球術";

        // 靜態屬性
        public static string skillSecond => "治癒術";

        private void Awake()
        {
            //inventorWater = 7;
            //inventorProp = 15;
            Debug.Log($"<color=#f31>藥水 : {inventorWater}</color>");
            Debug.Log($"<color=#f31>道具 : {inventorProp}</color>");

        }

        // 非靜態方法
        public void Punch()
        {
            Debug.Log("<color=#3f3>使用拳擊</color>");
        }

        // 靜態方法
        public static void Kick()
        {
            Debug.Log("<color=#3f3>使用踢擊</color>");
        }

        private void Start()
        {
            /// 在 Unity 內的差異
            /// 場景切換時
            /// 非靜態成員會被釋放 (還原維預設值)
            inventorWater++;    // 藥水加一
            Debug.Log($"<color=#78f>藥水 : {inventorWater}</color>");

            /// 非靜態成員會被釋放 (還原維預設值)
            inventorProp++;     // 道具加一
            Debug.Log($"<color=#78f>道具 : {inventorProp}</color>");

        }

        private void Update()
        {
            // 在 Game 畫面按下數字 1 會重新載入場景 (切為英文輸入法)
            // 如果按下數字 1 (左邊鍵盤)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }

}
