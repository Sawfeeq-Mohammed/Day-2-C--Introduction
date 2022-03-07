using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyirstConsole
{
   public  class Abstract
    {
        public void Main(string[] args)
        {
            Amazon e;
            e = new Elecronics();
            Console.WriteLine(e.Name = "JBL");
            e.Display();
            e.Product("Headset", 400);

            e = new HomeAppliances();
            Console.WriteLine(e.Name = "Bosch");
            e.Display();
            e.Product("Washing Machine", 15000);

            Console.ReadLine();
        }
    }


    public abstract class Amazon
    {
        public abstract void Display();
        protected String name;
        public abstract String Name
        {
            get;
            set;
        }
        public abstract void Product(String s, int x);
    }



    public class Elecronics : Amazon
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public override void Display()
        {
            Console.WriteLine("Electronics Product: ");
        }
        public override void Product(string s, int x)
        {
            Console.WriteLine("The ordered electronics product is: {0} and its price is: {1}" + s, x);

        }
    }

    public class HomeAppliances : Amazon
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public override void Display()
        {
            Console.WriteLine("Home Aplliances Product: ");
        }
        public override void Product(string s, int x)
        {
            Console.WriteLine("The ordered electronics product is: {0} and its price is: {1}" + s, x);

        }
    }

        
    
}
