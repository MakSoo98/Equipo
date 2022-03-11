using System;

namespace Pokemonlibrary
{
    public interface ISpell
    {
        string Name 
        { 
            get 
            { 
                return GetName(); 
            } 
            set
            {
                SetName(value);
            }
        }

        double Energy 
        { 
            get 
            { 
                return GetEnergy(); 
            }

            set
            {
                SetEnergy(value);
            }
        }
        SpellType Type 
        { 
            get 
            { 
                return GetSpellType(); 
            }
            set
            {
                SetSpellType(value);
            }
        }

        public string GetName();

        public void SetName(string value);

        public double GetEnergy();

        public void SetEnergy(double value);

        public SpellType GetSpellType();

        public void SetSpellType(SpellType value);


    }
}
