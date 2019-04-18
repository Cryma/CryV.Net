using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;

namespace CryV.Net.Client.EntityPool
{
    public class EntityPool : IEntityPool
    {

        private static readonly ConcurrentDictionary<int, Entity> _entities = new ConcurrentDictionary<int, Entity>();

        public void AddEntity(Entity entity)
        {
            _entities.TryAdd(entity.Handle, entity);
        }

        public void RemoveEntity(Entity entity)
        {
            RemoveEntity(entity.Handle);
        }

        public void RemoveEntity(int id)
        {
            _entities.TryRemove(id, out _);
        }

        public void Clear()
        {
            foreach (var entity in _entities.Values)
            {
                ThreadHelper.Run(() =>
                {
                    entity.Delete();
                });
            }

            _entities.Clear();
        }

        public ICollection<Entity> GetEntities()
        {
            return _entities.Values.ToList();
        }

        public bool ContainsEntity(int id)
        {
            return _entities.ContainsKey(id);
        }

    }
}
