namespace Jogo_RPG___POO.src.Entities
{
    public class Wizard : Hero
    {
        private const int HP_WIZARD = 6000;

        public Wizard(string name, int level, string heroType) : base(name, level, heroType, HP_WIZARD)
        {

        }

        public override string Attack()
        {
            this.valueDamage = this.RandomDamage();

            if (this.valueDamage >= 55)
            {
                this.valueDamage *= 2;
                return this.name + " recebeu a benção da Luz(seu dano foi multiplicado por 2) e causou " + this.valueDamage + " de dano no inimigo";
            }

            return this.name + " lançou uma magia e infligiu " + this.valueDamage + " de dano no inimigo";

        }
    }
}