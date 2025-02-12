using UnityEngine;
namespace lotta_8
{
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        // 類別 :
        // 用來定義一個物件以及他所有的資料與功能

        private void Awake()
        {
            // 實體化 NPC 並處存在 npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("捷克");
            Class_8_1_NPC npcZodd = new Class_8_1_NPC("Zodd" , "你好啊~");

            npcJack.LogName();
            npcZodd.LogName();
            npcJack.Talk();
            npcZodd.Talk();
        }
    }

}
