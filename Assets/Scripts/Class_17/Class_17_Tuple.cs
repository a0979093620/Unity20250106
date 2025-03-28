﻿using lotta.tools;
using System;
using UnityEngine;

namespace lotta_17
{
    /// <summary>
    /// 元組
    /// </summary>
    public class Class_17_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            // 元組 : 儲存多筆不同類型的資料
            // 宣告方式 : 指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 7);
            LogSystem.LogWithColor($"{card1.name} |" + $"消耗 : {card1.cost} |" + $"編號 : {card1.index}","#f49");

            // 宣告方式 2 :指定類型
            // 取得元組資料使用 Item1 ~ItemN
            (string, int, int) card2 = ("哥布林", 3, 10);
            LogSystem.LogWithColor($"{card2.Item1} |" + $"消耗 : {card2.Item2} |" + $"編號 : {card2.Item3}","#f49");

            // 宣告方式 3 : 使用 var
            var card3 = ("樹精", 5, 12);
            LogSystem.LogWithColor($"{card3.Item1} |" + $"消耗 : {card3.Item2} |" + $"編號 : {card3.Item3}","#f49");

            // 宣告方式 4 : 使用 var 以及指名
            var card4 = (name: "蝙蝠", cost: 3, index: 7);
            LogSystem.LogWithColor($"{card4.name} |" + $"消耗 : {card4.cost} |" + $"編號 : {card4.index}","#f49");

            UseCard(card1);
            UseCard(card2);
            UseCard(("暴龍", 13, 24));

            var cardupdate = UpdateCardCost(card1);
            LogSystem.LogWithColor($"{cardupdate.name} |" + $"消耗 : {cardupdate.cost} |" +
                $" 編號 : {cardupdate.index}", "#f49");
            LogSystem.LogWithColor($"{cardupdate == card1}", "#79f");
            LogSystem.LogWithColor($"{cardupdate != card1}","#79f");


        }

        /// <summary>
        /// 使用卡牌
        /// </summary>
        /// <param name="card">卡牌元組，名稱,消耗與編號</param>
        private void UseCard((string name, int cost, int index) card)
        {
            LogSystem.LogWithColor( $"消耗 : {card.cost} |" + $"使用卡牌 : {card.name} |" ,"#f79");
            
        }
        
        /// <summary>
        /// 降低卡牌消耗
        /// </summary>
        /// <param name="card">卡牌</param>
        /// <returns>降低消耗的卡牌</returns>
        private (string name, int cost, int index) UpdateCardCost((string name, int cost, int index) card)
        {
            card.name = card.name + "降低消耗版本";
            card.cost -= 1;
            return card;
        }
        
    }
}

