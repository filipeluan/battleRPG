using System.Text;

namespace Jogo_RPG___POO.src.Entities
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public string heroType;
        public int hp;
        public int valueDamage;
        public Hero(string name, int level, string heroType, int hp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
        }

        public virtual string Attack()
        {
            this.valueDamage = RandomDamage();
            return this.name + " Atacou e causou " + this.valueDamage + " de dano";
        }
        protected int RandomDamage()
        {
            var numberRandom = new Random();
            return numberRandom.Next(0, 100);
        }
        
        public override string ToString()
        {
           return this.name + "\n Lv. " + this.level + "   " + this.heroType;
        }
    }
}