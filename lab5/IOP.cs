namespace Lab4Solution
{
    public interface IOP<T>
    {
        T Add(T a, T b); 
    }

    class abc : IOP<int>, IOP<float> ,IOP<string> , IComparable<abc>
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public float Add(float a, float b)
        {
            throw new NotImplementedException();
        }

        public string Add(string a, string b)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(abc? other)
        {
            return 1;
            //throw new NotImplementedException();
        }
    } 

}