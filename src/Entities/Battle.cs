namespace Jogo_RPG___POO.src.Entities
{
    public class Battle
    {
        public Hero HeroOne { get; set; }
        public Hero HeroTwo { get; set; }

        public Battle(Hero heroOne, Hero heroTwo)
        {
            this.HeroOne = heroOne;
            this.HeroTwo = heroTwo;
        }

        public void InicializationBattle()
        {
            var numberRandom = new Random();
            var firstAttack = numberRandom.Next(1, 2);

            Console.WriteLine("Batalha Iniciada \n");
            Console.WriteLine($@"{HeroOne.name}, Nv. {HeroOne.level}   {HeroOne.heroType}   VS   {HeroTwo.name}, Nv. {HeroTwo.level}   {HeroTwo.heroType}");

            while (HeroOne.hp > 0 && HeroTwo.hp > 0)
            {
                if (firstAttack == 1)
                {
                    AttackHeroOne();
                    if (HeroTwo.hp <= 0)
                    {
                        Console.WriteLine($"{HeroTwo.name} morreu");
                        Console.WriteLine($"Quem venceu foi: {HeroOne.name}");
                        break;
                    }
                    AttackHeroTwo();
                    if (HeroOne.hp <= 0)
                    {
                        Console.WriteLine($"{HeroOne.name} morreu");
                        Console.WriteLine($"Quem venceu foi: {HeroTwo.name}");
                        break;
                    }

                    continue;
                }

                AttackHeroTwo();
                if (HeroOne.hp <= 0)
                {
                    Console.WriteLine($"{HeroOne.name} morreu ");
                    Console.WriteLine($"Quem venceu foi: {HeroTwo.name}");
                    break;
                }
                AttackHeroOne();
                if (HeroTwo.hp <= 0)
                {
                    Console.WriteLine($"{HeroTwo.name} morreu ");
                    Console.WriteLine($"Quem venceu foi: {HeroOne.name}");
                    break;
                }

            }

            Console.WriteLine($"\nA batalha foi finalizada");

        }

        private void AttackHeroOne()
        {
            Console.WriteLine("");
            var damage = 0;
            Console.WriteLine(HeroOne.Attack());
            damage = HeroOne.valueDamage;
            HeroTwo.hp -= damage;
            Console.WriteLine($"{HeroTwo.name} sofreu um ataque de {damage} e ficou com {HeroTwo.hp} de vida\n");
        }
        private void AttackHeroTwo()
        {
            Console.WriteLine("");
            var damage = 0;
            Console.WriteLine(HeroTwo.Attack());
            damage = HeroTwo.valueDamage;
            HeroOne.hp -= damage;
            Console.WriteLine($"{HeroOne.name} sofreu um ataque de {damage} e ficou com {HeroOne.hp} de vida\n");
        }
    }
}