using Project.BLL.DesignPattern.ServicePattern.IntService;
using Project.BLL.Dtos;
using Project.BLL.Dtos.Categories;
using Project.DAL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.ServicePattern.ConcServices
{
    public class CategoryService 
    {
        CategoryRepository _catRep;

        public CategoryService()
        {
            _catRep = new CategoryRepository();
        }
        public void Add(CreateCategoryDto item)
        {
            item.EndDataDate = DateTime.Now.AddYears(1);
            //Maplemek
            Category c = new Category();
            c.CategoryName = item.CategoryName;
            c.Description = item.Description;
            c.EndDataDate = item.EndDataDate;

            _catRep.Add(c);
        }

       

        public List<ResponseCategoryDto> GetAll()
        {
            return _catRep.GetAll().Select(x => new ResponseCategoryDto
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                CategoryId = x.CategoryId
           
                
            }).ToList();
        }

        public ResponseCategoryDto GetById(int id)
        {
            Category c = _catRep.GetById(id);

            return new ResponseCategoryDto
            {
                CategoryName = c.CategoryName,
                CategoryId = c.CategoryId,
                Description = c.Description
            };
        }

        public string Remove(int id)
        {
            Category c = _catRep.GetById(id);
            if(c== null)
            {
                return "Silmek istediginiz kategori bulunamadı";
            }

            _catRep.Remove(c);
            return "Kategori silindi";
        }

     
        public string Update(UpdateCategoryDto item)
        {
            Category originalCategory = _catRep.GetById(item.CategoryId);
            if (originalCategory == null)
            {
                return "Kategori bulunamadı";
            }

            Category newValues = new Category()
            {
                CategoryName = item.CategoryName,
                Description = item.Description,
                EndDataDate = originalCategory.EndDataDate

            };

           

            _catRep.Update(originalCategory, newValues);
            return "Güncelleme basarılı";
        }

      
      

        
    }
}
