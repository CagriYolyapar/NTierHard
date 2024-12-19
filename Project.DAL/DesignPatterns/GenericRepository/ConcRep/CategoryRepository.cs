using Project.DAL.ContextClasses;
using Project.DAL.DesignPatterns.GenericRepository.IntRep;
using Project.DAL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.GenericRepository.ConcRep
{
    //Data Access Logic
    public class CategoryRepository : IRepository<Category>
    {
        MyContext _db;

        public CategoryRepository()
        {
            _db = DBTool.DbInstance;
        }
        public void Add(Category item)
        {
            _db.Categories.Add(item);
            _db.SaveChanges();
        }

    

        public List<Category> GetAll()
        {
           return _db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _db.Categories.Find(id);
        }

        public void Remove(Category item)
        {
            

            _db.Categories.Remove(item);
            _db.SaveChanges();

        }

        public void Update(Category item,Category newItem)
        {
            _db.Entry(item).CurrentValues.SetValues(newItem);
            _db.SaveChanges();
        }
    }
}
