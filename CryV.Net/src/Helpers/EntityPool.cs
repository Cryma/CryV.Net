using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Elements;

namespace CryV.Net.Helpers;

public static class EntityPool
{

    private static readonly ConcurrentDictionary<int, Entity> _entities = new ConcurrentDictionary<int, Entity>();

    public static void AddEntity(Entity entity)
    {
        _entities.TryAdd(entity.Handle, entity);
    }

    public static void RemoveEntity(Entity entity)
    {
        RemoveEntity(entity.Handle);
    }

    public static void RemoveEntity(int id)
    {
        _entities.TryRemove(id, out _);
    }

    public static void Clear()
    {
        foreach (var entity in _entities.Values)
        {
            entity.Delete();
        }

        _entities.Clear();
    }

    public static IList<Entity> GetEntities()
    {
        return _entities.Values.ToList();
    }

    public static bool ContainsEntity(int id)
    {
        return _entities.ContainsKey(id);
    }

}
