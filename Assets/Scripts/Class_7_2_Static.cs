using UnityEngine;
namespace lotta_7
{ 
    /// <summary>
    /// �R�A Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        // �D�R�A�ܼ�
        public int inventorWater = 10;

        // �R�A�ܼ� : �׹����᭱�K�[����r static
        // �R�A�ܼƤ���ܦb�ݩʭ��O�W
        public static int inventorProp = 20;

        private void Awake()
        {
            inventorWater = 7;
            inventorProp = 15;
            Debug.Log($"<color=#f31>�Ĥ� : {inventorWater}</color>");
            Debug.Log($"<color=#f31>�D�� : {inventorProp}</color>");

        }
    }

}
