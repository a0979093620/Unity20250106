using UnityEngine;

public class 練習_3_運算子 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=orange>作業計算結果 : {6 / (2 * (1 + 2 ))}</color>");

        Debug.Log($"<color=orange>用呼叫方法的方式算 : { Count()}</color>");
    }

    /// <summary>
    /// 用別的方法嘗試
    /// </summary>
    [TextArea(1, 10)] public string Cal = "num1 / num2 (num3 + num4)";
    [Header("數字1")] public int number1 = 6;
    [Header("數字2")] public int number2 = 2;
    [Header("數字3") , Range (1,10)] public int number3 = 1;
    [ Header("數字4") , Range (1,10) ] public int number4 = 2;

    /// <summary>
    /// 方法設定
    /// </summary>
    /// <returns>計算結果</returns>
     public int Count()
    {
        return number1 / (number2 *(number3 + number4));
    }

}
