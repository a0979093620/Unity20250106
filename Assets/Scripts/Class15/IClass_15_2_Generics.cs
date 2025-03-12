namespace lotta_15
{
    public interface IClass_15_2_Generics
    {
        void Swap<T>(ref T a, ref T b);
        void SwapChar(ref char a, ref char b);
        void SwapNumber(ref int a, ref int b);
        void SwapObject(ref object a, ref object b);
    }
}