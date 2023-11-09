using System;
using System.Threading.Channels;

namespace TimeOfIllusions
{
    class Program
    {
        static void Main(string[] args)
        {


            void displayInventory(Player player)
            {
                Console.WriteLine("-------INVENTAIRE-------");
                Console.WriteLine("1. Armes");
                Console.WriteLine("2. Armures");
                Console.WriteLine("3. Potions");
                Console.WriteLine("------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (Weapon weapon in player.Weapons)
                        {
                            int nb = 1;
                            Console.Write("{0} - ", nb);
                            weapon.DisplayWeapon();
                        }
                        break;
                    case 2:
                        foreach (Armor armor in player.Armors)
                        {
                            int nb = 1;
                            Console.Write("{0} - ", nb);
                            armor.DisplayArmor();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Potions coming soon!");
                        break;
                }
            }
            
            
            
            Player player = new Player();
            
            LimitedList<Weapon> checkWeapons = new LimitedList<Weapon>(player.Weapons, 5);
            LimitedList<Armor> checkArmors = new LimitedList<Armor>(player.Armors, 5);
            LimitedList<Potion> checkPotions = new LimitedList<Potion>(player.Potions, 5);

            player.Weapons = checkWeapons.AddItem(new Weapon(99, 105, 3));
            player.Armors = checkArmors.AddItem(new Armor(5));
            player.Weapons = checkWeapons.AddItem(new Weapon(2, 6, 1));
            player.Armors = checkArmors.AddItem(new Armor(3));

            displayInventory(player);
        }
    }
}