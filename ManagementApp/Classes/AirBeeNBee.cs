using ManagementApp.Enums;
using ManagementApp.Classes;
using System;
using System.Collections.Generic;

namespace ManagementApp
{
    public class AirBeeNBee
    {
        private string name;

        private int indexDictionaryBeeGroup = 1;
        private int indexDictionaryhoneyCombs = 1;

        private List<BeeGroup> allBeeGroups = new List<BeeGroup>();
        private List<HoneyComb> allHoneyCombs = new List<HoneyComb>();


        public List<BeeGroup> AllBeeGroups { get { return allBeeGroups; }}
        public List<HoneyComb> AllHoneyCombs{ get { return  allHoneyCombs; }}

        /// <summary>
        /// sets the field name when the objects is instantiate 
        /// </summary>
        /// <param name="name"></param>
        public AirBeeNBee(string name)
        {
            this.name = name;

            AddHoneycombTestData();
            AddCustomerTestData();
        }

        public void AddHoneycombTestData()
        {
            AddHoneycomb(400, new List<BeeType>() { BeeType.HOUSEKEEPER, BeeType.NECTARGATHERER });
            AddHoneycomb(50, BeeType.GUARD);
            AddHoneycomb(1, BeeType.QUEEN);
            AddHoneycomb(300, BeeType.DRONE);
            AddHoneycomb(400, new List<BeeType>() { BeeType.HOUSEKEEPER, BeeType.GUARD });
            AddHoneycomb(200, BeeType.HOUSEKEEPER);
            AddHoneycomb(200, BeeType.NECTARGATHERER);
            AddHoneycomb(25, new List<BeeType>() { BeeType.GUARD, BeeType.DRONE });
            AddHoneycomb(1, BeeType.QUEEN);
        }

        public void AddCustomerTestData()
        {
            AddCustomer("The cleaners", BeeType.HOUSEKEEPER);
            AddCustomer("Drones R Us", BeeType.DRONE);
            AddCustomer("Somebody to love", BeeType.QUEEN);
            AddCustomer("Oh Beehave", BeeType.GUARD);
            AddCustomer("Defenders of the Earth", BeeType.GUARD);
        }

     
        public void AddCustomer(string name, BeeType beetype)
        {
            BeeGroup newBeeGroup = new BeeGroup(name, beetype); 
            allBeeGroups.Add(newBeeGroup);
        }

        public void AddHoneycomb(int numberOfCels, BeeType acceptedBeeType)
        {
            HoneyComb newHoneyComb = new HoneyComb(numberOfCels, acceptedBeeType);
            allHoneyCombs.Add(newHoneyComb);
        }

        public void AddHoneycomb(int numberOfCels, List<BeeType> acceptedBeeType)
        {
           HoneyComb newHoneyComb = new HoneyComb(numberOfCels, acceptedBeeType);
           allHoneyCombs.Add(newHoneyComb);

        }

        public bool TryCreateBooking(BeeGroup beeGroup)
        {
            return false;
        }




    }
}
