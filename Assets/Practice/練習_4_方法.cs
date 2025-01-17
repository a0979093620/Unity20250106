using UnityEngine;

public class 練習_4_方法 : MonoBehaviour 
{
    private void Awake()
    {
        Function_1();
        Function_2();
     
        Debug.Log(Function_3());
        Debug.Log(Function_4());
    }

    /// <summary>
    /// 課堂作業
    /// </summary>
    public void Function_1()
    {
        Debug.Log(10 > 5); 
    }

    public void Function_2()
    {
        Debug.Log(10 < 5); 
    }

    /// <summary>
    /// 用別的方法嘗試
    /// </summary>
    [TextArea(1, 10)] public string function_3 = "用function_3 的方法來判斷 number1 是否大於 number2";
    [TextArea(1, 10)] public string function_4 = "用function_4 的方法來判斷 number1 是否小於 number2";
    [Header("用來判斷的數字")]

    //變數設定
    public int number1 = 10;
    public int number2 = 5;
    private bool number3 = true;
    private bool number4 = true;

    /// <summary>
    /// 其他嘗試
    /// </summary>
    /// <returns>判斷是否正確</returns>
    public bool Function_3()
    {
        number3 = number1 > number2;
        return number3;
       
    } public bool Function_4()
    {
        number4 = number1 < number2;
        return number4; 
     
    }
}
