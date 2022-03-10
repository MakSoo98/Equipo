using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemonlibrary
{
    public enum PokemonType
    {
        Fire,
        Grass,
        Water
    }
    public enum SpellType
    {
        Fire,
        Grass,
        Water
    }
   public abstract class Pokemon: IPokemon
    {
        List<ISpell> SpellList = new List<ISpell>();
        private string name;
        private double life, startLife;
        public string GetName()
        {
            return name;
        }
        public abstract PokemonType GetPokemonType();

        public void SetName(string value)
        {
            name=value;
        }

        public double GetLife()
        {
            return this.life;
        }

        public double GetStartLife()
        {
            return this.startLife;
        }
        public void SetStartLife(double value)
        {
           startLife=value;
        }
        public void AddSpell(ISpell s)
        {
            if (s == null)
            { 
                return;
            }
            SpellList.Add(s);
        }
        public ISpell GetSpellAt(int index)
        {
           if(index < 0|| index > SpellList.Count)
            {
                return null;
            }
            else
            {
                return SpellList[index];
            }
        }
        public void LaunchSpell(string name)
        {
            for(int i = 0;i< SpellList.Count;i++)
            {
                if(SpellList[i].Name==name)
                {
                    if (SpellList[i].Energy <= GetLife())
                    {
                        life = life - SpellList[i].Energy;

                        return;
                    }
                    else
                        return;
                }
            }
        }
    }
}
