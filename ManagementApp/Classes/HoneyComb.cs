using ManagementApp.Enums;
using ManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ManagementApp.Classes
{
    public class HoneyComb
    {
        private int idSeeder = 10;
        private int id;
        private int numberOfCells;

        private List<BeeType> acceptedBeeTypes = new List<BeeType>();


        public HoneyComb(int numberOfCells, List<BeeType> acceptedBeeTypes)
        {
            this.numberOfCells = numberOfCells;
            this.acceptedBeeTypes = acceptedBeeTypes;
        }


        public HoneyComb(int numberOfCells, BeeType acceptedBeeTypes)
        {
            this.numberOfCells = numberOfCells;
            this.acceptedBeeTypes.Add(acceptedBeeTypes);
        }


        public int GetNumberOfVacantCells(BeeType beeType)
        {
            return this.numberOfCells;
        }

        public bool AddGuest(BeeGroup beeGroup)
        {
            return true;
        }


        public string GetInfo()
        {
            string infoText = $"{id} , {numberOfCells}";

            return infoText;
        }


    }
}
