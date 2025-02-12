using UnityEngine;
using UnityEngine.SceneManagement;      //���������n�[�o
namespace lotta_7
{ 
    /// <summary>
    /// �R�A Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        #region �ܼƻP�ݩ�
        // ���� : 
        // �ܼơB�ݩʡB��k

        // �D�R�A�ܼ�
        public int inventorWater = 10;

        // �R�A�ܼ� : �׹����᭱�K�[����r static
        // �R�A�ܼƤ���ܦb�ݩʭ��O�W
        public static int inventorProp = 20;

        public string skillMain => "���y�N";           // �D�R�A�ݩ�

        public static string skillSecond => "�v¡�N";  // �R�A�ݩ� 
        #endregion

        private float attack = 10;
        private static float mp = 100;

        private void Awake()
        {
            //inventorWater = 7;
            //inventorProp = 15;
            Debug.Log($"<color=#f31>�Ĥ� : {inventorWater}</color>");
            Debug.Log($"<color=#f31>�D�� : {inventorProp}</color>");

        }                       //��ܨ���ܼ�

        public void Punch()                            // �D�R�A��k
        {
            Debug.Log("<color=#3f3>�ϥή���</color>");

            // �D�R�A��k�i�H�s���Ҧ����� 
            Debug.Log($"<color=#f9e>�D�R�A�����O : {attack}</color>");
            Debug.Log($"<color=#f9e>�R�A�]�O : {mp}</color>");

        }
        
        public static void Kick()                       // �R�A��k
        {
            Debug.Log("<color=#3f3>�ϥν���</color>");
            // �R�A��k�u��s���R�A����
            // �ѩ� attack �O�D�R�A�L�k�s�� (�ɭP���~)
            // Debug.Log($"<color=#f9e>�D�R�A�����O : {attack}</color>");
            Debug.Log($"<color=#f9e>�R�A�]�O : {mp}</color>");

        }

        private void Start()
        {
            // �b Unity �����t��
            // ����������
            // �D�R�A�����|�Q���� (�٭���w�]��)
            inventorWater++;    // �Ĥ��[�@
            Debug.Log($"<color=#78f>�Ĥ� : {inventorWater}</color>");

            // �D�R�A�����|�Q���� (�٭���w�]��)
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
