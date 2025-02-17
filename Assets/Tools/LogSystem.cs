using UnityEngine;

namespace lotta.tools
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class LogSystem
    {
        public static string LogWithColor(string message , string color)
        {
            string reslt = $"<color={color}>{message}</color>";
            Debug.Log(reslt);
            return reslt;
        }

    }
}

