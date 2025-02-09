using UnityEngine;
namespace lotta_6
{
    public class 練習_6_迴圈與陣列 : MonoBehaviour
    {

        #region 宣告三維陣列(3*3*2)
        public string[,,] Practice =
        {
            //第一頁_神奇寶貝
            { {"妙蛙花" , "菊草葉" , "新葉喵" } , {"皮卡丘" , "咚咚鼠" , "白色惡魔" } },
            //第二頁_楓之谷
            { {"嫩寶" , "緞帶肥肥" , "黑木妖" } , {"藍水靈" , "姑姑寶貝" , "肥肥" } },
            //第三頁_英雄聯盟
            { { "蓋倫" , "克雷德" , "凱能" }, { "史矛德" , "吶兒" , "悠咪" } }
        }; 
        #endregion

        private void Start()
        {
            //取得皮卡丘，姑姑寶貝，蓋倫
            Debug.Log($"<color=orange>皮卡丘: {Practice[0, 1, 0] }、姑姑寶貝: {Practice[1 , 1 , 1]}、蓋倫: {Practice[2 , 0 , 0]}</color>");

            //取得第二頁第一排第三個_黑木妖
            Debug.Log($"<color=yellow>黑木妖: {Practice[1, 0, 2]}</color>");
        }
    }

}
