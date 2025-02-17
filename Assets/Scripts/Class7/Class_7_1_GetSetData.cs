using UnityEngine;
namespace lotta_7
{
    /// <summary>
    /// 練習抓取資料用
    /// </summary>
    public class Class_7_1_GetSetData : MonoBehaviour
    {
        // 宣告另一個腳本的變數_記得在Unity屬性面板把另一個腳本拉下來
        public Class_7_1_Property property;
        
        private void Awake()
        {
            // 取的另一個類別的資料
            Debug.Log(property.moveSpeed);          // 可以取得公開變數
            //Debug.Log(property.turnSpeed);        // 不可取得私人變數                                              

            // 設定另一個類別的資料
            property.moveSpeed = 7.7f;              // 可以設定公開變數
            //property.turnSpeed = 20.2f;           // 不可設定私人變數

            Debug.Log(property.runSpeed);           // 可以取得公開的屬性
            //Debug.Log(property.sprintSpeed);      // 不可取得私人的屬性

            property.runSpeed = 50.3f;              // 可以設定有 set 的屬性
            //property.jumpSpeed = 99.5f;           // 不可設定沒有 set 屬性 (唯讀)
            
        }
    
    }

}

