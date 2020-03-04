using System;
using System.Collections.Generic;
using domain.Entities;

namespace infra.Repositories
{
  public abstract class BaseRepository<T> where T : BaseEntity
  {
    private static Dictionary<Guid, T> Table;

    public BaseRepository()
    {
      Table = new Dictionary<Guid, T>();
    }

    public virtual Guid Add(T value)
    {

      Guid id = Guid.NewGuid();
      value.Id = id;
      Table.Add(id, value);

      return id;

    }

    public virtual IEnumerable<T> GetAll()
    {

      List<T> col = new List<T>();

      foreach (KeyValuePair<Guid, T> item in Table)
      {
        col.Add(item.Value);
      }
      return col;
    }

    public virtual T Get(Guid id)
    {

      T item;

      if (Table.TryGetValue(id, out item))
      {
        return item;
      }
      else throw new Exception("Item Não Encontrado!");

    }

  }
}