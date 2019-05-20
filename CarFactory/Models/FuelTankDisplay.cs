using CarFactory.Interfaces;

namespace CarFactory.Models
{
    public class FuelTankDisplay : IFuelTankDisplay
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
     }
}