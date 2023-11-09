using System.Collections.Generic;

namespace TimeOfIllusions
{
    public class Player
    {
        private int health;
        private int currentHealth;
        private int minAttack;
        private int maxAttack;
        private int defense;

        private List<Weapon> _weapons = new List<Weapon>();
        private List<Armor> _armors = new List<Armor>();
        private List<Potion> _potions = new List<Potion>();
        
        
        public Player()
        {
            this.health = 100;
            this.currentHealth = this.health;
            this._weapons.Add(new Weapon("Baton en bois", 1, 5, 1, true));
            this._armors.Add(new Armor("Vêtement simple", 4, true));
            this.minAttack = _weapons[0].MinAttack;
            this.maxAttack = _weapons[0].MaxAttack;
            this.defense = _armors[0].Defense;
            
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int CurrentHealth
        {
            get => currentHealth;
            set => currentHealth = value;
        }

        public int MinAttack
        {
            get => minAttack;
            set => minAttack = value;
        }

        public int MaxAttack
        {
            get => maxAttack;
            set => maxAttack = value;
        }

        public int Defense
        {
            get => defense;
            set => defense = value;
        }

        public List<Weapon> Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        public List<Armor> Armors
        {
            get { return _armors; }
            set { _armors = value; }
        }

        public List<Potion> Potions
        {
            get { return _potions; }
            set { _potions = value; }
        }
        
        
    }
}