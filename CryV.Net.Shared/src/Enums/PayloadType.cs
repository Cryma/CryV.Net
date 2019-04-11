namespace CryV.Net.Shared.Enums
{
    public enum PayloadType : byte
    {
        None,
        Bootstrap,
        AddClient,
        RemoveClient,
        UpdateClient,
        UpdatePointing
    }
}
