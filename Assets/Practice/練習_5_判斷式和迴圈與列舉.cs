using System;
using UnityEngine;
namespace lotta_5
{
    public class 練習_5_判斷式和迴圈與列舉 : MonoBehaviour
    {
        // 宣告血量變數
        [SerializeField, Header("血量"), Range(0, 100)]
        private int blood = 0;
       
        private void Update()
        {
            #region 練習5
            switch (blood)
            {
                case >= 80:
                    Debug.Log("<color=green>血量安全</color>");
                    break;

                case >= 60:
                    Debug.Log("<color=yellow>健康狀態有狀況</color>");
                    break;

                case >= 40:
                    Debug.Log("<color=orange>警告，快喝水</color>");
                    break;

                case >= 10:
                    Debug.Log("<color=red>快死掉了</color>");
                    break;

                default:
                    Debug.Log("<color=black>你已經死了</color>");
                    break; 

            }
            #endregion
        }
    }
       
}
