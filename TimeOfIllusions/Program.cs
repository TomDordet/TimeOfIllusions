using System;
using System.Threading.Channels;

namespace TimeOfIllusions
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            
            LimitedList<Weapon> checkWeapons = new LimitedList<Weapon>(player.Weapons, 5);
            LimitedList<Armor> checkArmors = new LimitedList<Armor>(player.Armors, 5);
            LimitedList<Potion> checkPotions = new LimitedList<Potion>(player.Potions, 5);

            player.Weapons = checkWeapons.AddItem(new Weapon("Epée cheaté", 99, 105, 3, true));
            player.Armors = checkArmors.AddItem(new Armor("Plastron de maille", 5, true));
            player.Weapons = checkWeapons.AddItem(new Weapon("Baton en bois", 2, 6, 1, false));
            player.Armors = checkArmors.AddItem(new Armor("Plaque de fer", 3, false));

            foreach (Weapon weapon in player.Weapons)
            {
                weapon.DisplayWeapon();
            }
            
            foreach (Armor armor in player.Armors)
            {
                armor.DisplayArmor();
            }
        }
    }
}