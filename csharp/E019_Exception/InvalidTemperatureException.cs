using System;

namespace E019_Exception
{
    public class InvalidTemperatureException : Exception
    {
        public InvalidTemperatureException(string message) : base(message)
        {
            
        }
    }
}