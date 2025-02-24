using JetBrains.Annotations;
using lotta.tools;
using lotta_10;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace lotta_10
{
    /// <summary>
    /// 繼承 Inherit
    /// </summary>
    public class Class_10_1_inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin = new Goblin(10, 1);
            LogSystem.LogWithColor($"哥布琳的攻擊:{goblin.attack}", "#f3d");
            var slime = new Slime(3, 2);
            LogSystem.LogWithColor($"史萊姆的攻擊:{slime.attack}", "#f3d");
            goblin.Move();
            slime.Move();
            slime.Initlize();

            // 判斷史萊姆是否繼承哥布林
            // 類別 A is 類別 B : 哥布林
            var slimeIsGoblin = slime is Goblin;
            LogSystem.LogWithColor($"史萊姆是否繼承哥布林 : {slimeIsGoblin}", "#f33");

            var spider1 = new Spider(15, 3);
            var spiderIsSlime = spider1 is Slime;
            var spiderIsGoblim = spider1 is Goblin;
            LogSystem.LogWithColor($"蜘蛛1號是否繼承哥布林 : {spiderIsGoblim}", "#f33");
            LogSystem.LogWithColor($"蜘蛛1號是否繼承史萊姆 : {spiderIsSlime}", "#f33");
        }
    }
 
    public class Goblin
    {
        public int attack;          // 公開 : 所有類別都可以存取
        public int defense;
        private float movespeed;    // 私人 : 此類別可以存取
        protected float hp;         // 保護 : 子類別都可以存取
        protected float lv = 5;

        public Goblin(int __attack, int __defense)
        {
            attack = __attack;
            defense = __defense;
        }

        // virtual 虛擬 : 允許子類別覆寫

        public virtual void Move()
        {
            LogSystem.LogWithColor("兩條腿移動", "#9f9");
        }

    }

    // 繼承類別可以繼承另一個類別，擁有 該類別的成員
    // 子類別 : 父類別
    // C# 僅提供單一繼承 (只能繼承一個類別)
    public class Slime : Goblin
    {
        protected int lv = 10;      // 綠色蚯蚓 : 提示父類別有相同成員名稱

        public Slime(int __attack, int __defense) : base(__attack, __defense)
        {
        }       //繼承父類別

        public void Initlize()
        {
            attack = 7;             // 公開 : 可以存取
                                    // movespeed = 3.5f;    // 私人 : 無法存取
            hp = 10;                // 保護 : 可以存取
            LogSystem.LogWithColor($"等級 :{lv}", "#78f");
            LogSystem.LogWithColor($"等級 :{base.lv} (父類別)", "#78f");
        }

        // override 覆寫 : 覆寫父類別有 virtual 關鍵字的成員
        // override 選擇要覆寫成員 > 按下 Enter 自動完成
        public override void Move()
        {
            // base.Move();    // 父類別原有內容
            LogSystem.LogWithColor("爬行", "#3f3");
        }
    }


    public class Spider : Slime
    {
        public Spider(int __attack, int __defense) : base(__attack, __defense)
        {
        }
    }

    
}



