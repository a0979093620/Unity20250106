using UnityEngine;

namespace lotta.tools
{
    /// <summary>
    /// ��X�T���u��
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

