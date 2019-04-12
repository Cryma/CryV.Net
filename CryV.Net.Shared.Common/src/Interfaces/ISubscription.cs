using System;

namespace CryV.Net.Shared.Common.Interfaces
{
    public interface ISubscription
    {
        Type EventType { get; }

        void Invoke(object arguments);
    }
}
