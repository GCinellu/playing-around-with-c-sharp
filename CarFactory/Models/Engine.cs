using CarFactory.Interfaces;

namespace CarFactory.Models
{
    public class Engine : IEngine
    {
        private bool _isRunning;
        
        public bool IsRunning
        {
            get { return _isRunning; }
        }
        
        public void Start()
        {
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }

        public void Consume(double liters)
        {
            
        }

        public Engine()
        {
            _isRunning = false;
        }
    }
}