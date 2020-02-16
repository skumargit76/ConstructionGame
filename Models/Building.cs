using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGame.Models
{
    //define properties/objec of buildings items
    class BaseBuilding
    {
        public List<string> Kitchen = new List<string>();
        public List<string> BedRoom = new List<string>();
        public List<string> Balcony = new List<string>();
        public string BuildingItems = "";

        //Show the items
        public string Describe()
        {            
            return BuildingItems.Trim().TrimEnd(',');
        }
        //reset properties 
        public void ClearBuildingItems()
        {
            this.Kitchen.Clear();
            this.BedRoom.Clear();
            this.Balcony.Clear();
        }

    }
    class Building
    {

        private BaseBuilding mainObj = new BaseBuilding();
        //Add Kitchen
        public Building AddKitchen()
        {            
            mainObj.Kitchen.Add("Kitchen");
            return this;
        }
        //Add Bedroom
        public Building AddBedroom(string roomType)
        {
            //mainObj.BedRoom  = roomType + " room";
            mainObj.BedRoom.Add(roomType + " room");
            return this;
        }
        //Add Balcony
        public Building AddBalcony()
        {
            //mainObj.Balcony  = "Balcony";
            mainObj.Balcony.Add("Balcony");
            return this;
        }

        // Build
        public BaseBuilding Build()
        {
            //Check item already there or not
            if (mainObj.BuildingItems.Length > 0) { mainObj.BuildingItems += ", "; }
            mainObj.BuildingItems += String.Join(",", mainObj.Kitchen) + ", " + String.Join(", ", mainObj.BedRoom) + ", " + String.Join(", ", mainObj.Balcony);
            //reset properties
            mainObj.ClearBuildingItems();
            //return
            return mainObj;
        }

    }
}
