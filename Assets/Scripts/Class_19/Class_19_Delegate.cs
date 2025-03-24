using lotta.tools;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

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

        // 宣告有傳回有參數的委派
        private delegate float Calculate(float numberA, float numberB);

        // 泛型委派_無傳回有一個參數
        private delegate void DelegateCombing<T>(T a);


        // 2. 目標方法
        #region 無傳回無參數的方法
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
        #endregion

        #region 有傳回有參數的方法
        private float Add(float numberA, float numberB)
        {
            float result = numberA + numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }
        #endregion

        private void Combine<T>(T a)
        {
            LogSystem.LogWithColor(a, "#ff3");
        }

        // 3. 宣告變數存放方法
        private DelegateMethod delegateMethod;
        private Calculate calculate;

        private DelegateCombing<float> delegateCombingFloat;
        private DelegateCombing<int> delegateCombingInt;


        // Func
        // 可以存放有傳回值並且有 0 個參數以上的方法
        // <參數，回傳值>
        private Func<float, float> funCalc;

        // Action
        // 可以存放無傳回值並且有 0 個參數以上的方法
        private Action actionMetohd;

        // Predicate
        // 可以存放有布林值傳回並且有 1 個參數的方法
        // 宣告一個委派，有一個參數 float，並且傳回值為 bool
        private Predicate<float> predicate;





        // 4. 呼叫委派
        private void Start()
        {
            #region 無傳回無參數的委派
            delegateMethod = Test;          // 將方法 Test 存放到變數 delegateMethod 內
            delegateMethod += Talk;         // 多播委派 : 一個委派存放多個方法，要相同的簽章
            delegateMethod += MagicCard;    // 可添加多個方法
            delegateMethod -= Test;         // 也可以刪除方法
            delegateMethod();           // 呼叫委派  
            #endregion

            #region 有傳回有參數的委派
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10, 3);
            calculate(100, 70);
            #endregion

            CalcuteNunber(Sub, 3, 7);   //將方法當作參數傳遞

            delegateCombingFloat = Combine<float>;
            delegateCombingFloat(3.5f);
            delegateCombingInt = Combine<int>;
            delegateCombingInt(999);







            funCalc = delegate (float x) { return x * 10; };
            LogSystem.LogWithColor($"Func 委派 : {funCalc(3.5f)}", "#f33");

            actionMetohd = delegate () { LogSystem.LogWithColor("Action 委派  ", "#f33"); };
            actionMetohd();

            predicate = delegate(float x) {return x >0; };
            LogSystem.LogWithColor($"Predicate委派 : 7 是否大於零 _ {predicate(7)}", "#f33");

            // Lambda 運算子 =>
            // (參數) => { 陳述式 }
            Action action = () => { LogSystem.LogWithColor("Lambda 練習", "#ff3"); };
            action();

            Func<int,string>func = (x) => { return $"Lambda 練習 ，數字 : {x}"; };
            LogSystem.LogWithColor($"{func(77)}", "#ff3");

            Predicate<string> predicateTest = (x) => { return x.Length >0; };
            LogSystem.LogWithColor($"{predicateTest("喵")}", "#ff3");


        }

        // 委派 : 將方法當作參數
        private void CalcuteNunber(Calculate calculate, float a, float b)
        {
            var result = calculate(a, b);
            LogSystem.LogWithColor(result, "#ff3");
        }

    }
}

