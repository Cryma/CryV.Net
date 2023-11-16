using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads.Helpers;

public static class PayloadHandler
{

    private static readonly IDictionary<PayloadType, Type> _payloadMapping = new Dictionary<PayloadType, Type>();

    static PayloadHandler()
    {
        var payloads = Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof(IPayload).IsAssignableFrom(x) && x.IsInterface == false && x.IsAbstract == false);

        foreach (var payload in payloads)
        {
            var dummyPayload = (IPayload) Activator.CreateInstance(payload)!;

            _payloadMapping.Add(dummyPayload.PayloadType, payload);
        }
    }

    public static TPayload DeserializePayload<TPayload>(byte[] data) where TPayload : IPayload
    {
        return (TPayload) DeserializePayload(typeof(TPayload), data);
    }

    public static IPayload DeserializePayload(Type type, byte[] data)
    {
        using var stream = new MemoryStream(data);
        return (IPayload)Serializer.Deserialize(type, stream);
    }

    public static byte[] SerializePayload<TPayload>(TPayload payload) where TPayload : IPayload
    {
        using var stream = new MemoryStream();
        Serializer.Serialize(stream, payload);

        return stream.ToArray();
    }

    public static Type? GetPayloadByType(PayloadType payloadType)
    {
        if (_payloadMapping.TryGetValue(payloadType, out var type) == false)
        {
            return null;
        }

        return type;
    }
    
}
