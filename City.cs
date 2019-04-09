using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {

        private string _cityName;
        private List<Building> buildings = new List<Building>();



        public string Mayor { get; set; }
        public string Year { get; set; }

        public City(string cityName)
        {
            _cityName = cityName;
        }

        public void AddBuilding(Building building)
        {
            buildings.Add(building);
        }

        public void DisplayBuildings(){
            foreach(Building building in buildings){
                building.DisplayBuilding();
            }
        }
    }
}