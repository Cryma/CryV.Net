using System.Numerics;

namespace CryV.Net.Shared.Common.Interfaces
{
    public interface ISharedEntity
    {

        int Id { get; }

        Vector3 Position { get; set; }

        Vector3 Rotation { get; set; }

        Vector3 Velocity { get; set; }

        ulong Model { get; set; }

    }
}
