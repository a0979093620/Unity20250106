using UnityEngine;
using UnityEngine.SceneManagement;      //���������n�[�o
namespace lotta_7
{ 
    /// <summary>
    /// �R�A Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        // ���� : 
        // �ܼơB�ݩʡB��k

        // �D�R�A�ܼ�
        public int inventorWater = 10;

        // �R�A�ܼ� : �׹����᭱�K�[����r static
        // �R�A�ܼƤ���ܦb�ݩʭ��O�W
        public static int inventorProp = 20;

        // �D�R�A�ݩ�
        public string skillMain => "���y�N";

        // �R�A�ݩ�
        public static string skillSecond => "�v¡�N";

        private void Awake()
        {
            //inventorWater = 7;
            //inventorProp = 15;
            Debug.Log($"<color=#f31>�Ĥ� : {inventorWater}</color>");
            Debug.Log($"<color=#f31>�D�� : {inventorProp}</color>");

        }

        // �D�R�A��k
        public void Punch()
        {
            Debug.Log("<color=#3f3>�ϥή���</color>");
        }

        // �R�A��k
        public static void Kick()
        {
            Debug.Log("<color=#3f3>�ϥν���</color>");
        }

        private void Start()
        {
            /// �b Unity �����t��
            /// ����������
            /// �D�R�A�����|�Q���� (�٭���w�]��)
            inventorWater++;    // �Ĥ��[�@
            Debug.Log($"<color=#78f>�Ĥ� : {inventorWater}</color>");

            /// �D�R�A�����|�Q���� (�٭���w�]��)
            inventorProp++;     // �D��[�@
            Debug.Log($"<color=#78f>�D�� : {inventorProp}</color>");

        }

        private void Update()
        {
            // �b Game �e�����U�Ʀr 1 �|���s���J���� (�����^���J�k)
            // �p�G���U�Ʀr 1 (������L)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("�ҵ{_7_�ݩʻP�R�A");
            }
        }
    }

}
