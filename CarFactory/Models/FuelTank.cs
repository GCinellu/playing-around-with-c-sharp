using CarFactory.Interfaces;

namespace CarFactory.Models
{
    public class FuelTank : IFuelTank
    {
        private double _fillLevel;
        private bool _isComplete;
        private bool _isOnReserve;
        
        public double FillLevel
        {
            get => _fillLevel;
        }

        public bool IsComplete
        {
            get => _isComplete;
        }

        public bool IsOnReserve
        {
            get => _isOnReserve;
        }

        public void Consume(double liters)
        {
            _fillLevel -= liters;
            if (_fillLevel < 60)
            {
                _isComplete = false;
            }

            if (_fillLevel < 5)
            {
                _isOnReserve = true;
            }
        }

        public void Refuel(double liters)
        {
            _fillLevel += liters;

            if (_fillLevel >= 60)
            {
                _isComplete = true;
            }

            if (_fillLevel >= 5)
            {
                _isOnReserve = false;
            }
        }
    }
}