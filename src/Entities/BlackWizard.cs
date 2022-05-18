namespace Jogo_RPG___POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public const int HP_BLACKWIZARD = 5000;
        public BlackWizard(string name, int level, string heroType) : base(name, level,heroType, HP_BLACKWIZARD)
        {
            
        }

        public override string Attack()
        {
            this.valueDamage = this.RandomDamage();

            if (this.hp <= 1500)
            {
                this.valueDamage *= 5;
                return this.name + " foi consumido pela escuridão(seu dano foi multiplicado por 5) e causou " + this.valueDamage + " de dano no inimigo";
            }

            return this.name + " lançou uma magia negra e infligiu " + this.valueDamage + " de dano no inimigo";

        }
    }
}