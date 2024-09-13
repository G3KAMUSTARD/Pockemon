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
            
        }
    }
}
