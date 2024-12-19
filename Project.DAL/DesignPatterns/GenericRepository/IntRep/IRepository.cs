using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : class
    {
        //List Commands
        List<T> GetAll();
        T GetById(int id);

        //Modification
        void Add(T item);
        void Remove(T item);
        void Update(T originalItem, T newItem);
    }
}
