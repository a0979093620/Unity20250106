using lotta.tools;
using UnityEngine;
namespace lotta_8
{
    /// <summary>
    /// 結構 struck
    /// </summary>
    public class Class_8_2_Struct : MonoBehaviour 
    {
        private void Awake()
        {
            Class_8_2_PlayerData player1 = new Class_8_2_PlayerData(2, 30);
            Class_8_2_PlayerData player2 = new Class_8_2_PlayerData(5, 100);

            //測試輸出工具
            LogSystem.LogWithColor("測試輸出工具", "#6f6");
            LogSystem.LogWithColor($"player1 lv = {player1.lv}，player1 hp = {player1.hp}", "#6f6");
            LogSystem.LogWithColor($"player2 lv = {player2.lv}，player2 hp = {player2.hp}", "#6f6");
        }



    }

}
