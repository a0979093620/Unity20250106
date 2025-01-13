using System.Security;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 課程 3 : 運算子
/// 補充 : Unity 欄位屬性 Unity 事件
/// </summary>
public class Clas_3_Clas_3_Operater : MonoBehaviour
{
    #region  基本的欄位應用
    // C# 變數 = 欄位 Field
    // 欄位屬性 Field Attritube

    // [標題(提示文字)]   : 在屬性面版上顯示提示文字
    [Header("等級")]
    public int lv = 1;

    // [提示(題示文字)]   : 在屬性面板上滑鼠停留在變數上時顯示
    [Tooltip("這是腳色移動速度，不見溢超過100。")]
    public float MoveSpeed = 2.5f;

    // [範圍(最小,最大)]    : 幫數值類型添加範圍(面板上改為滑桿)
    [Range(1,100)]
    public byte count = 10;
    // 範圍不能使用在非數值類型上，會顯示"Use Range With float or int"
    [Range(0, 20)]
    public string weapon = "匕首";

    // [文字範圍(最小行,最大行)]   : 使用在字串上，設定文字框的範圍
    [TextArea(2, 5)]
    public string ItemDescription = "這裡是道具的描述";

    //多個欄位屬性
    [Header("血量")]
    [Range(0, 999)]     //寫法1
    public int hp = 100;

    [Header("攻擊力"), Range(0, 100)]   //寫法2
    public float attack = 30.5f;

    // [在屬性面板上隱藏]   : 將公開變數穩藏
    [HideInInspector]
    public string password = "我是密碼";

    // [序列化欄位]    : 將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    /*使用 Unity 的事件
     * 1. 必須在腳本後面添加  : MonoBehaviour(繼承)
     * 2. 使用關鍵字快速完成，例如 : 輸入Awake 挑選要用的是事件 Enter
     * 喚醒事件 : 撥放遊戲後會執行的第一個事件，只執行一次
     * 事件名稱是藍色的(沒有變色不影響) */
    private void Awake()
    {
        #region 輸出訊息
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Ctrl +LeftShiftHandler +Cache 開啟控制台面板
        Debug.Log("哈囉，沃德 :D");          // 輸出文字
        Debug.Log(hp);                       // 輸出變數的值
        Debug.Log("攻擊力 : " + attack);     // 字串與變數
        Debug.Log($"攻擊力 : {attack}");     // $字串格式
        Debug.Log("攻擊力 : {attack}");      // 沒有寫$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");

        // 色碼 : #紅紅綠綠藍藍，數值0~9，a~f 越右邊顏色越亮 #000 黑 #fff 白
        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>");
        #endregion

        #region 算數運算子
        /* 運算子
         * 1. 算術運算子
         * 加、減、乘、除、餘
         * +   -    *   /   % 
         */
        Debug.Log("<color=#f93>---算數運算子---</color>");
        Debug.Log(10 + 3);      // 13
        Debug.Log(10 - 3);      // 7
        Debug.Log(10 * 3);      // 30
        Debug.Log(10 / 3);      // 3
        Debug.Log(10 % 3);      // 10 / 3 = 3 餘 1，結果為 1

        Debug.Log("<color=#f93>---算數運算子---</color>");
        // 區域變數 : 僅在此區域存取(不需要修飾詞的變數)
        float number1 = 10;
        float number2 = 3;

        Debug.Log(number1 + number2);
        Debug.Log(number1 - number2);
        Debug.Log(number1 * number2);
        Debug.Log(number1 / number2);       // 3.333
        Debug.Log(number1 % number2);
        #endregion

        #region 比較運算子
        Debug.Log("<color=#f93>---比較運算子---</color>");
        //比較運算子，使用後會得到布林值
        int number3 = 100, number4 = 1;

        Debug.Log(number3 > number4);        //大於     True
        Debug.Log(number3 < number4);        //小於     False
        Debug.Log(number3 >= number4);       //大於等於 True
        Debug.Log(number3 <= number4);       //小於等於 False
        Debug.Log(number3 == number4);       //等於     False
        Debug.Log(number3 != number4);       //不等於   True
        #endregion

    }

}
