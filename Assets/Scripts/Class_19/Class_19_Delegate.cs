using lotta.tools;
using UnityEngine;

namespace lotta_19
{
    /// <summary>
    ///  委派 Delegate
    /// </summary>
    public class Class_19_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數與元組
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));
        }

        // 將 float 當作參數
        private void Cure(float cure)
        {
            LogSystem.LogWithColor($"治癒的值 : {cure}", "#3f3");
        }

        // 將元組當作參數
        private void Card((string name, int index) card)
        {
            LogSystem.LogWithColor($"卡片 : {card.name} | {card.index}", "#3f3");
        }
        #endregion

        // 1. 宣告委派 : 簽章(傳回與參數)
        // 宣告一個無傳回與無參數的委派
        private delegate void DelegateMethod();

        // 2. 目標方法
        private void Test()
        {
            LogSystem.LogWithColor("測試", "#f3f");
        }

        private void Talk()
        {
            LogSystem.LogWithColor("哈囉，你好 ˇ3ˇ", "#3f3");
        }

        private void MagicCard()
        {
            LogSystem.LogWithColor("召喚小兵", "#3f3");
        }

        // 3. 宣告變數存放方法
        private DelegateMethod delegateMethod;

        // 4. 呼叫委派
        private void Start()
        {
            delegateMethod = Test;          // 將方法 Test 存放到變數 delegateMethod 內
            delegateMethod += Talk;         // 多播委派 : 一個委派存放多個方法，要相同的簽章
            delegateMethod += MagicCard;    // 可添加多個方法
            delegateMethod -= Test;         // 也可以刪除方法
            delegateMethod();           // 呼叫委派
        }

        // 委派 : 將方法當作參數


    }
}

