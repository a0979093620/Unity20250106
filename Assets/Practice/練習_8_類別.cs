using lotta.tools;
using UnityEngine;

namespace lotta_8
{
    public class 練習_8_類別 : MonoBehaviour
    {
        private void Awake()
        {
            Boss boss1 = new Boss("喵喵", "抓抓", 20);
            Boss boss2 = new Boss("汪汪", "咬咬", 50);

            boss1.CallBoss();
            boss2.CallBoss();
        }
    }
}
            
      public class Boss
        {
            private string name;
            private string skill;
            private int hp;

            public Boss(string _name, string _skill, int _hp)
            {
                name = _name;
                skill = _skill;
                hp = _hp;
                
            }

            public void CallBoss()
            {
                LogSystem.LogWithColor($"Boss 名稱 : {name}，絕招 : {skill}，HP = {hp}", "orange");
            }
        }



