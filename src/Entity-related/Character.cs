using System.Collections.Generic;

namespace DefaultNamespace
{
    public abstract class Character
    {
        protected readonly string _name;
        protected readonly string _description;
        protected double _health;
        protected double _stamina;
        protected double _sanity;
        protected List<Effect> _effects;

        protected int Health
        {
            get => this._health;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), " must be greater than 0");
                }

                this._health = value;
            }
        }

        protected int Stamina
        {
            get => this._stamina;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), " must be greater than 0");
                }

                this._stamina = value;
            }
        }

        protected int Sanity
        {
            get => this._sanity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), " must be greater than 0");
                }

                this._sanity = value;
            }
        }

        public List<Effect> Effects
        {
            get { return _effects; }
        }

        public Character(string name, string description, int health, int stamina, int sanity)
        {
            this._name = name;
            this._description = description;
            this.Health = health;
            this.Stamina = stamina;
            this.Sanity = sanity;
            this.Effects = new List<Effect>();
        }
    }
}
