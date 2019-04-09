using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {





            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building pizzaPlace = new Building("650 North Avenue");
            Building bigBuilding = new Building("20th big street");
            Building sixOneFive = new Building("615 10th Avenue");

            FiveOneTwoEigth.Width = 4000;
            FiveOneTwoEigth.Height = 6000;
            FiveOneTwoEigth.Stories = 4;

            pizzaPlace.Width = 1200;
            pizzaPlace.Height = 2000;
            pizzaPlace.Stories = 1;

            bigBuilding.Width = 9000;
            bigBuilding.Height = 6000;
            bigBuilding.Stories = 12;

            sixOneFive.Width = 4000;
            sixOneFive.Height = 6000;
            sixOneFive.Stories = 4;


            FiveOneTwoEigth.Construct();
            pizzaPlace.Construct();
            bigBuilding.Construct();
            sixOneFive.Construct();

            FiveOneTwoEigth.Purchase("dom");
            pizzaPlace.Purchase("sam");
            bigBuilding.Purchase("con");
            sixOneFive.Purchase("abb");

            City bigCity = new City("New york");
            City littleCity = new City("Montgomery");

            bigCity.AddBuilding(FiveOneTwoEigth);
            bigCity.AddBuilding(bigBuilding);

            littleCity.AddBuilding(pizzaPlace);
            littleCity.AddBuilding(sixOneFive);



            bigCity.DisplayBuildings();
            littleCity.DisplayBuildings();
































        }
    }
}
