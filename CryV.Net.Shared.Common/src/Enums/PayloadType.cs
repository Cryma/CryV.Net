namespace CryV.Net.Shared.Common.Enums;

public enum PayloadType
{
    None,
    Bootstrap,
    BootstrapFinished,
    AddPlayer,
    RemovePlayer,
    UpdatePlayer,
    UpdatePointing,
    StopPointing,
    AddVehicle,
    RemoveVehicle,
    UpdateVehicle,
    RemoteCommand,
    AddSync,
    RemoveSync
}
