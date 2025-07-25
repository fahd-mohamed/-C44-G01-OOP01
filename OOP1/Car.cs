using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Car
    {
		// Id
		#region Attribute
		private int id;
		private int speed;
		private string model;

		#endregion

		#region Properties
		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}



		public int ID
		{
			get { return id; }
			set { id = value; }
		}
        #endregion
        //public string  Address { get; set; } PROP

        //CLR Will Generate Parameterless Constructor 
        // This Constructor Do Nothing

        //CTOR

        public Car(int id , int speed , string model):this(id,speed)
        {
            ID = id;
			Speed = speed;
			Model = model;
        } 

		public Car(int id , int speed) :base(id)
        {
           // ID = id;
			Speed = speed;
			 
        }


        public override string ToString()
        {
            return $"Id : {ID} :: Speed :  {Speed} ::  Model : {Model}" ;
        }


    }
}
