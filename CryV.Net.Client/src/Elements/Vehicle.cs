namespace CryV.Net.Client.Elements
{
    public class Vehicle
    {

        private readonly int _handle;

        public Vehicle(int handle)
        {
            _handle = handle;
        }

        public static implicit operator int(Vehicle vehicle)
        {
            return vehicle._handle;
        }

    }
}
