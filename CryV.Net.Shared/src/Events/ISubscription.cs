namespace CryV.Net.Shared.Events
{
    public interface ISubscription
    {

        void Invoke(object arguments);

    }
}
