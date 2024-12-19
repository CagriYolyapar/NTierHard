using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Dtos.Categories
{
    public class CreateCategoryDto : BaseDto
    {
        
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime? EndDataDate { get; set; }

    }
}
