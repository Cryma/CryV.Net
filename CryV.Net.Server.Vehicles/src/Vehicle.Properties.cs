using System.Numerics;

namespace CryV.Net.Server.Vehicles
{
    public partial class Vehicle
    {

        public int Id { get; }

        public Vector3 Position
        {
            get => _position;
            set
            {
                _position = value;
                ForceSync();
            }
        }

        private Vector3 _position;

        public Vector3 Velocity
        {
            get => _velocity;
            set
            {
                _velocity = value;
                ForceSync();
            }
        }

        private Vector3 _velocity;

        public Vector3 Rotation
        {
            get => _rotation;
            set
            {
                _rotation = value;
                ForceSync();
            }
        }

        private Vector3 _rotation;

        public float EngineHealth
        {
            get => _engineHealth;
            set
            {
                _engineHealth = value;
                ForceSync();
            }
        }

        private float _engineHealth = 1000.0f;

        public string NumberPlate
        {
            get => _numberPlate;
            set
            {
                _numberPlate = value;
                ForceSync();
            }
        }

        private string _numberPlate;

        public ulong Model
        {
            get => _model;
            set
            {
                _model = value;
                ForceSync();
            }
        }

        private ulong _model;

        public bool EngineState
        {
            get => _engineState;
            set
            {
                _engineState = value;
                ForceSync();
            }
        }

        private bool _engineState;

        public byte CurrentGear
        {
            get => _currentGear;
            set
            {
                _currentGear = value;
                ForceSync();
            }
        }

        private byte _currentGear;

        public float CurrentRPM
        {
            get => _currentRPM;
            set
            {
                _currentRPM = value;
                ForceSync();
            }
        }

        private float _currentRPM;

        public float Clutch
        {
            get => _clutch;
            set
            {
                _clutch = value;
                ForceSync();
            }
        }

        private float _clutch;

        public float Turbo
        {
            get => _turbo;
            set
            {
                _turbo = value;
                ForceSync();
            }
        }

        private float _turbo;

        public float Acceleration
        {
            get => _acceleration;
            set
            {
                _acceleration = value;
                ForceSync();
            }
        }

        private float _acceleration;

        public float Brake
        {
            get => _brake;
            set
            {
                _brake = value;
                ForceSync();
            }
        }

        private float _brake;

        public float SteeringAngle
        {
            get => _steeringAngle;
            set
            {
                _steeringAngle = value;
                ForceSync();
            }
        }

        private float _steeringAngle;

        public int ColorPrimary
        {
            get => _colorPrimary;
            set
            {
                _colorPrimary = value;
                ForceSync();
            }
        }

        private int _colorPrimary = 112;

        public int ColorSecondary
        {
            get => _colorSecondary;
            set
            {
                _colorSecondary = value;
                ForceSync();
            }
        }

        private int _colorSecondary = 112;

        public bool IsHornActive
        {
            get => _isHornActive;
            set
            {
                _isHornActive = value;
                ForceSync();
            }
        }

        private bool _isHornActive;

        public bool IsBurnout
        {
            get => _isBurnout;
            set
            {
                _isBurnout = value;
                ForceSync();
            }
        }

        private bool _isBurnout;

        public bool IsRoofUp
        {
            get => _isRoofUp;
            set
            {
                _isRoofUp = value;
                ForceSync();
            }
        }

        private bool _isRoofUp;

        public bool IsRoofLowering
        {
            get => _isRoofLowering;
            set
            {
                _isRoofLowering = value;
                ForceSync();
            }
        }

        private bool _isRoofLowering;

        public bool IsRoofDown
        {
            get => _isRoofDown;
            set
            {
                _isRoofDown = value;
                ForceSync();
            }
        }

        private bool _isRoofDown;

        public bool IsRoofRaising
        {
            get => _isRoofRaising;
            set
            {
                _isRoofRaising = value;
                ForceSync();
            }
        }

        private bool _isRoofRaising;

        public bool IsSirenActive
        {
            get => _isSirenActive;
            set
            {
                _isSirenActive = value;
                ForceSync();
            }
        }

        private bool _isSirenActive;

    }
}
