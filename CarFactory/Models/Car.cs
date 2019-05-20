using System;
using System.Diagnostics;
using CarFactory.Interfaces;

namespace CarFactory.Models
{
    public class Car : ICar
    {
        public IFuelTankDisplay fuelTankDisplay;

        private IEngine engine = new Engine();

        private IFuelTank _fuelTank = new FuelTank();

        private bool _engineIsRunning;

        public Car()
        {
            _engineIsRunning = engine.IsRunning;
            _fuelTank.Refuel(20);
        }

        public Car(double fuelLevel)
        {
            _engineIsRunning = engine.IsRunning;
            _fuelTank.Refuel(fuelLevel);
            
            ////// TODO: this throws an error
//            fuelTankDisplay.FillLevel = _fuelTank.FillLevel;
        }

        public void EngineStart()
        {
            engine.Start();
            _engineIsRunning = engine.IsRunning;
        }

        public void EngineStop()
        {
            engine.Stop();
            _engineIsRunning = engine.IsRunning;
        }

        public void Consume(double liters)
        {
            _fuelTank.Consume(liters);
        }

        public void Refuel(double liters)
        {
            _fuelTank.Refuel(liters);
        }

        public bool EngineIsRunning
        {
            get { return _engineIsRunning; }
        }

        public void RunningIdle()
        {
            double consumptionPerSecond = 0.0003;
            Consume(consumptionPerSecond);
        }
    }
}