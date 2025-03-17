using lotta.tools;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;       // 有許多資料結構的命名空間

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

            #region 佇列
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
            #endregion

            #region 鏈結串列
            // Linklist 鏈結串列
            string[] skillArray = new string[] { "火球", "水球" };
            LinkedList<string> skills = new LinkedList<string>(skillArray);
            LogLinkList<string>(skills);
            skills.AddLast("毒球");
            LogLinkList<string>(skills);
            skills.AddLast("治癒球");
            LogLinkList<string>(skills);

            // 在火球後面添加草球
            LinkedListNode<string> findskill = skills.Find("火球");
            skills.AddAfter(findskill, "草球");
            // 在火球前面添加暗球
            skills.AddBefore(findskill, "暗球");
            LogLinkList<string>(skills);
            #endregion

            #region 排序集合
            // 自動排序並且不重複的集合(由小到大排序)
            SortedSet<int> counts = new SortedSet<int>() { 9, 2, 80, 1 };
            LogLSortSet<int>(counts);
            counts.Add(77);
            counts.Add(123);
            counts.Add(9);
            LogLSortSet<int>(counts);
            LogSystem.LogWithColor($"最大 : {counts.Max}", "#f33");
            LogSystem.LogWithColor($"最大 : {counts.Min}", "#f33");

            SortedSet<int> lv = new SortedSet<int> { 7, 3, 75, 123, 5, 80 };
            // 交集與差異
            counts.IntersectWith(lv);       //count 會只剩下{80,123}
            LogLSortSet(counts);
            counts.ExceptWith(lv);      //交集:刪掉 counts 裡面的{7,3,75,123,5,80}
            LogLSortSet(counts);        // counts 就只剩空集合 
            #endregion

            #region 字典
            // 字典
            Dictionary<int, string> deck = new Dictionary<int, string>()
            {
                {10, "小棉球" }, {3, "大棉花"}, {1, "中等棉"}
            };
            LogDictionary<int, string>(deck);
            deck.Add(7, "ㄚㄚ棉");
            // containskey  containsvalue  用來判斷是否有特定鍵或值
            LogSystem.LogWithColor($"是否有編號 7 :{deck.ContainsKey(7)}", "#f33");
            LogSystem.LogWithColor($"是否有棉花 :{deck.ContainsValue("棉花")}", "#f33");
            #endregion

            #region 排序清單與排序字典
            // 保持排序並且不會有重複的鍵(依照 Key 來排序)
            SortedList<string, int> board = new SortedList<string, int>();
            board.Add("喵", 99);
            board.Add("汪", 13);
            board.Add("嘿", 13);
            //  board.Add("嘿", 50);         重複的鍵會導致錯誤
            LogSortedList<string, int>(board);


            // 保持排序的字典(依照 Key 來排序)
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();
            scores.Add("喵", 99);
            scores.Add("汪", 13);
            scores.Add("嘿", 13);
            //  scores.Add("嘿", 50);         重複的鍵會導致錯誤
            LogSortedDictionary<string, int>(scores);

            // Sortedlist 與 SortedDictionary 的差異
            // 1. SortedList 是使用陣列方式儲存，比較省空間
            // 2. SortedDictionary 是使用樹狀結構方式儲存，比較占記憶體空間
            // 3. SortedList 可以使用索引值存取 [0]
            LogSystem.LogWithColor($"排行第一筆 : {board.Keys[0]}", "#f93");
            // LogSystem.LogWithColor($"排行第一筆 : {scores.Keys[0]}","#f93" );
            // 4. SortedList 大量資料增減比較占記憶體
            // 如果衣料不需要頻繁增減建議使用 SortedList 反之建議使用 SortedDictionary 
            #endregion

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

        private void LogLinkList<T>(LinkedList<T> linklist)
        {
            foreach (var item in linklist)
            {
                LogSystem.LogWithColor(item, "#7f7");
            }

            LogSystem.LogWithColor("----------", "#fa3");
        }

        private void LogLSortSet<T>(SortedSet<T> set)
        {
            foreach (var item in set)
            {
                LogSystem.LogWithColor(item, "#7f7");
            }

            LogSystem.LogWithColor("----------", "#fa3");
        }

        private void LogDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach(var item in dict)
            {
                // key 說的是 鍵     value 說的是值
                LogSystem.LogWithColor($"編號 : {item.Key}", "#f96");
                LogSystem.LogWithColor($"名稱 : {item.Value}", "#ff6");
            }
            LogSystem.LogWithColor("---------------", "#f45");
        }

        private void LogSortedList<T,U>(SortedList<T,U> list)
        {
            foreach(var item in list)
            {
                LogSystem.LogWithColor($"{item.Key}的分數 : {item.Value}", "#77f");
            }
            LogSystem.LogWithColor("-----------------", "#ff5");
        }

        private void LogSortedDictionary<T, U>(SortedDictionary<T, U> dict)
        {
            foreach (var item in dict)
            {
                LogSystem.LogWithColor($"{item.Key}的分數 : {item.Value}", "#77f");
            }
            LogSystem.LogWithColor("-----------------", "#ff5");
        }
    }
}

