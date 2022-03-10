using System;

namespace Bibliotecaejercicios
{
    public class Spell
    {
        private string name;
        private string description;
        private int power_consumption;
        private type stype;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Power_consumption
        {
            get { return power_consumption; }
            set { power_consumption = value; }
        }
        public type GetType
        {
            get { return stype; }
            set { stype = value; }
        }
        public enum type
        {
            FIRE,
            PLANT,
            WATER
        }
        public Spell(string Name, string Description, int Power_consumption, type GetType)
        {
            name = Name;
            description = Description;
            power_consumption = Power_consumption;
            stype = GetType;
        }
    }
}
