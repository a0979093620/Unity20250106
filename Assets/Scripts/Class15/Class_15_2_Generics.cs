using lotta.tools;
using UnityEngine;

namespace lotta_15
{
    /// <summary>
    /// 泛型
    /// </summary>
    public class Class_15_2_Generics : MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型
            #region 數字
            int numberA = 7, numberB = 6;
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");
            #endregion

            #region 字元
            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元 A 與 B : {charA} | {charB}", "#f93");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元 A 與 B : {charA} | {charB}", "#f93");
            #endregion

            #region 物件
            object objectA = 3.5f, objectB = '好';
            LogSystem.LogWithColor($"物件 A 與 B : {objectA} | {objectB}", "#f33");
            SwapObject(ref objectA, ref objectB);
            LogSystem.LogWithColor($"物件 A 與 B : {objectA} | {objectB}", "#f33");
            #endregion 
            #endregion

            bool boolA = false, boolB = true;
            LogSystem.LogWithColor($"物件 A 與 B : {boolA} | {boolB}", "#9f9");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($"物件 A 與 B : {boolA} | {boolB}", "#9f9");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($"物件 A 與 B : {byteA} | {byteB}", "#9f9");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($"物件 A 與 B : {byteA} | {byteB}", "#9f9");



            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);

            var player2 = new DataPlayer<string>();
            player2.data = "玩家二號";
            player2.LogData("哈囉");


        }

        #region 不使用泛型的對調方法
        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a">第一個數字</param>
        /// <param name="b">第二個數字</param>
        public void SwapNumber(ref int a, ref int b)       // ref 是同步功能，不用設定 a 或 b，直接將變數 numberA 和 numberB 同步成 a 和 b
        {
            int temp = a;       // 將第一個數字放到旁邊
            a = b;              // 將第二個數字放到第一個
            b = temp;           // 將旁邊的數字放到第二個
        }

        /// <summary>
        /// 字元對調
        /// </summary>
        /// <param name="a">第一個字元</param>
        /// <param name="b">第二個字元</param>
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 物件對調
        /// </summary>
        /// <param name="a">第一個物件</param>
        /// <param name="b">第二個物件</param>
        //不建議使用，會有裝箱拆箱的問題
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        #endregion

        /// <summary>
        /// 使用泛型對調資料
        /// </summary>
        /// <typeparam name="T">要對調的資料類型</typeparam>
        /// <param name="a">第一個資料</param>
        /// <param name="b">第二個資料</param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public class DataPlayer<T>
        {
            public T data;
            public void LogData(T data)
            {
                LogSystem.LogWithColor(data, "#3ff");
            }
        }

    }
}

