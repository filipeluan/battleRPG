namespace Jogo_RPG___POO.src.Entities
{
    public class Warrior : Hero
    {
        private const int HP_WARRIOR = 10000;
        public Warrior(string name, int level, string heroType) : base(name, level, heroType, HP_WARRIOR)
        {

        }
        public override string Attack()
        {
            this.valueDamage = this.RandomDamage();

            if (this.hp <= 5000)
            {
                this.valueDamage += 150;
                return this.name + " se tornou um Berserk(ganho de 150 de dano a cada ataque) e infligiu " + this.valueDamage + " de dano";
            }

            return this.name + " Atacou com sua espada e causou " + this.valueDamage + " de dano";
        }
        
    }
}