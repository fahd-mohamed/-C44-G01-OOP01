using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct Phonebook
    {

        string[] names;
        long[] numbers;

        public Phonebook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }


        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }


                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
        }

        public string this[long number]
        {
            get {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return names[i];
                    }
                }


                return "";
            }
            set {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                    }
                }
            }
        public void AddPerson(string name , long Number ,int index)
        {
            names[index] = name;
            numbers[index] = Number;
        
        }


        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }


            return -1;

        }

        public void UpdateNumber(String name , long newnumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                     numbers[i] = newnumber;
                }
            }

        }







        public string GetName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return names[i];
                }
            }


            return "";

        }

        public void UpdateName(long number, string newname)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    names[i] = newname;
                }
            }

        }




    }
}
