using lotta.tools;
using UnityEngine;
namespace lotta_19
{
    public class Class_19_BgmManger : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event Class_19_Event;

        // 步驟 3. 訂閱事件(unity 習慣在 Awake 或 Start 訂閱
        private void Awake()
        {
            // 事件 : 輸入 += 可以使用 Tab 自動完成 > 命名方法後 > Enter 完成
            Class_19_Event.onDead += ChangeBgm;
            Class_19_Event.onDeadAction += ChangeBgmViaHp;
            Class_19_Event.onEvent += ChangeBgmEvent;
            Class_19_Event.onEventWithHp += ChangeBgmWithHp;
        }

        private void ChangeBgmWithHp(object sender, float e)
        {
            LogSystem.LogWithColor($"發送事件者 : {sender}，參數 : {e}", "#ff3");
        }

        private void ChangeBgmEvent(object sender, System.EventArgs e)
        {
            LogSystem.LogWithColor($"發送事件者 : {sender}，參數 : {e}", "#ff3");
        }

        private void ChangeBgmViaHp(string arg1, float arg2)
        {
            LogSystem.LogWithColor($"{arg1}, | 血量 : {arg2}", "#78f");
            if(arg2 <= 5)
            {
                LogSystem.LogWithColor("變更遊戲結束音樂", "#777");
            }
        }

        private void ChangeBgm()
        {
            LogSystem.LogWithColor("變更音樂", "#3f3");
        }
    }
}

