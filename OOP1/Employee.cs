using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    #region Encapsulation
    internal struct Employee
    {

        private int ID;
        private string Name;
        private double Salary;
        private string Address;
        //Address

        //    //Apply Encapsulation User Setter Getter Method
        //    //Setter 

        //public void SetID(int id)
        //{
        //    this.ID = id;
        //}

        //public int GetID()
        //{
        //    return ID;
        //}
        //public void setName(string Name)
        //{
        //    this.Name = Name;
        //}

        //public string GetName()
        //{
        //    return Name;
        //}

        //public void SetSalary(double Salary)
        //{
        //    this.Salary = Salary;
        //}
        //public double GetSalary()
        //{
        //    return Salary;
        //}




        //public Employee(int id, String name, double salary)
        //{

        //    this.ID = id;
        //    this.Name = name;
        //    this.Salary = salary;

        //}

        //    public override string ToString()
        //    {
        //        return $"id {ID} :neme {Name} : Salary {Salary}";
        //        ;
        //    } 
        #endregion

        // Apply Encapsulation User Properties
        // 1. Full Property

        //id 
      

        public int ID
        {
             set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }


        //Name 
        public string Name
        {
            set
            {
                if (value.Length>= 8 && value.Length <= 20)
                name = Value;
              
             }

            get
            {
                return name;
            }
        }
        public double Salary
        {
            set { 
                if(value  > 0)
                    salary = Value;}
            get { return salary; }
        }







        // 2. Automatic Property


       // public string Address { set; get; }
        // 3. Special Property [Indexr]



        //    public Employee(int id, String name, double salary)
        //    {

        //        this.ID = id;
        //        this.Name = name;
        //        this.Salary = salary;

        //    }

        //    public override string ToString()
        //    {
        //        return $"id {ID} :neme {Name} : Salary {Salary}";
        //        ;
        //    } 
    }
}
