using UnityEngine;
public class Cladd_4_Function : MonoBehaviour
{
    /// <summary>
    /// 方法
    /// 中文 : 方法、函示、函數、功能
    /// 英文 : function、method(Unity)
    /// </summary>
    
    private void Awake()
    {
        #region 方法基本語法練習
        // 呼叫方法 : 方法沒有呼叫不會執行
        //方法名稱();
        FirstFunction();
        FirstFunction();
        FirstFunction();

        //呼叫有參數的方法 : 小括號內要放入對應數量的引數

        //UseSkill();  // 錯誤 : 缺少引數
        UseSkill("火球術", 30);
        UseSkill("冰凍術", 50);

        // 呼叫有預設值參數的方法 : 可以不用填參數(選填示參數)
        SpawnEmeny();
        SpawnEmeny("史萊姆");

        Fire(700);
        Fire(800, "保齡球");

        // 有多個選擇性參數的呼叫
        // 買紅水，50 個
        ButItem();
        //買紅水，30個
        //ButItem(30);          //錯誤寫法 30 會直接帶到 item 參數導致資料類型不符合
        ButItem(count: 30);     //正確寫法，指定參數
        //買藍水，50個
        ButItem("藍水");
        //買藍水，100個
        ButItem("藍水", 100);
        #endregion

        #region 呼叫有傳回的方法
        // 呼叫有傳回的方法
        // 第一種 : 把結果放到區域變數內
        int number9 = Square(9);
        Debug.Log($"<color=#a33>9 的平方{number9}</color>");
        // 第二種 : 把傳回平方寫作該傳回類型使用
        Debug.Log($"<color=#a33>7 的平方{Square(7)}</color>"); 
        #endregion

        #region 課堂練習
        //身高168，體重60
        Debug.Log($"<color=green>練習 1 的BMI = {Bmi(168, 60)}</color>");
        //身高160，體重42
        Debug.Log($"<color=green>練習 2 的BMI = {Bmi(160, 42)}</color>");

        #endregion

        #region 方法多載範例
        Move();
        Move(50.5f); 
        #endregion
    }

    //框選要整理得程式，案 Ctrl + K + S 選擇 #region 快速完成程式碼片段

    #region 方法基本語法語參數
    /* 方法
 *  包含一系列程式區塊
 *  方法語法 :
 *  修飾詞 傳回資料類型 方法名稱 (參數1，參數2，...，參數N) { 程式區塊 }
 *  方法命名習慣 : Unitry 習慣使用大寫開頭命名方法
 *  void 無傳回 : 使用方法不會傳回資料   */
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    //參數語法 : 與區域變數相同 資料類型 參數名稱 (習慣用小寫或加底線開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能 : {skill} </color>");
        Debug.Log($"<color=#f93>技能消耗 : {cost} </color>");
    }

    private void SpawnEmeny(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人 : {enemy} </color>");
    }

    //沒有預設值稱為 : 必要參數，有預設值稱為 選擇性參數
    //選擇性參數要放在必要參數後面
    // private void Fire(string fire = "子彈", int speed)
    //{

    // }       

    /// <summary>
    /// 物件發射方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="fire">要發射的物件</param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件 : {fire},速度 : {speed}</color>");
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void ButItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品 : {item},購買數量 : {count}</color>");
    }
    #endregion

    #region 有傳回的方法
    // 傳回方法 : 傳回類型不是 void，呼叫該方法會獲得結果
    // 傳回方法必須在 {} 內使用 return 關鍵字將結果傳回
    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number">要平方的數字</param>
    /// <returns>數字的平方</returns>
    private int Square(int number)
    {
        return number * number;
    } 
    #endregion

    #region 課堂練習
    /// <summary>
    /// 課堂練習_BMI計算 
    /// </summary>
    /// <param name="height">身高</param>
    /// <param name="weight">體重</param>
    /// <returns></returns>
    private float Bmi(float height, float weight)
    {
        height = height / 100;

        return weight / (height * height);
    }
    #endregion

    #region 方法的多載與命名不能重複
    // 類別、變數與方法的名稱  不能重複
    private void Test() { }
    // private void Test() { }      // 名稱重複的錯誤

    // 方法的多載 function overlod
    // 參數的類型或數量不同

    // 零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log("<color=#19f>移動中</color>");
    }

    //一個參數
    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>移動中，速度 : {speed}</color>");
    } 
    #endregion
}

