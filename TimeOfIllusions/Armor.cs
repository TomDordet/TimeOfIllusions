using System;

namespace TimeOfIllusions
{
    public class Armor
    {
        private string name;
        private int defense;
        private bool isEquipped;
        
        public Armor(int defense)
        {
            Random random = new Random();
            int indexNameOfArmor = random.Next(armorNames.Length);
            this.name = armorNames[indexNameOfArmor];
            this.defense = defense;
            this.isEquipped = false;
        }
        
        public Armor(string name, int defense, bool isEquipped)
        {
            this.name = name;
            this.defense = defense;
            this.isEquipped = isEquipped;
        }
        
        public void DisplayArmor()
        {
            string equipped;
            equipped = this.isEquipped == true ? "(Equipped)" : "";
            Console.WriteLine("Armor - {0} - (defense: {1})  {2}", this.name, this.defense, equipped);
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
            get => isEquipped;
            set => isEquipped = value;
        }
        
        string[] armorNames = {
            "Armure de Cuir",
            "Armure de Mailles",
            "Armure de Fer",
            "Armure de Bois",
            "Armure des Abysses",
            "Armure du Crépuscule",
            "Armure de la Nuit",
            "Armure de l'Aube",
            "Armure de Pierre",
            "Armure de Bronze",
            "Armure de Marbre",
            "Armure d'Acier",
            "Armure du Désert",
            "Armure de Glace",
            "Armure de Feu",
            "Armure de Vent",
            "Armure de l'Océan",
            "Armure du Ciel",
            "Armure de la Jungle",
            "Armure des Montagnes",
            "Armure des Sables Mouvants",
            "Armure des Plaines",
            "Armure de la Toundra",
            "Armure de la Forêt",
            "Armure de la Caverne",
            "Armure du Volcan",
            "Armure du Canyon",
            "Armure de l'Éclair",
            "Armure de la Tempête",
            "Armure de la Foudre",
            "Armure de l'Orage",
            "Armure de l'Étoile",
            "Armure du Cosmos",
            "Armure du Vide",
            "Armure des Éléments",
            "Armure de la Terre",
            "Armure de l'Eau",
            "Armure du Feu Sacré",
            "Armure de la Lave",
            "Armure de l'Ancien",
            "Armure du Gardien",
            "Armure du Protecteur",
            "Armure du Destin",
            "Armure de l'Espoir",
            "Armure de la Sagesse",
            "Armure de la Discrétion",
            "Armure du Courage",
            "Armure de la Résilience",
            "Armure de l'Honneur",
            "Armure de la Victoire"
        };

    }
}