using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Vehicles
{
    public class VehicleManager : IVehicleManager, IStartable
    {

        public IPlayerManager PlayerManager { get; set; }

        private readonly IEventHandler _eventHandler;

        private readonly ConcurrentDictionary<int, IVehicle> _vehicles = new ConcurrentDictionary<int, IVehicle>();

        private readonly Random _random = new Random();

        private readonly char[] _numberPlateCharacters =
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        public VehicleManager(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Start()
        {
        }

        public IVehicle AddVehicle(Vector3 position, Vector3 rotation, ulong model, string numberPlate)
        {
            var id = GetFreeId();

            if (numberPlate == null)
            {
                numberPlate = GenerateNumberPlate("CRYV-");
            }

            var vehicle = new Vehicle(this, _eventHandler, PlayerManager, id, position, rotation, model, numberPlate);

            _vehicles.TryAdd(id, vehicle);

            return vehicle;
        }

        public void RemoveVehicle(int vehicleId)
        {
            if (_vehicles.TryRemove(vehicleId, out var vehicle) == false)
            {
                return;
            }

            vehicle.Dispose();
        }

        public IVehicle GetVehicle(int vehicleId)
        {
            if (_vehicles.TryGetValue(vehicleId, out var vehicle) == false)
            {
                return null;
            }

            return vehicle;
        }

        public ICollection<IVehicle> GetVehicles()
        {
            return _vehicles.Values;
        }

        private string GenerateNumberPlate(string prefix = "", bool numbersOnly = false)
        {
            if (prefix.Length > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(prefix), "Prefix must be 0 to 8 characters long");
            }

            var text = prefix;

            for (var i = text.Length; i < 8; i++)
            {
                if (numbersOnly)
                {
                    text += _numberPlateCharacters[_random.Next(0, 9)];
                }
                else
                {
                    text += _numberPlateCharacters[_random.Next(0, _numberPlateCharacters.Length)];
                }
            }

            return text;
        }

        private int GetFreeId()
        {
            return Enumerable.Range(0, int.MaxValue)
                .Except(_vehicles.Keys.ToArray())
                .First();
        }

    }
}
