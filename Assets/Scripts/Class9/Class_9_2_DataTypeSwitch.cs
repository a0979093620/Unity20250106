using lotta.tools;
using UnityEngine;
using System;   //使用 API 一定要加的
namespace lotta_9
{
    public class Class_9_2_DataTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            #region 隱式轉換
            // 隱式轉換 : 不需要另外宣告轉換類型
            // 將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor("隱式轉換", "yellow");
            LogSystem.LogWithColor(byte1, "#7f7");
            LogSystem.LogWithColor(byte1.GetType(), "#7f7");
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");

            // 隱式轉換 : 將比較小的 Byte 放到大的 Int 裡面
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7"); 
            #endregion

            #region 顯示轉換
            // 顯示轉換 : 需要宣告轉換型態
            // 將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor("顯示轉換", "yellow");
            LogSystem.LogWithColor(int2, "#7f7");
            LogSystem.LogWithColor(int2.GetType(), "#7f7");
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7");

            // 顯示轉換 : 將比較大的 Int 放到小的 Byte 內
            // 添加 (資料類型)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7"); 
            #endregion

            #region 例外狀況
            // 例外狀況
            // 浮點數轉為整數型別，小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0;
            byte3 = (byte)float1;
            LogSystem.LogWithColor("例外狀況", "yellow");
            LogSystem.LogWithColor(byte3, "#f77");

            // 範圍較大的轉為範圍較小的，會導致溢位
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#f77"); 
            #endregion
        }
        private void Start()
        {
            // Unity 裡的 Api     Convert.ToString(要轉換的資料);     將資料轉成字串

            //將整數轉成字串
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSystem.LogWithColor(intToString.GetType(), "#f96");

            // 將布林値轉成字串
            bool isOver = true;
            var boolToString = Convert.ToString(isOver);
            LogSystem.LogWithColor(isOver.GetType(), "#f96");

            // 浮點數轉字串
            float move = 3.5f;
            var floatToByte = Convert.ToByte(move);
            LogSystem.LogWithColor(move.GetType(), "#f96");

            // true = 1 , false = 0
            bool isGrounded = true;
            var boolToByte = Convert.ToByte(isGrounded);
            LogSystem.LogWithColor(boolToByte, "#6f6");
            LogSystem.LogWithColor(boolToByte.GetTypeCode(), "#6f6");



        }
    }
}

