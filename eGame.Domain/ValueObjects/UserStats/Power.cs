namespace eGame.Domain.ValueObjects.UserStats
{

    public struct Power
    {
        private int _value;
        private DateTime _lastIncreasedAt;

        public int Value
        {
            get => _value;
            private set => _value = value >= 0 ? value : throw new ArgumentException("Power cannot be negative.");
        }

        public Power(int value)
        {
            this._value = 0;
            _lastIncreasedAt = DateTime.MinValue;
            IncreasePower(value);
        }

        public void IncreasePower(int value)
        {
            if (value % 20 != 0)
                throw new ArgumentException("Power can only be increased by 20.");

            var today = DateTime.Today;
            if (today == _lastIncreasedAt.Date)
                throw new ArgumentException("Power can only be increased once per day.");

            _value += value;
            _lastIncreasedAt = today;
        }
    }
}