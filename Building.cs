using System;

namespace Planner
{
    class Building
    {


        private string _designer = "domininc";

        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }

        private string _owner { get; set; }



        public int Stories { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
        public double Volume
        {
            get
            {
                return Width * Height * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }


        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void DisplayBuilding(){
            Console.WriteLine($@"

 {_address}
-------------- -
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
 {Volume} cubic meters of space
            ");
        }
    }
}