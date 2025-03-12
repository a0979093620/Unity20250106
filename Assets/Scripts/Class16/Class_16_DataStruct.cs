using lotta.tools;
using UnityEngine;
using System.Collections.Generic;       // 有許多資料結構的命名空間

namespace lotta_16
{
    /// <summary>
    /// 資料結構 DataStruct
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        // 陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };
        
        // 清單 : 泛型集合
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };

        private void Awake()
        {
            // 清單存取 : 與陣列相同
            LogSystem.LogWithColor($"第三筆速度 : {speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度 : {speeds[0]}", "#3f3");

        }
    }
}

