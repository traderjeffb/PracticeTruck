using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TruckPractice
{
    public enum TruckType
    {
        LongBed,
        ShortBed,
        MidSize,
    }
    public enum Towing
    {
        LightDuty,
        HeavyDUty,
        SuperHeavyDuty
    }
    class Trucks
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public Towing Towing { get; set; }
        public bool CanTowEquipment
        {
            get
            {
                switch (Towing)
                {
                    case Towing.HeavyDUty:
                    case Towing.SuperHeavyDuty:
                        return true;
                    case Towing.LightDuty:
                    default:
                        return false;
                }
            }
        }
        public TruckType TypeOfTruck { get; set; }
        public Trucks() { }
        public Trucks(TruckType typeOfTruck, int year, string color, Towing towing)
        {
            TypeOfTruck = typeOfTruck;//I don't understand this naming
            Year = year;
            Color = color;
            Towing = towing;

        }
    }
       
}
