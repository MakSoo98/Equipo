using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemonlibrary
{
    public interface IPokemon
    {
        //
        
        string Name 
        {
            get => GetName();
       
            set => SetName(value);
        }

        double Life
        {
            get => GetLife();
        }

        double StartLife 
        {
            get => GetStartLife();

            set => SetStartLife(value);
        }

        PokemonType PokemonType
        {
            get => GetPokemonType();
        }

        public string GetName();

        public void SetName(string value);

        public double GetLife();

        public double GetStartLife();

        public void SetStartLife(double value);

        public PokemonType GetPokemonType();

        public void AddSpell(ISpell s);

        public ISpell GetSpellAt(int index);

        public void LaunchSpell(string name);

    }
}
