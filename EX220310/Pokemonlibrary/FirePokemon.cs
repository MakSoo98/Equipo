using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemonlibrary
{
    public class FirePokemon:Pokemon
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Fire;
        }
    }
}
