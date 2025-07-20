namespace DefaultNamespace
{
    public abstract class Effect
    {
        protected readonly string _name;
        protected readonly string _description;
        protected readonly Stackability _stackability;
        protected int _turnsLeft;

        protected int TurnsLeft
        {
            get { return _turnsLeft; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), " must be greater than 0");

                if (value > this._turnsLeft && this._stackable == Stacka.NonStackable)
                    this._turnsLeft = value;
                if (this._stackability == Stackability.Stackable)
                    this._turnsLeft += value;
            }
        }

        public Effect(string name, string description, Stackable stackable, int turnsLeft)
        {
            this._name = name;
            this._description = description;
            this._stackable = stackable;
            this.TurnsLeft = turnsLeft;
        }

        protected bool DecreaseTurn()
        {
            this._turnsLeft--;

            return this._turnsLeft == 0;
        }

        public abstract void TakeEffect();
    }
}