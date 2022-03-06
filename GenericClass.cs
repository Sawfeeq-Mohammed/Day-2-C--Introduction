using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyirstConsole
{
    class GenericClass
    {
    }
    //public class Myclass<T>
    //{
    //    public void Compare(T v1, T v2)
    //    {
    //        if (v1.Equals(v2))
    //        {
    //            Console.Write("The value is matching");
    //        }
    //        else
    //        {
    //            Console.Write("The value is not matching");
    //        }
    //    }
    //}

    //class Programs
    //{
    //    static void Main(string[] args)
    //    {
    //        Myclass<string> obj = new Myclass<string>();
    //        obj.Compare("Amit", "Amit");
    //        Console.ReadLine();

    //    }
    //}
    //public class ClsMain
    //{
    //    private static void Main()
    //    {
    //        bool IsEqual = CCalc.IsEqual(100, 50);
    //        bool IsEqual1 = CCalc.IsEqual("book", "book");
    //        bool IsEqual2 = CCalc.IsEqual('A', 'A');
    //        if (IsEqual)
    //        {
    //            Console.WriteLine("Both are Equal");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Both are Not Equal");
    //        }
    //        if (IsEqual1)
    //        {
    //            Console.WriteLine("Both are Equal");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Both are Not Equal");
    //        }
    //        if (IsEqual2)
    //        {
    //            Console.WriteLine("Both are Equal");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Both are Not Equal");
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //public class CCalc
    //{

    //    public static bool IsEqual(object val1, object val2)//object reference
    //    {
    //        return val1 == val2;
    //    }
    //}
    class CompareClass
    {
        public bool Compare(string x, string y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
        public bool Compare(int x, int y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
    }
    class CompareGenericClass<T>
    {
        public bool Compare(T x, T y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
    }
    class GeneMain
    {
        static void Main(string[] args)
        {
            CompareClass obj = new CompareClass();
            bool intresult = obj.Compare(5, 7);
            Console.WriteLine("int compare result:" + intresult);
            bool stringresult = obj.Compare("DEVESH", "DEVESH");
            Console.WriteLine("string compare result:" + stringresult);
            CompareGenericClass<string> Ocompare = new CompareGenericClass<string>();
            bool stringResult = Ocompare.Compare("DEVESH", "DEVESH");
            Console.WriteLine("Generic string compare result:" + stringResult);
            CompareGenericClass<int> oIntcompare = new CompareGenericClass<int>();
            bool integerresult = oIntcompare.Compare(5, 6);
            Console.WriteLine("Generic int compare result:" + integerresult);

            Console.ReadKey();
        }
    }
}
