using System.Data.SqlTypes;
using System.Threading.Channels;

namespace OOP1
{


    //class 
    //Struct
    //Interfacde 
    //Enum



    internal class Program
    {


        

        static void Main(string[] args)
        {
            Console.WriteLine("V01");
            #region Struct
            ////struct : Value Type : STACK  

            ////Employee
            ////ID , Name ,Salary 

            ////Point 

            //// Point P01;
            ////Declare For Object From Type 'Point'
            ////P01: Object 
            ////allocate Uninitialized 8 Bytes at Stack
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);
            ////P01.X = 12;
            ////P01.Y = 12;
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////  P01 = new Point(1,2 );
            ////new : Used for Select The Constructor


            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);
            ////  Console.WriteLine(P01);
            ////Console.WriteLine();

            ////P01.PrintPoint();

            ////  Console.WriteLine(P01); 
            ///

            // Point[] points = new Point[10];



            #endregion

            Console.WriteLine("V02");
            #region OOP Overview
            ////OOP : Object Oriented Programming
            //// Programming Paradigm
            ////OOP : The  Paradigm Use The Build Any Business

            ////class : Blueprint of the object
            ////Object : Specific Instance of Class 

            ////4. Pillars
            ////===================
            ////1. Encapsulation 
            ////2. Inheritance
            ////3. Polymorphism
            ////4. Abstraction 
            #endregion
            Console.WriteLine("V03");

            #region Apply Encapsulation User Setter Getter Method
            ////1. Encapsulation
            ////Class Or Struct
            //// Separate The Data(Attributes)Defention  Fromits Use 
            ////[Setter Geter Method - Properties]


            ////Empiloyee
            ////Id , Name , Salary 
            ////1.End User Access Data Itself
            ////2. No Data Validation 
            ////3. Read Only Filed 

            //// Appiy Encapsulation 
            //// 1. Make All Data (Attributes) Private 
            //// 2. Access Data Througe : 
            //    //2.1 Setters and Getters Method 
            //    //2,2 Properties


            //Employee E01 = new Employee();
            //Console.WriteLine(E01);

            ////ID Read Only  Attributes



            ////E01.ID = 1;
            ////E01.Name = "Ahmed";
            ////E01.Salary = 12000;

            ////Console.WriteLine(E01.ID);
            ////Console.WriteLine(E01.Name);
            ////Console.WriteLine(E01.Salary);

            ////E01.SetID(1);
            ////E01.setName("Ahmed");
            ////E01.SetSalary(12000);

            ////Console.WriteLine(E01.GetID());
            ////Console.WriteLine(E01.GetSalary());
            ////Console.WriteLine(E01.GetName());


            #endregion

        }
    }
}

