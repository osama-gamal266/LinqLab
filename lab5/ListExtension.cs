/// <summary>
//////////////////////////// Example in Lecture///////////////////////////
/// </summary>

//namespace Lab3Solution
//{

//    static class ListExtension
//    {
//       public static List<int> FindTemp(this  List<int> l1, Func<int, bool> condition)
//        {
//            var res = new List<int>();
//            foreach (int i in l1)
//            {
//                if (condition.Invoke(i))
//                {
//                    res.Add(i);
//                }
//            }
//            return res;
//        }

//        public static void Print(this int z)
//        {
//            Console.WriteLine(z);
//        }

//    }

//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            List<int> l1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//            var result = ListExtension.FindTemp(l1, a => a % 2 != 0);
//            foreach (int i in result)
//            {
//                Console.WriteLine(i);
//            }


//            Console.WriteLine("=======");
//            var result2 = l1.FindTemp(a => a % 2 == 0);
//            foreach (int i in result2)
//            {
//                Console.WriteLine(i);
//            }

//            Console.WriteLine("=======");

//            int a = 20;
//            ListExtension.Print(a);
//            a.Print(); //Extenssion Method

//        }

//        //static void Main1(string[] args)
//        //{
//        //    //IOP<int> r1 = new abc();
//        //    //r1.Add(10,20);

//        //    abc[] arr = [new abc(), new abc()];
//        //    Array.Sort(arr);
//        //}

//    }
//}




/// <summary>
//////////////////////////// required in lab///////////////////////////
/// </summary>

namespace Lab4Solution
{
    static class ListExtension
    {
        public static List<string> FindTemp(this List<string> l1, Func<string, bool> condition)
        {
            var res = new List<string>();
            foreach (var i in l1)
            {
                if (condition.Invoke(i))
                {
                    res.Add(i);
                }
            }
            return res;
        }

        public static void Print(this int z)
        {
            Console.WriteLine(z);
        }

    }
}