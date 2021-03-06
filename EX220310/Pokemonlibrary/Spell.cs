using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemonlibrary
{
   public class Spell: ISpell
    {
        private string name;
        private double energy;
        private SpellType spellType;

        public Spell()
        {

        }

        public Spell(string name, double energy, SpellType spellType)
        {

        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public double GetEnergy()
        {
            return this.energy;
        }

        public void SetEnergy(double value)
        {
            energy = value;
        }

        public SpellType GetSpellType()
        {
            return spellType;
        }

        public void SetSpellType(SpellType value)
        {
            spellType = value;
        }
    }
}
