using Project.BLL.Dtos;
using Project.BLL.Dtos.Categories;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.ServicePattern.IntService
{
    public interface IService<T> where T: CreateCategoryDto 
    {

        //List Commands
        List<T> GetAll();
        T GetById(int id);

        //Modification
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
