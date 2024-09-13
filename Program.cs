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
            pokemon.special_defense = 0;
            pokemon.speed = 0;
        }
    }
}
