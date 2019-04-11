using System;

namespace CryV.Net.Shared.Events
{
    public interface ISubscription
    {

        Type EventType { get; }

        void Invoke(object arguments);

    }
}
