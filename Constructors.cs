using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyirstConsole
{
    class Constructors
    {
    }
    //class Team //Default Constructors
    //{

    //    int num;
    //    string name;


    //    Team()
    //    {
    //        Console.WriteLine("Constructor Called");
    //    }
    //    public static void Main()
    //    {


    //        Team t1 = new Team();


    //        Console.WriteLine(t1.name);
    //        Console.WriteLine(t1.num);

    //        Console.ReadLine();
    //    }
    //}
    //class Student  //Parameterized Constructors
    //{


    //    String name;
    //    int id;


    //   public Student(String name, int id)
    //    {
    //        this.name = name;
    //        this.id = id;
    //    }

    //    public void getData()
    //    {
    //        Console.WriteLine("Student Name is: {0} ", name);
    //        Console.WriteLine("Student ID is: {0} ", id);
    //    }
    //    public static void Main()
    //    {


    //        Student st1 = new Student("Tony",20);
    //        st1.getData();


    //        Console.ReadLine();

    //    }
    //}

    class Student  //Parameterized Constructors
    {


        String Fname;
        String Lname;
        int age;
        int id;
        char gender;


        public Student(String Fname,String Lname, int id,int age,char gender)
        {
            Console.WriteLine("Parameterized Constructor");
            this.Fname = Fname;
            this.Lname = Lname;
            this.age = age;
            this.id = id;
            this.gender = gender;
            
        }

        public Student(Student s)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Copy Constructor");
            this.Fname = s.Fname;
            this.Lname =s.Lname;
            this.age = s.age;
            this.id = s.id;
            this.gender = s.gender;
          }

        public void getData()
        {
            Console.WriteLine("Student First Name is: {0} ", Fname);
            Console.WriteLine("Student Last Name is: {0} ", Lname);
            Console.WriteLine("Student age is: {0} ", age);
            Console.WriteLine("Student ID is: {0} ", id);
            Console.WriteLine("Student Gender is: {0} ", gender);
        }
        public static void Main()
        {


            Student st1 = new Student("Tony","Stark",23,1101,'M');
            st1.getData();
            Student st2 = new Student(st1);
            st2.getData();


            Console.ReadLine();

        }
    }

}
