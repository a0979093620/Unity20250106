using lotta.tools;
using UnityEngine;

namespace lotta_10
{
    /// <summary>
    /// 繼承 Inherit
    /// </summary>
    public class Class_10_1_inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblon = new Goblin(10, 1);
            LogSystem.LogWithColor($"哥布琳的攻擊:{goblon.attack}", "#f3d");
            var slime = new Slime(3, 2);
            LogSystem.LogWithColor($"史萊姆的攻擊:{slime.attack}", "#f3d");
        }
    }

    public class Goblin
    {
        public int attack;          // 公開 : 所有類別都可以存取
        public int defense;
        private float movespeed;    // 私人 : 此類別可以存取
        protected float hp;         // 保護 : 子類別都可以存取

        public Goblin(int __attack, int __defense)
        {
            attack = __attack;
            defense = __defense;
        }
    }

    public class Slime : Goblin
    {
        public Slime(int __attack, int __defense) : base(__attack, __defense)
        {
        }

        public void Initlize()
        {
            attack = 7;             // 公開 : 可以存取
            // movespeed = 3.5f;    // 私人 : 無法存取
            hp = 10;                // 保護 : 可以存取
        }
    }
}

