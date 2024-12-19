using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WinUI.VmClasses
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage ="Kategori ismi alanı girilmesi zorunlu bir alandır")]
        [MinLength(5,ErrorMessage ="Kategori ismi alanı minimum 5 karakter olmalıdır")]
        
        public string CategoryName { get; set; }


        
        public string Description { get; set; }

        //public string Sifre { get; set; }

        //[Compare("Sifre",ErrorMessage ="Sifreler uyusmuyor")]
        //public string SifreTekrar { get; set; }


    }
}
