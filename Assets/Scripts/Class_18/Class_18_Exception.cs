using lotta.tools;
using System;
using UnityEditor.VersionControl;
using UnityEngine;
namespace lotta_18
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18_Exception : MonoBehaviour
    {
        private void Awake()
        {
            // 例外1
            LogSystem.LogWithColor($"{Divistion(8, 4)}", "#f33");
            LogSystem.LogWithColor($"{Divistion(3, 9)}", "#f33");
            LogSystem.LogWithColor($"{Divistion(7, 0)}", "#f33");

            // 例外2
            LogSystem.LogWithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(9)}", "#3f3");

            // 例外3
            SetEmeny();
        }

        #region 例外1
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="numberA">分子</param>
        /// <param name="numberB">分母</param>
        /// <returns></returns>
        private int? Divistion(int numberA, int numberB)
        {
            // 可能發生例外的區域
            try
            {
                return numberA / numberB;   //發生例外

            }
            // 捕捉到例外為「除以零」，會執行此區域
            catch (DivideByZeroException e)
            {
                // Message 例外官方訊息
                LogSystem.LogWithColor($"分母不可為零 | {e.Message}", "#f99");
                return null;
            }
            finally
            {
                LogSystem.LogWithColor("例外處理完畢", "#f73");
            }
        } 
        #endregion

        #region 例外2
        private int[] scores = { 70, 91, 64, 53, 88 };

        private int? GetScores(int index)
        {
            try
            {
                return scores[index];

            }
            catch (DivideByZeroException)
            {
                LogSystem.LogWithColor("發生例外", "#f11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                LogSystem.LogWithColor($"發生利外 | {e.Message}", "#f11");
                return null;
            }
        }
        #endregion

        #region 例外3
        [SerializeField]
        private GameObject enemy;

        private void SetEmeny()
        {
            try
            {
                enemy.SetActive(true);  // 顯示敵人
            }
            catch (Exception e)     // Exception 處理所有例外
            {
                LogSystem.LogWithColor($"發生例外 {e.Message}", "#f39");
            }
        } 
        #endregion
    }
}

