namespace CryV.Net.Client.Elements
{
    public class Ped
    {

        private readonly int _handle;

        public Ped(int handle)
        {
            _handle = handle;
        }

        public static implicit operator int(Ped ped)
        {
            return ped._handle;
        }

    }
}