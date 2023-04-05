using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    //public class Student
    //{
    //    //attributes
    //    public int id;
    //    public string name;

    //    //constructor
    //    public  Student(int id,string name)
    //    {
    //       this. id = id;
    //        this. name =name ;
    //    }
    //    //method
    //    public virtual string Display()
    //    {
    //        return $" name is {name} and id is {id}";
    //    }







    //}
    //public class Engstudent : Student
    //{
    //    public int age;

    //    public Engstudent (int id, string name,int age) :base(id,name)
    //    {
    //        this.age = age;
    //    }

    //    public override string Display()
    //    {
    //        return $" name is {name} and id is {id} and age is {age}";
    //    }
    //}


    //public class Student
    //{
    //    private int id;
    //    private string name;

    //    //property

    //    public int Id
    //    {
    //        set { id = value; }
    //        get { return id; }

    //    }


    //    public string Name
    //    {
    //        set { name = value; }
    //        get { return name; }
    //    }

    public class Calculation
    {
        //method overrloading
    public int Addition(int a,int b)
        {
            return a + b;
        }
        public int Addition(int a, int b,int c)
        {
            return a + b + c;
        }




    }


    public class Program
        {
            static void Main(string[] args)
            {
            //Student s = new Student(1,"Jack");
            //Console.WriteLine(s.Display());

            //Engstudent e = new Engstudent(1,"Paro",18);
            //Console.WriteLine(e.Display());
            //Student s = new Student();
            //s.Id = 1;
            //s.Name = "Piyush";
            //Console.WriteLine(s.name);
            Calculation c = new Calculation();
            Console.WriteLine(   c.Addition(1, 2, 3));
            }
        }
    }

