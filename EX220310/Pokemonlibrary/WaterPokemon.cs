using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemonlibrary
{
    public class WaterPokemon : Pokemon
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Water;
        }
    }
}
