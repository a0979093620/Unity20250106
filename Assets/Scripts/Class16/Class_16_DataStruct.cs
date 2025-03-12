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
        #region 清單
        // 陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };
        public List<float> playerDefence;

        // 清單 : 泛型集合
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };

        #endregion
        private void Awake()
        {
            #region 清單
            // 清單存取 : 與陣列相同
            LogSystem.LogWithColor($"第三筆速度 : {speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度 : {speeds[0]}", "#3f3");

            // 陣列初始化後無法增加長度
            // 清單可以

            // 添加一筆道具
            props.Add("寶劍");
            // 刪除第一筆道具
            props.RemoveAt(0);
            // 插入頭盔到編號 1 上
            props.Insert(1, "頭盔");

            foreach (var prop in props)
            {
                LogSystem.LogWithColor($"道具 : {prop}", "#f93");
            }

            // 由建構子帶入陣列建造清單
            playerDefence = new List<float>(defens);
            // 排序 : 由小到大
            playerDefence.Sort();
            // 排序 : 由大到小
            playerDefence.Reverse();

            foreach (var item in playerDefence)
            {
                LogSystem.LogWithColor($"資料 : {item}", "#f96");
            }

            // Count 指清單內的資料，根據 Add 和 Remove 改變
            LogSystem.LogWithColor($"數量 : {props.Count}", "#77f");
            // Capcity 指清單內的容量，系統自動分配，預設為 4 並且以倍數成長 (C# 版本不同)
            LogSystem.LogWithColor($"容量 : {props.Capacity}", "#77f");

            List<int> numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                LogSystem.LogWithColor($"數量 : {numbers.Count}", "#77f");
                LogSystem.LogWithColor($"容量 : {numbers.Capacity}", "#f39");
            }
            #endregion

            #region 堆疊
            // 堆疊 : 先進後出。類似椅子疊一起
            Stack<string> emeny = new Stack<string>();
            // 放資料進入堆疊
            emeny.Push("史萊姆");
            emeny.Push("哥布林");
            LogStrack<string>(emeny);

            // 拿資料並且不移除
            LogSystem.LogWithColor($"取出的資料 : {emeny.Peek()}", "#f33");           
            LogStrack<string>(emeny);
            // 拿資料並且移除
            LogSystem.LogWithColor($"取出的資料 : {emeny.Pop()}", "#f33");            
            LogStrack<string>(emeny);

            // 判斷是否包含某筆資料
            LogSystem.LogWithColor($"{emeny.Contains("哥布林")}", "#3f6");
            // 清除所有資料
            emeny.Clear();
            LogStrack<string>(emeny);
            #endregion

            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");
            LogQueue<string>(player);
            
            // 拿東西並且不刪除，與堆疊的 Peek 相同
            LogSystem.LogWithColor($"取出的資料 : {player.Peek()}", "#f33");
            LogQueue<string>(player);
            // 拿東西並刪除，與堆疊的 Pop 相同
            LogSystem.LogWithColor($"取出的資料 : {player.Dequeue()}", "#f33");
            LogQueue<string>(player);



        }

        private void LogStrack<T>(Stack<T> stack)
        {
            LogSystem.LogWithColor("----------", "#fff");
            foreach (var item in stack)
            {
                LogSystem.LogWithColor($"堆疊資料 : {item}", "#f74");
            }



        }

        private void LogQueue<T>(Queue<T> queue)
        {
            LogSystem.LogWithColor("----------", "#fff");
            foreach(var item in queue)
            {
                LogSystem.LogWithColor($"佇列資料 : {item}", "#7f7");
            }
        }

    }
}

