//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyirstConsole
//{
//    internal class ParamArray
//    {

//        public int Addvalues(params int[] arr)
//        {
//            int sum = 0;

//            foreach (int i in arr)
//            {
//                sum += i;
//            }
//            return sum;
//        }
//    }

//    class Run
//    {
//        static void Main(string[] args)
//        {
//            ParamArray app = new ParamArray();
//            int sum = app.Addvalues(10, 23, 83, 77, 65);

//            Console.WriteLine("The sum is: {0}", sum);
//            Console.ReadKey();


//        }

//    }
//}


