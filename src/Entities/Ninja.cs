namespace Jogo_RPG___POO.src.Entities
{
    public class Ninja : Hero
    {
        private const int HP_NINJA = 8000;
        public Ninja(string name, int level, string heroType) : base (name, level, heroType, HP_NINJA)
        {
            
        }

        public override string Attack()
        {
            this.valueDamage = this.RandomDamage();

            if (this.valueDamage >= 60)
            {
                this.valueDamage *= 3;
                return this.name + " lançou 4 shuriken(seu dano foi multiplicado por 3) e causou " + this.valueDamage + " de dano no inimigo";
            }

            this.valueDamage += 30;
            return this.name + " lançou 2 shuriken(concede 30 de dano adicional) e infligiu " + this.valueDamage + " de dano no inimigo";

        }
    }
}