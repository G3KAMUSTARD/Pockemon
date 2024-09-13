using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pockemonnaumov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Select Pokemon: \n1) Gible \n2) Gabite \n3) Garchomp");
                    Console.Write("Write Pokemon number: ");
                    int select = int.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            {
                                Gible gible = new Gible();
                                gible.statics();
                                break;
                            }

                        case 2:
                            {
                                Gabite gabite = new Gabite();
                                gabite.statics();
                                break;
                            }
                        case 3:
                            {
                                Garchomp garchomp = new Garchomp();
                                garchomp.statics();
                                break;
                            }
                    }
                }

                catch
                {

                }
            }
        }

    }
    class Pokemon
    {
        public int HP { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }

        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
    }
    class Gible
    {
        Pokemon pokemon = new Pokemon();

        public void statics()
        {
            pokemon.HP = 400;
            pokemon.attack = 500;
            pokemon.defense = 300;
            pokemon.special_attack = 300;
            pokemon.special_defense = 300;
            pokemon.speed = 400;
            Console.WriteLine($"Name: Gible \n HP:{pokemon.HP} \n Attack:{pokemon.attack}");
        }
    }
    class Gabite
    {
        Pokemon pokemon = new Pokemon();

        public void statics()
        {
            pokemon.HP = 400;
            pokemon.attack = 600;
            pokemon.defense = 400;
            pokemon.special_attack = 300;
            pokemon.special_defense = 400;
            pokemon.speed = 500;
            Console.WriteLine($"Name: Gabite \n HP:{pokemon.HP} \n Attack:{pokemon.attack}");
        }
    }
    class Garchomp
    {
        Pokemon pokemon = new Pokemon();

        public void statics()
        {
            pokemon.HP = 700;
            pokemon.attack = 800;
            pokemon.defense = 600;
            pokemon.special_attack = 500;
            pokemon.special_defense = 500;
            pokemon.special_attack = 600;
            pokemon.speed = 600;
            Console.WriteLine($"Name: Garchomp \n HP:{pokemon.HP} \n Attack:{pokemon.attack}");
        }
    }
}
