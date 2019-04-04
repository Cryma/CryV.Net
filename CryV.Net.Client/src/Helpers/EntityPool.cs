using System.Collections.Concurrent;
using CryV.Net.Client.Elements;

namespace CryV.Net.Client.Helpers
{
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

        public static bool ContainsEntity(int id)
        {
            return _entities.ContainsKey(id);
        }

    }
}
