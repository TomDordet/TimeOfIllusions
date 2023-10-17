using System;

namespace TimeOfIllusions
{
    public class Armor
    {
        private string name;
        private int defense;
        private bool isEquiped;
        
        public Armor(string name, int defense, bool isEquiped)
        {
            this.name = name;
            this.defense = defense;
            this.isEquiped = isEquiped;
        }
        
        public void DisplayArmor()
        {
            string equiped;
            equiped = isEquiped == true ? "(Equiped)" : "";
            Console.WriteLine("{0} - (defense: {1})  {2}", this.name, this.defense, equiped);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Defense
        {
            get => defense;
            set => defense = value;
        }

        public bool IsEquiped
        {
            get => isEquiped;
            set => isEquiped = value;
        }
    }
}