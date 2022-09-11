using ManagementApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagementApp.Classes
{
    public class BeeGroup
    {
        private string name;
        private BeeType beeType;
        public int numberOfBees;


        public BeeGroup(string name, BeeType beeType)
        {
           this.name = name;
           this.beeType = beeType;
        }


        public string GetInfo()
        {
            string InfoText = $" this beegroup name is {name}, the type of bee is {beeType} and the amount of bees is {numberOfBees}";
            return InfoText;

        }


    }
}
