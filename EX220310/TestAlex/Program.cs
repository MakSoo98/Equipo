using System;
using Pokemonlibrary;




namespace TestAlex
{
    class Program
    {
        public static void test1()
        {
            ISpell s = new Spell();
        }

        public static void test2()
        {
            IPokemon p = new WaterPokemon();
        }

        public static void test3()
        {
            ISpell s = new Spell();
            IPokemon p = new WaterPokemon();

            for(int i = 0; i < 10; i++)
            {
                int n = p.AddSpell().Count
                
                    if(n =! 0)
            }

        }

        static void Main(string[] args)
        {
            
            
        }

    }
}
