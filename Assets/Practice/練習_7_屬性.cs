using lotta.tools;
using UnityEngine;
namespace lotta_7
{
    public class 練習_7_屬性 : MonoBehaviour
    {
        [Header("血量"), Range(0 , 100 )] public float _hp;
        public float hp
        {
            get
            { 
                if ( _hp <= 0 )
                {
                    LogSystem.LogWithColor("玩家已死亡", "orange");
                    return _hp;
                } 
                    return _hp;
            }
            
        }
        private void Awake()
        {
            LogSystem.LogWithColor($"玩家血量 : {hp}", "yellow");
        }
    }
}

