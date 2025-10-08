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
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> l1 = new List<string> { "osama", "aly", "Khalid", "Nage", "Sami", "Amir", "Ahmed" };

            ////Using Static class
            //var result = ListExtension.FindTemp(l1, a => a.Length > 3);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //Using Extension Method

            Console.WriteLine("Names with length > 3::");
            var result2 = l1.FindTemp(s=>s.Length>3);
            foreach(var i in result2) {  Console.WriteLine(i); }


            Console.WriteLine("\nNames Satarts with a ::");
            var result3 = l1.FindTemp(s => s.StartsWith('a') || s.StartsWith('A'));
            foreach(var i in result3) { Console.WriteLine(i); }


            Console.WriteLine("\nNames ends with e ::");
            var result4 = l1.FindTemp(s => s.EndsWith('e') || s.EndsWith('E'));
            foreach (var i in result4) { Console.WriteLine(i); }


            Console.WriteLine("\nNames Contains letter e ::");
            var result5 = l1.FindTemp(s => s.Contains('e') );
            foreach (var i in result5) { Console.WriteLine(i); }
        }

        //static void Main1(string[] args)
        //{
        //    //IOP<int> r1 = new abc();
        //    //r1.Add(10,20);

        //    abc[] arr = [new abc(), new abc()];
        //    Array.Sort(arr);
        //}

    }
}