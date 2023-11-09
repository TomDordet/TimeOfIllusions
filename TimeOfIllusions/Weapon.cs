using System;

namespace TimeOfIllusions
{
    public class Weapon
    {
        private string name;
        private int minAttack;
        private int maxAttack;
        private int nbAttackPerTurn;
        private bool isEquipped;

        public Weapon(int minAttack, int maxAttack, int nbAttackPerTurn)
        {
            Random random = new Random();
            int indexNameOfWeapon = random.Next(weaponNames.Length);
            this.name = weaponNames[indexNameOfWeapon];
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.nbAttackPerTurn = nbAttackPerTurn;
            this.isEquipped = false;
        }
        
        public Weapon(string name, int minAttack, int maxAttack, int nbAttackPerTurn, bool isEquipped)
        {
            this.name = name;
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.nbAttackPerTurn = nbAttackPerTurn;
            this.isEquipped = isEquipped;
        }

        public void DisplayWeapon()
        {
            string equipped;
            equipped = this.isEquipped == true ? "(Equipped)" : "";
            Console.WriteLine("Weapon - {0} - (damage: {1}-{2}, attack per turn: {3})  {4}", this.name, this.minAttack, this.maxAttack, this.nbAttackPerTurn, equipped);
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int MinAttack
        {
            get => this.minAttack;
            set => this.minAttack = value;
        }

        public int MaxAttack
        {
            get => this.maxAttack;
            set => this.maxAttack = value;
        }

        public int NbAttackPerTurn
        {
            get => this.nbAttackPerTurn;
            set => this.nbAttackPerTurn = value;
        }

        public bool IsEquiped
        {
            get => this.isEquipped;
            set => this.isEquipped = value;
        }
        
        string[] weaponNames = {
            "Épée de feu",
            "Arc de Glace",
            "Lance des Ombres",
            "Katana Enchanté",
            "Couteau Empoisonné",
            "Bâton de Foudre",
            "Hache de Guerre en Fer",
            "Marteau de Tonnerre",
            "Fléau de Poison",
            "Dague de l'Ombre",
            "Épée de Cristal",
            "Arc Céleste",
            "Lance du Dragon",
            "Katana de l'Aube",
            "Poignard de l'Empereur",
            "Bâton de Sagesse",
            "Hache de Lave",
            "Marteau de Givre",
            "Fléau de la Nuit",
            "Dague des Abysses",
            "Épée de l'Aigle",
            "Arc de la Lune",
            "Lance de l'Étoile Filante",
            "Katana de la Tempête",
            "Couteau du Chaos",
            "Bâton des Anciens",
            "Hache de la Foudre",
            "Marteau du Géant",
            "Fléau du Démon",
            "Dague des Ténèbres",
            "Épée du Paladin",
            "Arc du Chasseur",
            "Lance de la Justice",
            "Katana du Maître",
            "Couteau du Voleur",
            "Bâton du Mage",
            "Hache de l'Inferno",
            "Marteau de la Colère",
            "Fléau de la Pestilence",
            "Dague du Bandit",
            "Épée de la Vengeance",
            "Arc de la Discorde",
            "Lance de la Ruine",
            "Katana de l'Honneur",
            "Couteau de l'Assassin",
            "Bâton de l'Illumination",
            "Hache de la Terreur",
            "Marteau du Jugement",
            "Fléau de la Rédemption",
            "Dague du Repentir"
        };
    }
}