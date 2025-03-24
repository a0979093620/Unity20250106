using lotta.tools;
using System.Linq;
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

        private void Awake()
        {
            // 使用 LinQ 的關鍵字查詢資料
            // 起手式 : 
            // from 資料來源
            // 關鍵字 select 選取結果

            // 說明 : 選取 scores 內的每一筆資料
            var queryAllData = from score in scores
                               select score;

            foreach(var item in queryAllData)
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

            foreach(var item in querySixty)
            {
                LogSystem.LogWithColor(item, "#ff3");
            }

            // 群組
            // 情境 : 篩選出分數為偶數的資料與奇數
            // group by
            var quaryGroup = from score in scores
                             group score by score % 2;

            foreach(var group in quaryGroup)
            {
                LogSystem.LogWithColor(group, "#79f");
                foreach(var item in group)
                {
                    LogSystem.LogWithColor(item, "#79g");
                }

                LogSystem.LogWithColor("------群組分隔線-----", "#79f");
            }

        }
    }
}

