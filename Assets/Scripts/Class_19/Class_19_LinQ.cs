using lotta.tools;
using System.Linq;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
namespace lotta_19
{
    /// <summary>
    /// LinQ 整合查詢語言 Language Interated Quary
    /// 查詢資料庫，所有程式語言共用技術
    /// </summary>
    public class Class_19_LinQ : MonoBehaviour
    {
        public int[] scores = { 90, 80, 77, 88, 93, 1, 5, 10, 35 };
        public string[] items = { "紅色藥水", "藍色藥水", "地圖", "回家卷軸", "匕首", "紅色炸彈" };
        public int[] numbers = { 1, 23, 77, 34, 42, 50, 80 };
        
        private void Awake()
        {
            #region LinQ基本用法
            // 使用 LinQ 的關鍵字查詢資料
            // 起手式 : 
            // from 資料來源
            // 關鍵字 select 選取結果

            // 說明 : 選取 scores 內的每一筆資料
            var queryAllData = from score in scores
                               select score;

            foreach (var item in queryAllData)
            {
                LogSystem.LogWithColor(item, "#3f3");
            }

            // 情境 : 希望找大於 60 分的玩家分數
            // where 篩選的條件
            // orderby 排序 (預設是由小到大) descending 由大到小
            var querySixty = from score in scores
                             where score >= 60
                             orderby score descending
                             select score;

            foreach (var item in querySixty)
            {
                LogSystem.LogWithColor(item, "#ff3");
            }

            // 群組
            // 情境 : 篩選出分數為偶數的資料與奇數
            // group by
            var quaryGroup = from score in scores
                             group score by score % 2;

            foreach (var group in quaryGroup)
            {
                LogSystem.LogWithColor(group, "#79f");
                foreach (var item in group)
                {
                    LogSystem.LogWithColor(item, "#79g");
                }

                LogSystem.LogWithColor("------群組分隔線-----", "#79f");
            } 
            #endregion

            // let 中間變數，可以取得特定資料並儲存在變數內
            var queryRed = from item in items
                           let firstWord = items[0] //先取得所有資料的第一個字
                           where firstWord == "紅"
                           select item;

            foreach (var item in queryRed)
            {
                LogSystem.LogWithColor($"第一個式紅的道具 : {item}", "#fa3");
            }

            // into 將資料分組，在獲得資料時可透過 key 獲得分組名單
            var queryGroup = from item in items
                             group item by item[0] into newGroup
                             select newGroup;

            foreach (var group in queryGroup)
            {
                LogSystem.LogWithColor($"群組 : {group.Key}", "#3f3");
                foreach(var item in group)
                {
                    LogSystem.LogWithColor($"道具 : {item}", "#9f9");
                }
            }

            var queryEquals = from score in scores
                              join number in numbers    // 加入第二組資料
                              on score equals number    // on 比較兩組資料
                              //select score;
                              select number;            // 選兩組資料都相同
            foreach(var item in queryEquals)
            {
                LogSystem.LogWithColor($"兩組相同的數字 : {item}", "#f33");
            }
            LogSystem.LogWithColor($"最大值 : {queryEquals.Max()}", "#7f7");
            LogSystem.LogWithColor($"最小值 : {queryEquals.Min()}", "#7f7");
            LogSystem.LogWithColor($"平均值 : {queryEquals.Average()}", "#7f7");
            LogSystem.LogWithColor($"總和值 : {queryEquals.Sum()}", "#7f7");

        }
    }
}

