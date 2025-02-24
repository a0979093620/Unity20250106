using lotta.tools;
using UnityEngine;

namespace lotta_9
{
    public class 練習_9_資料轉換 : MonoBehaviour
    {
         public float floatnumber = -999.321f;
         public sbyte sbytenumer = 1;
        private void Awake()
        {
            sbytenumer = (sbyte)floatnumber;
            LogSystem.LogWithColor($"顯示結果 : {sbytenumer}", "yellow");
        }



    }
}






