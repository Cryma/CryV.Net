using System.Collections.Generic;
using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IEntityPool
    {

        void AddEntity(Entity entity);
        void RemoveEntity(Entity entity);
        void RemoveEntity(int id);
        void Clear();
        ICollection<Entity> GetEntities();
        bool ContainsEntity(int id);

    }
}