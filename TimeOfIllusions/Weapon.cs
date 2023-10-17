using System;

namespace TimeOfIllusions
{
    public class Weapon
    {
        private string name;
        private int minAttack;
        private int maxAttack;
        private int nbAttackPerTurn;
        private bool isEquiped;

        public Weapon(string name, int minAttack, int maxAttack, int nbAttackPerTurn, bool isEquiped)
        {
            this.name = name;
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.nbAttackPerTurn = nbAttackPerTurn;
            this.isEquiped = isEquiped;
        }

        public void DisplayWeapon()
        {
            string equiped;
            equiped = isEquiped == true ? "(Equiped)" : "";
            Console.WriteLine("{0} - (attack per turn: {1}, damage: {2}-{3})  {4}", this.name, this.nbAttackPerTurn, this.minAttack, this.maxAttack, equiped);
        }

        public string Name
        {
            get => name;
            set => name = value;
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

        public int NbAttackPerTurn
        {
            get => nbAttackPerTurn;
            set => nbAttackPerTurn = value;
        }

        public bool IsEquiped
        {
            get => isEquiped;
            set => isEquiped = value;
        }
    }
}